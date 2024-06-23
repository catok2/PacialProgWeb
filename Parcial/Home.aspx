<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Parcial.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link rel="stylesheet" href="css/HomeStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <div id="cuadro">
                <asp:Button ID="btnIngreso" runat="server" Text="Ingreso Alumnos" PostBackUrl="~/IngresoAlumno.aspx" />&nbsp;
                <asp:Button ID="btnAdmin" runat="server" Text="Administrador de comentarios" PostBackUrl="~/ListadoComentarios.aspx" />
            </div>
        </div>
    </form>
</body>
</html>
