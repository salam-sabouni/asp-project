<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Control Panel</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
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
   
            <center>
                <h1>
                    <asp:Label ID="Label1" runat="server" Text="hey" CssClass="lbl1"></asp:Label></h1>
            </center>
        <div class="cont">
             <div class="side">
                 <h2>You can update a shipment status by following the link below</h2>
                 <asp:Button ID="Button2" runat="server" Text="Button" CssClass="homebtn" OnClick="Button2_Click" />
             </div>

            <img src="/media/5.png"  width="500" height="500" class="frontimg">
                       
            <div class="side">
                <h2>You can update your profile by following the link below</h2>
                <asp:Button ID="Button1" runat="server" Text="Button" CssClass="homebtn" OnClick="Button1_Click" />
             </div>
        </div>
    </form>
</body>
</html>
