<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KargomNerede.aspx.cs" Inherits="KargoTakip.KargomNerede" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-4">Takip kodunu Giriniz</div>
            <div class="col-md-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text1" />
            </div>
            <div class="col-md-4">
                <asp:Button Text="Kargo Ara" runat="server" CssClass="btn btn-success" ID="B1" OnClick="B1_Click" />
            </div>
        </div>
        <div class="table-responsive">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" CssClass="table" Style="margin-left: 400px;" AutoGenerateColumns="False" DataKeyNames="KargoId" DataSourceID="SqlDataSource1" Visible="False">
                    <Columns>
                        <asp:BoundField DataField="KargoId" HeaderText="KargoId" InsertVisible="False" ReadOnly="True" SortExpression="KargoId" />
                        <asp:BoundField DataField="GondericiAdSad" HeaderText="GondericiAdSad" SortExpression="GondericiAdSad" />
                        <asp:BoundField DataField="SonDurum" HeaderText="SonDurum" SortExpression="SonDurum" />
                        <asp:BoundField DataField="AliciAdSad" HeaderText="AliciAdSad" SortExpression="AliciAdSad" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kargoTakipConnectionString2 %>" SelectCommand="SELECT [KargoId], [GondericiAdSad], [SonDurum], [AliciAdSad] FROM [Kargolar]"></asp:SqlDataSource>
            </div>
        </div>
    </div>
</asp:Content>
