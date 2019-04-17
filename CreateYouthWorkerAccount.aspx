<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateYouthWorkerAccount.aspx.cs" Inherits="CreateYouthWorkerAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>

<html>
<head>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    
    <title>Hip Hop IllumiNation.com</title>
    <style>
        .drop{border:ridge;}
    
        .register{
    background: -webkit-linear-gradient(left, #3931af, #00c6ff);
    margin-top: 3%;
    padding: 3%;
}
.register-left{
    text-align: center;
    color: #fff;
    margin-top: 4%;
}
.register-left input{
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    width: 60%;
    background: #f8f9fa;
    font-weight: bold;
    color: #383d41;
    margin-top: 30%;
    margin-bottom: 3%;
    cursor: pointer;
}
.register-right{
    background: #f8f9fa;
    border-top-left-radius: 10% 50%;
    border-bottom-left-radius: 10% 50%;
}
.register-left img{
    margin-top: 15%;
    margin-bottom: 5%;
    width: 25%;
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
.register-left p{
    font-weight: lighter;
    padding: 12%;
    margin-top: -9%;
}
.register .register-form{
    padding: 10%;
    margin-top: 10%;
}
.btnRegister{
    float: right;
    margin-top: 10%;
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    background: #0062cc;
    color: #fff;
    font-weight: 600;
    width: 50%;
    cursor: pointer;
}
.register .nav-tabs{
    margin-top: 3%;
    border: none;
    background: #0062cc;
    border-radius: 1.5rem;
    width: 28%;
    float: right;
}
.register .nav-tabs .nav-link{
    padding: 2%;
    height: 34px;
    font-weight: 600;
    color: #fff;
    border-top-right-radius: 1.5rem;
    border-bottom-right-radius: 1.5rem;
}
.register .nav-tabs .nav-link:hover{
    border: none;
}
.register .nav-tabs .nav-link.active{
    width: 100px;
    color: #0062cc;
    border: 2px solid #0062cc;
    border-top-left-radius: 1.5rem;
    border-bottom-left-radius: 1.5rem;
}
.register-heading{
    text-align: center;
    margin-top: 8%;
    margin-bottom: -15%;
    color: #495057;
}
        
        </style>
</head>
<body>   
            
    <div class="container register">
                <div class="row">
                    <div class="col-md-3 register-left">
                        <img src="https://image.ibb.co/n7oTvU/logo_white.png" alt=""/>
                        <h3>Welcome</h3>
                        <p>to Hip Hop Illumination!</p>

                    </div>
                    <div class="col-md-9 register-right">

                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">Create Youth Worker Account</h3>
                                <div class="row register-form">
                                    <div class="col-xl-6">
                                        <div class="form-group">
                                            <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                                            <asp:TextBox ID="firstNameTextBox" runat="server" CssClass="form-control" placeholder="First Name *" Width="240px" required="true"></asp:TextBox>
                                        </div>  
                                        <div class="form-group">
                                            <asp:Label ID="middleNameLabel" runat="server" Text="Middle Name"></asp:Label>
                                            <asp:TextBox ID="middleNameTextBox" runat="server" CssClass="form-control" placeholder="Middle Name *" Width="240px"></asp:TextBox>
                                        </div>      
                                    
                                    <div class="form-group">
                                    <asp:Label ID="lastNameLabel" runat="server" Text="Last Name"></asp:Label>
                                    <asp:TextBox ID="lastNameTextBox" runat="server" CssClass="form-control" Width="240px" placeholder="Last Name *" required="true"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
                                        <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" Width="240px" placeholder="Email *" required="true"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label ID="dobLabel" runat="server" Text="Date Of Birth"></asp:Label>
                                        <asp:TextBox ID="dobTextBox" runat="server" CssClass="form-control" Width="240px" placeholder="DD/MM/YYYY *" required="true"></asp:TextBox>
                                    </div>
                                    
                                    <div class="form-group">
                                             <asp:Label ID="genderLabel" runat="server" Text="Gender"></asp:Label>
                                             <br />
                                            <asp:DropDownList ID="genderDropDownList" CssClass="drop" runat="server" Width="240px">
                                                <asp:ListItem Value="M">Male</asp:ListItem>
                                                <asp:ListItem Value="F">Female</asp:ListItem>
                                                <asp:ListItem Value="DND">I Do Not Wish to Disclose</asp:ListItem>
                                            </asp:DropDownList>
                                    </div>
                                    
                                    <div class="form-group">
                                        <asp:Label ID="schoolLabel" runat="server" Text="School" ></asp:Label>
                                        <asp:TextBox ID="SchoolTextBox" runat="server" CssClass="form-control" placeholder="School *" Width="240px" required="true"></asp:TextBox>


                                        </div>
                                         <div class="form-group">
                                             <asp:Label ID="streetLabel" runat="server" Text="Street"></asp:Label>
                                            <asp:TextBox ID="streetTextBox" runat="server" CssClass="form-control" placeholder="Street *" Width="240px" required="true"></asp:TextBox>
                                             </div>
                                        <div class="form-group">
                                            <asp:Label ID="cityLabel" runat="server" Text="City"></asp:Label>
                                            <asp:TextBox ID="cityTextBox" runat="server" CssClass="form-control" placeholder="City *" Width="240px" required="true"></asp:TextBox>

                                            </div>

                                        <div class="form-group">
                                                 <asp:Label ID="stateLabel" runat="server" Text="State:"></asp:Label>
                                                  <br />
                                                  <asp:DropDownList ID="stateDropDownList" runat="server" CssClass="drop" Width="240px" >                                                                            
	                                                            <asp:ListItem Value="AL">Alabama</asp:ListItem>
	                                                            <asp:ListItem Value="AK">Alaska</asp:ListItem>
	                                                            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
	                                                            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
	                                                            <asp:ListItem Value="CA">California</asp:ListItem>
	                                                            <asp:ListItem Value="CO">Colorado</asp:ListItem>
	                                                            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
	                                                            <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
	                                                            <asp:ListItem Value="DE">Delaware</asp:ListItem>
	                                                            <asp:ListItem Value="FL">Florida</asp:ListItem>
	                                                            <asp:ListItem Value="GA">Georgia</asp:ListItem>
	                                                            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
	                                                            <asp:ListItem Value="ID">Idaho</asp:ListItem>
	                                                            <asp:ListItem Value="IL">Illinois</asp:ListItem>
	                                                            <asp:ListItem Value="IN">Indiana</asp:ListItem>
	                                                            <asp:ListItem Value="IA">Iowa</asp:ListItem>
	                                                            <asp:ListItem Value="KS">Kansas</asp:ListItem>
	                                                            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
	                                                            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
	                                                            <asp:ListItem Value="ME">Maine</asp:ListItem>
	                                                            <asp:ListItem Value="MD">Maryland</asp:ListItem>
	                                                            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
	                                                            <asp:ListItem Value="MI">Michigan</asp:ListItem>
	                                                            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
	                                                            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
	                                                            <asp:ListItem Value="MO">Missouri</asp:ListItem>
	                                                            <asp:ListItem Value="MT">Montana</asp:ListItem>
	                                                            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
	                                                            <asp:ListItem Value="NV">Nevada</asp:ListItem>
	                                                            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
	                                                            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
	                                                            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
	                                                            <asp:ListItem Value="NY">New York</asp:ListItem>
	                                                            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
	                                                            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
	                                                            <asp:ListItem Value="OH">Ohio</asp:ListItem>
	                                                            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
	                                                            <asp:ListItem Value="OR">Oregon</asp:ListItem>
	                                                            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
	                                                            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
	                                                            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
	                                                            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
	                                                            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
	                                                            <asp:ListItem Value="TX">Texas</asp:ListItem>
	                                                            <asp:ListItem Value="UT">Utah</asp:ListItem>
	                                                            <asp:ListItem Value="VT">Vermont</asp:ListItem>
	                                                            <asp:ListItem Value="VA">Virginia</asp:ListItem>
	                                                            <asp:ListItem Value="WA">Washington</asp:ListItem>
	                                                            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
	                                                            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
	                                                            <asp:ListItem Value="WY">Wyoming</asp:ListItem>







                                               </asp:DropDownList>



                                            </div>
                                                            
                                        <div class="form-group">

                                            <asp:Label ID="countryLabel" runat="server" Text="Country"></asp:Label>

                                            <br />

                                            <asp:DropDownList ID="countryDropDownList" runat="server" CssClass="drop" Width="240px">
                                                                                        <asp:ListItem Value="AF">Afghanistan</asp:ListItem>

                                                                                        <asp:ListItem Value="AL">Albania</asp:ListItem>

                                                                                        <asp:ListItem Value="DZ">Algeria</asp:ListItem>

                                                                                        <asp:ListItem Value="AS">American Samoa</asp:ListItem>

                                                                                        <asp:ListItem Value="AD">Andorra</asp:ListItem>

                                                                                        <asp:ListItem Value="AO">Angola</asp:ListItem>

                                                                                        <asp:ListItem Value="AI">Anguilla</asp:ListItem>

                                                                                        <asp:ListItem Value="AQ">Antarctica</asp:ListItem>

                                                                                        <asp:ListItem Value="AG">Antigua And Barbuda</asp:ListItem>

                                                                                        <asp:ListItem Value="AR">Argentina</asp:ListItem>

                                                                                        <asp:ListItem Value="AM">Armenia</asp:ListItem>

                                                                                        <asp:ListItem Value="AW">Aruba</asp:ListItem>

                                                                                        <asp:ListItem Value="AU">Australia</asp:ListItem>

                                                                                        <asp:ListItem Value="AT">Austria</asp:ListItem>

                                                                                        <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>

                                                                                        <asp:ListItem Value="BS">Bahamas</asp:ListItem>

                                                                                        <asp:ListItem Value="BH">Bahrain</asp:ListItem>

                                                                                        <asp:ListItem Value="BD">Bangladesh</asp:ListItem>

                                                                                        <asp:ListItem Value="BB">Barbados</asp:ListItem>

                                                                                        <asp:ListItem Value="BY">Belarus</asp:ListItem>

                                                                                        <asp:ListItem Value="BE">Belgium</asp:ListItem>

                                                                                        <asp:ListItem Value="BZ">Belize</asp:ListItem>

                                                                                        <asp:ListItem Value="BJ">Benin</asp:ListItem>

                                                                                        <asp:ListItem Value="BM">Bermuda</asp:ListItem>

                                                                                        <asp:ListItem Value="BT">Bhutan</asp:ListItem>

                                                                                        <asp:ListItem Value="BO">Bolivia</asp:ListItem>

                                                                                        <asp:ListItem Value="BA">Bosnia And Herzegowina</asp:ListItem>

                                                                                        <asp:ListItem Value="BW">Botswana</asp:ListItem>

                                                                                        <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>

                                                                                        <asp:ListItem Value="BR">Brazil</asp:ListItem>

                                                                                        <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>

                                                                                        <asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>

                                                                                        <asp:ListItem Value="BG">Bulgaria</asp:ListItem>

                                                                                        <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>

                                                                                        <asp:ListItem Value="BI">Burundi</asp:ListItem>

                                                                                        <asp:ListItem Value="KH">Cambodia</asp:ListItem>

                                                                                        <asp:ListItem Value="CM">Cameroon</asp:ListItem>

                                                                                        <asp:ListItem Value="CA">Canada</asp:ListItem>

                                                                                        <asp:ListItem Value="CV">Cape Verde</asp:ListItem>

                                                                                        <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="CF">Central African Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="TD">Chad</asp:ListItem>

                                                                                        <asp:ListItem Value="CL">Chile</asp:ListItem>

                                                                                        <asp:ListItem Value="CN">China</asp:ListItem>

                                                                                        <asp:ListItem Value="CX">Christmas Island</asp:ListItem>

                                                                                        <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="CO">Colombia</asp:ListItem>

                                                                                        <asp:ListItem Value="KM">Comoros</asp:ListItem>

                                                                                        <asp:ListItem Value="CG">Congo</asp:ListItem>

                                                                                        <asp:ListItem Value="CK">Cook Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="CR">Costa Rica</asp:ListItem>

                                                                                        <asp:ListItem Value="CI">Cote D'Ivoire</asp:ListItem>

                                                                                        <asp:ListItem Value="HR">Croatia (Local Name: Hrvatska)</asp:ListItem>

                                                                                        <asp:ListItem Value="CU">Cuba</asp:ListItem>

                                                                                        <asp:ListItem Value="CY">Cyprus</asp:ListItem>

                                                                                        <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="DK">Denmark</asp:ListItem>

                                                                                        <asp:ListItem Value="DJ">Djibouti</asp:ListItem>

                                                                                        <asp:ListItem Value="DM">Dominica</asp:ListItem>

                                                                                        <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="TP">East Timor</asp:ListItem>

                                                                                        <asp:ListItem Value="EC">Ecuador</asp:ListItem>

                                                                                        <asp:ListItem Value="EG">Egypt</asp:ListItem>

                                                                                        <asp:ListItem Value="SV">El Salvador</asp:ListItem>

                                                                                        <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>

                                                                                        <asp:ListItem Value="ER">Eritrea</asp:ListItem>

                                                                                        <asp:ListItem Value="EE">Estonia</asp:ListItem>

                                                                                        <asp:ListItem Value="ET">Ethiopia</asp:ListItem>

                                                                                        <asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>

                                                                                        <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="FJ">Fiji</asp:ListItem>

                                                                                        <asp:ListItem Value="FI">Finland</asp:ListItem>

                                                                                        <asp:ListItem Value="FR">France</asp:ListItem>

                                                                                        <asp:ListItem Value="GF">French Guiana</asp:ListItem>

                                                                                        <asp:ListItem Value="PF">French Polynesia</asp:ListItem>

                                                                                        <asp:ListItem Value="TF">French Southern Territories</asp:ListItem>

                                                                                        <asp:ListItem Value="GA">Gabon</asp:ListItem>

                                                                                        <asp:ListItem Value="GM">Gambia</asp:ListItem>

                                                                                        <asp:ListItem Value="GE">Georgia</asp:ListItem>

                                                                                        <asp:ListItem Value="DE">Germany</asp:ListItem>

                                                                                        <asp:ListItem Value="GH">Ghana</asp:ListItem>

                                                                                        <asp:ListItem Value="GI">Gibraltar</asp:ListItem>

                                                                                        <asp:ListItem Value="GR">Greece</asp:ListItem>

                                                                                        <asp:ListItem Value="GL">Greenland</asp:ListItem>

                                                                                        <asp:ListItem Value="GD">Grenada</asp:ListItem>

                                                                                        <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>

                                                                                        <asp:ListItem Value="GU">Guam</asp:ListItem>

                                                                                        <asp:ListItem Value="GT">Guatemala</asp:ListItem>

                                                                                        <asp:ListItem Value="GN">Guinea</asp:ListItem>

                                                                                        <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>

                                                                                        <asp:ListItem Value="GY">Guyana</asp:ListItem>

                                                                                        <asp:ListItem Value="HT">Haiti</asp:ListItem>

                                                                                        <asp:ListItem Value="HM">Heard And Mc Donald Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="VA">Holy See (Vatican City State)</asp:ListItem>

                                                                                        <asp:ListItem Value="HN">Honduras</asp:ListItem>

                                                                                        <asp:ListItem Value="HK">Hong Kong</asp:ListItem>

                                                                                        <asp:ListItem Value="HU">Hungary</asp:ListItem>

                                                                                        <asp:ListItem Value="IS">Icel And</asp:ListItem>

                                                                                        <asp:ListItem Value="IN">India</asp:ListItem>

                                                                                        <asp:ListItem Value="ID">Indonesia</asp:ListItem>

                                                                                        <asp:ListItem Value="IR">Iran (Islamic Republic Of)</asp:ListItem>

                                                                                        <asp:ListItem Value="IQ">Iraq</asp:ListItem>

                                                                                        <asp:ListItem Value="IE">Ireland</asp:ListItem>

                                                                                        <asp:ListItem Value="IL">Israel</asp:ListItem>

                                                                                        <asp:ListItem Value="IT">Italy</asp:ListItem>

                                                                                        <asp:ListItem Value="JM">Jamaica</asp:ListItem>

                                                                                        <asp:ListItem Value="JP">Japan</asp:ListItem>

                                                                                        <asp:ListItem Value="JO">Jordan</asp:ListItem>

                                                                                        <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>

                                                                                        <asp:ListItem Value="KE">Kenya</asp:ListItem>

                                                                                        <asp:ListItem Value="KI">Kiribati</asp:ListItem>

                                                                                        <asp:ListItem Value="KP">Korea, Dem People'S Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="KR">Korea, Republic Of</asp:ListItem>

                                                                                        <asp:ListItem Value="KW">Kuwait</asp:ListItem>

                                                                                        <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>

                                                                                        <asp:ListItem Value="LA">Lao People'S Dem Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="LV">Latvia</asp:ListItem>

                                                                                        <asp:ListItem Value="LB">Lebanon</asp:ListItem>

                                                                                        <asp:ListItem Value="LS">Lesotho</asp:ListItem>

                                                                                        <asp:ListItem Value="LR">Liberia</asp:ListItem>

                                                                                        <asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>

                                                                                        <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>

                                                                                        <asp:ListItem Value="LT">Lithuania</asp:ListItem>

                                                                                        <asp:ListItem Value="LU">Luxembourg</asp:ListItem>

                                                                                        <asp:ListItem Value="MO">Macau</asp:ListItem>

                                                                                        <asp:ListItem Value="MK">Macedonia</asp:ListItem>

                                                                                        <asp:ListItem Value="MG">Madagascar</asp:ListItem>

                                                                                        <asp:ListItem Value="MW">Malawi</asp:ListItem>

                                                                                        <asp:ListItem Value="MY">Malaysia</asp:ListItem>

                                                                                        <asp:ListItem Value="MV">Maldives</asp:ListItem>

                                                                                        <asp:ListItem Value="ML">Mali</asp:ListItem>

                                                                                        <asp:ListItem Value="MT">Malta</asp:ListItem>

                                                                                        <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="MQ">Martinique</asp:ListItem>

                                                                                        <asp:ListItem Value="MR">Mauritania</asp:ListItem>

                                                                                        <asp:ListItem Value="MU">Mauritius</asp:ListItem>

                                                                                        <asp:ListItem Value="YT">Mayotte</asp:ListItem>

                                                                                        <asp:ListItem Value="MX">Mexico</asp:ListItem>

                                                                                        <asp:ListItem Value="FM">Micronesia, Federated States</asp:ListItem>

                                                                                        <asp:ListItem Value="MD">Moldova, Republic Of</asp:ListItem>

                                                                                        <asp:ListItem Value="MC">Monaco</asp:ListItem>

                                                                                        <asp:ListItem Value="MN">Mongolia</asp:ListItem>

                                                                                        <asp:ListItem Value="MS">Montserrat</asp:ListItem>

                                                                                        <asp:ListItem Value="MA">Morocco</asp:ListItem>

                                                                                        <asp:ListItem Value="MZ">Mozambique</asp:ListItem>

                                                                                        <asp:ListItem Value="MM">Myanmar</asp:ListItem>

                                                                                        <asp:ListItem Value="NA">Namibia</asp:ListItem>

                                                                                        <asp:ListItem Value="NR">Nauru</asp:ListItem>

                                                                                        <asp:ListItem Value="NP">Nepal</asp:ListItem>

                                                                                        <asp:ListItem Value="NL">Netherlands</asp:ListItem>

                                                                                        <asp:ListItem Value="AN">Netherlands Ant Illes</asp:ListItem>

                                                                                        <asp:ListItem Value="NC">New Caledonia</asp:ListItem>

                                                                                        <asp:ListItem Value="NZ">New Zealand</asp:ListItem>

                                                                                        <asp:ListItem Value="NI">Nicaragua</asp:ListItem>

                                                                                        <asp:ListItem Value="NE">Niger</asp:ListItem>

                                                                                        <asp:ListItem Value="NG">Nigeria</asp:ListItem>

                                                                                        <asp:ListItem Value="NU">Niue</asp:ListItem>

                                                                                        <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>

                                                                                        <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="NO">Norway</asp:ListItem>

                                                                                        <asp:ListItem Value="OM">Oman</asp:ListItem>

                                                                                        <asp:ListItem Value="PK">Pakistan</asp:ListItem>

                                                                                        <asp:ListItem Value="PW">Palau</asp:ListItem>

                                                                                        <asp:ListItem Value="PA">Panama</asp:ListItem>

                                                                                        <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>

                                                                                        <asp:ListItem Value="PY">Paraguay</asp:ListItem>

                                                                                        <asp:ListItem Value="PE">Peru</asp:ListItem>

                                                                                        <asp:ListItem Value="PH">Philippines</asp:ListItem>

                                                                                        <asp:ListItem Value="PN">Pitcairn</asp:ListItem>

                                                                                        <asp:ListItem Value="PL">Poland</asp:ListItem>

                                                                                        <asp:ListItem Value="PT">Portugal</asp:ListItem>

                                                                                        <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>

                                                                                        <asp:ListItem Value="QA">Qatar</asp:ListItem>

                                                                                        <asp:ListItem Value="RE">Reunion</asp:ListItem>

                                                                                        <asp:ListItem Value="RO">Romania</asp:ListItem>

                                                                                        <asp:ListItem Value="RU">Russian Federation</asp:ListItem>

                                                                                        <asp:ListItem Value="RW">Rwanda</asp:ListItem>

                                                                                        <asp:ListItem Value="KN">Saint K Itts And Nevis</asp:ListItem>

                                                                                        <asp:ListItem Value="LC">Saint Lucia</asp:ListItem>

                                                                                        <asp:ListItem Value="VC">Saint Vincent, The Grenadines</asp:ListItem>

                                                                                        <asp:ListItem Value="WS">Samoa</asp:ListItem>

                                                                                        <asp:ListItem Value="SM">San Marino</asp:ListItem>

                                                                                        <asp:ListItem Value="ST">Sao Tome And Principe</asp:ListItem>

                                                                                        <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>

                                                                                        <asp:ListItem Value="SN">Senegal</asp:ListItem>

                                                                                        <asp:ListItem Value="SC">Seychelles</asp:ListItem>

                                                                                        <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>

                                                                                        <asp:ListItem Value="SG">Singapore</asp:ListItem>

                                                                                        <asp:ListItem Value="SK">Slovakia (Slovak Republic)</asp:ListItem>

                                                                                        <asp:ListItem Value="SI">Slovenia</asp:ListItem>

                                                                                        <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="SO">Somalia</asp:ListItem>

                                                                                        <asp:ListItem Value="ZA">South Africa</asp:ListItem>

                                                                                        <asp:ListItem Value="GS">South Georgia , S Sandwich Is.</asp:ListItem>

                                                                                        <asp:ListItem Value="ES">Spain</asp:ListItem>

                                                                                        <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>

                                                                                        <asp:ListItem Value="SH">St. Helena</asp:ListItem>

                                                                                        <asp:ListItem Value="PM">St. Pierre And Miquelon</asp:ListItem>

                                                                                        <asp:ListItem Value="SD">Sudan</asp:ListItem>

                                                                                        <asp:ListItem Value="SR">Suriname</asp:ListItem>

                                                                                        <asp:ListItem Value="SJ">Svalbard, Jan Mayen Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="SZ">Sw Aziland</asp:ListItem>

                                                                                        <asp:ListItem Value="SE">Sweden</asp:ListItem>

                                                                                        <asp:ListItem Value="CH">Switzerland</asp:ListItem>

                                                                                        <asp:ListItem Value="SY">Syrian Arab Republic</asp:ListItem>

                                                                                        <asp:ListItem Value="TW">Taiwan</asp:ListItem>

                                                                                        <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>

                                                                                        <asp:ListItem Value="TZ">Tanzania, United Republic Of</asp:ListItem>

                                                                                        <asp:ListItem Value="TH">Thailand</asp:ListItem>

                                                                                        <asp:ListItem Value="TG">Togo</asp:ListItem>

                                                                                        <asp:ListItem Value="TK">Tokelau</asp:ListItem>

                                                                                        <asp:ListItem Value="TO">Tonga</asp:ListItem>

                                                                                        <asp:ListItem Value="TT">Trinidad And Tobago</asp:ListItem>

                                                                                        <asp:ListItem Value="TN">Tunisia</asp:ListItem>

                                                                                        <asp:ListItem Value="TR">Turkey</asp:ListItem>

                                                                                        <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>

                                                                                        <asp:ListItem Value="TC">Turks And Caicos Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="TV">Tuvalu</asp:ListItem>

                                                                                        <asp:ListItem Value="UG">Uganda</asp:ListItem>

                                                                                        <asp:ListItem Value="UA">Ukraine</asp:ListItem>

                                                                                        <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>

                                                                                        <asp:ListItem Value="GB">United Kingdom</asp:ListItem>

                                                                                        <asp:ListItem Value="US"  Selected="True">United States</asp:ListItem>

                                                                                        <asp:ListItem Value="UM">United States Minor Is.</asp:ListItem>

                                                                                        <asp:ListItem Value="UY">Uruguay</asp:ListItem>

                                                                                        <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>

                                                                                        <asp:ListItem Value="VU">Vanuatu</asp:ListItem>

                                                                                        <asp:ListItem Value="VE">Venezuela</asp:ListItem>

                                                                                        <asp:ListItem Value="VN">Viet Nam</asp:ListItem>

                                                                                        <asp:ListItem Value="VG">Virgin Islands (British)</asp:ListItem>

                                                                                        <asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>

                                                                                        <asp:ListItem Value="WF">Wallis And Futuna Islands</asp:ListItem>

                                                                                        <asp:ListItem Value="EH">Western Sahara</asp:ListItem>

                                                                                        <asp:ListItem Value="YE">Yemen</asp:ListItem>

                                                                                        <asp:ListItem Value="YU">Yugoslavia</asp:ListItem>

                                                                                        <asp:ListItem Value="ZR">Zaire</asp:ListItem>

                                                                                        <asp:ListItem Value="ZM">Zambia</asp:ListItem>

                                                                                        <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>

                                                                                 </asp:DropDownList>
                                            </div>
                                           <div class="form-group">
                                               <asp:Label ID="zipCodeLabel" runat="server" Text="Zip Code"></asp:Label>
                                                <asp:TextBox ID="zipCodeTextBox" runat="server" CssClass="form-control" placeholder="Zip Code *" Width="240px" required="true"></asp:TextBox>


                                               </div>
                                        <div class="form-group">

                                            <asp:Label ID="userNameLabel" runat="server" Text="UserName"></asp:Label>
                                            <asp:TextBox ID="userNameTextBox" runat="server" CssClass="form-control" placeholder="Username *" Width="240px" required="true"></asp:TextBox>



                                        </div>

                                        <div class="form-group">

                                             <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label>
                                            <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password *" Width="240px" required="true"></asp:TextBox>

                                        </div>

                                        <div class="form-group">

                                            <asp:Button ID="btnRegister" class="btnRegister" OnClick="CreateAccount_Click" runat="server" Text="Create" />

                                        </div>

                                    </div> 
                                    </div> 
                                </div> 
                            </div> 
                        </div> 
                        </div> 
                        </div> 
        
       
    

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>

</asp:Content>
