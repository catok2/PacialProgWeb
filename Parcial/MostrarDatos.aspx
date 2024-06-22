<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarDatos.aspx.cs" Inherits="Parcial.MostrarDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar Datos</title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
            <h1>Datos del Alumno</h1>
            <table>
                <tr>
                    <td>Apellido:</td>
                    <td><asp:Label ID="lblApellido" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Nombre:</td>
                    <td><asp:Label ID="lblNombre" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>DNI:</td>
                    <td><asp:Label ID="lblDNI" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Turno:</td>
                    <td><asp:Label ID="lblTurno" runat="server"></asp:Label></td>
                </tr>
            </table>
            <asp:TextBox ID="txtComentario" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="btnGuardarComentario" runat="server" Text="Guardar Comentario" OnClick="btnGuardarComentario_Click"/>
        </div>
    </form>
</body>
</html>
