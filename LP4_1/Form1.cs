using System;
using System.Windows.Forms;

namespace LP4_1
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
            // a format i.e, 12/04/2021  
            string currentDate1 = DateTime.Now.ToString("dd/MM/yyyy");
            // Displaying the current date
            MessageBox.Show(currentDate1);
        }
    }
}
