<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 295px; top: 218px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 294px; top: 265px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 297px; top: 312px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 601px; top: 215px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 602px; top: 263px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 602px; top: 359px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 407px; top: 446px; position: absolute"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 179px; top: 215px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 182px; top: 265px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 178px; top: 315px; position: absolute; right: 338px" Text="EMail"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 503px; top: 217px; position: absolute" Text="House No"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 521px; top: 264px; position: absolute" Text="Street"></asp:Label>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 524px; top: 315px; position: absolute; height: 19px; width: 34px" Text="Town"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 497px; top: 361px; position: absolute" Text="Post Code"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 433px; top: 513px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 507px; top: 512px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 167px; top: 372px; position: absolute" Text="Date of Birth"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 294px; top: 368px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlTown" runat="server" style="z-index: 1; left: 602px; top: 315px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 207px; top: 415px; position: absolute" Text="Gender"></asp:Label>
        <asp:DropDownList ID="ddlGender" runat="server" style="z-index: 1; left: 294px; top: 411px; position: absolute">
        </asp:DropDownList>
    </form>
</body>
</html>
