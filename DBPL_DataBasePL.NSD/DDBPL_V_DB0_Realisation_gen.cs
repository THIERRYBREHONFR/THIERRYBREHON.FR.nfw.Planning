// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_Realisation_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_Realisation_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Realisation(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 8;
        public const int C_AdditionalColumnsCount = 8 - 8;

        public override int UpdateColumnsCount => C_UpdateColumnsCount;
        public override int AdditionalColumnsCount => C_AdditionalColumnsCount;

        #region Initialization

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type)
        {
            switch (associatedIndex)
            {
                case C_Id: return NewDId(tBfrData_Type);
                case C_Debut: return NewDDebut(tBfrData_Type);
                case C_Id_employe: return NewDId_employe(tBfrData_Type);
                case C_Duree: return NewDDuree(tBfrData_Type);
                case C_Logicaldeleted: return NewDLogicaldeleted(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Id_contrainterealisee: return NewDId_contrainterealisee(tBfrData_Type);
                case C_Id_contrainte: return NewDId_contrainte(tBfrData_Type);

                default: return null;
            }
        }

        #endregion

        #region 0 Id long

        public const int C_Id = 0;

        public virtual ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);

     
        public override TBfrData<long> DId => (TBfrData<long>)AssociatedChild(C_Id); 

     
        #endregion

        #region 1 Debut DateTime

        public const int C_Debut = 1;

        public virtual ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, true, false, this);

     
        public DateTime Debut => DDebut.Content; 
        public TBfrData<DateTime> DDebut => (TBfrData<DateTime>)AssociatedChild(C_Debut); 

     
        #endregion

        #region 2 Id_employe long

        public const int C_Id_employe = 2;

        public virtual ITBfrData NewDId_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_employe, true, false, true, true, this);

     
        public long Id_employe => DId_employe.Content; 
        public TBfrData<long> DId_employe => (TBfrData<long>)AssociatedChild(C_Id_employe); 

     
        #endregion

        #region 3 Duree int

        public const int C_Duree = 3;

        public virtual ITBfrData NewDDuree(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Duree, false, false, true, false, this);

     
        public int Duree => DDuree.Content; 
        public TBfrData<int> DDuree => (TBfrData<int>)AssociatedChild(C_Duree); 

     
        #endregion

        #region 4 Logicaldeleted bool

        public const int C_Logicaldeleted = 4;

        public virtual ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);

     
        public bool Logicaldeleted => DLogicaldeleted.Content; 
        public TBfrData<bool> DLogicaldeleted => (TBfrData<bool>)AssociatedChild(C_Logicaldeleted); 

     
        #endregion

        #region 5 Id_espaceclient long

        public const int C_Id_espaceclient = 5;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 6 Id_contrainterealisee long

        public const int C_Id_contrainterealisee = 6;

        public virtual ITBfrData NewDId_contrainterealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainterealisee, true, false, true, true, this);

     
        public long Id_contrainterealisee => DId_contrainterealisee.Content; 
        public TBfrData<long> DId_contrainterealisee => (TBfrData<long>)AssociatedChild(C_Id_contrainterealisee); 

     
        #endregion

        #region 7 Id_contrainte long

        public const int C_Id_contrainte = 7;

        public virtual ITBfrData NewDId_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainte, true, false, true, true, this);

     
        public long Id_contrainte => DId_contrainte.Content; 
        public TBfrData<long> DId_contrainte => (TBfrData<long>)AssociatedChild(C_Id_contrainte); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_Realisation";
        case 0: return "Id";
        case 1: return "Debut";
        case 2: return "Id_employe";
        case 3: return "Duree";
        case 4: return "Logicaldeleted";
        case 5: return "Id_espaceclient";
        case 6: return "Id_contrainterealisee";
        case 7: return "Id_contrainte";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Realisation.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_Realisation.Id;
                case C_Debut: return RDBPL_V_DB0_Realisation.Debut;
                case C_Id_employe: return RDBPL_V_DB0_Realisation.Id_employe;
                case C_Duree: return RDBPL_V_DB0_Realisation.Duree;
                case C_Id_espaceclient: return RDBPL_V_DB0_Realisation.Id_espaceclient;
                case C_Id_contrainterealisee: return RDBPL_V_DB0_Realisation.Id_contrainterealisee;
                case C_Id_contrainte: return RDBPL_V_DB0_Realisation.Id_contrainte;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_Realisation ToStruct() => new DSDBPL_V_DB0_Realisation 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Debut = DDebut == null || DDebut.IsNull ? null : Debut.ToString(),
            Id_employe = DId_employe == null || DId_employe.IsNull ? null : Id_employe.ToString(),
            Duree = DDuree == null || DDuree.IsNull ? null : Duree.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_contrainterealisee = DId_contrainterealisee == null || DId_contrainterealisee.IsNull ? null : Id_contrainterealisee.ToString(),
            Id_contrainte = DId_contrainte == null || DId_contrainte.IsNull ? null : Id_contrainte.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_Realisation_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_Realisation_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Realisation_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Realisation.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_Realisation_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_Realisation> ToStruct() => this.Select(x => ((DDBPL_V_DB0_Realisation)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_Realisation(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_Realisation : DDBPL_V_DB0_Realisation_generated
    {
          public DDBPL_V_DB0_Realisation(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_Realisation_List : DDBPL_V_DB0_Realisation_List_generated
    {
          public DDBPL_V_DB0_Realisation_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_Realisation
    {
            public string Id;
            public string Debut;
            public string Id_employe;
            public string Duree;
            public string Logicaldeleted;
            public string Id_espaceclient;
            public string Id_contrainterealisee;
            public string Id_contrainte;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, true, false, this);
     
        public override ITBfrData NewDId_employe(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_employe, false, false, true, true, this);
     
        public override ITBfrData NewDDuree(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Duree, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_contrainterealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainterealisee, false, false, true, true, this);
     
        public override ITBfrData NewDId_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainte, false, false, true, true, this);
     

  */

