<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="BrowseLessons.aspx.cs" Inherits="BrowseLessons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>
    <!-- Custom styles for this template -->
    <link href="css/agency.min.css" rel="stylesheet">
    
    <style>
        body{
            margin: 0;
            padding:0;
            background-image: url(img/header-bg.jpg);
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

        
    
    <body> 
        <br />
    <br />
    <br />
    <br />
     <div class="container">  
      <div></div>
          <center>
              <h1 style="color:#fff;">Browse Lessons</h1>
              
              <br />
          </center>
          </div>       
        <center>
    <asp:TextBox ID="txtSearch" runat="server" class="form-control-sm" PlaceHolder="Lesson Name" Width="300px" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
    <asp:Button ID="btnSearch" runat="server" class="btn btn-secondary" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <br />
        </center>
        <center>
    <asp:TextBox ID="txtCat" runat="server" class="form-control-sm" PlaceHolder="Category Name" Width="300px" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
    <asp:Button ID="btnCat" runat="server" class="btn btn-secondary" Text="Search Category" OnClick="btnCatSearch_Click" />
    <br />
    <br />
    <br />
        </center>
    <asp:Label ID="noLessons" runat="server" forecolor="White" class="form-control-sm" Visible="false">There are currently no available lessons!</asp:Label>
    <asp:GridView ID="gvDocuments" CssClass="table-dark table-striped table-hover" runat="server"  AutoGenerateColumns="False" DataKeyNames="ID" HorizontalAlign="Center" Width="75%" AllowPaging="True" PageSize="100" CellPadding="10" >
       
        <AlternatingRowStyle />
        <Columns>
            <asp:TemplateField HeaderText="#">
                <ItemTemplate>
                    <%# Container.DataItemIndex+1 %>
                </ItemTemplate>
                <ControlStyle Width="1000px" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Lessons">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" CssClass="align-content-center"  runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                </ItemTemplate>
                <ControlStyle Width="35%" />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Document Category">
                <ItemTemplate>
                    <asp:Label ID="lblCategory1" runat="server" CssClass="align-content-center" Text='<%# Eval("DocumentCategory")%>'>
                </asp:Label>
                        </ItemTemplate>
                <ControlStyle Width="15%" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sub-Category 1">
                <ItemTemplate>
                    <asp:Label ID="lblCategory2" runat="server" CssClass="align-content-center" Text='<%# Eval("DocumentCategory2")%>'>
                </asp:Label>
                        </ItemTemplate>
                <ControlStyle Width="15%" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sub-Category 2">
                <ItemTemplate>
                    <asp:Label ID="lblCategory3" runat="server" CssClass="align-content-center" Text='<%# Eval("DocumentCategory3")%>'>
                </asp:Label>
                        </ItemTemplate>
                <ControlStyle Width="15%" />
            </asp:TemplateField>
        </Columns>
        <RowStyle />

        
    </asp:GridView>
     
    </body>
</asp:Content>