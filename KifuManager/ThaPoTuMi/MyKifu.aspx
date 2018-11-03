<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="MyKifu.aspx.cs" Inherits="KifuManager.MyKifu" %>

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
    <ul class="nav nav-pills nav-stacked">
        <li class="active"><asp:LinkButton runat="server" OnClick="ListMyKifu" Text="List My Kifu"/></li>
        <li><asp:LinkButton runat="server" OnClick="ListMyKifu" Text="List Favourite Kifu"/></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">List My Kifu</div>
            <div class="panel-body">
                <asp:GridView class="table table-striped" ID="grvList" runat="server" AllowPaging="True" BorderStyle="None"></asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
