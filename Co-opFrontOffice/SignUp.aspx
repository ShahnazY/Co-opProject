<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div>
            <br />
            <br />
            <asp:Label ID="title" runat="server" Text="SIGN-UP" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
           <br />
                <br />
                <table style="width: 100%;">
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblEMail" Font-Names="Yu Gothic" runat="server" Text="E Mail Address"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtEMail" Font-Names="Yu Gothic" runat="server" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblPassword" Font-Names="Yu Gothic" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword1" Font-Names="Yu Gothic" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblConfirm" Font-Names="Yu Gothic" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword2" Font-Names="Yu Gothic" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblError" Font-Names="Yu Gothic" runat="server"></asp:Label>
                <br />
                <br />
        </div>
    </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Sweden.PNG" style="z-index: 1; left: 300px; top: 257px; position: absolute; height: 186px; width: 640px; margin-top: 10px;">
        </asp:Panel>
        <asp:Button ID="btnSignUp" Font-Names="Yu Gothic" runat="server" Text="Sign-up" OnClick="btnSignUp_Click" />
&nbsp;<asp:Button ID="btnDone" Font-Names="Yu Gothic" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnReSend" Font-Names="Yu Gothic" runat="server" Text="Re-set Password" OnClick="btnReSend_Click" />
&nbsp;<asp:Button ID="btnView" Font-Names="Yu Gothic" runat="server" OnClick="btnView_Click" Text="View Email" />
</asp:Content>

