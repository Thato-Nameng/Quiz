using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentQuizzes
{
    public partial class frmStudentLogin : Form
    {
        public frmStudentLogin()
        {
            InitializeComponent();
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
                frmQuiz Letcure = new frmQuiz();
                Letcure.Show();
            }
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignin Sign = new frmSignin();
            Sign.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNme.Text != "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = false;
                lblSecPassError.Visible = false;
                string conString = null;
                conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Tido\Desktop\17749831 NAMENG THATO PROG 2A TASK-2\StudentQuizzes
                \StudentQuizzes\Student Information.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT Student Password, Student Name FROM Registration", con);
                con.Close();
                this.Hide();
                frmQuiz takeQuiz = new frmQuiz();
                takeQuiz.Show();
            }
            if (txtNme.Text == "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = true;
                lblSecPassError.Visible = false;
            }
            if (txtNme.Text != "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = false;
                lblSecPassError.Visible = true;
            }
            if (txtNme.Text == "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = true;
                lblSecPassError.Visible = true;
            }
        }
        private void frmStudentLogin_Load(object sender, EventArgs e)
        {
            txtSecPass.PasswordChar = '*';
            lblNameError.Visible = false;
            lblSecPassError.Visible = false;
        }

        private void menuStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
