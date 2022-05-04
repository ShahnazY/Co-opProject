<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADog.aspx.cs" Inherits="ADog" %>

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
            height: 471px;
            width: 1101px;
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
            left: 24px;
            top: 147px;
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
        .auto-style15 {
            z-index: 1;
            left: -20px;
            top: 327px;
            position: absolute;
            width: 90px;
        }
        .auto-style16 {
            z-index: 1;
            left: 87px;
            top: 327px;
            position: absolute;
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
                <asp:Label ID="lblDogsName" runat="server" CssClass="auto-style5" Font-Size="Large" Text="Dog's Name"></asp:Label>
                <asp:Label ID="lblDogsAge" runat="server" CssClass="auto-style6" Font-Size="Large" Text="Dog's Age"></asp:Label>
                <asp:Label ID="lblDogID" runat="server" style="z-index: 1; left: -11px; top: 288px; position: absolute; height: 47px; width: 565px;"></asp:Label>
                <asp:Label ID="lblBreed" runat="server" CssClass="auto-style7" Font-Size="Large" Text="Breed"></asp:Label>
                <asp:Label ID="lblSize" runat="server" CssClass="auto-style8" Font-Size="Large" Text="Size"></asp:Label>
                <asp:Label ID="lblGender" runat="server" CssClass="auto-style9" Font-Size="Large" Text="Gender"></asp:Label>
                <asp:TextBox ID="txtDogName" runat="server" CssClass="auto-style10" OnTextChanged="txtDogName_TextChanged"></asp:TextBox>
                <asp:TextBox ID="txtDogAge" runat="server" CssClass="auto-style11"></asp:TextBox>
                <asp:TextBox ID="txtBreed" runat="server" CssClass="auto-style12"></asp:TextBox>
                <asp:TextBox ID="txtSize" runat="server" CssClass="auto-style13" ></asp:TextBox>
                <asp:Button ID="btnCancel" runat="server" BackColor="#FF3300" CssClass="auto-style15" Font-Bold="True" Text="Cancel" />
                <asp:Button ID="btnOK" runat="server" BackColor="#00CC66" CssClass="auto-style16" Font-Bold="True" ForeColor="Black" OnClick="btnAddDog_Click" Text="OK" />
                <asp:Panel ID="PanelCoop" runat="server" BackImageUrl="~/coop-logo-png-16.png" CssClass="auto-style19">
                </asp:Panel>
                <asp:TextBox ID="txtGender" runat="server" style="z-index: 1; left: 118px; top: 159px; position: absolute"></asp:TextBox>
                <asp:Label ID="lblDateAdded" runat="server" Font-Bold="True" Font-Size="Small" style="z-index: 1; left: 7px; top: 238px; position: absolute" Text="Date of Registration"></asp:Label>
                <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 220px; top: 236px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 563px; top: 217px; position: absolute; width: 381px;" Text="Please fill in the from to generate Dog ID before adding a cover"></asp:Label>
            </asp:Panel>
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnAddInsurance" runat="server" OnClick="btnAddInsurance_Click" style="z-index: 1; left: 674px; top: 593px; position: absolute; right: 292px" Text="Add Insurance Cover" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 282px; top: 597px; position: absolute; width: 340px"></asp:Label>
    </form>
</body>
</html>
