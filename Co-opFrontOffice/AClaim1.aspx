<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="AClaim1.aspx.cs" Inherits="AClaim1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 195px; top: 165px; position: absolute; height: 489px; width: 831px" BackColor="#D6DDE9">
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 50px; top: 234px; position: absolute" Text="Status"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 343px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 527px; top: 414px; position: absolute; right: 263px; height: 26px;" Text="ADD" BackColor="White" BorderColor="#4F658E" Font-Bold="True" ForeColor="Green" />
        <asp:Label ID="lblLocation" runat="server" style="z-index: 1; left: 47px; top: 183px; position: absolute" Text="Location"></asp:Label>
        <asp:Label ID="lblDateOfClaim" runat="server" style="z-index: 1; left: 431px; top: 178px; position: absolute" Text="Date of Claim"></asp:Label>
        <asp:Label ID="lblDateOfInjury" runat="server" style="z-index: 1; left: 434px; top: 225px; position: absolute" Text="Date of Injury"></asp:Label>
        <asp:Label ID="lblEvidenceProvided" runat="server" style="z-index: 1; left: 20px; top: 293px; position: absolute" Text="Evidence Provided"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 598px; top: 416px; position: absolute" Text="CANCEL" BackColor="White" BorderColor="Red" Font-Bold="True" ForeColor="Red" />
        <asp:TextBox ID="txtDateOfClaim" runat="server" style="z-index: 1; left: 589px; top: 176px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOfInjury" runat="server" style="z-index: 1; left: 591px; top: 228px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" style="z-index: 1; left: 137px; top: 181px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlStatus" runat="server" style="z-index: 1; left: 138px; top: 231px; position: absolute">
            <asp:ListItem>In Progress</asp:ListItem>
            <asp:ListItem>Pending</asp:ListItem>
            <asp:ListItem>Submitted</asp:ListItem>
            <asp:ListItem>Accepted</asp:ListItem>
        </asp:DropDownList>
            <asp:CheckBox ID="chkYes" runat="server" style="z-index: 1; left: 163px; top: 291px; position: absolute" />
            <asp:Panel ID="Panel2" runat="server" BackColor="#B3F0FF" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 2px; top: -126px; position: absolute; height: 260px; width: 827px">
            </asp:Panel>
        </asp:Panel>

</asp:Content>

