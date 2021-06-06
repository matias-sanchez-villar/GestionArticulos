<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Ecommerce.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
            <div class="card" style="width: 18rem; height:500px; text-align:center; ">
                    <img src="<% = prodAux.URLimage %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                <div class="card-body">
                    <h5 class="card-title"><% = prodAux.Name %></h5>
                    <p class="card-text" style=" text-align:left;"><% = prodAux.Description %></p>
                    <h6 style="text-align:center;"> $<% = prodAux.Price %></h6>
                    <a href="Cart.aspx?id=<% = prodAux.ID %>" class="btn"> Add to cart </a>
                </div>
            </div>
    </div>


</asp:Content>
