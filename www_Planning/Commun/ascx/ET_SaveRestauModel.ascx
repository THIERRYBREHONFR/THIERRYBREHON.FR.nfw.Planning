<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ET_SaveRestauModel.ascx.cs"
    Inherits="ET_SaveRestauModel" %>
<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web"
    TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>
<%--Sources des combo box de gestion des modèles--%>
<asp:SqlDataSource ID="FSqlDataSourceMdlStd" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlPerso" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlAutre" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<asp:SqlDataSource ID="FSqlDataSourceMdlPersoModif" runat="server" ConnectionString="<%$ ConnectionStrings:SqlConnectionService %>" />
<TBfr:TBfr_PopupControl ID="SaveModel" runat="server" CloseAction="CloseButton" Modal="True"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="SaveModel"
    HeaderText="Sauvegarde du modèle" AllowDragging="True" PopupAnimationType="Auto"
    EnableViewState="False" Width="500px">
    <clientsideevents popup="function(s, e) { NomModeleSave.Focus(); }" />
    <contentcollection>
            <dx:PopupControlContentControl>
                <ul>
                    <li>Pour créer un nouveau modèle, saisissez un nom de modèle dans la zone de saisie.</li>
                    <li>Pour modifier un modèle existant, choisissez le dans la liste déroulante</li>
                    <li>Pour modifier un modèle existant et le renommer, choisissez le dans la boite déroulante,
                        et saisissez le nouveau nom dans la zone de saisie. </li>
                </ul>
                <table>
                    <tr>
                        <td>
                            Zone de saisie d'un nouveau nom
                        </td>
                        <td rowspan="2">
                        </td>
                        <td>
                            Liste déroulante des modèles existants
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <TBfr:ET_TextBox runat="server" ID="FNomModeleSave" ClientInstanceName="NomModeleSave" />
                        </td>
                        <td>
                            <TBfr:ET_ComboBox runat="server" ID="FId_ModeleSave" ClientInstanceName="Id_ModeleSave"
                                DataSourceID="FPSqlDataSourceMdlPersoModif" TextField="NomModele" ValueField="Id" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <TBfr:ET_Button ID="FOKSaveModel" runat="server" Text="Enregistrer" Width="100px" >
                                <ClientSideEvents Click="function(s, e) { SaveModel.Hide(); }" />
                            </TBfr:ET_Button>
                        </td>
                        <td>
                            <TBfr:ET_Button ID="FCancelSaveModel" runat="server" Text="Annuler" Width="100px"
                                AutoPostBack="False">
                                <ClientSideEvents Click="function(s, e) { SaveModel.Hide(); }" />
                            </TBfr:ET_Button>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </contentcollection>
</TBfr:TBfr_PopupControl>
<TBfr:TBfr_PopupControl ID="RestauModel" runat="server" CloseAction="CloseButton" Modal="True"
    PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" ClientInstanceName="RestauModel"
    HeaderText="Appliquer un modèle" AllowDragging="True" PopupAnimationType="Auto"
    EnableViewState="False">
    <clientsideevents popup="function(s, e) { Id_ModelePerso.Focus(); }" />
    <contentcollection>
            <dx:PopupControlContentControl>
                <table>
                    <tr id ="MdlStd" runat="server" visible="true">
                        <td>
                            Choisissez un modèle standard
                        </td>
                        <td>
                            <TBfr:ET_ComboBox runat="server" ID="FId_ModeleStd" ClientInstanceName="Id_ModeleStd"
                                DataSourceID="FPSqlDataSourceMdlStd" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModelePerso.SetSelectedIndex(-1); PId_ModeleAutre.SetSelectedIndex(-1); }" />
                        </td>
                    </tr>
                    <tr id ="MdlPerso" runat="server" visible="true">
                        <td>
                            Ou un modèle personnel
                        </td>
                        <td>
                            <TBfr:ET_ComboBox runat="server" ID="FId_ModelePerso" ClientInstanceName="Id_ModelePerso"
                                DataSourceID="FPSqlDataSourceMdlPerso" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModeleStd.SetSelectedIndex(-1); PId_ModeleAutre.SetSelectedIndex(-1); }" />
                        </td>
                    </tr>
                    <tr id ="MdlAutre" runat="server" visible="true">
                        <td>
                            Ou un modèle d'une autre personne
                        </td>
                        <td>
                            <TBfr:ET_ComboBox runat="server" ID="FId_ModeleAutre" ClientInstanceName="Id_ModeleAutre"
                                DataSourceID="FPSqlDataSourceMdlAutre" TextField="NomModele" ValueField="Id" ClientSideEvents-SelectedIndexChanged="function(s, e) { PId_ModeleStd.SetSelectedIndex(-1); PId_ModelePerso.SetSelectedIndex(-1); }" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <TBfr:ET_Button ID="FOKRestauModel" runat="server" Text="Appliquer" Width="100px" >
                                <ClientSideEvents Click="function(s, e) { RestauModel.Hide(); }" />
                            </TBfr:ET_Button>
                        </td>
                        <td>
                            <TBfr:ET_Button ID="FCancelRestauModel"  runat="server" Text="Annuler" Width="100px"
                                AutoPostBack="False">
                                <ClientSideEvents Click="function(s, e) { RestauModel.Hide(); }" />
                            </TBfr:ET_Button>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </contentcollection>
</TBfr:TBfr_PopupControl>
