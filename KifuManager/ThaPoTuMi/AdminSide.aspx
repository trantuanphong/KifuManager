<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="AdminSide.aspx.cs" Inherits="KifuManager.AdminSide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">New Opening</div>
            <div class="panel-body form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtOpenName">Open Name:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtOpenName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtDescription">Description:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtOpenDescription" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <asp:FileUpload ID="fuOpening" runat="server" /><br />
                <div class="text-center">
                    <asp:Button ID="btnNewOpening" runat="server" class="btn btn-success" Text="Created" OnClick="btnNewOpening_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">New Title</div>
            <div class="panel-body form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtTitleName">Title Name:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtTitleName" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-4" for="txtTitlePoint">Title Point:</label>
                    <div class="col-sm-8">
                        <asp:TextBox ID="txtTitlePoint" type="number" runat="server" class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="text-center">
                    <asp:Button ID="btnNewTitle" runat="server" class="btn btn-success" Text="New Title" OnClick="btnNewTitle_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="form-inline">
            <asp:Button ID="btnListUser" class="btn btn-primary" runat="server" Text="List User" OnClick="btnListUser_Click" />
            <asp:Button ID="btnListTitle" class="btn btn-primary" runat="server" Text="List Title" OnClick="btnListTitle_Click" />
        </div>
    </div>

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">List Account</div>
            <div class="panel-body">
                <asp:GridView ID="grvList" class="table table-striped" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Username" HeaderText="Username" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="APoint" HeaderText="Point" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        <asp:BoundField DataField="Type" HeaderText="Type" />
                        <asp:HyperLinkField DataNavigateUrlFields="Username" DataNavigateUrlFormatString="" HeaderText="Action" Text="Reset" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
