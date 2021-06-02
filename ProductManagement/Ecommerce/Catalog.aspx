<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Ecommerce.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                      </div>
                   </div>
                <% }
            %>
        </div>
    </div>

</asp:Content>
