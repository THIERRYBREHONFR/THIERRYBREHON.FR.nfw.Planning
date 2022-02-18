// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:24:11
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_TypeCategorie_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_TypeCategorie_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeCategorie(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 6;
        public const int C_AdditionalColumnsCount = 9 - 6;

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
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Id_mere: return NewDId_mere(tBfrData_Type);
                case C_Libelle: return NewDLibelle(tBfrData_Type);
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

        #region 3 Id_planning long

        public const int C_Id_planning = 3;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, true, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
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

        #region 6 Lib_planning string

        public const int C_Lib_planning = 6;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion

        #region 7 Abr_planning string

        public const int C_Abr_planning = 7;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion

        #region 8 Lib_mere string

        public const int C_Lib_mere = 8;

        public virtual ITBfrData NewDLib_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_mere, true, false, false, false, this);

     
        public string Lib_mere => DLib_mere.Content; 
        public TBfrData<string> DLib_mere => (TBfrData<string>)AssociatedChild(C_Lib_mere); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_TypeCategorie";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_espaceclient";
        case 3: return "Id_planning";
        case 4: return "Id_mere";
        case 5: return "Libelle";
        case 6: return "Lib_planning";
        case 7: return "Abr_planning";
        case 8: return "Lib_mere";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_TypeCategorie.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_TypeCategorie.Id;
                case C_Id_espaceclient: return RPL_V_PL0_TypeCategorie.Id_espaceclient;
                case C_Id_planning: return RPL_V_PL0_TypeCategorie.Id_planning;
                case C_Id_mere: return RPL_V_PL0_TypeCategorie.Id_mere;
                case C_Libelle: return RPL_V_PL0_TypeCategorie.Libelle;
                case C_Lib_planning: return RPL_V_PL0_TypeCategorie.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_TypeCategorie.Abr_planning;
                case C_Lib_mere: return RPL_V_PL0_TypeCategorie.Lib_mere;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_TypeCategorie ToStruct() => new DSPL_V_PL0_TypeCategorie 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_planning = DId_planning == null || DId_planning.IsNull ? null : Id_planning.ToString(),
            Id_mere = DId_mere == null || DId_mere.IsNull ? null : Id_mere.ToString(),
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),

          };
    }
    
    public class DPL_V_PL0_TypeCategorie_List_generated : TBfrData_List
    {

        public DPL_V_PL0_TypeCategorie_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeCategorie_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_TypeCategorie.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_TypeCategorie_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_TypeCategorie> ToStruct() => this.Select(x => ((DPL_V_PL0_TypeCategorie)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_TypeCategorie(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_TypeCategorie : DPL_V_PL0_TypeCategorie_generated
    {
          public DPL_V_PL0_TypeCategorie(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_TypeCategorie_List : DPL_V_PL0_TypeCategorie_List_generated
    {
          public DPL_V_PL0_TypeCategorie_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_TypeCategorie
    {
            public string Id;
            public string Logicaldeleted;
            public string Id_espaceclient;
            public string Id_planning;
            public string Id_mere;
            public string Libelle;

    }
      
    
    public class DPL_V_PL0_TypeCategorie_Choice_generated : DPL_V_PL0_TypeCategorie
    {
        public DPL_V_PL0_TypeCategorie_Choice_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type,withChildren) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeCategorie_Choice(tBfrData_Type, withChildren);

        public override TBfrData_List AddChildren(TBfrData_Type tBfrData_Type)
        {
            NewDLibelle(tBfrData_Type);

            return this;
        }

        public override string AbsoluteXmlName(int index) => index==-1 ? "PL_V_PL0_TypeCategorie_Choice" : base.AbsoluteXmlName(index);

        public DSPL_V_PL0_TypeCategorie_Choice ToStructChoice() => new DSPL_V_PL0_TypeCategorie_Choice
        {
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),

        };
   }

    public class DPL_V_PL0_TypeCategorie_ChoiceList_generated : TBfrData_List
    {
        public DPL_V_PL0_TypeCategorie_ChoiceList_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren = true) => new DPL_V_PL0_TypeCategorie_ChoiceList(tBfrData_Type, withChildren);

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_TypeCategorie_Choice" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_TypeCategorie_Choice> ToStruct() => this.Select(x => ((DPL_V_PL0_TypeCategorie_Choice)x).ToStructChoice()).ToList();
     
        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_TypeCategorie_Choice(tBfrData_Type, true);
   }


    public partial class DPL_V_PL0_TypeCategorie_Choice : DPL_V_PL0_TypeCategorie_Choice_generated
    {
          public DPL_V_PL0_TypeCategorie_Choice(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public partial class DPL_V_PL0_TypeCategorie_ChoiceList : DPL_V_PL0_TypeCategorie_ChoiceList_generated
    {
          public DPL_V_PL0_TypeCategorie_ChoiceList(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_TypeCategorie_Choice
    {
            public string Libelle;

    }

      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, true, true, this);
     
        public override ITBfrData NewDId_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_mere, false, false, true, true, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDLib_mere(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_mere, true, false, false, false, this);
     

  */

