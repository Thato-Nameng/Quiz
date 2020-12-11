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
    public partial class frmSignin : Form
    {
        public frmSignin()
        {
            InitializeComponent();
        }

        private void frmSignin_Load(object sender, EventArgs e)
        {
            lblNameError.Visible = false;
            lblSurnameErr.Visible = false;
            lblSecPassError.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNme.Text != "" && txtSurname.Text != "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = false;
                lblSurnameErr.Visible = false;
                lblSecPassError.Visible = false;
                string conString = null;
                conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Tido\Desktop\17749831 NAMENG 
                    THATO PROG 2A TASK-2\StudentQuizzes\StudentQuizzes\Student Information.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO StudentData (Student Password, Student Name, Student Surname) 
                    VALUES ('" + txtSecPass.Text + "','" + txtNme.Text + "','" + txtSurname.Text +
                    "','" + "')'", con);
                MessageBox.Show("Data was saved");
                con.Close();

                this.Hide();
                frmQuiz qz = new frmQuiz();
                qz.Show();
            }
            else 
            if (txtNme.Text == "" && txtSurname.Text == "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = true;
                lblSurnameErr.Visible = true;
                lblSecPassError.Visible = true;                
            }
            else
            if (txtNme.Text != "" && txtSurname.Text == "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = false;
                lblSurnameErr.Visible = true;
                lblSecPassError.Visible = true;
            }
            else
            if (txtNme.Text == "" && txtSurname.Text != "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = true;
                lblSurnameErr.Visible = false;
                lblSecPassError.Visible = true;
            }
            else
            if (txtNme.Text == "" && txtSurname.Text == "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = true;
                lblSurnameErr.Visible = true;
                lblSecPassError.Visible = false;
            }
            else
            if (txtNme.Text != "" && txtSurname.Text != "" && txtSecPass.Text == "")
            {
                lblNameError.Visible = false;
                lblSurnameErr.Visible = false;
                lblSecPassError.Visible = true;
            }
            else
            if (txtNme.Text == "" && txtSurname.Text != "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = true;
                lblSurnameErr.Visible = false;
                lblSecPassError.Visible = false;
            }
            else
            if (txtNme.Text != "" && txtSurname.Text == "" && txtSecPass.Text != "")
            {
                lblNameError.Visible = false;
                lblSurnameErr.Visible = true;
                lblSecPassError.Visible = false;
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
                frmMenu mnu = new frmMenu();
                mnu.Show();
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
                frmLectureLogin Letcure = new frmLectureLogin();
                Letcure.Show();
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
