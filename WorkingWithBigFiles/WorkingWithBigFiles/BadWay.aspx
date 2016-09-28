<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/main.Master" CodeBehind="BadWay.aspx.cs" Inherits="WorkingWithBigFiles.BadWay" %>


<asp:Content runat="server" ContentPlaceHolderID="titleContainer">
            <h1>The bad way</h1>
            <p class="lead">Reading the whole file and trying to allocate in memory. It will probably cause the typical: "OutOfMemory" exception and if not, it will use a lot of the server's memory.</p>
            <p>To get the whole explanation, go to <a href="www.chuin.es">chuin.es</a>.</p>
        </asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="mainContainer">

    <h2>The bad way</h2>
    <p>
        <asp:FileUpload ID="FileBadWay" CssClass="btn btn-default btn-file" runat="server" />
    </p>
    <p>
        <asp:Button runat="server" ID="BtnBadWay" Text="Try it!" CssClass="btn btn-default" OnClick="BtnBadWay_Click" />
    </p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="buttonsContainer">
    <p>
        <a class="btn btn-default" href="../">Back</a>
    </p>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="messageContainer">
    <p>
        <asp:Label runat="server" ID="LabelSuccess" CssClass="successMessage" Visible="false"></asp:Label>
        <asp:Label runat="server" ID="LabelFail" CssClass="failMessage" Visible="false"></asp:Label>
    </p>
</asp:Content>