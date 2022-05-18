<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="ADog1.aspx.cs" Inherits="ADog1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<head>
    <title>Dog</title>
    <link href="ADogStyleSheet.css" rel="stylesheet" type="text/css" />
</head>
        <asp:Label ID="lblAdd" runat="server" CssClass="auto-style1" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF9933" Text="ADD A NEW FURRY FRIEND"></asp:Label>
        <asp:Panel ID="PanelDog" runat="server" BackColor="#FF9933" CssClass="auto-style2">
            <asp:Label ID="lblDog" runat="server" CssClass="auto-style3" Text="DOG DETAILS" Font-Bold="True" Font-Size="X-Large" Font-Underline="False" ForeColor="#623202"></asp:Label>
            <asp:Panel ID="PanelDetails" runat="server" BackColor="#FDC995" CssClass="auto-style4">
                <asp:Label ID="lblDogsName" runat="server" CssClass="auto-style5" Font-Size="Large" Text="Dog's Name"></asp:Label>
                <asp:Label ID="lblDogsAge" runat="server" CssClass="auto-style6" Font-Size="Large" Text="Dog's Age"></asp:Label>
                <asp:Label ID="lblDogID" runat="server" style="z-index: 1; left: 583px; top: 80px; position: absolute; width: 330px;"></asp:Label>
                <asp:Label ID="lblBreed" runat="server" CssClass="auto-style7" Font-Size="Large" Text="Breed"></asp:Label>
                <asp:Label ID="lblSize" runat="server" CssClass="auto-style8" Font-Size="Large" Text="Size"></asp:Label>
                <asp:Label ID="lblGender" runat="server" CssClass="auto-style9" Font-Size="Large" Text="Gender"></asp:Label>
                <asp:TextBox ID="txtDogName" runat="server" CssClass="auto-style10"></asp:TextBox>
                <asp:TextBox ID="txtDogAge" runat="server" CssClass="auto-style11"></asp:TextBox>
                <asp:TextBox ID="txtBreed" runat="server" CssClass="auto-style12"></asp:TextBox>
                <asp:TextBox ID="txtSize" runat="server" CssClass="auto-style13" ></asp:TextBox>
                <asp:Button ID="btnCancel" runat="server" BackColor="#FF3300" CssClass="auto-style15" Font-Bold="True" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnAddDog" runat="server" BackColor="#00CC66" CssClass="auto-style16" Font-Bold="True" ForeColor="Black" OnClick="btnAddDog_Click" Text="ADD DOG" />
                <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style18"></asp:TextBox>
                <asp:Panel ID="PanelCoop" runat="server" BackImageUrl="~/coop-logo-png-16.png" CssClass="auto-style19">
                </asp:Panel>
                <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 115px; top: 158px; position: absolute"></asp:TextBox>
            </asp:Panel>
            <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style17" Font-Size="Large" Text="Date "></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 118px; top: 415px; position: absolute; width: 387px; height: 49px"></asp:Label>
            <asp:Label ID="AddingInsurance" runat="server" style="z-index: 1; left: 694px; top: 246px; position: absolute" Text="Please add a dog to generate Dog ID before continuing with adding insurance cover!"></asp:Label>
            <asp:Button ID="btnAddInsuranceCover" runat="server" OnClick="btnAddInsuranceCover_Click" style="z-index: 1; left: 841px; top: 371px; position: absolute" Text="Add Insurance Cover" />
        </asp:Panel>
    

</asp:Content>

