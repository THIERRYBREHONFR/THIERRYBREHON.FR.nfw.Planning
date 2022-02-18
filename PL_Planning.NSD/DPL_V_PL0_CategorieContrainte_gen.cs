// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:02
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_CategorieContrainte_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_CategorieContrainte_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_CategorieContrainte(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 5;
        public const int C_AdditionalColumnsCount = 17 - 5;

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
                case C_Lib_categorie: return NewDLib_categorie(tBfrData_Type);
                case C_Lib_typecategorie: return NewDLib_typecategorie(tBfrData_Type);
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);
                case C_Ref_contrainte: return NewDRef_contrainte(tBfrData_Type);
                case C_Lib_contrainte: return NewDLib_contrainte(tBfrData_Type);
                case C_Comm_contrainte: return NewDComm_contrainte(tBfrData_Type);
                case C_Id_typecontrainte: return NewDId_typecontrainte(tBfrData_Type);
                case C_Abr_contrainte: return NewDAbr_contrainte(tBfrData_Type);
                case C_Contrainterealisee: return NewDContrainterealisee(tBfrData_Type);
                case C_Lib_typecontrainte: return NewDLib_typecontrainte(tBfrData_Type);

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

        #region 5 Lib_categorie string

        public const int C_Lib_categorie = 5;

        public virtual ITBfrData NewDLib_categorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_categorie, true, false, false, false, this);

     
        public string Lib_categorie => DLib_categorie.Content; 
        public TBfrData<string> DLib_categorie => (TBfrData<string>)AssociatedChild(C_Lib_categorie); 

     
        #endregion

        #region 6 Lib_typecategorie string

        public const int C_Lib_typecategorie = 6;

        public virtual ITBfrData NewDLib_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecategorie, true, false, false, false, this);

     
        public string Lib_typecategorie => DLib_typecategorie.Content; 
        public TBfrData<string> DLib_typecategorie => (TBfrData<string>)AssociatedChild(C_Lib_typecategorie); 

     
        #endregion

        #region 7 Id_planning long

        public const int C_Id_planning = 7;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, false, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 8 Lib_planning string

        public const int C_Lib_planning = 8;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion

        #region 9 Abr_planning string

        public const int C_Abr_planning = 9;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion

        #region 10 Ref_contrainte int

        public const int C_Ref_contrainte = 10;

        public virtual ITBfrData NewDRef_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref_contrainte, false, false, false, false, this);

     
        public int Ref_contrainte => DRef_contrainte.Content; 
        public TBfrData<int> DRef_contrainte => (TBfrData<int>)AssociatedChild(C_Ref_contrainte); 

     
        #endregion

        #region 11 Lib_contrainte string

        public const int C_Lib_contrainte = 11;

        public virtual ITBfrData NewDLib_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_contrainte, true, false, false, false, this);

     
        public string Lib_contrainte => DLib_contrainte.Content; 
        public TBfrData<string> DLib_contrainte => (TBfrData<string>)AssociatedChild(C_Lib_contrainte); 

     
        #endregion

        #region 12 Comm_contrainte string

        public const int C_Comm_contrainte = 12;

        public virtual ITBfrData NewDComm_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Comm_contrainte, true, false, false, false, this);

     
        public string Comm_contrainte => DComm_contrainte.Content; 
        public TBfrData<string> DComm_contrainte => (TBfrData<string>)AssociatedChild(C_Comm_contrainte); 

     
        #endregion

        #region 13 Id_typecontrainte long

        public const int C_Id_typecontrainte = 13;

        public virtual ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, true, false, false, true, this);

     
        public long Id_typecontrainte => DId_typecontrainte.Content; 
        public TBfrData<long> DId_typecontrainte => (TBfrData<long>)AssociatedChild(C_Id_typecontrainte); 

     
        #endregion

        #region 14 Abr_contrainte string

        public const int C_Abr_contrainte = 14;

        public virtual ITBfrData NewDAbr_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_contrainte, true, false, false, false, this);

     
        public string Abr_contrainte => DAbr_contrainte.Content; 
        public TBfrData<string> DAbr_contrainte => (TBfrData<string>)AssociatedChild(C_Abr_contrainte); 

     
        #endregion

        #region 15 Contrainterealisee bool

        public const int C_Contrainterealisee = 15;

        public virtual ITBfrData NewDContrainterealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Contrainterealisee, false, true, false, false, this);

     
        public bool Contrainterealisee => DContrainterealisee.Content; 
        public TBfrData<bool> DContrainterealisee => (TBfrData<bool>)AssociatedChild(C_Contrainterealisee); 

     
        #endregion

        #region 16 Lib_typecontrainte string

        public const int C_Lib_typecontrainte = 16;

        public virtual ITBfrData NewDLib_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecontrainte, true, false, false, false, this);

     
        public string Lib_typecontrainte => DLib_typecontrainte.Content; 
        public TBfrData<string> DLib_typecontrainte => (TBfrData<string>)AssociatedChild(C_Lib_typecontrainte); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_CategorieContrainte";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_espaceclient";
        case 3: return "Id_categorie";
        case 4: return "Id_contrainte";
        case 5: return "Lib_categorie";
        case 6: return "Lib_typecategorie";
        case 7: return "Id_planning";
        case 8: return "Lib_planning";
        case 9: return "Abr_planning";
        case 10: return "Ref_contrainte";
        case 11: return "Lib_contrainte";
        case 12: return "Comm_contrainte";
        case 13: return "Id_typecontrainte";
        case 14: return "Abr_contrainte";
        case 15: return "Contrainterealisee";
        case 16: return "Lib_typecontrainte";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_CategorieContrainte.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_CategorieContrainte.Id;
                case C_Id_espaceclient: return RPL_V_PL0_CategorieContrainte.Id_espaceclient;
                case C_Id_categorie: return RPL_V_PL0_CategorieContrainte.Id_categorie;
                case C_Id_contrainte: return RPL_V_PL0_CategorieContrainte.Id_contrainte;
                case C_Lib_categorie: return RPL_V_PL0_CategorieContrainte.Lib_categorie;
                case C_Lib_typecategorie: return RPL_V_PL0_CategorieContrainte.Lib_typecategorie;
                case C_Id_planning: return RPL_V_PL0_CategorieContrainte.Id_planning;
                case C_Lib_planning: return RPL_V_PL0_CategorieContrainte.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_CategorieContrainte.Abr_planning;
                case C_Ref_contrainte: return RPL_V_PL0_CategorieContrainte.Ref_contrainte;
                case C_Lib_contrainte: return RPL_V_PL0_CategorieContrainte.Lib_contrainte;
                case C_Comm_contrainte: return RPL_V_PL0_CategorieContrainte.Comm_contrainte;
                case C_Id_typecontrainte: return RPL_V_PL0_CategorieContrainte.Id_typecontrainte;
                case C_Abr_contrainte: return RPL_V_PL0_CategorieContrainte.Abr_contrainte;
                case C_Contrainterealisee: return RPL_V_PL0_CategorieContrainte.Contrainterealisee;
                case C_Lib_typecontrainte: return RPL_V_PL0_CategorieContrainte.Lib_typecontrainte;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_CategorieContrainte ToStruct() => new DSPL_V_PL0_CategorieContrainte 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_categorie = DId_categorie == null || DId_categorie.IsNull ? null : Id_categorie.ToString(),
            Id_contrainte = DId_contrainte == null || DId_contrainte.IsNull ? null : Id_contrainte.ToString(),

          };
    }
    
    public class DPL_V_PL0_CategorieContrainte_List_generated : TBfrData_List
    {

        public DPL_V_PL0_CategorieContrainte_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_CategorieContrainte_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_CategorieContrainte.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_CategorieContrainte_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_CategorieContrainte> ToStruct() => this.Select(x => ((DPL_V_PL0_CategorieContrainte)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_CategorieContrainte(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_CategorieContrainte : DPL_V_PL0_CategorieContrainte_generated
    {
          public DPL_V_PL0_CategorieContrainte(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_CategorieContrainte_List : DPL_V_PL0_CategorieContrainte_List_generated
    {
          public DPL_V_PL0_CategorieContrainte_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_CategorieContrainte
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
     
        public override ITBfrData NewDLib_categorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_categorie, true, false, false, false, this);
     
        public override ITBfrData NewDLib_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecategorie, true, false, false, false, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, false, true, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDRef_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref_contrainte, false, false, false, false, this);
     
        public override ITBfrData NewDLib_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_contrainte, true, false, false, false, this);
     
        public override ITBfrData NewDComm_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Comm_contrainte, true, false, false, false, this);
     
        public override ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, false, false, false, true, this);
     
        public override ITBfrData NewDAbr_contrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_contrainte, true, false, false, false, this);
     
        public override ITBfrData NewDContrainterealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Contrainterealisee, false, true, false, false, this);
     
        public override ITBfrData NewDLib_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecontrainte, true, false, false, false, this);
     

  */

