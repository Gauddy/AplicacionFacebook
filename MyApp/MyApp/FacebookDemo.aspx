<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacebookDemo.aspx.cs" Inherits="MyApp.FacebookDemo" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Log in with Facebook" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Your Email"></asp:Label><br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Your Friends"></asp:Label><br />
        <asp:ListBox ID="ListBox1" runat="server" Width="200px" Height="200px"></asp:ListBox>
    </div>
    </form>
</body>
</html>
