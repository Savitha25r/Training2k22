<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationForm.aspx.cs" Inherits="Day1_EmptyPrj.ValidationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center">Registration Form</h2>
            UserName : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="uname" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uname" ErrorMessage="User Name cannot be Blank" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>

            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" ErrorMessage="Please Enter Password" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cpassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cpassword" Display="Dynamic" ErrorMessage="Confirm password is a must" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="cpassword" Display="Dynamic" ErrorMessage="Mismatch in password" ForeColor="Red" ValidationGroup="Register">*</asp:CompareValidator>
            <br />
            <br />
            Age&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="age" Display="Dynamic" ErrorMessage="Age must be between 21 and 60" ForeColor="Red" MaximumValue="60" MinimumValue="21" Type="Integer" ValidationGroup="Register">*</asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="age" Display="Dynamic" ErrorMessage="Enter age" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Email&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="Invalid Email.. Enter correctly" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Register">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="Email is mandatory" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" ValidationGroup="Register" />

            <br />
            <br />
            </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Register" />
    <div>
        <h2 style="text-align:center">Login Form</h2>
        Login Name : <asp:TextBox ID="login" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
            ControlToValidate="login" ErrorMessage="Enter Login name" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>

        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="lpassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter Password" ControlToValidate="lpassword" ForeColor="Red" ValidationGroup="Login">*</asp:RequiredFieldValidator>

        <br />
        <br />
        <asp:Button ID="LoginBtn" runat="server" Text="Login" ValidationGroup="Login" />
         <asp:ValidationSummary ID="ValidationSummary2" runat="server"  ForeColor="Red" ValidationGroup="Login"/>
    </div>
       
    </form>
</body>
</html>
