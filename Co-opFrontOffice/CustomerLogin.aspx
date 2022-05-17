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
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 195px; top: 165px; position: absolute; height: 489px; width: 831px" BackColor="#D6DDE9">
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 183px; top: 267px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 184px; top: 321px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 55px; top: 268px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 53px; top: 323px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 78px; top: 406px; position: absolute"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 52px; top: 210px; position: absolute" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 184px; top: 211px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 527px; top: 414px; position: absolute; right: 263px; height: 26px;" Text="ADD" BackColor="White" BorderColor="#4F658E" Font-Bold="True" ForeColor="Green" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 598px; top: 416px; position: absolute" Text="CANCEL" BackColor="White" BorderColor="Red" Font-Bold="True" ForeColor="Red" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 366px; top: 156px; position: absolute" Text="Find" />
        <asp:TextBox ID="txtLoginID" runat="server" style="z-index: 1; left: 183px; top: 161px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLoginID" runat="server" style="z-index: 1; left: 48px; top: 163px; position: absolute" Text="Customer Login ID"></asp:Label>
            <asp:Panel ID="Panel2" runat="server" BackColor="#B3F0FF" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 2px; top: -126px; position: absolute; height: 260px; width: 827px">
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
