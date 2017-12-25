<%@ Page Title="" Language="C#" MasterPageFile="~/AdmissionLogin.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="AdmissiontSystem.PL.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 163px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="User Name" Font-Names="Arial"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="243px" Font-Names="Arial"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Username is required" Font-Names="Arial" Font-Size="10pt"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="InValid Username" Font-Names="Arial" Font-Size="10pt" ValueToCompare="admin"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Password" Font-Names="Arial"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="241px" Font-Names="Arial"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Password Required" Font-Names="Arial" Font-Size="10pt"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Invalid Password" Font-Names="Arial" Font-Size="10pt" ValueToCompare="admin"></asp:CompareValidator>
        </td>
    </tr>
</table>
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
&nbsp;<asp:Label ID="Label7" runat="server"></asp:Label>
<br />

</asp:Content>
