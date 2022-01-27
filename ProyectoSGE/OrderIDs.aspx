<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="OrderIDs.aspx.vb" Inherits="ProyectoSGE.OrderIDs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="LabelFilas" runat="server" Text="0 filas."></asp:Label>
    <br />
    <br />
    <asp:Label ID="LabelTotal" runat="server" Text="El total es: 0€"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</asp:Content>
