<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarDatos.aspx.cs" Inherits="Parcial.MostrarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar Datos</title>
    <script type="text/javascript" src="js/script.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
      <div>
            <h1>Datos del Alumno</h1>
            <table border="1">
                <tr>
                    <td>Apellido</td>
                    <td>Nombre</td>
                    <td>DNI</td>
                    <td>Email</td>
                    <td>Turno</td>
    
                </tr>
                <tr>
                    <td><asp:Label ID="lblApellido" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblNombre" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblDNI" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                    <td><asp:Label ID="lblTurno" runat="server"></asp:Label></td>
                </tr>
            </table>
            <br />
            <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="btnGuardarComentario" runat="server" Text="Guardar Comentario" OnClick="btnGuardarComentario_Click" OnClientClick="return validarComentario()"/>
        </div>
    </form>
</body>
</html>
