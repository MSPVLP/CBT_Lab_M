using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace PartA
{
    public partial class Ex_6 : Form
    {
        public Ex_6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        
        private void btn_save_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=c:\\users\\maniraj\\documents\\visual studio 2015\\Projects\\PartA\\student_db.mdf;Integrated Security=True";
            con.Open();
            
            cmd = new SqlCommand("insert into student_master(rollno,student_name,dept_name,address,mobileno)values(@rno,@stuname,@dept,@address,@mobileno)",con);
            cmd.Parameters.Add("@rno", SqlDbType.Int).Value = txt_rno.Text;
            cmd.Parameters.Add("@stuname", SqlDbType.VarChar).Value = txt_stuname.Text;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = cmb_deptname.SelectedItem.ToString();
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txt_address.Text;
            cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = txt_mobile.Text;
            int x=cmd.ExecuteNonQuery();
            if (x == 1)
                MessageBox.Show("Students Data Inserted");
            else
                MessageBox.Show("Students Data Not Inserted");

            con.Close();

        }

       
    }
}
