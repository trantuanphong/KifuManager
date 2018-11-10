<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="MyKifu.aspx.cs" Inherits="KifuManager.MyKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">NEW KIFU</div>
            <div class="panel-body">
                <asp:FileUpload ID="KifuUpload" runat="server" /><br />
                <div class="text-center">
                    <asp:Button ID="btnUpload" class="btn btn-primary" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="form-inline">
            <asp:Button ID="btnListMyKifu" class="btn btn-primary" runat="server" Text="My Kifu" OnClick="btnListMyKifu_Click" />
            <asp:Button ID="btnListFavorKifu" class="btn btn-primary" runat="server" Text="Favourite Kifu" OnClick="btnListFavorKifu_Click" />
        </div>
    </div>

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">LIST KIFU</div>
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
