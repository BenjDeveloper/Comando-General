<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormaPrueba.aspx.cs" Inherits="PruebaCompleta.Vista.Paginas.FormaPrueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="km"></asp:Label>
    <asp:TextBox ID="_uxKilomentros" runat="server"></asp:TextBox>
     a 
    <asp:Label ID="Label2" runat="server" Text="mts:"></asp:Label>&nbsp;
    <asp:Label ID="_uxMetros" runat="server" Text="0"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mitad:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="LMitad" runat="server" Text="0"></asp:Label>
    <br />
    <asp:Button ID="_uxBoton" runat="server" Text="Calcular" OnClick="OnCalcular" />
</asp:Content>
