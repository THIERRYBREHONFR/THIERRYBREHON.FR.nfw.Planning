// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 09:14:23
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_EquipeEmployeVersion_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_EquipeEmployeVersion_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_EquipeEmployeVersion(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 6;
        public const int C_AdditionalColumnsCount = 22 - 6;

        public override int UpdateColumnsCount => C_UpdateColumnsCount;
        public override int AdditionalColumnsCount => C_AdditionalColumnsCount;

        #region Initialization

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type)
        {
            switch (associatedIndex)
            {
                case C_Id: return NewDId(tBfrData_Type);
                case C_Logicaldeleted: return NewDLogicaldeleted(tBfrData_Type);
                case C_Id_version: return NewDId_version(tBfrData_Type);
                case C_Id_equipe: return NewDId_equipe(tBfrData_Type);
                case C_Id_employe: return NewDId_employe(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);
                case C_Nom_employe: return NewDNom_employe(tBfrData_Type);
                case C_Prenom_employe: return NewDPrenom_employe(tBfrData_Type);
                case C_Feminin_employe: return NewDFeminin_employe(tBfrData_Type);
                case C_Ident_employe: return NewDIdent_employe(tBfrData_Type);
                case C_Init_employe: return NewDInit_employe(tBfrData_Type);
                case C_Abr_equipe: return NewDAbr_equipe(tBfrData_Type);
                case C_Lib_equipe: return NewDLib_equipe(tBfrData_Type);
                case C_Lib_planning_equipe: return NewDLib_planning_equipe(tBfrData_Type);
                case C_Abr_planning_equipe: return NewDAbr_planning_equipe(tBfrData_Type);
                case C_Abr_version: return NewDAbr_version(tBfrData_Type);
                case C_Lib_version: return NewDLib_version(tBfrData_Type);
                case C_Lib_planning_version: return NewDLib_planning_version(tBfrData_Type);
                case C_Abr_planning_version: return NewDAbr_planning_version(tBfrData_Type);

                default: return null;
            }
        }

        #endregion

        #region 0 Id long

        public const int C_Id = 0;

        public virtual ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);

     
        public override TBfrData<long> DId => (TBfrData<long>)AssociatedChild(C_Id); 

     
        #endregion

        #region 1 Logicaldeleted bool

        public const int C_Logicaldeleted = 1;

        public virtual ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);

     
        public bool Logicaldeleted => DLogicaldeleted.Content; 
        public TBfrData<bool> DLogicaldeleted => (TBfrData<bool>)AssociatedChild(C_Logicaldeleted); 

     
        #endregion

        #region 2 Id_version long

        public const int C_Id_version = 2;

        public virtual ITBfrData NewDId_version(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_version, true, false, true, true, this);

     
        public long Id_version => DId_version.Content; 
        public TBfrData<long> DId_version => (TBfrData<long>)AssociatedChild(C_Id_version); 

     
        #endregion

        #region 3 Id_equipe long

        public const int C_Id_equipe = 3;

        public virtual ITBfrData NewDId_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_equipe, true, false, true, true, this);

     
        public long Id_equipe => DId_equipe.Content; 
        public TBfrData<long> DId_equipe => (TBfrData<long>)AssociatedChild(C_Id_equipe); 

     
        #endregion

        #region 4 Id_employe long

        public const int C_Id_employe = 4;

        public virtual ITBfrData NewDId_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_employe, true, false, true, true, this);

     
        public long Id_employe => DId_employe.Content; 
        public TBfrData<long> DId_employe => (TBfrData<long>)AssociatedChild(C_Id_employe); 

     
        #endregion

        #region 5 Id_espaceclient long

        public const int C_Id_espaceclient = 5;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 6 Id_planning long

        public const int C_Id_planning = 6;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, false, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 7 Lib_planning string

        public const int C_Lib_planning = 7;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion

        #region 8 Abr_planning string

        public const int C_Abr_planning = 8;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion

        #region 9 Nom_employe string

        public const int C_Nom_employe = 9;

        public virtual ITBfrData NewDNom_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Nom_employe, true, false, false, false, this);

     
        public string Nom_employe => DNom_employe.Content; 
        public TBfrData<string> DNom_employe => (TBfrData<string>)AssociatedChild(C_Nom_employe); 

     
        #endregion

        #region 10 Prenom_employe string

        public const int C_Prenom_employe = 10;

        public virtual ITBfrData NewDPrenom_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Prenom_employe, true, false, false, false, this);

     
        public string Prenom_employe => DPrenom_employe.Content; 
        public TBfrData<string> DPrenom_employe => (TBfrData<string>)AssociatedChild(C_Prenom_employe); 

     
        #endregion

        #region 11 Feminin_employe bool

        public const int C_Feminin_employe = 11;

        public virtual ITBfrData NewDFeminin_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin_employe, false, true, false, false, this);

     
        public bool Feminin_employe => DFeminin_employe.Content; 
        public TBfrData<bool> DFeminin_employe => (TBfrData<bool>)AssociatedChild(C_Feminin_employe); 

     
        #endregion

        #region 12 Ident_employe string

        public const int C_Ident_employe = 12;

        public virtual ITBfrData NewDIdent_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Ident_employe, true, false, false, false, this);

     
        public string Ident_employe => DIdent_employe.Content; 
        public TBfrData<string> DIdent_employe => (TBfrData<string>)AssociatedChild(C_Ident_employe); 

     
        #endregion

        #region 13 Init_employe string

        public const int C_Init_employe = 13;

        public virtual ITBfrData NewDInit_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Init_employe, true, false, false, false, this);

     
        public string Init_employe => DInit_employe.Content; 
        public TBfrData<string> DInit_employe => (TBfrData<string>)AssociatedChild(C_Init_employe); 

     
        #endregion

        #region 14 Abr_equipe string

        public const int C_Abr_equipe = 14;

        public virtual ITBfrData NewDAbr_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_equipe, true, false, false, false, this);

     
        public string Abr_equipe => DAbr_equipe.Content; 
        public TBfrData<string> DAbr_equipe => (TBfrData<string>)AssociatedChild(C_Abr_equipe); 

     
        #endregion

        #region 15 Lib_equipe string

        public const int C_Lib_equipe = 15;

        public virtual ITBfrData NewDLib_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_equipe, true, false, false, false, this);

     
        public string Lib_equipe => DLib_equipe.Content; 
        public TBfrData<string> DLib_equipe => (TBfrData<string>)AssociatedChild(C_Lib_equipe); 

     
        #endregion

        #region 16 Lib_planning_equipe string

        public const int C_Lib_planning_equipe = 16;

        public virtual ITBfrData NewDLib_planning_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_equipe, true, false, false, false, this);

     
        public string Lib_planning_equipe => DLib_planning_equipe.Content; 
        public TBfrData<string> DLib_planning_equipe => (TBfrData<string>)AssociatedChild(C_Lib_planning_equipe); 

     
        #endregion

        #region 17 Abr_planning_equipe string

        public const int C_Abr_planning_equipe = 17;

        public virtual ITBfrData NewDAbr_planning_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_equipe, true, false, false, false, this);

     
        public string Abr_planning_equipe => DAbr_planning_equipe.Content; 
        public TBfrData<string> DAbr_planning_equipe => (TBfrData<string>)AssociatedChild(C_Abr_planning_equipe); 

     
        #endregion

        #region 18 Abr_version string

        public const int C_Abr_version = 18;

        public virtual ITBfrData NewDAbr_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_version, true, false, false, false, this);

     
        public string Abr_version => DAbr_version.Content; 
        public TBfrData<string> DAbr_version => (TBfrData<string>)AssociatedChild(C_Abr_version); 

     
        #endregion

        #region 19 Lib_version string

        public const int C_Lib_version = 19;

        public virtual ITBfrData NewDLib_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_version, true, false, false, false, this);

     
        public string Lib_version => DLib_version.Content; 
        public TBfrData<string> DLib_version => (TBfrData<string>)AssociatedChild(C_Lib_version); 

     
        #endregion

        #region 20 Lib_planning_version string

        public const int C_Lib_planning_version = 20;

        public virtual ITBfrData NewDLib_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_version, true, false, false, false, this);

     
        public string Lib_planning_version => DLib_planning_version.Content; 
        public TBfrData<string> DLib_planning_version => (TBfrData<string>)AssociatedChild(C_Lib_planning_version); 

     
        #endregion

        #region 21 Abr_planning_version string

        public const int C_Abr_planning_version = 21;

        public virtual ITBfrData NewDAbr_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_version, true, false, false, false, this);

     
        public string Abr_planning_version => DAbr_planning_version.Content; 
        public TBfrData<string> DAbr_planning_version => (TBfrData<string>)AssociatedChild(C_Abr_planning_version); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_EquipeEmployeVersion";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_version";
        case 3: return "Id_equipe";
        case 4: return "Id_employe";
        case 5: return "Id_espaceclient";
        case 6: return "Id_planning";
        case 7: return "Lib_planning";
        case 8: return "Abr_planning";
        case 9: return "Nom_employe";
        case 10: return "Prenom_employe";
        case 11: return "Feminin_employe";
        case 12: return "Ident_employe";
        case 13: return "Init_employe";
        case 14: return "Abr_equipe";
        case 15: return "Lib_equipe";
        case 16: return "Lib_planning_equipe";
        case 17: return "Abr_planning_equipe";
        case 18: return "Abr_version";
        case 19: return "Lib_version";
        case 20: return "Lib_planning_version";
        case 21: return "Abr_planning_version";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_EquipeEmployeVersion.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_EquipeEmployeVersion.Id;
                case C_Id_version: return RPL_V_PL0_EquipeEmployeVersion.Id_version;
                case C_Id_equipe: return RPL_V_PL0_EquipeEmployeVersion.Id_equipe;
                case C_Id_employe: return RPL_V_PL0_EquipeEmployeVersion.Id_employe;
                case C_Id_espaceclient: return RPL_V_PL0_EquipeEmployeVersion.Id_espaceclient;
                case C_Id_planning: return RPL_V_PL0_EquipeEmployeVersion.Id_planning;
                case C_Lib_planning: return RPL_V_PL0_EquipeEmployeVersion.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_EquipeEmployeVersion.Abr_planning;
                case C_Nom_employe: return RPL_V_PL0_EquipeEmployeVersion.Nom_employe;
                case C_Prenom_employe: return RPL_V_PL0_EquipeEmployeVersion.Prenom_employe;
                case C_Feminin_employe: return RPL_V_PL0_EquipeEmployeVersion.Feminin_employe;
                case C_Ident_employe: return RPL_V_PL0_EquipeEmployeVersion.Ident_employe;
                case C_Init_employe: return RPL_V_PL0_EquipeEmployeVersion.Init_employe;
                case C_Abr_equipe: return RPL_V_PL0_EquipeEmployeVersion.Abr_equipe;
                case C_Lib_equipe: return RPL_V_PL0_EquipeEmployeVersion.Lib_equipe;
                case C_Lib_planning_equipe: return RPL_V_PL0_EquipeEmployeVersion.Lib_planning_equipe;
                case C_Abr_planning_equipe: return RPL_V_PL0_EquipeEmployeVersion.Abr_planning_equipe;
                case C_Abr_version: return RPL_V_PL0_EquipeEmployeVersion.Abr_version;
                case C_Lib_version: return RPL_V_PL0_EquipeEmployeVersion.Lib_version;
                case C_Lib_planning_version: return RPL_V_PL0_EquipeEmployeVersion.Lib_planning_version;
                case C_Abr_planning_version: return RPL_V_PL0_EquipeEmployeVersion.Abr_planning_version;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_EquipeEmployeVersion ToStruct() => new DSPL_V_PL0_EquipeEmployeVersion 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_version = DId_version == null || DId_version.IsNull ? null : Id_version.ToString(),
            Id_equipe = DId_equipe == null || DId_equipe.IsNull ? null : Id_equipe.ToString(),
            Id_employe = DId_employe == null || DId_employe.IsNull ? null : Id_employe.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),

          };
    }
    
    public class DPL_V_PL0_EquipeEmployeVersion_List_generated : TBfrData_List
    {

        public DPL_V_PL0_EquipeEmployeVersion_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_EquipeEmployeVersion_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_EquipeEmployeVersion.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_EquipeEmployeVersion_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_EquipeEmployeVersion> ToStruct() => this.Select(x => ((DPL_V_PL0_EquipeEmployeVersion)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_EquipeEmployeVersion(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_EquipeEmployeVersion : DPL_V_PL0_EquipeEmployeVersion_generated
    {
          public DPL_V_PL0_EquipeEmployeVersion(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_EquipeEmployeVersion_List : DPL_V_PL0_EquipeEmployeVersion_List_generated
    {
          public DPL_V_PL0_EquipeEmployeVersion_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_EquipeEmployeVersion
    {
            public string Id;
            public string Logicaldeleted;
            public string Id_version;
            public string Id_equipe;
            public string Id_employe;
            public string Id_espaceclient;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_version(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_version, false, false, true, true, this);
     
        public override ITBfrData NewDId_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_equipe, false, false, true, true, this);
     
        public override ITBfrData NewDId_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_employe, false, false, true, true, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, false, true, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDNom_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Nom_employe, true, false, false, false, this);
     
        public override ITBfrData NewDPrenom_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Prenom_employe, true, false, false, false, this);
     
        public override ITBfrData NewDFeminin_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin_employe, false, true, false, false, this);
     
        public override ITBfrData NewDIdent_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Ident_employe, true, false, false, false, this);
     
        public override ITBfrData NewDInit_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Init_employe, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_equipe, true, false, false, false, this);
     
        public override ITBfrData NewDLib_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_equipe, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_equipe, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning_equipe(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_equipe, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_version, true, false, false, false, this);
     
        public override ITBfrData NewDLib_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_version, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_version, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_version, true, false, false, false, this);
     

  */

