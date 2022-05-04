<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteDog.aspx.cs" Inherits="DeleteInsurance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="PanelDeleteInsurance" runat="server" BackColor="#FDC995" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 42px; top: 53px; position: absolute; height: 213px; width: 776px">
            <asp:Label ID="lblDeleteDog" runat="server" style="z-index: 1; left: 31px; top: 18px; position: absolute" Text="Are you sure you want to delete this dog?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 346px; top: 170px; position: absolute" Text="NO" />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 423px; top: 170px; position: absolute" Text="Yes" />
        </asp:Panel>
    </form>
</body>
</html>
