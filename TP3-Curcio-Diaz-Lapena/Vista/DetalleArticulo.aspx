<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Vista.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="mb-3">
        <label for="formGroupExampleInput" class="form-label">CODIGO</label>
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="formGroupExampleInput2" class="form-label">NOMBRE</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="formGroupExampleInput2" class="form-label">DESCRIPCION</label>
        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label class="form-label">MARCA</label>
        <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label class="form-label">CATEGORIA</label>
        <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label class="form-label">PRECIO</label>
        <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
    </div>
</asp:Content>
