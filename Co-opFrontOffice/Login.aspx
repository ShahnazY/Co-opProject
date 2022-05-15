<%@ Page Language="C#"  MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <br />
        <br />
        Please log in again to continue to CHECKOUT<br />
        <br />
    
        User Name
    
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <br />
        Password
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    
   
</asp:Content>
