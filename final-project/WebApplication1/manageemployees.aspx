<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageemployees.aspx.cs" Inherits="WebApplication1.manageemployees" %>

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
        <div class="table">
            <asp:GridView runat="server" ID="datagrid"  AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="Gridview1_SelectedIndexChanged" CssClass="mydatagrid" PagerStyle-CssClass="pager"
                HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" >
                <SelectedRowStyle CssClass="selectedRowStyle" />
                  <Columns >  
                      <asp:BoundField HeaderText ="ID"  DataField ="id" /> 
                      <asp:BoundField HeaderText ="Username"  DataField ="UserName" />  
                      <asp:BoundField HeaderText ="First Name" DataField ="FirstName" />  
                      <asp:BoundField HeaderText ="Last Name" DataField ="LastName" />     
                      <asp:BoundField HeaderText ="Role" DataField ="UserRole" /> 
                  </Columns>  
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1"  ConnectionString="<%$ ConnectionStrings:webbased %>" SelectCommand="SELECT * FROM Employee"  ></asp:SqlDataSource>
        </div>
       
        <div class="login-form" style=" margin-top:0;">
            <h1>Control Panel</h1>
                <div class="content">

                    <div class="messages">
                        <asp:Label ID="msg" runat="server" Text="UserName already exists"></asp:Label>
                        <asp:Label ID="msg2" runat="server" Text="Cannot Delete your own account"></asp:Label>
                        <asp:Label ID="msg3" runat="server" Text="Account has been updated successfully"></asp:Label>
                        <asp:Label ID="msg4" runat="server" Text="Account has been deleted successfully"></asp:Label>
                    </div>
                    
                    <h3>Account Type</h3>
                    <div class="input-field">
                         <asp:DropDownList ID="AccountType" runat="server" CssClass="ddl">
                              <asp:ListItem Value="admin">admin</asp:ListItem>
                              <asp:ListItem Value="manager">manager</asp:ListItem>
                              <asp:ListItem Value="employee">employee</asp:ListItem>
                         </asp:DropDownList>
                    </div>
                    <h3>First Name </h3>
                    <div class="input-field">
                         <asp:TextBox ID="Fname" runat="server" CssClass="input" ></asp:TextBox> 
                    </div>
                    <h3>Last Name</h3>
                    <div class="input-field">
                         <asp:TextBox ID="Lname" runat="server" CssClass="input" ></asp:TextBox> 
                    </div>
                    <h3>Username</h3>
                    <div class="input-field">
                        <asp:TextBox ID="Username" runat="server" CssClass="input" ></asp:TextBox> 
                    </div>
                    
                    <h3 id="passheader" runat="server">Password</h3>
                    <div class="input-field" id="pass" runat="server">
                        <asp:TextBox ID="Password" runat="server" CssClass="input" TextMode="Password"></asp:TextBox> 
                    </div>
                </div>
                <asp:LinkButton ID="ADD" runat="server" CssClass="link" OnClick="ADD_Click"  >Add New employee instead</asp:LinkButton>
                <asp:LinkButton ID="Manage" runat="server" CssClass="link" OnClick="Manage_Click"  >Manage existing employee instead</asp:LinkButton>
                <div class="action">
                    <asp:Button ID="Update" Text="Update" runat="server" CssClass="submit" OnClick="Update_Click" class="buttonclass" />
                    <asp:Button ID="Delete" Text="Delete" runat="server" CssClass="submit" OnClick="Delete_Click" class="buttonclass" />
                    <asp:Button ID="AddNew" Text="Add" runat="server" CssClass="submit" OnClick="AddNew_Click" class="buttonclass" />
                </div>
        </div>
    </form>
</body>
</html>
