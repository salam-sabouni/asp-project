<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="/css/loginstyles.css"/>
    <link rel="stylesheet" href="/css/styles.css"/>
</head>
<body>
    <form id="form1" runat="server">
         <header>
        <div id="brand"><a href="employee.aspx"><asp:Label ID="Label2" runat="server"></asp:Label></a></div>
            <nav>
                <ul>
                    <li id="link1" runat="server"><a href="manageemployees.aspx">manage employees</a></li>
                    <li id="link2" runat="server"><a href="ManageShipments.aspx">manage shipments</a></li>
                    <li id="link4" runat="server"><a href="updateshipments.aspx">update shipment status</a></li>
                    <li id="link5" runat="server"><a href="updateprofile.aspx">update profile</a></li>
                    <li class="login"><asp:LinkButton ID="LinkButton2" runat="server" OnClick="Logout_Click">Log out</asp:LinkButton></li>
                </ul>
            </nav>    
        </header>
        <div class="login-form">
            <h1>Update your profile</h1>
                <div class="content">
                    <div class="messages">
                        <asp:Label ID="AccountType" runat="server" Text="User Name already exists"></asp:Label>
                        <asp:Label ID="msg" runat="server" Text="User Name already exists"></asp:Label>
                        <asp:Label ID="msg2" runat="server" Text="Wrong Password"></asp:Label>
                        <asp:Label ID="msg3" runat="server" Text="User Name has been Changed Successfully"></asp:Label>
                        <asp:Label ID="msg4" runat="server" Text="Password has been Changed Successfully"></asp:Label>
                    </div>
                    
                  <div class="input-field">
                      <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password" placeholder="current password"></asp:TextBox>
                      <asp:TextBox ID="Oldpassword" runat="server" TextMode="Password"  placeholder="old password"></asp:TextBox>
                  </div>
                  <div class="input-field">
                      <asp:TextBox ID="Newpassword" runat="server" TextMode="Password" placeholder="new password"></asp:TextBox>
                      <asp:TextBox ID="NewUsername" runat="server"  placeholder="new username"></asp:TextBox>
                  </div>
                </div>
                <asp:LinkButton ID="Passform" runat="server" OnClick="ChangePass_Click" CssClass="link" >Change Password instead?</asp:LinkButton>
                <asp:LinkButton ID="UserNameform" runat="server" OnClick="ChangeUsername_Click" CssClass="link" >Change Username instead?</asp:LinkButton>
                <div class="action">
                    <asp:Button ID="Button1" runat="server" Text="Change password" OnClick="Updatepassword_Click" />
                    <asp:Button ID="Button2" runat="server" Text="Change Username" OnClick="UpdateUsername_Click" />
                </div>

        </div>

    </form>
</body>
</html>
