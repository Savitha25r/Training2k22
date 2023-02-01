<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="Statemanagement.CookieSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username :&nbsp;
            <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :&nbsp;
            <asp:TextBox ID="Textpsswd" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_redirect" runat="server" Text="Redirect" OnClick="btn_redirect_Click" />
&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
