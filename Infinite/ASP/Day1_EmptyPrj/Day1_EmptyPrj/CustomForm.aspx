<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="Day1_EmptyPrj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                }
                else {
                    args.IsValid = false;
                }
            }
        }
    </script>
</head>
<body>
    <h1> Using Client and Server Side Validations</h1>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number : &nbsp;<asp:TextBox ID="txtnum"
              runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" 
                ControlToValidate="txtnum" 
                ErrorMessage="Not a Positive or an Even Number" ForeColor="Red" 
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="True" ClientValidationFunction="IsEven"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="SaveBtn" runat="server" Text="Save" OnClick="SaveBtn_Click" />

            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
