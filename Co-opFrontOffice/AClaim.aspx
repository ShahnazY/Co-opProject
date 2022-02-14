<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AClaim.aspx.cs" Inherits="AClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 246px; top: 178px; position: absolute" Text="Location"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" style="z-index: 1; left: 332px; top: 178px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 307px; top: 250px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 325px; top: 297px; position: absolute" Text="OK" />
    </form>
</body>
</html>
