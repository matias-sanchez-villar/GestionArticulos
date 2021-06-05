<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ecommerce.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-top:100px;" class="container-fluid">

        <table class="table">
            <thead class="thead-dark">
                <tr>
                  <th scope="col">Name</th>
                  <th scope="col">Description</th>
                  <th scope="col">Quantity</th>
                  <th scope="col">Price</th>
                </tr>
            </thead>
            <tbody>
                <%--
                    Bueno yo cree una lista para mostrar los producto en el carrito,
                    Abria que definir si de aca se pueden agregar mas productos con un 
                    TextBox TextMode="Number" o dejarlo fijo mostrarlo.
                 --%>
                <tr>
                  <th scope="row"></th>
                  <td></td>
                  <td></td>
                  <td></td>
                </tr>
            </tbody>
        </table>

    </div>


</asp:Content>
