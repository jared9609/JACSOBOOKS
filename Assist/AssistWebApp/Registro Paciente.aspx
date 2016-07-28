<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro Paciente.aspx.cs" Inherits="AssistWebApp.Registro_Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<!--Nombre/Apellido-->
<div class="form-group">
    <label for="Nombre">Email</label>
    <input type="text" class="form-control" id="txtNombre"
           placeholder="Introduce tu Nombre">
  </div>

    <!--Sexo-->
  <div class="form-group">
    <label for="Sexo">Sexo</label>
    <select class="form-control">
  <option>Masculino</option>
  <option>Femenino</option>
  <option>Indefinido</option>
</select>
  </div>

     <!--Fecha de Nacimiento-->
  <div class="form-group">
    <label for="Fec_nac">Fecha de nacimiento</label>
    <input type="date" id="txtFechaNac">
  </div>

     <!--Pais-->
    <div class="form-group">
    <label for="Pais">Pais</label>
    <select runat ="server" id="cboPais" class="form-control">
         
</select>
  </div>
    
     <!--Estado-->
    <div class="form-group">
    <label for="Estado">Estado</label>
    <select class="form-control">
        <input type="text" id="estado">
</select>
  </div>

     <!--Municipio-->
        <div class="form-group">
    <label for="Municipio">Municipio</label>
    <select class="form-control">
        <input type="text" id="municipio">
</select>
  </div>

     <!--Colonia-->
    <div class="form-group">
    <label for="Colonia">Colonia</label>
        <textarea class="form-control" rows="3" id="txtColonia"></textarea>
        </div>

      <!--Calle-->
        <div class="form-group">
    <label for="Calle">Calle</label>
    <input type="text" class="form-control" id="txtCalle"
           placeholder="Introduce tu calle y numero">
  </div>

      <!--Codigo Postal-->
        <div class="form-group">
    <label for="Cod_Postal">Codigo Postal</label>
    <input type="number" class="form-control" id="txtCodPostal" >
  </div>
      
    <!--Telefono-->
    <div class="form-group">
    <label for="Telefono">Telefono</label>
    <input type="tel" class="form-control" id="txtTelefono" >
  </div>
      
    <!--Celular-->
    <div class="form-group">
    <label for="Celular">Celular</label>
    <input type="tel" class="form-control" id="txtCelular" >
  </div>

      <!--Email-->
             <div class="form-group">
    <label for="Email">Email</label>
    <input type="text" class="form-control" id="txtEmail"
           placeholder="Introduce tu Email">
  </div>
     
     <!--Curp-->
             <div class="form-group">
    <label for="CURP">CURP</label>
    <input type="text" class="form-control" id="txtCurp"
           placeholder="Introduce tu CURP">
  </div>

    
  <div class="checkbox">
    <label>
      <input type="checkbox"> Activa esta casilla
    </label>
  </div>
  <button type="submit" class="btn btn-default">Enviar</button>
</asp:Content>
