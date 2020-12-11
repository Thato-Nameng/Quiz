namespace StudentQuizzes
{
    partial class frmStudentDetail
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.student_InformationDataSet1 = new StudentQuizzes.Student_InformationDataSet1();
            this.myAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAnsTableAdapter = new StudentQuizzes.Student_InformationDataSet1TableAdapters.MyAnsTableAdapter();
            this.studentInformationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crctAnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crctAnsTableAdapter = new StudentQuizzes.Student_InformationDataSet1TableAdapters.CrctAnsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.myAnsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.student_InformationDataSet2 = new StudentQuizzes.Student_InformationDataSet2();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationTableAdapter = new StudentQuizzes.Student_InformationDataSet2TableAdapters.RegistrationTableAdapter();
            this.student_InformationDataSet3 = new StudentQuizzes.Student_InformationDataSet3();
            this.studentMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentMarksTableAdapter = new StudentQuizzes.Student_InformationDataSet3TableAdapters.StudentMarksTableAdapter();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crctAnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // student_InformationDataSet1
            // 
            this.student_InformationDataSet1.DataSetName = "Student_InformationDataSet1";
            this.student_InformationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myAnsBindingSource
            // 
            this.myAnsBindingSource.DataMember = "MyAns";
            this.myAnsBindingSource.DataSource = this.student_InformationDataSet1;
            // 
            // myAnsTableAdapter
            // 
            this.myAnsTableAdapter.ClearBeforeFill = true;
            // 
            // studentInformationDataSet1BindingSource
            // 
            this.studentInformationDataSet1BindingSource.DataSource = this.student_InformationDataSet1;
            this.studentInformationDataSet1BindingSource.Position = 0;
            // 
            // crctAnsBindingSource
            // 
            this.crctAnsBindingSource.DataMember = "CrctAns";
            this.crctAnsBindingSource.DataSource = this.studentInformationDataSet1BindingSource;
            // 
            // crctAnsTableAdapter
            // 
            this.crctAnsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(416, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(146, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // myAnsBindingSource1
            // 
            this.myAnsBindingSource1.DataMember = "MyAns";
            this.myAnsBindingSource1.DataSource = this.studentInformationDataSet1BindingSource;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(283, 247);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 143;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 144;
            this.label1.Text = "Student Details";
            // 
            // student_InformationDataSet2
            // 
            this.student_InformationDataSet2.DataSetName = "Student_InformationDataSet2";
            this.student_InformationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.student_InformationDataSet2;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // student_InformationDataSet3
            // 
            this.student_InformationDataSet3.DataSetName = "Student_InformationDataSet3";
            this.student_InformationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentMarksBindingSource
            // 
            this.studentMarksBindingSource.DataMember = "StudentMarks";
            this.studentMarksBindingSource.DataSource = this.student_InformationDataSet3;
            // 
            // studentMarksTableAdapter
            // 
            this.studentMarksTableAdapter.ClearBeforeFill = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(364, 247);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 145;
            this.btnSet.Text = "Set Test";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // frmStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(608, 283);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStudentDetail";
            this.Text = "StudentQuizzes";
            this.Load += new System.EventHandler(this.frmStudentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crctAnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAnsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_InformationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentMarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Student_InformationDataSet1 student_InformationDataSet1;
        private System.Windows.Forms.BindingSource myAnsBindingSource;
        private Student_InformationDataSet1TableAdapters.MyAnsTableAdapter myAnsTableAdapter;
        private System.Windows.Forms.BindingSource studentInformationDataSet1BindingSource;
        private System.Windows.Forms.BindingSource crctAnsBindingSource;
        private Student_InformationDataSet1TableAdapters.CrctAnsTableAdapter crctAnsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource myAnsBindingSource1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private Student_InformationDataSet2 student_InformationDataSet2;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private Student_InformationDataSet2TableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private Student_InformationDataSet3 student_InformationDataSet3;
        private System.Windows.Forms.BindingSource studentMarksBindingSource;
        private Student_InformationDataSet3TableAdapters.StudentMarksTableAdapter studentMarksTableAdapter;
        private System.Windows.Forms.Button btnSet;
    }
}