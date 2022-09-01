using System;
using System.Windows.Forms;

namespace Ex_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Displays the day number
            txt_day.Text = dateTimePicker1.Value.Day.ToString();
            // Displays the month number
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            // Displays the year
            txt_year.Text = dateTimePicker1.Value.Year.ToString();

            //Displays the day
            txt_dayname.Text = dateTimePicker1.Value.ToString("dddd");
            //Displays the month name
            txt_monthname.Text = dateTimePicker1.Value.ToString("MMMM");
        }
    }
}
