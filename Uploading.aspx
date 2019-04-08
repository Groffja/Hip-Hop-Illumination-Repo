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
  border: 1px solid #ddd;
    </style>

<body>
    <form id="form1" runat="server">
        <center>
            
            <br />
            <h3>Upload a Lesson</h3>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Document: " ForeColor="White" Width="100px"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="White" Width="300px" />
            <br />
            <br />
            <p>
                
                <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Category:" Width="100px"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="206px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="92px" />
            </p>
            <br />
            <asp:GridView  visible="false" ID="gvDocuments" runat="server" AutoGenerateColumns="False" OnRowDeleting="Row_Deleting"  DataKeyNames="ID" OnSelectedIndexChanged="gvDocuments_SelectedIndexChanged">
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




        <asp:Table>
        <asp:GridView ID="GridView2" runat="server" width="100%" AutoGenerateColumns="False" CssClass="table-dark table-striped table-hover" DataKeyNames="ID" DataSourceID="SqlDataSource1" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="DocumentCategory" HeaderText="DocumentCategory" SortExpression="DocumentCategory" />
            </Columns>
        </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:lessonGridview %>"  SelectCommand="SELECT [ID], [Name], [DocumentContent], [DocumentCategory] FROM [Documents]"></asp:SqlDataSource>
    </asp:Table>
            </center>
    </form>
</body>
</html>
</asp:Content>

