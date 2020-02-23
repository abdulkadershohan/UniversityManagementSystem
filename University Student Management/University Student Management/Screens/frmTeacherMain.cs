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
using System.Data.SqlClient;

namespace University_Student_Management.Screens
{
    public partial class frmTeacherMain : frmTemplates
    {
        
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";

        string TeacherID,name;
        string name_;
        string phone_;
        string email_;
    

        public frmTeacherMain(string TeacherID)
        {
          
            InitializeComponent();
          
            this.TeacherID = TeacherID;
            labelView();
            ViewDataGit();
            dataGridView1.Enabled = false;
             teacherProfile();
            countCourse();
        }
        public void labelView()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Teacher Where ID='" + TeacherID + "'", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow data in dt.Rows)
                {
                    name = (string)data["Name"];
                }
                labelTeacher1.Text =name;
                labelTeacher1.Refresh();
            }
        }

      

        private void frmTeacherMain_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUpdate frm = new frmUpdate(TeacherID);
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void labelTeacher1_Click(object sender, EventArgs e)
        {

        }

        public void ViewDataGit()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Teach,Present_Course Where Present_Course.Course_Code=Teach.Course_Code AND  Teach.ID='" + TeacherID + "'", sqlcon);
                DataTable dt = new DataTable();
               adapter.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;

            }
           
        }
        public void teacherProfile()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
               
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Teacher Where ID='" + TeacherID + "'", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow data in dt.Rows)
                {
                    name_ = (String)data["Name"];
                    email_ = (String)data["Email"];
                    phone_ = (String)data["Phone"];
                }
                labelName.Text ="Name : " +name_;
                labelEmail.Text = "Email : "+email_;
                LabelPhone.Text = "Phone : " +phone_;

            }

        }
        public void countCourse()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Teach Where ID='" + TeacherID + "'", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int count = dt.Rows.Count;
                 labelCourseCount.Text = "Number of Courses = " + count;
            }




        }


    }
}
