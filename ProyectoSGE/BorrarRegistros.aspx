<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="BorrarRegistros.aspx.vb" Inherits="ProyectoSGE.BorrarRegistros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
<asp:Label ID="LabelEliminar" runat="server" Text="Eliminar Registros"></asp:Label>
<br />
<br />
<asp:Label ID="LabelBuscar" runat="server" Text="Buscar por ProductsID: "></asp:Label>
<asp:TextBox ID="TextBoxBuscar" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" />
<br />
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
<br />
<asp:Button ID="ButtonBorrar" runat="server" Text="Eliminar un registro" />
<br />
<br />
</asp:Content>
