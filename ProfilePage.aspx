<%@ Page Title="" Language="C#" MasterPageFile="MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="ProfilePage.aspx.cs" Inherits="ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        section{
            margin: 0;
    background: url(img/header-bg.jpg);
    background-size: 1440px 800px;    
    height: 100vh;
        }
    </style>
       <section>
            <div class="container">
                <div class="row">
                    <div class="col-sm-4">
                    </div>
                    <div class="col-sm-4">
                        <div class="team-member" >
                            <img class="mx-auto rounded-circle" src="img/admin_login.svg" alt="">
                            <h4 style="color:#fff; height: 19px;" id="username" runat="server"> Username</h4>
                            <p style="color:#fff" id="welcome" runat="server"></p>
                            <p style="color:#fff" id="lessons" runat="server">
                                Number of Lessons Completed</p>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-8 mx-auto text-center align" aria-hidden="False">
                        <strong id="project" style="color:#fff" >JMU CIS 484 Hip Hop IllumiNation Project</strong>
                    </div>
                </div>
            </div>
        </section>
</asp:Content>
