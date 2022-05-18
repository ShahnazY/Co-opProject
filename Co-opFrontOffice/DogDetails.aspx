<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="DogDetails.aspx.cs" Inherits="DogDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#FF9933" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 261px; width: 409px" Text="Quantity of insurances for purchase"></asp:Label>
    <asp:Button ID="btnBackInsurance" runat="server" style="z-index: 1; left: 206px; top: 58px; position: absolute" Text="Back to choose insurance" />
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 584px; top: 62px; position: absolute" Text="Add to Chart" />
    <asp:TextBox ID="txtQuanity" runat="server" style="z-index: 1; left: 459px; top: 4px; position: absolute">1</asp:TextBox>
</asp:Content>

