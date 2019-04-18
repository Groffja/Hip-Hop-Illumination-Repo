<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Hip Hop IllumiNation.com </title>
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

    <style>
        .far fa-kristina {
            color: white;
        }

        a:-webkit-any-link {

    
    cursor: pointer;
    text-decoration: none;
}
        h6{

            color:gold

        } 
        

    </style>


</head>

<body id="page-top">
    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark fixed-top" id="mainNav">
        <div class="container">
            <a class="navbar-brand js-scroll-trigger" href="#page-top">Hip Hop IllumiNation</a>
            <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                Menu
                <i class="fas fa-bars"></i>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive" runat="server">
                <ul class="navbar-nav text-uppercase ml-auto">

                    <li class="nav-item dropdown">
                        <a class="nav-link js-scroll-trigger dropdown-toggle" id="navbardrop" data-toggle="dropdown">Lessons</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="6Cs.aspx">The Six C's</a>
                            <a class="dropdown-item" href="CriticalConciousness.aspx">Critical Conciousness</a>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#team">Our Focus</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link js-scroll-trigger dropdown-toggle" id="navbardrop" data-toggle="dropdown">About Us</a>
                        <div class="dropdown-menu">
                            <a class="dropdown-item" href="Founder.aspx">Founder</a>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#contact">Contact</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="UserQuestions.aspx">Create Account</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="Login.aspx">Login</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" id="log" runat="server" href="ProfilePage.aspx">Profile</a>
                    </li>

                </ul>
            </div>
        </div>
    </nav>
    <!-- Header -->
    <header class="masthead">
        <div class="container">
            <div class="intro-text">
                <div class="intro-lead-in">Welcome To Hip Hop IllumiNation!</div>
                <div class="intro-heading text-uppercase">Let the Music Speak</div>
                <a class="btn btn-primary btn-xl text-uppercase js-scroll-trigger" href="#Lessons">Tell Me More</a>
            </div>
        </div>
    </header>



    <!--Lessons -->

    <section id="Lessons">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <center>
        <h2 class="section-heading text-uppercase">Lesson Overview</h2>
<%--        <br /> --%>
            <h3 class="section-subheading text-muted" style="font-style:normal; text-align:left; width:900px; line-height: 1.75">
            Hip Hop IllumiNation provides a library of lessons that use themes from hip hop
                music to promote positive youth development. These lessons are designed to prompt 
                reflection, critical discussion, and action on the topics presented (see below). 
                Topics have been drawn from research on youth development which suggests that 
                each topic is an important area for growth as young people mature. They are also 
                topics that consistently arise in hip hop music. Hip Hop IllumiNation identifies 
                music that aligns with each topic and creates lessons that help youth connect 
                their own development with culturally relevant themes. We regularly create new 
                lessons and add to the library, so you have a variety of options for engaging the young people you care about.    
                </h3>        

