// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 15:53:24
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_Categorie_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_Categorie_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Categorie(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 7;
        public const int C_AdditionalColumnsCount = 12 - 7;

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
                case C_Id_typecategorie: return NewDId_typecategorie(tBfrData_Type);
                case C_Id_mere: return NewDId_mere(tBfrData_Type);
                case C_Libelle: return NewDLibelle(tBfrData_Type);
                case C_Ordreaff: return NewDOrdreaff(tBfrData_Type);
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Lib_typecategorie: return NewDLib_typecategorie(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);
                case C_Lib_mere: return NewDLib_mere(tBfrData_Type);

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

        #region 3 Id_typecategorie long

        public const int C_Id_typecategorie = 3;

        public virtual ITBfrData NewDId_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecategorie, true, false, true, true, this);

     
        public long Id_typecategorie => DId_typecategorie.Content; 
        public TBfrData<long> DId_typecategorie => (TBfrData<long>)AssociatedChild(C_Id_typecategorie); 

     
        #endregion

        #region 4 Id_mere long

        public const int C_Id_mere = 4;

        public virtual ITBfrData NewDId_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_mere, true, false, true, true, this);

     
        public long Id_mere => DId_mere.Content; 
        public TBfrData<long> DId_mere => (TBfrData<long>)AssociatedChild(C_Id_mere); 

     
        #endregion

        #region 5 Libelle string

        public const int C_Libelle = 5;

        public virtual ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public string Libelle => DLibelle.Content; 
        public TBfrData<string> DLibelle => (TBfrData<string>)AssociatedChild(C_Libelle); 

     
        #endregion

        #region 6 Ordreaff int

        public const int C_Ordreaff = 6;

        public virtual ITBfrData NewDOrdreaff(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ordreaff, false, false, true, false, this);

     
        public int Ordreaff => DOrdreaff.Content; 
        public TBfrData<int> DOrdreaff => (TBfrData<int>)AssociatedChild(C_Ordreaff); 

     
        #endregion

        #region 7 Id_planning long

        public const int C_Id_planning = 7;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, false, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 8 Lib_typecategorie string

        public const int C_Lib_typecategorie = 8;

        public virtual ITBfrData NewDLib_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecategorie, true, false, false, false, this);

     
        public string Lib_typecategorie => DLib_typecategorie.Content; 
        public TBfrData<string> DLib_typecategorie => (TBfrData<string>)AssociatedChild(C_Lib_typecategorie); 

     
        #endregion

        #region 9 Lib_planning string

        public const int C_Lib_planning = 9;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion

        #region 10 Abr_planning string

        public const int C_Abr_planning = 10;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion

        #region 11 Lib_mere string

        public const int C_Lib_mere = 11;

        public virtual ITBfrData NewDLib_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_mere, true, false, false, false, this);

     
        public string Lib_mere => DLib_mere.Content; 
        public TBfrData<string> DLib_mere => (TBfrData<string>)AssociatedChild(C_Lib_mere); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_Categorie";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_espaceclient";
        case 3: return "Id_typecategorie";
        case 4: return "Id_mere";
        case 5: return "Libelle";
        case 6: return "Ordreaff";
        case 7: return "Id_planning";
        case 8: return "Lib_typecategorie";
        case 9: return "Lib_planning";
        case 10: return "Abr_planning";
        case 11: return "Lib_mere";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_Categorie.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_Categorie.Id;
                case C_Id_espaceclient: return RPL_V_PL0_Categorie.Id_espaceclient;
                case C_Id_typecategorie: return RPL_V_PL0_Categorie.Id_typecategorie;
                case C_Id_mere: return RPL_V_PL0_Categorie.Id_mere;
                case C_Libelle: return RPL_V_PL0_Categorie.Libelle;
                case C_Ordreaff: return RPL_V_PL0_Categorie.Ordreaff;
                case C_Id_planning: return RPL_V_PL0_Categorie.Id_planning;
                case C_Lib_typecategorie: return RPL_V_PL0_Categorie.Lib_typecategorie;
                case C_Lib_planning: return RPL_V_PL0_Categorie.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_Categorie.Abr_planning;
                case C_Lib_mere: return RPL_V_PL0_Categorie.Lib_mere;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_Categorie ToStruct() => new DSPL_V_PL0_Categorie 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_typecategorie = DId_typecategorie == null || DId_typecategorie.IsNull ? null : Id_typecategorie.ToString(),
            Id_mere = DId_mere == null || DId_mere.IsNull ? null : Id_mere.ToString(),
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),
            Ordreaff = DOrdreaff == null || DOrdreaff.IsNull ? null : Ordreaff.ToString(),

          };
    }
    
    public class DPL_V_PL0_Categorie_List_generated : TBfrData_List
    {

        public DPL_V_PL0_Categorie_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Categorie_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_Categorie.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Categorie_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Categorie> ToStruct() => this.Select(x => ((DPL_V_PL0_Categorie)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Categorie(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_Categorie : DPL_V_PL0_Categorie_generated
    {
          public DPL_V_PL0_Categorie(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_Categorie_List : DPL_V_PL0_Categorie_List_generated
    {
          public DPL_V_PL0_Categorie_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Categorie
    {
            public string Id;
            public string Logicaldeleted;
            public string Id_espaceclient;
            public string Id_typecategorie;
            public string Id_mere;
            public string Libelle;
            public string Ordreaff;

    }
      
    
    public class DPL_V_PL0_Categorie_Choice_generated : DPL_V_PL0_Categorie
    {
        public DPL_V_PL0_Categorie_Choice_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type,withChildren) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Categorie_Choice(tBfrData_Type, withChildren);

        public override TBfrData_List AddChildren(TBfrData_Type tBfrData_Type)
        {
            NewDLibelle(tBfrData_Type);

            return this;
        }

        public override string AbsoluteXmlName(int index) => index==-1 ? "PL_V_PL0_Categorie_Choice" : base.AbsoluteXmlName(index);

        public DSPL_V_PL0_Categorie_Choice ToStructChoice() => new DSPL_V_PL0_Categorie_Choice
        {
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),

        };
   }

    public class DPL_V_PL0_Categorie_ChoiceList_generated : TBfrData_List
    {
        public DPL_V_PL0_Categorie_ChoiceList_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren = true) => new DPL_V_PL0_Categorie_ChoiceList(tBfrData_Type, withChildren);

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Categorie_Choice" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Categorie_Choice> ToStruct() => this.Select(x => ((DPL_V_PL0_Categorie_Choice)x).ToStructChoice()).ToList();
     
        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Categorie_Choice(tBfrData_Type, true);
   }


    public partial class DPL_V_PL0_Categorie_Choice : DPL_V_PL0_Categorie_Choice_generated
    {
          public DPL_V_PL0_Categorie_Choice(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public partial class DPL_V_PL0_Categorie_ChoiceList : DPL_V_PL0_Categorie_ChoiceList_generated
    {
          public DPL_V_PL0_Categorie_ChoiceList(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Categorie_Choice
    {
            public string Libelle;

    }

      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecategorie, false, false, true, true, this);
     
        public override ITBfrData NewDId_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_mere, false, false, true, true, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public override ITBfrData NewDOrdreaff(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ordreaff, false, false, true, false, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, false, true, this);
     
        public override ITBfrData NewDLib_typecategorie(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecategorie, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDLib_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_mere, true, false, false, false, this);
     

  */

