<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PL_SaveRestauModel.ascx.cs"
    Inherits="PL_SaveRestauModel" %>
<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web"
    TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Planning.NSP.nfw" Namespace="Planning.NSP" TagPrefix="TBfr" %>
<%--Sources des combo box de gestion des modèles--%>
<asp:SqlDataSource ID="FSqlDataSourceMdlStd" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlPerso" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlAutre" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlPersoModif" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<TBfr:TBfr_PopupControl ID="FSaveModelPopup" runat="server" CloseAction="CloseButton" Modal="True"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="FSaveModelPopup"
    HeaderText="Sauvegarde du modèle" AllowDragging="True" PopupAnimationType="Auto"
    EnableViewState="False" Width="500px">
    <ClientSideEvents PopUp="function(s, e) { FNomModeleSave.Focus(); }" />
    <ContentCollection>
        <dx:PopupControlContentControl>
            <ul>
                <li>Créer un nouveau modèle, en spécifiant son nom : </li>
                <li>
                    <TBfr:PL_TextBox ID="FNomModeleSave" ClientIDMode="static" runat="server" />
                </li>
                <li>Ou modifier le modèle choisi dans la liste déroulante : </li>
                <li>
                    <TBfr:PL_ComboBox ID="FId_ModeleSave"
                        DataSourceID="FSqlDataSourceMdlPersoModif" TextField="NomModele" ValueField="Id" ClientIDMode="static" runat="server" />
                </li>
                <li>(Pour renommer un modèle, renseignez les deux zones)</li>
                <li>
                    <TBfr:PL_Button ID="FOKSaveModel" Text="Enregistrer" Width="100px" runat="server">
                        <ClientSideEvents Click="function(s, e) { FSaveModelPopup.Hide(); }" />
                    </TBfr:PL_Button>
                </li>
                <li>
                    <TBfr:PL_Button ID="FCancelSaveModel" Text="Annuler" Width="100px" AutoPostBack="False" runat="server">
                        <ClientSideEvents Click="function(s, e) { FSaveModelPopup.Hide(); }" />
                    </TBfr:PL_Button>
                </li>
            </ul>
        </dx:PopupControlContentControl>
    </ContentCollection>
</TBfr:TBfr_PopupControl>
<TBfr:TBfr_PopupControl ID="FRestauModelPopup" runat="server" CloseAction="CloseButton" Modal="True"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="FRestauModelPopup"
    HeaderText="Appliquer un modèle" AllowDragging="True" PopupAnimationType="Auto"
    EnableViewState="False">
    <ClientSideEvents PopUp="function(s, e) { FId_ModelePerso.Focus(); }" />
    <ContentCollection>
        <dx:PopupControlContentControl>
            <table>
                <tr id="MdlStd" runat="server" visible="true">
                    <td>Choisissez un modèle standard
                    </td>
                    <td>
                        <TBfr:PL_ComboBox runat="server" ID="FId_ModeleStd" ClientInstanceName="FId_ModeleStd"
                            DataSourceID="FSqlDataSourceMdlStd" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModelePerso.SetSelectedIndex(-1); PId_ModeleAutre.SetSelectedIndex(-1); }" />
                    </td>
                </tr>
                <tr id="MdlPerso" runat="server" visible="true">
                    <td>Ou un modèle personnel
                    </td>
                    <td>
                        <TBfr:PL_ComboBox runat="server" ID="FId_ModelePerso" ClientInstanceName="FId_ModelePerso"
                            DataSourceID="FSqlDataSourceMdlPerso" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModeleStd.SetSelectedIndex(-1); PId_ModeleAutre.SetSelectedIndex(-1); }" />
                    </td>
                </tr>
                <tr id="MdlAutre" runat="server" visible="true">
                    <td>Ou un modèle d'une autre personne
                    </td>
                    <td>
                        <TBfr:PL_ComboBox runat="server" ID="FId_ModeleAutre" ClientInstanceName="FId_ModeleAutre"
                            DataSourceID="FSqlDataSourceMdlAutre" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModeleStd.SetSelectedIndex(-1); PId_ModelePerso.SetSelectedIndex(-1); }" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <TBfr:PL_Button ID="FOKRestauModel" runat="server" Text="Appliquer" Width="100px">
                            <ClientSideEvents Click="function(s, e) { FRestauModelPopup.Hide(); }" />
                        </TBfr:PL_Button>
                    </td>
                    <td>
                        <TBfr:PL_Button ID="FCancelRestauModel" runat="server" Text="Annuler" Width="100px"
                            AutoPostBack="False">
                            <ClientSideEvents Click="function(s, e) { FRestauModelPopup.Hide(); }" />
                        </TBfr:PL_Button>
                    </td>
                </tr>
            </table>
        </dx:PopupControlContentControl>
    </ContentCollection>
</TBfr:TBfr_PopupControl>
