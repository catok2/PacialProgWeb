<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoAlumno.aspx.cs" Inherits="Parcial.IngresoAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingreso Alumno</title>
   <link rel="stylesheet" href="css/Estilos.css" />
    <script type="text/javascript" src="js/script.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th colspan="5"><asp:Label Id="lblDpersonales" Text="Datos Personales" runat="server"/></th>
                </tr>
                <tr>
                    <td rowspan="2"><asp:Label ID="lblDobligatorios" Text="Datos Obligatorios" Class="obligatorio" runat="server"/></td>

                    <td><asp:Label Class="obligatorio" ID="lblApellido" Text="Apellido" runat="server"/></td>
                    <td><asp:TextBox Class="desenfocada" ID="txtApellido" runat="server"></asp:TextBox></td>

                    <td><asp:Label Class="obligatorio" ID="lblNombre" Text="Nombre" runat="server"/></td>
                    <td><asp:TextBox Class="desenfocada" ID="txtNombre" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Label Class="obligatorio" ID="lblDni" Text="DNI" runat="server" /></td>
                    <td><asp:TextBox Class="desenfocada" ID="txtDni" runat="server"></asp:TextBox></td>

                    <td><asp:Label Class="obligatorio" ID="lblMail" Text="E-mail" runat="server"/></td>
                    <td><asp:TextBox Class="desenfocada" ID="txtMail" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><asp:Label Class="preferencias" ID="lblPreferencias" Text="Preferencias" runat="server"/></td>
                    <td><asp:Label Class="preferencias" ID="lblTurno" Text="Turno" runat="server"/></td>

                    <td colspan="3">
                        <asp:DropDownList ID="opciones" Class="desenfocada" runat="server">
                            <asp:ListItem Value="" Selected="True">Seleccione Turno</asp:ListItem>
                            <asp:ListItem Value="Mañana">Mañana</asp:ListItem>
                            <asp:ListItem Value="Tarde">Tarde</asp:ListItem>
                            <asp:ListItem Value="Noche">Noche</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td colspan="5" align="right">
                        <asp:Button ID="btnEnviar" Text="Enviar" runat="server" OnClick="btnEnviar_Click" OnClientClick="return Validacion()"/>&nbsp;
                        <asp:Button ID="btnLimpiar" Text="Limpiar" runat="server" OnClick="btnLimpiar_Click" />
                    </td>
                </tr>

            </table>
            <br />
            <asp:HyperLink Text="Volver al Inicio" runat="server" NavigateUrl="Home.aspx" />
        </div>
 
    </form>
</body>
</html>
