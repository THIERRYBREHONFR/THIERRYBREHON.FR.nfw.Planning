// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_Utilisateur_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_Utilisateur_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Utilisateur(tBfrData_Type, withChildren);

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
                case C_Modif: return NewDModif(tBfrData_Type);
                case C_Id_espaceclient: return NewDId_espaceclient(tBfrData_Type);
                case C_Nom: return NewDNom(tBfrData_Type);
                case C_Prenom: return NewDPrenom(tBfrData_Type);
                case C_Feminin: return NewDFeminin(tBfrData_Type);

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

        #region 2 Modif bool

        public const int C_Modif = 2;

        public virtual ITBfrData NewDModif(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Modif, false, true, true, false, this);

     
        public bool Modif => DModif.Content; 
        public TBfrData<bool> DModif => (TBfrData<bool>)AssociatedChild(C_Modif); 

     
        #endregion

        #region 3 Id_espaceclient long

        public const int C_Id_espaceclient = 3;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 4 Nom string

        public const int C_Nom = 4;

        public virtual ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 50, C_Nom, true, false, true, this);
     
        public string Nom => DNom.Content; 
        public TBfrData<string> DNom => (TBfrData<string>)AssociatedChild(C_Nom); 

     
        #endregion

        #region 5 Prenom string

        public const int C_Prenom = 5;

        public virtual ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 50, C_Prenom, true, false, false, this);
     
        public string Prenom => DPrenom.Content; 
        public TBfrData<string> DPrenom => (TBfrData<string>)AssociatedChild(C_Prenom); 

     
        #endregion

        #region 6 Feminin bool

        public const int C_Feminin = 6;

        public virtual ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, false, false, this);

     
        public bool Feminin => DFeminin.Content; 
        public TBfrData<bool> DFeminin => (TBfrData<bool>)AssociatedChild(C_Feminin); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_Utilisateur";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Modif";
        case 3: return "Id_espaceclient";
        case 4: return "Nom";
        case 5: return "Prenom";
        case 6: return "Feminin";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Utilisateur.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_Utilisateur.Id;
                case C_Modif: return RDBPL_V_DB0_Utilisateur.Modif;
                case C_Id_espaceclient: return RDBPL_V_DB0_Utilisateur.Id_espaceclient;
                case C_Nom: return RDBPL_V_DB0_Utilisateur.Nom;
                case C_Prenom: return RDBPL_V_DB0_Utilisateur.Prenom;
                case C_Feminin: return RDBPL_V_DB0_Utilisateur.Feminin;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_Utilisateur ToStruct() => new DSDBPL_V_DB0_Utilisateur 
          {
            Id = DId == null || DId.IsNull ? null : Id.ToString(),
            Logicaldeleted = DLogicaldeleted == null || DLogicaldeleted.IsNull ? null : Logicaldeleted.ToString(),
            Modif = DModif == null || DModif.IsNull ? null : Modif.ToString(),
            Id_espaceclient = DId_espaceclient == null || DId_espaceclient.IsNull ? null : Id_espaceclient.ToString(),
            Nom = DNom == null || DNom.IsNull ? null : Nom.ToString(),
            Prenom = DPrenom == null || DPrenom.IsNull ? null : Prenom.ToString(),
            Feminin = DFeminin == null || DFeminin.IsNull ? null : Feminin.ToString(),

          };
    }
    
    public class DDBPL_V_DB0_Utilisateur_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_Utilisateur_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Utilisateur_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Utilisateur.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_Utilisateur_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_Utilisateur> ToStruct() => this.Select(x => ((DDBPL_V_DB0_Utilisateur)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_Utilisateur(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_Utilisateur : DDBPL_V_DB0_Utilisateur_generated
    {
          public DDBPL_V_DB0_Utilisateur(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_Utilisateur_List : DDBPL_V_DB0_Utilisateur_List_generated
    {
          public DDBPL_V_DB0_Utilisateur_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_Utilisateur
    {
            public string Id;
            public string Logicaldeleted;
            public string Modif;
            public string Id_espaceclient;
            public string Nom;
            public string Prenom;
            public string Feminin;

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, true, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, true, false, this);
     
        public override ITBfrData NewDModif(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Modif, false, true, true, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, true, false, this);
     
        public override ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(1, 50, C_Nom, true, false, true, this);
     
        public override ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type==TBfrData_Type.WithStringContent? TBfrData_Type.WithStringContentAndConstraint: TBfrData_Type.WithConstraint)).Initialize(0, 50, C_Prenom, true, false, false, this);
     
        public override ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, false, false, this);
     

  */

