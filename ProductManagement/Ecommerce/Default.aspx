<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />


    <div class="carousel-container">
        
     <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
      <div class="carousel-indicators">
        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
      </div>
      <div class="carousel-inner">
        <div class="carousel-item active">
          <img src="https://www.apple.com/v/macbook-pro-13/g/images/overview/hero_endframe__bsza6x4fldiq_large_2x.jpg" class="d-block w-100" alt="...">
          <div class="carousel-caption d-none d-md-block">
            <h5>Macbook Pro - the Pro among Pro's</h5>
            <p>Some representative placeholder content for the first slide.</p>
          </div>
        </div>

        <div class="carousel-item">
          <img src="https://cdn.andro4all.com/files/2021/03/OnePlus-9-Pro-verde-1.jpg" class="d-block w-100" alt="...">
          <div class="carousel-caption d-none d-md-block">
            <h5>OnePlus 9 Pro - The Hasselblad revolution</h5>
            <p>Some representative placeholder content for the second slide.</p>
          </div>
        </div>

        <div class="carousel-item">
          <img src="https://www.gizmochina.com/wp-content/uploads/2021/04/Samsung-Galaxy-Z-Fold-2-Mystic-Black-Bronze-Featured.jpg" class="d-block w-100" alt="...">
          <div class="carousel-caption d-none d-md-block">
            <h5>Third slide label</h5>
            <p>Some representative placeholder content for the third slide.</p>
          </div>
        </div>
      </div>
      <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Previous</span>
      </button>
      <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="visually-hidden">Next</span>
      </button>
    </div>

    </div>



    <%--Aca tenemos la cantidad del carrito--%>

    <div class="container-fluid">

        <div class="row row-to-center p-5 m-5" style="gap: 30px;">

            <h1 style="text-align:center;"">Featured products</h1>
                
               <%
                   for(int i = 0; i<6; i++)
                   { %>
                   <div class="card" style="width: 18rem; height:500px; text-align:center; ">
                    <img src="<% = lista[i].URLimage %>" class="card-img-top" alt="product-image" style="height: 60%; object-fit:contain;">
                <div class="card-body">
                    <h5 class="card-title"><% = lista[i].Name %></h5>
                    <p class="card-text" style=" text-align:left;"><% = lista[i].Description %></p>
                    <h6 style="text-align:center;"> $<% = lista[i].Price %></h6>
                    <a href="Cart.aspx?id=<% = lista[i].ID %>" class="btn"> Add to cart </a>
                    <a href="Detalle.aspx?id=<% = lista[i].ID %>" class="btn"> Info </a>
                </div>
            </div>
                <% } %>
        </div>
    </div>


  <script>

      function createModal(id) {
          const modal = document.createElement('div');
          modal.classList.add('modal');
          modal.setAttribute('tabindex', '-1')
          modal.innerHTML = `
                             <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <img src="#" />
                                        <h5 class="modal-title"></h5>
                                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                    </div>
                                    <div class="modal-body">
                                        <p> asdasd </p>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                                        <button type="button" class="btn btn-primary">Add to cart</button>
                                     </div>
                                 </div>
                              </div>
                `
          document.body.appendChild(modal);
          return false;
      }
  </script>

      

</asp:Content>
