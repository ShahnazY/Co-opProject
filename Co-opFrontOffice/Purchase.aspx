<%@ Page Language="C#"  MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Purchase.aspx.cs" Inherits="Purchase" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 470px;
            top: 98px;
            position: absolute;
            height: 186px;
            width: 640px;
        }
        .auto-style2 {
            position: absolute;
            top: 155px;
            left: 27px;
            z-index: 1;
        }
        </style>

            
            
            &nbsp;
       &nbsp;<br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="PURCHASE A SHARE IN A FUND" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
    Your cart has
     <asp:Label ID="lblCartCount" runat="server"></asp:Label>
&nbsp;items. <a href="Viewcart.aspx">View cart</a> <br />
    <br />
            <table style="width:100%;">
            <tr>
                <td>FTSE Emerging Markets UCITS ETF</td>
                <td>£47.71</td>
                <td>
                    <a href="Details3.aspx?ProductID=1">Details</a>
                </td>
            </tr>
            <tr>
                <td>Federal Money Market Fund</td>
                <td>£3000.00</td>
                <td>
                    <a href="Details2.aspx?ProductID=2">Details</a>
                </td>
            </tr>
            <tr>
                <td>Treasury Money Market Fund</td>
                <td>£89.28</td>
                <td>
                    <a href="Details.aspx?ProductID=3">Details</a>
                </td>
            </tr>
        </table>
    
&nbsp;<br />
             </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Sweden.PNG" style="margin-top: 10px;" CssClass="auto-style1">
        </asp:Panel>
      
    </asp:Content>