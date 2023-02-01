<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFields.aspx.cs" Inherits="Statemanagement.HiddenFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Input 1 :&nbsp;
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <br />
            Input 2 :&nbsp;
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <asp:Button ID="btn_store" runat="server" Text="Store" OnClick="btn_store_Click"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_load" runat="server" Text="Load" OnClick="btn_load_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
