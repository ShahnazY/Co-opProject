<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="ReSet.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div>
            <br />
            <br />
            <asp:Label ID="title" runat="server" Text="RE-SET PASSWORD" Font-Size="X-Large" ForeColor="#314367"></asp:Label>
           <br />
                <br />

            <asp:Label ID="lblEMail" Font-Names="Yu Gothic" runat="server" Text="E-Mail Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtEMail" Font-Names="Yu Gothic" runat="server" Width="283px"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="lblError" Font-Names="Yu Gothic" runat="server"></asp:Label>
            <br />
&nbsp;</div>
    </asp:Panel>
        <asp:Panel ID="Panel8" runat="server" BackImageUrl="~/Coop_Sweden.PNG" style="z-index: 1; left: 300px; top: 206px; position: absolute; height: 186px; width: 640px; margin-top: 10px;">
        </asp:Panel>
&nbsp;<asp:Button ID="btnReSet" Font-Names="Yu Gothic" runat="server" Text="Re-set Password" OnClick="btnReSet_Click" />
&nbsp;<asp:Button ID="btnDone" Font-Names="Yu Gothic" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnView" Font-Names="Yu Gothic" runat="server" OnClick="btnView_Click" Text="View Email" />
</asp:Content>


