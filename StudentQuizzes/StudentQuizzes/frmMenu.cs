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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentLogin studLog = new frmStudentLogin();
            studLog.Show();            
        }

        private void btnLetcure_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLectureLogin letcure = new frmLectureLogin();
            letcure.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
