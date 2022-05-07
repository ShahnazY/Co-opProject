<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                <div>
            <br />
            <br />
            <asp:Label ID="title" runat="server" Text="CHANGE PASSWORD" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
           <br />
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 185px">
                    <asp:Label ID="lblCurrentPassword" Font-Names="Yu Gothic" runat="server" Text="Current Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtCurrentPassword" Font-Names="Yu Gothic" runat="server" TextMode="Password" style="margin-left: 0px" Width="283px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 185px">
            <asp:Label ID="lblPassword" Font-Names="Yu Gothic" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtPassword1" Font-Names="Yu Gothic" runat="server" TextMode="Password" width="283px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 185px">
            <asp:Label ID="lblConfirm" Font-Names="Yu Gothic" runat="server" Text="Confirm Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtPassword2" Font-Names="Yu Gothic" runat="server" TextMode="Password" width="283px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Label ID="lblError" Font-Names="Yu Gothic" runat="server"></asp:Label>
                    <br />
                    <br />
        </div>
        <asp:Button ID="btnChange" Font-Names="Yu Gothic" runat="server" Text="Change Password" OnClick="btnChange_Click" />
&nbsp;<asp:Button ID="btnDone" Font-Names="Yu Gothic" runat="server" Text="Done" OnClick="btnCancel_Click" />
</asp:Content>

