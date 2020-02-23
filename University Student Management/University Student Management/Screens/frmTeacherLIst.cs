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
    public partial class frmTeacherLIst : frmTemplates
    {

        string ConncetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30";
        public frmTeacherLIst()
        {
            InitializeComponent();
            panelControl.Hide();
            panelDataGit.Enabled = false;
            panelCount.Hide();
        }

        private void frmTeacherLIst_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string dept = textBoxDept.Text;
            bool dept_ = dept.Contains("CSE") || dept.Contains("BBA") || dept.Contains("TEXT") || dept.Contains("ENG") || dept.Contains("EEE") || dept.Contains("LAW");
            try
            {
                if (textBoxDept.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Department is Required");
                }

                else if (dept_ == false)
                {
                    MessageBox.Show("Invalid Department ");
                }

                else
                {
                    panelCount.Show();
                    panelDataGit.Enabled = true;
                    panelControl.Show();

                    dataShow();
                    panelControl.Enabled= false;




                }



            }
            catch
            {
                MessageBox.Show("Somthings is wrong");
            }
        }
        public void dataShow()
        {
            using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
            {
                panelControl.Show();
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Teacher where Department='" + textBoxDept.Text + "'", sqlcon);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                dataGridViewTeacher.AutoGenerateColumns = false;
                dataGridViewTeacher.DataSource = dt;
                int count = dt.Rows.Count;
                labelStudentCount.Text = "Number of Teacher is : " + count;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMain frm = new frmAdminMain();
            frm.Show();
            this.Hide();
        }

        private void dataGridViewTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            panelControl.Enabled = true;

            if (e.RowIndex >= -1)
            {
                DataGridViewRow row = this.dataGridViewTeacher.Rows[e.RowIndex];

                textBoxName.Text = row.Cells["Column2"].Value.ToString();
                textBoxID.Text = row.Cells["Column1"].Value.ToString();  
                textBoxPn.Text = row.Cells["Column3"].Value.ToString();
                textBoxEmail.Text = row.Cells["Column4"].Value.ToString();
                textBoxDept2.Text = row.Cells["Column5"].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Delete This Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                    {
                        sqlcon.Open();

                        SqlDataAdapter sqlda = new SqlDataAdapter("delete  from Teacher where [ID]='" + textBoxID.Text.Trim() + "' and [Name]='" + textBoxName.Text.Trim() + "'", sqlcon);

                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);
                        dataShow();
                        MessageBox.Show("Delete Successfully");
                        panelControl.Enabled = false;
                        textBoxName.Text = textBoxID.Text = textBoxPn.Text = textBoxEmail.Text = textBoxDept2.Text  = string.Empty;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Somethings is Wrong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MyDB\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "Select * from Teacher where ID='" + textBoxID.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                try
                {
                    using (SqlConnection sqlcon = new SqlConnection(ConncetionString))
                    {
                        sqlcon.Open();

                        SqlDataAdapter sqlda = new SqlDataAdapter("UPDATE Teacher set Name='" + this.textBoxName.Text + "',Department='" + this.textBoxDept2.Text + "',Email='" + this.textBoxEmail.Text + "',Phone= '" + this.textBoxPn.Text + "' where ID='" + this.textBoxID.Text + "'", sqlcon);
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);
                        MessageBox.Show("Update Successfully");
                        panelControl.Enabled = false;
                        dataShow();
                        textBoxName.Text = textBoxID.Text = textBoxPn.Text = textBoxEmail.Text = textBoxDept2.Text = string.Empty;
                    }
                }
                catch
                {
                    MessageBox.Show("Somthings is Wrong");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
        }
    }
}
