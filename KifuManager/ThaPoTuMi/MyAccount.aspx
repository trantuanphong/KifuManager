<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="KifuManager.ThaPoTuMi.MyAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <div class="row">
              
            <div class="col-md-3 col-md-push-3">
                <div class="panel-group">
                    <div class="panel panel-primary">
                        <div class="panel-heading text-center">CHANGE EMAIL</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="txtEmail">Email:</label>
                                <asp:TextBox ID="txtEmail" TextMode="Email" class="form-control" required="true" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                                <asp:Button ID="btnChangeEmail" class="btn btn-primary" runat="server" Text="Change Email" />
                            </div>
                        </div>
                    </div>
                </div>                
                <div class="panel-group">
                    <div class="panel panel-primary">
                        <div class="panel-heading text-center">CHANGE TITLE</div>
                        <div class="panel-body">
                            <label><asp:Label ID="lbPoint" runat="server" Text="Label"></asp:Label></label>
                            <div class="form-group">
                                <label for="txtEmail">Title:</label>
                                <asp:DropDownList ID="drTitle" class="form-control" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-inline text-center">
                                <asp:Button ID="btnChangeTitle" class="btn btn-primary" runat="server" Text="Change Title" OnClick="btnChangeTitle_Click" />
                                <asp:Button ID="btnRemoveTitle" class="btn btn-primary" runat="server" Text="Remove Title" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-3 col-md-push-3">
                <div class="panel-group">
                    <div class="panel panel-primary">
                        <div class="panel-heading text-center">CHANGE PASSWORD</div>
                        <div class="panel-body">
                            <div class="form-group">
                                <label for="txtOldPassword">Old Password:</label>
                                <asp:TextBox ID="txtOldPassword" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                            </div>                            
                            <div class="form-group">
                                <label for="txtNewPassword">New Password:</label>
                                <asp:TextBox ID="txtNewPassword" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtRetypePassword">Retype Password:</label>
                                <asp:TextBox ID="txtRetypePassword" class="form-control" required="true" type="password" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group text-center">
                                <asp:Button ID="btnChangePassword" class="btn btn-primary" runat="server" Text="Change Password" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>    
            
        </div>
    </div>
</asp:Content>
