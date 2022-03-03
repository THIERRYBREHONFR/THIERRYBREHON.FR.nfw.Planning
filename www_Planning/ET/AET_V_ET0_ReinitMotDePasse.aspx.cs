// Généré par GENERATEUR.THIERRYBREHON.FR le 31/08/2021 19:03:13
using THIERRYBREHON.FR.NSP;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSR;
using System.Linq;
using System.Xml.Linq;
using THIERRYBREHON.FR.Web;
using THIERRYBREHON.FR.X;
using DevExpress.Web;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Thierry.NSB;
using Thierry.NSP;
using Thierry.NSS;
using Thierry.NSD;
using Thierry.NSR;
using THIERRYBREHON.FR.NSE;
public partial class AET_V_ET0_ReinitMotDePasse : ETForm
{
    #region création de l'écran

    /// <summary>
    /// Nombre de Fiches
    /// </summary>
    protected override int CardsCount => 1;

    #endregion

    #region preinit, valeurs obligatoires

    //protected override bool Page_PreInitRequiredParametersCheckOnFirstEntrance()
    //{
    //    if (!base.Page_PreInitRequiredParametersCheckOnFirstEntrance())
    //        return false;
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "cb") != null && Request.QueryString["cb"].IsNullOrEmpty()) // pas de valeur sélectionnée
    //        return false;
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "po") != null && Request.QueryString["po"].IsNullOrEmpty()) // pas de valeur sélectionnée
    //        return false;
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "pod") != null && Request.QueryString["pod"].IsNullOrEmpty()) // pas de valeur sélectionnée
    //        return false;
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "cb") == null)
    //        GoToNextScreen("TR/ATR_V_TR0_CompteBancaire_Poste.aspx", true,
    //          ((string)null).AppendStrings(C_Query_CardSeparator.ToString(), null, Request.QueryString["po"]),
    //          null, "cb" + C_Query_CardSeparator + "po", "E", true, null);
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "po") == null)
    //        GoToNextScreen("TR/ATR_V_TR0_CompteBancaire_Poste.aspx", true,
    //        Request.QueryString["cb"].AlternateValue("", null, Request.QueryString["cb"]).IfElse(This => This.IsNullOrEmpty(), _ => null, This => This + C_Query_CardSeparator.ToString()),
    //            null, "cb" + C_Query_CardSeparator + "po", "E", true, null);
    //    if (Request.QueryString.AllKeys.FirstOrDefault(x => x == "pod") == null)
    //        GoToNextScreen("TR/ATR_V_TR0_Poste.aspx", true, null, null, "pod", "E", true, null);
    //    return true;
    //}

    #endregion

    #region init   

    protected override void Page_InitList(int iCard, WebFormMode webFormMode)
    {
        if (iCard == 0)
        {
            base.Page_InitList(iCard, WebFormMode.DetailFormOnly);
            AssociatedTBfrBusinessCard[iCard] = new BET_V_ET0_MotDePasse(IStorageAccess);
            AssociatedITBfrStorageCard[iCard] = new SET_V_ET0_MotDePasse(IStorageAccess);
        }
    }

    #endregion










    #region gestion des libellés

    protected override string ObjectName => RET_V_ET0_MotDePasse.Object;
    protected override string PageTitle => "Réinitialisation du mot de passe";


    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Motdepasse_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_MotDePasse.C_Motdepasse);
                case "PV_Login_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_MotDePasse.C_Login);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "LblFilterMotdepasse":
                case "LblMotdepasse": return RET_V_ET0_MotDePasse.LblMotdepasse;
                case "LblFilterLogin":
                case "LblLogin": return RET_V_ET0_MotDePasse.LblLogin;
                case "LblMotdepasseConfirm": return "Confirmation du mot de passe";

            }
        return base.TemplateLabelValue(iCard, labelId);
    }
    #endregion

    protected override void ReadOnlyPopUp(int iCard, ITBfr_Control control, DataRowView row)
    {
        if (iCard == 0)
        {
            bool vReadOnly = false;
            if (row != null)
            {
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_MotDePasse.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

            switch (((Control)control).ID)
            {
                case "Motdepasse_0": control.ReadOnly = vReadOnly; return;
                case "MotdepasseConfirm_0": control.ReadOnly = vReadOnly; return;

                case "Login_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region determination d'une valeur en fonction d'un controle

    //protected override string ValueFromNull(int iCard, string sqlName)
    //{
    //    if (iCard == 0)
    //        switch (sqlName)
    //        {

    //        }
    //    return base.ValueFromNull(iCard, sqlName);
    //}

    //protected override string ValueFromD(int iCard, string sqlName, string forControlId, TBfrData_List data_List, ITBfrStorageView storageView)
    //{
    //    var vResult = base.ValueFromD(iCard, sqlName, forControlId, data_List, storageView);
    //    if (iCard == 0)
    //        switch (forControlId)
    //        {
    //            // case "Id_0": return vResult;
    //            // case "Motdepasse_0": return vResult;

    //            // case "Login_0": return vResult;

    //        }
    //    return vResult;
    //}

    #endregion

    protected override bool LoadAndCheckBeforeUpdate(int iCard, object e)
    {
        bool vResult = base.LoadAndCheckBeforeUpdate(iCard, e);
        if (Motdepasse_0.Valeur != MotdepasseConfirm_0.Valeur)
        {
            Errors[0].AddError(MotdepasseConfirm_0, null, RET.NConfirmationMotDePasse, RET.ConfirmationMotDePasse );
            vResult = false;
        }
        return vResult;
    }

    protected override void Event_Validate(int iCard)
    {
        base.Event_Validate(iCard);
        if (CurrentCardState[iCard] == CardState.NoOperation)
        {
            IBusinessSession.Close(IdAndCodeSession);
            Motdepasse_0.Valeur = null;
            MotdepasseConfirm_0.Valeur = null;
        }
    }

}

