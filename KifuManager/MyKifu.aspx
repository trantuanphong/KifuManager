﻿<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="MyKifu.aspx.cs" Inherits="KifuManager.MyKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">New Kifu</div>
            <div class="panel-body">
                <asp:FileUpload ID="KifuUpload" runat="server" />
                <br />
                <asp:Button ID="btnUpload" class="btn btn-primary" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
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
</asp:Content>
