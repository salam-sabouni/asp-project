<%@ Page Language="C#"  MaintainScrollPositionOnPostback="true" AutoEventWireup="true" CodeBehind="ManageShipments.aspx.cs" Inherits="WebApplication1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/css/styles.css" />
    <link rel="stylesheet" href="/css/loginstyles.css" />
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
        <div class="typebtn">
            <asp:Button ID="AddNewbtn" Text="Add new" runat="server"  OnClick="ADD_Click"  class="buttonclass" />
             <asp:Button ID="ManageExisting" Text="Manage Existing" runat="server"  OnClick="Manage_Click"  class="buttonclass" />
        </div>
        
        <div id="search" runat="server">
             <asp:DropDownList ID="Searchtype" runat="server" CssClass="drpdown" OnSelectedIndexChanged="Searchtype_SelectedIndexChanged" AutoPostBack="true" >
                   <asp:ListItem Value="id">Shipment id</asp:ListItem>
                   <asp:ListItem Value="Sname">Sender Name</asp:ListItem>
                   <asp:ListItem Value="Rname">Reciever Name</asp:ListItem>
             </asp:DropDownList>
            <div id="boxes" >
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Calculate_Price" ></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="Calculate_Price" ></asp:TextBox>
                
            </div>
            <div class="typebtn">
                <asp:Button ID="searchfor" Text="Search" runat="server"  OnClick="searchfor_Click"  class="buttonclass" />
            </div>
                 <h2 id="bige" runat="server">Not found!!</h2>
        </div>
        
       <asp:GridView runat="server" ID="datagrid"  AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="datagrid_SelectedIndexChanged" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" >
                <SelectedRowStyle CssClass="selectedRowStyle" />
                  <Columns >  
                      <asp:BoundField HeaderText ="shipment id"  DataField ="id" /> 
                      <asp:BoundField HeaderText ="Sender Fname"  DataField ="SenderFirstName" /> 
                      <asp:BoundField HeaderText ="Sender Lname"  DataField ="SenderLastName" />  
                      <asp:BoundField HeaderText ="Reciever Fname" DataField ="RecieverFirstName" />  
                      <asp:BoundField HeaderText ="Reciever Lname" DataField ="RecieverLastName" />     
                      <asp:BoundField HeaderText ="Date" DataField ="Sdate" /> 
                  </Columns>  
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1"  ConnectionString="<%$ ConnectionStrings:webbased %>" SelectCommand="SELECT * FROM Shipments "  ></asp:SqlDataSource>

        <div class="login-form" style=" width:800px; margin: 10px auto">  
            <h1>Control Panel</h1>
                <div class="content">

                    <div class="messages">
                        <asp:Label ID="msg" runat="server" Text="Error"></asp:Label>
                        <asp:Label ID="msg2" runat="server" Text="Shipment has been updated successfully"></asp:Label>
                        <asp:Label ID="msg3" runat="server" Text="Shipment has been added successfully"></asp:Label>
                        <asp:Label ID="msg4" runat="server" Text="Shipment has been deleted successfully"></asp:Label>
                    </div>
                    
                    <h3>Shipment Type</h3>
                    <div class="input-field">
                         <asp:DropDownList ID="ShipmentType" runat="server" CssClass="ddl">
                              <asp:ListItem Value="normal">Normal</asp:ListItem>
                              <asp:ListItem Value="air">by air</asp:ListItem>
                         </asp:DropDownList>
                    </div>

                    <h3>Package Dimensions</h3>
                    <div class="input-field">
                        <div>
                             <asp:TextBox ID="Xd" runat="server" OnTextChanged="Calculate_Price" AutoPostBack="true" ></asp:TextBox>
                             <p>cm</p>
                        </div>
                        <div>
                             <asp:TextBox ID="Yd" runat="server" OnTextChanged="Calculate_Price" AutoPostBack="true"></asp:TextBox>
                             <p>cm</p>
                        </div>
                        <div>
                             <asp:TextBox ID="Zd" runat="server" OnTextChanged="Calculate_Price" AutoPostBack="true"></asp:TextBox>
                             <p>cm</p>
                        </div>
                    </div>

                    <h3>Package weight</h3>
                    <div class="input-field">
                        <div>
                              <asp:TextBox ID="weight" runat="server" OnTextChanged="Calculate_Price" AutoPostBack="true"></asp:TextBox>
                            <p>g</p>
                        </div>

                    </div>
                        <div>  
                            <div class="sender" style=" display: inline-block; margin: 0 50px; ">
                            <h2 style="margin: 20px 0;">Sender Details</h2>
                            <h3>City</h3>
                            <div class="input-field">
                                <asp:DropDownList ID="SCity" runat="server" CssClass="ddl"></asp:DropDownList>
                            </div>
                            <h3>First Name </h3>
                            <div class="input-field">
                                 <asp:TextBox ID="SFname" runat="server" CssClass="input" ></asp:TextBox> 
                            </div>
                            <h3>Last Name</h3>
                            <div class="input-field">
                                 <asp:TextBox ID="SLname" runat="server" CssClass="input" ></asp:TextBox> 
                            </div>
                        </div>
                        <div class="reciever" style=" display: inline-block; margin: 0 50px; ">
                            <h2 style="margin: 20px 0;">Reciever Details</h2>
                            <h3>City</h3>
                            <div class="input-field">
                                <asp:DropDownList ID="RCity" runat="server" CssClass="ddl"></asp:DropDownList>
                            </div>
                            <h3>First Name </h3>
                            <div class="input-field">
                                 <asp:TextBox ID="RFname" runat="server" CssClass="input" ></asp:TextBox> 
                            </div>
                            <h3>Last Name</h3>
                            <div class="input-field">
                                 <asp:TextBox ID="RLname" runat="server" CssClass="input" ></asp:TextBox> 
                            </div>
                        </div>
                    </div>
                    
                </div>
                <asp:Label ID="price" runat="server" CssClass="link" >Price : 0.00 ₺</asp:Label>
                <div class="action">
                    <asp:Button ID="Update" Text="Update" runat="server" CssClass="submit" OnClick="Update_Click" class="buttonclass" />
                    <asp:Button ID="Delete" Text="Delete" runat="server" CssClass="submit" OnClick="Delete_Click" class="buttonclass" />
                    <asp:Button ID="AddNew" Text="Add" runat="server" CssClass="submit" OnClick="AddNew_Click" class="buttonclass" />
                </div>
        </div>

    </form>
</body>
</html>
