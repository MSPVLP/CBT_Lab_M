﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void Form1_Load(object sender, EventArgs e)
        {
             

           
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            load_question();
        }

        private void btn_next_question_Click(object sender, EventArgs e)
        {

            check_answer();

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
        public void check_answer()
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
        public void load_question()
        {
            startTime = DateTime.Now;
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
                timer1.Start();
            }
        }
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now.Subtract(startTime);
             txt_time.Text = span.Hours.ToString() + ":" +
           span.Minutes.ToString() + ":" + span.Seconds.ToString() + ".";
            //& span.Milliseconds
            //if (span.Minutes == 1)
                if (span.Seconds == 5)
                {
                    timer1.Stop();
                    check_answer();
                    load_question();

            }

        }
    }
}
