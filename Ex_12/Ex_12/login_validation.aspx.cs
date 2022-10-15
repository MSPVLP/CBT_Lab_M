using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Ex_12
{
    public partial class login_validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\labcode_cbt\\CBT_Lab_N\\Ex_12\\Ex_12\\App_Data\\Validator_db.mdf;Integrated Security=True";

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            Response.Write("Connection MAde");
            conn.Close();
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {

        }
    }
}