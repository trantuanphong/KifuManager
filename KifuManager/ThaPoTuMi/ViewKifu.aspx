<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="ViewKifu.aspx.cs" Inherits="KifuManager.ViewKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">
                GAME INFORMATION
                - RATING <span class="badge">
                    <asp:Label ID="lblRate" runat="server"></asp:Label></span>
            </div>
            <div class="panel-body form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtBlackOpen">Black Open:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtBlackOpen" runat="server" ReadOnly="true" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtWhiteOpen">White Open:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtWhiteOpen" runat="server" ReadOnly="true" class="form-control"></asp:TextBox>
                    </div>
                </div>
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
                        <asp:TextBox ID="txtGameDate" runat="server" TextMode="Date" class="form-control">03/19/2018</asp:TextBox>
                    </div>
                </div>
                <% if (IsOwnKifu)
                    { %>
                <div class="form-inline text-center">
                    <asp:Button ID="btnSave" class="btn btn-primary" runat="server" Text="Save" OnClick="btnSave_Click" />
                    <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    <asp:Button ID="btnIdentify" class="btn btn-primary" runat="server" Text="Identify Opening" OnClick="btnIdentify_Click" />
                </div>
                <% } %>
            </div>
        </div>
    </div>

    <% if (Session["user"] != null)
        { %>
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">EVALUATE</div>
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
                    <asp:TextBox ID="txtComment" TextMode="MultiLine" Rows="5" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-inline text-center">
                    <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <% if (IsFavour)
                        {  %>
                    <asp:Button ID="btnDisLike" class="btn btn-danger" runat="server" Text="Dislike" OnClick="btnDisLike_Click" />
                    <%}
                        else
                        { %>
                    <asp:Button ID="btnLike" class="btn btn-success" runat="server" Text="Like" OnClick="btnLike_Click" />
                    <% } %>
                </div>
            </div>
        </div>
    </div>
    <% } %>
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

    <br />
    <div class="row">
        <asp:Repeater ID="rpComment" runat="server">
            <ItemTemplate>
                <label><%# Eval("Username") %> - <%# Eval("TitleName") %>  <span class="badge"><%# Eval("RatePoint") %></span></label>
                <div class="well"><%# Eval("Comment") %></div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <label><%# Eval("Username") %>  <span class="badge"><%# Eval("RatePoint") %></span></label>
                <div class="well"><%# Eval("Comment") %></div>
            </AlternatingItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
