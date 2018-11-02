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
                    <div class="panel panel-heading">TOP POPULAR OPENING</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopOpening" class="table table-striped" runat="server"></asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading">TOP FAVOURITE KIFU</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopFavourite" class="table table-striped" runat="server"></asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel panel-heading">TOP NEW KIFUS</div>
                    <div class="panel panel-body">
                        <asp:GridView ID="grvTopNews" class="table table-striped" runat="server"></asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
