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
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 246px; top: 178px; position: absolute" Text="Status"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 307px; top: 250px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 325px; top: 297px; position: absolute; right: 200px; height: 26px;" Text="OK" />
        <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 249px; top: 131px; position: absolute" Text="Location"></asp:Label>
        <asp:Label ID="lblDateOfClaim" runat="server" style="z-index: 1; left: 512px; top: 129px; position: absolute" Text="Date of Claim"></asp:Label>
        <asp:Label ID="lblDateOfInjury" runat="server" style="z-index: 1; left: 512px; top: 173px; position: absolute" Text="Date of Injury"></asp:Label>
        <asp:Label ID="lblEvidenceProvided" runat="server" style="z-index: 1; left: 514px; top: 232px; position: absolute" Text="Evidence Provided"></asp:Label>
        <asp:RadioButton ID="rbYes" runat="server" style="z-index: 1; left: 651px; top: 232px; position: absolute; right: 881px" Text="Yes" />
        <asp:RadioButton ID="rbNo" runat="server" style="z-index: 1; left: 715px; top: 232px; position: absolute" Text="No" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 398px; top: 298px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtDateOfClaim" runat="server" style="z-index: 1; left: 635px; top: 123px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOfInjury" runat="server" style="z-index: 1; left: 632px; top: 174px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtClaimID" runat="server" style="z-index: 1; left: 328px; top: 78px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblClaimID" runat="server" style="z-index: 1; left: 235px; top: 80px; position: absolute" Text="Claim ID"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 491px; top: 76px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 331px; top: 130px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlStatus" runat="server" style="z-index: 1; left: 331px; top: 175px; position: absolute">
            <asp:ListItem>In Progress</asp:ListItem>
            <asp:ListItem>Pending</asp:ListItem>
            <asp:ListItem>Submitted</asp:ListItem>
            <asp:ListItem>Accepted</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
