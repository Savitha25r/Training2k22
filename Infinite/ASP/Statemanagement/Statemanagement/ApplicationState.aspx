﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="Statemanagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblvisits" runat="server"></asp:Label><br />

            <asp:Button ID="btnapplication" Text="Find No.of Visits" runat="server" OnClick="btnapplication_Click" />
        </div>
    </form>
</body>
</html>
