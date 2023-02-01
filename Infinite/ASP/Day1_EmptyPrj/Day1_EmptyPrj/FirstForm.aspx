<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstForm.aspx.cs" Inherits="Day1_EmptyPrj.FirstForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function wishes() {
            alert("Hello Js");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox>
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 57px" Text="Button" />
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <input type="button" onclick="wishes()" value="Html Button" />
        </div>
    </form>
</body>
</html>
