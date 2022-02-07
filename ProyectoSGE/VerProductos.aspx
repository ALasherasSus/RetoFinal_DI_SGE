<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="VerProductos.aspx.vb" Inherits="ProyectoSGE.VerProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelContador" runat="server" Text="En la tabla hay 0 registros."></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True">
    </asp:GridView>
</asp:Content>
