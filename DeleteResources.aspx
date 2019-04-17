﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DeleteResources.aspx.cs" Inherits="DeleteResources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>
    <html>
        <head>
<style type="text/css">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

  table {
  border-collapse: collapse;
  border-spacing: 0;
  width: 60%;
  border: 1px solid #ddd;
}
  h3{
      color: white;
      text-align:center;
  }

th, td {
  text-align: left;
  padding: 16px;
}

        body{
    background-image:url(img/header-bg.jpg);
}
        .btnRegister1
   {
    float: none;
    
    border: none;
    border-radius: 1.5rem;
    padding: 1%;
    background: #fed136;
    color: black;
    font-weight: 50;
    width: 20%;
    cursor: pointer;
    border:1px solid white;
}
    





</style>
        </head>
        <body>
    <form  id="DeleteResourceForm"  runat="server">
        <h3>Current Resource</h3>
    <br />
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table-dark table-hover" DataKeyNames="resourceID" DataSourceID="SqlDataSourceCurrentResources" AutoGenerateDeleteButton="True" HorizontalAlign="Center" >
    <Columns runat="server">
        <asp:BoundField DataField="resourceID" HeaderText="resourceID" InsertVisible="False" ReadOnly="True" SortExpression="resourceID" />
        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />        
        <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
        <asp:BoundField DataField="Hyperlink" HeaderText="Hyperlink" SortExpression="Hyperlink" />
    </Columns>
</asp:GridView>       

            <asp:SqlDataSource ID="SqlDataSourceCurrentResources" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringCurrentResources %>"  DeleteCommand= "DELETE FROM [Resources] WHERE [resourceID]=@resourceID;" SelectCommand="SELECT [resourceID], [title], [category], [Hyperlink] FROM [Resources]">
    <DeleteParameters>
        <asp:Parameter Name="resourceID" />
    </DeleteParameters>
    </asp:SqlDataSource>
            
        </form>



















            
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
        </body>

    </html>

</asp:Content>

