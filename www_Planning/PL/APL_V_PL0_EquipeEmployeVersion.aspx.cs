// Généré par GENERATEUR.THIERRYBREHON.FR le 22/12/2021 06:22:06
using THIERRYBREHON.FR.NSP;
using THIERRYBREHON.FR.NSB;
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
using Planning.NSB;
using Planning.NSP;
using Planning.NSS;
using Planning.NSD;
using Planning.NSR;

public partial class APL_V_PL0_EquipeEmployeVersion : PLForm 
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
            base.Page_InitList(iCard, WebFormMode.Batch);

           AssociatedTBfrBusinessCard[0] = new BPL_V_PL0_EquipeEmployeVersion(IStorageAccess);
           AssociatedITBfrStorageCard[0] = new SPL_V_PL0_EquipeEmployeVersion(IStorageAccess);
        }
    }

    //protected override void Page_InitRepeaterScreen(int iCard) { base.Page_InitRepeaterScreen(iCard) ; }

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
            FiltreId_version_0.InitFilterControl(null, new SPL_V_PL0_Version(IStorageAccess), SqlDataSourceFiltreId_version_0, DPL_V_PL0_Version.C_Libelle.ToString(), null, true, true);
            //FiltreId_equipe_0.InitFilterControl(null, new SPL_V_PL0_Equipe(IStorageAccess), SqlDataSourceFiltreId_equipe_0, DPL_V_PL0_Equipe.C_Libelle.ToString(), null, true, true);
            //FiltreId_employe_0.InitFilterControl(null, new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceFiltreId_employe_0, DPL_V_PL0_Employe.C_Identite.ToString(), null, true, true);
            FiltreId_planning_0.InitFilterControl(null, new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceFiltreId_planning_0, DPL_V_PL0_Planning.C_Libelle.ToString(), null, true, true);

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 0)
        {
//			if (FiltreId_version_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_version, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_version_0.Valeur.ToSqlLong());
//			if (FiltreId_equipe_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_equipe_0.Valeur.ToSqlLong());
//			if (FiltreId_employe_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_employe, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_employe_0.Valeur.ToSqlLong());
//			if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_planning, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
//            if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreNom_employe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreNom_employe_0.Valeur.ToSqlLike(true));
//            if (FiltrePrenom_employe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe, FilterCombosParameters[iCard].ViewPrefix)+ FiltrePrenom_employe_0.Valeur.ToSqlLike(true));
//            if (FiltreFeminin_employe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreFeminin_employe_0.Valeur.ToSqlLike(true));
//            if (FiltreIdent_employe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreIdent_employe_0.Valeur.ToSqlLike(true));
//            if (FiltreInit_employe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Init_employe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreInit_employe_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_equipe_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_equipe_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_planning_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_equipe_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_equipe_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_version_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_version, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_version_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_version_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_version, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_version_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_planning_version_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_version_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_version_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_version_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RPL_V_PL0_EquipeEmployeVersion.Object;
    protected override string PageTitle => RPL_V_PL0_EquipeEmployeVersion.TitrePage;

    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Id_version_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_version);
                case "PV_Id_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe);
                case "PV_Id_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_employe);
                case "PV_Id_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_planning);
                case "PV_Lib_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning);
                case "PV_Abr_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning);
                case "PV_Nom_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe);
                case "PV_Prenom_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe);
                case "PV_Feminin_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe);
                case "PV_Ident_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe);
                case "PV_Init_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Init_employe);
                case "PV_Abr_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe);
                case "PV_Lib_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe);
                case "PV_Lib_planning_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe);
                case "PV_Abr_planning_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe);
                case "PV_Abr_version_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_version);
                case "PV_Lib_version_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_version);
                case "PV_Lib_planning_version_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version);
                case "PV_Abr_planning_version_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==0)
            switch (labelId)
            {
            case "LblFilterId_version": 
            case "LblId_version": return RPL_V_PL0_EquipeEmployeVersion.LblId_version;
            case "LblFilterId_equipe": 
            case "LblId_equipe": return RPL_V_PL0_EquipeEmployeVersion.LblId_equipe;
            case "LblFilterId_employe": 
            case "LblId_employe": return RPL_V_PL0_EquipeEmployeVersion.LblId_employe;
            case "LblFilterId_planning": 
            case "LblId_planning": return RPL_V_PL0_EquipeEmployeVersion.LblId_planning;
            case "LblFilterLib_planning": 
            case "LblLib_planning": return RPL_V_PL0_EquipeEmployeVersion.LblLib_planning;
            case "LblFilterAbr_planning": 
            case "LblAbr_planning": return RPL_V_PL0_EquipeEmployeVersion.LblAbr_planning;
            case "LblFilterNom_employe": 
            case "LblNom_employe": return RPL_V_PL0_EquipeEmployeVersion.LblNom_employe;
            case "LblFilterPrenom_employe": 
            case "LblPrenom_employe": return RPL_V_PL0_EquipeEmployeVersion.LblPrenom_employe;
            case "LblFilterFeminin_employe": 
            case "LblFeminin_employe": return RPL_V_PL0_EquipeEmployeVersion.LblFeminin_employe;
            case "LblFilterIdent_employe": 
            case "LblIdent_employe": return RPL_V_PL0_EquipeEmployeVersion.LblIdent_employe;
            case "LblFilterInit_employe": 
            case "LblInit_employe": return RPL_V_PL0_EquipeEmployeVersion.LblInit_employe;
            case "LblFilterAbr_equipe": 
            case "LblAbr_equipe": return RPL_V_PL0_EquipeEmployeVersion.LblAbr_equipe;
            case "LblFilterLib_equipe": 
            case "LblLib_equipe": return RPL_V_PL0_EquipeEmployeVersion.LblLib_equipe;
            case "LblFilterLib_planning_equipe": 
            case "LblLib_planning_equipe": return RPL_V_PL0_EquipeEmployeVersion.LblLib_planning_equipe;
            case "LblFilterAbr_planning_equipe": 
            case "LblAbr_planning_equipe": return RPL_V_PL0_EquipeEmployeVersion.LblAbr_planning_equipe;
            case "LblFilterAbr_version": 
            case "LblAbr_version": return RPL_V_PL0_EquipeEmployeVersion.LblAbr_version;
            case "LblFilterLib_version": 
            case "LblLib_version": return RPL_V_PL0_EquipeEmployeVersion.LblLib_version;
            case "LblFilterLib_planning_version": 
            case "LblLib_planning_version": return RPL_V_PL0_EquipeEmployeVersion.LblLib_planning_version;
            case "LblFilterAbr_planning_version": 
            case "LblAbr_planning_version": return RPL_V_PL0_EquipeEmployeVersion.LblAbr_planning_version;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

           switch (((Control)control).ID)
            {
                case "Id_version_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_version_0": control.ReadOnly = vReadOnly; return;
                case "Id_equipe_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_equipe_0": control.ReadOnly = vReadOnly; return;
                case "Id_employe_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_employe_0": control.ReadOnly = vReadOnly; return;

                case "Id_planning_0": control.ReadOnly = true; return;
                case "EF_Id_planning_0": control.ReadOnly = true; return;
                case "Lib_planning_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_0": control.ReadOnly = true; return;
                case "Abr_planning_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_0": control.ReadOnly = true; return;
                case "Nom_employe_0": control.ReadOnly = true; return;
                case "EF_Nom_employe_0": control.ReadOnly = true; return;
                case "Prenom_employe_0": control.ReadOnly = true; return;
                case "EF_Prenom_employe_0": control.ReadOnly = true; return;
                case "Feminin_employe_0": control.ReadOnly = true; return;
                case "EF_Feminin_employe_0": control.ReadOnly = true; return;
                case "Ident_employe_0": control.ReadOnly = true; return;
                case "EF_Ident_employe_0": control.ReadOnly = true; return;
                case "Init_employe_0": control.ReadOnly = true; return;
                case "EF_Init_employe_0": control.ReadOnly = true; return;
                case "Abr_equipe_0": control.ReadOnly = true; return;
                case "EF_Abr_equipe_0": control.ReadOnly = true; return;
                case "Lib_equipe_0": control.ReadOnly = true; return;
                case "EF_Lib_equipe_0": control.ReadOnly = true; return;
                case "Lib_planning_equipe_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_equipe_0": control.ReadOnly = true; return;
                case "Abr_planning_equipe_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_equipe_0": control.ReadOnly = true; return;
                case "Abr_version_0": control.ReadOnly = true; return;
                case "EF_Abr_version_0": control.ReadOnly = true; return;
                case "Lib_version_0": control.ReadOnly = true; return;
                case "EF_Lib_version_0": control.ReadOnly = true; return;
                case "Lib_planning_version_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_version_0": control.ReadOnly = true; return;
                case "Abr_planning_version_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_version_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_version), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_employe), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_planning), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe), null);


                     GridViewsList[iCard].AddCheckColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Init_employe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_version), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_version), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version), null);



        }
    }
    
    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnId_version_0(iCard, -1, null, null);
            AlterColumnId_equipe_0(iCard, -1, null, null);
            AlterColumnId_employe_0(iCard, -1, null, null);

            AlterColumnId_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnNom_employe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnPrenom_employe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnFeminin_employe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnIdent_employe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnInit_employe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_equipe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_equipe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_equipe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_equipe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_version_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_version_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_version_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_version_0(iCard, -1, null, null).ReadOnly = true;

   }
    }

    private GridViewDataColumn AlterColumnId_version_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_version), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_version, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdId_version, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpId_version,
           null, SqlDataSourceGridId_version_0, new SPL_V_PL0_Version(IStorageAccess));

    private GridViewDataColumn AlterColumnId_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdId_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpId_equipe,
           null, SqlDataSourceGridId_equipe_0, new SPL_V_PL0_Equipe(IStorageAccess));

    private GridViewDataColumn AlterColumnId_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_employe, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdId_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpId_employe,
           null, SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess));

    private GridViewDataColumn AlterColumnId_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Id_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_planning, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdId_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpId_planning,
           null, SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));

    private GridViewDataColumn AlterColumnLib_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdLib_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpLib_planning, null);


    private GridViewDataColumn AlterColumnAbr_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdAbr_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpAbr_planning, null);


    private GridViewDataColumn AlterColumnNom_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdNom_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpNom_employe, null);


    private GridViewDataColumn AlterColumnPrenom_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdPrenom_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpPrenom_employe, null);


    private GridViewDataColumn AlterColumnFeminin_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdFeminin_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpFeminin_employe);


    private GridViewDataColumn AlterColumnIdent_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdIdent_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpIdent_employe, null);


    private GridViewDataColumn AlterColumnInit_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Init_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Init_employe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdInit_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpInit_employe, null);


    private GridViewDataColumn AlterColumnAbr_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdAbr_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpAbr_equipe, null);


    private GridViewDataColumn AlterColumnLib_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdLib_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpLib_equipe, null);


    private GridViewDataColumn AlterColumnLib_planning_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdLib_planning_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpLib_planning_equipe, null);


    private GridViewDataColumn AlterColumnAbr_planning_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdAbr_planning_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpAbr_planning_equipe, null);


    private GridViewDataColumn AlterColumnAbr_version_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_version), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_version), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdAbr_version, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpAbr_version, null);


    private GridViewDataColumn AlterColumnLib_version_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_version), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_version), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdLib_version, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpLib_version, null);


    private GridViewDataColumn AlterColumnLib_planning_version_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdLib_planning_version, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpLib_planning_version, null);


    private GridViewDataColumn AlterColumnAbr_planning_version_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_EquipeEmployeVersion.LgdAbr_planning_version, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_EquipeEmployeVersion.TtpAbr_planning_version, null);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {
            //Id_version
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_version, vParameters,
            SqlDataSourceGridId_version_0, new SPL_V_PL0_Version(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_version, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_version_0, new SPL_V_PL0_Version(IStorageAccess), DPL_V_PL0_Version.C_Libelle);
            //Id_equipe
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe, vParameters,
            SqlDataSourceGridId_equipe_0, new SPL_V_PL0_Equipe(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_equipe_0, new SPL_V_PL0_Equipe(IStorageAccess), DPL_V_PL0_Equipe.C_Libelle);
            //Id_employe
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_employe, vParameters,
            SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_employe, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess), DPL_V_PL0_Employe.C_Libelle);
            //Id_planning
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_planning, vParameters,
            SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_EquipeEmployeVersion.C_Id_planning, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess), DPL_V_PL0_Planning.C_Libelle);

        }
    }

    #endregion

    protected override void InitPopupControls(int iCard, Control control)
    {
        base.InitPopupControls(iCard, control);
        if (iCard==0)
          switch (control.ID)
          {
            case "Id_version_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_version_0"),
                     new SPL_V_PL0_Version(IStorageAccess), SqlDataSourceId_version_0, null, null, true, false);
                break;
            case "EF_Id_version_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_version_0"),
                     new SPL_V_PL0_Version(IStorageAccess), SqlDataSourceId_version_0, null, null, true, false);
                break;
            case "Id_equipe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_equipe_0"),
                     new SPL_V_PL0_Equipe(IStorageAccess), SqlDataSourceId_equipe_0, null, null, true, false);
                break;
            case "EF_Id_equipe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_equipe_0"),
                     new SPL_V_PL0_Equipe(IStorageAccess), SqlDataSourceId_equipe_0, null, null, true, false);
                break;
            case "Id_employe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_employe_0"),
                     new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceId_employe_0, null, null, true, false);
                break;
            case "EF_Id_employe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_employe_0"),
                     new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceId_employe_0, null, null, true, false);
                break;
            case "Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;
            case "EF_Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;
            case "Feminin_employe_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Feminin_employe_0"); break;
            case "EF_Feminin_employe_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Feminin_employe_0"); break;

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
                // case "EF_Id_0": return vResult;
                // case "Id_version_0": return vResult;
                // case "EF_Id_version_0": return vResult;
                // case "Id_equipe_0": return vResult;
                // case "EF_Id_equipe_0": return vResult;
                // case "Id_employe_0": return vResult;
                // case "EF_Id_employe_0": return vResult;

                // case "Id_planning_0": return vResult;
                // case "EF_Id_planning_0": return vResult;
                // case "Lib_planning_0": return vResult;
                // case "EF_Lib_planning_0": return vResult;
                // case "Abr_planning_0": return vResult;
                // case "EF_Abr_planning_0": return vResult;
                // case "Nom_employe_0": return vResult;
                // case "EF_Nom_employe_0": return vResult;
                // case "Prenom_employe_0": return vResult;
                // case "EF_Prenom_employe_0": return vResult;
                // case "Feminin_employe_0": return vResult;
                // case "EF_Feminin_employe_0": return vResult;
