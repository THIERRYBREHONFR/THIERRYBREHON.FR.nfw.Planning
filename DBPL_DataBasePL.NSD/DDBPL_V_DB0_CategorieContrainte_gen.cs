// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_CategorieContrainte_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_CategorieContrainte_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_CategorieContrainte(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 5;
        public const int C_AdditionalColumnsCount = 5 - 5;

        public override int UpdateColumnsCount => C_UpdateColumnsCount;
        public override int AdditionalColumnsCount => C_AdditionalColumnsCount;

        #region Initialization

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type)
        {
            switch (associatedIndex)
            {
                case C_Id: return NewDId(tBfrData_Type);
                case C_Logicaldeleted: return NewDLogicaldeleted(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Id_categorie: return NewDId_categorie(tBfrData_Type);
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

        #region 1 Logicaldeleted bool

        public const int C_Logicaldeleted = 1;

        public virtual ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);

     
        public bool Logicaldeleted => DLogicaldeleted.Content; 
        public TBfrData<bool> DLogicaldeleted => (TBfrData<bool>)AssociatedChild(C_Logicaldeleted); 

     
        #endregion

        #region 2 Id_espaceclient long

        public const int C_Id_espaceclient = 2;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 3 Id_categorie long

        public const int C_Id_categorie = 3;

        public virtual ITBfrData NewDId_categorie(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_categorie, true, false, true, true, this);

     
        public long Id_categorie => DId_categorie.Content; 
        public TBfrData<long> DId_categorie => (TBfrData<long>)AssociatedChild(C_Id_categorie); 

     
        #endregion

        #region 4 Id_contrainte long

        public const int C_Id_contrainte = 4;

        public virtual ITBfrData NewDId_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainte, true, false, true, true, this);

     
        public long Id_contrainte => DId_contrainte.Content; 
        public TBfrData<long> DId_contrainte => (TBfrData<long>)AssociatedChild(C_Id_contrainte); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_CategorieContrainte";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_espaceclient";
        case 3: return "Id_categorie";
        case 4: return "Id_contrainte";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_CategorieContrainte.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_CategorieContrainte.Id;
                case C_Id_espaceclient: return RDBPL_V_DB0_CategorieContrainte.Id_espaceclient;
                case C_Id_categorie: return RDBPL_V_DB0_CategorieContrainte.Id_categorie;
                case C_Id_contrainte: return RDBPL_V_DB0_CategorieContrainte.Id_contrainte;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_CategorieContrainte ToStruct() => new DSDBPL_V_DB0_CategorieContrainte 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_categorie = DId_categorie == null || DId_categorie.IsNull ? null : Id_categorie.ToString(),
            Id_contrainte = DId_contrainte == null || DId_contrainte.IsNull ? null : Id_contrainte.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_CategorieContrainte_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_CategorieContrainte_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_CategorieContrainte_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_CategorieContrainte.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_CategorieContrainte_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_CategorieContrainte> ToStruct() => this.Select(x => ((DDBPL_V_DB0_CategorieContrainte)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_CategorieContrainte(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_CategorieContrainte : DDBPL_V_DB0_CategorieContrainte_generated
    {
          public DDBPL_V_DB0_CategorieContrainte(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_CategorieContrainte_List : DDBPL_V_DB0_CategorieContrainte_List_generated
    {
          public DDBPL_V_DB0_CategorieContrainte_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_CategorieContrainte
    {
            public string Id;
            public string Logicaldeleted;
            public string Id_espaceclient;
            public string Id_categorie;
            public string Id_contrainte;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_categorie(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_categorie, false, false, true, true, this);
     
        public override ITBfrData NewDId_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_contrainte, false, false, true, true, this);
     

  */

