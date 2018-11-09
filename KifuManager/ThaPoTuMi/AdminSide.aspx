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
                    <asp:Button ID="btnNewOpening" runat="server" class="btn btn-success" Text="New Opening" OnClick="btnNewOpening_Click" />
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
                <asp:GridView ID="grvListUser" class="table table-striped" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Username" HeaderText="Username" />
                        <asp:BoundField DataField="Email" HeaderText="Email" />
                        <asp:BoundField DataField="APoint" HeaderText="Point" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
                        <asp:BoundField DataField="Type" HeaderText="Type" />
                        <asp:TemplateField HeaderText="Action">
                            <ItemTemplate>
                                <asp:HyperLink ID="hlReset" runat="server" NavigateUrl='<%# Eval("Username") %>' Text="Reset"></asp:HyperLink>
                                <asp:HyperLink ID="hlBan" runat="server" NavigateUrl='<%# Eval("Username") %>' Text="Ban"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel-heading text-center">LIST TITLE</div>
                    <div class="panel-body">
                        <asp:GridView ID="grvListTitle" class="table table-striped" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="TitleID" HeaderText="TitleID"/>
                                <asp:BoundField DataField="TitleName" HeaderText="Title Name" />
                                <asp:BoundField DataField="Point" HeaderText="Point" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlDeleteTitle" runat="server" NavigateUrl='<%# Eval("TitleID") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-6">
            <div class="panel-group">
                <div class="panel panel-primary">
                    <div class="panel-heading text-center">LIST OPENING</div>
                    <div class="panel-body">
                        <asp:GridView ID="grvListOpen" class="table table-striped" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="OpenID" HeaderText="OpenID"/>
                                <asp:BoundField DataField="OpenName" HeaderText="Open Name" />
                                <asp:TemplateField HeaderText="Action">
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlDeleteOpen" runat="server" NavigateUrl='<%# Eval("OpenID") %>' Text="Delete"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
