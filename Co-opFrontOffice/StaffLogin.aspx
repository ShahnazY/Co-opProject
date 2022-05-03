<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="PanelCoLogo" runat="server" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 10px; top: 48px; position: absolute; height: 256px; width: 817px">
        </asp:Panel>
        <asp:Panel ID="PanelLogin" runat="server" BackColor="#A0CADA" style="z-index: 1; left: 306px; top: 310px; position: absolute; height: 391px; width: 810px">
            <asp:Label ID="lblStaffLoginID" runat="server" style="z-index: 1; left: 8px; top: 0px; position: absolute" Text="Staff Login ID" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtStaffLoginID" runat="server" style="z-index: 1; left: 6px; top: 47px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 579px; top: 144px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" style="z-index: 1; left: 420px; top: 146px; position: absolute" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 578px; top: 208px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 426px; top: 202px; position: absolute" Text="Email"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 579px; top: 272px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Font-Bold="True" style="z-index: 1; left: 428px; top: 270px; position: absolute" Text="Password"></asp:Label>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 748px; top: 343px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 13px; top: 343px; position: absolute" Text="Cancel" />
        </asp:Panel>
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0099FF" style="z-index: 1; left: 841px; top: 232px; position: absolute" Text="Staff Login"></asp:Label>
    </form>
</body>
</html>
