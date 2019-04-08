<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="Review Us.aspx.cs" Inherits="Review_Us" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>--%>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css">
    <head>
    <title>Review Us</title>
</head>
<style>
    body{
        padding-top: 50px !important;
        margin: 0;
        background: url(img/header-bg.jpg);
        background-size: 1440px 800px; 
        overflow-y: scroll;
        }



div.stars {
  width: 270px;
  display: inline-block;
}

input.star { display: none; }

label.star {
  float: right;
  padding: 10px;
  font-size: 36px;

  color: lightyellow;

  transition: all .2s;
} 
input.star:checked ~ label.star:before {
  content: '\f005';
  color: #FD4;
  transition: all .25s;
} 
input.star-1:checked ~ label.star:before {
  color: #FE7;
  text-shadow: 0 0 20px #952;
} 
input.star-5:checked ~ label.star:before { color: #F62; }


label.star:hover { transform: rotate(-15deg) scale(1.3); }

    label.star:before {
        content: '\f006';
        font-family: FontAwesome;
    }
</style>        
        
            
            <br />
            <asp:GridView ID="gvDocuments" runat="server" CssClass="table-dark table-hover" AutoGenerateColumns="False" DataKeyNames="ID">
                <%--<Columns>
                    <asp:TemplateField HeaderText="Document ID">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Documents">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>--%>
            </asp:GridView>
        
    



    <div class="container">  
      <div></div>
          <center>
              <h1 style="color:#fff;">We Appreciate Your Feedback!</h1>
              <h3 style="color:#fff;">Your 5 most recent lessons.</h3>
              <br />
          </center>
          </div>       

    <table class="table table-striped table-dark">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Documents</th>
      <th scope="col">Read Again?</th>
      <th scope="col">Rating</th>
      <th scope="col">Submit</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>      
      <td id="doc1" runat="server"></td>
      <td><button type="button" class="btn btn-primary">Read</button></td>
      <td>         
        <div class="stars">  
    <input class="star star-1" id="star-1" type="radio" name="star" hidden/>
    <label class="star star-1" for="star-1"></label>
    <input class="star star-2" id="star-2" type="radio" name="star" hidden/>
    <label class="star star-2" for="star-2"></label>
    <input class="star star-3" id="star-3" type="radio" name="star" hidden/>
    <label class="star star-3" for="star-3"></label>
    <input class="star star-4" id="star-4" type="radio" name="star" hidden/>
    <label class="star star-4" for="star-4"></label>
    <input class="star star-5" id="star-5" type="radio" name="star" hidden/>
    <label class="star star-5" for="star-5"></label>
    </div>
      </td>
        <td><button type="button" class="btn btn-primary">Submit</button></td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td id="doc2" runat="server"></td>
      <td><button type="button" class="btn btn-primary">Read</button></td>
      <td>
           <div class="stars">  
    <input class="star star-1" id="star-6" type="radio" name="star" hidden/>
    <label class="star star-1" for="star-6"></label>
    <input class="star star-2" id="star-7" type="radio" name="star" hidden/>
    <label class="star star-2" for="star-7"></label>
    <input class="star star-3" id="star-8" type="radio" name="star" hidden/>
    <label class="star star-3" for="star-8"></label>
    <input class="star star-4" id="star-9" type="radio" name="star" hidden/>
    <label class="star star-4" for="star-9"></label>
    <input class="star star-5" id="star-10" type="radio" name="star" hidden/>
    <label class="star star-5" for="star-10"></label>
    </div>
      </td>
        <td><button type="button" class="btn btn-primary">Submit</button></td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td id="doc3" runat="server"></td>
      <td><button type="button" class="btn btn-primary">Read</button></td>
      <td>
           <div class="stars">  
    <input class="star star-1" id="star-11" type="radio" name="star" hidden/>
    <label class="star star-1" for="star-11"></label>
    <input class="star star-2" id="star-12" type="radio" name="star" hidden/>
    <label class="star star-2" for="star-12"></label>
    <input class="star star-3" id="star-13" type="radio" name="star" hidden/>
    <label class="star star-3" for="star-13"></label>
    <input class="star star-4" id="star-14" type="radio" name="star" hidden/>
    <label class="star star-4" for="star-14"></label>
    <input class="star star-5" id="star-15" type="radio" name="star" hidden/>
    <label class="star star-5" for="star-15"></label>
    </div>
      </td>
        <td><button type="button" class="btn btn-primary">Submit</button></td>
    </tr>
      <tr>
        <th scope="row">4</th>      
      <td id="doc4" runat="server"></td>
      <td><button type="button" class="btn btn-primary">Read</button></td>
      <td> 
          <div class="stars">  
    <input class="star star-1" id="star-16" type="radio" name="star" hidden/>
    <label class="star star-1" for="star-16"></label>
    <input class="star star-2" id="star-17" type="radio" name="star" hidden/>
    <label class="star star-2" for="star-17"></label>
    <input class="star star-3" id="star-18" type="radio" name="star" hidden/>
    <label class="star star-3" for="star-18"></label>
    <input class="star star-4" id="star-19" type="radio" name="star" hidden/>
    <label class="star star-4" for="star-19"></label>
    <input class="star star-5" id="star-20" type="radio" name="star" hidden/>
    <label class="star star-5" for="star-20"></label>
    </div>
      </td>
          <td><button type="button" class="btn btn-primary">Submit</button></td>
    </tr>
    <tr>
      <th scope="row">5</th>
      <td id="doc5" runat="server"></td>
      <td><button type="button" class="btn btn-primary">Read</button></td>
      <td>
           <div class="stars">  
    <input class="star star-1" id="star-21" type="radio" name="star" hidden/>
    <label class="star star-1" for="star-21"></label>
    <input class="star star-2" id="star-22" type="radio" name="star" hidden/>
    <label class="star star-2" for="star-22"></label>
    <input class="star star-3" id="star-23" type="radio" name="star" hidden/>
    <label class="star star-3" for="star-23"></label>
    <input class="star star-4" id="star-24" type="radio" name="star" hidden/>
    <label class="star star-4" for="star-24"></label>
    <input class="star star-5" id="star-25" type="radio" name="star" hidden/>
    <label class="star star-5" for="star-25"></label>
    </div>
      </td>
        <td><button type="button" class="btn btn-primary">Submit</button></td>
    </tr>    
  </tbody>
</table>
</asp:Content>
