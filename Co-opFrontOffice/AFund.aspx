<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AFund.aspx.cs" Inherits="AFund" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel4" runat="server" BackColor="#0492C2" style="z-index: 1; left: 466px; top: 70px; position: absolute; height: 431px; width: 438px">
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 234px; top: 100px; position: absolute; height: 237px; width: 172px;"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" style="z-index: 1; left: 29px; top: 99px; position: absolute; height: 237px; width: 172px"></asp:ListBox>
            <asp:Button ID="Balancebtn" runat="server" style="z-index: 1; left: 32px; top: 55px; position: absolute; width: 150px;" Text="BALANCE" Font-Names="Yu Gothic" />
            <asp:Button ID="Holdingsbtn" runat="server" style="z-index: 1; left: 250px; top: 55px; position: absolute; width: 150px;" Text="HOLDINGS" Font-Names="Yu Gothic" />
            <asp:TextBox ID="ClientIDtxt" runat="server" style="z-index: 1; left: 220px; top: 360px; position: absolute"></asp:TextBox>
            <asp:Label ID="ClientIDlbl" runat="server" style="z-index: 1; left: 27px; top: 360px; position: absolute" Text="ENTER CLIENT ID" Font-Names="Yu Gothic" ></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblAdd" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 491px; top: 34px; position: absolute; height: 22px" Text="ACCOUNT INFORMATION"></asp:Label>
        <asp:Panel ID="Panel6" runat="server" BackColor="#757C88" style="z-index: 1; left: 17px; top: 136px; position: absolute; height: 388px; width: 438px">
            <asp:TextBox ID="txtShares" runat="server" style="z-index: 1; left: 166px; top: 194px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="Symbollbl" runat="server" style="z-index: 1; left: 46px; top: 96px; position: absolute" Text="Symbol:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
            <asp:Panel ID="Panel10" runat="server" BackColor="#757C88" style="z-index: 1; left: 899px; top: -3px; position: absolute; height: 388px; width: 422px">
                <asp:ListBox ID="lbFunds" runat="server" style="z-index: 1; left: 33px; top: 45px; position: absolute; height: 201px; width: 352px; right: 53px;"></asp:ListBox>
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
            <asp:Button ID="Clearbtn" runat="server" style="z-index: 1; left: 204px; top: 336px; position: absolute; width: 140px;" Text="CLEAR" Font-Names="Yu Gothic" />
            <asp:TextBox ID="txtClientID" runat="server" style="z-index: 1; left: 170px; top: 48px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="lblClientID" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 46px; top: 48px; position: absolute" Text="ClientID"></asp:Label>
            <asp:TextBox ID="txtDuration" runat="server" style="z-index: 1; left: 168px; top: 241px; position: absolute; width: 170px;"></asp:TextBox>
            <asp:Label ID="lblFundID" runat="server" Font-Italic="False" Font-Names="Yu Gothic" style="z-index: 1; left: 41px; top: 282px; position: absolute" Text="Fund ID:"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblTrade" runat="server" style="z-index: 1; left: 21px; top: 95px; position: absolute; height: 22px; width: 445px;" Text="TRADE AN ETF OR STOCK" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 868px; width: 350px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 270px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/coop-logo-png-16.PNG" style="z-index: 1; left: 231px; top: 601px; position: absolute; height: 270px; width: 828px">
        </asp:Panel>
        <asp:Label ID="Symbolshownlbl" runat="server" style="z-index: 1; left: 935px; top: 93px; position: absolute"  Font-Size="X-Large" ForeColor="#314367"></asp:Label>
       
        
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 961px; top: 425px; position: absolute; width: 343px;" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic"  />
        

       
        
         <asp:Label ID="lblPurchaseNo" Font-Names="Yu Gothic" runat="server" style="z-index: 1; left: 1008px; top: 546px; position: absolute"></asp:Label>
        

       
        
    </form>
</body>
</html>