<%@ Page Language="C#" MasterPageFile="~/PL/PL_MasterPage.master" AutoEventWireup="true"
    CodeFile="PL_Sommaire.aspx.cs" Inherits="PL_Sommaire" Title="" %>

<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="Planning.NSP.nfw" Namespace="Planning.NSP" TagPrefix="TBfr" %>

<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderForm" runat="Server">
    <ul>
        <li>
            <TBfr:PL_ComboBox ID="Wfm" Caption="Mode de saisie" ClientIDMode="Static" runat="server" AutoPostBack="True" SelectedIndex="0">
                <Items>
                    <dx:ListEditItem Text="Défaut" Value="0" Selected="True" />
                    <dx:ListEditItem Text="Fiche seule" Value="1" />
                    <dx:ListEditItem Text="Batch" Value="2" />
                    <dx:ListEditItem Text="Popup" Value="3" />
                    <dx:ListEditItem Text="Fiche détail" Value="4" />
                    <dx:ListEditItem Text="Inline" Value="5" />
                </Items>
            </TBfr:PL_ComboBox>
        </li>
        <li class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS">
            <%--            <ul>
                <li class="TBfr_ACCORDION_HIDE_ALL_JS TBfr_ACCORDION_HIDE_ALL_CSS"></li>
                <li class="TBfr_ACCORDION_SHOW_ALL_JS TBfr_ACCORDION_SHOW_ALL_CSS"></li>
            </ul>--%>
            <ul>
                <li>Plannings</li>
                <li>
                    <ul>
                        <li>
                            <a href="../PL/APL_V_PL0_planning.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Plannings</a></li>
                        <li>
                            <TBfr:PL_ComboBox ClientIDMode="Static" ID="FiltreId_planning_0" runat="server" AutoPostBack="true" OnSelectedIndexChanged="FPFiltreId_planning_0_SelectedIndexChanged" />
                        </li>
                        <li>
                            <a href="../PL/APL_V_PL0_employe.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Employés</a></li>
                        <li>
                            <a href="../PL/APL_V_PL0_equipe.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Equipes</a></li>

                        <li id="Versions" runat="server">
                            <a href="../PL/APL_V_PL0_Version.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Versions</a></li>
                        <li>
                            <a href="../PL/APL_V_PL0_equipeemploye.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Attachement des employés aux équipes</a></li>
                        <%--                        <li id="Calendrier" runat="server">
                            <a href="../PL/APL_V_PL0_Calendrier.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Calendrier</a></li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Ephemeride" OnClick="PPL0_Ephemeride_Click"
                                runat="server" ID="PPL0_Ephemeride" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Unités horaires" OnClick="PPL0_UniteHoraire_Click"
                                runat="server" ID="PPL0_UniteHoraire" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés batch" OnClick="PPL0_EquipeEmployebatch_Click"
                                runat="server" ID="PPL0_Employe" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés inline" OnClick="PPL0_EquipeEmployeinline_Click"
                                runat="server" ID="PL_Button1" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés popup" OnClick="PPL0_EquipeEmployepopup_Click"
                                runat="server" ID="PL_Button2" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés form row" OnClick="PPL0_EquipeEmployeformrow_Click"
                                runat="server" ID="PL_Button3" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés grid visu" OnClick="PPL0_EquipeEmployegridvisu_Click"
                                runat="server" ID="PL_Button4" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés grid" OnClick="PPL0_EquipeEmployegrid_Click"
                                runat="server" ID="PL_Button5" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés grid detail" OnClick="PPL0_EquipeEmployegriddetail_Click"
                                runat="server" ID="PL_Button6" CssClass="bouton_appli" />
                       </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Equipes - Employés edit detail" OnClick="PPL0_EquipeEmployeeditdetail_Click"
                                runat="server" ID="PL_Button7" CssClass="bouton_appli" />
                         </li>--%>
                    </ul>
                </li>
            </ul>
            <ul>
                <li>Contraintes</li>
                <li>
                    <ul>
                        <li>
                            <a href="../PL/APL_V_PL0_CategorieContrainte.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Catégories de contraintes</a></li>
                        <li>
                            <a href="../PL/APL_V_PL0_Contrainte.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Contrainte</a></li>
                        <li>
                            <a href="../PL/APL_V_PL0_Realisation.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Réalisations</a></li>
                        <%--  <li>
                            <TBfr:PL_Button ClientIDMode="Static" ID="PPL0_Contrainte" runat="server" Text="Planning" OnClick="PPL0_Contrainte_Click" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" ID="PPL0_ContrainteMulti" runat="server" Text="Planning (saisie en grille)" OnClick="PPL0_ContrainteMulti_Click" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" ID="PPL0_ContrainteOrdo" runat="server" Text="Ordonnancement" OnClick="PPL0_ContrainteOrdo_Click" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" ID="PPL0_Planification" runat="server" Text="Planning calculé" OnClick="PPL0_Planification_Click" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" ID="PPL0_Realisation" runat="server" Text="Réalisations" OnClick="PPL0_Realisation_Click" />
                        </li>--%>
                    </ul>
                </li>
            </ul>
            <ul>
                <li>Paramètres de planning</li>
                <li>
                    <ul>
                        <li>
                            <a href="../PL/APL_V_PL0_TypeCategorie.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Types de catégories</a></li>
                        <li>
                            <a href="../PL/APL_V_PL0_Categorie.aspx?code=<%=IdAndCodeSession%><%=Parm%>">Catégories</a></li>

                        <%--     <ul>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Sociétés" OnClick="PPL0_Societe_Click"
                                runat="server" ID="PPL0_Societe" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Applications" OnClick="PPL0_Application_Click"
                                runat="server" ID="PPL0_Application" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Projets" OnClick="PPL0_Projet_Click"
                                runat="server" ID="PPL0_Projet" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Modes de travail" OnClick="PPL0_ModeTravail_Click"
                                runat="server" ID="PPL0_ModeTravail" CssClass="bouton_appli" />
                        </li>
                        <li class="td_bouton_appli" colspan="2">
                            <TBfr:PL_Button ClientIDMode="Static" Text="Actions" OnClick="PPL0_Action_Click"
                                runat="server" ID="PPL0_Action" CssClass="bouton_appli" />
                        </li>
                        <li class="td_bouton_appli" colspan="2">
                            <TBfr:PL_Button ClientIDMode="Static" Text="Types de tâches" OnClick="PPL0_TypeTache_Click"
                                runat="server" ID="PPL0_TypeTache" CssClass="bouton_appli" />
                        </li>
                        <li>
                            <TBfr:PL_Button ClientIDMode="Static" Text="Statuts" OnClick="PPL0_Statut_Click"
                                runat="server" ID="PPL0_Statut" CssClass="bouton_appli" />
                        </li>--%>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
    <%--Variables cachées--%>
    <%--Données persistentes à l'application--%>
    <%--Sources des combo box de filtre--%>
    <asp:SqlDataSource ID="SqlDataSourceFiltreId_planning_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
    <asp:SqlDataSource ID="SqlDataSourceFiltreId_version_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
    <asp:SqlDataSource ID="SqlDataSourceFiltreId_employe_0" ConnectionString="<%$ ConnectionStrings:SqlConnectionDataPL %>" runat="server" />
</asp:Content>
<asp:Content ID="ContentScripts" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <script language="JavaScript" type="text/javascript">
        window.onload = function () {
            window.scrollTo(0, 0);
        }
    </script>
</asp:Content>
