<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryDestination.aspx.cs" Inherits="Statemanagement.QueryDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbldata" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Get QueryString" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
