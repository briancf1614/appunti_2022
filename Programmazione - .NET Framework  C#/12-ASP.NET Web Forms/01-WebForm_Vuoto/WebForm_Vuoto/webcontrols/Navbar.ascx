<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="WebForm_Vuoto.webcontrols.Navbar" %>

<div class="navbar">
            <div class="navbar-item">
                <asp:HyperLink ID="lnkHome" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
            </div>
            <div class="navbar-item">
                <asp:HyperLink ID="lnkChiSiamo" runat="server" NavigateUrl="~/Chi-Siamo.aspx">Chi siamo</asp:HyperLink>
            </div>
            <div class="navbar-item">
                <asp:HyperLink ID="lnkContatti" runat="server" NavigateUrl="~/Contatti.aspx">Contatti</asp:HyperLink>
            </div>
        </div>