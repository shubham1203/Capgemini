<%@ Page Title="" Language="C#" MasterPageFile="~/AdmissionLogin.Master" AutoEventWireup="true" CodeBehind="RegisterStudent.aspx.cs" Inherits="AdmissiontSystem.PL.RegisterStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 196px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="3" class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label6" runat="server" Text="Student Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSname" runat="server" Width="257px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label7" runat="server" Text="DOB"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="calDOB" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label10" runat="server" Text="Institute Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                </asp:DropDownList>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label11" runat="server" Text="Course Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Button2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
