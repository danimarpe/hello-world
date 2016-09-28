<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/main.Master" CodeBehind="GoodWay.aspx.cs" Inherits="WorkingWithBigFiles.GoodWay" %>
<asp:Content runat="server" ContentPlaceHolderID="titleContainer">
    <h1>The good way</h1>
    <p class="lead">Reading small parts of the file and writing them one by one. It will not cause any memory exception and it will use just a portion of the server's memory.</p>
    <p>To get the whole explanation, go to <a href="www.chuin.es">chuin.es</a>.</p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContainer">
    <h2>The good way</h2>
    <p>
        <asp:FileUpload ID="FileGoodWay" CssClass="btn btn-default btn-file" runat="server" />
    </p>
    <p>
        <asp:Button runat="server" Text="Try it!" CssClass="btn btn-default" />
    </p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="buttonsContainer">
    <p>
        <a class="btn btn-default" href="../">Back</a>
    </p>
</asp:Content>
