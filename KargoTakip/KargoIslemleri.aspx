<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="KargoIslemleri.aspx.cs" Inherits="KargoTakip.Personel.KargoIslemleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <div class="row">
            <div class="col-md-12" style="font-weight: bold">GÖNDERENİN</div>
        </div>
        <div class="row">
            <div class="col-md-3">ADI SOYADI:</div>
            <div class="col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text1" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-3">İLİ</div>

            <div class="col-md-3">
                <asp:DropDownList runat="server" CssClass="mdb-select " ID="DD1" AutoPostBack="true" OnSelectedIndexChanged="DD1_SelectedIndexChanged">
                    <asp:ListItem Text="İli Seçiniz" />
                </asp:DropDownList>
            </div>

        </div>
        <div class="row">
            <div class="col-md-3">İLÇESİ</div>
            <div class="col-md-3">
                <asp:DropDownList runat="server" CssClass="mdb-select" ID="DD2">
                    <asp:ListItem Text="İli Seçiniz" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">TELEFON NO</div>
            <div class="col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text2" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-12" style="font-weight: bold">ALICININ</div>
        </div>
        <div class="row">
            <div class="col-md-3">ADI SOYADI</div>
            <div class="col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text3" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">İLİ</div>

            <div class="col-md-3">
                <asp:DropDownList runat="server" CssClass="mdb-select" ID="DD3" AutoPostBack="true" OnSelectedIndexChanged="DD3_SelectedIndexChanged">
                    <asp:ListItem Text="İli Seçiniz" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">İLÇESİ</div>
            <div class="col-md-3">
                <asp:DropDownList runat="server" CssClass="mdb-select" ID="DD4">
                    <asp:ListItem Text="İli Seçiniz" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">ADRES</div>
            <div class="col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text6" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-3">TELEFON NO</div>
            <div class="col-md-3">
                <asp:TextBox runat="server" CssClass="form-control" ID="Text4" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">OLUŞTURMA TARİHİ</div>
            <div class="col-md-3">
                <asp:Label Text="16.07.2017" runat="server" ID="lbltarih" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-3 offset-3">
                <asp:Button Text="Kargo Kaydet" runat="server" CssClass="btn btn-success" OnClick="B1_Click1" ID="B1" />
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-3">SON DURUM DÜZENLE:</div>
        </div>
        <div class="row">
            <div class="table-responsive">
                <div class="col-md-12">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table" Style="margin-left: 400px;" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="KargoId">
                        <Columns>
                            <asp:CommandField SelectText="Seç" ShowSelectButton="True" />
                            <asp:BoundField DataField="KargoId" HeaderText="KargoId" InsertVisible="False" ReadOnly="True" SortExpression="KargoId" />
                            <asp:BoundField DataField="GondericiAdSad" HeaderText="Gondericinin Ad Soyadı" SortExpression="GondericiAdSad" />
                            <asp:BoundField DataField="GondericiIl" HeaderText="Gondericinin İli" SortExpression="GondericiIl" />
                            <asp:BoundField DataField="GondericiIlce" HeaderText="Gondericinin İlçesi" SortExpression="GondericiIlce" />
                            <asp:BoundField DataField="GondericiTel" HeaderText="Gondericinin Tel No" SortExpression="GondericiTel" />
                            <asp:BoundField DataField="AliciAdSad" HeaderText="Alıcının Adı Soyadı" SortExpression="AliciAdSad" />
                            <asp:BoundField DataField="AliciIl" HeaderText="Alıcının İli" SortExpression="AliciIl" />
                            <asp:BoundField DataField="AliciIlce" HeaderText="Alıcının İçesi" SortExpression="AliciIlce" />
                            <asp:BoundField DataField="AliciAdres" HeaderText="Alıcının Adresi" SortExpression="AliciAdres" />
                            <asp:BoundField DataField="AliciTel" HeaderText="Alıcının Tel No" SortExpression="AliciTel" />
                            <asp:BoundField DataField="SonDurum" HeaderText="SonDurum" SortExpression="SonDurum" />
                            <asp:BoundField DataField="OlusturanPersonel" HeaderText="Olusturan Personel" SortExpression="OlusturanPersonel" />
                            <asp:BoundField DataField="OlusturmaTarihi" HeaderText="Olusturma Tarihi" SortExpression="OlusturmaTarihi" />
                        </Columns>
                        <HeaderStyle BackColor="#0099CC" />
                        <SelectedRowStyle BackColor="#FFCC99" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:kargoTakipConnectionString2 %>" SelectCommand="SELECT * FROM [Kargolar]"></asp:SqlDataSource>
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-3<">KARGO SON DURUM</div>
        <div class="col-md-3">
            <asp:TextBox runat="server" CssClass="form-control" ID="Text5" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-3 offset-3">
            <asp:Button ID="Button1" runat="server" Text="DÜZENLE" CssClass="btn btn-info" OnClick="Button1_Click1" Width="145px" />
        </div>
    </div>
</asp:Content>
