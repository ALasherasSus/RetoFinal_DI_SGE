<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AnadirRegistros.aspx.vb" Inherits="ProyectoSGE.AnadirRegistros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<asp:Label ID="LabelAnadir" runat="server" Text="Añadir Registros"></asp:Label>
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
<asp:Button ID="Button1" runat="server" Text="Añadir un registro" />
<br />
<br />
</asp:Content>
