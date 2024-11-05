<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="WebApplication1.start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Deklaracja</title>
</head>
<body>
     <form runat="server" id="Form1">
         <h2>Deklaracja</h2>

        <div>
            <label>Imię i nazwisko:</label>
            <input type="text" name="name" required placeholder="Imię i nazwisko" />
        </div>
        <div>
            <label>Data:</label>
            <input type="date" name="date" required />
        </div>
        <div>
            <label>Nazwa zajęć:</label>
            <input type="text" name="subject" required placeholder="Nazwa zajęć" />
        </div>
        <div>
            <label>Numer zestawu:</label>
            <input type="text" name="ListNumber" required placeholder="Numer zestawu" />
        </div>


        <h3>Zadania:</h3>
        <% for (int i = 1; i <= 10; i++) { %>
            <div>
                <label>Zadanie <%= i %>:</label>
                <input type="number" name="task<%= i %>" min="0" max="8" value="0"/>
            </div>
        <% } %>

        <button>Wyślij</button>
    </form>
</body>
</html>
