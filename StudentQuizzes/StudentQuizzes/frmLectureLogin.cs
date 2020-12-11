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
    public partial class frmLectureLogin : Form
    {
        public frmLectureLogin()
        {
            InitializeComponent();
        }

        private void frmLectureLogin_Load(object sender, EventArgs e)
        {
            lblNameError.Hide();
            lblSecPassError.Hide();
        }

        private void menuStudent_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure that you would like to" +
                "leave? ", "Wait...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message == DialogResult.Yes)
            {
                this.Hide();
                frmStudentLogin Student = new frmStudentLogin();
                Student.Show();
            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Name = "Thato";
            String Password = "445Lecture";

            if(Name == txtNme.Text && Password == txtSecPass.Text)
            {
                lblNameError.Hide();
                lblSecPassError.Hide();
                this.Hide();
                frmStudentDetail dtl = new frmStudentDetail();
                dtl.Show();
            }
            else
            if (Name != txtNme.Text && Password != txtSecPass.Text)
            {
                lblNameError.Show();
                lblSecPassError.Show();
            }
            else
            if (Name != txtNme.Text && Password == txtSecPass.Text)
            {
                lblNameError.Show();
                lblSecPassError.Hide();
            }
            if (Name == txtNme.Text && Password != txtSecPass.Text)
            {
                lblNameError.Hide();
                lblSecPassError.Show();
            }
        }

        private void menuLecture_Click(object sender, EventArgs e)
        {

        }
    }
}
