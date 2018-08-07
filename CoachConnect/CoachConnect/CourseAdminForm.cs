// <copyright file="CourseAdminForm.cs" company="Adam J. Smith at NWTC">
//     Copyright 2018 Smithbucks Computing (Adam J. Smith, radarsmith83@gmail.com)
// </copyright>
namespace CoachConnect
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Declaration for the <see cref="CourseAdminForm"/> class.
    /// </summary>|
    public partial class CourseAdminForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CourseAdminForm"/> class.
        /// </summary>
        public CourseAdminForm()
        {
            this.InitializeComponent();
        }
  
        /// <summary>
        /// Maximizes Form and displays the users with load event of the form.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CourseAdminFormLoad(object sender, EventArgs e)
        {
            this.DisplayDepartments();
            this.DisplayCourses();
        }

        /// <summary>
        /// Method to display the list of users
        /// </summary>
        private void DisplayDepartments()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var departmentQuery = from departments in context.Departments
                        orderby departments.DepartmentName
                        select departments;

                    // Convert query results to list
                    List<Department> departmentList = departmentQuery.ToList();

                    // Set combo box data source and update data member settings
                    this.cbxDepartment.DataSource = departmentList;
                    this.cbxDepartment.ValueMember = "DepartmentID";
                    this.cbxDepartment.DisplayMember = "DepartmentName";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to display the list of courses
        /// </summary>
        private void DisplayCourses()
        {
            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query user table in database and returns the list of the users in ascending order according to last name
                    var courseQuery = from courses in context.CourseListings
                        orderby courses.CourseID ascending
                        select courses;

                    // Convert query results to list
                    List<CourseListing> courseList = courseQuery.ToList();

                    // Set combo box data source and update data member settings
                    this.cbxChooseCourse.DataSource = courseList;
                    this.cbxChooseCourse.ValueMember = "CourseID";
                    this.cbxChooseCourse.DisplayMember = "CourseListID";
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clear all data fields
        /// </summary>
        private void ClearAllFields()
        {
            // Clearing check boxes and text boxes.
            this.txtCourseID.Clear();
            this.txtCourseName.Clear();
            this.chkActive.Checked = false;
            this.cbxDepartment.SelectedIndex = -1;
            this.cbxChooseCourse.SelectedIndex = -1;
        }

        /// <summary>
        /// Populates the combo boxes and text boxes with the selected user's information
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void CbxChooseCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxChooseCourse.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                using (var context = new db_sft_2172Entities())
                {
                    // Query obtains the user ID from the combo box
                    string courseId = this.cbxChooseCourse.SelectedValue.ToString();

                    // Find the user in the database
                    var courseQuery = from course in context.Courses
                        where course.CourseID.Equals(courseId)
                        select course;

                    // If the query returns a user, display the corresponding info in the form
                    if (courseQuery.Any())
                    {
                        var courseResult = courseQuery.FirstOrDefault();

                        if (courseResult != null)
                        {
                            this.txtCourseID.Text = courseResult.CourseID;
                            this.txtCourseName.Text = courseResult.CourseName;
                            this.chkActive.Checked = courseResult.IsActive;
                            this.cbxDepartment.SelectedValue = courseResult.DepartmentID;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Add button clears all text boxes and check boxes so user can enter new information.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            this.ClearAllFields();
        }

        /// <summary>
        /// Submit button sends the added or updated info to the database.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            try
            {
                // Run query to check for a corresponding user in the database
                using (var context = new db_sft_2172Entities())
                {
                    string courseId = this.txtCourseID.Text;
                    var courseQuery = from course in context.Courses
                                    where course.CourseID.Equals(courseId)
                                    select course;

                    if (courseQuery.Any())
                    {
                        var courseResult = courseQuery.FirstOrDefault();

                        if (courseResult != null)
                        {
                            courseResult.CourseID = this.txtCourseID.Text;
                            courseResult.CourseName = this.txtCourseName.Text;
                            courseResult.Department = (Department)this.cbxDepartment.SelectedItem;
                            courseResult.IsActive = this.chkActive.Checked;
                        }

                        context.SaveChanges();
                        this.DisplayCourses();
                        MessageBox.Show(@"Course Updated");
                    }
                    else
                    {
                        Course newCourse = new Course
                        {
                            CourseID = this.txtCourseID.Text,
                            CourseName = this.txtCourseName.Text,
                            Department = (Department)this.cbxDepartment.SelectedItem,
                            IsActive = true
                        };

                        context.Courses.Add(newCourse);
                        context.SaveChanges();
                        MessageBox.Show(@"Course Added");

                        // If save is successful, update the user list and display the new user profile
                        this.DisplayCourses();
                        this.cbxChooseCourse.SelectedValue = newCourse.CourseID;
                    }
                }
            }
            catch (DbUpdateException dbUEx)
            {
                MessageBox.Show(dbUEx.InnerException != null ? dbUEx.InnerException.Message : dbUEx.Message);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.InnerException != null ? sqlEx.InnerException.Message : sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// A method to disable a selected user
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void BtnMinusClick(object sender, EventArgs e)
        {
            this.chkActive.Checked = false;
        }
    }
}