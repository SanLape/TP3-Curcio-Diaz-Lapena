<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Vista.Formulario_web11" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="py-4 text-center">Carrito de compras </h1>
    <div class="container">

        <div class="card" style="width: 100%;">
            <ul class="list-group list-group-flush ">
               
            
                <asp:Repeater runat="server" ID="rptDatos" OnItemDataBound="rptDatos_ItemDataBound">
                    <ItemTemplate>
                        <li class="list-group-item py-4">
                            <div class="d-flex justify-content-end pb-4">
                                <asp:Button OnClick="btnEliminar_click" ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" Style="border-radius: 100px" CommandArgument='<%# Eval("ID") %>' />
                            </div>
                            <div class="d-flex justify-content-between">
                                <div>
                                    <h5><%#Eval("Nombre")%></h5>
                                    <p>descripcion</p>
                                </div>
                                <div>
                                    <p style="text-align: center;">Cantidad</p>
                                    <div class="btn-group" role="group" aria-label="Basic example">

                                        <asp:Button ID="btnLess" runat="server" Text="-" class="btn btn-danger" OnClick="btnLess_Click" />
                                        <asp:TextBox ID="txbCantidad" runat="server" Style="width: 4vw;" Text="0"></asp:TextBox>
                                        <asp:Button ID="btnPlus" runat="server" Text="+" class="btn btn-success" OnClick="btnPlus_Click" />

                                    </div>
                                </div>
                                <div style="text-align: center;">
                                    <p>Total</p>
                                    <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                                </div>
                            </div>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
               
            </ul>
        </div>

    </div>
</asp:Content>
