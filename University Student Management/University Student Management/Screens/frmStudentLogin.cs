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
using MySql.Data.MySqlClient;
using University_Student_Management.Screens.Templates;

namespace University_Student_Management.Screens
{
    public partial class frmStudentLogin : frmTemplates
    {
        String StudentId;
        public frmStudentLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentSignUP_Click(object sender, EventArgs e)
        {
            frmRegStudent frm = new frmRegStudent();
            frm.Show();
            this.Hide();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
        
            SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Student where ID='"+textBoxStudentID.Text.Trim()+"' and Password ='"+textBoxStudentPass.Text.Trim()+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                StudentId = textBoxStudentID.Text;
                frmStudentMain frm = new frmStudentMain(StudentId);
                this.Hide();
                frm.Show();
            }
            else if (textBoxStudentID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Student ID is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStudentID.Clear();
                textBoxStudentID.Focus();
            }
                
             else if (textBoxStudentPass.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxStudentPass.Clear();
                    textBoxStudentPass.Focus();

                }
        
            else
            {
                MessageBox.Show("Student ID or Password is Invalid  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmStudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
             frm.Show();
            this.Hide();
        }
    }
}
