<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoComentarios.aspx.cs" Inherits="Parcial.ListadoComentarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado de Comentarios</title>
</head>
<body>
<form id="form1" runat="server">
        <div align="center">
            <h2>Listado de Comentarios</h2>
            <asp:GridView ID="DataGrid" runat="server" AutoGenerateColumns="False" 
               DataKeyNames="Id"                 
                OnRowEditing="DataGrid_RowEditing" 
                OnRowDeleting="DataGrid_RowDeleting"
                OnRowUpdating="DataGrid_RowUpdating"
                OnRowCancelingEdit="DataGrid_RowCancelingEdit" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
                
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
                
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />

            </asp:GridView>
            <br />
            <asp:HyperLink Text="Volver al Inicio" runat="server" NavigateUrl="Home.aspx" />
        </div>
    </form>
</body>
</html>
