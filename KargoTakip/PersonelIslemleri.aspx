<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonelIslemleri.aspx.cs" Inherits="KargoTakip.Admin.PersonelIslemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" CssClass="alert alert-danger" runat="server" />
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-3">
                Ad Soyad:
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                Tc No:
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                Kullanıcı Tipi:
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                Kullanıcı Adı:
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                Kullanıcı Şifresi:
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="EKLE" OnClick="Button1_Click1" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="Button2" runat="server" CssClass="btn btn-warning" Text="DÜZENLE" OnClick="Button2_Click" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="Button3" runat="server" CssClass="btn btn-danger" Text="SİL" OnClick="Button3_Click1" />
            </div>
        </div>
        <div class="table-responsive">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" CssClass="table" Style="margin-left: 400px;" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField SelectText="Seç" ShowSelectButton="True" />
                        <asp:BoundField DataField="adsad" HeaderText="Ad Soyad" SortExpression="adsad" />
                        <asp:BoundField DataField="TC" HeaderText="TC" SortExpression="TC" />
                        <asp:BoundField DataField="kullanici_tipi" HeaderText="kullanici_tipi" SortExpression="kullanici_tipi" />
                        <asp:BoundField DataField="kullanici_ad" HeaderText="kullanici_ad" SortExpression="kullanici_ad" />
                        <asp:BoundField DataField="kullanici_sifre" HeaderText="kullanici_sifre" SortExpression="kullanici_sifre" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kargoTakipConnectionString2 %>" SelectCommand="SELECT [adsad], [TC], [kullanici_tipi], [kullanici_ad], [kullanici_sifre] FROM [kullanicilar]"></asp:SqlDataSource>
            </div>
        </div>
    </div>
    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="None" ErrorMessage=" T.C Numarasını Kotrol Edin" OnServerValidate="CustomValidator1_ServerValidate"> </asp:CustomValidator>
</asp:Content>
