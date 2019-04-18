<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<head>
    <title>Login</title>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom fonts for this template -->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>
    <!-- Custom styles for this template -->
    <link href="css/agency.min.css" rel="stylesheet">

<!------ Include the above in your HEAD tag ---------->
    <style>

html,body {
  background-color: grey;
}

body {
  font-family: "Poppins", sans-serif;
  height: 100vh;
}

a {
  color: #000066/*#ffc40c*/;
  display:inline-block;
  text-decoration-style: wavy;
  font-weight: 400;
            height: 18px;
        }

h2 {
  text-align: center;
  font-size: 16px;
  font-weight: 600;
  text-transform: uppercase;
  display:inline-block;
  margin: 40px 8px 10px 8px; 
  color: #cccccc;
}



/* STRUCTURE */

.wrapper {
  display: flex;
  align-items: center;
  flex-direction: column; 
  justify-content: center;
  width: 100%;
  min-height: 100%;
  padding: 20px;
}

#formContent {
  -webkit-border-radius: 10px 10px 10px 10px;
  border-radius: 10px 10px 10px 10px;
  background: #fff;
  padding: 30px;
  width: 90%;
  max-width: 450px;
  position: relative;
  padding: 0px;
  -webkit-box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
  box-shadow: 0 30px 60px 0 rgba(0,0,0,0.3);
  text-align: center;
}

#formFooter {
  background-color: #ffc40c; /*this is the yellow color to use throughout*/
  border-top: 1px solid #dce8f1;
  padding: 25px;
  text-align: center;
  -webkit-border-radius: 0 0 10px 10px;
  border-radius: 0 0 10px 10px;
}



/* TABS */

h2.inactive {
  color: #cccccc;
}

h2.active {
  color: #0d0d0d;
  border-bottom: 2px solid #5fbae9;
}



/* FORM TYPOGRAPHY*/

input[type=button], input[type=submit]  {
  background-color: #ffc40c/*#56baed*/;
  border: none;
  color: white;
  padding: 15px 80px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  text-transform: uppercase;
  font-size: 13px;
  -webkit-box-shadow: 0 10px 30px 0 rgba(95,186,233,0.4);
  box-shadow: 0 10px 30px 0 rgba(95,186,233,0.4);
  -webkit-border-radius: 5px 5px 5px 5px;
  border-radius: 5px 5px 5px 5px;
  margin: 5px 20px 40px 20px;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
}


input[type=button]:hover, input[type=submit]:hover, input[type=reset]:hover  {
  background-color:#ffc40c /*#39ace7*/;
}

input[type=button]:active, input[type=submit]:active  {
  -moz-transform: scale(0.95);
  -webkit-transform: scale(0.95);
  -o-transform: scale(0.95);
  -ms-transform: scale(0.95);
  transform: scale(0.95);
}

input[type=text] {
  background-color: #f6f6f6;
  border: none;
  color: #0d0d0d;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 5px;
  width: 85%;
  border: 2px solid #f6f6f6;
  -webkit-transition: all 0.5s ease-in-out;
  -moz-transition: all 0.5s ease-in-out;
  -ms-transition: all 0.5s ease-in-out;
  -o-transition: all 0.5s ease-in-out;
  transition: all 0.5s ease-in-out;
  -webkit-border-radius: 5px 5px 5px 5px;
  border-radius: 5px 5px 5px 5px;
}

input[type=text]:focus {
  background-color: #fff;
  border-bottom: 2px solid #5fbae9;
}

input[type=text]:placeholder {
  color: #cccccc;
}



/* ANIMATIONS */

/* Simple CSS3 Fade-in-down Animation */

.fadeInDown {
  -webkit-animation-name: fadeInDown;
  animation-name: fadeInDown;
  -webkit-animation-duration: 1s;
  animation-duration: 1s;
  -webkit-animation-fill-mode: both;
  animation-fill-mode: both;
}

@-webkit-keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  100% {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}

@keyframes fadeInDown {
  0% {
    opacity: 0;
    -webkit-transform: translate3d(0, -100%, 0);
    transform: translate3d(0, -100%, 0);
  }
  100% {
    opacity: 1;
    -webkit-transform: none;
    transform: none;
  }
}
    
