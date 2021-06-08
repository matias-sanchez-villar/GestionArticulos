<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="text-center d-md-flex justify-content-md-center" style="padding-top:120px;">
        <div class="col-md-12 search-table-col" style="width: 85%;">
            <div class="table-responsive table table-hover table-bordered results">
                <table class="table table-hover table-bordered" style="color:#f5f7fa; ">
                    <thead class="bill-header cs Hover" style="background-color:#1a2639;">
                        <tr>
                            <th class="col-lg-3 color">Nombre</th>
                            <th class="col-lg-2">Precio</th>
                            <th class="col-lg-2">Cantidad</th>
                            <th class="col-lg-2">Total</th>
                            <th class="col-lg-2">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                         <% foreach (Domain.Carrito item in cartlist)
                            { %>
                            <tr>
                                <td><% = item.Product.Name %></td>
                                <td><% = item.Product.Price %></td>
                                <td><% = item.Quantity %></td>
                                <td>$<% = Math.Round(item.Product.Price * item.Quantity, 0) %></td>
                                <td>
                                    <a style="background-color: #198754;" href="Cart.aspx?id=<% = item.Product.ID %>" class="btn btn-success" style="margin-left: 5px;" type="submit">
                                        <i class="fa fa-plus" style="font-size: 15px;"></i>
                                    </a>
                                    <a href="Cart.aspx?id=<% = item.Product.ID %>&r=u" class="btn btn-danger" style="margin-left: 5px;" type="submit">
                                        <i class="fa fa-minus" style="font-size: 15px;"></i>
                                    </a>
                                </td>
                            </tr>
                        <%} %>
                    </tbody>
                </table>
            </div>
        </div>
    </div>

        <div class="totals-container">
            <h3>Total products in your cart: <% = TotalProductos %></h3>
            <h3>Total price: <% = PrecioTotal %></h3>
        </div>

</asp:Content>
