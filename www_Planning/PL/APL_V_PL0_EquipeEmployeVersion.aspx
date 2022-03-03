<%@ Page Language="C#" MasterPageFile="~/PL/PL_MasterPage.master" AutoEventWireup="true"
 CodeFile="APL_V_PL0_EquipeEmployeVersion.aspx.cs" Inherits="APL_V_PL0_EquipeEmployeVersion" Title="" %>

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
            <ul>
              <li ID="FFiltersTab_0" class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS" ClientIDMode="Static" runat="server">
                    <ul>
                        <li>Filtres</li>
                        <li><TBfr:PL_ComboBox ID="FiltreId_planning_0" Caption='<%# TemplateLabelValue(0,"LblFilterId_planning")%>' OnSelectedIndexChanged="FPFiltreId_planning_0_SelectedIndexChanged" ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_ComboBox ID="FiltreId_version_0" Caption='<%# TemplateLabelValue(0,"LblFilterId_version")%>' OnSelectedIndexChanged="FPFiltreId_version_0_SelectedIndexChanged" ClientIDMode="Static" runat="server" /></li>
<%--                        <li><TBfr:PL_ComboBox ID="FiltreId_equipe_0" Caption='<%# TemplateLabelValue(0,"LblFilterId_equipe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_ComboBox ID="FiltreId_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterId_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreLib_planning_0" Caption='<%# TemplateLabelValue(0,"LblFilterLib_planning")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreAbr_planning_0" Caption='<%# TemplateLabelValue(0,"LblFilterAbr_planning")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreNom_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterNom_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltrePrenom_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterPrenom_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_CheckBox ID="FiltreFeminin_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterFeminin_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreIdent_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterIdent_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreInit_employe_0" Caption='<%# TemplateLabelValue(0,"LblFilterInit_employe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreAbr_equipe_0" Caption='<%# TemplateLabelValue(0,"LblFilterAbr_equipe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreLib_equipe_0" Caption='<%# TemplateLabelValue(0,"LblFilterLib_equipe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreLib_planning_equipe_0" Caption='<%# TemplateLabelValue(0,"LblFilterLib_planning_equipe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreAbr_planning_equipe_0" Caption='<%# TemplateLabelValue(0,"LblFilterAbr_planning_equipe")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreAbr_version_0" Caption='<%# TemplateLabelValue(0,"LblFilterAbr_version")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreLib_version_0" Caption='<%# TemplateLabelValue(0,"LblFilterLib_version")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreLib_planning_version_0" Caption='<%# TemplateLabelValue(0,"LblFilterLib_planning_version")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_TextBox ID="FiltreAbr_planning_version_0" Caption='<%# TemplateLabelValue(0,"LblFilterAbr_planning_version")%>' ClientIDMode="Static" runat="server" /></li>--%>

                        <li><TBfr:PL_Button ID="FFilterButton_0" text='<%# TemplateButtonText("IconFilterButton", 1)%>' ToolTip='<%# TemplateButtonText("TextFilterButton", 0)%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:PL_Button ID="FEmptyFiltersButton_0" text='<%# TemplateButtonText("IconEmptyFiltersButton", 1)%>' ToolTip='<%# TemplateButtonText("TextEmptyFiltersButton", 0)%>' ClientIDMode="Static" runat="server" /></li>
                    </ul>
                </li>
            </ul>
            <TBfr:TBfr_GridViewExporter ID="GridViewExporter_0" GridViewID="grid_0" ClientIDMode="Static" runat="server" />
            <TBfr:PL_GridView ID="grid_0" OnInit="Page_InitGridView" ClientIDMode="Static" runat="server" >
