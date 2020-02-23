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
    public partial class frmSummary : frmTemplates
    {
        String StudentID, name, dept, email, intake, phone;
        double CountTotalCgpa = 0,CountTotalCredit=0,total,credit;
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentMain frm = new frmStudentMain(StudentID);
            frm.Show();
            this.Hide();



        }

        private void presentCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoutine frm = new frmRoutine(StudentID);
            frm.Show();
            this.Hide();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentCourse frm = new frmPresentCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        private void prToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreviousCourse frm = new frmPreviousCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        public frmSummary()
        {
            InitializeComponent();


        }
        public frmSummary(String StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;

            Operation();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Operation()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Student where Student.ID='" + StudentID + "'", sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                foreach (DataRow data in dt.Rows)
                {
                    StudentID = (String)data["ID"];
                    name = (String)data["Name"];
                    dept = (String)data["Department"];
                    email = (String)data["Email"];
                    intake = (String)data["Intake_Sec"];
                    phone = (String)data["Phone"];
                }

                labelStudentID.Text = StudentID;
                labelStudentName.Text = name;
                labelStudentEmail.Text = email;
                labelStudentPn.Text = phone;
                labelIntakeSec.Text = intake;
                GetCGPA();
                labelCGPA.Text = CountTotalCgpa.ToString("0.00");



            }
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {

        }
        public void GetCGPA()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select Previous_Course_Marks.Total,Previous_Course.Credit from Previous_Course_Marks,Previous_Course where Previous_Course_Marks.ID='" + StudentID + "' AND Previous_Course_Marks.Course_Code=Previous_Course.Course_Code ", sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
               // dataGridView1.DataSource = dt;
                foreach (DataRow data in dt.Rows)
                {
                    total = (double)data["total"];
                    credit = (double)data["Credit"];
                    function(total,credit);
                }
                CountTotalCgpa = CountTotalCgpa / CountTotalCredit;
               
            }
        }
        public void function(double total,double credit)
        {
            CountTotalCredit = credit + CountTotalCredit;
            if(total>=80)
            {
                CountTotalCgpa = (credit * 4)+ CountTotalCgpa;
            }
            else if(total>=75)
            {
                CountTotalCgpa = (credit * 3.75) + CountTotalCgpa;
            }
            else if (total >= 70)
            {
                CountTotalCgpa = (credit * 3.50) + CountTotalCgpa;
            }
            else if (total >=65)
            {
                CountTotalCgpa = (credit * 3.25) + CountTotalCgpa;
            }
            else if (total >= 60)
            {
                CountTotalCgpa = (credit * 3) + CountTotalCgpa;
            }
            else if (total >=55)
            {
                CountTotalCgpa = (credit * 2.75) + CountTotalCgpa;
            }
            else if (total >= 50)
            {
                CountTotalCgpa = (credit * 2.50) + CountTotalCgpa;
            }
            else if (total >= 45)
            {
                CountTotalCgpa = (credit * 2.25) + CountTotalCgpa;
            }
            else if (total >= 40)
            {
                CountTotalCgpa = (credit * 2) + CountTotalCgpa;
            }
            else
            {
                CountTotalCgpa = (credit * 0) + CountTotalCgpa;
            }
            
        }
    }
}
