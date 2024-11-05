<%@ Page Language="C#" CodeBehind="index.aspx.cs" Inherits="Z1.index" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        <a href="strona.aspx?p1=v1&p2=v2">żądanie GET</a>
    </div>
    <div>
        <form method="post">
            <input type="text" name="p1"/>
            <input type="text" name="p2"/>
            <input type="submit" value="żądanie POST"/>
        </form>
    </div>
    <div>
        <h3><%= new StreamReader(Request.InputStream).ReadToEnd()%></h3>
    </div>
    <div>
        <a href onclick="aPost()">żądanie POST</a>
    </div>
    <div>
        <form id="form2" method="post">
            <input type="text" name="p1"/>
            <input type="text" name="p2"/>
            <input onclick="formGet()" value="żądanie GET"/>
        </form>
    </div>
</form>
<script>
function aPost() {
  const form = document.getElementById("form2");
  form.submit();
}
function formGet() {
    document.location.href="strona.aspx?p1=v1&p2=v2";
}
</script>
</body>
</html>