<%--              <columns>
                    <dx:GridViewCommandColumn Name="c0" />
                    <dx:GridViewCommandColumn Name="c1" />
                    <dx:GridViewDataTextColumn Name="cId" />
                    <dx:GridViewDataComboBoxColumn Name="cId_version" />
                    <dx:GridViewDataComboBoxColumn Name="cId_equipe" />
                    <dx:GridViewDataComboBoxColumn Name="cId_employe" />
                    <dx:GridViewDataComboBoxColumn Name="cId_planning" />
                    <dx:GridViewDataTextColumn Name="cLib_planning" />
                    <dx:GridViewDataTextColumn Name="cAbr_planning" />
                    <dx:GridViewDataTextColumn Name="cNom_employe" />
                    <dx:GridViewDataTextColumn Name="cPrenom_employe" />
                    <dx:GridViewDataCheckColumn Name="cFeminin_employe" />
                    <dx:GridViewDataTextColumn Name="cIdent_employe" />
                    <dx:GridViewDataTextColumn Name="cInit_employe" />
                    <dx:GridViewDataTextColumn Name="cAbr_equipe" />
                    <dx:GridViewDataTextColumn Name="cLib_equipe" />
                    <dx:GridViewDataTextColumn Name="cLib_planning_equipe" />
                    <dx:GridViewDataTextColumn Name="cAbr_planning_equipe" />
                    <dx:GridViewDataTextColumn Name="cAbr_version" />
                    <dx:GridViewDataTextColumn Name="cLib_version" />
                    <dx:GridViewDataTextColumn Name="cLib_planning_version" />
                    <dx:GridViewDataTextColumn Name="cAbr_planning_version" />

              </columns>--%>
<%--            <SettingsBehavior ConfirmDelete="true" />--%>
                <SettingsPopup>
                    <EditForm Width="50px" />
                </SettingsPopup>
                <Templates>
                    <%--<PreviewRow>
                        <ul>
<li>
                                    <TBfr:PL_TextBox D="PV_Id_version_0" Valeur='<%# TemplateColId(0,"PV_Id_version")%>' Caption='<%# TemplateLabelValue(0,"LblId_version")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Id_equipe_0" Valeur='<%# TemplateColId(0,"PV_Id_equipe")%>' Caption='<%# TemplateLabelValue(0,"LblId_equipe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Id_employe_0" Valeur='<%# TemplateColId(0,"PV_Id_employe")%>' Caption='<%# TemplateLabelValue(0,"LblId_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Id_planning_0" Valeur='<%# TemplateColId(0,"PV_Id_planning")%>' Caption='<%# TemplateLabelValue(0,"LblId_planning")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Lib_planning_0" Valeur='<%# TemplateColId(0,"PV_Lib_planning")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Abr_planning_0" Valeur='<%# TemplateColId(0,"PV_Abr_planning")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Nom_employe_0" Valeur='<%# TemplateColId(0,"PV_Nom_employe")%>' Caption='<%# TemplateLabelValue(0,"LblNom_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Prenom_employe_0" Valeur='<%# TemplateColId(0,"PV_Prenom_employe")%>' Caption='<%# TemplateLabelValue(0,"LblPrenom_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Feminin_employe_0" Valeur='<%# TemplateColId(0,"PV_Feminin_employe")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Ident_employe_0" Valeur='<%# TemplateColId(0,"PV_Ident_employe")%>' Caption='<%# TemplateLabelValue(0,"LblIdent_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Init_employe_0" Valeur='<%# TemplateColId(0,"PV_Init_employe")%>' Caption='<%# TemplateLabelValue(0,"LblInit_employe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Abr_equipe_0" Valeur='<%# TemplateColId(0,"PV_Abr_equipe")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_equipe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Lib_equipe_0" Valeur='<%# TemplateColId(0,"PV_Lib_equipe")%>' Caption='<%# TemplateLabelValue(0,"LblLib_equipe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Lib_planning_equipe_0" Valeur='<%# TemplateColId(0,"PV_Lib_planning_equipe")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_equipe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Abr_planning_equipe_0" Valeur='<%# TemplateColId(0,"PV_Abr_planning_equipe")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_equipe")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Abr_version_0" Valeur='<%# TemplateColId(0,"PV_Abr_version")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_version")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Lib_version_0" Valeur='<%# TemplateColId(0,"PV_Lib_version")%>' Caption='<%# TemplateLabelValue(0,"LblLib_version")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Lib_planning_version_0" Valeur='<%# TemplateColId(0,"PV_Lib_planning_version")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_version")%>' ClientIDMode="Static" runat="server" />

