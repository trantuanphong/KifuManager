<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="KifuManager.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>ABOUT US</h1>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <div class="row">
        <div class="col-md-3">
            <div class="thumbnail">
                <img src="../image/thanh.jpg" alt="Tha">
                <div class="caption">
                    <h3>Nguyen Tien Thanh</h3>
                    <p>Database Designer</p>
                </div>
            </div>
        </div>        
        <div class="col-md-3">
            <div class="thumbnail">
                <img src="../image/phong.jpg" alt="Po">
                <div class="caption">
                    <h3>Tran Tuan Phong</h3>
                    <p>Architecture Designer</p>
                </div>
            </div>
        </div>        
        <div class="col-md-3">
            <div class="thumbnail">
                <img src="../image/tuan.jpg" alt="Tu">
                <div class="caption">
                    <h3>Bui Quoc Tuan</h3>
                    <p>Prototype Designer</p>
                </div>
            </div>
        </div>        
        <div class="col-md-3">
            <div class="thumbnail">
                <img src="../image/minh.jpg" alt="Mi">
                <div class="caption">
                    <h3>Vu Quang Minh</h3>
                    <p>Algorithm Designer</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
