<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KifuManager._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ThaPoTuMi</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="About" class="btn btn-primary btn-lg">About Us &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP POPULAR OPENING</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopOpening" class="table table-striped" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="OpenID" HeaderText="OpenID" Visible="False" />
                                <asp:BoundField DataField="OpenName" HeaderText="Open Name" />
                                <asp:BoundField DataField="Amount" HeaderText="Used"/>
                                <asp:HyperLinkField DataNavigateUrlFields="OpenID" DataNavigateUrlFormatString="SearchKifu.aspx?openID={0}" HeaderText="Action" Text="<span class='glyphicon glyphicon-log-out'>" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP FAVOURITE KIFU</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopFavourite" class="table table-striped" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="KifuID" HeaderText="KifuID" Visible="False" />
                                <asp:TemplateField HeaderText="White Player">
                                    <ItemTemplate>
                                        <%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>)
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Black Player">
                                    <ItemTemplate>
                                        <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:HyperLinkField DataNavigateUrlFields="KifuID" DataNavigateUrlFormatString="ViewKifu.aspx?KifuID={0}" HeaderText="Action" Text="<span class='glyphicon glyphicon-log-out'>" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP NEW KIFUS</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopNews" class="table table-striped" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="KifuID" HeaderText="KifuID" Visible="False" />
                                <asp:TemplateField HeaderText="White Player">
                                    <ItemTemplate>
                                        <%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>)
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Black Player">
                                    <ItemTemplate>
                                        <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:HyperLinkField DataNavigateUrlFields="KifuID" DataNavigateUrlFormatString="ViewKifu.aspx?KifuID={0}" HeaderText="Action" Text="<span class='glyphicon glyphicon-log-out'>" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>



