<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DogList.aspx.cs" Inherits="InsuranceList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstDogs" runat="server" BackColor="#FDC995" style="z-index: 1; left: 315px; top: 146px; position: absolute; height: 189px; width: 361px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 312px; top: 338px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 437px; top: 337px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 563px; top: 337px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
