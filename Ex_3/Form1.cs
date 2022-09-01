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
        string operation=string.Empty;
        double memory,result = 0.0;
        private void NumEvent(object sender, EventArgs e)
        {              
            Button btn = (Button)sender;
            txt_result.Text += btn.Text;
        }
        private void OperatorsEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;

            operand1 = double.Parse(txt_result.Text);
            txt_result.Text = "";
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
        }
        private void btn_memory_Click(object sender, EventArgs e)
        {
            memory =double.Parse( txt_result.Text);
            txt_result.Clear();
        }
        private void btn_recall_Click(object sender, EventArgs e)
        {
            txt_result.Text = memory.ToString();
        }
        private void btn_result_Click(object sender, EventArgs e)
        {
            operand2 = double.Parse(txt_result.Text);

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
                    result = (operand1) / (operand2);
                    break;
                case "%":
                    result = (operand1) % (operand2);
                    break;
                default:
                    break;
            }
            txt_result.Text = result.ToString();
        }         
    }
}
