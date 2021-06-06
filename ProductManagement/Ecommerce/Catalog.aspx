<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Ecommerce.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-to-center p-5 m-5" style="gap: 30px;">
        <h1 style="text-align:center;"">Featured products</h1>

        <% foreach (Domain.Product item in lista) {%>
        
            <div class="card" style="width: 18rem; height:500px; text-align:center; ">
                    <img src="<% = item.URLimage %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Name %></h5>
                    <p class="card-text" style=" text-align:left;"><% = item.Description %></p>
                    <h6 style="text-align:center;"> $<% = item.Price %></h6>
                    <a href="Cart.aspx?id=<% = item.ID %>" class="btn"> Add to cart </a>
                    <a href="Detalle.aspx?id=<% = item.ID %>" class="btn"> Info </a>
                </div>
            </div>

        <% } %>

    </div>

</asp:Content>
