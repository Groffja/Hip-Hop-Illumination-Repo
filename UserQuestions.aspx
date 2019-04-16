<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserQuestions.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="css/YouthCreate.css" crossorigin="anonymous">

    <title>Hip Hop IllumiNation.com</title>
    <style>
        .drop{border:ridge;}

register {
    margin-right:0px;
    }
.register-left{
    text-align: center;
    color: #fff;
    margin-top: 4%;
}

.register-right{
    background: #f8f9fa;
    border-top-left-radius: 10% 50%;
    border-bottom-left-radius: 10% 50%;
    padding-right:155px;
    padding-bottom:50px;
    top:0;
    bottom:0;
    height: 100%;

}
.register-left img{
    margin-top: 15%;
    margin-bottom: 5%;
    width: 50%;
    -webkit-animation: mover 2s infinite  alternate;
    animation: mover 1s infinite  alternate;
}
@-webkit-keyframes mover {
    0% { transform: translateY(0); }
    100% { transform: translateY(-20px); }
}
@keyframes mover {
    0% { transform: translateY(0); }
    100% { transform: translateY(-20px); }
}

.register .register-form{
    padding: 8%;
    margin-top: 80px;
    margin-left: 10%;
}
.btnRegister{
    float: right;
    margin-top: 8%;
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    background: #fed136;
    color: white;
    font-weight: 600;
    width: 50%;
    cursor: pointer;
}

.register-heading{
    text-align: center;
    margin-top: 40px;
    margin-bottom: -15%;
    color: #495057;
}

.label {
  vertical-align: super;
  padding-top: 5px;
  font-size: 20px;
}

body{
    background-image:url(img/lombardo_cover.jpeg);
    float:right;
    background-repeat:no-repeat;
    background-size: auto;
    margin: 0px 0px 0px 0px;
} 
 
        </style>
</head>

<body>
    <form id="form1" class="form-group" runat="server">
        <div class="container register">
            <div class="row"> 
                <div class="col-md-3 register-left">
                        <img src="img/microphone-pngrepo-com.png" alt=""/>
                        <h3>Welcome</h3>
                        <p>to Hip Hop IllumiNation!</p>
                </div>  <!-- left aside-->

            <div class="col-md-9 register-right">  
                        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />


                 <h3 class="register-heading">Create New Account</h3>
                <div class="row register-form">
                    <div class="form-group">


 <div class="form-group input-group input-group-md label">
           <h4>Are you 18+ years old?</h4>
                      <br />
     </div>
                        <div class="form-check form-group rightStyle">
            <input runat="server" Class="form-check-input" type="radio" id="adultYes" name="adult" value="yes" required>
            <asp:Label ID="Label1" class="form-check-label" runat="server" Text="Yes" Width="130px" for="adultYes" ></asp:Label>
                            <br />
            <input runat="server" Class="form-check-input" type="radio" id="adultNo" name="adult" value="no" required>
            <asp:Label ID="Label2" class="form-check-label" runat="server" Text="No" Width="130px" for="adultYes" ></asp:Label>
                          </div>
           



    <asp:Button ID="btnContinue" class="btnRegister" runat="server" OnClick="btnContinue_Click" Text="Continue" />
                                <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />


          
</div>

        </div> <!-- row register-form -->
                </div>  <!-- register-right -->
            </div>  <!-- row class-->
     </div>





    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

            </form>
    </body>
</html>