<%@ Page Title="" Language="C#" MasterPageFile="~/Co_opProject.master" AutoEventWireup="true" CodeFile="APersonalInjury1.aspx.cs" Inherits="APersonalInjury1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 195px; top: 165px; position: absolute; height: 489px; width: 831px" BackColor="#D6DDE9">
    <asp:Label ID="lblSeverity" runat="server" style="z-index: 1; left: 82px; top: 280px; position: absolute" Text="Severity"></asp:Label>
        <asp:TextBox ID="txtSeverity" runat="server" style="z-index: 1; left: 224px; top: 273px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 78px; top: 383px; position: absolute"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 527px; top: 414px; position: absolute; right: 263px; height: 26px;" Text="ADD" BackColor="White" BorderColor="#4F658E" Font-Bold="True" ForeColor="Green" />
        <asp:DropDownList ID="ddlTypeOfInjury" runat="server" style="z-index: 1; left: 227px; top: 222px; position: absolute">
            <asp:ListItem>Head</asp:ListItem>
            <asp:ListItem>Leg</asp:ListItem>
            <asp:ListItem>Spinal</asp:ListItem>
            <asp:ListItem>Arm</asp:ListItem>
            <asp:ListItem>Back</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblTypeOfInjury" runat="server" style="z-index: 1; left: 80px; top: 226px; position: absolute" Text="Type of Injury"></asp:Label>
        <asp:TextBox ID="txtCompensation" runat="server" style="z-index: 1; left: 224px; top: 325px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCompensation" runat="server" style="z-index: 1; left: 80px; top: 327px; position: absolute" Text="Compensation"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 598px; top: 416px; position: absolute" Text="CANCEL" BackColor="White" BorderColor="Red" Font-Bold="True" ForeColor="Red" />
        <asp:Panel ID="Panel2" runat="server" BackColor="#B3F0FF" BackImageUrl="~/coop-logo-png-16.png" style="z-index: 1; left: 2px; top: -126px; position: absolute; height: 260px; width: 827px">
            </asp:Panel>
        </asp:Panel>

</asp:Content>

