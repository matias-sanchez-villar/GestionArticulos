﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Ecommerce.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<<<<<<< HEAD
     <div class="row row-to-center p-5 m-5" style="gap: 30px;">

            <h1 style="text-align:center;"">Featured products</h1>

            <%
                foreach (Domain.Product product in lista)
                { %>
                   <div class="card" style="width: 18rem; height:500px; text-align:center; ">
                      <img src="<% = product.URLimage %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                      <div class="card-body">
                        <h5 class="card-title"><% = product.Name %></h5>
                        <p class="card-text" style=" text-align:left;"><% = product.Description %></p>
                          <h6 style="text-align:center;"> $<% = product.Price.ToString().TrimEnd(new char[] { '0' } ).Replace(',', ' ') %></h6>
                          <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Add to cart" />
=======
    <div class="container-fluid">
        <div class="row p-5 m-5" style="gap: 30px;">
            <%
                foreach (Domain.Product product in lista)
                { %>
                   <div class="card" style="width: 18rem; height:450px;">
                      <img src="<% = product.URLimage %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                      <div class="card-body">
                        <h5 class="card-title"><% = product.Name %></h5>
                        <p class="card-text"><% = product.Description %></p>
                        <a href="#" class="btn btn-primary">Add to cart</a>
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495
                      </div>
                   </div>
                <% }
            %>
        </div>
<<<<<<< HEAD
=======
    </div>
>>>>>>> e61b175f4c25ecb15e2d3cbab0d5ab14ef299495

</asp:Content>