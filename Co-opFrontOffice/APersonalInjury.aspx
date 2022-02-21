<%@ Page Language="C#" AutoEventWireup="true" CodeFile="APersonalInjury.aspx.cs" Inherits="APersonalInjury" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblSeverity" runat="server" style="z-index: 1; left: 320px; top: 193px; position: absolute" Text="Severity"></asp:Label>
        <asp:TextBox ID="txtSeverity" runat="server" style="z-index: 1; left: 431px; top: 193px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 352px; top: 248px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 391px; top: 324px; position: absolute" Text="OK" />
        <asp:DropDownList ID="ddlTypeOfInjury" runat="server" style="z-index: 1; left: 431px; top: 145px; position: absolute">
        </asp:DropDownList>
        <asp:Label ID="lblTypeOfInjury" runat="server" style="z-index: 1; left: 323px; top: 145px; position: absolute" Text="Type of Injury"></asp:Label>
        <asp:TextBox ID="txtCompensation" runat="server" style="z-index: 1; left: 754px; top: 143px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCompensation" runat="server" style="z-index: 1; left: 637px; top: 145px; position: absolute" Text="Compensation"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 492px; top: 326px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
