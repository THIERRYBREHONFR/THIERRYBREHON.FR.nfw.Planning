<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ET_PopupExport.ascx.cs"
    Inherits="ET_PopupExport" %>
<%@ Register Assembly="DevExpress.Web.v21.2" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="THIERRYBREHON.FR.Web.nfw" Namespace="THIERRYBREHON.FR.Web" TagPrefix="TBfr" %>
<%@ Register Assembly="Thierry.NSP.nfw" Namespace="Thierry.NSP" TagPrefix="TBfr" %>
<TBfr:TBfr_PopupControl ID="ExportDoc" runat="server" CloseAction="CloseButton" Modal="True"
    Width="500px" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter"
    ClientInstanceName="ExportDoc" HeaderText="Export" AllowDragging="True" PopupAnimationType="Auto"
    EnableViewState="False">
    <contentcollection>
            <dx:PopupControlContentControl>
                <table>f
                 <tr id="FCompatibiliteImport" runat="server" visible="false">
                        <td style="background-color: Silver; vertical-align: top;">
                            Compatibilité import
                        </td>
                        <td style="background-color: #DDDDDD; vertical-align: top;">
                            <table>
                              <tr>
                                   <td colspan="4">
                                        <TBfr:ET_CheckBox ID="FExpImp" Checked="false" ClientInstanceName="ExpImp" 
                                            Text="En cochant cette case, vous exportez dans un Format excel compatible avec l'import." runat="server" />
                                    </td>
                                </tr>  
                                <tr>
                                   <td colspan="4">
                                             Dans ce cas, les options ci-dessous sont inutiles.
                                     </td>
                                </tr>   
                            </table>
                        </td>
                    </tr>
                            <tr id="FLikeOnScreenVisible" runat="server" >
                <td style="background-color: Silver; vertical-align: top;">
                            Données exportées
                        </td>
                        <td style="background-color: #DDDDDD; vertical-align: top;">
                            <table>
                                <tr>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FDataLikeOnScreen" Checked="true" Text="Exporter tel qu'à l'écran"
                                            GroupName="PreservationGroupes" runat="server" />
                                    </td>
                                    <td>
                                        TOUTES les pages sont exportées, mais pas les données masquées.
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <TBfr:ET_RadioButton  Checked="false" Text="Exporter toutes les données"
                                            GroupName="PreservationGroupes" runat="server" />
                                    </td>
                                    <td>
                                        Attention le temps de réponse peut être conséquent
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: Silver; vertical-align: top;">
                            Format du fichier
                        </td>
                        <td style="background-color: #DDDDDD; vertical-align: top;">
                            <table>
                                <tr>
                                    <td>
                                        Formats mis en forme
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FPdf" Checked="false" ClientInstanceName="Pdf" GroupName="FormatFichier"
                                            Text="*.pdf" runat="server" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FXls" Checked="false" ClientInstanceName="Xls" GroupName="FormatFichier"
                                            Text="*.xls" runat="server" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FXlsx" Checked="false" ClientInstanceName="XlsX" GroupName="FormatFichier"
                                            Text="*.xlsx" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Formats bruts
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FCsv" Checked="false" ClientInstanceName="Csv" GroupName="FormatFichier"
                                            Text="*.csv" runat="server" visible="false" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FXlsBrut" Checked="false" ClientInstanceName="XlsBrut" GroupName="FormatFichier"
                                            Text="*.xls" runat="server" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FXlsxBrut" Checked="true" ClientInstanceName="XlsxBrut"
                                            GroupName="FormatFichier" Text="*.xlsx" runat="server" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr id="specialpdf">
                        <td style="background-color: Silver; vertical-align: top;">
                            Format du document (APPLICABLE UNIQUEMENT AU FORMAT PDF)
                        </td>
                        <td style="background-color: #DDDDDD; vertical-align: top;">
                            <table>
                                <tr>
                                    <td>
                                        Papier
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FA4" Checked="true" GroupName="FormatPapier" Text="A4" runat="server" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FA3" Checked="false" GroupName="FormatPapier" Text="A3" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Orientation
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FPaysage" Checked="true" GroupName="Orientation" Text="Paysage"
                                            runat="server" />
                                    </td>
                                    <td>
                                        <TBfr:ET_RadioButton ID="FPortrait" Checked="false" GroupName="Orientation" Text="Portrait"
                                            runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <table>
                                            <tr>
                                                <td colspan="4" style="text-align: center;">
                                                    Marges (mm)
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td style="text-align: right;">
                                                    Haut
                                                </td>
                                                <td>
                                                    <TBfr:ET_TextBox ID="FTopMargin" runat="server" Text="30" />
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Gauche
                                                </td>
                                                <td>
                                                    <TBfr:ET_TextBox ID="FLeftMargin" runat="server" Text="10" />
                                                </td>
                                                <td style="text-align: right;">
                                                    Droite
                                                </td>
                                                <td>
                                                    <TBfr:ET_TextBox ID="FRightMargin" runat="server" Text="10" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td style="text-align: right;">
                                                    Bas
                                                </td>
                                                <td>
                                                    <TBfr:ET_TextBox ID="FBottomMargin" runat="server" Text="10" />
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: Silver; vertical-align: top;">
                        </td>
                        <td style="background-color: #DDDDDD; vertical-align: top;">
                            <table>
                                <tr>
                                    <td>
                                        <TBfr:ET_Button ID="FExportButton" runat="server" Text="Exporter" Width="100px">
                                            <ClientSideEvents Click="function(s, e) { ExportDoc.Hide(); }" />
                                        </TBfr:ET_Button>
                                    </td>
                                    <td>
                                        <TBfr:ET_Button runat="server" Text="Annuler" Width="100px" AutoPostBack="False">
                                            <ClientSideEvents Click="function(s, e) { ExportDoc.Hide(); }" />
                                        </TBfr:ET_Button>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </dx:PopupControlContentControl>
        </contentcollection>
</TBfr:TBfr_PopupControl>
