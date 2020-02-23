namespace University_Student_Management.Screens
{
    partial class frmStudentMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudentNameD = new System.Windows.Forms.Label();
            this.btnPreviousCourse = new System.Windows.Forms.Button();
            this.btnPresentCourse = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnRoutine = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStudentNameD
            // 
            this.labelStudentNameD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentNameD.BackColor = System.Drawing.Color.Honeydew;
            this.labelStudentNameD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStudentNameD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentNameD.ForeColor = System.Drawing.Color.Black;
            this.labelStudentNameD.Location = new System.Drawing.Point(10, 63);
            this.labelStudentNameD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudentNameD.Name = "labelStudentNameD";
            this.labelStudentNameD.Size = new System.Drawing.Size(1038, 39);
            this.labelStudentNameD.TabIndex = 4;
            this.labelStudentNameD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousCourse
            // 
            this.btnPreviousCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousCourse.AutoSize = true;
            this.btnPreviousCourse.Image = global::University_Student_Management.Properties.Resources.previous_course;
            this.btnPreviousCourse.Location = new System.Drawing.Point(806, 50);
            this.btnPreviousCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreviousCourse.Name = "btnPreviousCourse";
            this.btnPreviousCourse.Size = new System.Drawing.Size(182, 201);
            this.btnPreviousCourse.TabIndex = 3;
            this.btnPreviousCourse.UseVisualStyleBackColor = true;
            this.btnPreviousCourse.Click += new System.EventHandler(this.btnPreviousCourse_Click);
            // 
            // btnPresentCourse
            // 
            this.btnPresentCourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresentCourse.AutoSize = true;
            this.btnPresentCourse.Image = global::University_Student_Management.Properties.Resources.present_course;
            this.btnPresentCourse.Location = new System.Drawing.Point(561, 51);
            this.btnPresentCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPresentCourse.Name = "btnPresentCourse";
            this.btnPresentCourse.Size = new System.Drawing.Size(177, 203);
            this.btnPresentCourse.TabIndex = 2;
            this.btnPresentCourse.UseVisualStyleBackColor = true;
            this.btnPresentCourse.Click += new System.EventHandler(this.btnPresentCourse_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSummary.AutoSize = true;
            this.btnSummary.Image = global::University_Student_Management.Properties.Resources.summary;
            this.btnSummary.Location = new System.Drawing.Point(294, 52);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(179, 205);
            this.btnSummary.TabIndex = 1;
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnRoutine
            // 
            this.btnRoutine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoutine.AutoSize = true;
            this.btnRoutine.Image = global::University_Student_Management.Properties.Resources.Routine;
            this.btnRoutine.Location = new System.Drawing.Point(42, 52);
            this.btnRoutine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoutine.Name = "btnRoutine";
            this.btnRoutine.Size = new System.Drawing.Size(180, 204);
            this.btnRoutine.TabIndex = 0;
            this.btnRoutine.UseVisualStyleBackColor = true;
            this.btnRoutine.Click += new System.EventHandler(this.btnRoutine_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoSize = true;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(968, 63);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 39);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnPreviousCourse);
            this.panel1.Controls.Add(this.btnPresentCourse);
            this.panel1.Controls.Add(this.btnSummary);
            this.panel1.Controls.Add(this.btnRoutine);
            this.panel1.Location = new System.Drawing.Point(10, 205);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 293);
            this.panel1.TabIndex = 25;
            // 
            // frmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelStudentNameD);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1074, 659);
            this.Name = "frmStudentMain";
            this.Text = "Student Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoutine;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnPresentCourse;
        private System.Windows.Forms.Button btnPreviousCourse;
        private System.Windows.Forms.Label labelStudentNameD;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
    }
}