using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex_7
{
    public partial class login : System.Web.UI.Page
    { 
        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
                lbl_result.Text = "Enter UserName";
            else if (txtpassword.Text == "")
                lbl_result.Text = "Enter Password";
            else
            {
                // check whether given username and password is equal to
                //   “Computer” & “mspvl”
                if (txtusername.Text == "Computer" && txtpassword.Text == "mspvl")
                    lbl_result.Text = "Login Success";
                else
                    lbl_result.Text = "Invalid Name or Password";
            }
        }
    }
}