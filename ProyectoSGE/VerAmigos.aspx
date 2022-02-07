<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="VerAmigos.aspx.vb" Inherits="ProyectoSGE.VerAmigos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CNAmigos %>" ProviderName="<%$ ConnectionStrings:CNAmigos.ProviderName %>" SelectCommand="SELECT * FROM [Contactos]"></asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField ShowSelectButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
        <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
        <asp:BoundField DataField="FechaNacimiento" DataFormatString="{0:d}" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
        <asp:CheckBoxField DataField="Carnet" HeaderText="Carnet" SortExpression="Carnet" />
        <asp:BoundField DataField="Cuota" DataFormatString="{0:F2}" HeaderText="Cuota" SortExpression="Cuota" />
        <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="../Images/{0}" HeaderText="Foto">
            <ControlStyle Height="30px" Width="30px" />
        </asp:ImageField>
        <asp:HyperLinkField DataNavigateUrlFields="Url" DataTextField="Url" HeaderText="Url" />
    </Columns>
</asp:GridView>
</asp:Content>
