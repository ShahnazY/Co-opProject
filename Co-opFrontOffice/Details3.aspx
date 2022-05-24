<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />

    <br />
         This fund offers investors a low-cost way to gain equity exposure to emerging markets. The fund invests in stocks of companies located in emerging markets around the world, such as Brazil, Russia, India, Taiwan, and China. Stocks of companies in emerging markets tend to be more volatile than those in developed countries, which could imply the potential for greater long-term returns. Along with this potential, however, come risks such as currency and political risks. Long-term, risk-tolerant investors who want to diversify their international portfolio may wish to consider this fund..<br />
        <br />
        <asp:Image ID="FTSE" runat="server" Height="465px" ImageUrl="~/FTSE.png" Width="698px" />
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
