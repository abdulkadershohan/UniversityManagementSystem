namespace University_Student_Management.Screens
{
    partial class frmTeacherLogin
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
            this.btnTeacherSignUP = new System.Windows.Forms.Button();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.textBoxTeacherPass = new System.Windows.Forms.TextBox();
            this.textBoxTeacherID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTeacherSignUP
            // 
            this.btnTeacherSignUP.AutoSize = true;
            this.btnTeacherSignUP.Location = new System.Drawing.Point(581, 40);
            this.btnTeacherSignUP.Name = "btnTeacherSignUP";
            this.btnTeacherSignUP.Size = new System.Drawing.Size(82, 34);
            this.btnTeacherSignUP.TabIndex = 14;
            this.btnTeacherSignUP.Text = "Sign up";
            this.btnTeacherSignUP.UseVisualStyleBackColor = true;
            this.btnTeacherSignUP.Click += new System.EventHandler(this.btnTeacherSignUP_Click);
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.AutoSize = true;
            this.btnTeacherLogin.Location = new System.Drawing.Point(589, 216);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(74, 34);
            this.btnTeacherLogin.TabIndex = 13;
            this.btnTeacherLogin.Text = "Login";
            this.btnTeacherLogin.UseVisualStyleBackColor = true;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // textBoxTeacherPass
            // 
            this.textBoxTeacherPass.Location = new System.Drawing.Point(478, 162);
            this.textBoxTeacherPass.Name = "textBoxTeacherPass";
            this.textBoxTeacherPass.PasswordChar = '*';
            this.textBoxTeacherPass.Size = new System.Drawing.Size(185, 30);
            this.textBoxTeacherPass.TabIndex = 12;
            // 
            // textBoxTeacherID
            // 
            this.textBoxTeacherID.Location = new System.Drawing.Point(478, 89);
            this.textBoxTeacherID.Name = "textBoxTeacherID";
            this.textBoxTeacherID.Size = new System.Drawing.Size(185, 30);
            this.textBoxTeacherID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(370, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(364, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Teacher ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University_Student_Management.Properties.Resources.login_profile;
            this.pictureBox1.Location = new System.Drawing.Point(35, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.AutoSize = true;
            this.btnCancle.BackColor = System.Drawing.Color.Red;
            this.btnCancle.Location = new System.Drawing.Point(478, 216);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(72, 34);
            this.btnCancle.TabIndex = 20;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnTeacherSignUP);
            this.panel1.Controls.Add(this.btnTeacherLogin);
            this.panel1.Controls.Add(this.textBoxTeacherPass);
            this.panel1.Controls.Add(this.textBoxTeacherID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(39, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 350);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(90, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 470);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(90, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 137);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(88, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 82);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Login";
            // 
            // frmTeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 743);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(927, 790);
            this.Name = "frmTeacherLogin";
            this.Text = "Teachers Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeacherLogin_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeacherSignUP;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.TextBox textBoxTeacherPass;
        private System.Windows.Forms.TextBox textBoxTeacherID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}