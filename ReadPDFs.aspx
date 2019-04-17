<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReadPDFs.aspx.cs" Inherits="ReadPDFs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select Your PDF"></asp:Label>
            <br />
            <asp:GridView ID="gvDocuments" runat="server" AutoGenerateColumns="False" DataKeyNames="ID">
                <Columns>
                    <asp:TemplateField HeaderText="Document ID">
                        <ItemTemplate>
                            <%# Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Documents">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" OnClick="OpenDocument" runat="server" Text='<%# Eval("Name") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
