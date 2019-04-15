<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Uploading.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!DOCTYPE html>

<html>
    <style>
body{
    background-image:url(img/header-bg.jpg);
}
h3{
      color: white;
  }
table {
            border-collapse: collapse;
            border-spacing: 0;
            width: 100%;
            border: 1px solid #ddd yellow;
        }
/*#c1{
    float:left;
}*/


/*#c2{
    position:relative;
    float:right;
}*/      

    </style>

<body>
    <form id="form1" runat="server">

                    <div class="container">
                <div class="row">
                    <div class="col-6">



            <div class="container" id="c1">
                <div class="row">
                    <div class="col">
            <center>
                <h3>Upload a Lesson</h3>
                </center>
                <br />
                <br />

                <asp:Label ID="Label1" runat="server" Text="Document: " ForeColor="White" Width="150px" Height="50px"></asp:Label>
                <asp:FileUpload Class="btn btn-outline-warning" ID="FileUpload1" runat="server" ForeColor="White" Width="300px" Height="45px" />

                <br />
                <br />

                
                <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Category:" Width="150px" Height="50px"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="300px" Height="30px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblCat2" runat="server" ForeColor="White" Text="Subcategory:" Width="150px" Height="50px"></asp:Label>
                <asp:TextBox ID="txtCat2" runat="server" Width="300px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblCat3" runat="server" ForeColor="White" Text="Subcategory:" Width="150px" Height="50px"></asp:Label>
                <asp:TextBox ID="txtCat3" runat="server" Width="300px"></asp:TextBox>

            <br />
            <br />
                <center>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="92px" Class="btn btn-outline-warning" Height="40px"/>
    </center>
                        <br />

            <br />


            <asp:GridView  visible="false" ID="gvDocuments" runat="server" AutoGenerateColumns="False" OnRowDeleting="Row_Deleting"  DataKeyNames="ID" OnSelectedIndexChanged="gvDocuments_SelectedIndexChanged" CellPadding="10" PageSize="5">
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            </div>
            </div>
            </div>

        <asp:Table>

        <asp:GridView ID="GridView2" runat="server" width="30%"  AutoGenerateColumns="False" CssClass="table-dark table-striped table-hover" DataKeyNames="ID" DataSourceID="SqlDataSource1" AllowSorting="True" CellPadding="10">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="DocumentCategory" HeaderText="Document Category" SortExpression="DocumentCategory" />
                <asp:BoundField DataField="DocumentCategory2" HeaderText="Subcategory" SortExpression="DocumentCategory2" />
                <asp:BoundField DataField="DocumentCategory3" HeaderText="Subcategory" SortExpression="DocumentCategory3" />
            </Columns>
        </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:lessonGridview %>"  SelectCommand="SELECT [ID], [Name], [DocumentContent], [DocumentCategory],[DocumentCategory2],[DocumentCategory3] FROM [Documents]"></asp:SqlDataSource>
    </asp:Table>


                                                </div>
                    <div class="col-6">

              <div class="container" id="c2">
                <div class="row">
                    <div class="col">
     


<center>
            <h3>Upload a Resource</h3>
    </center>
                        <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Resource URL:" ForeColor="White" Width="150px" Height="50px"></asp:Label>
            <asp:Textbox ID="hyperlink" runat="server" Width="300px" />
            <br />
            <br />
            <asp:Label ID="title" runat="server" Text="Resource Title" ForeColor="White" Width="150px" Height="50px"></asp:Label>
            <asp:Textbox ID="txtTitle" runat="server" Width="300px" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="    Category:" ForeColor="White" Width="150px" Height="50px"></asp:Label>
            <asp:Textbox ID="category" runat="server" Width="300px" />
                        <br />
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server" Height="50px" Visible="False"></asp:TextBox>
                        <br />
            <br />
                        <center>
            <asp:Button ID="save" runat="server" onclick="save_Click" Text="Save" Width="92px" Class="btn btn-outline-warning" Height="40px"/>
                        </center>
            <br />
                        <br />
                        <br />
            <br />

    <asp:GridView ID="GridView3" runat="server" autoPostback="True" Width="30%" AutoGenerateColumns="False" CssClass="table-dark table-striped table-hover"  AllowSorting="True" CellPadding="10" DataKeyNames="resourceID" DataSourceID="SqlDataSourceResources">
        <Columns>
            <asp:BoundField DataField="resourceID" HeaderText="resourceID" InsertVisible="False" ReadOnly="True" SortExpression="resourceID" />
            <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
            <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
            <asp:BoundField DataField="Hyperlink" HeaderText="Hyperlink" SortExpression="Hyperlink" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSourceResources" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringResources %>" SelectCommand="SELECT [resourceID], [title], [category], [Hyperlink] FROM [Resources]"></asp:SqlDataSource>
</div>
                    </div>
</div>
</div>
                        </div>
</div>

    </form>
</body>
</html>
</asp:Content>

