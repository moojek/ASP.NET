<%@ Page Language="C#" CodeBehind="index.aspx.cs" Inherits="Z7.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
</head>
<body>
<form id="HtmlForm" runat="server" enctype="multipart/form-data">
    <div>
        <input type="file" id="fileId" name="fileName"/>
        <button type="submit">Upload</button>
    </div>
</form>
</body>
</html>