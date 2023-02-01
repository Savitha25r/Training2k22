<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDestination.aspx.cs" Inherits="Statemanagement.CookieDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" Text="" runat="server"></asp:Label><br />
            <asp:Label ID="lbl2" Text="" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnGetData" Text="Click to get Data" runat="server" OnClick="btnGetData_Click" />
        </div>
    </form>
</body>
</html>
