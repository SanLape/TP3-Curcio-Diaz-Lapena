<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="py-4 text-center">CARRITO </h1>
    <label for = "searchButton" class="form-label">Busqueda</label>
    <input type="text" class="form-control w-25 mb-5" id="searchButton">
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%
            foreach (Dominio.Articulo art in ListaArticulo)
            {
        %>
        <div class="col">
            <div class="card" style="width: 18rem;">
                <img src="<%: art.imagenUrl %>" class="img-thumbnail" alt="...">
                <div class="card-body">
                    <h5 class="card-title"><%: art.Nombre %></h5>
                    <p class="card-text"><%: art.Descripcion %></p>
                    <a href="DetalleArticulo.aspx?id=<%: art.ID %>">Ver Detalle </a>
                </div>
            </div>
        </div>
        <%  } %>
    </div>
</asp:Content>
