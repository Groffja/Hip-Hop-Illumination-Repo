<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="RecommendationForYandYW.aspx.cs" Inherits="RecommendationForYandYW" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>
    <html>
        <head>
            <style type="text/css">
                body{

            background-image: url(img/header-bg.jpg);
        }
.marginZero{
    margin:0;
    padding:0;
}
h1{
    color:white;
}
.btnSee{
    margin-top: 2%;
    border: none;
    border-radius: 1.5rem;
    background: #fed136;
    color: black;
    font-weight: 600;
    width: 200px;
    cursor: pointer;
    border:1px solid white;
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
            <form id="recommendationForMeForm" method="post">
                 <center>
                     <h1>Recommendations for You</h1>
                      <asp:Button ID="btnSeeData" runat="server" OnClick="btnSeeData_Click" Text="See Recommendation" class="btnSee"/>
                     </center>
               
<div class="row d-block mx-auto">
    <div class="col d-block mx-auto">
        <div class="row "> 
        <div class="form-group col-4">

        

        <asp:TextBox ID="test" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" class="align-content-center" runat="server" Width="400px"></asp:Label>
            </div>
            </div>
        

        <div class="row d-block mx-auto"> 
            <div class="col d-block mx-auto"

    <asp:Label ID="noLessons" runat="server" forecolor="White" class="form-control-sm" Visible="false">You currently have no Recommendations!</asp:Label>
    
        <Center>

        
        <asp:GridView ID="GridView1" runat="server" class="table-dark table-striped table-hover marginZero" HorizontalAlign="Center" Width="75%" AllowPaging="True" PageSize="100" CellPadding="10" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <AlternatingRowStyle /> 
        <Columns>
            
            <asp:BoundField DataField="Name" HeaderText="Lesson" SortExpression="Name"/>
            <asp:BoundField DataField="DocumentCategory" HeaderText="Category" SortExpression="DocumentCategory"/>
            <asp:BoundField DataField="recommendedBy" HeaderText="Sender Username" SortExpression="recommendedBy" />
            <asp:BoundField DataField="dateRecommended" HeaderText="Date Recieved" SortExpression="dateRecommended" />
        </Columns>
        <RowStyle />
    </asp:GridView>
       </Center>        

                </div>
            </div>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringRecommendation %>" SelectCommand="SELECT Documents.Name, Documents.DocumentCategory, Recommendations.recommendedBy, Recommendations.dateRecommended FROM Documents INNER JOIN Recommendations ON Documents.ID = Recommendations.ID WHERE accountID = @recieverAccountID">

                <SelectParameters>
    <asp:ControlParameter ControlID="test" Name="recieverAccountID" PropertyName="Text" Type="String" Defaultvalue=""  />
    </SelectParameters>
        </asp:SqlDataSource>

        
            <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    
    </div>
    </div>
 
                </form>
    </body>
    </html>



</asp:Content>
