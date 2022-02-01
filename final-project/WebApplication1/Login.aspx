<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">  
    <title>Login Page</title>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="/css/loginstyles.css"/>
    <link rel="stylesheet" href="/css/styles.css"/>
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
        <div class="login-form">
            <h1>Login</h1>
                <div class="content">
                    <asp:Label ID="msg" runat="server" Text="Wrong username or password"></asp:Label>
                  <div class="input-field">
                     <asp:TextBox ID="username" runat="server" CssClass="input" placeholder="Username" ></asp:TextBox> 
                  </div>
                  <div class="input-field">
                    <asp:TextBox ID="password" runat="server" CssClass="input" TextMode="Password" placeholder="Password" ></asp:TextBox> 
                  </div>
                </div>
                <div class="action">
                  <asp:Button ID="Button1" Text="Log In" runat="server" CssClass="submit" OnClick="login_Click" class="buttonclass"/>
                </div>
        </div>
     </form>
</body>
</html>
