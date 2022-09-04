<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_validation.aspx.cs" Inherits="Ex_12.login_validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 334px;
        }
        .auto-style2 {
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width:600px;">
          <legend>Required Field Validator in asp.net</legend>
              <table align="center"  style="border: 1px solid #dbcece">
                <tr>
                    <td colspan="3" style="text-align: center; font-
				weight: 700; border-bottom-style: solid;border-
				bottom-width: thin; border-bottom-
				color:#008080;">User Login Area</td>
                </tr>
                <tr>
                    <td >&nbsp;</td>
                    <td >&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td >UserName :</td>
                    <td >
                        <asp:TextBox ID="txtusername" runat="server" 
				Width="120px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
				ID="RequiredFieldValidator3" runat="server" 
				ControlToValidate="txtusername" 
				ErrorMessage="Please, enter username"  
				ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td >Password :</td>
                    <td >
                        <asp:TextBox ID="txtpassword" runat="server" 
				TextMode="Password" Width="120px"> 
			      </asp:TextBox>
                    </td>


                    <td>
                        <asp:RequiredFieldValidator 
				ID="RequiredFieldValidator4" 
				runat="server" ControlToValidate="txtpassword" 
				ErrorMessage="Please, enter password"
                          ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
            </table>
                 </fieldset>

    </div>
        <div>
  	<fieldset style="width:600px;">
       <legend>RangeValidator in asp.net</legend>
          <table align="center"  style="border: 1px solid #dbcece" class="auto-style2">
            <tr>
                <td>Age <span style="color:red;">*</span></td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="rgvAge" runat="server" ErrorMessage="Please enter age between 18 to 30" ForeColor="#FF3300" MaximumValue="30" MinimumValue="18" SetFocusOnError="True" Type="Integer" ControlToValidate="txtAge">
			  </asp:RangeValidator>
                </td>
                <td> </td>
             </tr> 
		  <tr>
                <td>&nbsp;</td>
                <td class="auto-style1">
                   <asp:Button ID="btnlogin" runat="server" 
				OnClick="btnlogin_Click" Text="Login" />
                </td>
                <td> </td>
            </tr>
        </table>
    </fieldset>
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    </form>
</body>
</html>
