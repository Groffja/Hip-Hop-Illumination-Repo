<%@ Page Title="" Language="C#" MasterPageFile="AdminMasterPage.master" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style>
        body {
            margin: 0;
            padding: 0;
            background-image: url(img/header-bg.jpg);
        }

        .search-box {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            background-color: gray;
            height: 40px;
            border-radius: 40px;
            padding: 10px;
        }

            .search-box:hover > .search-txt {
                width: 240px;
                padding: 0 6px;
            }

            .search-box:hover > .search-btn {
                background: white;
            }

        .search-btn {
            color: gold;
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

        .btnRegister {
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

        .btn-secondary {
            background-color: #fed136;
        }
    </style>


    <form id="form2" runat="server">

        <center>
              <h1 style="color:#fff;">Feedback</h1>
              
        
    <asp:Panel ID="panel2" runat="server"  DefaultButton="btnSearch">
    <asp:TextBox ID="txtSearch" runat="server" class="form-control-sm" Width="300px"  Placeholder="Search By Comment" ></asp:TextBox>
         <asp:Button ID="btnSearch" runat="server" class="btn btn-secondary" Text="Search" OnClick="btnSearch_Click" />
                 </asp:Panel>          
   
              
              <br />

            <asp:Panel ID="panel1" runat="server"  DefaultButton="btnSearchUsername">
            <asp:TextBox ID="TxtSearchUsername" runat="server" class="form-control-sm" Width="300px" Placeholder="Search By Username" ></asp:TextBox>
                <asp:Button ID="btnSearchUsername" runat="server" class="btn btn-secondary" Text="Search" OnClick="btnSearchUsername_Click" />
               </asp:Panel>
           
    
              
              <br />
          </Center>
    
    
    <br />
       
    
        <asp:GridView ID="GridView2" CssClass="table-dark table-striped table-hover" runat="server" HorizontalAlign="Center" Width="75%" AllowPaging="True" PageSize="100" CellPadding="10"  AutoGenerateColumns="False" DataSourceID="SqlDataSourceFeedback">

            <Columns>
                <asp:BoundField DataField="accountID" HeaderText="Account ID" SortExpression="accountID" />
                <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField DataField="comment" HeaderText="Topic - Comment" SortExpression="comment" />
            </Columns>










        </asp:GridView>



        <%-- <asp:SqlDataSource ID="SqlDataSourceFeedback" runat="server" ConnectionString="manageUsers" SelectCommand="SELECT Feedback.accountID, LoginInfo.username, LoginInfo.email, Feedback.comment FROM Feedback INNER JOIN LoginInfo ON Feedback.accountID = LoginInfo.accountID"--%>





     <asp:SqlDataSource ID="SqlDataSourceFeedback" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringFeedback %>" SelectCommand="SELECT Feedback.accountID, LoginInfo.username, LoginInfo.email, Feedback.comment FROM LoginInfo INNER JOIN Feedback ON LoginInfo.accountID = Feedback.accountID"></asp:SqlDataSource>


    
    
    

        <asp:SqlDataSource ID="SqlDataSourceFeedbackSearch" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionString2 %>" SelectCommand="
  SELECT        Feedback.accountID, LoginInfo.username,  Feedback.comment
  FROM            Feedback INNER JOIN
                         LoginInfo ON Feedback.accountID = LoginInfo.accountID
  WHERE   ([comment] LIKE '%' + @comment + '%')">
            <SelectParameters>
                <asp:SessionParameter Name="comment" SessionField="test" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

    
    
    
    
        <br />
       
                <asp:SqlDataSource ID="SqlDataSourceUsernameSearch" runat="server" ConnectionString="<%$ ConnectionStrings:hhidatabaseConnectionStringDanDaMan %>" SelectCommand="
  SELECT        Feedback.accountID, LoginInfo.username,  Feedback.comment
  FROM            Feedback INNER JOIN
                         LoginInfo ON Feedback.accountID = LoginInfo.accountID
 WHERE ([username] LIKE '%' + @username + '%')">
            <SelectParameters>
                <asp:SessionParameter Name="username" SessionField="username" DefaultValue="" />
            </SelectParameters>
        </asp:SqlDataSource>
        
    
    

    </form>
</asp:Content>
