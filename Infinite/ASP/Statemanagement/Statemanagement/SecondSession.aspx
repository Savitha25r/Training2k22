<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="Statemanagement.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server">
            </asp:Label><br />
            <asp:Label ID="lbl2" runat="server"></asp:Label><br />
            <asp:Button ID="btn_retrieve" runat ="server" Text="Retrieve Session" OnClick="btn_retrieve_Click" />
        </div>
    </form>
</body>
</html>
