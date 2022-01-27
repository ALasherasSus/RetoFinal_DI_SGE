<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Filtrar.aspx.vb" Inherits="ProyectoSGE.Filtrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelPais" runat="server" Font-Size="Larger" Text="País:"></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Larger" AutoPostBack="True">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="LabelCiudades" runat="server" Font-Size="Larger" Text="Ciudades:"></asp:Label>
<asp:DropDownList ID="DropDownList2" runat="server" Font-Size="Larger" AutoPostBack="True">
</asp:DropDownList>
    <br />
    <br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True">
</asp:GridView>
    <br />
    <asp:Label ID="LabelCity" runat="server" Text="City:"></asp:Label>
    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelCountry" runat="server" Text="Country:"></asp:Label>
    <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelCompanyName" runat="server" Text="Company Name:"></asp:Label>
    <asp:TextBox ID="TextBoxCompanyName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LabelAcentos" runat="server" Text="VER ACENTOS: BD, Editar columnas, HtmlEncode=FALSE"></asp:Label>
</asp:Content>
