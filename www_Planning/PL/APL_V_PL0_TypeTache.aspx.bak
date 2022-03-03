<%@ Page Language="C#" MasterPageFile="~/PL/PL_MasterPage.master" AutoEventWireup="true"
 CodeFile="APL_V_PL0_TypeTache.aspx.cs" Inherits="APL_V_PL0_TypeTache" Title="" %>

<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Planning.NSP.nfw" Namespace="Planning.NSP" TagPrefix="TBfr" %>
<%@ Register Src="ascx/PL_PopupExport.ascx" TagPrefix="exp" TagName="PL_PopupExport" %>
<%@ Register Src="ascx/PL_SaveRestauModel.ascx" TagPrefix="mdl" TagName="PL_SaveRestauModel" %>

<asp:Content ID="ContentForm" ContentPlaceHolderID="PlaceHolderForm" runat="server">
    <ul>
    <li><TBfr:PL_Label ID="FCurrentStateDisplay_0" CssClass="PL_CurrentStateDisplay" ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Label ID="FMessageDisplay_0" CssClass="PL_MessageDisplay" ClientIDMode="Static" runat="server" /></li>
    </ul>
    <ul>
    <%--<li id="FTabHeader_0" runat="server">
            <span id="sp_liste_0" class="onglet" onclick="Affiche_div_0('liste_0')">Liste</span>
            <span id="sp_detail_0" class="onglet" onclick="Affiche_div_0('detail_0')">Détail</span>
</li>--%>
        <li id="vide_0" />
        <li id="liste_0">
<%--            <ul>
              <li ID="FFiltersTab_0" class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS" ClientIDMode="Static" runat="server">
                    <ul>
                        <li>Filtres</li>
                        <li><TBfr:PL_TextBox ID="FiltreLibelle_0" Caption='<%# TemplateLabelValue(0,"LblFilterLibelle")%>' ClientIDMode="Static" runat="server" /></li>

                        <li><TBfr:PL_Button ID="FFilterButton_0" text='<%# TemplateButtonText("IconFilterButton", 1)%>' ToolTip='<%# TemplateButtonText("TextFilterButton", 0)%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_Button ID="FEmptyFiltersButton_0" text='<%# TemplateButtonText("IconEmptyFiltersButton", 1)%>' ToolTip='<%# TemplateButtonText("TextEmptyFiltersButton", 0)%>' ClientIDMode="Static" runat="server" /></li>
                    </ul>
                </li>
            </ul>--%>
            <TBfr:TBfr_GridViewExporter ID="GridViewExporter_0" GridViewID="grid_0" ClientIDMode="Static" runat="server" />
            <TBfr:PL_GridView ID="grid_0" OnInit="Page_InitGridView" ClientIDMode="Static" runat="server" >
<%--              <columns>
                    <dx:GridViewCommandColumn Name="c0" />
                    <dx:GridViewCommandColumn Name="c1" />
                    <dx:GridViewDataTextColumn Name="cId" />
                    <dx:GridViewDataTextColumn Name="cLibelle" />

              </columns>--%>
<%--            <SettingsBehavior ConfirmDelete="true" />--%>
                <SettingsPopup>
                    <EditForm Width="50px" />
                </SettingsPopup>
                <Templates>
                    <%--<PreviewRow>
                        <ul>
<li>
                                    <TBfr:PL_TextBox D="PV_Libelle_0" Valeur='<%# TemplateColId(0,"PV_Libelle")%>' Caption='<%# TemplateLabelValue(0,"LblLibelle")%>' ClientIDMode="Static" runat="server" />

</li>

                        </ul>
                    </PreviewRow>--%>
                    <EditForm>
                        <TBfr:TBfr_HiddenField ID="TemplateStateControl_0" Valeur='<%# TemplateStateControlValue(0,"TemplateStateControl","TemplateStateControl_0")%>' ClientIDMode="Static" runat="server" />
                        <TBfr:TBfr_HiddenField ID="EF_Id_0" Valeur='<%# TemplateStringValue(0,"Id","EF_Id_0")%>' ClientIDMode="Static" runat="server" />
                        <ul class="PL_Master_EditForm">
                          <li><TBfr:PL_TextBox ID="EF_AffId_0" Valeur='<%# TemplateStringValue(0,"Id","EF_AffId_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" /></li>
                          <li><TBfr:PL_Label ID="Lib_Delete_0" Valeur='<%# TemplateStringValue(0,"Lib_Delete","Lib_Delete_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" /></li>
                          <li><dx:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton" runat="server" />
                              <dx:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton" runat="server" /></li>
<li>
             <TBfr:PL_TextBox ID="EF_Libelle_0" Valeur='<%# TemplateStringValue(0,"Libelle","EF_Libelle_0")%>' Caption='<%# TemplateLabelValue(0,"LblLibelle")%>' ClientIDMode="Static" runat="server" />      

</li>

                        </ul>
                    </EditForm>
                </Templates>
            </TBfr:PL_GridView>
        <%--Sources des combobox de grille--%>

        <%--Sources des combo box de filtre--%>

</li>
<li id="detail_0">
<TBfr:TBfr_HiddenField ID="Logicaldeleted_0" Valeur='<%# TemplateStringValue(0,"Logicaldeleted", "Logicaldeleted_0")%>' ClientIDMode="Static" runat="server" />
<TBfr:TBfr_HiddenField ID="Id_0" Valeur='<%# TemplateStringValue(0,"Id", "Id_0")%>' ClientIDMode="Static" runat="server" />
<ul class="PL_Master_EditForm">
<li><TBfr:PL_TextBox ID="AffId_0" Valeur='<%# TemplateStringValue(0,"Id", "AffId_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" /></li>
<li>
             <TBfr:PL_TextBox ID="Libelle_0" Valeur='<%# TemplateStringValue(0,"Libelle","Libelle_0")%>' Caption='<%# TemplateLabelValue(0,"LblLibelle")%>' ClientIDMode="Static" runat="server" />      

