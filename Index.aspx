<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title> Hip Hop IllumiNation.com </title>
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
        .far fa-kristina{
            color: white;
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
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#services">About Us</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#portfolio">The 6 Cs</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#team">Our Team</a>
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
                <div class="intro-lead-in">Welcome To Hip Hip IllumiNation!</div>
                <div class="intro-heading text-uppercase">Come Explore</div>
                <a class="btn btn-primary btn-xl text-uppercase js-scroll-trigger" href="#services">Tell Me More</a>
            </div>
        </div>
    </header>
    <!-- Services -->
    <section id="services">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">About Us</h2>
                    <h3 class="section-subheading text-muted">
                        Hip Hop IllumiNation was born out of a love for hip hop music, a commitment to positive youth development,
                        and a burning desire to combine the two productively.
                        We deeply believe that hip hop music provides poignant insight into the lived experiences of the marginalized and dispossessed,
                        serving as a prism through which young people, particularly young men of color, might view the world around them.
                        It also serves as a mirror into which they can gaze and reflect upon their own selves–good, bad, and ugly.
                        We hope that Hip Hop IllumiNation prompts you to stand over the shoulders of those young men as they explore the art.
                        We hope that you elicit, encourage, and sometimes challenge their insights and reflections,
                        pushing them to realize and express their best selves while resisting and disrupting the structures that stand in their way.
                        <br />
                        <br />
                        We believe that marginalized youth need to first be aware of and reflect upon the sociopolitical circumstances that may present barriers on their pathways to adulthood.
                        Then, they must build and bolster developmental assets, so they can finally take effective action to navigate and/or dismantle these barriers.
                    </h3>
                </div>
            </div>
            <div class="row text-center">
                <div class="col-md-4">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-globe-americas fa-stack-1x fa-inverse"></i>
                        <%--<i class="fab fa-angellist fa-stack-1x fa-inverse"></i>--%>
                        <%--<i class="fas fa-shopping-cart fa-stack-1x fa-inverse"></i>--%>
                        
                    </span>
                    <h4 class="service-heading">Mission</h4>
                    <p class="text-muted">Our mission is to increase critical consciousness and developmental assets among young men of color (ages 14-24) through guided exploration of hip hop music.</p>
                </div>
                <div class="col-md-4">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-laptop fa-stack-1x fa-inverse"></i>
                    </span>
                    <h4 class="service-heading">Vision</h4>
                    <p class="text-muted">Our vision is that young men of color, particularly those living in marginalized communities, will recognize their strengths and exercise their power to positively influence the world around them.</p>
                </div>
                <div class="col-md-4">
                    <span class="fa-stack fa-4x">
                        <i class="fas fa-circle fa-stack-2x text-primary"></i>
                        <i class="fas fa-bullseye fa-stack-1x fa-inverse"></i>
                        <%--<i class="fas fa-lock fa-stack-1x fa-inverse"></i>--%>
                    </span>
                    <h4 class="service-heading">Goal</h4>
                    <p class="text-muted">"Quote from Nick Carrington"</p>
                </div>
            </div>
        </div>
    </section>
    <!-- Portfolio Grid -->
    <section class="bg-light" id="portfolio">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">The Six C's</h2>
                    <h3 class="section-subheading text-muted">Harnessing the power of hip hop for positive youth development</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal1">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C8.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Caring</h4>
                        <%--<p class="text-muted">Illustration</p>--%>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal2">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C2.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Character</h4>
                        <%--<p class="text-muted">Graphic Design</p>--%>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal3">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C3.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Competence</h4>
                        <%--<p class="text-muted">Identity</p>--%>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal4">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C4.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Confidence</h4>
                       <%-- <p class="text-muted">Branding</p>--%>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal5">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C9.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Connection</h4>
                       <%-- <p class="text-muted">Website Design</p>--%>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6 portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal6">
                        <div class="portfolio-hover">
                            <div class="portfolio-hover-content">
                                <i class="fas fa-plus fa-3x"></i>
                            </div>
                        </div>
                        <img class="img-fluid" src="img/6C6.jpeg" alt="">
                    </a>
                    <div class="portfolio-caption">
                        <h4>Contribution</h4>
                        <%--<p class="text-muted">Photography</p>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!--Six Cs -->

    <section>
             <div class="container"> 
                 <div class="row">
        <div class="col-lg-12 text-center" >
        <h2 class="section-heading text-uppercase">Why Are the Six Cs Important for Young Men of Color?</h2>
        <br /> 
        <%--<p style= "width: 800px">--%>
            <h3 class="section-subheading text-muted">

            Young men of color disproportionately face negative perceptions about their attitudes, skills, and behaviors. 
            These perceptions are reflected not only in institutional policies/cultures (e.g., school discipline, police brutality) 
            but also in the beliefs and actions of their teachers, employers, and even peers. Too often, these perceptions are also 
            unintentionally manifest in the actions of youth-serving organizations designed to help young men of color. 
            The Six Cs provide a framework that focuses on building and reinforcing the inherent strengths that young men of color possess. 
            Rather than preventing “problem behavior,” the Six Cs model focuses attention on developing attitudes, skills, and behaviors that help youth thrive.
            <br />
            <br />
            To date, the Six Cs are the best indication of thriving within the field of youth development. 
            The domains are interrelated and reinforce one another. So, as youth strengthen various sub domains
            of each C, they are more likely to attain others as well. Further, experiencing success in each of the Cs 
            makes youth, particularly young men of color, more likely to achieve longer-term outcomes that position them 
            for success in adulthood. For example, young people who form positive relationships with neighbors 
            (Connection) are better able to develop empathy for those neighbors (Caring). 
            Empathy combined with a belief in one’s own ability to effect change (Confidence) and specific skills to act
            (Competence) lead to greater social and civic engagement down the road (Contribution). Similarly, long-term 
            educational success is a reflection of academic engagement (Connection), a positive view of one’s future (Confidence), 
            and the academic skills to succeed (Competence).
     <%--   </p>--%>
                </h3>
               
        <br />
        <br />
        <h2 class="section-heading text-uppercase">How Does Hip Hop IllumiNation Contribute to the Six Cs?</h2>
        <%--<p style="width: 800px">--%>
            <h3 class="section-subheading text-muted">
            Hip Hop IllumiNation’s lessons use examples from hip hop music where one or more sub domains 
            of the Six Cs is demonstrated. Youth are prompted to identify how each positive asset is 
            demonstrated in the music, reflect on how they can relate to the artist’s experience, and 
            discuss how they might further cultivate the positive asset in their personal life. Adults are 
            prompted to facilitate this process of discovery, reflection, and discussion. They are also encouraged 
            to follow up with and support youth to ensure appropriate opportunities for cultivation are in place.
            <br />
            <br />
            We believe that young men of color will be motivated to emulate the positive
            qualities of hip hop artists with whom they can relate. Hip Hop IllumiNation provides the 
            platform and structure for them to not only identify the positive messages in hip hop music but
            also to see how those messages relate to their own lives and access opportunities to cultivate the same qualities in themselves.
    <%--    </p>--%>
                </h3>
            </div>
                     </div>
</div>
    </section>
  
    <!-- Team -->
    <section class="bg-light" id="team">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2 class="section-heading text-uppercase">Our Amazing Team</h2>
                    <h3 class="section-subheading text-muted"></h3>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Kristina Mosqueda</h4>
                        <p class="text-muted">Lead Designer</p>
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
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Dan Baron</h4>
                        <p class="text-muted">Lead Engineer</p>
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
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Max Ammon</h4>
                        <p class="text-muted">Lead Developer</p>
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
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Jacob Groff</h4>
                        <p class="text-muted">Lead Architect</p>
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
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Yun Zhang</h4>
                        <p class="text-muted">Database Engineer</p>
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
                </div>
                <div class="col-sm-4">
                    <div class="team-member">
                        <img class="mx-auto rounded-circle" src="#" alt="">
                        <h4>Quentin Schaefer</h4>
                        <p class="text-muted">Project Manager</p>
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
                </div>
            </div>
            <div class="row">
                <div class="col-lg-8 mx-auto text-center">
                    <p class="large text-muted">JMU CIS 484 Hip Hop IllumiNation Project</p>
                </div>
            </div>
        </div>
    </section>
    <%--<!-- Clients -->
    <section class="py-5">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <a href="#">
                        <img class="img-fluid d-block mx-auto" src="img/logos/envato.jpg" alt="">
                    </a>
                </div>
                <div class="col-md-3 col-sm-6">
                    <a href="#">
                        <img class="img-fluid d-block mx-auto" src="img/logos/designmodo.jpg" alt="">
                    </a>
                </div>
                <div class="col-md-3 col-sm-6">
                    <a href="#">
                        <img class="img-fluid d-block mx-auto" src="img/logos/themeforest.jpg" alt="">
                    </a>
                </div>
                <div class="col-md-3 col-sm-6">
                    <a href="#">
                        <img class="img-fluid d-block mx-auto" src="img/logos/creative-market.jpg" alt="">
                    </a>
                </div>
            </div>
        </div>
    </section>--%>
    <!-- Contact -->
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
                                    <input class="form-control" id="name" type="text" placeholder="Your Name *" required="required" data-validation-required-message="Please enter your name.">
                                    <p class="help-block text-danger"></p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="email" type="email" placeholder="Your Email *" required="required" data-validation-required-message="Please enter your email address.">
                                    <p class="help-block text-danger"></p>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" id="phone" type="tel" placeholder="Your Phone *" required="required" data-validation-required-message="Please enter your phone number.">
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-group">
                                    <textarea class="form-control" id="message" placeholder="Your Message *" required="required" data-validation-required-message="Please enter a message."></textarea>
                                    <p class="help-block text-danger"></p>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                            <div class="col-lg-12 text-center">
                                <div id="success"></div>
                                <button id="sendMessageButton" class="btn btn-primary btn-xl text-uppercase" type="submit">Send Message</button>
                            </div>
                        </div>
                    </form>
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
    <!-- Portfolio Modals -->
    <!-- Modal 1 -->
    <div class="portfolio-modal modal fade" id="portfolioModal1" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Caring</h2>
                                <p class="item-intro text-muted"> </p>
                                <img class="img-fluid d-block mx-auto" src="img/portfolio/headphones.jpg" alt="">
                                <p>A sense of sympathy and empathy for others.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>                                    
                                    <li>Category: Caring</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close 
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal 2 -->
    <div class="portfolio-modal modal fade" id="portfolioModal2" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Character</h2>
                                <p class="item-intro text-muted"> </p>
                                <img class="img-fluid d-block mx-auto" src="img/portfolio/number2.jpg" alt="">

                                <p>Respect for societal and cultural rules, possession of standards for correct behaviors, a sense of right and wrong, and integrity.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>
                                   
                                    <li>Category: Character</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal 3 -->
    <div class="portfolio-modal modal fade" id="portfolioModal3" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Competence</h2>
                                <p class="item-intro text-muted"> </p>
                                <img class="img-fluid d-block mx-auto" src="img/6C11.jpeg" alt="">
                                <p>Positive view of one’s abilities in domain specific areas including social, academic, cognitive, and vocational.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>
                                    
                                    <li>Category: Competence</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close 
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal 4 -->
    <div class="portfolio-modal modal fade" id="portfolioModal4" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Confidence</h2>
                                <%--<p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>--%>
                                <img class="img-fluid d-block mx-auto" src="img/portfolio/MusicNote.jpg" width="400px" height="800px" alt="">
                                <p>An internal sense of overall positive self-worth and self-efficacy; one’s global self-regard, as opposed to domain specific beliefs.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>
                                    <li>Category: Confidence</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal 5 -->
    <div class="portfolio-modal modal fade" id="portfolioModal5" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Connection</h2>
                                <%--<p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>--%>
                                <img class="img-fluid d-block mx-auto" src="img/portfolio/connection.jpg" alt="">
                                
                                <p>Positive bonds with people and institutions that are reflected in mutual exchanges between the individual and peers, family, school, and community in which both parties contribute to the relationship.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>
                                    <li>Category: Connection</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Modal 6 -->
    <div class="portfolio-modal modal fade" id="portfolioModal6" tabindex="-1" role="dialog" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="close-modal" data-dismiss="modal">
                    <div class="lr">
                        <div class="rl"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 mx-auto">
                            <div class="modal-body">
                                <!-- Project Details Go Here -->
                                <h2 class="text-uppercase">Contribution</h2>
                               <%-- <p class="item-intro text-muted">Lorem ipsum dolor sit amet consectetur.</p>--%>
                                <img class="img-fluid d-block mx-auto" src="img/portfolio/microphone_02.jpg"  alt="">
                                
                                <p>Contribution is frequently added to the original model as scholars have recognized the importance of youth engagement in family, civic, and political life. This model suggests that youth experience positive development when their strengths in these areas are aligned with positive opportunities to grow.</p>
                                <ul class="list-inline">
                                    <li>Date: April 2019</li>
                                    <%--<li>Client: Window</li>--%>
                                    <li>Category: Contribution</li>
                                </ul>
                                <button class="btn btn-primary" data-dismiss="modal" type="button">
                                    <i class="fas fa-times"></i>
                                    Close
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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