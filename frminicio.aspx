<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frminicio.aspx.cs" Inherits="Web1Mamn.frminicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 310px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="ButtonCargaDatos" runat="server" Height="60px" OnClick="ButtonCargaDatos_Click" Text="Cargar Datos a DB" Width="199px" />
        <p style="width: 571px">
            SQL SERVER</p>
        <asp:TextBox ID="TextBoxID" runat="server" Width="445px"></asp:TextBox>
        <asp:Button ID="ButtonBuscarID" runat="server" Height="23px" OnClick="ButtonBuscarID_Click" Text="Buscar por ID" />
        <p>
            <asp:TextBox ID="TextBoxNombre" runat="server" Width="445px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarporNombre" runat="server" OnClick="ButtonBuscarporNombre_Click" Text="Buscar por Nombre" Width="200px" />
        </p>
        <p>
            <asp:TextBox ID="TextBoxResultadoSQL" runat="server" Width="563px"></asp:TextBox>
        </p>
        <p style="width: 571px">
            MYSQL</p>
        <p>
            <asp:TextBox ID="TextBoxIDMySql" runat="server" Width="433px"></asp:TextBox>
            <asp:Button ID="ButtonIDMySql" runat="server" OnClick="ButtonIDMySql_Click" Text="Buscar por ID" Width="124px" />
        </p>
        <p>
            <asp:TextBox ID="TextBoxNombreMySql" runat="server" Width="429px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarporNombreMySql" runat="server" OnClick="ButtonBuscarporNombreMySql_Click" Text="Buscar por Nombre" Width="209px" />
        </p>
        <asp:TextBox ID="TextBoxResultadoMySql" runat="server" Width="558px"></asp:TextBox>
    </form>
</body>
</html>
