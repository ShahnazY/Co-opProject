<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />

    <br />
         Federal Money Market Fund’s investment objective is to seek to provide current income while maintaining liquidity and a stable share price of $1.
    The fund invests at least 99.5% of its total assets in cash, U.S. government securities, and/or repurchase agreements that are collateralized solely by U.S. government securities or cash (collectively, government securities).<br />
        <br />
        <asp:Image ID="federal" runat="server" Height="317px" ImageUrl="~/federal.png" Width="698px" />
        <br />
        <br />
        Add number of shares to purchase
    <br />
        <asp:TextBox ID="txtQTY" runat="server">1</asp:TextBox>
        <br />
    

    <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" />
        <br />
        <br />
        <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue Shopping" />

</asp:Content>
