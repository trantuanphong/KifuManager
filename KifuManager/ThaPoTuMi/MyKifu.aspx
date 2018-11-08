<%@ Page Title="" Language="C#" MasterPageFile="~/TwoRowSite.master" AutoEventWireup="true" CodeBehind="MyKifu.aspx.cs" Inherits="KifuManager.MyKifu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="server">
    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">New Kifu</div>
            <div class="panel-body">
                <asp:FileUpload ID="KifuUpload" runat="server" /><br />
                <div class="text-center">
                    <asp:Button ID="btnUpload" class="btn btn-primary" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
    <div class="panel-group">
        <div class="form-inline">
            <asp:Button ID="btnListMyKifu" class="btn btn-primary" runat="server" Text="My Kifu" OnClick="btnListMyKifu_Click" />
            <asp:Button ID="btnListFavorKifu" class="btn btn-primary" runat="server" Text="Favourite Kifu" OnClick="btnListFavorKifu_Click" />
        </div>
    </div>

    <div class="panel-group">
        <div class="panel panel-primary">
            <div class="panel-heading">List My Kifu</div>
            <div class="panel-body">
                <asp:GridView class="table table-striped" ID="grvList" runat="server" AllowPaging="True" BorderStyle="None" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="KifuID" HeaderText="KifuID" Visible="False" />
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" />
                        <asp:BoundField DataField="Event" HeaderText="Event" />
                        <asp:TemplateField HeaderText="White Player">
                            <ItemTemplate>
                                <%#Eval("WhitePlayer") %> (<%#Eval("WhiteLevel") %>)
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Black Player">
                            <ItemTemplate>
                                <%#Eval("BlackPlayer") %> (<%#Eval("BlackLevel") %>)
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Result" DataFormatString="{0}" HeaderText="Result" />
                        <asp:BoundField DataField="Date" DataFormatString="{0:d}" HeaderText="Date" />
                        <asp:HyperLinkField DataNavigateUrlFields="KifuID" DataNavigateUrlFormatString="ViewKifu.aspx?KifuID={0}" HeaderText="Action" Text="View" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
