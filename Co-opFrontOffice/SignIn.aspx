<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div>
            <br />
                <br />
            <asp:Label ID="title" runat="server" Text="SIGN-IN" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
           <br />
                <br />
                <table style="width: 100%;">
                <tr>
                    <td style="width: 192px">
            <asp:Label ID="lblEMail" runat="server" Text="E-Mail Address" Font-Names="Yu Gothic"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="txtEMail"  runat="server" Width="283px" Font-Names="Yu Gothic"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px; height: 26px;">
            <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Names="Yu Gothic"></asp:Label>
                    </td>
                    <td style="height: 26px"><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="283px" Font-Names="Yu Gothic"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
                </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Sweden.PNG" style="z-index: 1; left: 306px; top: 204px; position: absolute; height: 186px; width: 640px; margin-top: 10px;">
        </asp:Panel>
&nbsp;<br />
                <br />
                <asp:Label ID="lblError" runat="server" Font-Names="Yu Gothic"></asp:Label>
            <br />
            <br />
&nbsp;</div>
        <asp:Button ID="btnSignIn" runat="server" Text="Sign-in" OnClick="btnSignIn_Click" Font-Names="Yu Gothic" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Font-Names="Yu Gothic" />
&nbsp;<asp:Button ID="btnReSend" runat="server" Text="Re-set Password" OnClick="btnReSend_Click" Font-Names="Yu Gothic" />
</asp:Content>
