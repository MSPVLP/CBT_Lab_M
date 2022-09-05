
using System;
namespace PartA
{
public class Ex_7
{
    static void Main()
    {
         protected void btnlogin_Click(object sender, EventArgs e)
            {
                if (txtuname.Text == "")
                {
                    Lbl_result.Text = "Enter UserName";
                }
                else if (txtupass.Text == "")
                {
                    Lbl_result.Text = "Enter Password";
                }
                else
                {
        		// Program tocheck whether given username and password is equal to
        		//   “Computer” & “mspvl” 
                    if(txtuname.Text=="Computer" && txtupass.Text=="mspvl")
                    {
                        Lbl_result.Text = "Login Success";
                    }
                    else
                    {
                        Lbl_result.Text = "Invalid Name or Password";
                    }
                 }
           }

    }
}
}
