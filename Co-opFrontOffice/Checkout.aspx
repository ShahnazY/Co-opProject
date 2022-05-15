<%@ Page Language="C#"  MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="AddingClient2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 577px;
            top: 72px;
            position: absolute;
            width: 435px;
        }
        .auto-style2 {
            z-index: 1;
            left: 749px;
            top: 193px;
            position: absolute;
            width: 364px;
        }
        .auto-style3 {
            z-index: 1;
            left: 608px;
            top: 323px;
            position: absolute;
            width: 304px;
        }
        .auto-style4 {
            z-index: 1;
            left: 781px;
            top: 381px;
            position: absolute;
            width: 361px;
        }
    </style>

        <asp:Panel ID="Panel4" runat="server" BackColor="#0492C2" style="z-index: 1; left: 177px; top: 141px; position: absolute; height: 163px; width: 449px">
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" BackColor="#1F456E" style="z-index: 1; left: 568px; top: 112px; position: absolute; height: 363px; width: 601px">
        </asp:Panel>
        <asp:TextBox ID="txtCardNo" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:Label ID="BankNamelbl" runat="server" style="z-index: 1; left: 603px; top: 191px; position: absolute" Text="Card Number:" Font-Italic="False" Font-Names="Yu Gothic" ForeColor="White"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 868px; width: 350px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 270px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/coop-logo-png-16.PNG" style="z-index: 1; left: 231px; top: 601px; position: absolute; height: 270px; width: 828px">
        </asp:Panel>
        
       
        
        <asp:Button ID="btnCheckout" runat="server" Text="CHECKOUT" Font-Names="Yu Gothic" CssClass="auto-style3" OnClick="btnCheckout_Click"  />
        
       
        
        <asp:Button ID="btnBack" runat="server" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic" CssClass="auto-style4" OnClick="btnBack_Click"  />
        
       
        
         <asp:Label ID="LblBank" runat="server" Text="PROVIDE YOUR BANK DETAILS" Font-Size="X-Large" ForeColor="#314367" CssClass="auto-style1"></asp:Label>
        
       
        
    
</asp:Content>

