<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Ecommerce.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<div class="row mt-5 align-items-center" style=" height:500px; text-align:center; ">
    <div class="col-md-6">
        <div class="row justify-content-center">
            <img
                class="img-fluid mx-auto d-block"
                src="<% = prodAux.URLimage %>"
                alt="" style="height:400px; width:400px; margin:0;"/>
        </div>
    </div>
    <div class="col-md-6">
        <h1 class="pb-4 text-left"><% = prodAux.Name %></h1>
        <p class="py-3 text-left">
            <% = prodAux.Description %>
        </p>
        <h4 class="h3 text-left"><% = prodAux.Price %></h4>
        <a href="Cart.aspx?id=<% = prodAux.ID %>" class="btn btn-primary btn-lg mt-4">Add to cart</a>
    </div>
</div>


</asp:Content>
