<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>CARRITO </h1>
    <asp:GridView ID="dgvArticulo" runat="server" CssClass="table"></asp:GridView>
    <div class="row row-cols-1 row-cols-md-2 g-4">
        <%
            foreach (Dominio.Articulo art in ListaArticulo)
            {
        %>
            <div class="col">
                <div class="card">
                    <img src="<%: art.ImagenURL %>"" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%: art.Nombre %></h5>
                        <p class="card-text"><%: art.Descripcion %></p>
                    </div>
                </div>
            </div>
        <%  } %>
    </div>
</asp:Content>
