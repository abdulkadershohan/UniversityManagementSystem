using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Student_Management.Screens.Templates
{
    public partial class frmTemplates : Form
    {
        public frmTemplates()
        {
            InitializeComponent();
        }

        private void aboutUSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmAboutUs frm = new frmAboutUs();
            frm.Show();
        }

        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
