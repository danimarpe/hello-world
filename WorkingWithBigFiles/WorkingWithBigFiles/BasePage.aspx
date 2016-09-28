<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/main.Master" CodeBehind="BasePage.aspx.cs" Inherits="WorkingWithBigFiles.BasePage" %>

<asp:Content runat="server" ContentPlaceHolderID="messageContainer">
    <p>
        <asp:Label runat="server" ID="LabelSuccess" CssClass="successMessage" Visible="false"></asp:Label>
        <asp:Label runat="server" ID="LabelFail" CssClass="failMessage" Visible="false"></asp:Label>
    </p>
</asp:Content>
