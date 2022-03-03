// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:20:16
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

public partial class APL_V_PL0_Realisation : PLForm 
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

           AssociatedTBfrBusinessCard[0] = new BPL_V_PL0_Realisation(IStorageAccess);
           AssociatedITBfrStorageCard[0] = new SPL_V_PL0_Realisation(IStorageAccess);
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
            //FiltreId_employe_0.InitFilterControl(null, new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceFiltreId_employe_0, DPL_V_PL0_Employe.C_Libelle.ToString(), null, true, true);
            //FiltreId_contrainterealisee_0.InitFilterControl(null, new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceFiltreId_contrainterealisee_0, DPL_V_PL0_Contrainte.C_Libelle.ToString(), null, true, true);
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
//            if (FiltreDebut_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Debut, FilterCombosParameters[iCard].ViewPrefix)+ FiltreDebut_0.Valeur.ToSqlLike(true));
//			if (FiltreId_employe_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_employe, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_employe_0.Valeur.ToSqlLong());
//            if (FiltreDuree_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Duree, FilterCombosParameters[iCard].ViewPrefix)+ FiltreDuree_0.Valeur.ToSqlLike(true));
//			if (FiltreId_contrainterealisee_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_contrainterealisee, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_contrainterealisee_0.Valeur.ToSqlLong());
//			if (FiltreId_contrainte_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_contrainte_0.Valeur.ToSqlLong());
//			if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_planning, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_planning_0.Valeur.ToSqlLong());
//            if (FiltreRef_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Ref, FilterCombosParameters[iCard].ViewPrefix)+ FiltreRef_0.Valeur.ToSqlLike(true));
//            if (FiltreAbreviation_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Abreviation, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbreviation_0.Valeur.ToSqlLike(true));
//            if (FiltreLibelle_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Libelle, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLibelle_0.Valeur.ToSqlLike(true));
//            if (FiltreCommentaire_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Commentaire, FilterCombosParameters[iCard].ViewPrefix)+ FiltreCommentaire_0.Valeur.ToSqlLike(true));
//			if (FiltreId_typecontrainte_0.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_typecontrainte, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_typecontrainte_0.Valeur.ToSqlLong());
//            if (FiltreRealisee_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Realisee, FilterCombosParameters[iCard].ViewPrefix)+ FiltreRealisee_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_typecontrainte_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Lib_typecontrainte, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_typecontrainte_0.Valeur.ToSqlLike(true));
//            if (FiltreAbr_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Abr_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
//            if (FiltreLib_planning_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Lib_planning, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RPL_V_PL0_Realisation.Object;
    protected override string PageTitle => RPL_V_PL0_Realisation.TitrePage;

    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Debut_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Debut);
                case "PV_Id_employe_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_employe);
                case "PV_Duree_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Duree);
                case "PV_Id_contrainterealisee_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainterealisee);
                case "PV_Id_contrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainte);
                case "PV_Id_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_planning);
                case "PV_Ref_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Ref);
                case "PV_Abreviation_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abreviation);
                case "PV_Libelle_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Libelle);
                case "PV_Commentaire_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Commentaire);
                case "PV_Id_typecontrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_typecontrainte);
                case "PV_Realisee_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Realisee);
                case "PV_Lib_typecontrainte_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_typecontrainte);
                case "PV_Abr_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abr_planning);
                case "PV_Lib_planning_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_planning);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==0)
            switch (labelId)
            {
            case "LblFilterDebut": 
            case "LblDebut": return RPL_V_PL0_Realisation.LblDebut;
            case "LblFilterId_employe": 
            case "LblId_employe": return RPL_V_PL0_Realisation.LblId_employe;
            case "LblFilterDuree": 
            case "LblDuree": return RPL_V_PL0_Realisation.LblDuree;
            case "LblFilterId_contrainterealisee": 
            case "LblId_contrainterealisee": return RPL_V_PL0_Realisation.LblId_contrainterealisee;
            case "LblFilterId_contrainte": 
            case "LblId_contrainte": return RPL_V_PL0_Realisation.LblId_contrainte;
            case "LblFilterId_planning": 
            case "LblId_planning": return RPL_V_PL0_Realisation.LblId_planning;
            case "LblFilterRef": 
            case "LblRef": return RPL_V_PL0_Realisation.LblRef;
            case "LblFilterAbreviation": 
            case "LblAbreviation": return RPL_V_PL0_Realisation.LblAbreviation;
            case "LblFilterLibelle": 
            case "LblLibelle": return RPL_V_PL0_Realisation.LblLibelle;
            case "LblFilterCommentaire": 
            case "LblCommentaire": return RPL_V_PL0_Realisation.LblCommentaire;
            case "LblFilterId_typecontrainte": 
            case "LblId_typecontrainte": return RPL_V_PL0_Realisation.LblId_typecontrainte;
            case "LblFilterRealisee": 
            case "LblRealisee": return RPL_V_PL0_Realisation.LblRealisee;
            case "LblFilterLib_typecontrainte": 
            case "LblLib_typecontrainte": return RPL_V_PL0_Realisation.LblLib_typecontrainte;
            case "LblFilterAbr_planning": 
            case "LblAbr_planning": return RPL_V_PL0_Realisation.LblAbr_planning;
            case "LblFilterLib_planning": 
            case "LblLib_planning": return RPL_V_PL0_Realisation.LblLib_planning;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

           switch (((Control)control).ID)
            {
                case "Debut_0": control.ReadOnly = vReadOnly; return;
                case "EF_Debut_0": control.ReadOnly = vReadOnly; return;
                case "Id_employe_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_employe_0": control.ReadOnly = vReadOnly; return;
                case "Duree_0": control.ReadOnly = vReadOnly; return;
                case "EF_Duree_0": control.ReadOnly = vReadOnly; return;
                case "Id_contrainterealisee_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_contrainterealisee_0": control.ReadOnly = vReadOnly; return;
                case "Id_contrainte_0": control.ReadOnly = vReadOnly; return;
                case "EF_Id_contrainte_0": control.ReadOnly = vReadOnly; return;

                case "Id_planning_0": control.ReadOnly = true; return;
                case "EF_Id_planning_0": control.ReadOnly = true; return;
                case "Ref_0": control.ReadOnly = true; return;
                case "EF_Ref_0": control.ReadOnly = true; return;
                case "Abreviation_0": control.ReadOnly = true; return;
                case "EF_Abreviation_0": control.ReadOnly = true; return;
                case "Libelle_0": control.ReadOnly = true; return;
                case "EF_Libelle_0": control.ReadOnly = true; return;
                case "Commentaire_0": control.ReadOnly = true; return;
                case "EF_Commentaire_0": control.ReadOnly = true; return;
                case "Id_typecontrainte_0": control.ReadOnly = true; return;
                case "EF_Id_typecontrainte_0": control.ReadOnly = true; return;
                case "Realisee_0": control.ReadOnly = true; return;
                case "EF_Realisee_0": control.ReadOnly = true; return;
                case "Lib_typecontrainte_0": control.ReadOnly = true; return;
                case "EF_Lib_typecontrainte_0": control.ReadOnly = true; return;
                case "Abr_planning_0": control.ReadOnly = true; return;
                case "EF_Abr_planning_0": control.ReadOnly = true; return;
                case "Lib_planning_0": control.ReadOnly = true; return;
                case "EF_Lib_planning_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Libelle);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
                     GridViewsList[iCard].AddDateColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Debut), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_employe), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Duree), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainterealisee), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainte), null);

                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_planning), null);

                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Ref), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abreviation), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Libelle), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Commentaire), null);


                     GridViewsList[iCard].AddComboBoxDirectColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_typecontrainte), null);

                     GridViewsList[iCard].AddCheckColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Realisee), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_typecontrainte), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abr_planning), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_planning), null);



        }
    }
    
    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnDebut_0(iCard, -1, null, null);
            AlterColumnId_employe_0(iCard, -1, null, null);
            AlterColumnDuree_0(iCard, -1, null, null);
            AlterColumnId_contrainterealisee_0(iCard, -1, null, null);
            AlterColumnId_contrainte_0(iCard, -1, null, null);

            AlterColumnId_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnRef_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbreviation_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLibelle_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnCommentaire_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnId_typecontrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnRealisee_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_typecontrainte_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnAbr_planning_0(iCard, -1, null, null).ReadOnly = true;
            AlterColumnLib_planning_0(iCard, -1, null, null).ReadOnly = true;

   }
    }

    private GridViewDataColumn AlterColumnDebut_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterDateTimeColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Debut), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Debut), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdDebut, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpDebut, null);


    private GridViewDataColumn AlterColumnId_employe_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_employe), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_employe, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdId_employe, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpId_employe,
           null, SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess));

    private GridViewDataColumn AlterColumnDuree_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Duree), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Duree), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdDuree, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpDuree, null);


    private GridViewDataColumn AlterColumnId_contrainterealisee_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainterealisee), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainterealisee, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdId_contrainterealisee, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpId_contrainterealisee,
           null, SqlDataSourceGridId_contrainterealisee_0, new SPL_V_PL0_Contrainte(IStorageAccess));

    private GridViewDataColumn AlterColumnId_contrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_contrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainte, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdId_contrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpId_contrainte,
           null, SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess));

    private GridViewDataColumn AlterColumnId_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_planning, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdId_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpId_planning,
           null, SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));

    private GridViewDataColumn AlterColumnRef_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Ref), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Ref), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdRef, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpRef, null);


    private GridViewDataColumn AlterColumnAbreviation_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abreviation), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abreviation), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdAbreviation, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpAbreviation, null);


    private GridViewDataColumn AlterColumnLibelle_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Libelle), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Libelle), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdLibelle, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpLibelle, null);


    private GridViewDataColumn AlterColumnCommentaire_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Commentaire), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Commentaire), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdCommentaire, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpCommentaire, null);


    private GridViewDataColumn AlterColumnId_typecontrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
           =>  GridViewsList[iCard].AlterColumnComboBoxDirect("c" + AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Id_typecontrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_typecontrainte, labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdId_typecontrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpId_typecontrainte,
           null, SqlDataSourceGridId_typecontrainte_0, new SPL_V_PL0_TypeTache(IStorageAccess));

    private GridViewDataColumn AlterColumnRealisee_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Realisee), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Realisee), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdRealisee, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpRealisee);


    private GridViewDataColumn AlterColumnLib_typecontrainte_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_typecontrainte), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_typecontrainte), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdLib_typecontrainte, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpLib_typecontrainte, null);


    private GridViewDataColumn AlterColumnAbr_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abr_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Abr_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdAbr_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpAbr_planning, null);


    private GridViewDataColumn AlterColumnLib_planning_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_planning), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Realisation.C_Lib_planning), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Realisation.LgdLib_planning, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Realisation.TtpLib_planning, null);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {
            //Id_employe
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_employe, vParameters,
            SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_employe, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_employe_0, new SPL_V_PL0_Employe(IStorageAccess), DPL_V_PL0_Employe.C_Libelle);
            //Id_contrainterealisee
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainterealisee, vParameters,
            SqlDataSourceGridId_contrainterealisee_0, new SPL_V_PL0_Contrainte(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainterealisee, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_contrainterealisee_0, new SPL_V_PL0_Contrainte(IStorageAccess), DPL_V_PL0_Contrainte.C_Libelle);
            //Id_contrainte
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainte, vParameters,
            SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_contrainte, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_contrainte_0, new SPL_V_PL0_Contrainte(IStorageAccess), DPL_V_PL0_Contrainte.C_Libelle);
            //Id_planning
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_planning, vParameters,
            SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_planning, FilterCombosParameters[iCard],
            //SqlDataSourceGridId_planning_0, new SPL_V_PL0_Planning(IStorageAccess), DPL_V_PL0_Planning.C_Libelle);
            //Id_typecontrainte
            GridViewsList[iCard].UpdateColumnComboBoxDirect(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_typecontrainte, vParameters,
            SqlDataSourceGridId_typecontrainte_0, new SPL_V_PL0_TypeTache(IStorageAccess));
            //GridViewsList[iCard].UpdateColumnComboBox(AssociatedITBfrStorageCard[iCard], DPL_V_PL0_Realisation.C_Id_typecontrainte, FilterCombosParameters[iCard],
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
            case "Id_employe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_employe_0"),
                     new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceId_employe_0, null, null, true, false);
                break;
            case "EF_Id_employe_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_employe_0"),
                     new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceId_employe_0, null, null, true, false);
                break;
            case "Id_contrainterealisee_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "Lib_Id_contrainterealisee_0"),
                     new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceId_contrainterealisee_0, null, null, true, false);
                break;
            case "EF_Id_contrainterealisee_0":
                ((TBfr_ComboBox)control).InitChoiceControl((WebControl)FindControlFromRoot(this, "EF_Lib_Id_contrainterealisee_0"),
                     new SPL_V_PL0_Contrainte(IStorageAccess), SqlDataSourceId_contrainterealisee_0, null, null, true, false);
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
            case "Realisee_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Realisee_0"); break;
            case "EF_Realisee_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Realisee_0"); break;
            case "Debut_0": ((TBfr_DateEdit)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Debut_0"); break;
            case "EF_Debut_0": ((TBfr_DateEdit)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Debut_0"); break;

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
                // case "Debut_0": return vResult;
                // case "EF_Debut_0": return vResult;
case "Lib_Debut_0": return vResult.Beginning(10);
case "EF_Lib_Debut_0": return vResult.Beginning(10);

                // case "Id_employe_0": return vResult;
                // case "EF_Id_employe_0": return vResult;
                // case "Duree_0": return vResult;
                // case "EF_Duree_0": return vResult;
                // case "Id_contrainterealisee_0": return vResult;
                // case "EF_Id_contrainterealisee_0": return vResult;
                // case "Id_contrainte_0": return vResult;
                // case "EF_Id_contrainte_0": return vResult;

                // case "Id_planning_0": return vResult;
                // case "EF_Id_planning_0": return vResult;
                // case "Ref_0": return vResult;
                // case "EF_Ref_0": return vResult;
                // case "Abreviation_0": return vResult;
                // case "EF_Abreviation_0": return vResult;
                // case "Libelle_0": return vResult;
                // case "EF_Libelle_0": return vResult;
                // case "Commentaire_0": return vResult;
                // case "EF_Commentaire_0": return vResult;
                // case "Id_typecontrainte_0": return vResult;
                // case "EF_Id_typecontrainte_0": return vResult;
                // case "Realisee_0": return vResult;
                // case "EF_Realisee_0": return vResult;
case "Lib_Realisee_0": return vResult.ToLowerCase() == "false" ? null : "X";
case "EF_Lib_Realisee_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Lib_typecontrainte_0": return vResult;
                // case "EF_Lib_typecontrainte_0": return vResult;
                // case "Abr_planning_0": return vResult;
                // case "EF_Abr_planning_0": return vResult;
                // case "Lib_planning_0": return vResult;
                // case "EF_Lib_planning_0": return vResult;

            }
        return vResult;
    }

    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 0)
        {
            //         if (FiltreDebut_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Debut)+ FiltreDebut_0.Valeur.ToSqlLike(true));
            //if (FiltreId_employe_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_employe)+ "=" + FiltreId_employe_0.Valeur.ToSqlLong());
            //         if (FiltreDuree_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Duree)+ FiltreDuree_0.Valeur.ToSqlLike(true));
            //if (FiltreId_contrainterealisee_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_contrainterealisee)+ "=" + FiltreId_contrainterealisee_0.Valeur.ToSqlLong());
            //if (FiltreId_contrainte_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_contrainte)+ "=" + FiltreId_contrainte_0.Valeur.ToSqlLong());
            if (FiltreId_planning_0.Valeur.ToLongOrDefault(-1) != -1)

                GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere(DPL_V_PL0_Realisation.C_Id_planning) + "=" + FiltreId_planning_0.Valeur.ToSqlLong());
            //         if (FiltreRef_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Ref)+ FiltreRef_0.Valeur.ToSqlLike(true));
            //         if (FiltreAbreviation_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Abreviation)+ FiltreAbreviation_0.Valeur.ToSqlLike(true));
            //         if (FiltreLibelle_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Libelle)+ FiltreLibelle_0.Valeur.ToSqlLike(true));
            //         if (FiltreCommentaire_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Commentaire)+ FiltreCommentaire_0.Valeur.ToSqlLike(true));
            //if (FiltreId_typecontrainte_0.Valeur.ToLongOrDefault(-1) != -1)

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Id_typecontrainte)+ "=" + FiltreId_typecontrainte_0.Valeur.ToSqlLong());
            //         if (FiltreRealisee_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Realisee)+ FiltreRealisee_0.Valeur.ToSqlLike(true));
            //         if (FiltreLib_typecontrainte_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Lib_typecontrainte)+ FiltreLib_typecontrainte_0.Valeur.ToSqlLike(true));
            //         if (FiltreAbr_planning_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Abr_planning)+ FiltreAbr_planning_0.Valeur.ToSqlLike(true));
            //         if (FiltreLib_planning_0.Valeur.IsCompleted())

            //         GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Realisation.C_Lib_planning)+ FiltreLib_planning_0.Valeur.ToSqlLike(true));

        }
   }
}

