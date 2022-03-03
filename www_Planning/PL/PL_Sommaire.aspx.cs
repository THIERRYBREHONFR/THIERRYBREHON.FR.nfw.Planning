using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Planning.NSP;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.NSS;
using Planning.NSS;
using Planning.NSD;
using Planning.NSB;
using THIERRYBREHON.FR.NSR;
using Planning.NSR;
using THIERRYBREHON.FR.NSP;

public partial class PL_Sommaire : PLForm
{

    //protected string Parm => null;// ((string)null).AppendStrings("&", "&",
                                  //(Compte_Ecriture.Valeur.ToLongOrDefault(default) != 0 ? "cb=" + Compte_Ecriture.Valeur : null),
                                  //Wfm.Valeur.ToLongOrDefault(default) != 0 ? $"{C_Query_WebFormMode}={Wfm.Valeur.ToString()}" : null);


    protected override string ObjectName => "Sommaire";
    protected override string PageTitle => "Sommaire";







    //private string Parmplanning(long VId_planning)
    //{
    //    var VParametres = new TBfrStorageParameters();
    //    VParametres.Condition = VParametres.Condition.AppendStrings(null, " and ",
    //        new SPL_V_PLC_Employe(IStorageAccess).DbNameForWhere(DPL_V_PLC_Employe.C_Id_planning) + "=" + VId_planning.ToSql());
    //    VParametres.Top = "1";
    //    var VTPLC_Employe = (DPL_V_PLC_Employe)new BPL_V_PLC_Employe(IStorageAccess).ReadOneRow(VParametres, null);
    //    if (VTPLC_Employe == null) throw new ArgumentException();
    //    return RPL.ParmPlanning + "=" + VId_planning.ToString() + "&" + RPL.ParmEmploye + "=" + VTPLC_Employe.Id.ToString();
    //}

    protected void PPL0_Contrainte_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Contrainte.aspx");

    protected void PPL0_Planification_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Planification.aspx");

    protected void PPL0_ContrainteMulti_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_ContrainteMulti.aspx");

    protected void PPL0_Realisation_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Realisation.aspx");


    protected void PPL0_ContrainteOrdo_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_ContrainteOrdo.aspx");

    protected void PPL0_Ephemeride_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Ephemeride.aspx");

    protected void PPL0_Calendrier_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Calendrier.aspx");

    protected void PPL0_UniteHoraire_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_UniteHoraire.aspx");

    protected void PPL0_EquipeEmployebatch_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_editbatch.aspx", false, eqempfilterids, reqoperations, null, null, false, null);

    protected void PPL0_EquipeEmployeinline_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_editinline.aspx", false, eqempfilterids, reqoperations, null, null, false, null);

    protected void PPL0_EquipeEmployepopup_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_editpopup.aspx", false, eqempfilterids, reqoperations, null, null, false, null);

    protected void PPL0_EquipeEmployeformrow_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_editformrow.aspx", false, eqempfilterids, reqoperations, null, null, false, null);

    protected void PPL0_EquipeEmployegridvisu_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_gridvisu.aspx", false, eqempfilterids, reqoperations, null, null, false, null);

    protected void PPL0_EquipeEmployegriddetail_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_griddetail.aspx", false, eqempfilterids, reqoperations, null, null, false, null);
    protected void PPL0_EquipeEmployeeditdetail_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_editdetail.aspx", false, eqempfilterids, reqoperations, null, null, false, null);
    protected void PPL0_EquipeEmployegrid_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_EquipeEmploye_grid.aspx", false, eqempfilterids, reqoperations, null, null, false, null);
    protected void PPL0_EquipeEmploye_Click(object sender, EventArgs e)
    {
    }
    string eqempfilterids = "3398760" + C_Query_CardSeparator + "3398758";
    //string reqoperations = TBfrConst.Delete.ToString() + C_Query_FormSeparator + TBfrConst.Delete.ToString();
    string reqoperations = TBfrConst.Update.ToString() + C_Query_CardSeparator + TBfrConst.Update.ToString();
    protected void PPL0_Societe_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Societe.aspx");

    protected void PPL0_Application_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Application.aspx");

    protected void PPL0_Projet_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Projet.aspx");

    protected void PPL0_ModeTravail_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_ModeTravail.aspx");

    protected void PPL0_Action_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Action.aspx");

    protected void PPL0_TypeTache_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_TypeTache.aspx");

    protected void PPL0_Statut_Click(object sender, EventArgs e) => GoToNextScreen("PL/PL0_Statut.aspx");

}