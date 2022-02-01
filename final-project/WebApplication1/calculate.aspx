<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculate.aspx.cs" Inherits="WebApplication1.calculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculate Prices</title>
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
        <div>
            <div class="inputd">
                <p>Select a Shipping type:</p>
                <asp:DropDownList ID="Type" runat="server" CssClass="drpdown"></asp:DropDownList>
                <p>From:</p>
                <asp:DropDownList ID="Sender" runat="server" CssClass="drpdown"></asp:DropDownList>
                <p>to:</p>
                <asp:DropDownList ID="Reciever" runat="server" CssClass="drpdown"></asp:DropDownList>
            </div>
            <div class="inputd">
                <p>Enter the Package's x length in :</p>
                <asp:TextBox ID="x" runat="server"></asp:TextBox>
                <p>Enter the Package's y length in cm:</p>
                <asp:TextBox ID="y" runat="server"></asp:TextBox>
            </div>       
            <div class="inputd">
                <p>Enter the Package's z length in cm:</p>
                <asp:TextBox ID="z" runat="server" ></asp:TextBox>
                <p>Enter the Package's weight in grams:</p>
                <asp:TextBox ID="w" runat="server"></asp:TextBox>

            </div>  
            <div class="inputd">
                <asp:Button ID="calc" runat="server" Text="Calculate" OnClick="calc_Click" BorderWidth="1px" Width="120px" Height="25px" />
                <h2 id="price" runat="server">Price</h2>
            </div>
        </div>
    </form>
</body>
</html>
