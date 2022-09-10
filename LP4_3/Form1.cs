using System;
using System.Windows.Forms;

namespace LP4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_click_to_add_Click(object sender, EventArgs e)
        {
            DateTime currentDate1 = DateTime.Now;
            DateTime addedDate = currentDate1.AddDays(int.Parse(txt_input.Text));
            MessageBox.Show(addedDate.ToString("F"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_current_date.Text = DateTime.Now.ToString();
        }
        private void btn_add_month_Click(object sender, EventArgs e)
        {
            DateTime currentDate1 = DateTime.Now;
            DateTime addedmonth = currentDate1.AddMonths(int.Parse(txt_input.Text));
            MessageBox.Show(addedmonth.ToString("F"));
        }
        private void btn_add_year_Click(object sender, EventArgs e)
        {
            DateTime currentDate1 = DateTime.Now;
            DateTime addedyear = currentDate1.AddYears(int.Parse(txt_input.Text));
            MessageBox.Show(addedyear.ToString("F"));
        }
    }
}