</li>
<li>
                                    <TBfr:PL_TextBox D="PV_Abr_planning_version_0" Valeur='<%# TemplateColId(0,"PV_Abr_planning_version")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_version")%>' ClientIDMode="Static" runat="server" />

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
            <TBfr:PL_ComboBox ID="EF_Id_version_0" Valeur='<%# TemplateStringValue(0,"Id_version","EF_Id_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="EF_Id_equipe_0" Valeur='<%# TemplateStringValue(0,"Id_equipe","EF_Id_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="EF_Id_employe_0" Valeur='<%# TemplateStringValue(0,"Id_employe","EF_Id_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="EF_Id_planning_0" Valeur='<%# TemplateStringValue(0,"Id_planning","EF_Id_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Lib_planning_0" Valeur='<%# TemplateStringValue(0,"Lib_planning","EF_Lib_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Abr_planning_0" Valeur='<%# TemplateStringValue(0,"Abr_planning","EF_Abr_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Nom_employe_0" Valeur='<%# TemplateStringValue(0,"Nom_employe","EF_Nom_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblNom_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Prenom_employe_0" Valeur='<%# TemplateStringValue(0,"Prenom_employe","EF_Prenom_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblPrenom_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_CheckBox ID="EF_Feminin_employe_0" Valeur='<%# TemplateStringValue(0,"Feminin_employe","EF_Feminin_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin_employe")%>' ClientIDMode="Static" runat="server" />      
      <TBfr:PL_TextBox ID="EF_Lib_Feminin_employe_0" Valeur='<%# TemplateStringValue(0,"Feminin_employe","EF_Lib_Feminin_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin_employe")%>' ClientIDMode="Static" runat="server" />      
 
</li>
<li>
             <TBfr:PL_TextBox ID="EF_Ident_employe_0" Valeur='<%# TemplateStringValue(0,"Ident_employe","EF_Ident_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblIdent_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Init_employe_0" Valeur='<%# TemplateStringValue(0,"Init_employe","EF_Init_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblInit_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Abr_equipe_0" Valeur='<%# TemplateStringValue(0,"Abr_equipe","EF_Abr_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Lib_equipe_0" Valeur='<%# TemplateStringValue(0,"Lib_equipe","EF_Lib_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Lib_planning_equipe_0" Valeur='<%# TemplateStringValue(0,"Lib_planning_equipe","EF_Lib_planning_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Abr_planning_equipe_0" Valeur='<%# TemplateStringValue(0,"Abr_planning_equipe","EF_Abr_planning_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Abr_version_0" Valeur='<%# TemplateStringValue(0,"Abr_version","EF_Abr_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Lib_version_0" Valeur='<%# TemplateStringValue(0,"Lib_version","EF_Lib_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Lib_planning_version_0" Valeur='<%# TemplateStringValue(0,"Lib_planning_version","EF_Lib_planning_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="EF_Abr_planning_version_0" Valeur='<%# TemplateStringValue(0,"Abr_planning_version","EF_Abr_planning_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_version")%>' ClientIDMode="Static" runat="server" />      

</li>

                        </ul>
                    </EditForm>
                </Templates>
            </TBfr:PL_GridView>
        <%--Sources des combobox de grille--%>
        <asp:SqlDataSource ID="SqlDataSourceGridId_version_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceGridId_equipe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceGridId_employe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceGridId_planning_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />

        <%--Sources des combo box de filtre--%>
<%--        <asp:SqlDataSource ID="SqlDataSourceFiltreId_version_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />--%>
        <asp:SqlDataSource ID="SqlDataSourceFiltreId_equipe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
<%--        <asp:SqlDataSource ID="SqlDataSourceFiltreId_employe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceFiltreId_planning_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />--%>

