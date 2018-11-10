<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KifuManager._Default" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ThaPoTuMi</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="About" class="btn btn-primary btn-lg">About Us &raquo;</a></p>
    </div>

    <div class="row">

        <%--TOP POPULAR OPENING--%>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP POPULAR OPENING</div>
                    <div class="panel panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th class="text-center">Opening Name</th>
                                    <th class="text-center">Used</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTopOpening" runat="server">
                                    <ItemTemplate>
                                        <tr class="text-center">
                                            <td><a href='SearchKifu.aspx?openID=<%#Eval("OpenID") %>'> <%#Eval("OpenName") %> </a></td>
                                            <td><%#Eval("Amount") %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <%--TOP FAVOURITE KIFU--%>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP FAVOURITE KIFU</div>
                    <div class="panel panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th class="text-center">Match</th>
                                    <th class="text-center">Favour</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTopFavour" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><a href='ViewKifu.aspx?KifuID=<%#Eval("KifuID") %>'><%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>) vs <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)</a></td>
                                            <td class="text-center"><%#Eval("Favour") %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <%--TOP NEW KIFU--%>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading text-center">TOP NEW KIFUS</div>
                    <div class="panel panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th class="text-center">Match</th>
                                    <th class="text-center">Result</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptTopNews" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><a href='ViewKifu.aspx?KifuID=<%#Eval("KifuID") %>'><%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>) vs <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)</a></td>
                                            <td><%#Eval("Result") %></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

    </div>

</asp:Content>



