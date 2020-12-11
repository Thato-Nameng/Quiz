using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentQuizzes
{
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()
        {
            InitializeComponent();
        }

        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_InformationDataSet3.StudentMarks' table. You can move, or remove it, as needed.
            this.studentMarksTableAdapter.Fill(this.student_InformationDataSet3.StudentMarks);
            // TODO: This line of code loads data into the 'student_InformationDataSet2.Registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.student_InformationDataSet2.Registration);

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetTest tst = new frmSetTest();
            tst.Show();
        }
    }
}