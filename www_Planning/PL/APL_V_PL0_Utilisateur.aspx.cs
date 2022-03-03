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

public partial class APL_V_PL0_Utilisateur : PLForm 
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

           AssociatedTBfrBusinessCard[0] = new BPL_V_PL0_Utilisateur(IStorageAccess);
           AssociatedITBfrStorageCard[0] = new SPL_V_PL0_Utilisateur(IStorageAccess);
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

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 0)
        {
//            if (FiltreModif_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Modif, FilterCombosParameters[iCard].ViewPrefix)+ FiltreModif_0.Valeur.ToSqlLike(true));
//            if (FiltreNom_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Nom, FilterCombosParameters[iCard].ViewPrefix)+ FiltreNom_0.Valeur.ToSqlLike(true));
//            if (FiltrePrenom_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Prenom, FilterCombosParameters[iCard].ViewPrefix)+ FiltrePrenom_0.Valeur.ToSqlLike(true));
//            if (FiltreFeminin_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Feminin, FilterCombosParameters[iCard].ViewPrefix)+ FiltreFeminin_0.Valeur.ToSqlLike(true));
//            if (FiltreIdentite_0.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Identite, FilterCombosParameters[iCard].ViewPrefix)+ FiltreIdentite_0.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RPL_V_PL0_Utilisateur.Object;
    protected override string PageTitle => RPL_V_PL0_Utilisateur.TitrePage;

    protected override string TemplateColId(int iCard, string labelId)
    {
        if (iCard == 0)
            switch (labelId)
            {
                case "PV_Modif_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Modif);
                case "PV_Nom_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Nom);
                case "PV_Prenom_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Prenom);
                case "PV_Feminin_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Feminin);
                case "PV_Identite_0": return AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Identite);

            }
        return null;
    }

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==0)
            switch (labelId)
            {
            case "LblFilterModif": 
            case "LblModif": return RPL_V_PL0_Utilisateur.LblModif;
            case "LblFilterNom": 
            case "LblNom": return RPL_V_PL0_Utilisateur.LblNom;
            case "LblFilterPrenom": 
            case "LblPrenom": return RPL_V_PL0_Utilisateur.LblPrenom;
            case "LblFilterFeminin": 
            case "LblFeminin": return RPL_V_PL0_Utilisateur.LblFeminin;
            case "LblFilterIdentite": 
            case "LblIdentite": return RPL_V_PL0_Utilisateur.LblIdentite;

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
                // VReadOnly |= row[AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Id_user)].ToString() != DUserRights.Id.ToString();
            }

           switch (((Control)control).ID)
            {
                case "Modif_0": control.ReadOnly = vReadOnly; return;
                case "EF_Modif_0": control.ReadOnly = vReadOnly; return;
                case "Nom_0": control.ReadOnly = vReadOnly; return;
                case "EF_Nom_0": control.ReadOnly = vReadOnly; return;
                case "Prenom_0": control.ReadOnly = vReadOnly; return;
                case "EF_Prenom_0": control.ReadOnly = vReadOnly; return;
                case "Feminin_0": control.ReadOnly = vReadOnly; return;
                case "EF_Feminin_0": control.ReadOnly = vReadOnly; return;

                case "Identite_0": control.ReadOnly = true; return;
                case "EF_Identite_0": control.ReadOnly = true; return;

            }
        }
        base.ReadOnlyPopUp(iCard, control, row);
    }

    #region construction de la gridview

    protected override string DefaultSortList(int iCard)
    {
        string vResult = base.DefaultSortList(iCard);
        if (iCard == 0) vResult = AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Identite);
        return vResult;
    }

    protected override void AddColumnsGridView(int iCard)
    {
        base.AddColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AddCommandColumns(-1);
                     GridViewsList[iCard].AddCheckColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Modif), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Nom), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Prenom), null);


                     GridViewsList[iCard].AddCheckColumn( AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Feminin), null);


                     GridViewsList[iCard].AddTextColumn(AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Identite), null);



        }
    }
    
    protected override void AlterColumnsGridView(int iCard)
    {
        base.AlterColumnsGridView(iCard);
        if (iCard == 0)
        {
            GridViewsList[iCard].AlterCommandColumns(-1);
            AlterColumnModif_0(iCard, -1, null, null);
            AlterColumnNom_0(iCard, -1, null, null);
            AlterColumnPrenom_0(iCard, -1, null, null);
            AlterColumnFeminin_0(iCard, -1, null, null);

            AlterColumnIdentite_0(iCard, -1, null, null).ReadOnly = true;

   }
    }

    private GridViewDataColumn AlterColumnModif_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Modif), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Modif), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Utilisateur.LgdModif, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Utilisateur.TtpModif);


    private GridViewDataColumn AlterColumnNom_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Nom), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Nom), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Utilisateur.LgdNom, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Utilisateur.TtpNom, null);


    private GridViewDataColumn AlterColumnPrenom_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Prenom), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Prenom), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Utilisateur.LgdPrenom, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Utilisateur.TtpPrenom, null);


    private GridViewDataColumn AlterColumnFeminin_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterCheckColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Feminin), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Feminin), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Utilisateur.LgdFeminin, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Utilisateur.TtpFeminin);


    private GridViewDataColumn AlterColumnIdentite_0(int iCard, Unit width, string labelGrid, string toolTip)
              => GridViewsList[iCard].AlterTextColumn("c"+ AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Identite), !Page_PreRenderForbiddenFilters(iCard), !Page_PreRenderForbiddenFilters(iCard), width, AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DPL_V_PL0_Utilisateur.C_Identite), labelGrid.IsCompleted() ? labelGrid : RPL_V_PL0_Utilisateur.LgdIdentite, toolTip.IsCompleted() ? toolTip : RPL_V_PL0_Utilisateur.TtpIdentite, null);




    protected override void UpdateComboBoxColumnsGrid(int iCard)
    {
        base.UpdateComboBoxColumnsGrid(iCard);
        ITBfrStorageParameters vParameters = null;
        if (iCard == 0)
        {

        }
    }

    #endregion

    protected override void InitPopupControls(int iCard, Control control)
    {
        base.InitPopupControls(iCard, control);
        if (iCard==0)
          switch (control.ID)
          {
            case "Modif_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Modif_0"); break;
            case "EF_Modif_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "EF_Lib_Modif_0"); break;
            case "Feminin_0": ((TBfr_CheckBox)control).TBfr_TextBoxAssociee = (TBfr_TextBox)FindControlFromRoot(this, "Lib_Feminin_0"); break;
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
                // case "EF_Id_0": return vResult;
                // case "Modif_0": return vResult;
                // case "EF_Modif_0": return vResult;
case "Lib_Modif_0": return vResult.ToLowerCase() == "false" ? null : "X";
case "EF_Lib_Modif_0": return vResult.ToLowerCase() == "false" ? null : "X";

                // case "Nom_0": return vResult;
                // case "EF_Nom_0": return vResult;
                // case "Prenom_0": return vResult;
                // case "EF_Prenom_0": return vResult;
                // case "Feminin_0": return vResult;
                // case "EF_Feminin_0": return vResult;
case "Lib_Feminin_0": return vResult.ToLowerCase() == "false" ? null : "X";
case "EF_Lib_Feminin_0": return vResult.ToLowerCase() == "false" ? null : "X";


                // case "Identite_0": return vResult;
                // case "EF_Identite_0": return vResult;

            }
        return vResult;
    }

    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 0)
        {
            //if (FiltreModif_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Modif)+ FiltreModif_0.Valeur.ToSqlLike(true));
            //if (FiltreNom_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Nom)+ FiltreNom_0.Valeur.ToSqlLike(true));
            //if (FiltrePrenom_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Prenom)+ FiltrePrenom_0.Valeur.ToSqlLike(true));
            //if (FiltreFeminin_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Feminin)+ FiltreFeminin_0.Valeur.ToSqlLike(true));
            //if (FiltreIdentite_0.Valeur.IsCompleted())
   
            //GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DPL_V_PL0_Utilisateur.C_Identite)+ FiltreIdentite_0.Valeur.ToSqlLike(true));

        }
   }
}

