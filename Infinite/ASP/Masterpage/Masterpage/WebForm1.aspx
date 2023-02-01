<%@ Page Title="" Language="C#" MasterPageFile="~/Mymaster.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Masterpage.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MasterContent" runat="server">

    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>

