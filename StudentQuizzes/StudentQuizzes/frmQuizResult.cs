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
    public partial class frmQuizResult : Form
    {
        public frmQuizResult()
        {
            InitializeComponent();
        }

        private void frmQuizResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_InformationDataSet5.CrctAns' table. You can move, or remove it, as needed.
            this.crctAnsTableAdapter.Fill(this.student_InformationDataSet5.CrctAns);
            // TODO: This line of code loads data into the 'student_InformationDataSet4.MyAns' table. You can move, or remove it, as needed.
            this.myAnsTableAdapter.Fill(this.student_InformationDataSet4.MyAns);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuMenu_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure that you would like to" +
                "leave? ", "Wait...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message == DialogResult.Yes)
            {
                this.Hide();
                frmMenu Menu = new frmMenu();
                Menu.Show();
            }
        }

        private void menuLecture_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure that you would like to" +
                "leave? ", "Wait...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message == DialogResult.Yes)
            {
                this.Hide();
                frmLectureLogin lecture = new frmLectureLogin();
                lecture.Show();
            }
        }

        private void menuStudent_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure that you would like to" +
                "leave? ", "Wait...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message == DialogResult.Yes)
            {
                this.Hide();
                frmStudentLogin student = new frmStudentLogin();
                student.Show();
            }
        }
    }
}
