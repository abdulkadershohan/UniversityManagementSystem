namespace University_Student_Management.Screens
{
    partial class frmPreviousCourse
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
            this.dataGridViewPrevious = new System.Windows.Forms.DataGridView();
            this.Course_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intake_Sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_of_30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrevious)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrevious
            // 
            this.dataGridViewPrevious.AllowUserToAddRows = false;
            this.dataGridViewPrevious.AllowUserToDeleteRows = false;
            this.dataGridViewPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrevious.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPrevious.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrevious.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_Code,
            this.Course_Title,
            this.Credit,
            this.Intake_Sec,
            this.Mid,
            this.Final,
            this.Out_of_30,
            this.Column1});
            this.dataGridViewPrevious.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewPrevious.GridColor = System.Drawing.Color.Green;
            this.dataGridViewPrevious.Location = new System.Drawing.Point(59, 53);
            this.dataGridViewPrevious.Name = "dataGridViewPrevious";
            this.dataGridViewPrevious.ReadOnly = true;
            this.dataGridViewPrevious.RowHeadersWidth = 51;
            this.dataGridViewPrevious.RowTemplate.Height = 24;
            this.dataGridViewPrevious.Size = new System.Drawing.Size(1750, 298);
            this.dataGridViewPrevious.TabIndex = 8;
            // 
            // Course_Code
            // 
            this.Course_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course_Code.DataPropertyName = "Course_Code";
            this.Course_Code.FillWeight = 110F;
            this.Course_Code.HeaderText = "Course Code";
            this.Course_Code.MinimumWidth = 6;
            this.Course_Code.Name = "Course_Code";
            this.Course_Code.ReadOnly = true;
            // 
            // Course_Title
            // 
            this.Course_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Course_Title.DataPropertyName = "Course_Title";
            this.Course_Title.FillWeight = 120F;
            this.Course_Title.HeaderText = "Course Title";
            this.Course_Title.MinimumWidth = 6;
            this.Course_Title.Name = "Course_Title";
            this.Course_Title.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Intake_Sec
            // 
            this.Intake_Sec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intake_Sec.DataPropertyName = "Intake_Sec";
            this.Intake_Sec.HeaderText = "Intake-Sec";
            this.Intake_Sec.MinimumWidth = 6;
            this.Intake_Sec.Name = "Intake_Sec";
            this.Intake_Sec.ReadOnly = true;
            // 
            // Mid
            // 
            this.Mid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mid.DataPropertyName = "Mid";
            this.Mid.HeaderText = "Mid";
            this.Mid.MinimumWidth = 6;
            this.Mid.Name = "Mid";
            this.Mid.ReadOnly = true;
            // 
            // Final
            // 
            this.Final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Final.DataPropertyName = "Final";
            this.Final.HeaderText = "Final";
            this.Final.MinimumWidth = 6;
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            // 
            // Out_of_30
            // 
            this.Out_of_30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Out_of_30.DataPropertyName = "Out_of_30";
            this.Out_of_30.HeaderText = "Out of 30";
            this.Out_of_30.MinimumWidth = 6;
            this.Out_of_30.Name = "Out_of_30";
            this.Out_of_30.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Total";
            this.Column1.HeaderText = "Total";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.presentCourseToolStripMenuItem,
            this.routineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1900, 31);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.summaryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // presentCourseToolStripMenuItem
            // 
            this.presentCourseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.presentCourseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentCourseToolStripMenuItem.Name = "presentCourseToolStripMenuItem";
            this.presentCourseToolStripMenuItem.Size = new System.Drawing.Size(142, 27);
            this.presentCourseToolStripMenuItem.Text = "Present Course";
            this.presentCourseToolStripMenuItem.Click += new System.EventHandler(this.presentCourseToolStripMenuItem_Click);
            // 
            // routineToolStripMenuItem
            // 
            this.routineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.routineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routineToolStripMenuItem.Name = "routineToolStripMenuItem";
            this.routineToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.routineToolStripMenuItem.Text = "Routine";
            this.routineToolStripMenuItem.Click += new System.EventHandler(this.routineToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.dataGridViewPrevious);
            this.panel1.Location = new System.Drawing.Point(20, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1868, 404);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(498, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 165);
            this.panel2.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::University_Student_Management.Properties.Resources.b5ca34c1b0d5917f1475e85510f16d74;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 98);
            this.label1.TabIndex = 107;
            this.label1.Text = "Previous Course Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPreviousCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "frmPreviousCourse";
            this.Text = "Previous Course Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPreviousCourse_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrevious)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPrevious;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routineToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intake_Sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_of_30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}