using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ex_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset_quiz();       // Call reset_quiz() during startup to set components' statuses properly
        }

        // Quiz Settings:

        int MAX_QUIZ_SECONDS = 25;
        int marks_for_correct = 10;
        int neg_marks_for_wrong = 5;

        // Quiz Questions:

        string[] questions = new string[]
        {
                "Which of these is a fruits?",
                "What OS did Linus develop?",
                "What is India's capital?",
                "________ is a loop in C#.",
                "A variable name can contain ______."
        };

        string[,] answer_choices = new string[5, 4]
        {
               { "apple", "brinjal", "rock", "carrot" },
               { "Windows", "DOS", "Linux", "macOS" },
               { "Chennai", "New Delhi", "Madras", "Tirunelveli" },
               { "while", "struct", "int", "All the Above" },
               { "all symbols","plus sign","/","underscore" }
        };

        int[] correct_answers = new int[] { 1, 3, 2, 1, 4 };

        // Quiz attending related variables

        int score = 0;
        DateTime start_time;
        int current_question = -1;
        int time_remaining = 0;

        public void reset_quiz()
        {
            current_question = -1;
            score = 0;
            txt_score.Text = score.ToString();
            txt_question_no.Text = "";
            txt_question.Text = "";

            rdb_A.Text = "";
            rdb_B.Text = "";
            rdb_C.Text = "";
            rdb_D.Text = "";

            rdb_A.Checked = false;
            rdb_B.Checked = false;
            rdb_C.Checked = false;
            rdb_D.Checked = false;

            rdb_A.Enabled = false;
            rdb_B.Enabled = false;
            rdb_C.Enabled = false;
            rdb_D.Enabled = false;

            btn_start.Enabled = true;
            btn_next_question.Visible = false;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            start_time = DateTime.Now;       // Record start time of quiz
            current_question = 0;              // Start from Question index 0
            load_question(current_question);   // Load first question
            timer1.Start();
        }

        public void load_question(int q_no)
        {
            txt_question_no.Text = (q_no + 1).ToString();
            txt_question.Text = questions[q_no];

            rdb_A.Text = answer_choices[q_no, 0];
            rdb_B.Text = answer_choices[q_no, 1];
            rdb_C.Text = answer_choices[q_no, 2];
            rdb_D.Text = answer_choices[q_no, 3];

            rdb_A.Checked = false;
            rdb_B.Checked = false;
            rdb_C.Checked = false;
            rdb_D.Checked = false;

            rdb_A.Enabled = true;
            rdb_B.Enabled = true;
            rdb_C.Enabled = true;
            rdb_D.Enabled = true;

            btn_start.Enabled = false;
            btn_next_question.Visible = true;
        }

        public void check_answer()
        {
            int answer_given = 0;

            // Convert chosen radio button to choice number 
            if (rdb_A.Checked) answer_given = 1;
            else if (rdb_B.Checked) answer_given = 2;
            else if (rdb_C.Checked) answer_given = 3;
            else if (rdb_D.Checked) answer_given = 4;

            if (answer_given == correct_answers[current_question])
            {
                MessageBox.Show("Correct!", "Quiz");
                score += marks_for_correct;
            }
            else
            {
                MessageBox.Show("Incorrect!", "Quiz");
                score -= neg_marks_for_wrong;
            }
            
            txt_score.Text = Convert.ToString(score);       // Update score 
        }

        private void btn_next_question_Click(object sender, EventArgs e)
        {
            check_answer();

            // Go to next question
            current_question++;

            if (current_question < questions.Length)
            {
                load_question(current_question);
            }
            else
            {
                quiz_end("End of quiz.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now.Subtract(start_time);
            time_remaining = MAX_QUIZ_SECONDS - span.Seconds;

            txt_time.Text = time_remaining.ToString(); // span.Hours.ToString() + ":" + span.Minutes.ToString() + ":" + span.Seconds.ToString();

            if (span.Seconds == MAX_QUIZ_SECONDS)
            {
                timer1.Stop();
                quiz_end("You ran out of time.");
            }
        }

        public void quiz_end(string msg)
        {
            timer1.Stop();
            MessageBox.Show(msg + " Your score is " + score.ToString() + ". Press start to begin again.", "Quiz Result");
            reset_quiz();
        }
    }
}
