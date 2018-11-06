<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="SearchKifu.aspx.cs" Inherits="KifuManager.SearchKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">Search</div>
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
                    <asp:DropDownList ID="drRank" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="drOpen">By game opening:</label>
                    <asp:DropDownList ID="drOpen" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <asp:Button ID="btnSearch" runat="server" Text="Search" class="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">List</div>
            <div class="panel-body">
                <asp:GridView ID="grvListKifu" class="table table-striped" runat="server" AllowPaging="True" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="KifuID" HeaderText="KifuID" Visible="False" />
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" />
                        <asp:BoundField DataField="Event" HeaderText="Event" />
                        <asp:TemplateField HeaderText="White Player">
                            <ItemTemplate>
                                <%#Eval("WhitePlayer") %> <%#Eval("WhiteLevel") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Black Player">
                            <ItemTemplate>
                                <%#Eval("BlackPlayer") %> <%#Eval("BlackLevel") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Result" DataFormatString="{0}" HeaderText="Result" />
                        <asp:BoundField DataField="Date" DataFormatString="{0:d}" HeaderText="Date" />
                        <asp:HyperLinkField DataNavigateUrlFields="KifuID" DataNavigateUrlFormatString="ViewKifu.aspx?KifuID={0}" HeaderText="Action" Text="View" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
