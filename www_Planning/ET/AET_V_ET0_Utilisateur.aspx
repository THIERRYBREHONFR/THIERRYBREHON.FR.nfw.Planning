<%@ Page Language="C#" MasterPageFile="~/ET/ET_MasterPage.master" AutoEventWireup="true"
    CodeFile="AET_V_ET0_Utilisateur.aspx.cs" Inherits="AET_V_ET0_Utilisateur" Title="" %>

<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>
<%@ Register Src="ascx/ET_PopupExport.ascx" TagPrefix="exp" TagName="ET_PopupExport" %>
<%@ Register Src="ascx/ET_SaveRestauModel.ascx" TagPrefix="mdl" TagName="ET_SaveRestauModel" %>

<asp:Content ID="ContentForm" ContentPlaceHolderID="PlaceHolderForm" runat="server">
    <ul>
        <li>
            <TBfr:ET_Label ID="FCurrentStateDisplay_0" CssClass="ET_CurrentStateDisplay" ClientIDMode="Static" runat="server" /></li>
        <li>
            <TBfr:ET_Label ID="FMessageDisplay_0" CssClass="ET_MessageDisplay" ClientIDMode="Static" runat="server" /></li>
    </ul>
    <ul>
        <li id="liste_0">
<%--                   <ul>
                <li id="FFiltersTab_0" class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS" clientidmode="Static" runat="server">
                    <ul>
                        <li>Filtres</li>
                            <li>
                                <TBfr:ET_TextBox ID="FiltrePrenom_0" Caption='<%# TemplateLabelValue(0,"LblFilterPrenom")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="FiltreLogin_0" Caption='<%# TemplateLabelValue(0,"LblFilterLogin")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreTr_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterTr_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreCo_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterCo_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreCa_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterCa_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltrePt_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterPt_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreAv_prendre_0" Caption='<%# TemplateLabelValue(0,"LblFilterAv_prendre")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreTa_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterTa_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreSo_visu_0" Caption='<%# TemplateLabelValue(0,"LblFilterSo_visu")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_ComboBox ID="FiltreId_espaceclient_0" Caption='<%# TemplateLabelValue(0,"LblFilterId_espaceclient")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="FiltreMail_0" Caption='<%# TemplateLabelValue(0,"LblFilterMail")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="FiltreNom_0" Caption='<%# TemplateLabelValue(0,"LblFilterNom")%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="FiltreFeminin_0" Caption='<%# TemplateLabelValue(0,"LblFilterFeminin")%>' ClientIDMode="Static" runat="server" />
                            </li>

                            <li>
                                <TBfr:ET_Button ID="FFilterButton_0" Text='<%# TemplateButtonText("IconFilterButton", 1)%>' ToolTip='<%# TemplateButtonText("TextFilterButton", 0)%>' ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_Button ID="FEmptyFiltersButton_0" Text='<%# TemplateButtonText("IconEmptyFiltersButton", 1)%>' ToolTip='<%# TemplateButtonText("TextEmptyFiltersButton", 0)%>' ClientIDMode="Static" runat="server" />
                            </li>
                        </ul>
                  </li>
            </ul>--%>
            <TBfr:TBfr_GridViewExporter ID="GridViewExporter_0" GridViewID="grid_0" ClientIDMode="Static" runat="server" />
            <TBfr:ET_GridView ID="grid_0" OnInit="Page_InitGridView" ClientIDMode="Static" runat="server">
