<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstSession.aspx.cs" Inherits="Statemanagement.FirstSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtname" runat="server" ></asp:TextBox><br />
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnsession" Text="SetSession" runat="server" OnClick="btnsession_Click" />
        </div>
    </form>
</body>
</html>
