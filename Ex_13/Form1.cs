using System;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace Ex_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rdb_select_CheckedChanged(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            DS.ReadXml("E:\\labcode_cbt\\CBT_Lab_N\\Ex_13\\student_mark_details.xml");
            dataGridView1.DataSource = DS;
            dataGridView1.DataMember = "Sem";
        }
    }
}
