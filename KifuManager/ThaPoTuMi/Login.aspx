<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KifuManager.ThaPoTuMi.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-push-4" style="margin-top: 50px">
                <div class="panel-group">
                    <div class="panel panel-primary">
                        <div class="panel-heading text-center"><h2>LOGIN</h2></div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="txtUsername1">Username:</label>
                                <asp:TextBox ID="txtUserName1" class="form-control" required="true" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName1" ErrorMessage="Username is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="form-group">
                                <label for="txtPassword1">Password:</label>
                                <asp:TextBox ID="txtPassword1" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword1" ErrorMessage="Password is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </div>
                            <div class="text-center">
                                <asp:Button ID="btnLogin" class="btn btn-success" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            </div>
                            <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