</li>

</ul>
</li>
</ul>
    <asp:SqlDataSource ID="SqlDataSourceGrid_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
<%--Sources des combo box de fiche UNIQUEMENT POUR _editpopup et editformrow--%>

    <%--Variables cachées--%>
    <TBfr:TBfr_HiddenField ID="FDisplayedTabHiddenField_0" ClientIDMode="Static" runat="server" />
    <TBfr:TBfr_HiddenField ID="FCurrentStateHiddenField_0" runat="server" valeur="1" />
    <%--Modèles et exports --%>
    <TBfr:TBfr_HiddenField ID="FModelsExportGridHiddenField" runat="server" />
    <mdl:PL_SaveRestauModel ID="SaveRestauModel" runat="server" />
    <exp:PL_PopupExport ID="PopupExport" PCompatibiliteImportVisible="false" runat="server" />
</asp:Content>
<asp:Content ID="ContentSideMenu" runat="server" ContentPlaceHolderID="PlaceHolderSideMenu">
    <ul>
        <li>
            <TBfr:PL_Button ID="FSelectButton" Text='<%# TemplateButtonText("IconSelectButton", 1)%>' ClientIDMode="Static" runat="server" />
        </li>
        <li>
            <TBfr:PL_Button ID="FCancelSelectButton" Text='<%# TemplateButtonText("IconCancelSelectButton", 1)%>' ClientIDMode="Static" runat="server" />
        </li>
    </ul>
    <ul>
    <li><TBfr:PL_Button ID="FCreateButton_0" text='<%# TemplateButtonText("IconCreateButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FVisualizeButton_0" Text='<%# TemplateButtonText("IconViewButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FDuplicateButton_0" text='<%# TemplateButtonText("IconDuplicateButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FUpdateButton_0" text='<%# TemplateButtonText("IconUpdateButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FDeleteButton_0" text='<%# TemplateButtonText("IconDeleteButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FValidateButton_0" text='<%# TemplateButtonText("IconValidateButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FCancelButton_0" text='<%# TemplateButtonText("IconCancelButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:PL_Button ID="FEraseButton_0" Text='<%# TemplateButtonText("IconEraseButton", 1)%>' ClientIDMode="Static" runat="server" /></li>
    </ul>
    <ul>
            <li>
                <TBfr:PL_Button ID="save_0" Text='<%# TemplateButtonText("IconSaveModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextSaveModelButton", 0) %>' OnClick="OnClickShowSavePopup" ClientIDMode="Static" runat="server" />
            </li>
            <li>
                <TBfr:PL_Button ID="restau_0" Text='<%# TemplateButtonText("IconApplyModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextApplyModelButton", 0) %>' OnClick="OnClickShowRestauPopup" ClientIDMode="Static" runat="server" />
            </li>
    </ul>
    <ul>
        <li>
            <ul>
            <li>
                <TBfr:PL_Button ID="export_0" Text='<%# TemplateButtonText("IconExportGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportGridButton", 0) %>' AutoPostBack="False" ClientIDMode="Static" runat="server">
                    <ClientSideEvents Click="function(s, e) { ShowExportGridViewPopup('0'); }" />
                </TBfr:PL_Button></li>
            <%--<li>
                <TBfr:PL_Button ID="exportPdf_0" Text='<%# TemplateButtonText("IconExportPdfGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportPdfGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>--%>
               <li>
                <TBfr:PL_Button ID="exportXlsx_0" Text='<%# TemplateButtonText("IconExportXlsxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsxGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
                <%--<li>
                <TBfr:PL_Button ID="exportXls_0" Text='<%# TemplateButtonText("IconExportXlsGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
            <li>
                <TBfr:PL_Button ID="exportCsv_0" Text='<%# TemplateButtonText("IconExportCsvGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportCsvGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
               <li>
                <TBfr:PL_Button ID="exportDocx_0" Text='<%# TemplateButtonText("IconExportDocxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocxGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
                <li>
                <TBfr:PL_Button ID="exportDoc_0" Text='<%# TemplateButtonText("IconExportDocGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>--%>
</ul>
        </li>
            <li>
                <TBfr:PL_Button ID="btnShowColumn_0" ClientInstanceName="btnShowColumn_0"
                    Text='<%# TemplateButtonText("IconShowGridColumnsButton", 1)+ "&nbsp;" + TemplateButtonText("TextShowGridColumnsButton", 0) %>' UseSubmitBehavior="false" AutoPostBack="false" ClientIDMode="Static" runat="server">
                    <ClientSideEvents Click="function(s, e) { btnShowColumn_Click(grid_0); }" />
                </TBfr:PL_Button>
            </li>
            <%--<li>
                <TBfr:PL_Button ID="ShowRestauPreview_0" Text="Fiches/Lignes" OnClick="OnClickShowPreview" ClientIDMode="Static" runat="server" />
            </li>
            <li>
                <TBfr:PL_Button ID="PopupEditForm_0" Text="Grille/Popup" OnClick="OnClickPopupEditForm" ClientIDMode="Static" runat="server" />
            </li>--%>
        </ul>
<ul>
        <li class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS" clientidmode="Static" runat="server">
            <ul class="TBfr_ACCORDION_GROUP_COLLAPSED_JS">
                <li>Changement de mode de saisie</li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=0">Défaut</a></li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=1">Detail seul</a></li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=2">Batch</a></li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=3">PopupEditForm</a></li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=4">Liste/Detail</a></li>
                <li><a href="../PL/APL_V_PL0_TypeTache.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=5">Inline</a></li>
            </ul>
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
