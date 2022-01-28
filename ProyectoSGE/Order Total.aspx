<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Order Total.aspx.vb" Inherits="ProyectoSGE.Order_Total" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ELORRIETA %>" ProviderName="<%$ ConnectionStrings:ELORRIETA.ProviderName %>" SelectCommand="SELECT * FROM [Order Details]"></asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID,ProductID" DataSourceID="SqlDataSource1" AllowPaging="True">
    <Columns>
        <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
        <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
        <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        <asp:BoundField DataField="Discount" HeaderText="Discount" SortExpression="Discount" />
        <asp:TemplateField HeaderText="Total">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# String.Format("{0:F2}", Eval("UnitPrice") * Eval("Quantity")) %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
