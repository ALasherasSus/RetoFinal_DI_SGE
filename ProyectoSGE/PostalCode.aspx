<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="PostalCode.aspx.vb" Inherits="ProyectoSGE.PostalCode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="SELECT [CustomeID], [CompanyName], [City], [Country], [PostalCode] FROM [Customers]"></asp:Label>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Si el PostalCode es par / impar / otra cosa"></asp:Label>
<br />
<br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ELORRIETA %>" ProviderName="<%$ ConnectionStrings:ELORRIETA.ProviderName %>" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country], [PostalCode] FROM [Customers]"></asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
        <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
        <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
        <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
    </Columns>
</asp:GridView>
</asp:Content>