</center>
                    <center>
        <h2 class="section-heading text-uppercase">Lesson Topics</h2>
            <h3 class="section-subheading text-muted" style="font-style:normal; text-align:left ; width:900px; line-height: 1.75">
            Our lessons cover a wide range of topics, all essential to positive youth development. They can be grouped broadly into 
                two categories: Critical Consciousness and The Six Cs. Each of these categories is further divided into topics and 
                sub-topics that cover essential domains of youth development (see below). You and the youth you work with will know 
                best which topics they are most interested in or in need of pursuing. Categories and Tags make it easy to search and 
                find appropriate lessons based on topic, sub-topic, artist, and even song title.
           <br />
            <br />
            <img src="img/Photos-20190411T182208Z-001/Photos/CriticalConTable.png" style="width:500px; display:block; margin:auto"/>
                <p class="section-subheading text-muted" style="font-style:normal; text-align:center">Critical Consciousness Topics and Sub Topics</p>
                </h3>
           
 </center>
                    <center>
        <h2 class="section-heading text-uppercase">Structure of Lessons</h2>
            <h3 class="section-subheading text-muted" style="font-style:normal; text-align:left ; width:900px; line-height: 1.75">
            Our lessons are structured to facilitate teaching and learning. With that in mind, each lesson has a section summarizing the topic(s) and sub-topic(s) covered and how they are important for youth development. The summary is followed by learning objectives, outlining what youth and adults should gain from the lesson. Objectives are followed by the lesson content, which includes lyrics/themes from featured artist(s)/song(s), guidance for the adult leading the lesson, and specific prompts for Reflection, Discussion, and Action. At the end of each lesson, we also try to provide links to additional lessons or other resources that might extend learning.
                <br />
                <br />
                <img src="img/Photos-20190411T182208Z-001/Photos/SixCsTable.png" style="width:800px; display:block; margin:auto"/>
                <p class="section-subheading text-muted" style="font-style:normal; text-align:center">The Six Cs Topics and Sub Topics</p>
                </h3>
                
            </center>

                </div>
            </div>
        </div>
    </section>

    <!-- Team -->
    <section class="bg-light" id="team">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">Our Focus</h2>
                    <h3 class="section-subheading text-muted"></h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/Youth.png" alt="">

                        <h4>Youth</h4>
                        <%--<p class="text-muted">18 and Under</p>--%>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/white-treble.jpg" alt="">

                        <h4>Youth Worker</h4>
                        <%--<p class="text-muted">need to figure this out </p>--%>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/parent.jpg" alt="">
                        <h4>Parent</h4>
                        <%-- <p class="text-muted">Can Recommend Lessons to Youth</p>--%>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/gray_chalk_apple.png" alt="">

                        <h4>Teacher</h4>
                        <%--<p class="text-muted">Brief overview of teacher</p>--%>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/mentor.jpg" alt="">

                        <h4>Mentor</h4>
                        <%--<p class="text-muted">add something about mentor </p>--%>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="img/team/NewOther.jpg" alt="" />

                        <h4>Other Adult</h4>
                        <%--<p class="text-muted">Other adults intrested in fostering the youth</p>--%>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-8 mx-auto text-center">
                    <p class="large text-muted">JMU CIS 484 Hip Hop IllumiNation Project</p>
                </div>
            </div>
        </div>
    </section>
    <!-- Services -->
    <section id="services">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">About Us</h2>
                    <center>
                    <h3 class="section-subheading text-muted" style="font-style:normal; text-align:left; width: 900px; line-height: 1.75">
                        Hip Hop IllumiNation was born out of a love for hip hop music, a commitment to positive youth development,
                        and a burning desire to combine the two productively.
                        We deeply believe that hip hop music provides poignant insight into the lived experiences of the marginalized and dispossessed,
                        serving as a prism through which young people, particularly young men of color, might view the world around them.
                        It also serves as a mirror into which they can gaze and reflect upon their own selves: good, bad, and ugly.
                        We hope that Hip Hop IllumiNation prompts you to stand over the shoulders of those young men as they explore the art.
                        We hope that you elicit, encourage, and sometimes challenge their insights and reflections,
                        pushing them to realize and express their best selves while resisting and disrupting the structures that stand in their way.
                        <br />
                        <br />
                        We believe that marginalized youth need to first be aware of and reflect upon the sociopolitical circumstances that may present barriers on their pathways to adulthood.
                        Then, they must build and bolster developmental assets, so they can finally take effective action to navigate and/or dismantle these barriers.
                    </h3>
                        </center>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-6">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-globe-americas fa-stack-1x fa-inverse"></i>
                        <%--<i class="fab fa-angellist fa-stack-1x fa-inverse"></i>--%>
                        <%--<i class="fas fa-shopping-cart fa-stack-1x fa-inverse"></i>--%>
                        
                    </span>
                    <h4 class="service-heading">Mission</h4>
                    <center>
                    <p class="text-muted" style="text-align:left; width: 400px">Our mission is to increase critical consciousness and developmental assets among young men of color (ages 14-24) through guided exploration of hip hop music.</p>
               </center>
                </div>
                <div class="col-md-6">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-laptop fa-stack-1x fa-inverse"></i>
                    </span>
                    <h4 class="service-heading">Vision</h4>
                    <center>
                    <p class="text-muted" style="text-align:left; width: 400px">Our vision is that young men of color, particularly those living in marginalized communities, will recognize their strengths and exercise their power to positively influence the world around them.</p>
                </center>
                </div>

            </div>
        </div>
    </section>
    <!-- Contact -->
    <section id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">Want to Contact Us?</h2>
                    <h2 class="section-subheading" style="color:gold">Create an account and send us a message!</h2>
                    <h3 class="section-subheading text-muted">Your feedback is important to us!</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
            
                </div>
            </div>
        </div>
    </section>
    <!-- Footer -->
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <span class="copyright">Copyright &copy; Hip Hop IllumiNation</span>
                </div>
                <div class="col-md-4">
                    <ul class="list-inline social-buttons">
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-twitter"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-facebook-f"></i>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                        </li>
                    </ul>
                </div>
                <div class="col-md-4">
                    <ul class="list-inline quicklinks">
                        <li class="list-inline-item">
                            <a href="#">Privacy Policy</a>
                        </li>
                        <li class="list-inline-item">
                            <a href="#">Terms of Use</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Plugin JavaScript -->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>
    <!-- Contact form JavaScript -->
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/contact_me.js"></script>
    <!-- Custom scripts for this template -->
    <script src="js/agency.min.js"></script>
</body>

</html>