case "Lib_Feminin_employe_0": return vResult.ToLowerCase() == "false" ? null : "X";
case "EF_Lib_Feminin_employe_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Ident_employe_0": return vResult;
                // case "EF_Ident_employe_0": return vResult;
                // case "Init_employe_0": return vResult;
                // case "EF_Init_employe_0": return vResult;
                // case "Abr_equipe_0": return vResult;
                // case "EF_Abr_equipe_0": return vResult;
                // case "Lib_equipe_0": return vResult;
                // case "EF_Lib_equipe_0": return vResult;
                // case "Lib_planning_equipe_0": return vResult;
                // case "EF_Lib_planning_equipe_0": return vResult;
                // case "Abr_planning_equipe_0": return vResult;
                // case "EF_Abr_planning_equipe_0": return vResult;
                // case "Abr_version_0": return vResult;
                // case "EF_Abr_version_0": return vResult;
                // case "Lib_version_0": return vResult;
                // case "EF_Lib_version_0": return vResult;
                // case "Lib_planning_version_0": return vResult;
                // case "EF_Lib_planning_version_0": return vResult;
                // case "Abr_planning_version_0": return vResult;
                // case "EF_Abr_planning_version_0": return vResult;

            }
        return vResult;
    }

    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 0)
        {
			if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_planning)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
			if (FiltreId_version_0.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_version)+ "=" + FiltreId_version_0.Valeur.ToSqlLong());
			//if (FiltreId_equipe_0.Valeur.ToLongOrDefault(-1) != -1)
   
   //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe)+ "=" + FiltreId_equipe_0.Valeur.ToSqlLong());
			//if (FiltreId_employe_0.Valeur.ToLongOrDefault(-1) != -1)
   
   //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Id_employe)+ "=" + FiltreId_employe_0.Valeur.ToSqlLong());
            //if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
            //if (FiltreNom_employe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe)+ FiltreNom_employe_0.Valeur.ToSqlLike(true));
            //if (FiltrePrenom_employe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe)+ FiltrePrenom_employe_0.Valeur.ToSqlLike(true));
            //if (FiltreFeminin_employe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe)+ FiltreFeminin_employe_0.Valeur.ToSqlLike(true));
            //if (FiltreIdent_employe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe)+ FiltreIdent_employe_0.Valeur.ToSqlLike(true));
            //if (FiltreInit_employe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Init_employe)+ FiltreInit_employe_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe)+ FiltreAbr_equipe_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe)+ FiltreLib_equipe_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_planning_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe)+ FiltreLib_planning_equipe_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_planning_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe)+ FiltreAbr_planning_equipe_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_version_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_version)+ FiltreAbr_version_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_version_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_version)+ FiltreLib_version_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_planning_version_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version)+ FiltreLib_planning_version_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_planning_version_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version)+ FiltreAbr_planning_version_0.Valeur.ToSqlLike(true));

        }
   }
}

