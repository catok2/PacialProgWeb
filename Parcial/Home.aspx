<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Parcial.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Button runat="server" Text="Ingreso Alumnos" PostBackUrl="~/IngresoAlumno.aspx" />&nbsp;
            <asp:Button runat="server" Text="Administrador de comentarios" PostBackUrl="~/ListadoComentarios.aspx" />
        </div>
    </form>
</body>
</html>
