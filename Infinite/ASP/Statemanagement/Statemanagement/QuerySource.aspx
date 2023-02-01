<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerySource.aspx.cs" Inherits="Statemanagement.QuerySource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username :&nbsp;
            <asp:TextBox ID="Txtname" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :&nbsp;
            <asp:TextBox ID="Txtpsswd" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Btnclick" runat="server" Text="QueryRedirect" OnClick="Btnclick_Click" />
        </div>
    </form>
</body>
</html>
