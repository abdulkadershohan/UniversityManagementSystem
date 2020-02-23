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

namespace University_Student_Management.Screens
{
    public partial class frmAdminLogin : frmTemplates
    {
        string IDPASS = "Admin";
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click_1(object sender, EventArgs e)
        {
            if (textBoxAdminID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Admin ID is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAdminID.Clear();
                textBoxAdminID.Focus();
            }

            else if (textBoxAdminPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAdminPass.Clear();
                textBoxAdminPass.Focus();

            }
            else if(textBoxAdminID.Text==IDPASS && textBoxAdminPass.Text==IDPASS)
            {
                frmAdminMain frm = new frmAdminMain();
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Admin ID or Password is Invalid  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();
        }

    
    }
}
