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

public partial class APL_V_PL0_Equipe : PLForm 
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

           AssociatedTBfrBusinessCard[0] = new BPL_V_PL0_Equipe(IStorageAccess);
           AssociatedITBfrStorageCard[0] = new SPL_V_PL0_Equipe(IStorageAccess);
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
            FiltreId_planning_0.InitFilterControl(null, new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceFiltreId_planning_0, DPL_V_PL0_Planning.C_Libelle.ToString(), null, true, true);

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 0)
        {
//            if (FiltreLibelle_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Libelle, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLibelle_0.Valeur.ToSqlLike(true));
//            if (FiltreAbreviation_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abreviation, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbreviation_0.Valeur.ToSqlLike(true));
//			if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Id_planning, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
//            if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Lib_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abr_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_planning_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Lib_planning_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_equipe_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_equipe_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abr_planning_equipe, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_equipe_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RPL_V_PL0_Equipe.Object;
    protected override string PageTitle => RPL_V_PL0_Equipe.TitrePage;

    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Libelle_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Libelle);
                case "PV_Abreviation_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abreviation);
                case "PV_Id_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Id_planning);
                case "PV_Lib_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning);
                case "PV_Abr_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning);
                case "PV_Lib_planning_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning_equipe);
                case "PV_Abr_planning_equipe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning_equipe);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==0)
            switch (labelId)
            {
            case "LblFilterLibelle": 
            case "LblLibelle": return RPL_V_PL0_Equipe.LblLibelle;
            case "LblFilterAbreviation": 
            case "LblAbreviation": return RPL_V_PL0_Equipe.LblAbreviation;
            case "LblFilterId_planning": 
            case "LblId_planning": return RPL_V_PL0_Equipe.LblId_planning;
            case "LblFilterLib_planning": 
            case "LblLib_planning": return RPL_V_PL0_Equipe.LblLib_planning;
            case "LblFilterAbr_planning": 
            case "LblAbr_planning": return RPL_V_PL0_Equipe.LblAbr_planning;
            case "LblFilterLib_planning_equipe": 
            case "LblLib_planning_equipe": return RPL_V_PL0_Equipe.LblLib_planning_equipe;
            case "LblFilterAbr_planning_equipe": 
            case "LblAbr_planning_equipe": return RPL_V_PL0_Equipe.LblAbr_planning_equipe;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

           switch (((Control)control).ID)
            {
                case "Libelle_0": control.ReadOnly = vReadOnly; return;
                case "EF_Libelle_0": control.ReadOnly = vReadOnly; return;
                case "Abreviation_0": control.ReadOnly = vReadOnly; return;
                case "EF_Abreviation_0": control.ReadOnly = vReadOnly; return;
                case "Id_planning_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_planning_0": control.ReadOnly = vReadOnly; return;

                case "Lib_planning_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_0": control.ReadOnly = true; return;
                case "Abr_planning_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_0": control.ReadOnly = true; return;
                case "Lib_planning_equipe_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_equipe_0": control.ReadOnly = true; return;
                case "Abr_planning_equipe_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_equipe_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning_equipe);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Libelle), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abreviation), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Id_planning), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning_equipe), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning_equipe), null);



        }
    }
    
    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnLibelle_0(iCard, -1, null, null);
            AlterColumnAbreviation_0(iCard, -1, null, null);
            AlterColumnId_planning_0(iCard, -1, null, null);

            AlterColumnLib_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_equipe_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_equipe_0(iCard, -1, null, null).ReadOnly = true;

   }
    }

    private GridViewDataColumn AlterColumnLibelle_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Libelle), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Libelle), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdLibelle, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpLibelle, null);


    private GridViewDataColumn AlterColumnAbreviation_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abreviation), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abreviation), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdAbreviation, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpAbreviation, null);


    private GridViewDataColumn AlterColumnId_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Id_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Equipe.C_Id_planning, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdId_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpId_planning,
           null, SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));

    private GridViewDataColumn AlterColumnLib_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdLib_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpLib_planning, null);


    private GridViewDataColumn AlterColumnAbr_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdAbr_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpAbr_planning, null);


    private GridViewDataColumn AlterColumnLib_planning_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Lib_planning_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdLib_planning_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpLib_planning_equipe, null);


    private GridViewDataColumn AlterColumnAbr_planning_equipe_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning_equipe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Equipe.C_Abr_planning_equipe), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Equipe.LgdAbr_planning_equipe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Equipe.TtpAbr_planning_equipe, null);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {
            //Id_planning
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Equipe.C_Id_planning, vParameters,
            SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Equipe.C_Id_planning, FilterCombosParameters[iCard],
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
            case "Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;
            case "EF_Id_planning_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_planning_0"),
                     new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceId_planning_0, null, null, true, false);
                break;

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
                // case "Libelle_0": return vResult;
                // case "EF_Libelle_0": return vResult;
                // case "Abreviation_0": return vResult;
                // case "EF_Abreviation_0": return vResult;
                // case "Id_planning_0": return vResult;
                // case "EF_Id_planning_0": return vResult;

                // case "Lib_planning_0": return vResult;
                // case "EF_Lib_planning_0": return vResult;
                // case "Abr_planning_0": return vResult;
                // case "EF_Abr_planning_0": return vResult;
                // case "Lib_planning_equipe_0": return vResult;
                // case "EF_Lib_planning_equipe_0": return vResult;
                // case "Abr_planning_equipe_0": return vResult;
                // case "EF_Abr_planning_equipe_0": return vResult;

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
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Id_planning)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
            //if (FiltreLibelle_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Libelle)+ FiltreLibelle_0.Valeur.ToSqlLike(true));
            //if (FiltreAbreviation_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abreviation)+ FiltreAbreviation_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Lib_planning)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abr_planning)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
            //if (FiltreLib_planning_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Lib_planning_equipe)+ FiltreLib_planning_equipe_0.Valeur.ToSqlLike(true));
            //if (FiltreAbr_planning_equipe_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Equipe.C_Abr_planning_equipe)+ FiltreAbr_planning_equipe_0.Valeur.ToSqlLike(true));

        }
   }
}

