<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="KifuManager.ThaPoTuMi.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-push-4" style="margin-top: 50px">
                <div class="panel-group">
                    <div class="panel panel-primary">
                        <div class="panel-heading text-center">REGISTER</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="txtUsername">Username:</label>
                                <asp:TextBox ID="txtUsername" class="form-control" required="true" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword">Password:</label>
                                <asp:TextBox ID="txtPassword" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtRetypePassword">Retype password:</label>
                                <asp:TextBox ID="txtRetypePassword" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtEmail">Email:</label>
                                <asp:TextBox ID="txtEmail" type="email" class="form-control" required="true" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                                <asp:Button ID="btnRegister" class="btn btn-success" runat="server" Text="Sign up" OnClick="btnRegister_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
