using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentQuizzes
{
    public partial class frmSetTest : Form
    {
        private StreamWriter write;
        private StreamReader read;
        //SQl commands and connection strings.
        SqlCommand cmd;
        SqlConnection conn;
        public frmSetTest()
        {
            InitializeComponent();
        }

        private void frmSetTest_Load(object sender, EventArgs e)
        {
            btnSetTest.Hide();
        }

        private void btnSetTest_Click(object sender, EventArgs e)
        {
            //saving the lectures answers and questions onto a string so i can save them to a file later on.
            string Question1 = "";
            Question1 = txtQuestion1Possible1.Text
                + "\n  " + txtQuestion1Possible2.Text
                + "\n  " + txtQuestion1Possible3.Text
                + "\n  " + txtQuestion1Possible4.Text;
            //creating the file. writting to a file and closing the file
            write = new StreamWriter("Question 1.txt");
            write.WriteLine(Question1);
            write.Close();

            string Question1Type = "";
            Question1Type = txtQuestion1.Text;
            write = new StreamWriter("Question 1 type.txt");
            write.WriteLine(Question1Type);
            write.Close();

            
            //saving the lectures answers and questions onto a string so i can save them to a file later on.
            string Question2 = "";
            Question2 = txtQuestion2Possible1.Text
                + "\n  " + txtQuestion2Possible2.Text
                + "\n  " + txtQuestion2Possible3.Text
                + "\n  " + txtQuestion2Possible4.Text;
            //creating the file. writting to a file and closing the file
             
            write = new StreamWriter("Question 2.txt");
            write.WriteLine(Question2);
            write.Close();

            string Question2Type = "";
            Question2Type = txtQuestion2.Text;
            write = new StreamWriter("Question 2 type.txt");
            write.WriteLine(Question2Type);
            write.Close();


            //saving the lectures answers and questions onto a string so i can save them to a file later on.
            string Question3 = "";
            Question3 = txtQuestion3Possible1.Text
                + "\n  " + txtQuestion3Possible2.Text
                + "\n  " + txtQuestion3Possible3.Text
                + "\n  " + txtQuestion3Possible4.Text;
            
            //creating the file. writting to a file and closing the file
            write = new StreamWriter("Question 3.txt");
            write.WriteLine(Question3);
            write.Close();

            string Question3Type = "";
            Question3Type = txtQuestion3.Text;
            write = new StreamWriter("Question 3 type.txt");
            write.WriteLine(Question3Type);
            write.Close();


            //saving the lectures answers and questions onto a string so i can save them to a file later on.
            string Question4 = "";
            Question4 = txtQuestion4Possible1.Text
                + "\n  " + txtQuestion4Possible2.Text
                + "\n  " + txtQuestion4Possible3.Text
                + "\n  " + txtQuestion4Possible4.Text;
            
            //creating the file. writting to a file and closing the file
            write = new StreamWriter("Question 4.txt");
            write.WriteLine(Question4);
            write.Close();

            string Question4Type = "";
            Question4Type = txtQuestion4.Text;
            write = new StreamWriter("Question 4 type.txt");
            write.WriteLine(Question4Type);
            write.Close();


            string Answer = "";
            Answer = txtUserAnswer1.Text
                + "\n  " + txtUserAnswer2.Text
                + "\n  " + txtUserAnswer3.Text
                + "\n  " + txtUserAnswer4.Text;
            
            //creating the file. writting to a file and closing the file
            write = new StreamWriter("Answers.txt");
            write.WriteLine(Answer);
            write.Close();
            

            string[] Answers = new string[4];
            Answers[0] = txtUserAnswer1.Text;
            Answers[1] = txtUserAnswer2.Text;
            Answers[2] = txtUserAnswer3.Text;
            Answers[3] = txtUserAnswer4.Text;

            string conString = null;
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Tido\Desktop\17749831 NAMENG THATO PROG 2A TASK-2\StudentQuizzes
                \StudentQuizzes\Student Information.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cnd = new SqlCommand(@"INSERT INTO SetTest (Question, Answer) VALUES ('" + "*" + Answers + "')'", con);
            con.Close();
        }
        private void txtQuestion4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StudentDB.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cm = new SqlCommand("DELETE FROM SetTest WHERE *", con);
            cm.ExecuteNonQuery();
            con.Close();
            btnDlt.Hide();
            btnSetTest.Show();
        }

        private void menuMenu_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Are you sure that you would like to" +
                "leave? ", "Wait...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message == DialogResult.Yes)
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
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
