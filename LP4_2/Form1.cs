using System;
using System.Windows.Forms;

namespace LP4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime currentDate1 = DateTime.Now;
            label1.Text = currentDate1.ToString(listBox1.Text);
        }
    }
}
