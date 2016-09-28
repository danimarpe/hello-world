<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BigFilesDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Big Files Demo</h1>
        <p class="lead">This is an example code. To get the whole explanation, go to <a href="www.chuin.es" class="btn btn-primary btn-lg">chuin.es</a>.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>The bad way</h2>
            <p>
                Reading the whole file and trying to allocate in memory. It will probably cause the typical: "OutOfMemory" exception and if not, it will use a lot of the server's memory.
            </p>
            <p>
                <a class="btn btn-default" href="#">Try it!</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>The good way</h2>
            <p>
                Reading small parts of the file and writing them one by one. It will not cause any memory exception and it will use just a portion of the server's memory.
            </p>
            <p>
                <a class="btn btn-default" href="#">Try it! &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
