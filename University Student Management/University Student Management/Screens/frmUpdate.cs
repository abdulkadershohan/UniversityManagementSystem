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
    public partial class frmUpdate : frmTemplates
    {
        string Course_Code, TeacherID;
        int check = 0;



        string ConncetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";


        public frmUpdate()
        {
            InitializeComponent();
        }
        public frmUpdate(String TeacherID)
        {
            InitializeComponent();
            this.TeacherID = TeacherID;
            ButtonDisable();
            textboxDisable();
            btnUpdate.Hide();
            dataGridViewPresent.Enabled = false;
            textBoxCourseCode.Enabled = false;
        }


        private void btonOK_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Teach where Course_Code='" + textBoxUpdate_Code.Text.Trim() + "' and ID ='" + TeacherID + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (textBoxUpdate_Code.Text == string.Empty)
            {
                MessageBox.Show("Invalid Course Code");
                Clear();
            }
            else if (table.Rows.Count == 1)
            {
                dataGridViewPresent.Show();
                ButtonEnable();
                texboxEnable();
                Course_Code = textBoxUpdate_Code.Text;
                textBoxCourseCode.Text = Course_Code;
                textBoxID.Text = textBoxMid.Text = textBoxFinal.Text = textBoxOut_Of_30.Text = textBoxTotal.Text = string.Empty;
                dataGridViewPresent.Enabled = true;
                ViewDataGit();
                labelCourse_Code.Text = textBoxCourseCode.Text;


            }
            else
            {
                MessageBox.Show(textBoxUpdate_Code, "Invalid Course Code");
                Clear();

                dataGridViewPresent.Hide();
                ButtonDisable();
                textboxDisable();
            }

        }
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            Clear();
            textBoxCourseCode.Text = Course_Code;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            int len = id.Length;
            ViewDataGit();
            btnUpdate.Hide();
            string mid = textBoxMid.Text;
            float mid_ =float.Parse(mid);
            string final = textBoxFinal.Text;
            float final_ = float.Parse(final);
            string total = textBoxTotal.Text;
            float total_ = float.Parse(total);

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con2.Open();
            string query = "Select * from Present_Course_Marks where ID='" + textBoxID.Text.Trim() + "' and Course_Code ='" + textBoxCourseCode.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con2);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {



                if (textBoxID.Text == string.Empty)
                {
                    MessageBox.Show("Student ID Is Required");
                }
                else if (textBoxCourseCode.Text == string.Empty)
                {
                    MessageBox.Show("Course Code Is Required");
                }
                else if(len!=11)
                {
                    MessageBox.Show("Invalid ID");
                }
                else if(mid_>30 || final_>40 || total_>100)
                {
                    MessageBox.Show("Invalid Value");
                }
             
                else
                {
                    using (SqlConnection con = new SqlConnection(ConncetionString))
                    {
                        con.Open();
                        SqlCommand SqlCmd = new SqlCommand("UpdatePresentCoureseMarks", con);
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.Parameters.AddWithValue("@ID", textBoxID.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Course_Code", Course_Code);
                        SqlCmd.Parameters.AddWithValue("@Mid", textBoxMid.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Final", textBoxFinal.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Out_of_30", textBoxOut_Of_30.Text.Trim());
                        SqlCmd.Parameters.AddWithValue("@Total", textBoxTotal.Text.Trim());
                        SqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Successful");

                        Clear();
                        ViewDataGit();
                        textBoxCourseCode.Text = Course_Code;

                    }
                }



            }
            else
            {
                MessageBox.Show("Data Is Already Added");
            }
            ViewDataGit();
        }
        public void ButtonEnable()
        {
            btnSave.Enabled = true;
            btnCancle.Enabled = true;
            btnDelete.Enabled = true;
        }
        public void ButtonDisable()
        {
            btnSave.Enabled = false;
            btnCancle.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridViewPresent_DoubleClick(object sender, EventArgs e)
        {


        }

        public void Clear()
        {
            textBoxID.Text = textBoxCourseCode.Text = textBoxMid.Text = textBoxFinal.Text = textBoxOut_Of_30.Text = textBoxTotal.Text = string.Empty;
            btnSave.Text = "Save";

        }

        private void dataGridViewPresent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            btnDelete.Enabled = true;
            if (e.RowIndex >= -1)
            {
                DataGridViewRow row = this.dataGridViewPresent.Rows[e.RowIndex];

                textBoxID.Text = row.Cells["Column1"].Value.ToString();
                textBoxCourseCode.Text = row.Cells["Column2"].Value.ToString();
                textBoxMid.Text = row.Cells["Column3"].Value.ToString();
                textBoxFinal.Text = row.Cells["Column4"].Value.ToString();
                textBoxOut_Of_30.Text = row.Cells["Column5"].Value.ToString();
                textBoxTotal.Text = row.Cells["Column6"].Value.ToString();

            }
            btnUpdate.Show();

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTotal.Text = textBoxMid.Text;
            }
            catch
            {

            }
        }

        private void textBoxFinal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTotal.Text = (float.Parse(textBoxMid.Text) + float.Parse(textBoxFinal.Text)).ToString();
            }
            catch
            {

            }

        }

        private void textBoxOut_Of_30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTotal.Text = (float.Parse(textBoxMid.Text) + float.Parse(textBoxFinal.Text) + float.Parse(textBoxOut_Of_30.Text)).ToString();
            }
            catch
            {

            }
        }

        public void ViewDataGit()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Present_Course_Marks where Course_Code='" + Course_Code + "'", sqlcon);

                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataGridViewPresent.AutoGenerateColumns = false;
                dataGridViewPresent.DataSource = dt;

            }
        }
        public void textboxDisable()
        {
            textBoxID.Enabled = false;
            textBoxCourseCode.Enabled = false;
            textBoxMid.Enabled = false;
            textBoxFinal.Enabled = false;
            textBoxOut_Of_30.Enabled = false;
            textBoxTotal.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            IsTrue();

            if (check != 0)
            {
                if (MessageBox.Show("Are You Sure To Delete This Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                    {
                        sqlcon.Open();

                        SqlDataAdapter sqlda = new SqlDataAdapter("delete  from Present_Course_Marks where [ID]='" + textBoxID.Text.Trim() + "' and [Course_Code]='" + textBoxCourseCode.Text.Trim() + "'", sqlcon);

                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);
                        ViewDataGit();
                        Clear();
                        MessageBox.Show("Delete Successfully");
                        textBoxCourseCode.Text = Course_Code;



                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID Or Course Code ");
                textBoxCourseCode.Text = Course_Code;
                ViewDataGit();


            }
            check = 0;

        }
        public void IsTrue()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from Present_Course_Marks where ID='" + textBoxID.Text.Trim() + "' and Course_Code ='" + textBoxCourseCode.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                check = 1;
            }
        }


        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCourseCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from Present_Course_Marks where ID='" + textBoxID.Text.Trim() + "' and Course_Code ='" + textBoxCourseCode.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {

                using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                {
                    sqlcon.Open();

                    SqlDataAdapter sqlda = new SqlDataAdapter("UPDATE Present_Course_Marks set ID='" + this.textBoxID.Text + "',Course_Code='" + this.textBoxCourseCode.Text + "',Mid='" + this.textBoxMid.Text + "',Final= '" + this.textBoxFinal.Text + "',Out_of_30= '" + this.textBoxOut_Of_30.Text + "',Total= '" + this.textBoxTotal.Text + "' where ID='" + this.textBoxID.Text + "' and Course_Code='" + this.textBoxCourseCode.Text + "'", sqlcon);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    ViewDataGit();

                    MessageBox.Show("Update Successfully");
                    ViewDataGit();
                    Clear();
                    btnUpdate.Hide();



                }




            }
            else
            {
                MessageBox.Show("Invalid Student ID Or Course Code");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmTeacherMain frm = new frmTeacherMain(TeacherID);
            frm.Show();
            this.Hide();
        }

        public void texboxEnable()
        {
            textBoxID.Enabled = true;
            
            textBoxMid.Enabled = true;
            textBoxFinal.Enabled = true;
            textBoxOut_Of_30.Enabled = true;
            textBoxTotal.Enabled = true;
        }

    }
}
