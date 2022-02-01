<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="/css/styles.css"/>
    <link rel="stylesheet" href="/css/loginstyles.css"/>
</head>
<body>
    
    <form id="form1" runat="server">
    <header>
        <div id="brand"><a href="/">Cargo</a></div>
        <nav>
            <ul>
                <li><a href="track.aspx">Track Your Shipment</a></li>
                <li><a href="calculate.aspx">Calculate price</a></li>
                <li class="login"><a href="Login.aspx">Login</a></li>
            </ul>
        </nav>    
    </header>
        <div class="cont">
             <div class="side">
                 <h2>You can track your shipment by following the link below</h2>
                 <asp:Button ID="Button2" runat="server" Text="Button" CssClass="homebtn" OnClick="Button2_Click" />
             </div>

            <img src="/media/5.png"  width="500" height="500" class="frontimg">
                       
            <div class="side">
                <h2>You can calculate the cost of your shipment by following the link below</h2>
                <asp:Button ID="Button1" runat="server" Text="Button" CssClass="homebtn" OnClick="Button1_Click" />
             </div>
        </div>
    
    </form>
    
</body>
</html>
