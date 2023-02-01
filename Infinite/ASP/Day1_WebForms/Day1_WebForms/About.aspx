<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Day1_WebForms.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="newBtn" runat="server" Text="My New Button" BackColor="#3333CC"
            BorderColor="White" BorderStyle="Groove" BorderWidth="5px" ForeColor="White" />
    </p>
</asp:Content>
