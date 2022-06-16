<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_Vuoto.Default" %>

<%@ Register Src="~/webcontrols/Navbar.ascx" TagPrefix="uc1" TagName="Navbar" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
        <uc1:Navbar runat="server" id="Navbar" />


        <div>
            <p>Benvenuto nella mia prima applicazione web ASP.NET Web Forms</p>
        </div>


        <asp:Label ID="lblTesto" runat="server" Text="Inserisci un testo: "></asp:Label>

        <asp:TextBox ID="txtTesto" runat="server"></asp:TextBox>

        <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" 
            OnClientClick="return confirm('Ciao Luciano! Vuoi continuare?');"  />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblRisultato" runat="server" Text=""></asp:Label>

        <br /><br />
        <p>Uso di link</p>
        <a href="Chi-Siamo.aspx">Chi siamo</a>
        <br />
        <asp:HyperLink ID="hlk" runat="server" NavigateUrl="~/Chi-Siamo.aspx">Chi siamo</asp:HyperLink>

        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/CILIEGIe.jpg.jpg" CssClass="img"/>

        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="img" ImageUrl="~/images/Coltivazione-biologica-della-fragola.jpg" PostBackUrl="~/Chi-Siamo.aspx" />

        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <br /><br />
        <img alt="" src="images/CILIEGIe.jpg.jpg" class="img" />
    </form>
</body>
</html>
