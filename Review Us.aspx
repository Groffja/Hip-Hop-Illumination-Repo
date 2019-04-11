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
input.star-2:checked ~ label.star:before {
  content: '\f005';
  color: #FD4;
  transition: all .25s;
} 
input.star-3:checked ~ label.star:before {
  content: '\f005';
  color: #FD4;
  transition: all .25s;
} 
input.star-4:checked ~ label.star:before {
  content: '\f005';
  color: #FD4;
  transition: all .25s;
} 
input.star-5:checked ~ label.star:before { color: #F62; }


label.star:hover { transform: rotate(-15deg) scale(1.3); }

    label.star:before {
        content: '\f006';
        font-family: FontAwesome;
    }
</style>        
        </head>
    <body>
            
            <br />
            <asp:GridView ID="gvDocuments" runat="server" CssClass="table-dark table-hover" AutoGenerateColumns="False" DataKeyNames="ID">
               <%-- <Columns>
                    <asp:TemplateField HeaderText="Document ID">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Documents">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1"  runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>--%>
            </asp:GridView>
        
    


        <div class="container" runat="server">
    <div class="container">  
      <div></div>
          <center>
              <h1 style="color:#fff;">We Appreciate Your Feedback!</h1>
              <h3 style="color:#fff;">Your 5 most recent lessons.</h3>
              <br />
          </center>
          </div>       

    <table runat="server" class="table table-striped table-dark" >
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Documents</th>
      <%--<th scope="col">Read Again?</th>--%>
      <th scope="col">Rating</th>
      <th scope="col">Submit</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row">1</th>      
      <td id="doc1" runat="server"></td>
      <%--<td><asp:Button class="btn btn-primary" Text="Read" runat="server"  onclick="btnRead" /></td>--%>
      <td>         
        <div class="stars input-group"  >  
    <input class="star star-1" ClientIDMode="static" runat="server" id="star1" type="radio" name="star" hidden/>
    <label class="star star-1" ClientIDMode="static" runat="server" for="star1"></label>
    <input class="star star-2" ClientIDMode="static" runat="server"  id="star2" type="radio" name="star" hidden/>
    <label class="star star-2" ClientIDMode="static" runat="server" for="star2"></label>
    <input class="star star-3" ClientIDMode="static" runat="server" id="star3" type="radio" name="star" hidden/>
    <label class="star star-3" ClientIDMode="static" runat="server" for="star3"></label>
    <input class="star star-4" ClientIDMode="static" runat="server" id="star4" type="radio" name="star" hidden/>
    <label class="star star-4" ClientIDMode="static" runat="server" for="star4"></label>
    <input class="star star-5" ClientIDMode="static" runat="server" id="star5" type="radio" name="star" hidden/>
    <label class="star star-5" ClientIDMode="static" runat="server" for="star5"></label>
    </div>
      </td>
        <td><asp:Button class="btn btn-primary" Text="Submit" runat="server"  onclick="btnSubmit1" /></td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td id="doc2" runat="server"></td>
      <%--<td><asp:Button class="btn btn-primary" Text="Read" runat="server"  onclick="btnRead" /></td>--%>
      <td>
           <div class="stars">  
    <input class="star star-1" ClientIDMode="static" runat="server" id="star6" type="radio" name="star" hidden/>
    <label class="star star-1" ClientIDMode="static" runat="server" for="star6"></label>
    <input class="star star-2" ClientIDMode="static" runat="server" id="star7" type="radio" name="star" hidden/>
    <label class="star star-2" ClientIDMode="static" runat="server" for="star7"></label>
    <input class="star star-3" ClientIDMode="static" runat="server" id="star8" type="radio" name="star" hidden/>
    <label class="star star-3" ClientIDMode="static" runat="server" for="star8"></label>
    <input class="star star-4" ClientIDMode="static" runat="server" id="star9" type="radio" name="star" hidden/>
    <label class="star star-4" ClientIDMode="static" runat="server" for="star9"></label>
    <input class="star star-5" ClientIDMode="static" runat="server" id="star10" type="radio" name="star" hidden/>
    <label class="star star-5" ClientIDMode="static" runat="server" for="star10"></label>
    </div>
      </td>
        <td><asp:Button  class="btn btn-primary" Text="Submit" runat="server"  onclick="btnSubmit2" /></td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td id="doc3" runat="server"></td>
      <%--<td><asp:Button class="btn btn-primary" Text="Read" runat="server"  onclick="btnRead" /></td>--%>
      <td>
           <div class="stars">  
    <input class="star star-1" ClientIDMode="static" runat="server" id="star11" type="radio" name="star" hidden/>
    <label class="star star-1" ClientIDMode="static" runat="server" for="star11"></label>
    <input class="star star-2" ClientIDMode="static" runat="server" id="star12" type="radio" name="star" hidden/>
    <label class="star star-2" ClientIDMode="static" runat="server" for="star12"></label>
    <input class="star star-3" ClientIDMode="static" runat="server" id="star13" type="radio" name="star" hidden/>
    <label class="star star-3" ClientIDMode="static" runat="server" for="star13"></label>
    <input class="star star-4" ClientIDMode="static" runat="server" id="star14" type="radio" name="star" hidden/>
    <label class="star star-4" ClientIDMode="static" runat="server" for="star14"></label>
    <input class="star star-5" ClientIDMode="static" runat="server" id="star15" type="radio" name="star" hidden/>
    <label class="star star-5" ClientIDMode="static" runat="server" for="star15"></label>
    </div>
      </td>
        <td><asp:Button  class="btn btn-primary" Text="Submit" runat="server"  onclick="btnSubmit3" /></td>
    </tr>
      <tr>
        <th scope="row">4</th>      
      <td id="doc4" runat="server"></td>
      <%--<td><asp:Button class="btn btn-primary" Text="Read" runat="server"  onclick="btnRead" /></td>--%>
      <td> 
          <div class="stars">  
    <input class="star star-1" ClientIDMode="static" runat="server" id="star16" type="radio" name="star" hidden/>
    <label class="star star-1" ClientIDMode="static" runat="server" for="star16"></label>
    <input class="star star-2" ClientIDMode="static" runat="server" id="star17" type="radio" name="star" hidden/>
    <label class="star star-2" ClientIDMode="static" runat="server" for="star17"></label>
    <input class="star star-3" ClientIDMode="static" runat="server" id="star18" type="radio" name="star" hidden/>
    <label class="star star-3" ClientIDMode="static" runat="server" for="star18"></label>
    <input class="star star-4" ClientIDMode="static" runat="server" id="star19" type="radio" name="star" hidden/>
    <label class="star star-4" ClientIDMode="static" runat="server" for="star19"></label>
    <input class="star star-5" ClientIDMode="static" runat="server" id="star20" type="radio" name="star" hidden/>
    <label class="star star-5" ClientIDMode="static" runat="server" for="star20"></label>
    </div>
      </td>
          <td><asp:Button class="btn btn-primary" Text="Submit" runat="server"  onclick="btnSubmit4" /></td>
    </tr>
    <tr>
      <th scope="row">5</th>
      <td id="doc5" runat="server"></td>
      <%--<td><asp:Button class="btn btn-primary" Text="Read" runat="server"  onclick="btnRead" /></td>--%>
      <td>
           <div class="stars">  
    <input class="star star-1" ClientIDMode="static" runat="server" id="star21" type="radio" name="star" hidden/>
    <label class="star star-1" ClientIDMode="static" runat="server" for="star21"></label>
    <input class="star star-2" ClientIDMode="static" runat="server" id="star22" type="radio" name="star" hidden/>
    <label class="star star-2" ClientIDMode="static" runat="server" for="star22"></label>
    <input class="star star-3" ClientIDMode="static" runat="server" id="star23" type="radio" name="star" hidden/>
    <label class="star star-3" ClientIDMode="static" runat="server" for="star23"></label>
    <input class="star star-4" ClientIDMode="static" runat="server" id="star24" type="radio" name="star" hidden/>
    <label class="star star-4" ClientIDMode="static" runat="server" for="star24"></label>
    <input class="star star-5" ClientIDMode="static" runat="server" id="star25" type="radio" name="star" hidden/>
    <label class="star star-5" ClientIDMode="static" runat="server" for="star25"></label>
    </div>
      </td>
        <td><asp:Button  class="btn btn-primary" Text="Submit" runat="server"  onclick="btnSubmit5" /></td>
    </tr>    
  </tbody>
</table>
            
            </div>
        <asp:Label id="lblStarVal" runat="server" Text="" ForeColor="#CC0000" />
<%--            </form>--%>
        </body>
</asp:Content>
