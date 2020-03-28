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
    
    public partial class frmTeacherLogin : frmTemplates
    {
        string TeacherID;
        public frmTeacherLogin()
        {
            InitializeComponent();
        }

        private void btnTeacherSignUP_Click(object sender, EventArgs e)
        {
            frmRegTeacher frm = new frmRegTeacher();
            frm.Show();
            this.Hide();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            string pass = textBoxTeacherPass.Text;
            int len = pass.Length;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Teacher where ID='" + textBoxTeacherID.Text.Trim() + "' and Password ='" + textBoxTeacherPass.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
           
            if (textBoxTeacherID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Teacher ID is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTeacherID.Clear();
                textBoxTeacherID.Focus();
            }

            else if (textBoxTeacherPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTeacherPass.Clear();
                textBoxTeacherPass.Focus();

            }
            else if(len<8)
            {
                MessageBox.Show("Password Must Be 8 Digit");
            }
            else if (table.Rows.Count == 1)
            {
                TeacherID = textBoxTeacherID.Text;
                frmTeacherMain frm = new frmTeacherMain(TeacherID);
                this.Hide();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Teacher ID or Password is Invalid  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();

        }

        private void frmTeacherLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
