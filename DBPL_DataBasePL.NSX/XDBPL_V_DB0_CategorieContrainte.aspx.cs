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

public partial class XDBPL_V_DB0_CategorieContrainte : DBPLForm 
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

           AssociatedTBfrBusinessCard[7] = new BDBPL_V_DB0_CategorieContrainte(IStorageAccess);
           AssociatedITBfrStorageCard[7] = new SDBPL_V_DB0_CategorieContrainte(IStorageAccess);
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
            FiltreId_categorie_7.InitFilterControl(null, new SDBPL_V_DBPL0_Id_categorie(IStorageAccess), SqlDataSourceFiltreId_categorie_7, DDBPL_V_DBPL0_Id_categorie.C_Libelle.ToString(), null, true, true);
            FiltreId_contrainte_7.InitFilterControl(null, new SDBPL_V_DBPL0_Id_contrainte(IStorageAccess), SqlDataSourceFiltreId_contrainte_7, DDBPL_V_DBPL0_Id_contrainte.C_Libelle.ToString(), null, true, true);

        }
    }

    protected override void SetConditionToFilterCombosParameters(int iCard)
    {
        base.SetConditionToFilterCombosParameters(iCard);
        if (iCard == 7)
        {
//			if (FiltreId_categorie_7.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_CategorieContrainte.C_Id_categorie, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_categorie_7.Valeur.ToSqlLong());
//			if (FiltreId_contrainte_7.Valeur.ToLongOrDefault(-1) != -1)
   
            //    FilterCombosParameters[iCard].Condition = FilterCombosParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_CategorieContrainte.C_Id_contrainte, FilterCombosParameters[iCard].ViewPrefix)+ "=" + FiltreId_contrainte_7.Valeur.ToSqlLong());

        }
    }

    protected override bool Page_PreRenderForbiddenFilters(int iCard) => false; 

    #endregion

    #region gestion des libellés

    protected override string ObjectName => RDBPL_V_DB0_CategorieContrainte.Object;
    protected override string PageTitle => RDBPL_V_DB0_CategorieContrainte.TitrePage;

    protected override string TemplateLabelValue(int iCard, string labelId)
    {
        if (iCard==7)
            switch (labelId)
            {
            case "LblFilterId_categorie": 
            case "LblId_categorie": return RDBPL_V_DB0_CategorieContrainte.LblId_categorie;
            case "LblFilterId_contrainte": 
            case "LblId_contrainte": return RDBPL_V_DB0_CategorieContrainte.LblId_contrainte;

            }
        return base.TemplateLabelValue(iCard, labelId);
    }

    #endregion

    #region construction de la pivotgrid

    protected override void AddColumnsPivotGrid(int iCard)
    {
        base.AddColumnsPivotGrid(iCard);
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id)}_{iCard}");
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_categorie)}_{iCard}");
        PivotGridsList[iCard].AddField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_contrainte)}_{iCard}");

    }

    protected override void AlterColumnsPivotGrid(int iCard)
    {
        base.AlterColumnsPivotGrid(iCard);
        AlterColumn_fId_7(iCard, null, null);
        AlterColumn_fId_categorie_7(iCard, null, null);
        AlterColumn_fId_contrainte_7(iCard, null, null);

    }

    protected override void CompleteAreasPivotGrid(int iCard)
    {
        if (iCard == 7)
        {
            PivotGridsList[iCard].AllowedFieldsInColumnArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].AllowedFieldsInRowArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].AllowedFieldsInDataArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].AllowedFieldsInFilterArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].FieldsInFilterArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].FieldsInColumnArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].FieldsInRowArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].FieldsInDataArea(
                ""
,"fId_7"
,"fId_categorie_7"
,"fId_contrainte_7"

                );
            PivotGridsList[iCard].OptionsDataField.Area = PivotDataArea.ColumnArea;
            PivotGridsList[iCard].OptionsDataField.AreaIndex = 0;
       }

    }

    private DevExpress.Web.ASPxPivotGrid.PivotGridField AlterColumn_fId_categorie_7(int iCard, string fieldName, string caption)
        => PivotGridsList[iCard].AlterIntegerField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_categorie)}_{iCard}",
    fieldName ?? AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_categorie), caption ?? RDBPL_V_DB0_CategorieContrainte.Id_categorie, null, null);

    private DevExpress.Web.ASPxPivotGrid.PivotGridField AlterColumn_fId_contrainte_7(int iCard, string fieldName, string caption)
        => PivotGridsList[iCard].AlterIntegerField($"f{AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_contrainte)}_{iCard}",
    fieldName ?? AssociatedITBfrStorageCard[iCard].DbNameForOrderBy(DDBPL_V_DB0_CategorieContrainte.C_Id_contrainte), caption ?? RDBPL_V_DB0_CategorieContrainte.Id_contrainte, null, null);



    #endregion

    protected override void InitGridParameters(int iCard)
    {
        base.InitGridParameters(iCard);
        if (iCard == 7)
        {
			if (FiltreId_categorie_7.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_CategorieContrainte.C_Id_categorie)+ "=" + FiltreId_categorie_7.Valeur.ToSqlLong());
			if (FiltreId_contrainte_7.Valeur.ToLongOrDefault(-1) != -1)
   
            GridParameters[iCard].Condition = GridParameters[iCard].Condition.AppendStrings(null, " and ", AssociatedITBfrStorageCard[iCard].DbNameForWhere( DDBPL_V_DB0_CategorieContrainte.C_Id_contrainte)+ "=" + FiltreId_contrainte_7.Valeur.ToSqlLong());

        }
   }
}

