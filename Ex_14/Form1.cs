using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        //CONNECTION OBJECT
        SqlConnection con = new SqlConnection();
        // COMMAND OBJECT
        SqlCommand cmd = new SqlCommand(); 
        DataSet ds = new DataSet();        
        private void rdb_select_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();            
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + openFileDialog1.FileName + @";Integrated Security=True;Integrated Security=True";
            con.Open();           
            cmd.Connection = con;
            cmd.CommandText = "select * from student_master ";
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = cmd;
            ada.Fill(ds, "student_master");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "student_master";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            ds.WriteXml("E:\\labcode_cbt\\CBT_Lab_N\\Ex_14\\student_details.xml", XmlWriteMode.WriteSchema);
            con.Close();
            MessageBox.Show("Sucessfully Written students data from database to XML...");
        }
    }
}
