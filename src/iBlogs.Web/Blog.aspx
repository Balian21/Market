<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="iBlogs.Web.Blog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="UserName" runat="server" Text="Здесь должен быть Login юзера"></asp:Label>
        <asp:DataList ID="UserArticles" runat="server"></asp:DataList>
    </div>
    </form>
</body>
</html>
