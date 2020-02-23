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
    public partial class frmRoutine : frmTemplates
    {
        string StudentID;
        public frmRoutine()
        {
            InitializeComponent();
           
        }
        public frmRoutine(string StudentID)
        {
            InitializeComponent();
            this.StudentID = StudentID;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentMain frm = new frmStudentMain(StudentID);
            frm.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentMain frm = new frmStudentMain(StudentID);
            frm.Show();
            this.Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummary frm = new frmSummary(StudentID);
            frm.Show();
            this.Hide();
        }

        private void presentCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentCourse frm = new frmPresentCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        private void previousCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPreviousCourse frm = new frmPreviousCourse(StudentID);
            frm.Show();
            this.Hide();
        }

        private void previousCourseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmPreviousCourse frm = new frmPreviousCourse(StudentID);
            frm.Show();
            this.Hide();
        }
    }
}
