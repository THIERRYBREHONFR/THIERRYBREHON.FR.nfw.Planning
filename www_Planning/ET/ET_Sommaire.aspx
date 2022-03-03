<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ET_Sommaire.aspx.cs" Inherits="ET_Sommaire" %>

<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--#include file="../Commun/head.html" -->
    <link href="styles/ET.css" rel="stylesheet" type="text/css" />
    <link href="styles/ET_Web.css" rel="stylesheet" type="text/css" />
    <link href="styles/ET_Sommaire.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form0" runat="server">
        <ul class="ET_Sommaire_EntetePage">
            <li id="div_Summary" runat="server"><a href="../ET/ET_Sommaire.aspx?code=<%=IdAndCodeSession%>" title="Accueil">
                <i class="fas fa_home"></i>&nbsp;<img src="../ET/Images/Logo_Sommaire.JPG" alt="Accueil" title="Accueil" /></a></li>
            <li>
                <h1>
                    <TBfr:ET_Label ID="FTitrePage" runat="server" /></h1>
            </li>
            <li>
                <TBfr:ET_Button ID="FLogoutButton" ToolTip="Déconnexion" Text='<%# TemplateButtonText("IconLogoutButton",1)%>' ClientIDMode="Static" runat="server"></TBfr:ET_Button>
            </li>
            <li>
                <TBfr:ET_HyperLink ID="FReloginButton" ToolTip="Déconnexion" Text='<%# TemplateButtonText("IconReloginButton", 0)%>' ClientIDMode="Static" runat="server"></TBfr:ET_HyperLink>
            </li>
        </ul>
        <ul class="ET_Sommaire_Bonjour">
            <li>Bonjour           
                    <TBfr:ET_Label ID="Identite" runat="server" />. 
            </li>
            <li>Choisissez une des applications ci-dessous :</li>
        </ul>
        <ul class="ET_Sommaire_MenuPrincipal">
            <li id="Div_CO" runat="server"><a href="../CO/CO_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../CO/Images/logo_appli.JPG" alt="Copropriété" title="Copropriété" /></a></li>
            <li id="Div_TR" runat="server"><a href="../TR/TR_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../TR/Images/logo_appli.JPG" alt="Trésorerie" title="Trésorerie" /></a></li>
            <li id="Div_PL" runat="server"><a href="../PL/PL_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../PL/Images/logo_appli.JPG" alt="Planning" title="Planning" /></a></li>
            <li id="Div_SO" runat="server"><a href="../SO/SO_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../SO/Images/logo_appli.JPG" alt="Soirées" title="Soirées" /></a></li>
            <li id="Div_TA" runat="server"><a href="../TA/TA_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../TA/Images/logo_appli.JPG" alt="Travaux" title="Travaux" /></a></li>
            <li id="Div_PDJ" runat="server"><a href="../PDJ/PDJ_Sommaire.aspx?code=<%=IdAndCodeSession%>">
                <img src="../PDJ/Images/logo_appli.JPG" alt="Petit déj" title="Petit déj asynchrone" /></a></li>
        </ul>
        <TBfr:ET_ImageButton ID="default_btn" OnClientClick="return false;" CssClass="ET_pseudobutton" ClientIDMode="Static" runat="server" />
    </form>
</body>
</html>
