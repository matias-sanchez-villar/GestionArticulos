<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-top:100px;" class="whole-container">

            <% foreach (Domain.Carrito item in cartlist)
                { %>
            <div class="cart-item-container">

                <div class="cart-item-data">
                    <h5 class="product-title"><% = item.Product.Name %> </h5>
                    <h5 class="product-quantity" style="color: red;"><% = item.Quantity %> </h5>
                    <h5 class="product-total-price">$<% = item.Product.Price * item.Quantity %> </h5>
                    <img src="<% = item.Product.URLimage %>" />
                </div>
                <div class="cart-item-handler">
                    <a href="Cart.aspx?id=<% = item.Product.ID %>" class="btn">+</a>
                    <a href="Cart.aspx?id=<% = item.Product.ID %>&r=u" class="btn">-</a>
                </div>
            </div>
        <%} %>
        </div>


</asp:Content>
