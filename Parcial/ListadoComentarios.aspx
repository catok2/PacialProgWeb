<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoComentarios.aspx.cs" Inherits="Parcial.ListadoComentarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <h2>Listado de Comentarios</h2>
            <asp:GridView ID="DataGrid" runat="server" AutoGenerateColumns="False" 
               DataKeyNames="Id"                 
                OnRowEditing="DataGrid_RowEditing" 
                OnRowDeleting="DataGrid_RowDeleting"
                OnRowUpdating="DataGrid_RowUpdating"
                OnRowCancelingEdit="DataGrid_RowCancelingEdit">
                
                <Columns>
                    <asp:BoundField DataField="DNI" HeaderText="DNI" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                     <asp:TemplateField HeaderText="Comentario">
                        <ItemTemplate>
                            <%# Eval("Comentario") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtComentario" runat="server" Text='<%# Bind("Comentario") %>' />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
