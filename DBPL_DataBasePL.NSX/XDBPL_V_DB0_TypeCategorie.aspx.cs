// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 09:16:49
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
using DevExpress.XtraPivotGrid;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBasePL.NSB;
using DataBasePL.NSP;
using DataBasePL.NSS;
using DataBasePL.NSD;
using DataBasePL.NSR;

public partial class XDBPL_V_DB0_TypeCategorie : DBPLForm 
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
        if (iCard == 7)
        {
            PivotGridsList[iCard] = grid_7;
            PivotGridsList[iCard].DataSource = SqlDataSourceGrid_7;
            base.Page_InitList(iCard, WebFormMode.Default);

           AssociatedTBfrBusinessCard[7] = new BDBPL_V_DB0_TypeCategorie(IStorageAccess);
           AssociatedITBfrStorageCard[7] = new SDBPL_V_DB0_TypeCategorie(IStorageAccess);
        }
    }

    #endregion

    #region load

   //protected override void Page_LoadPivotGrid(object sender, EventArgs e)
   //{
   //    base.Page_LoadPivotGrid(sender, e);
   //    if (IsFirstEntrance)
   //    {
   ////        Positionnement de filtres, etc en fonction de paramètres transmis à l'écran
   //    }
   //}

    #endregion

    #region événements : nothing

    #endregion

    #region prerender

    protected override void Page_PreRenderInitFilterCombos(int iCard)
    {
        base.Page_PreRenderInitFilterCombos(iCard);
        if (iCard == 7)
        {
            FiltreId_planning_7.InitFilterControl(null, new SDBPL_V_DBPL0_Id_planning(IStorageAccess), SqlDataSourceFiltreId_planning_7, DDBPL_V_DBPL0_Id_planning.C_Libelle.ToString(), null, true, true);
            FiltreId_mere_7.InitFilterControl(null, new SDBPL_V_DBPL0_Id_mere(IStorageAccess), SqlDataSourceFiltreId_mere_7, DDBPL_V_DBPL0_Id_mere.C_Libelle.ToString(), null, true, true);

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 7)
        {
//			if (FiltreId_planning_7.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Id_planning, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_planning_7.Valeur.ToSqlLong());
//			if (FiltreId_mere_7.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Id_mere, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_mere_7.Valeur.ToSqlLong());
//            if (FiltreLibelle_7.Valeur.IsCompleted())
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Libelle, FilterCombosParameters[iCard].ViewPrefix)+ FiltreLibelle_7.Valeur.ToSqlLike(true));

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RDBPL_V_DB0_TypeCategorie.Object;
    protected override string PageTitle => RDBPL_V_DB0_TypeCategorie.TitrePage;

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==7)
            switch (labelId)
            {
            case "LblFilterId_planning": 
            case "LblId_planning": return RDBPL_V_DB0_TypeCategorie.LblId_planning;
            case "LblFilterId_mere": 
            case "LblId_mere": return RDBPL_V_DB0_TypeCategorie.LblId_mere;
            case "LblFilterLibelle": 
            case "LblLibelle": return RDBPL_V_DB0_TypeCategorie.LblLibelle;

            }
        return base.TemplateLabelValue(iCard, labelId);
    }

    #endregion

    #region construction de la pivotgrid

    protected override void AddColumnsPivotGrid(int iCard)
    {
        base.AddColumnsPivotGrid(iCard);
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id)}_{iCard}");
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_planning)}_{iCard}");
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_mere)}_{iCard}");
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Libelle)}_{iCard}");

    }

    protected override void AlterColumnsPivotGrid(int iCard)
    {
        base.AlterColumnsPivotGrid(iCard);
        AlterColumn_fId_7(iCard, null, null);
        AlterColumn_fId_planning_7(iCard, null, null);
        AlterColumn_fId_mere_7(iCard, null, null);
        AlterColumn_fLibelle_7(iCard, null, null);

    }

    protected override void CompleteAreasPivotGrid(int iCard)
    {
        if (iCard == 7)
        {
            PivotGridsList[iCard].AllowedFieldsInColumnArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].AllowedFieldsInRowArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].AllowedFieldsInDataArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].AllowedFieldsInFilterArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].FieldsInFilterArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].FieldsInColumnArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].FieldsInRowArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].FieldsInDataArea(
                ""
,"fId_7"
,"fId_planning_7"
,"fId_mere_7"
,"fLibelle_7"

                );
            PivotGridsList[iCard].OptionsDataField.Area = PivotDataArea.ColumnArea;
            PivotGridsList[iCard].OptionsDataField.AreaIndex = 0;
       }

    }

    private DevExpress.Web.ASPxPivotGrid.PivotGridField AlterColumn_fId_planning_7(int iCard, string fieldName, string caption)
        => PivotGridsList[iCard].AlterIntegerField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_planning)}_{iCard}",
    fieldName ?? AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_planning), caption ?? RDBPL_V_DB0_TypeCategorie.Id_planning, null, null);

    private DevExpress.Web.ASPxPivotGrid.PivotGridField AlterColumn_fId_mere_7(int iCard, string fieldName, string caption)
        => PivotGridsList[iCard].AlterIntegerField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_mere)}_{iCard}",
    fieldName ?? AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Id_mere), caption ?? RDBPL_V_DB0_TypeCategorie.Id_mere, null, null);

    private DevExpress.Web.ASPxPivotGrid.PivotGridField AlterColumn_fLibelle_7(int iCard, string fieldName, string caption)
        => PivotGridsList[iCard].AlterTextField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Libelle)}_{iCard}",
      fieldName ?? AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_TypeCategorie.C_Libelle), caption ?? RDBPL_V_DB0_TypeCategorie.Libelle, null);




    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 7)
        {
			if (FiltreId_planning_7.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Id_planning)+ "=" + FiltreId_planning_7.Valeur.ToSqlLong());
			if (FiltreId_mere_7.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Id_mere)+ "=" + FiltreId_mere_7.Valeur.ToSqlLong());
            if (FiltreLibelle_7.Valeur.IsCompleted())
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_TypeCategorie.C_Libelle)+ FiltreLibelle_7.Valeur.ToSqlLike(true));

        }
   }
}