/* Simple CSS3 Fade-in Animation */

@-webkit-keyframes fadeIn { from { opacity:0; } to { opacity:1; } }
@-moz-keyframes fadeIn { from { opacity:0; } to { opacity:1; } }
@keyframes fadeIn { from { opacity:0; } to { opacity:1; } }

.fadeIn {
  opacity:0;
  -webkit-animation:fadeIn ease-in 1;
  -moz-animation:fadeIn ease-in 1;
  animation:fadeIn ease-in 1;

  -webkit-animation-fill-mode:forwards;
  -moz-animation-fill-mode:forwards;
  animation-fill-mode:forwards;

  -webkit-animation-duration:1s;
  -moz-animation-duration:1s;
  animation-duration:1s;
}

.fadeIn.first {
  -webkit-animation-delay: 0.4s;
  -moz-animation-delay: 0.4s;
  animation-delay: 0.4s;
  align-content:center;
}

.fadeIn.second {
  -webkit-animation-delay: 0.6s;
  -moz-animation-delay: 0.6s;
  animation-delay: 0.6s;
}

.fadeIn.third {
  -webkit-animation-delay: 0.8s;
  -moz-animation-delay: 0.8s;
  animation-delay: 0.8s;
}

.fadeIn.fourth {
  -webkit-animation-delay: 1s;
  -moz-animation-delay: 1s;
  animation-delay: 1s;
}
    
/* Simple CSS3 Fade-in Animation */
.underlineHover:after {
  display: block;
  left: 0;
  bottom: -10px;
  width: 0;
  height: 2px;
  background-color: #FFC40C;
  content: "";
  transition: width 0.2s;
}

.underlineHover:hover {
  color: white;
}

.underlineHover:hover:after{
  width: 100%;
}

.form-control:focus {
  border-color: #FFC40C;
  -webkit-box-shadow: none;
  box-shadow: none;
}



/* OTHERS */

.textarea:focus {
    outline: none;
} 

#icon {
  width:70%;
  height:70%;
  align-content:center;
}
.type{
    color:black;
    border:groove;
    border-radius: 10px 10px 10px 10px;
}

body {
    margin: 0;
    background: url(img/about/Login.jpg);
    background-size: 100%;            
    font: 13px/18px "Helvetica Neue", Helvetica, Arial, sans-serif;
}
</style>

    </head>



 <body id="page-top">
    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand js-scroll-trigger" href="index.aspx">Hip Hop IllumiNation</a>
            
        </div>
    </nav>


<div class="wrapper fadeInDown">
  <div id="formContent">
    <!-- Tabs Titles -->

    <!-- Icon -->
    <div class="fadeIn first">
        <br />
        
      <%--<img id="icon" src="img/admin_login.svg"/>--%>
        <img src="img/microphone.jpg" width="300px" height="300px"/>
    </div>
        
    <!-- Login Form -->
      <form id="loginForm" class="form-horizontal" runat="server">
          <div class="container">

<%--              <div class="form-group">
                 <asp:LinkButton ID="lnkCreate" runat="server" href="UserQuestions.aspx">Create Account</asp:LinkButton>
              </div>--%>
              <br />
              <br />
              <center>
             <div class="form-group col-8 underlineHover">
                  <asp:TextBox  class="form-control" ID="txtUsername" runat="server" placeholder="Email" required="required" TextMode="Email"></asp:TextBox>
             </div>
             
              <div class="form-group col-8 underlineHover">
                  <asp:TextBox class="form-control" ID="txtPassword" runat="server" placeholder="Password" required="required" TextMode="Password"></asp:TextBox>
              </div>

              <div class="form-group col-sm-6 text-center ">
            <asp:Button class="form-control" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" BackColor="#FFC40C" ForeColor="Black" Height="50px" Width="200px"/>
              </div>
                  
              <div class="form-group">
            <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>

              </div>   
                  </center>
          </div>
      
      </form>

    <!-- Remind Passowrd -->
    <div id="formFooter">
      <a class="underlineHover" href="UserQuestions.aspx">Create Account</a>
        <br />
      <a class="underlineHover" href="ForgotPassword.aspx">Forgot Password</a>
    </div>

  </div>
</div>
     </body>
&nbsp;
