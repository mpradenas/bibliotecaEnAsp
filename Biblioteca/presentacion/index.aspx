<%@ Page Title="" Language="C#" MasterPageFile="~/paginaMaestra/MasterPage.master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Biblioteca.presentacion.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_principal" runat="server">
      <div class="container" style="margin-top:50px">
            <h2>Cliente</h2>
            <form>
              <div class="form-group">
                  <label for="nombre" class="label">Nombre</label>
                  <input type="text" class="form-control" id="nombre" placeholder="nombre">
              </div>
              <button type="button" id="guarda"class="btn btn-primary">Guardar</button>
              <button type="button" class="btn btn-default" onclick="cancelar();" style="display:none" >Cancelar</button>
           
            </form>
            
            
       </div>
 
 <script type="text/javascript" src="javascript/cliente.js?2"></script>   
</asp:Content>
