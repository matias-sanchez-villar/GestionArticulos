<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Ecommerce.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row row-to-center p-5 m-5" style="gap: 30px;">
        <h1 style="text-align:center;"">Featured products</h1>
        
        <asp:Repeater runat="server" ID="RepeatCatalog">

            <ItemTemplate>
                <div class="card" style="width: 18rem; height:500px; text-align:center; ">
                    <img src="<%#Eval("URLimage") %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Name") %></h5>
                        <p class="card-text" style=" text-align:left;"><%#Eval("Description") %></p>
                        <h6 style="text-align:center;"> $<%#Eval("Price") %></h6>
                        <asp:Button ID="btnAddProduct" runat="server" Text="Add to cart" CssClass="btn btn-primary" OnClick="AddProduct_click" CommandArgument='<%#Eval("ID") %>' />
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>

    </div>

</asp:Content>
