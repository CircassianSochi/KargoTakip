<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KargoTakip.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-7">
        <div class="row">
            <div class="col">Kullanıcı Adı:</div>
            <div class="col">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text1" />
            </div>
        </div>
        <div class="row">
            <div class="col">Şifre:</div>
            <div class="col">
                <asp:TextBox runat="server" ID="Text2" CssClass="form-control" TextMode="Password" />
            </div>
        </div>
        <div class="row">
            <div class="col"></div>
            <div class="col"></div>
        </div>
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <asp:Button Text="Giriş" runat="server" CssClass="btn btn-success" ID="B1" OnClick="B1_Click1" />
            </div>
        </div>
    </div>
</asp:Content>
