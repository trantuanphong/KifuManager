<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="KifuManager.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<script type="text/javascript" src="wgo/wgo.js"></script>
	<script type="text/javascript" src="wgo/kifu.js"></script>
	<script type="text/javascript" src="wgo/sgfparser.js"></script>
	<script type="text/javascript" src="wgo/player.js"></script>
	<script type="text/javascript" src="wgo/basicplayer.js"></script>
	<script type="text/javascript" src="wgo/basicplayer.component.js"></script>
	<script type="text/javascript" src="wgo/basicplayer.infobox.js"></script>
	<script type="text/javascript" src="wgo/basicplayer.commentbox.js"></script>
	<script type="text/javascript" src="wgo/basicplayer.control.js"></script>
	<script type="text/javascript" src="wgo/player.editable.js"></script>
	<script type="text/javascript" src="wgo/scoremode.js"></script>
	<script type="text/javascript" src="wgo/player.permalink.js"></script>

	<link rel="stylesheet" type="text/css" href="wgo/wgo.player.css" />

    <div class="col-sm-7">
        <div data-wgo="<%=Content%>"></div>
    </div>
    
</asp:Content>
