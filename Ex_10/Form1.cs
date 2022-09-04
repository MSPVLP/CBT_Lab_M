using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex_10
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
         
        SqlDataAdapter ada;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public void connect()
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\CBT_LabCode\\CBT_Lab_N\\Ex_9\\student_details_db.mdf;Integrated Security=True";
            con.Open();
        }
        public void BindData()
        {
            // Call connect function 
            connect(); 
            ada = new SqlDataAdapter("select * from student_master", con); 
            SqlCommandBuilder cmdb = new SqlCommandBuilder(ada);
            ada.Fill(ds, "student_master");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "student_master"; 
            con.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int x;
            x = ada.Update(ds, "student_master");
            if (x == 1)
                MessageBox.Show("RECORD UPDATED");
            else
                MessageBox.Show("RECORD NOT UPDATED"); 
        }
    }
}
