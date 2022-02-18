// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:17
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_Employe_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_Employe_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 9;
        public const int C_AdditionalColumnsCount = 12 - 9;

        public override int UpdateColumnsCount => C_UpdateColumnsCount;
        public override int AdditionalColumnsCount => C_AdditionalColumnsCount;

        #region Initialization

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type)
        {
            switch (associatedIndex)
            {
                case C_Id: return NewDId(tBfrData_Type);
                case C_Logicaldeleted: return NewDLogicaldeleted(tBfrData_Type);
                case C_Initiales: return NewDInitiales(tBfrData_Type);
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Nom: return NewDNom(tBfrData_Type);
                case C_Prenom: return NewDPrenom(tBfrData_Type);
                case C_Feminin: return NewDFeminin(tBfrData_Type);
                case C_Id_utilisateur: return NewDId_utilisateur(tBfrData_Type);
                case C_Identite: return NewDIdentite(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);

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

        #region 2 Initiales string

        public const int C_Initiales = 2;

        public virtual ITBfrData NewDInitiales(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 5, C_Initiales, true, false, true, this);
     
        public string Initiales => DInitiales.Content; 
        public TBfrData<string> DInitiales => (TBfrData<string>)AssociatedChild(C_Initiales); 

     
        #endregion

        #region 3 Id_planning long

        public const int C_Id_planning = 3;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, true, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 4 Id_espaceclient long

        public const int C_Id_espaceclient = 4;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 5 Nom string

        public const int C_Nom = 5;

        public virtual ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 50, C_Nom, true, false, true, this);
     
        public string Nom => DNom.Content; 
        public TBfrData<string> DNom => (TBfrData<string>)AssociatedChild(C_Nom); 

     
        #endregion

        #region 6 Prenom string

        public const int C_Prenom = 6;

        public virtual ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 50, C_Prenom, true, false, false, this);
     
        public string Prenom => DPrenom.Content; 
        public TBfrData<string> DPrenom => (TBfrData<string>)AssociatedChild(C_Prenom); 

     
        #endregion

        #region 7 Feminin bool

        public const int C_Feminin = 7;

        public virtual ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, true, false, this);

     
        public bool Feminin => DFeminin.Content; 
        public TBfrData<bool> DFeminin => (TBfrData<bool>)AssociatedChild(C_Feminin); 

     
        #endregion

        #region 8 Id_utilisateur long

        public const int C_Id_utilisateur = 8;

        public virtual ITBfrData NewDId_utilisateur(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_utilisateur, true, false, true, true, this);

     
        public long Id_utilisateur => DId_utilisateur.Content; 
        public TBfrData<long> DId_utilisateur => (TBfrData<long>)AssociatedChild(C_Id_utilisateur); 

     
        #endregion

        #region 9 Identite string

        public const int C_Identite = 9;

        public virtual ITBfrData NewDIdentite(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Identite, true, false, false, false, this);

     
        public string Identite => DIdentite.Content; 
        public TBfrData<string> DIdentite => (TBfrData<string>)AssociatedChild(C_Identite); 

     
        #endregion

        #region 10 Lib_planning string

        public const int C_Lib_planning = 10;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion

        #region 11 Abr_planning string

        public const int C_Abr_planning = 11;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_Employe";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Initiales";
        case 3: return "Id_planning";
        case 4: return "Id_espaceclient";
        case 5: return "Nom";
        case 6: return "Prenom";
        case 7: return "Feminin";
        case 8: return "Id_utilisateur";
        case 9: return "Identite";
        case 10: return "Lib_planning";
        case 11: return "Abr_planning";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_Employe.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_Employe.Id;
                case C_Initiales: return RPL_V_PL0_Employe.Initiales;
                case C_Id_planning: return RPL_V_PL0_Employe.Id_planning;
                case C_Id_espaceclient: return RPL_V_PL0_Employe.Id_espaceclient;
                case C_Nom: return RPL_V_PL0_Employe.Nom;
                case C_Prenom: return RPL_V_PL0_Employe.Prenom;
                case C_Feminin: return RPL_V_PL0_Employe.Feminin;
                case C_Id_utilisateur: return RPL_V_PL0_Employe.Id_utilisateur;
                case C_Identite: return RPL_V_PL0_Employe.Identite;
                case C_Lib_planning: return RPL_V_PL0_Employe.Lib_planning;
                case C_Abr_planning: return RPL_V_PL0_Employe.Abr_planning;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_Employe ToStruct() => new DSPL_V_PL0_Employe 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Initiales = DInitiales == null || DInitiales.IsNull ? null : Initiales.ToString(),
            Id_planning = DId_planning == null || DId_planning.IsNull ? null : Id_planning.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Nom = DNom == null || DNom.IsNull ? null : Nom.ToString(),
            Prenom = DPrenom == null || DPrenom.IsNull ? null : Prenom.ToString(),
            Feminin = DFeminin == null || DFeminin.IsNull ? null : Feminin.ToString(),
            Id_utilisateur = DId_utilisateur == null || DId_utilisateur.IsNull ? null : Id_utilisateur.ToString(),

          };
    }
    
    public class DPL_V_PL0_Employe_List_generated : TBfrData_List
    {

        public DPL_V_PL0_Employe_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_Employe.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Employe_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Employe> ToStruct() => this.Select(x => ((DPL_V_PL0_Employe)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Employe(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_Employe : DPL_V_PL0_Employe_generated
    {
          public DPL_V_PL0_Employe(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_Employe_List : DPL_V_PL0_Employe_List_generated
    {
          public DPL_V_PL0_Employe_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Employe
    {
            public string Id;
            public string Logicaldeleted;
            public string Initiales;
            public string Id_planning;
            public string Id_espaceclient;
            public string Nom;
            public string Prenom;
            public string Feminin;
            public string Id_utilisateur;

    }
      
    
    public class DPL_V_PL0_Employe_Choice_generated : DPL_V_PL0_Employe
    {
        public DPL_V_PL0_Employe_Choice_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type,withChildren) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe_Choice(tBfrData_Type, withChildren);

        public override TBfrData_List AddChildren(TBfrData_Type tBfrData_Type)
        {
            NewDIdentite(tBfrData_Type);

            return this;
        }

        public override string AbsoluteXmlName(int index) => index==-1 ? "PL_V_PL0_Employe_Choice" : base.AbsoluteXmlName(index);

        public DSPL_V_PL0_Employe_Choice ToStructChoice() => new DSPL_V_PL0_Employe_Choice
        {
            Identite = DIdentite == null || DIdentite.IsNull ? null : Identite.ToString(),

        };
   }

    public class DPL_V_PL0_Employe_ChoiceList_generated : TBfrData_List
    {
        public DPL_V_PL0_Employe_ChoiceList_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren = true) => new DPL_V_PL0_Employe_ChoiceList(tBfrData_Type, withChildren);

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Employe_Choice" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Employe_Choice> ToStruct() => this.Select(x => ((DPL_V_PL0_Employe_Choice)x).ToStructChoice()).ToList();
     
        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Employe_Choice(tBfrData_Type, true);
   }


    public partial class DPL_V_PL0_Employe_Choice : DPL_V_PL0_Employe_Choice_generated
    {
          public DPL_V_PL0_Employe_Choice(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public partial class DPL_V_PL0_Employe_ChoiceList : DPL_V_PL0_Employe_ChoiceList_generated
    {
          public DPL_V_PL0_Employe_ChoiceList(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Employe_Choice
    {
            public string Identite;

    }

      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDInitiales(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 5, C_Initiales, true, false, true, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, true, true, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 50, C_Nom, true, false, true, this);
     
        public override ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 50, C_Prenom, true, false, false, this);
     
        public override ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, true, false, this);
     
        public override ITBfrData NewDId_utilisateur(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_utilisateur, false, false, true, true, this);
     
        public override ITBfrData NewDIdentite(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Identite, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     

  */

