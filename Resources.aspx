<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="Resources.aspx.cs" Inherits="Resources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style>
        body {
            background-image: url(img/header-bg.jpg);
            background-size: 100%;
            color: white;
        }

        .btnRegister {
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
            border: 1px solid white;
        }
    </style>
    <center>
    <br/>
    <br/>
    <br/>
    
    <br/>
    <br/>
    <h3> Resources Just For You!</h3>
    <br/>
    <br/>
        <asp:Panel ID="panel2" runat="server"  DefaultButton="btnSearch">
    <asp:TextBox ID="txtSearch" runat="server" class="form-control-sm" Width="300px"  Placeholder="Search By Title" ></asp:TextBox>
            </asp:Panel>
    <asp:Button ID="btnSearch" runat="server" class="btn btn-secondary" Text="Search" OnClick="btnSearch_Click" />
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    <br/>
    
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" CssClass="table-dark table-striped table-hover" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="60%" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="60px">
        <Columns>            
            <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="btn btn-primary" />
            <asp:BoundField DataField="title" HeaderText="Title" SortExpression="title" />
            <asp:BoundField DataField="category" HeaderText="Category" SortExpression="category" />
            <asp:BoundField DataField="Hyperlink" HeaderText="Website" SortExpression="Hyperlink"  />                 
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringResources %>" SelectCommand="SELECT [title], [category], [Hyperlink] FROM [Resources]"></asp:SqlDataSource>
    </center>





</asp:Content>
