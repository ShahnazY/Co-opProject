<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />

    <br />
         Treasury Money Market Fund, which invests primarily in U.S. Treasury securities, seeks to provide current income and preserve shareholders’ principal investment by maintaining a share price of $1.
    This fund at a minimum invests 80% of the assets in debt issued directly by the government in the form of Treasury bills and may invest in other securities including, but not limited to debt issued by 
    federal agencies that are sponsored, guaranteed, or owned by the federal government. As a government money market fund, this fund is required to invest at least 99.5% of its total assets in cash, U.S.
    government securities, and/or repurchase agreements that are collateralized solely by U.S. government securities or cash (collectively, government securities).<br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="317px" ImageUrl="~/Capture.png" Width="698px" />
        <br />
        <br />
        Add number of shares to purchase
    <br />
        <asp:TextBox ID="txtQTY" runat="server">1</asp:TextBox>
        <br />
    
    </div>
    <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add to Cart" />
        <br />
        <br />
        <asp:Button ID="btnContinue" runat="server" OnClick="btnContinue_Click" Text="Continue Shopping" />
    </form>
</body>
</asp:Content>
