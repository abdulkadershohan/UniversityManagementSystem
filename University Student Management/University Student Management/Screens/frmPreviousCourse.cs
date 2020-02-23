using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Student_Management.Screens.Templates;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace University_Student_Management.Screens
{
    public partial class frmPreviousCourse : frmTemplates
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
        int _bool=0;
        string StudentID;
        public frmPreviousCourse()
        {
            InitializeComponent();
        }
        public frmPreviousCourse(string StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            isNotFoundInPrevious_Mark();
            ForShow_Data();
            panel1.Enabled = false;

        }

        private void frmPreviousCourse_Load(object sender, EventArgs e)
        {

        }
        public void isNotFoundInPrevious_Mark()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                string query = "Select * from Previous_Course_Marks where Previous_Course_Marks.ID='" + StudentID + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query,ConnectionString );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count >=1)
                {
                    _bool = 10;
                }
            }



        }
        public void ForShow_Data()
        {
            if(_bool!=0)
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Previous_Course,Previous_Course_Marks where Previous_Course.Course_Code=Previous_Course_Marks.Course_Code and ID='" + StudentID + "'", sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataGridViewPrevious.AutoGenerateColumns = false;
                dataGridViewPrevious.DataSource=dt;

            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Previous_Course", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridViewPrevious.AutoGenerateColumns = false;
                    dataGridViewPrevious.DataSource = dt;

                }
            }
            

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentMain frm = new frmStudentMain(StudentID);
            frm.Show();
            this.Hide();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummary frm = new frmSummary(StudentID);
            frm.Show();
            this.Hide();
        }

        private void presentCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentCourse frm = new frmPresentCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        private void routineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoutine frm = new frmRoutine(StudentID);
            frm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
