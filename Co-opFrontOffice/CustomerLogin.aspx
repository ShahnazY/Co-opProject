<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 298px; top: 180px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 297px; top: 236px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 183px; top: 183px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 184px; top: 235px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 220px; top: 323px; position: absolute"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 185px; top: 140px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 299px; top: 127px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 191px; top: 387px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 378px; top: 390px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