</li>
<li id="detail_0">
<TBfr:TBfr_HiddenField ID="Logicaldeleted_0" Valeur='<%# TemplateStringValue(0,"Logicaldeleted", "Logicaldeleted_0")%>' ClientIDMode="Static" runat="server" />
<TBfr:TBfr_HiddenField ID="Id_0" Valeur='<%# TemplateStringValue(0,"Id", "Id_0")%>' ClientIDMode="Static" runat="server" />
<ul class="PL_Master_EditForm">
<li><TBfr:PL_TextBox ID="AffId_0" Valeur='<%# TemplateStringValue(0,"Id", "AffId_0")%>' ReadOnly="true" ClientIDMode="Static" runat="server" /></li>
<li>
            <TBfr:PL_ComboBox ID="Id_version_0" Valeur='<%# TemplateStringValue(0,"Id_version","Id_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="Id_equipe_0" Valeur='<%# TemplateStringValue(0,"Id_equipe","Id_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="Id_employe_0" Valeur='<%# TemplateStringValue(0,"Id_employe","Id_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_ComboBox ID="Id_planning_0" Valeur='<%# TemplateStringValue(0,"Id_planning","Id_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblId_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Lib_planning_0" Valeur='<%# TemplateStringValue(0,"Lib_planning","Lib_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Abr_planning_0" Valeur='<%# TemplateStringValue(0,"Abr_planning","Abr_planning_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Nom_employe_0" Valeur='<%# TemplateStringValue(0,"Nom_employe","Nom_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblNom_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Prenom_employe_0" Valeur='<%# TemplateStringValue(0,"Prenom_employe","Prenom_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblPrenom_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
            <TBfr:PL_CheckBox ID="Feminin_employe_0" Valeur='<%# TemplateStringValue(0,"Feminin_employe","Feminin_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin_employe")%>' ClientIDMode="Static" runat="server" />      
      <TBfr:PL_TextBox ID="Lib_Feminin_employe_0" Valeur='<%# TemplateStringValue(0,"Feminin_employe","Lib_Feminin_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblFeminin_employe")%>' ClientIDMode="Static" runat="server" />      
 
</li>
<li>
             <TBfr:PL_TextBox ID="Ident_employe_0" Valeur='<%# TemplateStringValue(0,"Ident_employe","Ident_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblIdent_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Init_employe_0" Valeur='<%# TemplateStringValue(0,"Init_employe","Init_employe_0")%>' Caption='<%# TemplateLabelValue(0,"LblInit_employe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Abr_equipe_0" Valeur='<%# TemplateStringValue(0,"Abr_equipe","Abr_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Lib_equipe_0" Valeur='<%# TemplateStringValue(0,"Lib_equipe","Lib_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Lib_planning_equipe_0" Valeur='<%# TemplateStringValue(0,"Lib_planning_equipe","Lib_planning_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Abr_planning_equipe_0" Valeur='<%# TemplateStringValue(0,"Abr_planning_equipe","Abr_planning_equipe_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_equipe")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Abr_version_0" Valeur='<%# TemplateStringValue(0,"Abr_version","Abr_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Lib_version_0" Valeur='<%# TemplateStringValue(0,"Lib_version","Lib_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Lib_planning_version_0" Valeur='<%# TemplateStringValue(0,"Lib_planning_version","Lib_planning_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblLib_planning_version")%>' ClientIDMode="Static" runat="server" />      

</li>
<li>
             <TBfr:PL_TextBox ID="Abr_planning_version_0" Valeur='<%# TemplateStringValue(0,"Abr_planning_version","Abr_planning_version_0")%>' Caption='<%# TemplateLabelValue(0,"LblAbr_planning_version")%>' ClientIDMode="Static" runat="server" />      

</li>

</ul>
</li>
</ul>
    <asp:SqlDataSource ID="SqlDataSourceGrid_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
<%--Sources des combo box de fiche UNIQUEMENT POUR _editpopup et editformrow--%>
        <asp:SqlDataSource ID="SqlDataSourceId_version_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceId_equipe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceId_employe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceId_planning_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />

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
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=0">Défaut</a></li>
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=1">Detail seul</a></li>
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=2">Batch</a></li>
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=3">PopupEditForm</a></li>
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=4">Liste/Detail</a></li>
                <li><a href="../PL/APL_V_PL0_EquipeEmployeVersion.aspx?code=<%=IdAndCodeSession%>&<%=C_Query_WebFormMode%>=5">Inline</a></li>
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
