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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            int x = 0;
            string line1;
            System.IO.StreamReader file1 = new System.IO.StreamReader("Question 1.txt");
            while ((line1 = file1.ReadLine()) != null)
            {
                lstPossibleAnswer1.Items.Add(line1);
                x++;
            }
            string FirstQ;
            System.IO.StreamReader Q1 = new System.IO.StreamReader("Question 1 type.txt");
            FirstQ = Q1.ReadLine();
            lblQuestion1.Text = FirstQ;

            int y = 0;
            string line2;
            System.IO.StreamReader file2 = new System.IO.StreamReader("Question 2.txt");
            while ((line2 = file2.ReadLine()) != null)
            {
                lstPossibleAnswer2.Items.Add(line2);
                y++;
            }
            string SecondQ;
            System.IO.StreamReader Q2 = new System.IO.StreamReader("Question 2 type.txt");
            SecondQ = Q2.ReadLine();
            lblQuestion2.Text = SecondQ;

            int c = 0;
            string line3;
            System.IO.StreamReader file3 = new System.IO.StreamReader("Question 3.txt");
            while ((line3 = file3.ReadLine()) != null)
            {
                lstPossibleAnswer3.Items.Add(line3);
                c++;
            }
            string ThirdQ;
            System.IO.StreamReader Q3 = new System.IO.StreamReader("Question 3 type.txt");
            ThirdQ = Q3.ReadLine();
            lblQuestion3.Text = ThirdQ;

            int n = 0;
            string line4;
            System.IO.StreamReader file4 = new System.IO.StreamReader("Question 4.txt");
            while ((line4 = file4.ReadLine()) != null)
            {
                lstPossibleAnswer4.Items.Add(line4);
                n++;
            }
            string FourthQ;
            System.IO.StreamReader Q4 = new System.IO.StreamReader("Question 4 type.txt");
            FourthQ = Q4.ReadLine();
            lblQuestion4.Text = FourthQ;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] Students = new string[4];

            string line1;
            System.IO.StreamReader file1 = new System.IO.StreamReader("Answers 1.txt");
            line1 = file1.ReadLine();

            string line2;
            System.IO.StreamReader file2 = new System.IO.StreamReader("Answers 2.txt");
            line2 = file2.ReadLine();

            string line3;
            System.IO.StreamReader file3 = new System.IO.StreamReader("Answers 3.txt");
            line3 = file3.ReadLine();

            string line4;
            System.IO.StreamReader file4 = new System.IO.StreamReader("Answers 4.txt");
            line4 = file4.ReadLine();

            Students[0] = line1;
            Students[1] = line2;
            Students[2] = line3;
            Students[3] = line4;

            int k = 0;
            int x = 4;

            while (k < x)
            {
                if (line1 == lstPossibleAnswer1.Text)
                {
                    k++;
                }
                if (line2 == lstPossibleAnswer2.Text)
                {
                    k++;
                }
                if (line3 == lstPossibleAnswer3.Text)
                {
                    k++;
                }
                if (line4 == lstPossibleAnswer4.Text)
                {
                    k++;
                }

                string connectionString = null;
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Tido\Desktop\17749831 NAMENG THATO PROG 2A TASK-2\StudentQuizzes
                \StudentQuizzes\Student Information.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cnnd = new SqlCommand(@"INSERT INTO StudentMarks (Id, Marks) VALUES ('" + "*" + "','" + k + "')'", conn);
            }

            string conString = null;
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Tido\Desktop\17749831 NAMENG THATO PROG 2A TASK-2\StudentQuizzes
                \StudentQuizzes\Student Information.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cnd = new SqlConnection(conString);
            cnd.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM LectureAns WHERE *", cnd);
            cmd.ExecuteNonQuery();
            cnd.Close();

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cs = new SqlCommand(@"INSERT INTO StudAns (Question, StudAns) VALUES ('" + "*" + "','" + Students + "')'", con);
            con.Close();

            this.Hide();
            frmQuizResult rslt = new frmQuizResult();
            rslt.Show();
        }
    }
}
