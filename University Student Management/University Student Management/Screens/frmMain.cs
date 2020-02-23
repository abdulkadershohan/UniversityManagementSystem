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
    public partial class frmMain : frmTemplates
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStudentLogin frm = new frmStudentLogin();
            frm.Show();
            this.Hide();
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacherLogin frm = new frmTeacherLogin();
            frm.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdminLogin frm = new frmAdminLogin();
            frm.Show();
            this.Hide();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
