<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Landing.aspx.cs" Inherits="Landing" %>

<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--#include file="../Commun/head.html" -->
    <link href="../commun/styles/meyer.css" rel="stylesheet" type="text/css" />
    <link href="../commun/styles/THIERRYBREHON.FR.css" rel="stylesheet" type="text/css" />
    <link href="../commun/styles/login.css" rel="stylesheet" type="text/css" />
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
            <li class="Construction">Site public en cours de développement.</li>
            <li><a href="../ET/ET_Sommaire.aspx?code=<%=IdAndCodeSession%>" title="Accès privé">Accès privé</a></li>
        </ul>
        <TBfr:ET_ImageButton ID="default_btn" OnClientClick="return false;" CssClass="ET_pseudobutton" ClientIDMode="Static" runat="server" />
    </form>
</body>
</html>
