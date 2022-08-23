using System;

using System.Windows.Forms;

namespace Ex4
{
    public partial class Calendar_Control_Ex4 : Form
    {
        public Calendar_Control_Ex4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_day.Text = dateTimePicker1.Value.Day.ToString();
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();

            txt_dayname.Text = dateTimePicker1.Value.ToString("dddd");
            txt_monthname.Text = dateTimePicker1.Value.ToString("MMMM");

        }
    }
}
