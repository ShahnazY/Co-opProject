﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteClaim.aspx.cs" Inherits="DeleteClaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 129px; top: 101px; position: absolute" Text="Are you sure you want to delete this claim?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 132px; top: 172px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 321px; top: 173px; position: absolute" Text="No" />
    </form>
</body>
</html>
