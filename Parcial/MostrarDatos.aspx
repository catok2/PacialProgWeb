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
            <h1>Datos</h1>
            <table border="1">
                <tr>
                    <td>Apellido</td>
                    <td>Nombre</td>
                    <td>DNI</td>
                    <td>E-mail</td>
                    <td>Turno</td>
                </tr>
                <tr>
                    <td><asp:Label Text="" runat="server"></asp:Label></td>
                    <td><asp:Label Text="" runat="server"></asp:Label></td>
                    <td><asp:Label Text="" runat="server"></asp:Label></td>
                    <td><asp:Label Text="" runat="server"></asp:Label></td>
                    <td><asp:Label Text="" runat="server"></asp:Label></td>
                </tr>
            </table>
            <br />
            <br />
            <asp:TextBox ID="txtComentario" TextMode="MultiLine" runat="server"></asp:TextBox>&nbsp;
            <asp:Button ID="guardar" Text="Guardar" runat="server" OnClientClick="return validarComentario()" />
        </div>
    </form>
</body>
</html>
