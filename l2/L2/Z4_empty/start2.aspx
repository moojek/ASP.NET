<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start2.aspx.cs" Inherits="Z4_empty.start2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" id="Form1">
        <h2>Deklaracja</h2>

        <div>
            <label>Imię i nazwisko:</label>
            <input type="text" name="name" required="required" placeholder="Imię i nazwisko" />
        </div>
        <div>
            <label>Data:</label>
            <input type="date" name="date" required="required" />
        </div>
        <div>
            <label>Nazwa zajęć:</label>
            <input type="text" name="subject" required="required" placeholder="Nazwa zajęć" />
        </div>
        <div>
            <label>Numer zestawu:</label>
            <input type="text" name="ListNumber" required="required" placeholder="Numer zestawu" />
        </div>


        <h3>Zadania:</h3>
        <% for (int i = 1; i <= 10; i++)
            { %>
        <div>
            <label>Zadanie <%= i %>:</label>
            <input type="number" name="task<%= i %>" min="0" max="8" value="0" />
        </div>
        <% } %>

        <button>Wyślij</button>
    </form>
</body>
</html>
