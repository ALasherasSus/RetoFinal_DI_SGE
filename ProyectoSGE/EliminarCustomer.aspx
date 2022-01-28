<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="EliminarCustomer.aspx.vb" Inherits="ProyectoSGE.EliminarCustomer" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelCuidado" runat="server" Text="CUIDADO: el msgbox sale por detrás."></asp:Label>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ELORRIETA %>" 
        DeleteCommand="DELETE FROM [Customers] WHERE [CustomerID] = ?" InsertCommand="INSERT INTO [Customers] ([CustomerID], [CompanyName], [City], [Country]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ELORRIETA.ProviderName %>" SelectCommand="SELECT [CustomerID], [CompanyName], [City], [Country] FROM [Customers]" UpdateCommand="UPDATE [Customers] SET [CompanyName] = ?, [City] = ?, [Country] = ? WHERE (([CustomerID] = ?) OR ([CustomerID] IS NULL AND ? IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="CustomerID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CustomerID" Type="String" />
            <asp:Parameter Name="CompanyName" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CompanyName" Type="String" />
            <asp:Parameter Name="City" Type="String" />
            <asp:Parameter Name="Country" Type="String" />
            <asp:Parameter Name="CustomerID" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <asp:Label ID="Label2" runat="server" Text="BD, editar columnas, convertir en plantillas"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False"
                        CommandName="Delete" Text="Eliminar"></asp:LinkButton>

                    <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server"
                        TargetControlID="LinkButton1"
                        ConfirmText="Estas seguro que deseas borrar">
                    </ajaxToolkit:ConfirmButtonExtender>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
            <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
        </Columns>
    </asp:GridView>
    </asp:Content>
