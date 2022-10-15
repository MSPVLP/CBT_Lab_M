using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Ex_12_A
{
    public partial class User_register : System.Web.UI.Page
    {
       protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\labcode_cbt\\CBT_Lab_N\\Ex_12_A\\App_Data\\ex_12A_db.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO user_register(User_Name,Password,Age) VALUES(@name,@pass,@age)");
            int x;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@name", txtusername.Text);
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            con.Open();
            x = cmd.ExecuteNonQuery();
            if (x == 1)
               Response.Write("<script>alert('Registered Successful...');</script>");
            else
               Response.Write("<script>alert('Not Registered...');</script>");
            con.Close();
          }
    }
}