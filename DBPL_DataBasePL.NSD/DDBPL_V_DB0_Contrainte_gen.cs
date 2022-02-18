﻿// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_Contrainte_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_Contrainte_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Contrainte(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 10;
        public const int C_AdditionalColumnsCount = 10 - 10;

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
                case C_Ref: return NewDRef(tBfrData_Type);
                case C_Abreviation: return NewDAbreviation(tBfrData_Type);
                case C_Libelle: return NewDLibelle(tBfrData_Type);
                case C_Commentaire: return NewDCommentaire(tBfrData_Type);
                case C_Id_typecontrainte: return NewDId_typecontrainte(tBfrData_Type);
                case C_Realisee: return NewDRealisee(tBfrData_Type);

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

        #region 4 Ref int

        public const int C_Ref = 4;

        public virtual ITBfrData NewDRef(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref, false, false, true, false, this);

     
        public int Ref => DRef.Content; 
        public TBfrData<int> DRef => (TBfrData<int>)AssociatedChild(C_Ref); 

     
        #endregion

        #region 5 Abreviation string

        public const int C_Abreviation = 5;

        public virtual ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 16, C_Abreviation, true, false, false, this);
     
        public string Abreviation => DAbreviation.Content; 
        public TBfrData<string> DAbreviation => (TBfrData<string>)AssociatedChild(C_Abreviation); 

     
        #endregion

        #region 6 Libelle string

        public const int C_Libelle = 6;

        public virtual ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public string Libelle => DLibelle.Content; 
        public TBfrData<string> DLibelle => (TBfrData<string>)AssociatedChild(C_Libelle); 

     
        #endregion

        #region 7 Commentaire string

        public const int C_Commentaire = 7;

        public virtual ITBfrData NewDCommentaire(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 1000, C_Commentaire, true, false, false, this);
     
        public string Commentaire => DCommentaire.Content; 
        public TBfrData<string> DCommentaire => (TBfrData<string>)AssociatedChild(C_Commentaire); 

     
        #endregion

        #region 8 Id_typecontrainte long

        public const int C_Id_typecontrainte = 8;

        public virtual ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, true, false, true, true, this);

     
        public long Id_typecontrainte => DId_typecontrainte.Content; 
        public TBfrData<long> DId_typecontrainte => (TBfrData<long>)AssociatedChild(C_Id_typecontrainte); 

     
        #endregion

        #region 9 Realisee bool

        public const int C_Realisee = 9;

        public virtual ITBfrData NewDRealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Realisee, false, true, true, false, this);

     
        public bool Realisee => DRealisee.Content; 
        public TBfrData<bool> DRealisee => (TBfrData<bool>)AssociatedChild(C_Realisee); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_Contrainte";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Id_espaceclient";
        case 3: return "Id_planning";
        case 4: return "Ref";
        case 5: return "Abreviation";
        case 6: return "Libelle";
        case 7: return "Commentaire";
        case 8: return "Id_typecontrainte";
        case 9: return "Realisee";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Contrainte.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_Contrainte.Id;
                case C_Id_espaceclient: return RDBPL_V_DB0_Contrainte.Id_espaceclient;
                case C_Id_planning: return RDBPL_V_DB0_Contrainte.Id_planning;
                case C_Ref: return RDBPL_V_DB0_Contrainte.Ref;
                case C_Abreviation: return RDBPL_V_DB0_Contrainte.Abreviation;
                case C_Libelle: return RDBPL_V_DB0_Contrainte.Libelle;
                case C_Commentaire: return RDBPL_V_DB0_Contrainte.Commentaire;
                case C_Id_typecontrainte: return RDBPL_V_DB0_Contrainte.Id_typecontrainte;
                case C_Realisee: return RDBPL_V_DB0_Contrainte.Realisee;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_Contrainte ToStruct() => new DSDBPL_V_DB0_Contrainte 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Id_planning = DId_planning == null || DId_planning.IsNull ? null : Id_planning.ToString(),
            Ref = DRef == null || DRef.IsNull ? null : Ref.ToString(),
            Abreviation = DAbreviation == null || DAbreviation.IsNull ? null : Abreviation.ToString(),
            Libelle = DLibelle == null || DLibelle.IsNull ? null : Libelle.ToString(),
            Commentaire = DCommentaire == null || DCommentaire.IsNull ? null : Commentaire.ToString(),
            Id_typecontrainte = DId_typecontrainte == null || DId_typecontrainte.IsNull ? null : Id_typecontrainte.ToString(),
            Realisee = DRealisee == null || DRealisee.IsNull ? null : Realisee.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_Contrainte_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_Contrainte_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Contrainte_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Contrainte.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_Contrainte_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_Contrainte> ToStruct() => this.Select(x => ((DDBPL_V_DB0_Contrainte)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_Contrainte(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_Contrainte : DDBPL_V_DB0_Contrainte_generated
    {
          public DDBPL_V_DB0_Contrainte(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_Contrainte_List : DDBPL_V_DB0_Contrainte_List_generated
    {
          public DDBPL_V_DB0_Contrainte_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_Contrainte
    {
            public string Id;
            public string Logicaldeleted;
            public string Id_espaceclient;
            public string Id_planning;
            public string Ref;
            public string Abreviation;
            public string Libelle;
            public string Commentaire;
            public string Id_typecontrainte;
            public string Realisee;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDId_planning(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_planning, false, false, true, true, this);
     
        public override ITBfrData NewDRef(TBfrData_Type tBfrData_Type) => ((TBfrData_int)TBfrData_int.NewITBfrData(tBfrData_Type)).Initialize(C_Ref, false, false, true, false, this);
     
        public override ITBfrData NewDAbreviation(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 16, C_Abreviation, true, false, false, this);
     
        public override ITBfrData NewDLibelle(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 100, C_Libelle, true, false, true, this);
     
        public override ITBfrData NewDCommentaire(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 1000, C_Commentaire, true, false, false, this);
     
        public override ITBfrData NewDId_typecontrainte(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_typecontrainte, false, false, true, true, this);
     
        public override ITBfrData NewDRealisee(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Realisee, false, true, true, false, this);
     

  */

