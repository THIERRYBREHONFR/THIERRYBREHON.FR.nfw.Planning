using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using DevExpress.Data;
using DevExpress.Web;
using DevExpress.Web.Data;
using Planning.NSB;
using Planning.NSS;
using Planning.NSR;
using Planning.NSD;
using THIERRYBREHON.FR.Web;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSB;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.NSR;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.NSP;
namespace Planning.NSP
{
    public class PLForm : WebForm
    {
        public PLForm() : base() => IStorageAccess
            = new TBfrStorageAccess(new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlConnectionDataPL"].ConnectionString),
                new TBfrStorageAccess(new SqlConnection(WebConfigurationManager.ConnectionStrings["SqlConnectionService"].ConnectionString)));

        protected DPL_V_PL9_Droits PCTPL9_Droits => (DPL_V_PL9_Droits)DUserRights;

        protected override TBfrBusiness_ListWithRead CreateBUserRights() => new BPL_V_PL9_Droits(IStorageAccess);

        protected override string AcceptedLogLevel => "LogPL";
        protected override string SessionTimeOut => "SessionTimeOutPL";
        protected override string SummaryScreen => "PL/PL_Sommaire.aspx";
        protected override string HomeScreen => "ET/ET_Sommaire.aspx";
        protected override string ApplicationCode => "PL";

        #region paramètres persistants

        protected virtual string Parm =>
            ((string)null).AppendStrings("&", "&",
            ParmId_planning != 0 ? C_Query_Id_planning + "=" + ParmId_planning : null,
            ParmId_version != 0 ? C_Query_Id_version + "=" + ParmId_version : null,
            ParmId_employe != 0 ? C_Query_Id_employe + "=" + ParmId_employe : null);


        #region Id_planning

        public const string C_Query_Id_planning = "idpl";

        PL_ComboBox PFiltreId_planning_0 => FindControlFromRoot(this, this.ControlName(0, "FiltreId_planning", false)) as PL_ComboBox;

        protected SqlDataSource SqlDataSourceFiltreId_planning_0 = new SqlDataSource() { ConnectionString = WebConfigurationManager.ConnectionStrings["SqlConnectionDataPL"].ToString(), };
        private TBfr_HiddenField HFId_planning => FindControlFromRoot(this, this.ControlName(-1, "FHFId_planning", false)) as TBfr_HiddenField;

        protected long ParmId_planning
        {
            get => HFId_planning == null ? 0 : HFId_planning.Valeur.ToLongOrDefault(default);
            set { if (HFId_planning != null) HFId_planning.Valeur = value.ToString(); }
        }

        protected void FPFiltreId_planning_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParmId_planning = PFiltreId_planning_0.Valeur.ToLongOrDefault(default);
        }

        #endregion Id_planning

        #region Id_version

        public const string C_Query_Id_version = "idve";

        PL_ComboBox PFiltreId_version_0 => FindControlFromRoot(this, this.ControlName(0, "FiltreId_version", false)) as PL_ComboBox;

        protected SqlDataSource SqlDataSourceFiltreId_version_0 = new SqlDataSource() { ConnectionString = WebConfigurationManager.ConnectionStrings["SqlConnectionDataPL"].ToString(), };

        private TBfr_HiddenField HFId_version => FindControlFromRoot(this, this.ControlName(-1, "FHFId_version", false)) as TBfr_HiddenField;

        protected long ParmId_version
        {
            get => HFId_version == null ? 0 : HFId_version.Valeur.ToLongOrDefault(default);
            set { if (HFId_version != null) HFId_version.Valeur = value.ToString(); }
        }

