// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 09:13:55
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_Version_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_Version_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Version(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 7;
        public const int C_AdditionalColumnsCount = 13 - 7;

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
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Abreviation: return NewDAbreviation(tBfrData_Type);
                case C_Figee: return NewDFigee(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Debut: return NewDDebut(tBfrData_Type);
                case C_Fin: return NewDFin(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);
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

        #region 2 Libelle string

        public const int C_Libelle = 2;

        public virtual ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public string Libelle => DLibelle.Content; 
        public TBfrData<string> DLibelle => (TBfrData<string>)AssociatedChild(C_Libelle); 

     
        #endregion

        #region 3 Id_planning long

        public const int C_Id_planning = 3;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, true, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 4 Abreviation string

        public const int C_Abreviation = 4;

        public virtual ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 8, C_Abreviation, true, false, true, this);
     
        public string Abreviation => DAbreviation.Content; 
        public TBfrData<string> DAbreviation => (TBfrData<string>)AssociatedChild(C_Abreviation); 

     
        #endregion

        #region 5 Figee bool

        public const int C_Figee = 5;

        public virtual ITBfrData NewDFigee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Figee, false, true, true, false, this);

     
        public bool Figee => DFigee.Content; 
        public TBfrData<bool> DFigee => (TBfrData<bool>)AssociatedChild(C_Figee); 

     
        #endregion

        #region 6 Id_espaceclient long

        public const int C_Id_espaceclient = 6;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 7 Debut DateTime

        public const int C_Debut = 7;

        public virtual ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, false, false, this);

     
        public DateTime Debut => DDebut.Content; 
        public TBfrData<DateTime> DDebut => (TBfrData<DateTime>)AssociatedChild(C_Debut); 

     
        #endregion

        #region 8 Fin DateTime

        public const int C_Fin = 8;

        public virtual ITBfrData NewDFin(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Fin, false, false, false, false, this);

     
        public DateTime Fin => DFin.Content; 
        public TBfrData<DateTime> DFin => (TBfrData<DateTime>)AssociatedChild(C_Fin); 

     
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

        #region 11 Lib_planning_version string

        public const int C_Lib_planning_version = 11;

        public virtual ITBfrData NewDLib_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_version, true, false, false, false, this);

     
        public string Lib_planning_version => DLib_planning_version.Content; 
        public TBfrData<string> DLib_planning_version => (TBfrData<string>)AssociatedChild(C_Lib_planning_version); 

     
        #endregion

        #region 12 Abr_planning_version string

        public const int C_Abr_planning_version = 12;

        public virtual ITBfrData NewDAbr_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_version, true, false, false, false, this);

     
        public string Abr_planning_version => DAbr_planning_version.Content; 
        public TBfrData<string> DAbr_planning_version => (TBfrData<string>)AssociatedChild(C_Abr_planning_version); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_Version";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Libelle";
        case 3: return "Id_planning";
        case 4: return "Abreviation";
        case 5: return "Figee";
        case 6: return "Id_espaceclient";
        case 7: return "Debut";
        case 8: return "Fin";
        case 9: return "Lib_planning";
        case 10: return "Abr_planning";
        case 11: return "Lib_planning_version";
        case 12: return "Abr_planning_version";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_Version.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_Version.Id;
                case C_Libelle: return RPL_V_PL0_Version.Libelle;
                case C_Id_planning: return RPL_V_PL0_Version.Id_planning;
                case C_Abreviation: return RPL_V_PL0_Version.Abreviation;
                case C_Figee: return RPL_V_PL0_Version.Figee;
                case C_Id_espaceclient: return RPL_V_PL0_Version.Id_espaceclient;
                case C_Debut: return RPL_V_PL0_Version.Debut;
                case C_Fin: return RPL_V_PL0_Version.Fin;
                case C_Lib_planning: return RPL_V_PL0_Version.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_Version.Abr_planning;
                case C_Lib_planning_version: return RPL_V_PL0_Version.Lib_planning_version;
                case C_Abr_planning_version: return RPL_V_PL0_Version.Abr_planning_version;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_Version ToStruct() => new DSPL_V_PL0_Version 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),
            Id_planning = DId_planning == null || DId_planning.IsNull ? null : Id_planning.ToString(),
            Abreviation = DAbreviation == null || DAbreviation.IsNull ? null : Abreviation.ToString(),
            Figee = DFigee == null || DFigee.IsNull ? null : Figee.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),

          };
    }
    
    public class DPL_V_PL0_Version_List_generated : TBfrData_List
    {

        public DPL_V_PL0_Version_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Version_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_Version.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Version_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Version> ToStruct() => this.Select(x => ((DPL_V_PL0_Version)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Version(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_Version : DPL_V_PL0_Version_generated
    {
          public DPL_V_PL0_Version(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_Version_List : DPL_V_PL0_Version_List_generated
    {
          public DPL_V_PL0_Version_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Version
    {
            public string Id;
            public string Logicaldeleted;
            public string Libelle;
            public string Id_planning;
            public string Abreviation;
            public string Figee;
            public string Id_espaceclient;

    }
      
    
    public class DPL_V_PL0_Version_Choice_generated : DPL_V_PL0_Version
    {
        public DPL_V_PL0_Version_Choice_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type,withChildren) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Version_Choice(tBfrData_Type, withChildren);

        public override TBfrData_List AddChildren(TBfrData_Type tBfrData_Type)
        {
            NewDLib_planning_version(tBfrData_Type);

            return this;
        }

        public override string AbsoluteXmlName(int index) => index==-1 ? "PL_V_PL0_Version_Choice" : base.AbsoluteXmlName(index);

        public DSPL_V_PL0_Version_Choice ToStructChoice() => new DSPL_V_PL0_Version_Choice
        {
            Lib_planning_version = DLib_planning_version == null || DLib_planning_version.IsNull ? null : Lib_planning_version.ToString(),

        };
   }

    public class DPL_V_PL0_Version_ChoiceList_generated : TBfrData_List
    {
        public DPL_V_PL0_Version_ChoiceList_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren = true) => new DPL_V_PL0_Version_ChoiceList(tBfrData_Type, withChildren);

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Version_Choice" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Version_Choice> ToStruct() => this.Select(x => ((DPL_V_PL0_Version_Choice)x).ToStructChoice()).ToList();
     
        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Version_Choice(tBfrData_Type, true);
   }


    public partial class DPL_V_PL0_Version_Choice : DPL_V_PL0_Version_Choice_generated
    {
          public DPL_V_PL0_Version_Choice(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public partial class DPL_V_PL0_Version_ChoiceList : DPL_V_PL0_Version_ChoiceList_generated
    {
          public DPL_V_PL0_Version_ChoiceList(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Version_Choice
    {
            public string Lib_planning_version;

    }

      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, true, true, this);
     
        public override ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 8, C_Abreviation, true, false, true, this);
     
        public override ITBfrData NewDFigee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Figee, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDDebut(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Debut, false, false, false, false, this);
     
        public override ITBfrData NewDFin(TBfrData_Type tBfrData_Type) => ((TBfrData_DateTime)TBfrData_DateTime.NewITBfrData(tBfrData_Type)).Initialize(C_Fin, false, false, false, false, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning_version, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning_version(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning_version, true, false, false, false, this);
     

  */

