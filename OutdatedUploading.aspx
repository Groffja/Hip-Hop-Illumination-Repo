<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OutdatedUploading.aspx.cs" Inherits="Uploading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Document: "></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
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




        
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table-dark table-hover" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:TemplateField HeaderText="Name" SortExpression="Name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:lessonGridview %>"  SelectCommand="SELECT [ID], [Name], [DocumentContent] FROM [Documents]"></asp:SqlDataSource>
    
    </form>
</body>
</html>

