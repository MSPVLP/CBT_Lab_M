using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ex_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\student_db.mdf;Integrated Security=True";
            System.Diagnostics.Debug.WriteLine(con.ConnectionString);
            con.Open();
            sql = "insert into student_master(rollno,student_name,dept_name,address,mobileno)values(@rno,@stuname,@dept,@address,@mobileno)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@rno", SqlDbType.Int).Value = txt_rno.Text;
            cmd.Parameters.Add("@stuname", SqlDbType.VarChar).Value = txt_stuname.Text;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = cmb_deptname.SelectedItem.ToString();
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txt_address.Text;
            cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = txt_mobile.Text;

            int result = cmd.ExecuteNonQuery();

            if (result == 1)
                MessageBox.Show("Student's Data Inserted.");
            else
                MessageBox.Show("Student's Data Not Inserted.");

            con.Close();
        }
    }
}
