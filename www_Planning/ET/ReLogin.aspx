<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReLogin.aspx.cs" Inherits="ReLogin" %>

<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width" />
    <title></title>
    <link href="../commun/styles/meyer.css" rel="stylesheet" type="text/css" />
    <link href="../commun/styles/THIERRYBREHON.FR.css" rel="stylesheet" type="text/css" />
    <link href="../commun/styles/login.css" rel="stylesheet" type="text/css" />
    <%--    <link href="Commun/Styles/25ET.css" rel="stylesheet" type="text/css" />
    <script src="../Commun/Scripts/responsive.js" type="text/javascript"></script>--%>
</head>
<body>
    <div class="conteneur_principal">
        <form id="form1" runat="server">
            <ul>
                <li>
                    <TBfr:ET_Image runat="server" ImageUrl="../Commun/Images/LOGO complet 500.jpg" AlternateText="Logo THIERRYBREHON.FR" ToolTip="Logo THIERRYBREHON.FR" />
                </li>
                <li>
                    <h1>
                        <TBfr:ET_Label ID="FTitrePage" runat="server" /></h1>
                </li>
                <li>
                    <TBfr:ET_TextBox ID="Identifiant" NullText="Identifiant" Caption="Identifiant" runat="server" />
                </li>
                <li>
                    <TBfr:ET_TextBox ID="Password" NullText="Mot de passe" Password="true" Caption="Mot de passe" runat="server" />
                </li>
                <li>
                    <TBfr:ET_TextBox ID="Avatar" NullText="Avatar" Caption="Avatar" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="EnterButton" Text="Valider" OnClick="EnterButton_Click" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="LostPasswordButton" Text="Mot de passe perdu ?" OnClick="LostPasswordButton_Click" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Label ID="FMessageDisplay" CssClass="TBfr_MessageDisplay" runat="server" /></li>
            </ul>
            <TBfr:TBfr_HiddenField ID="PAppli" runat="server" />
            <TBfr:TBfr_HiddenField ID="PIdAppli" runat="server" />
            <TBfr:TBfr_HiddenField ID="POpAppli" runat="server" />
            <TBfr:TBfr_HiddenField ID="PItAppli" runat="server" />
            <%--<TBfr:TBfr_HiddenField ID="FCurrentStateHiddenField" runat="server" />
            <TBfr:TBfr_HiddenField ID="FPTri" runat="server" />
            <TBfr:TBfr_HiddenField ID="HF_Resolution" Valeur="#" ClientIDMode="Static" runat="server" />--%>
        </form>
    </div>
</body>
</html>
