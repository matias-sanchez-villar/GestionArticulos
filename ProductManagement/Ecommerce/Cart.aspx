<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dvgCart" runat="server">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name"/>
            <asp:BoundField DataField="Description" HeaderText="Description"/>
            <asp:BoundField DataField="Price" HeaderText="Price"/>
        </Columns>
    </asp:GridView>

</asp:Content>
