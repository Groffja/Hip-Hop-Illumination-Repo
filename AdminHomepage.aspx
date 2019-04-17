<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdminHomepage.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <title>Hip Hop IllumiNation.com</title>
    <style>
        body{
    background-image:url(img/about/bright-clear-close-up-401107.jpg);
    margin:auto;
    max-height:50%;
    max-width:100%;
    background-position: top;
    background-repeat: no-repeat;
    background-size: cover;
    display:block;
    
}
        .container {
  position: center;
  max-width: 400px;
  padding: 300px;
  background-color: white;
}
        /*.font {
            
        }*/
    </style>
    <body>
        <%--<img src="img/about/bright-clear-close-up-401107.jpg" style="width:100%; display:block; margin:auto; height:100%; background-size:cover"/>--%>
       <form action="/action_page.php" class="container">
          <center>
           <h2>Welcome Nicholas Carrington</h2>

              </center>
    
  </form> 
    </body>
</asp:Content>


