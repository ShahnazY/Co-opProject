<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="InsuranceCoverage1.aspx.cs" Inherits="InsuranceCoverage1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Label ID="lblCoverage" runat="server" Font-Size="X-Large" ForeColor="#FF9933" style="z-index: 1; left: 120px; top: 62px; position: absolute" Text="PLEASE CHOOSE INSURANCE COVERAGE"></asp:Label>
        <asp:Panel ID="PanelInsurance" runat="server" BackColor="#FDC995" style="z-index: 1; left: 127px; top: 105px; position: absolute; height: 487px; width: 477px">
            <asp:Label ID="lblDentalTreatment" runat="server" style="z-index: 1; left: 9px; top: 69px; position: absolute" Text="Dental Treatment" Font-Size="Large"></asp:Label>
            <asp:Label ID="lblCover" runat="server" Font-Size="Large" style="z-index: 1; left: 11px; top: 112px; position: absolute; height: 21px; width: 45px;" Text="Cover"></asp:Label>
            <asp:Label ID="lblVetFees" runat="server" Font-Size="Large" style="z-index: 1; left: 8px; top: 151px; position: absolute" Text="Vet Fees"></asp:Label>
            <asp:CheckBox ID="chkDentalTreatment" runat="server" Font-Size="Small" style="z-index: 1; left: 193px; top: 65px; position: absolute; height: 37px; width: 218px" Text="Press to select" />
            <asp:DropDownList ID="ddlCover" runat="server" style="z-index: 1; left: 199px; top: 112px; position: absolute">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlVetFees" runat="server" style="z-index: 1; left: 200px; top: 155px; position: absolute">
            </asp:DropDownList>
            <asp:Panel ID="PanelDogID" runat="server" BackColor="#FF9933" style="z-index: 1; left: 0px; top: 404px; position: absolute; height: 82px; width: 477px">
                <asp:Label ID="lblInsuranceNumber" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute"></asp:Label>
            </asp:Panel>
            <asp:TextBox ID="txtDogID" runat="server" style="z-index: 1; left: 99px; top: 7px; position: absolute; height: 23px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 283px; top: 9px; position: absolute" Text="Find" OnClick="btnFind_Click" />
            <asp:Label ID="DogID" runat="server" Font-Bold="True" style="z-index: 1; left: 12px; top: 13px; position: absolute" Text="Dog ID"></asp:Label>
            <asp:Label ID="lblInsuranceID" runat="server" Font-Bold="False" Font-Size="Large" style="z-index: 1; left: 9px; top: 203px; position: absolute" Text="Insurance ID"></asp:Label>
            <asp:TextBox ID="txtInsuranceID" runat="server" style="z-index: 1; left: 157px; top: 204px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPrice" runat="server" Font-Size="Large" style="z-index: 1; left: 13px; top: 259px; position: absolute" Text="Price"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 157px; top: 262px; position: absolute"></asp:TextBox>
        </asp:Panel>
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 135px; top: 364px; position: absolute; width: 76px; height: 28px" Text="Back" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 141px; top: 420px; position: absolute"></asp:Label>
        <asp:Panel ID="PanelCoop" runat="server" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: -23px; top: 565px; position: absolute; height: 254px; width: 823px">
        </asp:Panel>
        <p>
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 504px; top: 362px; position: absolute; width: 66px; height: 28px" Text="OK" />
            </p>

</asp:Content>

