<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="ClaimList1.aspx.cs" Inherits="ClaimList1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 211px; top: 52px; position: absolute; height: 517px; width: 595px; margin-top: 0px" BackColor="#C1EBFF">
        <asp:ListBox ID="lstClaims" runat="server" style="z-index: 1; left: 130px; top: 73px; position: absolute; height: 217px; width: 356px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 144px; top: 360px; position: absolute; height: 29px; width: 48px;" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 400px; top: 357px; position: absolute; height: 25px; width: 58px;" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 132px; top: 452px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 274px; top: 358px; position: absolute; width: 49px;" Text="Edit" />
        
        </asp:Panel>

</asp:Content>

