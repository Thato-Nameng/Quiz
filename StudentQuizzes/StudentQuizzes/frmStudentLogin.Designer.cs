namespace StudentQuizzes
{
    partial class frmStudentLogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLecture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSignin = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecPass = new System.Windows.Forms.TextBox();
            this.lblSecPassError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Leture = new System.Windows.Forms.Label();
            this.txtNme = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuLecture,
            this.menuStudent,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 45);
            this.menuStrip1.TabIndex = 132;
            this.menuStrip1.Text = "menuSt";
            // 
            // menuMenu
            // 
            this.menuMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuMenu.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(87, 41);
            this.menuMenu.Text = "Menu";
            this.menuMenu.Click += new System.EventHandler(this.menuMenu_Click);
            // 
            // menuLecture
            // 
            this.menuLecture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuLecture.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuLecture.Name = "menuLecture";
            this.menuLecture.Size = new System.Drawing.Size(174, 41);
            this.menuLecture.Text = "Lecture Login";
            this.menuLecture.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuLecture.Click += new System.EventHandler(this.menuLecture_Click);
            // 
            // menuStudent
            // 
            this.menuStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menuStudent.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStudent.Name = "menuStudent";
            this.menuStudent.Size = new System.Drawing.Size(179, 41);
            this.menuStudent.Text = "Student Login";
            this.menuStudent.Click += new System.EventHandler(this.menuStudent_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 41);
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSignin.Location = new System.Drawing.Point(430, 48);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(45, 16);
            this.lblSignin.TabIndex = 131;
            this.lblSignin.Text = "Signin";
            this.lblSignin.Click += new System.EventHandler(this.lblSignin_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(315, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 129;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(46, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "Password";
            // 
            // txtSecPass
            // 
            this.txtSecPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecPass.Location = new System.Drawing.Point(168, 158);
            this.txtSecPass.MaxLength = 2720;
            this.txtSecPass.Name = "txtSecPass";
            this.txtSecPass.Size = new System.Drawing.Size(222, 22);
            this.txtSecPass.TabIndex = 127;
            // 
            // lblSecPassError
            // 
            this.lblSecPassError.AutoSize = true;
            this.lblSecPassError.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSecPassError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecPassError.ForeColor = System.Drawing.Color.Red;
            this.lblSecPassError.Location = new System.Drawing.Point(179, 183);
            this.lblSecPassError.Name = "lblSecPassError";
            this.lblSecPassError.Size = new System.Drawing.Size(136, 16);
            this.lblSecPassError.TabIndex = 125;
            this.lblSecPassError.Text = "Error please try again";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(179, 139);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(136, 16);
            this.lblNameError.TabIndex = 126;
            this.lblNameError.Text = "Error please try again";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 124;
            this.label1.Text = "Name";
            // 
            // Leture
            // 
            this.Leture.AutoSize = true;
            this.Leture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Leture.Font = new System.Drawing.Font("Eras Bold ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Leture.Location = new System.Drawing.Point(34, 61);
            this.Leture.Name = "Leture";
            this.Leture.Size = new System.Drawing.Size(146, 23);
            this.Leture.TabIndex = 123;
            this.Leture.Text = "Student Login";
            // 
            // txtNme
            // 
            this.txtNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNme.Location = new System.Drawing.Point(168, 115);
            this.txtNme.Name = "txtNme";
            this.txtNme.Size = new System.Drawing.Size(222, 22);
            this.txtNme.TabIndex = 122;
            // 
            // frmStudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(488, 257);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSignin);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecPass);
            this.Controls.Add(this.lblSecPassError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Leture);
            this.Controls.Add(this.txtNme);
            this.Name = "frmStudentLogin";
            this.Text = "StudentQuizzes";
            this.Load += new System.EventHandler(this.frmStudentLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem menuLecture;
        private System.Windows.Forms.ToolStripMenuItem menuStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecPass;
        private System.Windows.Forms.Label lblSecPassError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Leture;
        private System.Windows.Forms.TextBox txtNme;
    }
}