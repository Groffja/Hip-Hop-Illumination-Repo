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
    float:left;
    position:relative;
    right:0px;
    border: none;
    border-radius: 1.5rem;
    padding: 1%;
    background: #fed136;
    color: black;
    font-weight: 50px;
    width:65%;
    cursor: pointer;
    border:1px solid white;
    margin-top:10px;
    margin-bottom: 10px
}
h3{
      color: white;
  }

th, td {
  text-align: left;
  padding: 16px;
}


/*.divWidth{
    display:inline;
}*/

#container1{
    float:left;
    position:relative;
    right:0px;
    margin-left:0;
    width: 15%;
    padding: 2%
    
    
}

#container2{
    float:left;
    position:relative;
    right:100px;
    width: 85%
}



    </style>
    <form runat="server">

            <div class="row">
                <div id="container1">
<%--                <div class="span6" >--%>
                    

               
        
<div class="row">
        <asp:Button class="btnRegister1" ID="Button1" runat="server" Text="Youth Users Map" OnClick="Button1_Click" />
</div>
<div class="row">
        <asp:Button class="btnRegister1" ID="Button2" runat="server" Text="Adult Users Map" OnClick="Button2_Click" />
</div>
<div class="row">
        <asp:Button class="btnRegister1" ID="Button3" runat="server" Text="Favorite Artisit" OnClick="Button3_Click" />
</div>
<div class="row">
        <asp:Button class="btnRegister1" ID="Button4" runat="server" Text="Favorite Music" OnClick="Button4_Click" />
</div>
<div class="row">
        <asp:Button class="btnRegister1" ID="Button5" runat="server" Text="Gender Ratio" OnClick="Button5_Click" />
</div>
<div class="row">
        <asp:Button class="btnRegister1" ID="Button6" runat="server" Text="Age Breakdown" OnClick="Button6_Click" />
</div>

<%--</div>--%>


</div>

<div id="container2">

<%--<div class="span6">--%>
    <div id="youthMap" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 848px;'><object class='tableauViz' width='1920' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;AdultUsers' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
    <div id="adultMap" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1797px; height: 848px;'><object class='tableauViz' width='1797' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;YouthUsers_1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
    <div id="favoriteArtist" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 848px;'><object class='tableauViz' width='1920' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Artist_1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
    <div id="favoriteGenre" runat="server">
        <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 848px;'><object class='tableauViz' width='1920' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Genre_1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>
     <div id="gender" runat="server">
       <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 848px;'><object class='tableauViz' width='1920' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Gender_1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
     </div>
    <div id="populationPyramid" runat="server">
       <script type='text/javascript' src='https://us-east-1.online.tableau.com/javascripts/api/viz_v1.js'></script><div class='tableauPlaceholder' style='width: 1920px; height: 848px;'><object class='tableauViz' width='1920' height='848' style='display:none;'><param name='host_url' value='https%3A%2F%2Fus-east-1.online.tableau.com%2F' /> <param name='embed_code_version' value='3' /> <param name='site_root' value='&#47;t&#47;hiphopilluminationmap' /><param name='name' value='YouthUsersMap&#47;Population_1' /><param name='tabs' value='no' /><param name='toolbar' value='yes' /><param name='showAppBanner' value='false' /><param name='filter' value='iframeSizedToWindow=true' /></object></div>
    </div>

<%--</div>--%>
</div>

</div>

 </form>
</asp:Content>

