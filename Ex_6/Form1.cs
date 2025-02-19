﻿using System;
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
        // ADO.Net Connection Object
        SqlConnection con = new SqlConnection();
        //ADO.Net Command Object
        SqlCommand cmd = new SqlCommand();
        string sql;
        private void btn_save_Click(object sender, EventArgs e)
        {
            //Connection Property
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\student_db.mdf;Integrated Security=True";
            System.Diagnostics.Debug.WriteLine(con.ConnectionString);
            // Open Connection
            con.Open();
            //Parameterized SQL Command for INSERT Records into a TABLE
            sql = "insert into student_master(rollno,student_name,dept_name,address,mobileno)values(@rno,@stuname,@dept,@address,@mobileno)";
            cmd = new SqlCommand(sql, con);
            // Add Parameter Value
            cmd.Parameters.Add("@rno", SqlDbType.Int).Value = txt_rno.Text;
            cmd.Parameters.Add("@stuname", SqlDbType.VarChar).Value = txt_stuname.Text;
            cmd.Parameters.Add("@dept", SqlDbType.VarChar).Value = cmb_deptname.SelectedItem.ToString();
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txt_address.Text;
            cmd.Parameters.Add("@mobileno", SqlDbType.VarChar).Value = txt_mobile.Text;
            //Execute method return integer value
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
                MessageBox.Show("Student's Data Inserted.");
            else
                MessageBox.Show("Student's Data Not Inserted.");
            // Close Connection
            con.Close();
        }
    }
}
