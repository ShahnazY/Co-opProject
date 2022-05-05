<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="AFund.aspx.cs" Inherits="AFund" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
        <asp:Panel ID="Panel4" runat="server" BackColor="#0492C2" style="z-index: 1; left: 466px; top: 70px; position: absolute; height: 431px; width: 308px">
            <asp:Button ID="Holdingsbtn" runat="server" style="z-index: 1; left: 76px; top: 361px; position: absolute; width: 150px;" Text="HOLDINGS" Font-Names="Yu Gothic" OnClick="Holdingsbtn_Click" />
            <asp:TextBox ID="txtFindID" runat="server" style="z-index: 1; left: 167px; top: 46px; position: absolute; width: 100px;"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 14px; top: 46px; position: absolute" Font-Names="Yu Gothic" Text="Enter Client ID:"></asp:Label>
            <asp:ListBox ID="lbPurchases" runat="server" style="z-index: 1; left: 42px; top: 98px; position: absolute; height: 248px; width: 233px"></asp:ListBox>
        </asp:Panel>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 469px; top: 36px; position: absolute; height: 22px" Text="ACCOUNT INFORMATION"></asp:Label>
        <asp:Panel ID="Panel6" runat="server" BackColor="#757C88" style="z-index: 1; left: 17px; top: 136px; position: absolute; height: 388px; width: 438px">
            <asp:TextBox ID="txtShares" runat="server" style="z-index: 1; left: 166px; top: 194px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="Symbollbl" runat="server" style="z-index: 1; left: 46px; top: 96px; position: absolute" Text="Symbol:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
            <asp:Panel ID="Panel10" runat="server" BackColor="#757C88" style="z-index: 1; left: 778px; top: -49px; position: absolute; height: 439px; width: 543px">
                <asp:ListBox ID="lbFunds" runat="server" style="z-index: 1; left: 23px; top: 13px; position: absolute; height: 99px; width: 494px; right: 26px;"></asp:ListBox>
                <asp:TextBox ID="txtFindSymbol" runat="server" style="z-index: 1; left: 38px; top: 392px; position: absolute; width: 157px; height: 24px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 93px; top: 352px;  position: absolute" Text="ENTER FUND NUMBER TO VIEW DESCRIPTION" Font-Names="Yu Gothic"></asp:Label>
                <asp:Label ID="lbDescription" runat="server" style="z-index: 1; left: 24px; top: 130px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
            </asp:Panel>
            <asp:Label ID="lblDuration" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 40px; top: 243px; position: absolute; bottom: 119px;" Text="Duration:"></asp:Label>
            <asp:Label ID="Shareslbl" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 47px; top: 195px; position: absolute" Text="Shares:"></asp:Label>
            <asp:Label ID="AccountTypelbl" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 23px; top: 149px; position: absolute" Text="Order Type:"></asp:Label>
            <asp:DropDownList ID="ddlOrderType" runat="server" Font-Names="Yu Gothic" style="z-index: 1; left: 167px; top: 149px; position: absolute; width: 181px;">
                <asp:ListItem>Market</asp:ListItem>
                <asp:ListItem>Limit</asp:ListItem>
                <asp:ListItem>Stop</asp:ListItem>
                <asp:ListItem>Stop Limit</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtSymbol" runat="server" style="z-index: 1; left: 170px; top: 97px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:TextBox ID="txtFundID" runat="server" style="z-index: 1; left: 169px; top: 284px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Button ID="Continuebtn" runat="server" style="z-index: 1; left: 23px; top: 337px; position: absolute; width: 140px;" Text="CONTINUE" Font-Names="Yu Gothic" OnClick="Continuebtn_Click" />
            <asp:Button ID="Clearbtn" runat="server" style="z-index: 1; left: 204px; top: 336px; position: absolute; width: 140px;" Text="CLEAR" Font-Names="Yu Gothic" OnClick="Clearbtn_Click" />
            <asp:TextBox ID="txtClientID" runat="server" style="z-index: 1; left: 170px; top: 48px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="lblClientID" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 46px; top: 48px; position: absolute" Text="ClientID"></asp:Label>
            <asp:TextBox ID="txtDuration" runat="server" style="z-index: 1; left: 168px; top: 241px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="lblFundID" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 41px; top: 282px; position: absolute" Text="Fund ID:"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblTrade" runat="server" style="z-index: 1; left: 21px; top: 95px; position: absolute; height: 22px; width: 445px;" Text="TRADE AN ETF OR STOCK" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 549px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 868px; width: 350px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 270px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Sweden.PNG" style="z-index: 1; left: 266px; top: 559px; position: absolute; height: 186px; width: 640px; margin-top: 10px;">
        </asp:Panel>
       
        
        <asp:Button ID="btnDisplayFunds" runat="server" style="z-index: 1; left: 1142px; top: 483px; position: absolute; width: 166px;" Text="VIEW OBJECTIVE" Font-Names="Yu Gothic" OnClick="btnDisplayFunds_Click"  />
        

       
        
         <asp:Label ID="lblPurchaseNo" Font-Names="Yu Gothic" runat="server" style="z-index: 1; left: 473px; top: 512px; position: absolute"></asp:Label>
        

       
        
         <p>
        <asp:Label ID="Symbolshownlbl" runat="server" style="z-index: 1; left: 802px; top: 55px; position: absolute; width: 258px; margin-top: 0px;"  Font-Size="X-Large" ForeColor="#314367">AVAILABLE FUNDS</asp:Label>
       
        
         </p>
        

       
        
    </asp:Content>