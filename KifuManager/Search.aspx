<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="KifuManager.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <div class="col-sm-4">
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
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>

        <div class="col-sm-8">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel-heading">List</div>
                    <div class="panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <td>No</td>
                                    <td>White Player</td>
                                    <td>Black Player</td>
                                    <td>Result</td>
                                    <td>Date</td>
                                    <td>Game Name</td>
                                    <td>Action</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>Phong</td>
                                    <td>Phong</td>
                                    <td>W+R</td>
                                    <td>11-11-1111</td>
                                    <td>FGocTournament</td>
                                    <td>
                                        <span class="glyphicon glyphicon-download"></span>
                                        <span class="glyphicon glyphicon-open"></span>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
