<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="ViewKifu.aspx.cs" Inherits="KifuManager.ViewKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">Upload file</div>
            <div class="panel-body">
                <asp:FileUpload ID="fuKifu" runat="server" />
            </div>
        </div>
        <div class="panel panel-primary">
            <div class="panel-heading">Game Information</div>
            <div class="panel-body form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameEvent">Game Event:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="gameEvent" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameName">Game Name:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="gameName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameDate">Game Date:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="gameDate" type="date" runat="server" class="form-control">19/03/2018</asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <script type="text/javascript" src="wgo/wgo.js"></script>
    <script type="text/javascript" src="wgo/kifu.js"></script>
    <script type="text/javascript" src="wgo/sgfparser.js"></script>
    <script type="text/javascript" src="wgo/player.js"></script>
    <script type="text/javascript" src="wgo/basicplayer.js"></script>
    <script type="text/javascript" src="wgo/basicplayer.component.js"></script>
    <script type="text/javascript" src="wgo/basicplayer.infobox.js"></script>
    <script type="text/javascript" src="wgo/basicplayer.commentbox.js"></script>

    <link rel="stylesheet" type="text/css" href="wgo/wgo.player.css" />

    <div data-wgo="<%=Content%>"></div>
</asp:Content>
