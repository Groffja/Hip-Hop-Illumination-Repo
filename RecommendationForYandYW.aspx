<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="RecommendationForYandYW.aspx.cs" Inherits="RecommendationForYandYW" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html>
    <html>
        <head>
            <style type="text/css">
                body{
            margin: 0;
            padding:0;
            background-image: url(img/header-bg.jpg);
        }
.btnRegister
   {
    float: left;
    margin-top: 8%;
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    background: #fed136;
    color: black;
    font-weight: 600;
    width: 40%;
    cursor: pointer;
    border:1px solid white;
}
.marginZero{
    margin:0;
    padding:0;
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
<div class="row d-block mx-auto">
    <div class="col d-block mx-auto">
        <div class="row"> 
        <div class="form-group col-4">
        <asp:Button ID="btnSeeData" runat="server" OnClick="btnSeeData_Click" Text="See Recommendation" class="btnRegister"/>
        <asp:TextBox ID="test" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" class="align-content-center" runat="server" Width="400px"></asp:Label>
            </div>
            </div>
<%--            <div class="row"> 

            <div class="form-group col-3 d-block mx-auto">
            <asp:Label ID="Label1" runat="server" Text="Recommendation For You" ForeColor="white"></asp:Label>

            </div>
                 
            </div>--%>

        <div class="row d-block mx-auto"> 
            <div class="col d-block mx-auto"
    <asp:GridView ID="GridView1" runat="server" class="table-dark table-striped table-hover marginZero" Width="100%" AllowPaging="True" PageSize="100" CellPadding="10" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Document Name" SortExpression="Name"/>
            <asp:BoundField DataField="recommendedBy" HeaderText="Recommended By" SortExpression="recommendedBy" />
            <asp:BoundField DataField="dateRecommended" HeaderText="Date Recommended" SortExpression="dateRecommended" />
        </Columns>
    </asp:GridView>
                </div>
            </div>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringRecommendation %>" SelectCommand="SELECT Documents.Name, Recommendations.recommendedBy, Recommendations.dateRecommended FROM Documents INNER JOIN Recommendations ON Documents.ID = Recommendations.documentID WHERE RecieverAccountID = @recieverAccountID">

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
