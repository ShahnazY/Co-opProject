<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteInsurance.aspx.cs" Inherits="DeleteInsurance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="PanelDelete" runat="server" BackColor="#FDC995" style="z-index: 1; left: 169px; top: 37px; position: absolute; height: 223px; width: 689px">
            <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 24px; top: 11px; position: absolute" Text="Insurance will be deleted, do you wish to continue?" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 621px; top: 178px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 20px; top: 182px; position: absolute; right: 635px" Text="No" />
        </asp:Panel>
    </form>
</body>
</html>
