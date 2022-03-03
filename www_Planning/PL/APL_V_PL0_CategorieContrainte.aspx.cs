// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:20:15
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

public partial class APL_V_PL0_CategorieContrainte : PLForm 
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

           AssociatedTBfrBusinessCard[0] = new BPL_V_PL0_CategorieContrainte(IStorageAccess);
           AssociatedITBfrStorageCard[0] = new SPL_V_PL0_CategorieContrainte(IStorageAccess);
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
            //FiltreId_categorie_0.InitFilterControl(null, new SPL_V_PL0_Categorie(IStorageAccess), SqlDataSourceFiltreId_categorie_0, DPL_V_PL0_Categorie.C_Libelle.ToString(), null, true, true);
            //FiltreId_contrainte_0.InitFilterControl(null, new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceFiltreId_contrainte_0, DPL_V_PL0_Contrainte.C_Libelle.ToString(), null, true, true);
            FiltreId_planning_0.InitFilterControl(null, new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceFiltreId_planning_0, DPL_V_PL0_Planning.C_Libelle.ToString(), null, true, true);
            //FiltreId_typecontrainte_0.InitFilterControl(null, new SPL_V_PL0_TypeTache(IStorageAccess), SqlDataSourceFiltreId_typecontrainte_0, DPL_V_PL0_TypeTache.C_Libelle.ToString(), null, true, true);

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 0)
        {
//			if (FiltreId_categorie_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_categorie, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_categorie_0.Valeur.ToSqlLong());
//			if (FiltreId_contrainte_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_contrainte_0.Valeur.ToSqlLong());
//            if (FiltreLib_categorie_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_categorie, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_categorie_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_typecategorie_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_typecategorie_0.Valeur.ToSqlLike(true));
//			if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_planning, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
//            if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Abr_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreRef_contrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Ref_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreRef_contrainte_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_contrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_contrainte_0.Valeur.ToSqlLike(true));
//            if (FiltreComm_contrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Comm_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreComm_contrainte_0.Valeur.ToSqlLike(true));
//			if (FiltreId_typecontrainte_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_typecontrainte_0.Valeur.ToSqlLong());
//            if (FiltreAbr_contrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Abr_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_contrainte_0.Valeur.ToSqlLike(true));
//            if (FiltreContrainterealisee_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Contrainterealisee, FilterCombosParameters[iCard].ViewPrefix)+ FiltreContrainterealisee_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_typecontrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_typecontrainte_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RPL_V_PL0_CategorieContrainte.Object;
    protected override string PageTitle => RPL_V_PL0_CategorieContrainte.TitrePage;

    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Id_categorie_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_categorie);
                case "PV_Id_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_contrainte);
                case "PV_Lib_categorie_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_categorie);
                case "PV_Lib_typecategorie_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie);
                case "PV_Id_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_planning);
                case "PV_Lib_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_planning);
                case "PV_Abr_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_planning);
                case "PV_Ref_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Ref_contrainte);
                case "PV_Lib_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_contrainte);
                case "PV_Comm_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Comm_contrainte);
                case "PV_Id_typecontrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte);
                case "PV_Abr_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_contrainte);
                case "PV_Contrainterealisee_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Contrainterealisee);
                case "PV_Lib_typecontrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==0)
            switch (labelId)
            {
            case "LblFilterId_categorie": 
            case "LblId_categorie": return RPL_V_PL0_CategorieContrainte.LblId_categorie;
            case "LblFilterId_contrainte": 
            case "LblId_contrainte": return RPL_V_PL0_CategorieContrainte.LblId_contrainte;
            case "LblFilterLib_categorie": 
            case "LblLib_categorie": return RPL_V_PL0_CategorieContrainte.LblLib_categorie;
            case "LblFilterLib_typecategorie": 
            case "LblLib_typecategorie": return RPL_V_PL0_CategorieContrainte.LblLib_typecategorie;
            case "LblFilterId_planning": 
            case "LblId_planning": return RPL_V_PL0_CategorieContrainte.LblId_planning;
            case "LblFilterLib_planning": 
            case "LblLib_planning": return RPL_V_PL0_CategorieContrainte.LblLib_planning;
            case "LblFilterAbr_planning": 
            case "LblAbr_planning": return RPL_V_PL0_CategorieContrainte.LblAbr_planning;
            case "LblFilterRef_contrainte": 
            case "LblRef_contrainte": return RPL_V_PL0_CategorieContrainte.LblRef_contrainte;
            case "LblFilterLib_contrainte": 
            case "LblLib_contrainte": return RPL_V_PL0_CategorieContrainte.LblLib_contrainte;
            case "LblFilterComm_contrainte": 
            case "LblComm_contrainte": return RPL_V_PL0_CategorieContrainte.LblComm_contrainte;
            case "LblFilterId_typecontrainte": 
            case "LblId_typecontrainte": return RPL_V_PL0_CategorieContrainte.LblId_typecontrainte;
            case "LblFilterAbr_contrainte": 
            case "LblAbr_contrainte": return RPL_V_PL0_CategorieContrainte.LblAbr_contrainte;
            case "LblFilterContrainterealisee": 
            case "LblContrainterealisee": return RPL_V_PL0_CategorieContrainte.LblContrainterealisee;
            case "LblFilterLib_typecontrainte": 
            case "LblLib_typecontrainte": return RPL_V_PL0_CategorieContrainte.LblLib_typecontrainte;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

           switch (((Control)control).ID)
            {
                case "Id_categorie_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_categorie_0": control.ReadOnly = vReadOnly; return;
                case "Id_contrainte_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_contrainte_0": control.ReadOnly = vReadOnly; return;

                case "Lib_categorie_0": control.ReadOnly = true; return;
                case "EF_Lib_categorie_0": control.ReadOnly = true; return;
                case "Lib_typecategorie_0": control.ReadOnly = true; return;
                case "EF_Lib_typecategorie_0": control.ReadOnly = true; return;
                case "Id_planning_0": control.ReadOnly = true; return;
                case "EF_Id_planning_0": control.ReadOnly = true; return;
                case "Lib_planning_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_0": control.ReadOnly = true; return;
                case "Abr_planning_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_0": control.ReadOnly = true; return;
                case "Ref_contrainte_0": control.ReadOnly = true; return;
                case "EF_Ref_contrainte_0": control.ReadOnly = true; return;
                case "Lib_contrainte_0": control.ReadOnly = true; return;
                case "EF_Lib_contrainte_0": control.ReadOnly = true; return;
                case "Comm_contrainte_0": control.ReadOnly = true; return;
                case "EF_Comm_contrainte_0": control.ReadOnly = true; return;
                case "Id_typecontrainte_0": control.ReadOnly = true; return;
                case "EF_Id_typecontrainte_0": control.ReadOnly = true; return;
                case "Abr_contrainte_0": control.ReadOnly = true; return;
                case "EF_Abr_contrainte_0": control.ReadOnly = true; return;
                case "Contrainterealisee_0": control.ReadOnly = true; return;
                case "EF_Contrainterealisee_0": control.ReadOnly = true; return;
                case "Lib_typecontrainte_0": control.ReadOnly = true; return;
                case "EF_Lib_typecontrainte_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_categorie), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_contrainte), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_categorie), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_planning), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Ref_contrainte), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_contrainte), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Comm_contrainte), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_contrainte), null);


                     GridViewsList[iCard].AddCheckColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Contrainterealisee), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte), null);



        }
    }
    
    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnId_categorie_0(iCard, -1, null, null);
            AlterColumnId_contrainte_0(iCard, -1, null, null);

            AlterColumnLib_categorie_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_typecategorie_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnId_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnRef_contrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_contrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnComm_contrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnId_typecontrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_contrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnContrainterealisee_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_typecontrainte_0(iCard, -1, null, null).ReadOnly = true;

   }
    }

    private GridViewDataColumn AlterColumnId_categorie_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_categorie), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_categorie, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdId_categorie, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpId_categorie,
           null, SqlDataSourceGridId_categorie_0, new SPL_V_PL0_Categorie(IStorageAccess));

    private GridViewDataColumn AlterColumnId_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_contrainte, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdId_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpId_contrainte,
           null, SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess));

    private GridViewDataColumn AlterColumnLib_categorie_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_categorie), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_categorie), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdLib_categorie, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpLib_categorie, null);


    private GridViewDataColumn AlterColumnLib_typecategorie_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdLib_typecategorie, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpLib_typecategorie, null);


    private GridViewDataColumn AlterColumnId_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_planning, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdId_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpId_planning,
           null, SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));

    private GridViewDataColumn AlterColumnLib_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdLib_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpLib_planning, null);


    private GridViewDataColumn AlterColumnAbr_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdAbr_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpAbr_planning, null);


    private GridViewDataColumn AlterColumnRef_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Ref_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Ref_contrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdRef_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpRef_contrainte, null);


    private GridViewDataColumn AlterColumnLib_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_contrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdLib_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpLib_contrainte, null);


    private GridViewDataColumn AlterColumnComm_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Comm_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Comm_contrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdComm_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpComm_contrainte, null);


    private GridViewDataColumn AlterColumnId_typecontrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdId_typecontrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpId_typecontrainte,
           null, SqlDataSourceGridId_typecontrainte_0, new SPL_V_PL0_TypeTache(IStorageAccess));

    private GridViewDataColumn AlterColumnAbr_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Abr_contrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdAbr_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpAbr_contrainte, null);


    private GridViewDataColumn AlterColumnContrainterealisee_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Contrainterealisee), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Contrainterealisee), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdContrainterealisee, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpContrainterealisee);


    private GridViewDataColumn AlterColumnLib_typecontrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_CategorieContrainte.LgdLib_typecontrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_CategorieContrainte.TtpLib_typecontrainte, null);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {
            //Id_categorie
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_categorie, vParameters,
            SqlDataSourceGridId_categorie_0, new SPL_V_PL0_Categorie(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_categorie, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_categorie_0, new SPL_V_PL0_Categorie(IStorageAccess), DPL_V_PL0_Categorie.C_Libelle);
            //Id_contrainte
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_contrainte, vParameters,
            SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_contrainte, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess), DPL_V_PL0_Contrainte.C_Libelle);
            //Id_planning
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_planning, vParameters,
            SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_planning, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess), DPL_V_PL0_Planning.C_Libelle);
            //Id_typecontrainte
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte, vParameters,
            SqlDataSourceGridId_typecontrainte_0, new SPL_V_PL0_TypeTache(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_typecontrainte_0, new SPL_V_PL0_TypeTache(IStorageAccess), DPL_V_PL0_TypeTache.C_Libelle);

        }
    }

    #endregion

    protected override void InitPopupControls(int iCard, Control control)
    {
        base.InitPopupControls(iCard, control);
        if (iCard==0)
          switch (control.ID)
          {
            case "Id_categorie_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_categorie_0"),
                     new SPL_V_PL0_Categorie(IStorageAccess), SqlDataSourceId_categorie_0, null, null, true, false);
                break;
            case "EF_Id_categorie_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_categorie_0"),
                     new SPL_V_PL0_Categorie(IStorageAccess), SqlDataSourceId_categorie_0, null, null, true, false);
                break;
            case "Id_contrainte_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_contrainte_0"),
                     new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceId_contrainte_0, null, null, true, false);
                break;
            case "EF_Id_contrainte_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_contrainte_0"),
                     new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceId_contrainte_0, null, null, true, false);
                break;
            case "Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;
            case "EF_Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;
            case "Id_typecontrainte_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_typecontrainte_0"),
                     new SPL_V_PL0_TypeTache(IStorageAccess), SqlDataSourceId_typecontrainte_0, null, null, true, false);
                break;
            case "EF_Id_typecontrainte_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_typecontrainte_0"),
                     new SPL_V_PL0_TypeTache(IStorageAccess), SqlDataSourceId_typecontrainte_0, null, null, true, false);
                break;
            case "Contrainterealisee_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Contrainterealisee_0"); break;
            case "EF_Contrainterealisee_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Contrainterealisee_0"); break;

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
                // case "Id_categorie_0": return vResult;
                // case "EF_Id_categorie_0": return vResult;
                // case "Id_contrainte_0": return vResult;
                // case "EF_Id_contrainte_0": return vResult;

                // case "Lib_categorie_0": return vResult;
                // case "EF_Lib_categorie_0": return vResult;
                // case "Lib_typecategorie_0": return vResult;
                // case "EF_Lib_typecategorie_0": return vResult;
                // case "Id_planning_0": return vResult;
                // case "EF_Id_planning_0": return vResult;
                // case "Lib_planning_0": return vResult;
                // case "EF_Lib_planning_0": return vResult;
                // case "Abr_planning_0": return vResult;
                // case "EF_Abr_planning_0": return vResult;
                // case "Ref_contrainte_0": return vResult;
                // case "EF_Ref_contrainte_0": return vResult;
                // case "Lib_contrainte_0": return vResult;
                // case "EF_Lib_contrainte_0": return vResult;
                // case "Comm_contrainte_0": return vResult;
                // case "EF_Comm_contrainte_0": return vResult;
                // case "Id_typecontrainte_0": return vResult;
                // case "EF_Id_typecontrainte_0": return vResult;
                // case "Abr_contrainte_0": return vResult;
                // case "EF_Abr_contrainte_0": return vResult;
                // case "Contrainterealisee_0": return vResult;
                // case "EF_Contrainterealisee_0": return vResult;
