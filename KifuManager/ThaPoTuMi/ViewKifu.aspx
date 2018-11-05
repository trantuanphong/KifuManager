<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="ViewKifu.aspx.cs" Inherits="KifuManager.ViewKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">Upload file</div>
            <div class="panel-body">
                <asp:FileUpload ID="fuKifu" runat="server" />
            </div>
        </div>
    </div>

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">Game Information</div>
            <div class="panel-body form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameEvent">Game Event:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtGameEvent" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameName">Game Name:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtGameName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="gameDate">Game Date:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtGameDate" type="date" runat="server" class="form-control">03/19/2018</asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-2">
                        <asp:Button ID="btnSave" class="btn btn-primary" runat="server" Text="Save" />
                    </div>
                    <div class="col-sm-2">
                        <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" />
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <asp:Label ID="lblRate" runat="server" Text="Rating: 9/10"></asp:Label>
            </div>
            <div class="panel-body">
                <div class="form-group">
                    <label for="comment">
                        Rating and enter your comment here:
                    <asp:DropDownList ID="drRate" runat="server">
                        <asp:ListItem Text="1" Value="1"></asp:ListItem>
                        <asp:ListItem Text="2" Value="2"></asp:ListItem>
                        <asp:ListItem Text="3" Value="3"></asp:ListItem>
                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                        <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    </asp:DropDownList>
                    </label>
                    <textarea class="form-control" rows="5" id="comment" runat="server" name="txtComment"></textarea>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" />
                    <asp:Button ID="btnLike" class="btn btn-danger" runat="server" Text="Like" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <script type="text/javascript" src="../wgo/wgo.js"></script>
    <script type="text/javascript" src="../wgo/kifu.js"></script>
    <script type="text/javascript" src="../wgo/sgfparser.js"></script>
    <script type="text/javascript" src="../wgo/player.js"></script>
    <script type="text/javascript" src="../wgo/basicplayer.js"></script>
    <script type="text/javascript" src="../wgo/basicplayer.component.js"></script>
    <script type="text/javascript" src="../wgo/basicplayer.infobox.js"></script>
    <script type="text/javascript" src="../wgo/basicplayer.commentbox.js"></script>

    <link rel="stylesheet" type="text/css" href="../wgo/wgo.player.css" />
    <div data-wgo="<%=Content%>"></div>
</asp:Content>
