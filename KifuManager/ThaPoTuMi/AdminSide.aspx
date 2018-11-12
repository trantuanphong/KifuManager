<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="AdminSide.aspx.cs" Inherits="KifuManager.AdminSide" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">NEW OPENING</div>
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
                    <asp:Button ID="btnNewOpening" runat="server" class="btn btn-success" Text="New Opening" OnClick="btnNewOpening_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading text-center">NEW TITLE</div>
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
                        <asp:TextBox ID="txtTitlePoint" TextMode="Number" runat="server" class="form-control"></asp:TextBox>
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
        <div class="panel panel-primary">
            <div class="panel-heading text-center">LIST ACCOUNT</div>
            <div class="panel-body">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>Username</th>
                            <th>Email</th>
                            <th>Point</th>
                            <th>Type</th>
                            <th>Status</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="rptListUser" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("Username") %></td>
                                    <td><%#Eval("Email") %></td>
                                    <td><%#Eval("APoint") %></td>
                                    <td><%#Eval("Type").ToString().Equals("1") ? "Admin" : "User" %></td>
                                    <td><%#Eval("Status").ToString().Equals("True")? "Actived" : "Banned" %></td>
                                    <td>
                                        <a href='AdminSide.aspx?resetPass=<%#Eval("Username") %>'>Reset</a>
                                        <asp:HyperLink NavigateUrl='<%# Eval("Username","~/ThaPoTuMi/AdminSide.aspx?changeStatus={0}") %>'
                                            Visible='<%# Eval("Type").ToString().Equals("0") ? true:false%>' 
                                            runat="server" Text='<%#Eval("Status").ToString().Equals("True")? "Banned" : "Actived" %>'></asp:HyperLink>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel-heading text-center">LIST TITLE</div>
                    <div class="panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>TitleID</th>
                                    <th>Title Name</th>
                                    <th>Point</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptListTitle" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("TitleID") %></td>
                                            <td><%#Eval("TitleName") %></td>
                                            <td><%#Eval("Point") %></td>
                                            <td><a href='AdminSide.aspx?deleteTitle=<%#Eval("TitleID") %>'>Delete</a></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-6">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel-heading text-center">LIST OPENING</div>
                    <div class="panel-body">
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>OpenID</th>
                                    <th>Open Name</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="rptListOpen" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("OpenID") %></td>
                                            <td><%#Eval("OpenName") %></td>
                                            <td><a href='AdminSide.aspx?deleteOpen=<%#Eval("OpenID") %>'>Delete</a></td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
