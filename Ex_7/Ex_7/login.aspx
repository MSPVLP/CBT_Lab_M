<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Ex_7.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset style="width:600px;">
                <legend>Student Entry</legend>
                <table align="center"  style="border: 1px solid #dbcece">
                   <tr>
                    <td colspan="3"
                        style="text-align: center; font-weight: 700; border-bottom-style: solid;border-bottom-width: thin; border-bottom-color: #008080;">User Login Area</td>
                </tr>
                <tr>
                    <td colspan="3" >
                       <span style="color:red;"><asp:Label ID="lbl_result" runat="server"></asp:Label></span>
                    </td>
                </tr>
                <tr>
                    <td ><span style="color: blue;">UserName :</span></td>
                    <td >
                        <asp:TextBox ID="txtusername" runat="server" Width="120px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                   <td ><span style="color: blue;">Password :</span></td>
                    <td >
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" Width="120px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">

                        <asp:Button ID="btn_login" runat="server" OnClick="btn_login_Click" Text="Login" />

                    </td>
                    
                </tr>
            </table>
                 </fieldset>
    </div>
    </form>
</body>
</html>
