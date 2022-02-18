<%@ Page Language="C#" MasterPageFile="~/DBPL/DBPL_MasterPage.master" AutoEventWireup="true"
 CodeFile="XDBPL_V_DB0_CategorieContrainte.aspx.cs" Inherits="XDBPL_V_DB0_CategorieContrainte" Title="" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v21.1" Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="DataBasePL.NSP.nfw" Namespace="DataBasePL.NSP" TagPrefix="TBfr" %>
<%@ Register Src="ascx/DBPL_PopupExport.ascx" TagPrefix="exp" TagName="DBPL_PopupExport" %>
<%@ Register Src="ascx/DBPL_SaveRestauModel.ascx" TagPrefix="mdl" TagName="DBPL_SaveRestauModel" %>

<asp:Content ID="ContentForm" ContentPlaceHolderID="PlaceHolderForm" runat="server">
    <ul>
    <li><TBfr:DBPL_Label ID="FCurrentStateDisplay_7" CssClass="DBPL_CurrentStateDisplay" ClientIDMode="Static" runat="server" /></li>
    <li><TBfr:DBPL_Label ID="FMessageDisplay_7" CssClass="DBPL_MessageDisplay" ClientIDMode="Static" runat="server" /></li>
    </ul>
    <ul>
        <li>
            <ul>
                <li id="FFiltersTab_7" class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS" clientidmode="Static" runat="server">
                    <ul>
                        <li>Filtres</li>
                        <li><TBfr:DBPL_ComboBox ID="FiltreId_categorie_7" Caption='<%# TemplateLabelValue(7,"LblFilterId_categorie")%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:DBPL_ComboBox ID="FiltreId_contrainte_7" Caption='<%# TemplateLabelValue(7,"LblFilterId_contrainte")%>' ClientIDMode="Static" runat="server" /></li>

                        <li><TBfr:DBPL_Button ID="FFilterButton_7" text='<%# TemplateButtonText("IconFilterButton", 1)%>' ToolTip='<%# TemplateButtonText("TextFilterButton", 7)%>' ClientIDMode="Static" runat="server" /></li>
                        <li><TBfr:DBPL_Button ID="FEmptyFiltersButton_7" text='<%# TemplateButtonText("IconEmptyFiltersButton", 1)%>' ToolTip='<%# TemplateButtonText("TextEmptyFiltersButton", 7)%>' ClientIDMode="Static" runat="server" /></li>
                        </ul>
                </li>
            </ul>
        </li>
        <li>
            <TBfr:TBfr_PivotGridExporter ID="PivotGridExporter_7" ASPxPivotGridID="grid_7" ClientIDMode="Static" runat="server" />
            <TBfr:DBPL_PivotGrid ID="grid_7" OnInit="Page_InitPivotGrid" ClientIDMode="Static" runat="server" >
                <ClientSideEvents CustomizationFieldsVisibleChanged="function(s,e){onCustomizationFieldsVisibleChanged(grid_7, btnShowColumn_7);}" />
              <%--<Fields>
                    <dx:PivotGridField ID="fId_7" FieldName="Id" />
                    <dx:PivotGridField ID="fId_categorie_7" FieldName="Id_categorie" />
                    <dx:PivotGridField ID="fId_contrainte_7" FieldName="Id_contrainte" />

              </Fields>--%>
            </TBfr:DBPL_PivotGrid>
        </li>
    </ul>
    <asp:SqlDataSource ID="SqlDataSourceGrid_7" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataDBPL %>" runat="server" />
        <%--Sources des combo box de filtre--%>
        <asp:SqlDataSource ID="SqlDataSourceFiltreId_categorie_7" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataDBPL %>" runat="server" />
        <asp:SqlDataSource ID="SqlDataSourceFiltreId_contrainte_7" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataDBPL %>" runat="server" />

    <%--Variables cachées--%>
    <TBfr:TBfr_HiddenField ID="FModelsExportGridHiddenField" runat="server" />
    <mdl:DBPL_SaveRestauModel ID="SaveRestauModel" runat="server" />
    <exp:DBPL_PopupExport ID="PopupExport" PCompatibiliteImportVisible="false" runat="server" />
</asp:Content>
<asp:Content ID="ContentSideMenu" runat="server" ContentPlaceHolderID="PlaceHolderSideMenu">
    <ul>
            <li>
                <TBfr:DBPL_Button ID="save_7" Text='<%# TemplateButtonText("IconSaveModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextSaveModelButton", 0) %>' OnClick="OnClickShowSavePopup" ClientIDMode="Static" runat="server" />
            </li>
            <li>
                <TBfr:DBPL_Button ID="restau_7" Text='<%# TemplateButtonText("IconApplyModelButton", 1)+ "&nbsp;" + TemplateButtonText("TextApplyModelButton", 0) %>' OnClick="OnClickShowRestauPopup" ClientIDMode="Static" runat="server" />
            </li>
    </ul>
    <ul>
        <li>
            <ul>
            <li>
                <TBfr:DBPL_Button ID="export_7" Text='<%# TemplateButtonText("IconExportGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportGridButton", 0) %>' AutoPostBack="False" ClientIDMode="Static" runat="server">
                    <ClientSideEvents Click="function(s, e) { ShowExportGridViewPopup('7'); }" />
                </TBfr:DBPL_Button></li>
            <li>
                <TBfr:DBPL_Button ID="exportPdf_7" Text='<%# TemplateButtonText("IconExportPdfGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportPdfGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
               <li>
                <TBfr:DBPL_Button ID="exportXlsx_7" Text='<%# TemplateButtonText("IconExportXlsxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsxGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
                <li>
                <TBfr:DBPL_Button ID="exportXls_7" Text='<%# TemplateButtonText("IconExportXlsGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportXlsGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
            <li>
                <TBfr:DBPL_Button ID="exportCsv_7" Text='<%# TemplateButtonText("IconExportCsvGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportCsvGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
               <li>
                <TBfr:DBPL_Button ID="exportDocx_7" Text='<%# TemplateButtonText("IconExportDocxGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocxGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
                <li>
                <TBfr:DBPL_Button ID="exportDoc_7" Text='<%# TemplateButtonText("IconExportDocGridButton", 1)+ "&nbsp;" + TemplateButtonText("TextExportDocGridButton", 0) %>' onclick="Export_Click" AutoPostBack="False" ClientIDMode="Static" runat="server"/>
            </li>
</ul>
        </li>
            <li>
    <TBfr:DBPL_Button ID="btnShowColumn_7" Text='<%# TemplateButtonText("IconShowGridColumnsButton", 1)+ "&nbsp;" + TemplateButtonText("TextShowGridColumnsButton", 0) %>' AutoPostBack="False" Width="100%" ClientIDMode="Static" runat="server">
        <ClientSideEvents Click="function(s,e){onShowCustomizationButtonClick(grid_7);}" />
    </TBfr:DBPL_Button>
            </li>
        </ul>
</asp:Content>