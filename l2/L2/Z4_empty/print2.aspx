<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="print2.aspx.cs" Inherits="Z4_empty.print2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Do druku</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Deklaracja</h2>
        <table border="1">
            <tr>
                <th>Imię i nazwisko</th>
                <td><%= Session["name"] %></td>
            </tr>
            <tr>
                <th>Data</th>
                <td><%= Session["date"] %></td>
            </tr>
            <tr>
                <th>Nazwa zajęć</th>
                <td><%= Session["subject"] %></td>
            </tr>
            <tr>
                <th>Numer zestawu</th>
                <td><%= Session["ListNumber"] %></td>
            </tr>
            <tr>
                <th>Zadanie</th>
                <th>Punkty</th>
            </tr>
            <% for (int i = 1; i <= 10; i++)
                { %>
            <tr>
                <td>Zadanie <%= i %></td>
                <td><%= Session["task" + i] %></td>
            </tr>
            <% } %>
        </table>
    </form>
</body>
</html>
