<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InsuranceCoverage.aspx.cs" Inherits="InsuranceCoverage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCoverage" runat="server" Font-Size="X-Large" ForeColor="#FF9933" style="z-index: 1; left: 120px; top: 62px; position: absolute" Text="PLEASE CHOOSE INSURANCE COVERAGE"></asp:Label>
        <asp:Panel ID="PanelInsurance" runat="server" BackColor="#FDC995" style="z-index: 1; left: 120px; top: 168px; position: absolute; height: 494px; width: 711px">
            <asp:Label ID="lblDentalTreatment" runat="server" style="z-index: 1; left: 7px; top: 16px; position: absolute" Text="Dental Treatment" Font-Size="Large"></asp:Label>
            <asp:Label ID="lblCover" runat="server" Font-Size="Large" style="z-index: 1; left: 11px; top: 86px; position: absolute" Text="Cover"></asp:Label>
            <asp:Label ID="lblVetFees" runat="server" Font-Size="Large" style="z-index: 1; left: 8px; top: 151px; position: absolute" Text="Vet Fees"></asp:Label>
            <asp:CheckBox ID="chkDentalTreatment" runat="server" Font-Size="Small" style="z-index: 1; left: 282px; top: 22px; position: absolute; height: 37px; width: 218px" Text="Press to select" />
            <asp:DropDownList ID="ddlCover" runat="server" style="z-index: 1; left: 284px; top: 90px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlVetFees" runat="server" style="z-index: 1; left: 284px; top: 158px; position: absolute">
            </asp:DropDownList>
            <asp:Panel ID="PanelDogID" runat="server" BackColor="#FF9933" style="z-index: 1; left: 0px; top: 243px; position: absolute; height: 246px; width: 711px">
                <asp:Label ID="lblDogID" runat="server" style="z-index: 1; left: 11px; top: 0px; position: absolute" Text="Dog ID"></asp:Label>
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 562px; top: 179px; position: absolute; width: 140px; height: 54px" Text="OK" />
            </asp:Panel>
            <asp:TextBox ID="txtDogID" runat="server" style="z-index: 1; left: 277px; top: 246px; position: absolute; height: 23px"></asp:TextBox>
        </asp:Panel>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 139px; top: 591px; position: absolute; width: 140px; height: 54px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 859px; top: 617px; position: absolute"></asp:Label>
        <asp:Panel ID="PanelCoop" runat="server" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 806px; top: 123px; position: absolute; height: 254px; width: 823px">
        </asp:Panel>
    </form>
</body>
</html>
