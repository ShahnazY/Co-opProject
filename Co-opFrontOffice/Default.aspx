<%@ Page Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br />
        <div>
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign In" width="160px" />
            <br />
            <asp:Button ID="btnFunds" runat="server" OnClick="btnFunds_Click" Text="Manage Funds" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnReSet" runat="server" OnClick="btnReSet_Click" Text="Re Set Password" width="160px" />
            <br />
            <br />
            <asp:Button ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click" Text="Change Password" Width="160px" />
            <br />
            <br />
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="Sign Out" width="160px" />
        </div>
    <br />
            <asp:Button ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" Text="Purchase Funds" width="160px" />
        </div>


    </asp:Content>
