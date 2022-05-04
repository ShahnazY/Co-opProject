<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AddStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="PanelCoopLogo" runat="server" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 5px; top: 40px; position: absolute; height: 257px; width: 828px">
        </asp:Panel>
        <asp:Panel ID="PanelStaff" runat="server" BackColor="#A0CADA" style="z-index: 1; left: 3px; top: 282px; position: absolute; height: 412px; width: 1146px">
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute" Text="Staff ID" Font-Bold="True"></asp:Label>
            <asp:Label ID="lblFirstName" runat="server" Font-Bold="True" style="z-index: 1; left: 0px; top: 59px; position: absolute" Text="First Name"></asp:Label>
            <asp:Label ID="lblLastName" runat="server" Font-Bold="True" style="z-index: 1; left: 3px; top: 118px; position: absolute" Text="Last Name"></asp:Label>
            <asp:Label ID="lblDateOfBirth" runat="server" Font-Bold="True" style="z-index: 1; left: 3px; top: 176px; position: absolute" Text="Date of Birth"></asp:Label>
            <asp:Label ID="lblGender" runat="server" Font-Bold="True" style="z-index: 1; left: 7px; top: 240px; position: absolute" Text="Gender"></asp:Label>
            <asp:Label ID="lblDepartment" runat="server" Font-Bold="True" style="z-index: 1; left: 658px; top: 3px; position: absolute" Text="Department"></asp:Label>
            <asp:Label ID="lblEmail" runat="server" Font-Bold="True" style="z-index: 1; left: 665px; top: 64px; position: absolute" Text="Email"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 216px; top: 10px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 216px; top: 62px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 214px; top: 120px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 215px; top: 178px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 834px; top: 7px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 835px; top: 66px; position: absolute"></asp:TextBox>
            <asp:DropDownList ID="ddlGender" runat="server" style="z-index: 1; left: 216px; top: 240px; position: absolute">
            </asp:DropDownList>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 805px; top: 199px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 1011px; top: 251px; position: absolute" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 899px; top: 253px; position: absolute; right: 151px;" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 369px; top: 9px; position: absolute" Text="Find" />
        </asp:Panel>
        <asp:Label ID="lblStaffLogo" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0066CC" style="z-index: 1; left: 846px; top: 206px; position: absolute; height: 65px; width: 143px" Text="Staff"></asp:Label>
    </form>
</body>
</html>
