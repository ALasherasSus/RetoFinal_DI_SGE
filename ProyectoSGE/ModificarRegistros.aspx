<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ModificarRegistros.aspx.vb" Inherits="ProyectoSGE.ModificarRegistros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="LabelModificar" runat="server" Text="Modificar Registros"></asp:Label>
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
    <br />
    <asp:Label ID="LabelProductName" runat="server" Text="ProductName: "></asp:Label>
    <asp:TextBox ID="TextBoxProductName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelQuantityPerUnit" runat="server" Text="QuantityPerUnit: "></asp:Label>
    <asp:TextBox ID="TextBoxQuantityPerUnit" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelUnitPrice" runat="server" Text="UnitPrice: "></asp:Label>
    <asp:TextBox ID="TextBoxUnitPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonModificar" runat="server" Text="Modificar un registro" />
    <br />
    <br />
</asp:Content>
