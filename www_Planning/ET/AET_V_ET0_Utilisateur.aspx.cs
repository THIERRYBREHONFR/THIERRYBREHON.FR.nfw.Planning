// Généré par GENERATEUR.THIERRYBREHON.FR le 31/08/2021 10:43:45
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

public partial class AET_V_ET0_Utilisateur : ETForm
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
            GridViewsList[iCard] = grid_0;
            GridViewsList[iCard].DataSource = SqlDataSourceGrid_0;
            base.Page_InitList(iCard, WebFormMode.PopupEditForm);

            AssociatedTBfrBusinessCard[iCard] = new BET_V_ET0_Utilisateur(IStorageAccess);
            AssociatedITBfrStorageCard[iCard] = new SET_V_ET0_Utilisateur(IStorageAccess);
        }
    }

    #endregion

    #region load

    //protected override void Page_LoadGridView(object sender, EventArgs e)
    //{
    //    base.Page_LoadGridView(sender, e);
    //    if (IsFirstEntrance)
    //    {
    ////        Positionnement de filtres, etc en fonction de paramètres transmis à l'écran
    //        if (Request.Params["cb"].IsCompleted())
    //            grid_0.AutoFilterByColumn(grid_0.Columns[AssociatedITBfrStorageCard[0].DbNameForOrderBy(DTR_V_TR0_Releve.C_Id_comptebancaire)], Request.Params["cb"]);
    //        grid_0.DataColumns[AssociatedITBfrStorageCard[0].DbNameForOrderBy(DTR_V_TR0_Releve.C_Debut)].Settings.AutoFilterCondition = AutoFilterCondition.LessOrEqual;
    //        grid_0.AutoFilterByColumn(grid_0.Columns[AssociatedITBfrStorageCard[0].DbNameForOrderBy(DTR_V_TR0_Releve.C_Debut)], DateTime.Now.AddMonths(-18).ToString("yyyy-MM-dd"));//"MM/dd/yyyy") );
    //    }
    //}

    #endregion

    #region prerender

    protected override void Page_PreRenderInitFilterCombos(int iCard)
    {
        base.Page_PreRenderInitFilterCombos(iCard);
        if (iCard == 0)
        {

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 0)
        {
            //if (FiltrePrenom_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Prenom, FilterCombosParameters[iCard].ViewPrefix) +  FiltrePrenom_0.Valeur.ToSqlLike(true));
            //if (FiltreLogin_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Login, FilterCombosParameters[iCard].ViewPrefix) +  FiltreLogin_0.Valeur.ToSqlLike(true));
            //if (FiltreTr_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Tr_visu, FilterCombosParameters[iCard].ViewPrefix) + FiltreTr_visu_0.Valeur.ToSqlLike(true));
            //if (FiltreCo_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Co_visu, FilterCombosParameters[iCard].ViewPrefix) + FiltreCo_visu_0.Valeur.ToSqlLike(true));
            //if (FiltreCa_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Ca_visu, FilterCombosParameters[iCard].ViewPrefix) + FiltreCa_visu_0.Valeur.ToSqlLike(true));
            //if (FiltrePt_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Pt_visu, FilterCombosParameters[iCard].ViewPrefix) + FiltrePt_visu_0.Valeur.ToSqlLike(true));
            //if (FiltreAv_prendre_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Av_prendre, FilterCombosParameters[iCard].ViewPrefix) +  FiltreAv_prendre_0.Valeur.ToSqlLike(true));
            //if (FiltreTa_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Ta_visu, FilterCombosParameters[iCard].ViewPrefix) +  FiltreTa_visu_0.Valeur.ToSqlLike(true));
            //if (FiltreSo_visu_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_So_visu, FilterCombosParameters[iCard].ViewPrefix) + FiltreSo_visu_0.Valeur.ToSqlLike(true));
            //if (FiltreId_espaceclient_0.Valeur.ToLongOrDefault(-1) != -1)

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Id_espaceclient, FilterCombosParameters[iCard].ViewPrefix) + "=" + FiltreId_espaceclient_0.Valeur.ToSqlLong());
            //if (FiltreMail_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Mail, FilterCombosParameters[iCard].ViewPrefix) +  FiltreMail_0.Valeur.ToSqlLike(true));
            //if (FiltreNom_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Nom, FilterCombosParameters[iCard].ViewPrefix) + FiltreNom_0.Valeur.ToSqlLike(true));
            //if (FiltreFeminin_0.Valeur.IsCompleted())

            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Feminin, FilterCombosParameters[iCard].ViewPrefix) + FiltreFeminin_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false;

    // protected override void FW_FiltresReadOnly_2(int iCard, Boolean readOnly)
    // { // prise en charge des cas standards par webpagegestion 
    //     base.FW_FiltresReadOnly_2(iCard, readOnly);
    //     if (iCard == 0)
    //     {
    //         FiltrePrenom_0.ReadOnly = readOnly;
    //         FiltreLogin_0.ReadOnly = readOnly;
    //         FiltreTr_visu_0.ReadOnly = readOnly;
    //         FiltreCo_visu_0.ReadOnly = readOnly;
    //         FiltreCa_visu_0.ReadOnly = readOnly;
    //         FiltrePt_visu_0.ReadOnly = readOnly;
    //         FiltreAv_prendre_0.ReadOnly = readOnly;
    //         FiltreTa_visu_0.ReadOnly = readOnly;
    //         FiltreSo_visu_0.ReadOnly = readOnly;
    //         FiltreId_espaceclient_0.ReadOnly = readOnly;
    //         FiltreMail_0.ReadOnly = readOnly;
    //         FiltreNom_0.ReadOnly = readOnly;
    //         FiltreFeminin_0.ReadOnly = readOnly;

    //     }
    // }

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RET_V_ET0_Utilisateur.Object;
    protected override string PageTitle => RET_V_ET0_Utilisateur.TitrePage;


    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Prenom_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Prenom);
                case "PV_Login_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Login);
                case "PV_Tr_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Tr_visu);
                case "PV_Co_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Co_visu);
                case "PV_Ca_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ca_visu);
                case "PV_Pt_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Pt_visu);
                case "PV_Av_prendre_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Av_prendre);
                case "PV_Ta_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ta_visu);
                case "PV_So_visu_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_So_visu);
                case "PV_Id_espaceclient_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Id_espaceclient);
                case "PV_Mail_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Mail);
                case "PV_Nom_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Nom);
                case "PV_Feminin_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Feminin);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "LblFilterPrenom":
                case "LblPrenom": return RET_V_ET0_Utilisateur.LblPrenom;
                case "LblFilterLogin":
                case "LblLogin": return RET_V_ET0_Utilisateur.LblLogin;
                case "LblFilterTr_visu":
                case "LblTr_visu": return RET_V_ET0_Utilisateur.LblTr_visu;
                case "LblFilterCo_visu":
                case "LblCo_visu": return RET_V_ET0_Utilisateur.LblCo_visu;
                case "LblFilterCa_visu":
                case "LblCa_visu": return RET_V_ET0_Utilisateur.LblCa_visu;
                case "LblFilterPt_visu":
                case "LblPt_visu": return RET_V_ET0_Utilisateur.LblPt_visu;
                case "LblFilterAv_prendre":
                case "LblAv_prendre": return RET_V_ET0_Utilisateur.LblAv_prendre;
                case "LblFilterTa_visu":
                case "LblTa_visu": return RET_V_ET0_Utilisateur.LblTa_visu;
                case "LblFilterSo_visu":
                case "LblSo_visu": return RET_V_ET0_Utilisateur.LblSo_visu;
                case "LblFilterId_espaceclient":
                case "LblId_espaceclient": return RET_V_ET0_Utilisateur.LblId_espaceclient;
                case "LblFilterMail":
                case "LblMail": return RET_V_ET0_Utilisateur.LblMail;
                case "LblFilterNom":
                case "LblNom": return RET_V_ET0_Utilisateur.LblNom;
                case "LblFilterFeminin":
                case "LblFeminin": return RET_V_ET0_Utilisateur.LblFeminin;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

            switch (((Control)control).ID)
            {
                case "Prenom_0": control.ReadOnly = vReadOnly; return;
                case "Login_0": control.ReadOnly = vReadOnly; return;
                case "Tr_visu_0": control.ReadOnly = vReadOnly; return;
                case "Co_visu_0": control.ReadOnly = vReadOnly; return;
                case "Ca_visu_0": control.ReadOnly = vReadOnly; return;
                case "Pt_visu_0": control.ReadOnly = vReadOnly; return;
                case "Av_prendre_0": control.ReadOnly = vReadOnly; return;
                case "Ta_visu_0": control.ReadOnly = vReadOnly; return;
                case "So_visu_0": control.ReadOnly = vReadOnly; return;
                case "Id_espaceclient_0": control.ReadOnly = vReadOnly; return;
                case "Mail_0": control.ReadOnly = vReadOnly; return;
                case "Nom_0": control.ReadOnly = vReadOnly; return;
                case "Feminin_0": control.ReadOnly = vReadOnly; return;

                case "EF_Prenom_0": control.ReadOnly = vReadOnly; return;
                case "EF_Login_0": control.ReadOnly = vReadOnly; return;
                case "EF_Tr_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_Co_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_Ca_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_Pt_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_Av_prendre_0": control.ReadOnly = vReadOnly; return;
                case "EF_Ta_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_So_visu_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_espaceclient_0": control.ReadOnly = vReadOnly; return;
                case "EF_Mail_0": control.ReadOnly = vReadOnly; return;
                case "EF_Nom_0": control.ReadOnly = vReadOnly; return;
                case "EF_Feminin_0": control.ReadOnly = vReadOnly; return;


            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Nom);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
            GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Prenom), null);


            GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Login), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Tr_visu), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Co_visu), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ca_visu), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Pt_visu), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Av_prendre), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ta_visu), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_So_visu), null);


            GridViewsList[iCard].AddComboBoxDirectColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Id_espaceclient), null);

            GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Mail), null);


            GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Nom), null);


            GridViewsList[iCard].AddCheckColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Feminin), null);



        }
    }

    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnPrenom_0(iCard, -1, null, null);
            AlterColumnLogin_0(iCard, -1, null, null);
            AlterColumnTr_visu_0(iCard, -1, null, null);
            AlterColumnCo_visu_0(iCard, -1, null, null);
            AlterColumnCa_visu_0(iCard, -1, null, null);
            AlterColumnPt_visu_0(iCard, -1, null, null);
            AlterColumnAv_prendre_0(iCard, -1, null, null);
            AlterColumnTa_visu_0(iCard, -1, null, null);
            AlterColumnSo_visu_0(iCard, -1, null, null);
            AlterColumnId_espaceclient_0(iCard, -1, null, null);
            AlterColumnMail_0(iCard, -1, null, null);
            AlterColumnNom_0(iCard, -1, null, null);
            AlterColumnFeminin_0(iCard, -1, null, null);


        }
    }

    private GridViewDataColumn AlterColumnPrenom_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Prenom), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Prenom), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdPrenom, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpPrenom, null);


    private GridViewDataColumn AlterColumnLogin_0(int iCard, Unit width, string labelGrid, string toolTip)
               => GridViewsList[iCard].AlterTextColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Login), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Login), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdLogin, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpLogin, null);


    private GridViewDataColumn AlterColumnTr_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Tr_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Tr_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdTr_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpTr_visu);


    private GridViewDataColumn AlterColumnCo_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Co_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Co_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdCo_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpCo_visu);


    private GridViewDataColumn AlterColumnCa_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ca_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ca_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdCa_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpCa_visu);


    private GridViewDataColumn AlterColumnPt_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Pt_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Pt_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdPt_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpPt_visu);


    private GridViewDataColumn AlterColumnAv_prendre_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Av_prendre), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Av_prendre), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdAv_prendre, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpAv_prendre);


    private GridViewDataColumn AlterColumnTa_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ta_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Ta_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdTa_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpTa_visu);


    private GridViewDataColumn AlterColumnSo_visu_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_So_visu), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_So_visu), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdSo_visu, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpSo_visu);


    private GridViewDataColumn AlterColumnId_espaceclient_0(int iCard, Unit width, string labelGrid, string toolTip)
           => GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Id_espaceclient), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DET_V_ET0_Utilisateur.C_Id_espaceclient, labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdId_espaceclient, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpId_espaceclient,
           null, SqlDataSourceGridId_espaceclient_0, new SET_V_ET0_EspaceClient(IStorageAccess));

    private GridViewDataColumn AlterColumnMail_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Mail), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Mail), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdMail, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpMail, null);


    private GridViewDataColumn AlterColumnNom_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Nom), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Nom), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdNom, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpNom, null);


    private GridViewDataColumn AlterColumnFeminin_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Feminin), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DET_V_ET0_Utilisateur.C_Feminin), labelGrid.IsCompleted() ? labelGrid : RET_V_ET0_Utilisateur.LgdFeminin, toolTip.IsCompleted() ? toolTip : RET_V_ET0_Utilisateur.TtpFeminin);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {
            //Id_espaceclient
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DET_V_ET0_Utilisateur.C_Id_espaceclient, vParameters,
            SqlDataSourceGridId_espaceclient_0, new SET_V_ET0_EspaceClient(IStorageAccess));

        }
    }

    #endregion

    protected override void InitPopupControls(int iCard, Control control)
    {
        base.InitPopupControls(iCard, control);
        if (iCard == 0)
            switch (control.ID)
            {
                case "Id_espaceclient_0":
                    ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_espaceclient_0"),
                         new SET_V_ET0_EspaceClient(IStorageAccess), SqlDataSourceId_espaceclient_0, null, null, true, false);
                    break;
                case "Tr_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Tr_visu_0"); break;
                case "Co_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Co_visu_0"); break;
                case "Ca_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Ca_visu_0"); break;
                case "Pt_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Pt_visu_0"); break;
                case "Av_prendre_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Av_prendre_0"); break;
                case "Ta_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Ta_visu_0"); break;
                case "So_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_So_visu_0"); break;
                case "Logicaldeleted_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Logicaldeleted_0"); break;
                case "Feminin_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Feminin_0"); break;

                case "EF_Id_espaceclient_0":
                    ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_espaceclient_0"),
                         new SET_V_ET0_EspaceClient(IStorageAccess), SqlDataSourceId_espaceclient_0, null, null, true, false);
                    break;
                case "EF_Tr_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Tr_visu_0"); break;
                case "EF_Co_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Co_visu_0"); break;
                case "EF_Ca_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Ca_visu_0"); break;
                case "EF_Pt_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Pt_visu_0"); break;
                case "EF_Av_prendre_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Av_prendre_0"); break;
                case "EF_Ta_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Ta_visu_0"); break;
                case "EF_So_visu_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_So_visu_0"); break;
                case "EF_Logicaldeleted_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Logicaldeleted_0"); break;
                case "EF_Feminin_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Feminin_0"); break;

            }
    }

    #region determination d'une valeur en fonction d'un controle

    protected override string ValueFromD(int iCard, string sqlName, string forControlId, TBfrData_List data_List, ITBfrStorageView storageView)
    {
        var vResult = base.ValueFromD(iCard, sqlName, forControlId, data_List, storageView);
        if (iCard == 0)
            switch (forControlId)
            {
                // case "Id_0": return vResult;
                // case "Prenom_0": return vResult;
                // case "Login_0": return vResult;
                // case "Tr_visu_0": return vResult;
                case "Lib_Tr_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Tr_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Co_visu_0": return vResult;
                case "Lib_Co_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Co_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Ca_visu_0": return vResult;
                case "Lib_Ca_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Ca_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Pt_visu_0": return vResult;
                case "Lib_Pt_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Pt_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Av_prendre_0": return vResult;
                case "Lib_Av_prendre_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Av_prendre_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Ta_visu_0": return vResult;
                case "Lib_Ta_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Ta_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "So_visu_0": return vResult;
                case "Lib_So_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_So_visu_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Id_espaceclient_0": return vResult;
                // case "Logicaldeleted_0": return vResult;
                case "Lib_Logicaldeleted_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Logicaldeleted_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Mail_0": return vResult;
                // case "Nom_0": return vResult;
                // case "Feminin_0": return vResult;
                case "Lib_Feminin_0": return vResult.ToLowerCase() == "false" ? null : "X";
                case "EF_Lib_Feminin_0": return vResult.ToLowerCase() == "false" ? null : "X";



            }
        return vResult;
    }

    #endregion

    // protected override void InitGridParameters(int iCard)
    // {
    //     base.InitGridParameters(iCard);
    //     if (iCard == 0)
    //     {
    //     if (FiltrePrenom_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Prenom) + FiltrePrenom_0.Valeur.ToSqlLike(true));
    //     if (FiltreLogin_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Login) + FiltreLogin_0.Valeur.ToSqlLike(true));
    //     if (FiltreTr_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Tr_visu) + FiltreTr_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltreCo_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Co_visu) + FiltreCo_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltreCa_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Ca_visu) + FiltreCa_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltrePt_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Pt_visu) + FiltrePt_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltreAv_prendre_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Av_prendre) + FiltreAv_prendre_0.Valeur.ToSqlLike(true));
    //     if (FiltreTa_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Ta_visu) + FiltreTa_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltreSo_visu_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_So_visu) + FiltreSo_visu_0.Valeur.ToSqlLike(true));
    //     if (FiltreId_espaceclient_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Id_espaceclient) + FiltreId_espaceclient_0.Valeur.ToSqlLike(true));
    //     if (FiltreMail_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Mail) + FiltreMail_0.Valeur.ToSqlLike(true));
    //     if (FiltreNom_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Nom) + FiltreNom_0.Valeur.ToSqlLike(true));
    //     if (FiltreFeminin_0.Valeur.IsCompleted())
    //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DET_V_ET0_Utilisateur.C_Feminin) + FiltreFeminin_0.Valeur.ToSqlLike(true));

    //     }
    //}
}