        protected void FPFiltreId_version_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParmId_version = PFiltreId_version_0.Valeur.ToLongOrDefault(default);
        }

        #endregion Id_version

        #region Id_employe

        public const string C_Query_Id_employe = "idem";

        PL_ComboBox PFiltreId_employe_0 => FindControlFromRoot(this, this.ControlName(0, "FiltreId_employe", false)) as PL_ComboBox;

        protected SqlDataSource SqlDataSourceFiltreId_employe_0 = new SqlDataSource() { ConnectionString = WebConfigurationManager.ConnectionStrings["SqlConnectionDataPL"].ToString(), };
        private TBfr_HiddenField HFId_employe => FindControlFromRoot(this, this.ControlName(-1, "FId_employe", false)) as TBfr_HiddenField;

        protected long ParmId_employe
        {
            get => HFId_employe == null ? 0 : HFId_employe.Valeur.ToLongOrDefault(default);
            set { if (HFId_employe != null) HFId_employe.Valeur = value.ToString(); }
        }

        protected void FPFiltreId_employe_0_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParmId_employe = PFiltreId_employe_0.Valeur.ToLongOrDefault(default);
        }

        #endregion Id_employe

        #endregion

        protected override void Page_PreRender(object sender, EventArgs e)
        {
            base.Page_PreRender(sender, e);
            if (PFiltreId_planning_0 != null)
            {
                PFiltreId_planning_0.InitFilterControl(null, new SPL_V_PL0_Planning(IStorageAccess), SqlDataSourceFiltreId_planning_0, DPL_V_PL0_Planning.C_Libelle.ToString(), null, true, true);
                PFiltreId_planning_0.Valeur = ParmId_planning.ToString();
            }
            if (PFiltreId_version_0 != null)
            {
                PFiltreId_version_0.InitFilterControl(null, new SPL_V_PL0_Version(IStorageAccess), SqlDataSourceFiltreId_version_0, DPL_V_PL0_Version.C_Libelle.ToString(), null, true, true);
                PFiltreId_version_0.Valeur = ParmId_version.ToString();
            }
            if (PFiltreId_employe_0 != null)
            {
                PFiltreId_employe_0.InitChoiceControl(null, new SPL_V_PL0_Employe(IStorageAccess), SqlDataSourceFiltreId_employe_0, DPL_V_PL0_Employe.C_Identite.ToString(), null, true, true);
                PFiltreId_employe_0.Valeur = ParmId_employe.ToString();
            }
            //if (PMenuPlanning != null)
            //    PMenuPlanning.Visible = (Etat == TBfrConst.OperationAucune) && !ModifDansPileAppel();
            //if (LogoutButton != null)
            //    LogoutButton.Visible = (Etat == TBfrConst.OperationAucune) && !ModifDansPileAppel();
        }

        protected override void Page_Init(object sender, EventArgs e)
        {
            base.Page_Init(sender, e);
            if (IsFirstEntrance)
            {
                ParmId_planning = Request.Params[C_Query_Id_planning].ToLongOrDefault(-1);
                ParmId_version = Request.Params[C_Query_Id_version].ToLongOrDefault(-1);
                ParmId_employe = Request.Params[C_Query_Id_employe].ToLongOrDefault(-1);
            }
        }

        //protected override void Page_Init(object sender, EventArgs e)
        //{
        //    base.Page_Init(sender, e);
        //    if (PFiltreId_planning_0 != null)
        //    {
        //        PFiltreId_planning_0.InitChoiceControl(null, new TP_DalPLC_Planning(), TP_DalPLC_Planning.C_Id, TP_DalPLC_Planning.C_Libelle,
        //           SqlDataSourceFiltreId_planning, TP_DalPLC_Planning.C_Libelle.ToString(), null, true, true);
        //        if (IsFirstEntrance && Request.Params[PL_Const.C_ParmPlanning].TolongOrDefault() > 0)
        //            PFiltreId_planning_0.Valeur = Request.Params[PL_Const.C_ParmPlanning];
        //    }
        //    if (PFiltreId_version_0 != null)
        //    {
        //        PFiltreId_version_0.InitChoiceControl(null, new TP_DalPLC_Version(), TP_DalPLC_Version.C_Id, TP_DalPLC_Version.C_Libelle,
        //           SqlDataSourceFiltreId_version, TP_DalPLC_Version.C_Libelle.ToString(), null, true, true);
        //        if (IsFirstEntrance && Request.Params[PL_Const.C_ParmVersion].TolongOrDefault() > 0)
        //            PFiltreId_version_0.Valeur = Request.Params[PL_Const.C_ParmVersion];
        //    }
        //    if (PFiltreId_employe_0 != null)
        //    {
        //        PFiltreId_employe_0.InitChoiceControl(null, new TP_DalPLC_Employe(), TP_DalPLC_Employe.C_Id, TP_DalPLC_Employe.C_Identite,
        //           SqlDataSourceFiltreId_employe, TP_DalPLC_Employe.C_Identite.ToString(), null, true, true);
        //        if (IsFirstEntrance && Request.Params[PL_Const.C_ParmEmploye].TolongOrDefault() > 0)
        //            PFiltreId_employe_0.Valeur = Request.Params[PL_Const.C_ParmEmploye];
        //    }
        //}

        //protected BA_ComboBox PFiltreId_planning_0 { get { return TrouverControle(0, "FPFiltreId_planning") as BA_ComboBox; } }
        //protected BA_ComboBox PFiltreId_version_0 { get { return TrouverControle(0, "FPFiltreId_version") as BA_ComboBox; } }
        //protected BA_ComboBox PFiltreId_employe_0 { get { return TrouverControle(0, "FPFiltreId_employe") as BA_ComboBox; } }

        //protected override void GoToNextScreen(string VEcranAppele, bool VEcranCourant, string VIdentifiantsASelectionner, string VOperationsDemandees, string VNomsIdentifiantsSelectionnes, string VFonctionsHorsStd, string VParametresSupplementaires)
        //{
        //    if (PFiltreId_planning_0 != null)
        //        VParametresSupplementaires = VParametresSupplementaires.Appendstrings("&", PFiltreId_planning_0.Valeur.TolongOrDefault() > 0 ? ("pl=" + PFiltreId_planning_0.Valeur) : null);
        //    if (PFiltreId_version_0 != null)
        //        VParametresSupplementaires = VParametresSupplementaires.Appendstrings("&", PFiltreId_version_0.Valeur.TolongOrDefault() > 0 ? ("pl=" + PFiltreId_version_0.Valeur) : null);
        //    if (PFiltreId_employe_0 != null)
        //        VParametresSupplementaires = VParametresSupplementaires.Appendstrings("&", PFiltreId_employe_0.Valeur.TolongOrDefault() > 0 ? ("pl=" + PFiltreId_employe_0.Valeur) : null);
        //    base.GoToNextScreen(VEcranAppele, true, VIdentifiantsASelectionner, VOperationsDemandees, VNomsIdentifiantsSelectionnes, VFonctionsHorsStd, VParametresSupplementaires);
        //}

        //private BA_HiddenField PHFId_projet => TrouverControle(-1, "FPId_projet") as BA_HiddenField;
        //protected long PId_projet
        //{
        //    get { return PHFId_projet == null ? 0 : PHFId_projet.Valeur.TolongOrDefault(); }
        //    set { if (PHFId_projet != null) PHFId_projet.Valeur = value.ToString(); }
        //}

        //private BA_HiddenField PHFId_employe => TrouverControle(-1, "FPId_employe") as BA_HiddenField;
        //protected long PId_employe
        //{
        //    get { return PHFId_employe == null ? 0 : PHFId_employe.Valeur.TolongOrDefault(); }
        //    set { if (PHFId_employe != null) PHFId_employe.Valeur = value.ToString(); }
        //}

        protected override ITemplate ColumnCommandTemplate(int iCard)
            => new PL_GridViewPostBackButtonsTemplate(GridViewCustomUpdate_Click, GridViewCustomDuplicate_Click, GridViewCustomDelete_Click, GridViewCustomVisualize_Click,
                     "Images/Modifier.png", "Images/Dupliquer.png", "Images/archiver.png", "Images/Consulter.png");

    }
}