// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_EquipeEmployeVersion_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_EquipeEmployeVersion_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_EquipeEmployeVersion(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 6;
        public const int C_AdditionalColumnsCount = 6 - 6;

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



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_EquipeEmployeVersion";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_version";
        case 3: return "Id_equipe";
        case 4: return "Id_employe";
        case 5: return "Id_espaceclient";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_EquipeEmployeVersion.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_EquipeEmployeVersion.Id;
                case C_Id_version: return RDBPL_V_DB0_EquipeEmployeVersion.Id_version;
                case C_Id_equipe: return RDBPL_V_DB0_EquipeEmployeVersion.Id_equipe;
                case C_Id_employe: return RDBPL_V_DB0_EquipeEmployeVersion.Id_employe;
                case C_Id_espaceclient: return RDBPL_V_DB0_EquipeEmployeVersion.Id_espaceclient;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_EquipeEmployeVersion ToStruct() => new DSDBPL_V_DB0_EquipeEmployeVersion 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_version = DId_version == null || DId_version.IsNull ? null : Id_version.ToString(),
            Id_equipe = DId_equipe == null || DId_equipe.IsNull ? null : Id_equipe.ToString(),
            Id_employe = DId_employe == null || DId_employe.IsNull ? null : Id_employe.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_EquipeEmployeVersion_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_EquipeEmployeVersion_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_EquipeEmployeVersion_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_EquipeEmployeVersion.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_EquipeEmployeVersion_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_EquipeEmployeVersion> ToStruct() => this.Select(x => ((DDBPL_V_DB0_EquipeEmployeVersion)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_EquipeEmployeVersion(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_EquipeEmployeVersion : DDBPL_V_DB0_EquipeEmployeVersion_generated
    {
          public DDBPL_V_DB0_EquipeEmployeVersion(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_EquipeEmployeVersion_List : DDBPL_V_DB0_EquipeEmployeVersion_List_generated
    {
          public DDBPL_V_DB0_EquipeEmployeVersion_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_EquipeEmployeVersion
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
     

  */

