<%@ Page Title="" Language="C#" MasterPageFile="MasterPageLoggedIn.master" AutoEventWireup="true" CodeFile="YourLessons.aspx.cs" Inherits="YourLessons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body{
        padding-top: 50px !important;
        margin: 10px;
        background: url(img/header-bg.jpg);
        background-size: 1440px 800px; 
        overflow-y: scroll;
        padding-left: 50px;
        }
    </style>

    <head>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
  
        <div>
            <asp:GridView ID="LessonsGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" DataKeyNames="ID" AllowSorting="True" CssClass="grid-view" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Document ID">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                       
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
         
                    <asp:BoundField DataField="dateStarted" HeaderText="Date Started" SortExpression="dateStarted" />
                    <asp:TemplateField HeaderText="Link">
                             
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>           
                            
                
                    
                 
                
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#3C3C3C" Font-Bold="True" ForeColor="Yellow" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=localhost;Initial Catalog=hhidatabase;Integrated Security=True" SelectCommand="SELECT        Documents.ID, Documents.Name, Documents.Extn, LessonYouth.dateStarted
                                    FROM            Documents INNER JOIN
                                    LessonYouth ON Documents.ID = LessonYouth.ID" ProviderName="System.Data.SqlClient"></asp:SqlDataSource>
&nbsp;&nbsp;
            
            <br />
            <br />
            
        </div>
    
</body>


</asp:Content>