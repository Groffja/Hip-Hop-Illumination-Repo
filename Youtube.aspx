<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Youtube.aspx.cs" Inherits="Youtube" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    <!DOCTYPE html>
    
<html>
<head >
    <style type="text/css">
        body {
            background-image: url(http://localhost:65108/img/header-bg.jpg);
            color:white;
        }


    </style>
    <title>Hip Hop IllumiNation.com</title>
</head>
<body>
    
    <center>

    
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <div class="form-group">
        <asp:Label ID="Label2" runat="server" Text="URL "  Width="10%"></asp:Label>
            <asp:textbox ID="url" runat="server" class="form-control" required="true" Width="20%" />
        <br />
                        </div>
         <div class="form-group">
        <asp:Label ID="Label3" runat="server" Text="Category " Width="10%"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server" class="form-control" required="true" Width="20%"></asp:TextBox>
        <br />
              </div>

<div class="form-group">
        <asp:Label ID="Label4" runat="server"  Text="Title " Width="10%"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" class="form-control" required="true" Width="20%"></asp:TextBox>
        <br />
    </div>

                    <div class="form-group">
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning" OnClick="Button1_Click" Text="Save" Width="10%" Enabled="false" />
        <asp:Button ID="Button2" runat="server" CssClass="btn btn-warning" OnClick="Button2_Click" Text="Check URL" Width="10%" />
 </div>
                    <asp:Label ID="Label5" runat="server" Width="25%"></asp:Label>
        <br />
        
    
    
    <center>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" CssClass="table-dark table-hover align-content-center" width="90%" AutoGenerateColumns="False" DataSourceID="SqlDataSource123">
                <Columns>
                    <asp:BoundField DataField="title" HeaderStyle-CssClass="align-content-center" ControlStyle-Width="15%" HeaderText="Title" SortExpression="title" />
                    <asp:BoundField DataField="category" HeaderStyle-CssClass="align-content-center" ControlStyle-Width="15%" HeaderText="Category" SortExpression="category" />
                    <asp:BoundField DataField="Hyperlink" HeaderStyle-CssClass="align-content-center" ControlStyle-Width="60%" HeaderText="Hyperlink" SortExpression="Hyperlink" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource123" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionString2 %>" SelectCommand="SELECT [title], [category], [Hyperlink] FROM [Resources]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="gvDocuments" CssClass="table-dark table-striped table-hover" runat="server"  AutoGenerateColumns="False" DataKeyNames="resourceID" HorizontalAlign="Center" Width="100%" AllowPaging="True" PageSize="100" CellPadding="10" Visible="false" >
       
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
                    <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" CssClass="align-content-center"  runat="server" Text='<%# Eval("Hyperlink") %>'></asp:LinkButton>
                </ItemTemplate>
                <ControlStyle Width="35%" />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Document Category">
                <ItemTemplate>
                    <asp:Label ID="lblCategory1" runat="server" CssClass="align-content-center" Text='<%# Eval("category")%>'>
                </asp:Label>
                        </ItemTemplate>
                <ControlStyle Width="15%" />
            </asp:TemplateField>
            
        </Columns>
        <RowStyle />

        
    </asp:GridView>
            
        
        
        </div>
            </center>
            </div>
        </div>

            </div>
    </form>
        </center>
</body>
</html>
</asp:Content>

