<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClaimList.aspx.cs" Inherits="ClaimList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstClaims" runat="server" style="z-index: 1; left: 186px; top: 130px; position: absolute; height: 217px; width: 356px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 194px; top: 388px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 266px; top: 387px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 201px; top: 460px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 354px; top: 388px; position: absolute" Text="Edit" />
    </form>
</body>
</html>
