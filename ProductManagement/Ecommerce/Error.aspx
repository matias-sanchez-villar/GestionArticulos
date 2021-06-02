<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="Ecommerce.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="alert alert-danger" role="alert" style="padding-top:120px;">
        <asp:Label ID="lblError" runat="server" Text="text"></asp:Label>
    </div>

    <div class="col-auto text-center">
        <a class="btn btn-primary p-3 m-3" href="Default.aspx" role="button">Home</a>
    </div>

</asp:Content>
