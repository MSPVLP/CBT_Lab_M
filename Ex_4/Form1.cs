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

            DateTime dt = dateTimePicker1.Value;

            //Displays the day number
            txt_day.Text = dt.Day.ToString();

            // Displays the month number
            txt_month.Text = dt.Month.ToString();

            // Displays the year
            txt_year.Text = dt.Year.ToString();

            //Displays the day
            txt_dayname.Text = dt.ToString("dddd");

            //Displays the month name
            txt_monthname.Text = dt.ToString("MMMM");
        }
    }
}