case "Lib_Contrainterealisee_0": return vResult.ToLowerCase() == "false" ? null : "X";
case "EF_Lib_Contrainterealisee_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Lib_typecontrainte_0": return vResult;
                // case "EF_Lib_typecontrainte_0": return vResult;

            }
        return vResult;
    }

    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 0)
        {
            //if (FiltreId_categorie_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_categorie)+ "=" + FiltreId_categorie_0.Valeur.ToSqlLong());
            //if (FiltreId_contrainte_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_contrainte)+ "=" + FiltreId_contrainte_0.Valeur.ToSqlLong());
            //         if (FiltreLib_categorie_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_categorie)+ FiltreLib_categorie_0.Valeur.ToSqlLike(true));
            //         if (FiltreLib_typecategorie_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie)+ FiltreLib_typecategorie_0.Valeur.ToSqlLike(true));
            if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)

                GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere(DPL_V_PL0_CategorieContrainte.C_Id_planning) + "=" + FiltreId_planning_0.Valeur.ToSqlLong());
            //         if (FiltreLib_planning_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_planning)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
            //         if (FiltreAbr_planning_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Abr_planning)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
            //         if (FiltreRef_contrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Ref_contrainte)+ FiltreRef_contrainte_0.Valeur.ToSqlLike(true));
            //         if (FiltreLib_contrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_contrainte)+ FiltreLib_contrainte_0.Valeur.ToSqlLike(true));
            //         if (FiltreComm_contrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Comm_contrainte)+ FiltreComm_contrainte_0.Valeur.ToSqlLike(true));
            //if (FiltreId_typecontrainte_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte)+ "=" + FiltreId_typecontrainte_0.Valeur.ToSqlLong());
            //         if (FiltreAbr_contrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Abr_contrainte)+ FiltreAbr_contrainte_0.Valeur.ToSqlLike(true));
            //         if (FiltreContrainterealisee_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Contrainterealisee)+ FiltreContrainterealisee_0.Valeur.ToSqlLike(true));
            //         if (FiltreLib_typecontrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte)+ FiltreLib_typecontrainte_0.Valeur.ToSqlLike(true));

        }
   }
}

