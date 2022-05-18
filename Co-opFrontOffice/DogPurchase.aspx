<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="DogPurchase.aspx.cs" Inherits="DogPurchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF9933" style="z-index: 1; left: 21px; top: 41px; position: absolute; height: 255px; width: 472px" Text="Purchase Insurance for a Dog"></asp:Label>
    <asp:Label ID="lblItems" runat="server" Font-Bold="True" style="z-index: 1; left: 583px; top: 78px; position: absolute" Text="Number of Insurances in your chart: "></asp:Label>
    <asp:Label ID="lblChartAmount" runat="server" style="z-index: 1; left: 994px; top: 79px; position: absolute"></asp:Label>
    <asp:LinkButton ID="LinkButton1" runat="server" style="z-index: 1; left: 586px; top: 133px; position: absolute">View Chart</asp:LinkButton>
    <asp:LinkButton ID="lnkDetails" runat="server" OnClick="lnkDetails_Click" style="z-index: 1; left: 892px; top: 266px; position: absolute">Details</asp:LinkButton>
</asp:Content>

