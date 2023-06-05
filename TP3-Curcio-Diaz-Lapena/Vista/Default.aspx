<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vista.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="py-4 text-center">CARRITO </h1>
    <label for="searchButton" class="form-label">Busqueda</label>
    <input type="text" class="form-control w-25 mb-5" id="searchButton">
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater ID="repRepetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card" style="width: 18rem;">
                        <img src="<%#Eval("imagenUrl")%>" class="img-thumbnail" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre")%></h5>
                            <p class="card-text"><%#Eval("Descripcion")%></p>
                            <div class="d-flex justify-content-between">
                                <a href="DetalleArticulo.aspx?id=<%#Eval("ID")%>">Ver Detalle </a>
                                <asp:Button ID="btnAddCart" runat="server" Text="Agregar al carrito" CssClass="btn btn-success" OnClick="btnAddCart_Click" CommandArgument='<%#Eval("ID") %>' CommandName="articuloId" />
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
