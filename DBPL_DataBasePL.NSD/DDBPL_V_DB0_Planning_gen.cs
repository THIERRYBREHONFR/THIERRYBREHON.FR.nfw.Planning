// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_Planning_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_Planning_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Planning(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 7;
        public const int C_AdditionalColumnsCount = 7 - 7;

        public override int UpdateColumnsCount => C_UpdateColumnsCount;
        public override int AdditionalColumnsCount => C_AdditionalColumnsCount;

        #region Initialization

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type)
        {
            switch (associatedIndex)
            {
                case C_Id: return NewDId(tBfrData_Type);
                case C_Logicaldeleted: return NewDLogicaldeleted(tBfrData_Type);
                case C_Libelle: return NewDLibelle(tBfrData_Type);
                case C_Abreviation: return NewDAbreviation(tBfrData_Type);
                case C_Debut: return NewDDebut(tBfrData_Type);
                case C_Fin: return NewDFin(tBfrData_Type);
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

        #region 2 Libelle string

        public const int C_Libelle = 2;

        public virtual ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public string Libelle => DLibelle.Content; 
        public TBfrData<string> DLibelle => (TBfrData<string>)AssociatedChild(C_Libelle); 

     
        #endregion

        #region 3 Abreviation string

        public const int C_Abreviation = 3;

        public virtual ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 8, C_Abreviation, true, false, true, this);
     
        public string Abreviation => DAbreviation.Content; 
        public TBfrData<string> DAbreviation => (TBfrData<string>)AssociatedChild(C_Abreviation); 

     
        #endregion

        #region 4 Debut DateTime

        public const int C_Debut = 4;

        public virtual ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, true, false, this);

     
        public DateTime Debut => DDebut.Content; 
        public TBfrData<DateTime> DDebut => (TBfrData<DateTime>)AssociatedChild(C_Debut); 

     
        #endregion

        #region 5 Fin DateTime

        public const int C_Fin = 5;

        public virtual ITBfrData NewDFin(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Fin, false, false, true, false, this);

     
        public DateTime Fin => DFin.Content; 
        public TBfrData<DateTime> DFin => (TBfrData<DateTime>)AssociatedChild(C_Fin); 

     
        #endregion

        #region 6 Id_espaceclient long

        public const int C_Id_espaceclient = 6;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_Planning";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Libelle";
        case 3: return "Abreviation";
        case 4: return "Debut";
        case 5: return "Fin";
        case 6: return "Id_espaceclient";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Planning.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_Planning.Id;
                case C_Libelle: return RDBPL_V_DB0_Planning.Libelle;
                case C_Abreviation: return RDBPL_V_DB0_Planning.Abreviation;
                case C_Debut: return RDBPL_V_DB0_Planning.Debut;
                case C_Fin: return RDBPL_V_DB0_Planning.Fin;
                case C_Id_espaceclient: return RDBPL_V_DB0_Planning.Id_espaceclient;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_Planning ToStruct() => new DSDBPL_V_DB0_Planning 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),
            Abreviation = DAbreviation == null || DAbreviation.IsNull ? null : Abreviation.ToString(),
            Debut = DDebut == null || DDebut.IsNull ? null : Debut.ToString(),
            Fin = DFin == null || DFin.IsNull ? null : Fin.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_Planning_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_Planning_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Planning_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Planning.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_Planning_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_Planning> ToStruct() => this.Select(x => ((DDBPL_V_DB0_Planning)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_Planning(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_Planning : DDBPL_V_DB0_Planning_generated
    {
          public DDBPL_V_DB0_Planning(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_Planning_List : DDBPL_V_DB0_Planning_List_generated
    {
          public DDBPL_V_DB0_Planning_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_Planning
    {
            public string Id;
            public string Logicaldeleted;
            public string Libelle;
            public string Abreviation;
            public string Debut;
            public string Fin;
            public string Id_espaceclient;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public override ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 8, C_Abreviation, true, false, true, this);
     
        public override ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, true, false, this);
     
        public override ITBfrData NewDFin(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Fin, false, false, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     

  */

