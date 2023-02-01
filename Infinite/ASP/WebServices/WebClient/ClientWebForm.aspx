<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientWebForm.aspx.cs" Inherits="WebClient.ClientWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter Your Name : <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
        Enter a Real Number :<asp:TextBox ID="txtnum" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="hellobtn" runat="server" Text="ForHelloMessage" OnClick="hellobtn_Click" />
        <asp:Button ID="msgbtn" runat="server" Text="For Message" OnClick="msgbtn_Click" />
        <asp:Button ID="sqbtn" runat="server" Text="ForSquare" OnClick="sqbtn_Click" />
        <br /><br />
        <asp:Label ID="lbldata" runat="server"></asp:Label>
    </form>
</body>
</html>
