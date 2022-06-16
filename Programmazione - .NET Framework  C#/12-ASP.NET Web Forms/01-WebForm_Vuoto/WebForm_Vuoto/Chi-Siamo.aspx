<%@ Page Title="Chi Siamo" Language="C#" AutoEventWireup="true" CodeBehind="Chi-Siamo.aspx.cs" Inherits="WebForm_Vuoto.Chi_Siamo" %>

<%@ Register Src="~/webcontrols/Navbar.ascx" TagPrefix="uc1" TagName="Navbar" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Chi Siamo</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Navbar runat="server" id="Navbar" />

        <div>
            <h1>Chi siamo</h1>
        </div>
    </form>
</body>
</html>
