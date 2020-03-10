<%@ Page Title="" Language="C#" MasterPageFile="~/web/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="MobilwebSite.Web.attendance" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="background-color:#eee;padding-top:4px; padding-bottom:4px">
        <div class="row rowmargin" >
            <div class="col-xs-3">Data</div>
            <div class="col-xs-9" ><asp:TextBox ID="tb_data" runat="server" Width="200px"></asp:TextBox></div>
        </div>
        <div class="row rowmargin">
            <div class="col-xs-3">Time</div>
            <div class="col-xs-9"><asp:TextBox ID="tb_time" runat="server" Width="200px"></asp:TextBox></div>
        </div>
        <br />
       <div class="row rowmargin">
            <div class="col-xs-3">Staff Number</div>
            <div class="col-xs-9"><asp:TextBox ID="tb_staffnumber" runat="server" Width="200px"></asp:TextBox></div>
        </div>
        <br />
        <div class="row rowmargin" >
            <div class="col-xs-3"></div>
            <div class="col-xs-9" style="padding-left:16px">
                <asp:Button ID="btn_in" runat="server" Text="In" CssClass="btn btn-primary btn-lg" Width="80px"/>&nbsp&nbsp&nbsp&nbsp
                <asp:Button ID="btn_out" runat="server" Text="Out" CssClass="btn btn-primary btn-lg" Width="80px"/> 
            </div>
        </div>
    </div>
</asp:Content>