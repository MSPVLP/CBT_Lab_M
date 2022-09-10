using System;
using System.Windows.Forms;

namespace Ex_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double operand1,operand2;
        string operation = string.Empty;
        double memory, result = 0.0;

        private void NumEvent(object sender, EventArgs e)
        {              
            Button btn = (Button)sender;
            txt_result.Text += btn.Text;
        }

        private void OperatorsEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;

            if (txt_result.Text != "")
                operand1 = double.Parse(txt_result.Text);
            else
                operand1 = 0;

            txt_result.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
        }

        private void btn_memory_Click(object sender, EventArgs e)
        {
            if(txt_result.Text!="")
                memory += double.Parse(txt_result.Text);
        }

        private void btn_memory_clear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void btn_recall_Click(object sender, EventArgs e)
        {
            txt_result.Text = memory.ToString();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (txt_result.Text != "")
                operand2 = double.Parse(txt_result.Text);
            else
                operand2 = 0;

            switch (operation)
            {
                case "+":
                    result = (operand1) + (operand2);
                    break;
                case "-":
                    result = (operand1) - (operand2);
                    break;
                case "*":
                    result = (operand1) * (operand2);
                    break;
                case "/":
                    if (operand2 != 0)
                        result = (operand1) / (operand2);
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.","Error");
                        result = 0;
                    }
                    break;
                default:
                    break;
            }
            
            txt_result.Text = result.ToString();
        }         
    }
}
