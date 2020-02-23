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
    public partial class frmRegStudent : frmTemplates
    {
        string ConncetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";

        public frmRegStudent()
        {
            InitializeComponent();
        }

        private void btnStudentRegCancle_Click(object sender, EventArgs e)
        {
            frmStudentLogin frm = new frmStudentLogin();
            frm.Show();
            this.Hide();
        }

        private void btnStudentRegSubmit_Click(object sender, EventArgs e)
        {
            string id = textBoxStudentID.Text;
            int id_ = id.Length;
            string dept = textBoxDept.Text;
            bool dept_ = dept.Contains("CSE") || dept.Contains("BBA") || dept.Contains("TEXT") || dept.Contains("ENG") || dept.Contains("EEE")|| dept.Contains("LAW");
            
            string phone = textBoxStudentPn.Text;
            int phone_ = phone.Length;
            string email = textBoxStudentEmail.Text;
            bool check = email.Contains("@") && email.Contains(".com");
            string pass = textBoxStudentPass.Text;
            int passlen = pass.Length;
   
            try
            {

                if (textBoxStudentID.Text == string.Empty || textBoxStudentName.Text == string.Empty || textBoxStudentEmail.Text == string.Empty || textBoxStudentPn.Text == String.Empty || textBoxStudentPass.Text == string.Empty || textBoxDept.Text == string.Empty || textBoxIntakeSec.Text == string.Empty)
                {
                    MessageBox.Show("Fill Up The Tegistration Form Properly");
                }
                else if (textBoxStudentPass.Text != textBoxStudentConfirmPass.Text)
                {
                    MessageBox.Show("Password Do Not Match ");
                }
                else if(id_!=11)
                {
                    MessageBox.Show("Invalid Student ID");
                }
                else if(dept_==false)
                {
                    MessageBox.Show("Invaild Department");
                }
                else if(phone_>14 || phone_<11)
                {
                    MessageBox.Show("Inavild Phone Number");
                }
                else if(check==false)
                {
                    MessageBox.Show("Invalid Email");
                }
                else if(passlen<8)
                {
                    MessageBox.Show("Password Must Be 8 Digit");
                }

                else
                {
                    using (SqlConnection con = new SqlConnection(ConncetionString))
                    {
                        con.Open();
                        SqlCommand SqlCmd = new SqlCommand("StudentReg", con);
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.Parameters.AddWithValue("@ID", textBoxStudentID.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Name", textBoxStudentName.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Department", textBoxDept.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Email", textBoxStudentEmail.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Phone", textBoxStudentPn.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Intake_Sec", textBoxIntakeSec.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Password", textBoxStudentPass.Text.Trim());
                        SqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Is Successful");
                        Clear();
                        frmStudentLogin frm = new frmStudentLogin();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("You Have Already An Account");
            }
        }
        void Clear()
        {
            textBoxStudentID.Text = textBoxStudentName.Text = textBoxDept.Text = textBoxStudentEmail.Text = textBoxStudentPn.Text = textBoxStudentPass.Text = textBoxStudentConfirmPass.Text = textBoxIntakeSec.Text = string.Empty;
        }

        private void frmRegStudent_Load(object sender, EventArgs e)
        {

        }
    }
}

