<%@ Page Title="" Language="C#" MasterPageFile="MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="ProfilePage.aspx.cs" Inherits="ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        section{
            margin: 0;
    background: url(img/team/amps.jpg);

    width:1900px;
    background-size: 100%;    
    height: 1280px;
        }
    </style>
       <section>
           <br />
           <br />
           <br />
            <div class="container">
                <div class="row">
                    <div class="col-sm-4">
                    </div>
                    <div class="col-xl-5" style="background-color:white;border:15px groove;border-color:gold;">
                        <div class="team-member" >
                            <img class="mx-auto rounded-circle" src="img/about/LandingPageAdmin.jpg" alt="">
                         
                            <h4 style="color:black; height: 19px;" id="username" runat="server"> Username</h4>
                            <p style="color:black" id="welcome" runat="server"></p>
                            <p style="color:black" id="lessons" runat="server">
                                Number of Lessons Completed</p>

                
                        </div>
                    </div>
                </div>
                
            </div>
        </section>
</asp:Content>
