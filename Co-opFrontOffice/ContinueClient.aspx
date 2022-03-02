<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContinueClient.aspx.cs" Inherits="Co_op_Front_Office.ContinueClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel4" runat="server" BackColor="#0492C2" style="z-index: 1; left: 177px; top: 141px; position: absolute; height: 163px; width: 449px">
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" BackColor="#1F456E" style="z-index: 1; left: 568px; top: 112px; position: absolute; height: 363px; width: 601px">
            <asp:TextBox ID="txtClientID" runat="server" style="z-index: 1; left: -218px; top: 73px; position: absolute"></asp:TextBox>
        </asp:Panel>
        <asp:Label ID="ClientIDlbl" runat="server"  style="z-index: 1; left: 212px; top: 178px; position: absolute" Text="Client ID:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 351px; top: 219px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtBankName" runat="server" style="z-index: 1; left: 749px; top: 193px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAccountNumber" runat="server" style="z-index: 1; left: 749px; top: 229px; position: absolute"></asp:TextBox>
        <asp:Label ID="Passwordlbl" runat="server" style="z-index: 1; left: 212px; top: 217px; position: absolute" Text="Password:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="BankNamelbl" runat="server" style="z-index: 1; left: 603px; top: 191px; position: absolute" Text="Bank Name:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="StreetNumberlbl" runat="server" style="z-index: 1; left: 579px; top: 227px; position: absolute" Text="Account Number:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="SortCodelbl" runat="server" style="z-index: 1; left: 610px; top: 264px; position: absolute" Text="Sort Code:" Font-Italic="False" Font-Names="Yu Gothic"></asp:Label>
        <asp:TextBox ID="txtSortCode" runat="server" style="z-index: 1; left: 749px; top: 265px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblContinue" runat="server" Font-Size="X-Large" ForeColor="#314367" style="z-index: 1; left: 186px; top: 103px; position: absolute; height: 22px; margin-top: 0px;" Text="CHOOSE LOG IN DETAILS"></asp:Label>
        <asp:Label ID="lblSuccess" runat="server" style="z-index: 1; left: 212px; top: 506px; position: absolute" Font-Names="Yu Gothic"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 8px; top: 557px; position: absolute" Font-Names="Yu Gothic" ></asp:Label>
        
        
        <asp:Panel ID="Panel7" runat="server" BackColor="#A3B6DA" style="z-index: 1; left: 1355px; top: -4px; position: absolute; height: 868px; width: 350px">
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server"  BackColor="#A3B6DA" style="z-index: 1; left: -1px; top: 595px; position: absolute; height: 270px; width: 1370px">
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/coop-logo-png-16.PNG" style="z-index: 1; left: 231px; top: 601px; position: absolute; height: 270px; width: 828px">
        </asp:Panel>
        
       
        
        <asp:Button ID="btnContinue" runat="server" style="z-index: 1; left: 608px; top: 323px; position: absolute; width: 304px;" Text="SUBMIT REGISTRATION" Font-Names="Yu Gothic"  />
        
       
        
        <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 791px; top: 372px; position: absolute; width: 361px;" Text="GO BACK TO MAIN PAGE" Font-Names="Yu Gothic"  />
        
       
        
        <asp:Label ID="lblClientID" runat="server" style="z-index: 1; left: 894px; top: 541px; position: absolute" Font-Size="X-Large" ForeColor="#314367" ></asp:Label>
        
       
        
         <asp:Label ID="LblBank" runat="server" style="z-index: 1; left: 577px; top: 72px; position: absolute" Text="PROVIDE YOUR BANK DETAILS" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
        
       
        
    </form>
</body>
</html>
