using System;
using System.Data;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        DataTable courseTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataTable();
        }

        private void SetupDataTable()
        {
            courseTable.Columns.Add("Course Code", typeof(string));
            courseTable.Columns.Add("Course Name", typeof(string));
            courseTable.Columns.Add("Obtained Marks", typeof(int));
            courseTable.Columns.Add("Grade", typeof(string));
            courseTable.Columns.Add("Status", typeof(string));
            dataGridView1.DataSource = courseTable;
        }

        private void AddCourse()
        {
            string courseCode = txtCourseCode.Text;
            string courseName = txtCourseName.Text;
            int obtainedMarks;

            if (!int.TryParse(txtObtainedMarks.Text, out obtainedMarks))
            {
                MessageBox.Show("Please enter a valid number for Obtained Marks.");
                return;
            }

            string grade;
            string status;
            if(obtainedMarks >=90)
            {
                grade = "A+";
                status = "Pass";
            }

            else if (obtainedMarks >= 85)
            {
                grade = "A";
                status = "Pass";
            }
            else if (obtainedMarks >= 70)
            {
                grade = "B";
                status = "Pass";
            }
            else if (obtainedMarks >= 50)
            {
                grade = "C";
                status = "Pass";
            }
            else
            {
                grade = "F";
                status = "Fail";
            }

            courseTable.Rows.Add(courseCode, courseName, obtainedMarks, grade, status);
            txtCourseCode.Clear();
            txtCourseName.Clear();
            txtObtainedMarks.Clear();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            AddCourse();
        }
    }
}
