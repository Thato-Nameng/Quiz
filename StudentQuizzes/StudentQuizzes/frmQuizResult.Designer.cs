namespace StudentQuizzes
{
    partial class frmQuizResult
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_InformationDataSet4 = new StudentQuizzes.Student_InformationDataSet4();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.myAnsTableAdapter = new StudentQuizzes.Student_InformationDataSet4TableAdapters.MyAnsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crctAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_InformationDataSet5 = new StudentQuizzes.Student_InformationDataSet5();
            this.crctAnsTableAdapter = new StudentQuizzes.Student_InformationDataSet5TableAdapters.CrctAnsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLecture = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crctAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionsDataGridViewTextBoxColumn,
            this.answersDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myAnsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(390, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionsDataGridViewTextBoxColumn
            // 
            this.questionsDataGridViewTextBoxColumn.DataPropertyName = "Questions";
            this.questionsDataGridViewTextBoxColumn.HeaderText = "Questions";
            this.questionsDataGridViewTextBoxColumn.Name = "questionsDataGridViewTextBoxColumn";
            this.questionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answersDataGridViewTextBoxColumn
            // 
            this.answersDataGridViewTextBoxColumn.DataPropertyName = "Answers";
            this.answersDataGridViewTextBoxColumn.HeaderText = "Answers";
            this.answersDataGridViewTextBoxColumn.Name = "answersDataGridViewTextBoxColumn";
            // 
            // myAnsBindingSource
            // 
            this.myAnsBindingSource.DataMember = "MyAns";
            this.myAnsBindingSource.DataSource = this.student_InformationDataSet4;
            // 
            // student_InformationDataSet4
            // 
            this.student_InformationDataSet4.DataSetName = "Student_InformationDataSet4";
            this.student_InformationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myAnsTableAdapter
            // 
            this.myAnsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionDataGridViewTextBoxColumn,
            this.correctAnswersDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.crctAnsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(46, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(338, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswersDataGridViewTextBoxColumn
            // 
            this.correctAnswersDataGridViewTextBoxColumn.DataPropertyName = "Correct Answers";
            this.correctAnswersDataGridViewTextBoxColumn.HeaderText = "Correct Answers";
            this.correctAnswersDataGridViewTextBoxColumn.Name = "correctAnswersDataGridViewTextBoxColumn";
            // 
            // crctAnsBindingSource
            // 
            this.crctAnsBindingSource.DataMember = "CrctAns";
            this.crctAnsBindingSource.DataSource = this.student_InformationDataSet5;
            // 
            // student_InformationDataSet5
            // 
            this.student_InformationDataSet5.DataSetName = "Student_InformationDataSet5";
            this.student_InformationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crctAnsTableAdapter
            // 
            this.crctAnsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "StudentResults";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(350, 262);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(762, 45);
            this.menuStrip1.TabIndex = 136;
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
            // frmQuizResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(762, 293);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQuizResult";
            this.Text = "StudentQuizzes";
            this.Load += new System.EventHandler(this.frmQuizResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crctAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Student_InformationDataSet4 student_InformationDataSet4;
        private System.Windows.Forms.BindingSource myAnsBindingSource;
        private Student_InformationDataSet4TableAdapters.MyAnsTableAdapter myAnsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Student_InformationDataSet5 student_InformationDataSet5;
        private System.Windows.Forms.BindingSource crctAnsBindingSource;
        private Student_InformationDataSet5TableAdapters.CrctAnsTableAdapter crctAnsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswersDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem menuLecture;
        private System.Windows.Forms.ToolStripMenuItem menuStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}