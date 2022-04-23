﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADog.aspx.cs" Inherits="ADog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dog</title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 102px;
            top: 58px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 97px;
            top: 115px;
            position: absolute;
            height: 496px;
            width: 469px;
        }
        .auto-style3 {
            z-index: 1;
            left: 17px;
            top: 14px;
            position: absolute;
            height: 28px;
            width: 191px;
        }
        .auto-style4 {
            z-index: 1;
            left: 116px;
            top: 119px;
            position: absolute;
            height: 282px;
            width: 558px;
        }
        .auto-style5 {
            z-index: 1;
            left: 8px;
            top: 8px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 9px;
            top: 47px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 9px;
            top: 85px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 10px;
            top: 122px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 10px;
            top: 156px;
            position: absolute;
            height: 25px;
        }
        .auto-style10 {
            z-index: 1;
            left: 114px;
            top: 6px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 114px;
            top: 48px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 115px;
            top: 85px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 116px;
            top: 122px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 116px;
            top: 155px;
            position: absolute;
            width: 130px;
            height: 26px;
        }
        .auto-style15 {
            z-index: 1;
            left: 129px;
            top: 340px;
            position: absolute;
            width: 90px;
        }
        .auto-style16 {
            z-index: 1;
            left: 249px;
            top: 340px;
            position: absolute;
        }
        .auto-style17 {
            z-index: 1;
            left: 128px;
            top: 313px;
            position: absolute;
        }
        .auto-style18 {
            z-index: 1;
            left: 113px;
            top: 195px;
            position: absolute;
            right: 317px;
        }
        .auto-style19 {
            z-index: 1;
            left: 265px;
            top: -157px;
            position: absolute;
            height: 250px;
            width: 816px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblAdd" runat="server" CssClass="auto-style1" Font-Bold="True" Font-Size="X-Large" ForeColor="#FF9933" Text="ADD A NEW FURRY FRIEND"></asp:Label>
        <asp:Panel ID="PanelDog" runat="server" BackColor="#FF9933" CssClass="auto-style2">
            <asp:Label ID="lblDog" runat="server" CssClass="auto-style3" Text="DOG DETAILS" Font-Bold="True" Font-Size="X-Large" Font-Underline="False" ForeColor="#623202"></asp:Label>
            <asp:Panel ID="PanelDetails" runat="server" BackColor="#FDC995" CssClass="auto-style4">
                <asp:Label ID="lblName" runat="server" CssClass="auto-style5" Font-Size="Large" Text="Dog's Name"></asp:Label>
                <asp:Label ID="lblAge" runat="server" CssClass="auto-style6" Font-Size="Large" Text="Dog's Age"></asp:Label>
                <asp:Label ID="lblBreed" runat="server" CssClass="auto-style7" Font-Size="Large" Text="Breed"></asp:Label>
                <asp:Label ID="lblSize" runat="server" CssClass="auto-style8" Font-Size="Large" Text="Size"></asp:Label>
                <asp:Label ID="lblGender" runat="server" CssClass="auto-style9" Font-Size="Large" Text="Gender"></asp:Label>
                <asp:TextBox ID="txtDogName" runat="server" CssClass="auto-style10" OnTextChanged="txtDogName_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txtDogAge" runat="server" CssClass="auto-style11"></asp:TextBox>
                <asp:TextBox ID="txtBreed" runat="server" CssClass="auto-style12"></asp:TextBox>
                <asp:TextBox ID="txtSize" runat="server" CssClass="auto-style13" ></asp:TextBox>
                <asp:ListBox ID="lstGender" runat="server" CssClass="auto-style14"></asp:ListBox>
                <asp:Button ID="btnCancel" runat="server" BackColor="#FF3300" CssClass="auto-style15" Font-Bold="True" Text="Cancel" />
                <asp:Button ID="btnAddDog" runat="server" BackColor="#00CC66" CssClass="auto-style16" Font-Bold="True" ForeColor="Black" OnClick="btnAddDog_Click" Text="ADD DOG" />
                <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style18"></asp:TextBox>
                <asp:Panel ID="PanelCoop" runat="server" BackImageUrl="~/coop-logo-png-16.png" CssClass="auto-style19">
                </asp:Panel>
            </asp:Panel>
            <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style17" Font-Size="Large" Text="Date "></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
