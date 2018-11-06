<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KifuManager.ThaPoTuMi.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-push-4" style="margin-top:50px">
                <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">Login</div>
            <div class="panel-body" style="padding:10%">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="txtUserName1" class="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName1" ErrorMessage="Username is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="txtPassword1" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword1" ErrorMessage="Password is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="btnLogin" runat="server" style="width:50%; font-size:20px; margin-left:25%;" class="btn btn-primary" Text="Login" OnClick="btnLogin_Click" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </div>
        </div>
    </div>
            </div>
        </div>
    </div>
</asp:Content>
