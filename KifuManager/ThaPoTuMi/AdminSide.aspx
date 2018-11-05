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
                <asp:FileUpload ID="fuOpening" runat="server" />
                <br />
                <asp:Button ID="btnNewOpening" runat="server" class="btn btn-success" Text="Created" OnClick="btnNewOpening_Click" />
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
                <asp:Button ID="btnNewTitle" runat="server" class="btn btn-success" Text="New Title" />
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">List Account</div>
            <div class="panel-body">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <td>No</td>
                            <td>Username</td>
                            <td>Email</td>
                            <td>Status</td>
                            <td>Type</td>
                            <td>Action</td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Phong</td>
                            <td>phongtt@fpt.edu.vn</td>
                            <td>Actived</td>
                            <td>User</td>
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
