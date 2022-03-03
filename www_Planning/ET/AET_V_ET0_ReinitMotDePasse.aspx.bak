<%@ Page Language="C#" MasterPageFile="~/ET/ET_MasterPage.master" AutoEventWireup="true"
    CodeFile="AET_V_ET0_ReinitMotDePasse.aspx.cs" Inherits="AET_V_ET0_ReinitMotDePasse" Title="" %>

<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>

<asp:Content ID="ContentForm" ContentPlaceHolderID="PlaceHolderForm" runat="server">
    <ul>
        <li>
            <TBfr:ET_Label ID="FCurrentStateDisplay_0" CssClass="ET_CurrentStateDisplay" ClientIDMode="Static" runat="server" /></li>
        <li>
            <TBfr:ET_Label ID="FMessageDisplay_0" CssClass="ET_MessageDisplay" ClientIDMode="Static" runat="server" /></li>
    </ul>
    <ul>
        <li id="detail_0">
            <TBfr:TBfr_HiddenField ID="Logicaldeleted_0" Valeur='<%# TemplateStringValue(0,"Logicaldeleted", "Logicaldeleted_0")%>' ClientIDMode="Static" runat="server" />
            <TBfr:TBfr_HiddenField ID="Id_0" Valeur='<%# TemplateStringValue(0,"Id", "Id_0")%>' ClientIDMode="Static" runat="server" />
            <ul class="ET_Master_EditForm">
                <li>
                    <TBfr:ET_TextBox ID="AffId_0" Valeur='<%# TemplateStringValue(0,"Id", "AffId_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_TextBox ID="Login_0" Valeur='<%# TemplateStringValue(0,"Login","Login_0")%>' Caption='<%# TemplateLabelValue(0,"LblLogin")%>' ClientIDMode="Static" runat="server" />

                </li>
                <li>
                    <TBfr:ET_TextBox ID="Motdepasse_0" Password="true" Caption='<%# TemplateLabelValue(0,"LblMotdepasse")%>' ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_TextBox ID="MotdepasseConfirm_0" Password="true" Caption='<%# TemplateLabelValue(0,"LblMotdepasseConfirm")%>' ClientIDMode="Static" runat="server" />
                </li>
            </ul>
        </li>
    </ul>
    <asp:SqlDataSource ID="SqlDataSourceGrid_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataET %>" runat="server" />
    <%--Sources des combo box de fiche UNIQUEMENT POUR _editpopup et editformrow--%>

    <%--Variables cachées--%>
    <TBfr:TBfr_HiddenField ID="FCurrentStateHiddenField_0" runat="server" Valeur="1" />
    <TBfr:TBfr_HiddenField ID="FModelsExportGridHiddenField" runat="server" />
</asp:Content>
<asp:Content ID="ContentSideMenu" runat="server" ContentPlaceHolderID="PlaceHolderSideMenu">
    <ul>
        <li>
            <TBfr:ET_Button ID="FValidateButton_0" Text='<%# TemplateButtonText("IconValidateButton", 1)%>' ClientIDMode="Static" runat="server" />
        </li>
    </ul>
</asp:Content>
<asp:Content ID="ContentScripts" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <script language="JavaScript" type="text/javascript">
        window.onload = function () {
            Affiche_div_0(document.getElementById("<%=DisplayedTabHiddenField(0).ClientID%>").value);
            window.scrollTo(0, 0);
        }
        function Affiche_div_0(Suffixe) {
            ActualiserOngletChoisiById("sp_" + Suffixe, "vide_0", "");
            ActualiserOngletChoisiById("sp_" + Suffixe, "liste_0", "sp_liste_0");
            ActualiserOngletChoisiById("sp_" + Suffixe, "detail_0", "sp_detail_0");
            document.getElementById("<%=DisplayedTabHiddenField(0).ClientID%>").value = Suffixe;
            EnfonceById("sp_" + Suffixe);
        }
    </script>
</asp:Content>
