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
    public partial class frmAdminMain : frmTemplates
    {
        int check = 0;

        string ConncetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";

        public frmAdminMain()
        {
            InitializeComponent();
            btnUpdate.Hide();
            // btnDelete.Hide();
            ViewDataGit();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            clear();
        }
        public void clear()
        {
            textBoxTeacherID.Text = textBoxCourse_Code.Text = textBoxIntake_Sec.Text = textBoxDept.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          
            string coursecode = textBoxCourse_Code.Text;
            int lencourse = coursecode.Length;
            string dept = textBoxDept.Text;
            bool dept_ = dept.Contains("CSE") || dept.Contains("BBA") || dept.Contains("TEXT") || dept.Contains("ENG") || dept.Contains("EEE") || dept.Contains("LAW");
            btnUpdate.Hide();
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            string query = "Select * from Teacher where ID='" + textBoxTeacherID.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                try
                {

                    if (textBoxCourse_Code.Text == string.Empty || textBoxDept.Text == string.Empty || textBoxIntake_Sec.Text == string.Empty || textBoxTeacherID.Text == string.Empty)
                    {
                        MessageBox.Show("Fill Up Properly");
                    }
                    else if (lencourse != 7)
                    {
                        MessageBox.Show("Invalid Course Code");
                    }
                    else if (dept_ == false)
                    {
                        MessageBox.Show("Invalid Department");
                    }

                    else
                    {
                        using (SqlConnection con = new SqlConnection(ConncetionString))
                        {
                            con.Open();
                            SqlCommand SqlCmd = new SqlCommand("AddCourse", con);
                            SqlCmd.CommandType = CommandType.StoredProcedure;
                            SqlCmd.Parameters.AddWithValue("@ID", textBoxTeacherID.Text.Trim());
                            SqlCmd.Parameters.AddWithValue("@Course_Code", textBoxCourse_Code.Text.Trim());
                            SqlCmd.Parameters.AddWithValue("@Intake_Sec", textBoxIntake_Sec.Text.Trim());
                            SqlCmd.Parameters.AddWithValue("@Department", textBoxDept.Text.Trim());
                            SqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Course Added Successful ");
                            clear();
                            ViewDataGit();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Data is Already Added");
                }
            }
            else

            {
                MessageBox.Show("Invalid ID");

            }
        }
        public void ViewDataGit()
        {
           

            using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
             {
                 SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from Teach,Teacher Where Teach.ID=Teacher.ID", sqlcon);
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);
                 dataGridViewAdmin.AutoGenerateColumns = false;
                 dataGridViewAdmin.DataSource = dt;

             }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from Teach where ID='" + textBoxTeacherID.Text.Trim() + "' and Course_Code ='" + textBoxCourse_Code.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {

                using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                {
                    sqlcon.Open();
                    SqlDataAdapter sqlda = new SqlDataAdapter("UPDATE Teach set ID='" + this.textBoxTeacherID.Text + "',Course_Code='" + this.textBoxCourse_Code.Text + "',Intake_Sec='" + this.textBoxIntake_Sec.Text + "',Department='" + textBoxDept.Text + "' where ID='" + this.textBoxTeacherID.Text + "' and Course_Code='" + this.textBoxCourse_Code.Text + "'", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    ViewDataGit();

                    MessageBox.Show("Update Successfully");
                    ViewDataGit();
                    clear();
                    btnUpdate.Hide();



                }




            }
            else
            {
                MessageBox.Show("Invalid Teacher ID Or Course Code");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsTrue();

            if (check != 0)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
                con1.Open();
                string query = "Select * from Teacher,Teach where Teach.ID='"+textBoxTeacherID.Text.Trim()+"' and Teacher.ID='" + textBoxTeacherID.Text.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con1);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {

                    if (MessageBox.Show("Are You Sure To Delete This Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                        {
                            sqlcon.Open();

                            SqlDataAdapter sqlda = new SqlDataAdapter("delete  from Teach where [ID]='" + textBoxTeacherID.Text.Trim() + "' and [Course_Code]='" + textBoxCourse_Code.Text.Trim() + "'", sqlcon);

                            DataTable dt = new DataTable();
                            sqlda.Fill(dt);

                            clear();
                            MessageBox.Show("Delete Successfully");
                            ViewDataGit();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Teacher ID Or Course Code ");


            }

        }
        
        public void IsTrue()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from Teach where ID='" + textBoxTeacherID.Text.Trim() + "' and Course_Code ='" + textBoxCourse_Code.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                check = 1;
            }
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow row = this.dataGridViewAdmin.Rows[e.RowIndex];

                textBoxTeacherID.Text = row.Cells["ID"].Value.ToString();
                textBoxCourse_Code.Text = row.Cells["Course_Code"].Value.ToString();
                textBoxDept.Text = row.Cells["Department"].Value.ToString();
                textBoxIntake_Sec.Text = row.Cells["Intake_Sec"].Value.ToString();
                btnUpdate.Show();

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTeacherLIst frm = new frmTeacherLIst();
            frm.Show();
            this.Hide();

        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            frmStudentList frm = new frmStudentList();
            frm.Show();
            this.Hide();
        }
       
    }

}
