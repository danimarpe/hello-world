<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorkingWithBigFiles.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="/Content/site.css" rel="stylesheet" type="text/css" />

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Working with big files</title>
</head>
<body>
    <div id="main-containter" class="main-container center-block col-md-8">
        <div class="jumbotron">
            <h1>Big Files Demo</h1>
            <p class="lead">This is an example code. To get the whole explanation, go to <a href="www.chuin.es">chuin.es</a>.</p>
        </div>

        <div class="row">
            <div class="col-md-6">
                <h2>The bad way</h2>
                <p>
                    Reading the whole file and trying to allocate in memory. It will probably cause the typical: "OutOfMemory" exception and if not, it will use a lot of the server's memory.
                </p>
                <p>
                    <a class="btn btn-default" href="#">Try it! &raquo;</a>
                </p>
            </div>
            <div class="col-md-6">
                <h2>The good way</h2>
                <p>
                    Reading small parts of the file and writing them one by one. It will not cause any memory exception and it will use just a portion of the server's memory.
                </p>
                <p>
                    <a class="btn btn-default" href="#">Try it! &raquo;</a>
                </p>
            </div>
        </div>
    </div>
    <script src="/scripts/jquery-1.9.1.min.js" type="text/javascript" ></script>
    <script src="/scripts/bootstrap.min.js" type="text/javascript" ></script>
</body>
</html>
