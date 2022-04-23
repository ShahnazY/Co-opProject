<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AClaimInjury.aspx.cs" Inherits="AClaimInjury" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtClaimID" runat="server" style="z-index: 1; left: 267px; top: 131px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPersonalInjuryID" runat="server" style="z-index: 1; left: 267px; top: 172px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblClaimID" runat="server" style="z-index: 1; left: 129px; top: 130px; position: absolute" Text="Claim ID"></asp:Label>
        <asp:Label ID="lblPersonalInjuryID" runat="server" style="z-index: 1; left: 131px; top: 173px; position: absolute" Text="Personal Injury ID"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 267px; top: 254px; position: absolute" Text="OK" />
    </form>
</body>
</html>
