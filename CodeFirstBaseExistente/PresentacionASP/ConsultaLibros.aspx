<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaLibros.aspx.cs" Inherits="PresentacionASP.ConsultaLibros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
             <br />
    <div>
        <asp:GridView ID="gvLibros" runat="server" Caption="LISTA DE LIBROS" CellPadding="4" Height="175px" Width="788px" AllowPaging="True" PageSize="8" OnPageIndexChanging="gvLibros_PageIndexChanging" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvLibros_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    <div>
        <asp:GridView ID="gvAutores" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Caption="Autores" CellPadding="4" Visible="False" Width="787px" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvAutores_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="Codigo" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Pais.Nombre" HeaderText="Nacionalidad" />
            </Columns>
            
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>
    <div>
        <asp:GridView ID="gvLibrosAutor" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" Caption="Otros libros del autor" CellPadding="4" GridLines="Horizontal" Width="784px" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="Edicion" HeaderText="Edicion" />
                <asp:BoundField DataField="Paginas" HeaderText="Paginas" />
                <asp:BoundField DataField="Genero.Descripcion" HeaderText="Genero" />
                <asp:BoundField DataField="Editoriale.Descripcion" HeaderText="Editorial" />
            </Columns>
            
            
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    </div>
</asp:Content>
