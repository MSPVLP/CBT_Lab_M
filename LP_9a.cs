using System;

using System.Windows.Forms;

namespace Part_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        int i = -1;
        int a = 0;
        DateTime startTime;
        string[] questions = new string[]
            {
                "The type float can be safely converted to___?",
                "Default Property for a textbox control______?",
                "What is the operator used to create object?",
                "________loop repeats group of statement for each element of an array?",
                "A _________variable is one that is declared inside a method?"

            };

        string[] answers = new string[]
        {
               "double", "long", "decimal", "ufloat",
               "Multiline", "Password Char", "Enable", "Text",
               "++", "+", "New", "object",
               "while loop", "do while loop", "foreach loop", "All the Above",
               "global","local","external","static"
        };

        string[] quizAnswers = new string[] { "double", "Text", "New", "foreach loop","local" };
       

        private void btn_start_Click(object sender, EventArgs e)
        {
            
            load_question();
        }

        private void btn_next_question_Click(object sender, EventArgs e)
        {

            if (getSelectedAnswer().Equals(quizAnswers[i]))
            {
                MessageBox.Show("Correct");
                score++;
                txt_score.Text = Convert.ToString(score);
                btn_next_question.Enabled = false;
                btn_next_question.Visible = false;
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_start.Text = "Next";

            }

            else
            {
                MessageBox.Show("Incorrect");
                // score--;
                txt_score.Text = Convert.ToString(score);
                btn_next_question.Enabled = false;
                btn_next_question.Visible = false;
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_start.Text = "Next";

            }


        }

        string getSelectedAnswer()
        {
            if (rdb_A.Checked)
                return rdb_A.Text.ToString();
            if (rdb_B.Checked)
                return rdb_B.Text.ToString();
            if (rdb_C.Checked)
                return rdb_C.Text.ToString();
            if (rdb_D.Checked)
                return rdb_D.Text.ToString();
            return "";
        }
       
        public void load_question()
        {
            
            i++;
            if (i < questions.Length)

            {

                //txtScore.Text = score;

                txt_question_no.Text = (i + 1).ToString();
                txt_question.Text = questions[i];


                rdb_A.Text = answers[a];
                a++;
                rdb_B.Text = answers[a];
                a++;
                rdb_C.Text = answers[a];
                a++;
                rdb_D.Text = answers[a];
                a++;

                rdb_A.Checked = false;
                rdb_B.Checked = false;
                rdb_C.Checked = false;
                rdb_D.Checked = false;

                btn_start.Enabled = false;
                btn_next_question.Visible = true;
                btn_next_question.Enabled = true;
            }
        }

        
        

        }
    }
}