<%--                <SettingsBehavior ConfirmDelete="true" />--%>
                <SettingsPopup>
                    <EditForm Width="50px" />
                </SettingsPopup>
                <Templates>
                    <EditForm>
                        <TBfr:TBfr_HiddenField ID="Logicaldeleted_0" Valeur='<%# TemplateStringValue(0,"Logicaldeleted","Logicaldeleted_0")%>' ClientIDMode="Static" runat="server" />
                        <TBfr:TBfr_HiddenField ID="Id_0" Valeur='<%# TemplateStringValue(0,"Id","Id_0")%>' ClientIDMode="Static" runat="server" />
                        <ul class="ET_Master_EditForm">
                            <li>
                                <TBfr:ET_TextBox ID="AffId_0" Valeur='<%# TemplateStringValue(0,"Id","AffId_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_Label ID="Lib_Delete_0" Valeur='<%# TemplateStringValue(0,"Lib_Delete","Lib_Delete_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" /></li>
                            <li>
                                <dx:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton" runat="server" />
                                <dx:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton" runat="server" />
                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="Prenom_0" Valeur='<%# TemplateStringValue(0,"Prenom","Prenom_0")%>' Caption='<%# TemplateLabelValue(0,"LblPrenom")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="Login_0" Valeur='<%# TemplateStringValue(0,"Login","Login_0")%>' Caption='<%# TemplateLabelValue(0,"LblLogin")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Tr_visu_0" Valeur='<%# TemplateStringValue(0,"Tr_visu","Tr_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblTr_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Tr_visu_0" Valeur='<%# TemplateStringValue(0,"Tr_visu","Lib_Tr_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblTr_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Co_visu_0" Valeur='<%# TemplateStringValue(0,"Co_visu","Co_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblCo_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Co_visu_0" Valeur='<%# TemplateStringValue(0,"Co_visu","Lib_Co_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblCo_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Ca_visu_0" Valeur='<%# TemplateStringValue(0,"Ca_visu","Ca_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblCa_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Ca_visu_0" Valeur='<%# TemplateStringValue(0,"Ca_visu","Lib_Ca_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblCa_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Pt_visu_0" Valeur='<%# TemplateStringValue(0,"Pt_visu","Pt_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblPt_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Pt_visu_0" Valeur='<%# TemplateStringValue(0,"Pt_visu","Lib_Pt_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblPt_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Av_prendre_0" Valeur='<%# TemplateStringValue(0,"Av_prendre","Av_prendre_0")%>' Caption='<%# TemplateLabelValue(0,"LblAv_prendre")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Av_prendre_0" Valeur='<%# TemplateStringValue(0,"Av_prendre","Lib_Av_prendre_0")%>' Caption='<%# TemplateLabelValue(0,"LblAv_prendre")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Ta_visu_0" Valeur='<%# TemplateStringValue(0,"Ta_visu","Ta_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblTa_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Ta_visu_0" Valeur='<%# TemplateStringValue(0,"Ta_visu","Lib_Ta_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblTa_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="So_visu_0" Valeur='<%# TemplateStringValue(0,"So_visu","So_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblSo_visu")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_So_visu_0" Valeur='<%# TemplateStringValue(0,"So_visu","Lib_So_visu_0")%>' Caption='<%# TemplateLabelValue(0,"LblSo_visu")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_ComboBox ID="Id_espaceclient_0" Valeur='<%# TemplateStringValue(0,"Id_espaceclient","Id_espaceclient_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_espaceclient")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="Mail_0" Valeur='<%# TemplateStringValue(0,"Mail","Mail_0")%>' Caption='<%# TemplateLabelValue(0,"LblMail")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_TextBox ID="Nom_0" Valeur='<%# TemplateStringValue(0,"Nom","Nom_0")%>' Caption='<%# TemplateLabelValue(0,"LblNom")%>' ClientIDMode="Static" runat="server" />

                            </li>
                            <li>
                                <TBfr:ET_CheckBox ID="Feminin_0" Valeur='<%# TemplateStringValue(0,"Feminin","Feminin_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin")%>' ClientIDMode="Static" runat="server" />
                                <TBfr:ET_TextBox ID="Lib_Feminin_0" Valeur='<%# TemplateStringValue(0,"Feminin","Lib_Feminin_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin")%>' ClientIDMode="Static" runat="server" />

                            </li>

                        </ul>
                    </EditForm>
                </Templates>
            </TBfr:ET_GridView>
            <%--Sources des combobox de grille--%>
            <asp:SqlDataSource ID="SqlDataSourceGridId_espaceclient_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataET %>" runat="server" />

            <%--Sources des combo box de filtre--%>
            <asp:SqlDataSource ID="SqlDataSourceFiltreId_espaceclient_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataET %>" runat="server" />

        </li>
    </ul>
    <asp:SqlDataSource ID="SqlDataSourceGrid_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataET %>" runat="server" />
    <%--Sources des combo box de fiche UNIQUEMENT POUR _editpopup et editformrow--%>
    <asp:SqlDataSource ID="SqlDataSourceId_espaceclient_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataET %>" runat="server" />

    <%--Variables cachées--%>
    <TBfr:TBfr_HiddenField ID="FCurrentStateHiddenField_0" runat="server" Valeur="1" />
    <TBfr:TBfr_HiddenField ID="FModelsExportGridHiddenField" runat="server" />
    <mdl:ET_SaveRestauModel ID="SaveRestauModel" runat="server" />
    <exp:ET_PopupExport ID="PopupExport" PCompatibiliteImportVisible="false" runat="server" />
</asp:Content>
<asp:Content ID="ContentSideMenu" runat="server" ContentPlaceHolderID="PlaceHolderSideMenu">
    <ul>
        <li>
            <TBfr:ET_Button ID="save_0" Text='<%# TemplateButtonText("IconSaveModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextSaveModelButton", 0) %>' OnClick="OnClickShowSavePopup" ClientIDMode="Static" runat="server" />
        </li>
        <li>
            <TBfr:ET_Button ID="restau_0" Text='<%# TemplateButtonText("IconApplyModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextApplyModelButton", 0) %>' OnClick="OnClickShowRestauPopup" ClientIDMode="Static" runat="server" />
        </li>
        <li>
            <ul>
                <li>
                    <TBfr:ET_Button ID="export_0" Text='<%# TemplateButtonText("IconExportGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportGridButton", 0) %>' AutoPostBack="False" ClientIDMode="Static" runat="server">
                        <ClientSideEvents Click="function(s, e) { ShowExportGridViewPopup('0'); }" />
                    </TBfr:ET_Button>
                </li>
                <li>
                    <TBfr:ET_Button ID="exportPdf_0" Text='<%# TemplateButtonText("IconExportPdfGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportPdfGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="exportXlsx_0" Text='<%# TemplateButtonText("IconExportXlsxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsxGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="exportXls_0" Text='<%# TemplateButtonText("IconExportXlsGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="exportCsv_0" Text='<%# TemplateButtonText("IconExportCsvGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportCsvGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="exportDocx_0" Text='<%# TemplateButtonText("IconExportDocxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocxGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
                <li>
                    <TBfr:ET_Button ID="exportDoc_0" Text='<%# TemplateButtonText("IconExportDocGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocGridButton", 0) %>' OnClick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server" />
                </li>
            </ul>
        </li>
        <li>
            <TBfr:ET_Button ID="btnShowColumn_0" ClientInstanceName="btnShowColumn_0"
                Text='<%# TemplateButtonText("IconShowGridColumnsButton", 1)+ "&nbsp;" + TemplateButtonText("TextShowGridColumnsButton", 0) %>' UseSubmitBehavior="false" AutoPostBack="false" ClientIDMode="Static" runat="server">
                <ClientSideEvents Click="function(s, e) { btnShowColumn_Click(grid_0); }" />
            </TBfr:ET_Button>
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
