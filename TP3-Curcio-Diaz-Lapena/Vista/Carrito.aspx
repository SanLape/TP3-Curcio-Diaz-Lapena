<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vista.Formulario_web11" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="py-4 text-center">Carrito de compras </h1>
    <div class="container">
        <div class="card" style="width: 100%;">
            <ul class="list-group list-group-flush ">
                <li class="list-group-item py-4">
                    <div class="d-flex justify-content-end pb-4">
                        <button style="border-radius:100px" class="btn btn-danger ">
                            <i class="fa-solid fa-trash"></i>
                        </button>
                    </div>
                    <div class="d-flex justify-content-between">
                        <div>
                            <h5>Titulo del articulo</h5>
                            <p>descripcion</p>
                        </div>
                        <div>
                            <p style="text-align: center;">Cantidad</p>

                            <div class="btn-group" role="group" aria-label="Basic example">
                                <button type="button" class="btn btn-danger">-</button>
                                <input type="text" style="width: 4vw;" />
                                <button type="button" class="btn btn-success">+</button>
                            </div>
                        </div>
                        <div>
                            <p style="text-align: center;">Total </p>
                            <p>$21212 </p>
                        </div>
                    </div>
                </li>
                <li class="list-group-item py-4">A second item</li>
                <li class="list-group-item py-4">A third item</li>
            </ul>
        </div>
    </div>
</asp:Content>
