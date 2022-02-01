<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="track.aspx.cs" Inherits="WebApplication1.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Track your shipment</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="/css/styles.css"/>
    <link rel="stylesheet" href="/css/loginstyles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div id="brand"><a href="home.aspx">Cargo</a></div>
            <nav>
                <ul>
                    <li><a href="track.aspx">Track Your Shipment</a></li>
                    <li><a href="calculate.aspx">Calculate price</a></li>
                    <li class="login"><a href="Login.aspx">Login</a></li>
                </ul>
            </nav>    
        </header>
         <div id="getinf" runat="server">
            <div class="inputc">
                <asp:Label ID="Sdate" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="details" runat="server" Text="Label"></asp:Label>
            </div>
             <div class="ppldtl">
                 <div>
                <asp:Label ID="Sname" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Scity" runat="server" Text="Label"></asp:Label>
                </div>       
                <div>
                <asp:Label ID="Rname" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="Rcity" runat="server" Text="Label"></asp:Label>
                </div>  
            </div>
            
        </div>
         <div class="inputd">
                <p>Enter the Shipment id you want to track:</p>
                <asp:TextBox ID="id" runat="server" ></asp:TextBox>
             </div>
        <div class="inputd">
                <asp:Button ID="search" runat="server" Text="Track" OnClick="search_Click" BorderWidth="1px" Width="150px" Height="25px" />
             </div>
        
       
    </form>
</body>
</html>
