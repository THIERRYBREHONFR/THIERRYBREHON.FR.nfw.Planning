// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:23:27
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL0_Realisation_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL0_Realisation_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 8;
        public const int C_AdditionalColumnsCount = 18 - 8;

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
                case C_Id_planning: return NewDId_planning(tBfrData_Type);
                case C_Ref: return NewDRef(tBfrData_Type);
                case C_Abreviation: return NewDAbreviation(tBfrData_Type);
                case C_Libelle: return NewDLibelle(tBfrData_Type);
                case C_Commentaire: return NewDCommentaire(tBfrData_Type);
                case C_Id_typecontrainte: return NewDId_typecontrainte(tBfrData_Type);
                case C_Realisee: return NewDRealisee(tBfrData_Type);
                case C_Lib_typecontrainte: return NewDLib_typecontrainte(tBfrData_Type);
                case C_Abr_planning: return NewDAbr_planning(tBfrData_Type);
                case C_Lib_planning: return NewDLib_planning(tBfrData_Type);

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

        #region 8 Id_planning long

        public const int C_Id_planning = 8;

        public virtual ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, true, false, false, true, this);

     
        public long Id_planning => DId_planning.Content; 
        public TBfrData<long> DId_planning => (TBfrData<long>)AssociatedChild(C_Id_planning); 

     
        #endregion

        #region 9 Ref int

        public const int C_Ref = 9;

        public virtual ITBfrData NewDRef(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref, false, false, false, false, this);

     
        public int Ref => DRef.Content; 
        public TBfrData<int> DRef => (TBfrData<int>)AssociatedChild(C_Ref); 

     
        #endregion

        #region 10 Abreviation string

        public const int C_Abreviation = 10;

        public virtual ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abreviation, true, false, false, false, this);

     
        public string Abreviation => DAbreviation.Content; 
        public TBfrData<string> DAbreviation => (TBfrData<string>)AssociatedChild(C_Abreviation); 

     
        #endregion

        #region 11 Libelle string

        public const int C_Libelle = 11;

        public virtual ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Libelle, true, false, false, false, this);

     
        public string Libelle => DLibelle.Content; 
        public TBfrData<string> DLibelle => (TBfrData<string>)AssociatedChild(C_Libelle); 

     
        #endregion

        #region 12 Commentaire string

        public const int C_Commentaire = 12;

        public virtual ITBfrData NewDCommentaire(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Commentaire, true, false, false, false, this);

     
        public string Commentaire => DCommentaire.Content; 
        public TBfrData<string> DCommentaire => (TBfrData<string>)AssociatedChild(C_Commentaire); 

     
        #endregion

        #region 13 Id_typecontrainte long

        public const int C_Id_typecontrainte = 13;

        public virtual ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, true, false, false, true, this);

     
        public long Id_typecontrainte => DId_typecontrainte.Content; 
        public TBfrData<long> DId_typecontrainte => (TBfrData<long>)AssociatedChild(C_Id_typecontrainte); 

     
        #endregion

        #region 14 Realisee bool

        public const int C_Realisee = 14;

        public virtual ITBfrData NewDRealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Realisee, false, true, false, false, this);

     
        public bool Realisee => DRealisee.Content; 
        public TBfrData<bool> DRealisee => (TBfrData<bool>)AssociatedChild(C_Realisee); 

     
        #endregion

        #region 15 Lib_typecontrainte string

        public const int C_Lib_typecontrainte = 15;

        public virtual ITBfrData NewDLib_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecontrainte, true, false, false, false, this);

     
        public string Lib_typecontrainte => DLib_typecontrainte.Content; 
        public TBfrData<string> DLib_typecontrainte => (TBfrData<string>)AssociatedChild(C_Lib_typecontrainte); 

     
        #endregion

        #region 16 Abr_planning string

        public const int C_Abr_planning = 16;

        public virtual ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);

     
        public string Abr_planning => DAbr_planning.Content; 
        public TBfrData<string> DAbr_planning => (TBfrData<string>)AssociatedChild(C_Abr_planning); 

     
        #endregion

        #region 17 Lib_planning string

        public const int C_Lib_planning = 17;

        public virtual ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);

     
        public string Lib_planning => DLib_planning.Content; 
        public TBfrData<string> DLib_planning => (TBfrData<string>)AssociatedChild(C_Lib_planning); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL0_Realisation";
        case 0: return "Id";
        case 1: return "Debut";
        case 2: return "Id_employe";
        case 3: return "Duree";
        case 4: return "Logicaldeleted";
        case 5: return "Id_espaceclient";
        case 6: return "Id_contrainterealisee";
        case 7: return "Id_contrainte";
        case 8: return "Id_planning";
        case 9: return "Ref";
        case 10: return "Abreviation";
        case 11: return "Libelle";
        case 12: return "Commentaire";
        case 13: return "Id_typecontrainte";
        case 14: return "Realisee";
        case 15: return "Lib_typecontrainte";
        case 16: return "Abr_planning";
        case 17: return "Lib_planning";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL0_Realisation.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL0_Realisation.Id;
                case C_Debut: return RPL_V_PL0_Realisation.Debut;
                case C_Id_employe: return RPL_V_PL0_Realisation.Id_employe;
                case C_Duree: return RPL_V_PL0_Realisation.Duree;
                case C_Id_espaceclient: return RPL_V_PL0_Realisation.Id_espaceclient;
                case C_Id_contrainterealisee: return RPL_V_PL0_Realisation.Id_contrainterealisee;
                case C_Id_contrainte: return RPL_V_PL0_Realisation.Id_contrainte;
                case C_Id_planning: return RPL_V_PL0_Realisation.Id_planning;
                case C_Ref: return RPL_V_PL0_Realisation.Ref;
                case C_Abreviation: return RPL_V_PL0_Realisation.Abreviation;
                case C_Libelle: return RPL_V_PL0_Realisation.Libelle;
                case C_Commentaire: return RPL_V_PL0_Realisation.Commentaire;
                case C_Id_typecontrainte: return RPL_V_PL0_Realisation.Id_typecontrainte;
                case C_Realisee: return RPL_V_PL0_Realisation.Realisee;
                case C_Lib_typecontrainte: return RPL_V_PL0_Realisation.Lib_typecontrainte;
                case C_Abr_planning: return RPL_V_PL0_Realisation.Abr_planning;
                case C_Lib_planning: return RPL_V_PL0_Realisation.Lib_planning;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL0_Realisation ToStruct() => new DSPL_V_PL0_Realisation 
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
    
    public class DPL_V_PL0_Realisation_List_generated : TBfrData_List
    {

        public DPL_V_PL0_Realisation_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL0_Realisation.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Realisation_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Realisation> ToStruct() => this.Select(x => ((DPL_V_PL0_Realisation)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Realisation(tBfrData_Type, true);

    }

    public partial class DPL_V_PL0_Realisation : DPL_V_PL0_Realisation_generated
    {
          public DPL_V_PL0_Realisation(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL0_Realisation_List : DPL_V_PL0_Realisation_List_generated
    {
          public DPL_V_PL0_Realisation_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Realisation
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
      
    
    public class DPL_V_PL0_Realisation_Choice_generated : DPL_V_PL0_Realisation
    {
        public DPL_V_PL0_Realisation_Choice_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type,withChildren) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation_Choice(tBfrData_Type, withChildren);

        public override TBfrData_List AddChildren(TBfrData_Type tBfrData_Type)
        {
            NewDLibelle(tBfrData_Type);

            return this;
        }

        public override string AbsoluteXmlName(int index) => index==-1 ? "PL_V_PL0_Realisation_Choice" : base.AbsoluteXmlName(index);

        public DSPL_V_PL0_Realisation_Choice ToStructChoice() => new DSPL_V_PL0_Realisation_Choice
        {
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),

        };
   }

    public class DPL_V_PL0_Realisation_ChoiceList_generated : TBfrData_List
    {
        public DPL_V_PL0_Realisation_ChoiceList_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren = true) => new DPL_V_PL0_Realisation_ChoiceList(tBfrData_Type, withChildren);

        public override string AbsoluteXmlName(int index) => "PL_V_PL0_Realisation_Choice" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL0_Realisation_Choice> ToStruct() => this.Select(x => ((DPL_V_PL0_Realisation_Choice)x).ToStructChoice()).ToList();
     
        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL0_Realisation_Choice(tBfrData_Type, true);
   }


    public partial class DPL_V_PL0_Realisation_Choice : DPL_V_PL0_Realisation_Choice_generated
    {
          public DPL_V_PL0_Realisation_Choice(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public partial class DPL_V_PL0_Realisation_ChoiceList : DPL_V_PL0_Realisation_ChoiceList_generated
    {
          public DPL_V_PL0_Realisation_ChoiceList(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL0_Realisation_Choice
    {
            public string Libelle;

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
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, false, true, this);
     
        public override ITBfrData NewDRef(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref, false, false, false, false, this);
     
        public override ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abreviation, true, false, false, false, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Libelle, true, false, false, false, this);
     
        public override ITBfrData NewDCommentaire(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Commentaire, true, false, false, false, this);
     
        public override ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, false, false, false, true, this);
     
        public override ITBfrData NewDRealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Realisee, false, true, false, false, this);
     
        public override ITBfrData NewDLib_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_typecontrainte, true, false, false, false, this);
     
        public override ITBfrData NewDAbr_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Abr_planning, true, false, false, false, this);
     
        public override ITBfrData NewDLib_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Lib_planning, true, false, false, false, this);
     

  */

