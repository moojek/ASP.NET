<%@ Page Language="C#" CodeBehind="strona.aspx.cs" Inherits="Z1.strona" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Strona</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <h2>Querystring:</h2>
        <h3>p1 = <%= Request.QueryString["p1"]%></h3>
        <h3>p2 = <%= Request.QueryString["p2"]%></h3>
        <h2>Body:</h2>
        <h3><%= new StreamReader(Request.InputStream).ReadToEnd()%></h3>
    </div>
</form>
</body>
</html>