<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdultTablau.aspx.cs" Inherits="AdultTablau" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body{
    background-image:url(img/header-bg.jpg);
}
                .btnRegister1
   {
    float: none;
    
    border: none;
    border-radius: 1.5rem;
    padding: 1%;
    background: #fed136;
    color: black;
    font-weight: 50;
    width: 15%;
    cursor: pointer;
    border:1px solid white;
}
h3{
      color: white;
  }

th, td {
  text-align: left;
  padding: 16px;
}
    </style>
    <form runat="server">
    <center>
    <h3>
        <asp:Button class="btnRegister1" ID="Button1" runat="server" Text="Youth Users Map" OnClick="Button1_Click" />
        <asp:Button class="btnRegister1" ID="Button2" runat="server" Text="Adult Users Map" OnClick="Button2_Click" />
        <asp:Button class="btnRegister1" ID="Button3" runat="server" Text="Favorite Artisit" OnClick="Button3_Click" />
        <asp:Button class="btnRegister1" ID="Button4" runat="server" Text="Favorite Music" OnClick="Button4_Click" />
        <asp:Button class="btnRegister1" ID="Button5" runat="server" Text="Gender Ratio" OnClick="Button5_Click" />
        </h3>
    </center>

    <div id="youthMap" runat="server">
   <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 849px;'><object class='tableauViz' width='1920' height='849' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Sheet2' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
    <div id="adultMap" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 849px;'><object class='tableauViz' width='1920' height='849' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Sheet1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
        </form>
    <div id="favoriteArtist" runat="server">
    <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 849px;'><object class='tableauViz' width='1920' height='849' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Sheet3' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
    <div id="favoriteGenre" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 849px;'><object class='tableauViz' width='1920' height='849' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Sheet4' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
     <div id="gender" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1000px; height: 827px;'><object class='tableauViz' width='1000' height='827' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Dashboard1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
     </div>
</asp:Content>

