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
            // Getting the string form of the current date in
            // different format  
            DateTime currentDate1 = DateTime.Now;
            MessageBox.Show(currentDate1.ToString("dddd, dd MMMM yyyy"));
            MessageBox.Show(currentDate1.ToString("MM/dd/yyyy HH:mm"));
            MessageBox.Show(currentDate1.ToString("MM/dd/yyyy hh:mm tt"));
            MessageBox.Show(currentDate1.ToString("MM/dd/yyyy H:mm"));
            MessageBox.Show(currentDate1.ToString("MM/dd/yyyy h:mm tt"));
            MessageBox.Show(currentDate1.ToString("MM/dd/yyyy HH:mm:ss"));
            MessageBox.Show(currentDate1.ToString("MMMM dd"));
        }
    }
}
