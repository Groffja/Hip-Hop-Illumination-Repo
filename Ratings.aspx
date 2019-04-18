﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Ratings.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body{

    background-image:url(img/header-bg.jpg);
}
        .search-box{
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            background-color: gray;
            height: 40px;
            border-radius:40px;
            padding: 10px;
        }
        .search-box:hover > .search-txt{
            width: 240px;
            padding: 0 6px;
        }
         .search-box:hover > .search-btn{
            background: white;
        }
        .search-btn{
            color:gold;
            float: right;
            width: 40px;
            height: 40px;
            border-radius: 50%;
            background-color: white;
            display: flex;
            justify-content: center;
            align-items: center;
            transition: 0.4s;
        }
        .search-txt {
            border: none;
            background: none;
            outline: none;
            float: left;
            padding: 0;
            color: white;
            font-size: 16px;
            transition: 0.4s;
            line-height: 40px;
            width: 0px;
        }

            .btnRegister
                {
    float: right;
    margin-top: 8%;
    border: none;
    border-radius: 1.5rem;
    padding: 2%;
    background: black;
    color: white;
    font-weight: 600;
    width: 50%;
    cursor: pointer;
}
            
        .btn-secondary
   {
    
    background-color:#fed136;
}

    </style>
    
    <form id="form2" runat="server">
     <center>
        <h2 style="color:white;">Lesson Ratings
            
            </h2>
         <br />
        <asp:TextBox ID="txtSearchbar" runat="server" class="form-control-sm"  Placeholder="Search Lesson" Width="20%"></asp:TextBox>
        
        
        <asp:Button ID="btnSearchbar" runat="server" class="btn btn-secondary" Text="Search" OnClick="btnSearch_Click" Width="10%" />
        
            <br />
         <br />
         <br />
         
        <asp:GridView ID="ratingGridView1" runat="server"  AutoGenerateColumns="False" CssClass="table-dark table-hover" AutoGenerateDeleteButton="True" DataKeyNames="RatingID" DataSourceID="SqlDataSourceRating" CellSpacing="5" Height="175%" Width="90%" CellPadding="2">
            <Columns>
                
                <asp:BoundField DataField="RatingID" HeaderText="RatingID" InsertVisible="False" ReadOnly="True" SortExpression="RatingID" />
                <asp:BoundField DataField="Lesson" HeaderText="Lesson" SortExpression="Lesson" />
                <asp:BoundField DataField="Rating" HeaderText="Rating" SortExpression="Rating" />
                <asp:BoundField DataField="Comment" HeaderText="Comment" SortExpression="Comment" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                 
            </Columns>
        </asp:GridView>
            
        <asp:SqlDataSource ID="SqlDataSourceRating" runat="server" ConnectionString="<%$ ConnectionStrings:maxRatingsconnstring %>" SelectCommand="SELECT        Ratings.ratingID as RatingID, Documents.Name as Lesson, Ratings.rating as Rating, Ratings.comment as Comment, LoginInfo.username as Username
FROM            Documents INNER JOIN
                         Ratings ON Documents.ID = Ratings.ID INNER JOIN
                         LoginInfo ON Ratings.accountID = LoginInfo.accountID" DeleteCommand="DELETE FROM [dbo].[Ratings] WHERE ratingID = @RatingID">
            <DeleteParameters>
                <asp:Parameter Name="RatingID" />
            </DeleteParameters>
        </asp:SqlDataSource>
        </center>
    </form>
</asp:Content>

