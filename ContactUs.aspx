<%@ Page Title="" Language="C#" MasterPageFile="MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom fonts for this template -->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>
    <!-- Custom styles for this template -->
    <link href="css/agency.css" rel="stylesheet">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript">
        $(document).ready(function(){
        $('#<%=dvMsg.ClientID%>').fadeOut(5000,function(){
        $(this).html(""); //reset label after fadeout
        });
       });   
    </script>
    <style>
    
    </style>
    <title> Hip Hop IllumiNation.com</title>
    <section id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">Contact Us</h2>
                    <h3 class="section-subheading text-muted">Your feedback is important to us!</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                    <form id="contactForm" name="sentMessage" novalidate="novalidate">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <input class="form-control" id="name" type="text" placeholder="Your Name *" runat="server" required="required" data-validation-required-message="Please enter your name.">
                                    <p class="help-block text-danger"></p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="email" type="text" placeholder="Your Email *" runat="server" required="required" data-validation-required-message="Please enter your email address.">
                                    <p class="help-block text-danger">
                                 
                                    </p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="phone" type="text" placeholder="Topic *" runat="server" required="required" data-validation-required-message="Please enter a topic.">
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="col-md-6">
                                
                                    
                                    
                                <div class="form-group">    
                                <textarea class="form-control" id="messageTextArea" name="messageTextArea" placeholder="Your Message *" runat="server"  required="required" data-validation-required-message="Please enter a message."></textarea>
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="col-lg-12 text-center">
                                <div id="success"></div>
                                <asp:Button id="sendMessageButton" class="btn btn-primary btn-xl text-uppercase" runat="server" OnClick="MessageButton_Click" text="Send Message"/>
                            <br />
                                    <br />
                                <div id="dvMsg" class="notification" runat="server" visible="false">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            </div>
   
                                <asp:Button ID="btnShowMsg" runat="server" Text="Show" onclick="btnShowMsg_Click" visible="false"/>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>
</asp:Content>


