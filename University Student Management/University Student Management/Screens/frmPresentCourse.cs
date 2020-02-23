using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_Student_Management.Screens.Templates;

namespace University_Student_Management.Screens
{
    
    public partial class frmPresentCourse : frmTemplates
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
        string StudentID;
        
        public frmPresentCourse()
        {
            InitializeComponent();
        }
        public frmPresentCourse(string StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;
            ForShow_Data();
            panel1.Enabled = false;
           
        }
     
        public void ForShow_Data()
        {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
                {
                  dataGridViewPresent.Enabled = false;
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Present_Course,Present_Course_Marks where Present_Course.Course_Code=Present_Course_Marks.Course_Code and Present_Course_Marks.ID='" + StudentID  +"'", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    dataGridViewPresent.AutoGenerateColumns = false;
                    dataGridViewPresent.DataSource = dt;

                
                }
            
        }


        private void PresentCourse_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStudentMain frm = new frmStudentMain(StudentID);
            frm.Show();
            this.Hide();
        }

        private void summaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSummary frm = new frmSummary(StudentID);
            frm.Show();
            this.Hide();
        }

        private void presentCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoutine frm = new frmRoutine(StudentID);
            frm.Show();
            this.Hide();
        }

        private void previousCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreviousCourse frm = new frmPreviousCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
