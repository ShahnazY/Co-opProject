<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsuranceList.aspx.cs" Inherits="InsuranceList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblListInsurances" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF9933" style="z-index: 1; left: 51px; top: 61px; position: absolute" Text="Insurances List"></asp:Label>
        <asp:Panel ID="PanelList" runat="server" BackColor="#FDC995" style="z-index: 1; left: 50px; top: 113px; position: absolute; height: 395px; width: 674px">
            <asp:Panel ID="PanelCOOP" runat="server" style="z-index: 1; left: -58px; top: 410px; position: absolute; height: 246px; width: 811px" BackImageUrl="~/coop-logo-png-16.png">
            </asp:Panel>
            <asp:ListBox ID="lstInsurance" runat="server" style="z-index: 1; left: 11px; top: 0px; position: absolute; height: 256px; width: 651px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 464px; top: 348px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 530px; top: 348px; position: absolute" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 590px; top: 348px; position: absolute" Text="Delete" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 352px; position: absolute"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
