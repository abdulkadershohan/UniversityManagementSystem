using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using University_Student_Management.Screens.Templates;

namespace University_Student_Management.Screens
{
    public partial class frmRegTeacher : frmTemplates
    {
        string ConncetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";


        public frmRegTeacher()
        {
            InitializeComponent();
        }

        private void btnTeacherRegCancle_Click(object sender, EventArgs e)
        {
            frmTeacherLogin frm = new frmTeacherLogin();
            frm.Show();
            this.Hide();
        }

        private void btnTeacherRegSubmit_Click(object sender, EventArgs e)
        {
            string dept = textBoxDept.Text;
            bool dept_= dept.Contains("CSE") || dept.Contains("BBA") || dept.Contains("TEXT") || dept.Contains("ENG") || dept.Contains("EEE") || dept.Contains("LAW");
            string phone = textBoxTeacherPn.Text;
            int phonelen = phone.Length;
            string email = textBoxTeacherEmail.Text;
            bool check = email.Contains("@") && email.Contains(".com");
            string pass = textBoxTeacherPass.Text;
            int passlen = pass.Length;
            //

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Teacher where ID='" + textBoxTeacherID.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);


            //

            try
            {
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("You Have Already An Account");
                }


                else if (textBoxDept.Text==string.Empty || textBoxTeacherID.Text == string.Empty || textBoxTeacherName.Text == string.Empty || textBoxTeacherEmail.Text == string.Empty || textBoxTeacherPn.Text == String.Empty || textBoxTeacherPass.Text == string.Empty)
                {
                    MessageBox.Show("Fill Up The Tegistration Form Properly");
                }
                else if (textBoxTeacherPass.Text != textBoxTeacherConfirmPass.Text)
                {
                    MessageBox.Show("Password Do Not Match ");
                }
                else if(phonelen<11 || phonelen>14)
                {
                    MessageBox.Show("Invalid Phone");
                }
                else if(check==false)
                {
                    MessageBox.Show("Invalid Email");
                }
                else if(passlen<8)
                {
                    MessageBox.Show("Password Must Be 8 Digit");
                }
                else if(dept_==false)
                {
                    MessageBox.Show("Invalid Department");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(ConncetionString))
                    {
                        con.Open();
                        SqlCommand SqlCmd = new SqlCommand("TeacherReg", con);
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.Parameters.AddWithValue("@ID", textBoxTeacherID.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Name", textBoxTeacherName.Text.Trim());
                       SqlCmd.Parameters.AddWithValue("@Department", textBoxDept.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Email", textBoxTeacherEmail.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Phone", textBoxTeacherPn.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Password", textBoxTeacherPass.Text.Trim());
                        SqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration Is Successful");
                        Clear();
                        frmTeacherLogin frm = new frmTeacherLogin();
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Database not found !");
            }
        }
        void Clear()
        {
            textBoxTeacherID.Text= textBoxDept.Text = textBoxTeacherName.Text = textBoxTeacherEmail.Text = textBoxTeacherPn.Text = textBoxTeacherPass.Text =textBoxTeacherConfirmPass.Text ="";
        }

        private void frmRegTeacher_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
