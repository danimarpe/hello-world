<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/main.Master" CodeBehind="Default.aspx.cs" Inherits="WorkingWithBigFiles.Default" %>
<asp:Content runat="server" ContentPlaceHolderID="titleContainer">
    <h1>Big Files Demo</h1>
    <p class="lead">This is an example code. To get the whole explanation, go to <a href="www.chuin.es">chuin.es</a>.</p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="leftContainer">
    <h2>The bad way</h2>
    <p>
        Reading the whole file and trying to allocate in memory. It will probably cause the typical: "OutOfMemory" exception and if not, it will use a lot of the server's memory.
    </p>
    <p>
        <a class="btn btn-default" href="BadWay.aspx">Try it! &raquo;</a>
    </p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="rightContainer">
    <h2>The good way</h2>
    <p>
        Reading small parts of the file and writing them one by one. It will not cause any memory exception and it will use just a portion of the server's memory.
    </p>
    <p>
        <a class="btn btn-default" href="GoodWay.aspx">Try it! &raquo;</a>
    </p>
</asp:Content>
