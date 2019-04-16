<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="RecommendationPage.aspx.cs" Inherits="RecommendationPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>
    
    <html>
    <head>
        <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <style type="text/css">
        section{
        padding-top: 50px !important;
        margin: 10px;
        background: url(img/header-bg.jpg);
        background-size: 1440px 800px; 
        overflow-y: scroll;
        padding-left: 50px;
    }
body{
            margin: 0;
            padding:0;
            background-image: url(img/header-bg.jpg);
            color: white;
        }
.btnRegister
   {
    float: right;
    margin-top: 8%;
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    background: #fed136 ;
    color: black;
    font-weight: 600;
    width: 30%;
    cursor: pointer;
    border:1px solid white;
}
.smallStyle{
    color:white;
}

    </style>
        
        
    </head>
        
    <body>
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
        <center><h1>Recommend a Lesson</h1></center>
    <form id="recommendation" method="post">
      
        <div class="row d-block mx-auto">
            <div class="col-4 d-block mx-auto">
                <div class="form-group ">
                                    <br />
        <br />
                                    <asp:TextBox ID="TextBox1" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        <br />
<%--                <asp:Label ID="Label1" runat="server" ></asp:Label>--%>
             <asp:Label ID="Label1" runat="server" Text="Email" ForeColor="White"></asp:Label>
             <br />
             <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" class="form-control"></asp:TextBox>
<%--             <small id="emailTip" class="form-text text-muted smallStyle">Please enter the receiver's email.</small>--%>
             </div>

             <br />


        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Your Recommendation" ForeColor="White"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlRecommendation" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID" CssClass="form-control"></asp:DropDownList>            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringRec %>" SelectCommand="SELECT  Documents.ID, Documents.Name FROM Documents">
<%--                <SelectParameters>
            <asp:ControlParameter ControlID="TextBox1" Name="accountID" PropertyName="Text" Type="String" Defaultvalue=""  />
            </SelectParameters>--%>
            </asp:SqlDataSource>            
            
            <br />
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" class="btnRegister"/>
            </div>
                </div>
            </div>

      </form>








            <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
        </body>
        </html>
    </asp:Content>