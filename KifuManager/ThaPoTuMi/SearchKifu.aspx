<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="SearchKifu.aspx.cs" Inherits="KifuManager.SearchKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">SEARCH</div>
            <div class="panel-body">
                <div class="form-group">
                    <label for="txtPlayerName">By player name:</label>
                    <asp:TextBox ID="txtPlayerName" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtGameName">By game name:</label>
                    <asp:TextBox ID="txtGameName" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="drRank">By player rank:</label>
                    <asp:DropDownList ID="drRank" class="form-control" runat="server">
                        <asp:ListItem Text="All" Value="" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Kyu" Value="k"></asp:ListItem>
                        <asp:ListItem Text="Dan" Value="d"></asp:ListItem>
                        <asp:ListItem Text="Pro Dan" Value="p"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:CheckBox ID="cbOpening" runat="server" Text="By game opening:" />
                    <asp:DropDownList ID="drOpen" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="text-center">
                    <asp:Button ID="btnSearch" runat="server" Text="Search" class="btn btn-primary" OnClick="btnSearch_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">LIST OF KIFU  <span class="badge"><% %></span></div>
            <div class="panel-body">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th class="text-center">Event</th>
                            <th>Game Name</th>
                            <th class="text-center">Players</th>
                            <th>Result</th>
                            <th>Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("Event") %></td>
                                    <td><%#Eval("GameName") %></td>
                                    <td><a href='ViewKifu.aspx?KifuID=<%#Eval("KifuID") %>'><%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>) vs <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)</a></td>
                                    <td><%#Eval("Result") %></td>
                                    <td><%#Eval("Date","{0:d}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
