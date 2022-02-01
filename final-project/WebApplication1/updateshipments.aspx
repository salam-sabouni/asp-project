<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateshipments.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/css/styles.css" />
    <link rel="stylesheet" href="/css/loginstyles.css" />
</head>
<body>
    <form id="form1" runat="server" >
        <header>
            <div id="brand"><a href="employee.aspx"><asp:Label ID="Label2" runat="server"></asp:Label></a></div>
            <nav>
                <ul>
                    <li id="link1" runat="server"><a href="manageemployees.aspx">manage employees</a></li>
                    <li id="link2" runat="server"><a href="ManageShipments.aspx">manage shipments</a></li>
                    <li id="link4" runat="server"><a href="updatestatus.aspx">update shipment status</a></li>
                    <li id="link5" runat="server"><a href="updateprofile.aspx">update profile</a></li>
                    <li class="login"><asp:LinkButton ID="LinkButton2" runat="server" OnClick="Logout_Click">Log out</asp:LinkButton></li>
                </ul>
            </nav>
        </header>
        <div style="display:flex; justify-content:center;">
            <h2 style=" color:white; justify-self:center;"> enter an id to search for </h2>
        </div>
        
         <div id="search" runat="server">
            <div id="boxes" >
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div class="typebtn">
                <asp:Button ID="searchfor" Text="Search" runat="server"  OnClick="searchfor_Click"  class="buttonclass" />
            </div>
                 <h2 id="bige" runat="server">Not found!!</h2>
                  <h2 id="Lstat" runat="server">Not found!!</h2>
        </div>
        <div class="typebtn">
            <asp:Button ID="returnit" Text="iade et" runat="server"  OnClick="returnit_Click"  class="buttonclass" />
            <asp:Button ID="teslim" Text="teslim et" runat="server"  OnClick="teslim_Click"  class="buttonclass" />
            <asp:Button ID="yolda" Text="yola gonder" runat="server"  OnClick="yolda_Click"  class="buttonclass" />
        </div>
        
    </form>
</body>
</html>
