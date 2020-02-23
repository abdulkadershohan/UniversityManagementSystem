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
    public partial class frmStudentMain : frmTemplates
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
        string name;
        String StudentId;
        public frmStudentMain()
        {
            InitializeComponent();
        }
        public frmStudentMain(String StudentId)
        {
            InitializeComponent();
            this.StudentId = StudentId;
            click();
        }

        private void btnRoutine_Click(object sender, EventArgs e)
        {
            frmRoutine frm = new frmRoutine(StudentId);
            frm.Show();
            this.Hide();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            frmSummary frm = new frmSummary(StudentId);
            frm.Show();
            this.Hide();
        }

        private void frmStudentMain_Load(object sender, EventArgs e)
        {

        }
        private void click()
        {
          using (SqlConnection sqlcon =new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Student Where Student.ID='" + StudentId + "'", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach(DataRow data in dt.Rows)
                {
                    name = (string)data["Name"];
                }
                labelStudentNameD.Text = name;
                labelStudentNameD.Refresh();
            }
        }

        private void btnPresentCourse_Click(object sender, EventArgs e)
        {
            frmPresentCourse frm = new frmPresentCourse(StudentId);
            frm.Show();
            this.Hide();
        }

        private void btnPreviousCourse_Click(object sender, EventArgs e)
        {
          
            frmPreviousCourse frm = new frmPreviousCourse(StudentId);
            frm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }
    }
}
