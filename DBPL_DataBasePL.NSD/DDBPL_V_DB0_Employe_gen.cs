// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using DataBasePL.NSR;
namespace DataBasePL.NSD
{

    public class DDBPL_V_DB0_Employe_generated : TBfrData_List
    {
        #region object itself

        public DDBPL_V_DB0_Employe_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Employe(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 9;
        public const int C_AdditionalColumnsCount = 9 - 9;

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



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "DBPL_V_DB0_Employe";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Initiales";
        case 3: return "Id_planning";
        case 4: return "Id_espaceclient";
        case 5: return "Nom";
        case 6: return "Prenom";
        case 7: return "Feminin";
        case 8: return "Id_utilisateur";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Employe.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RDBPL_V_DB0_Employe.Id;
                case C_Initiales: return RDBPL_V_DB0_Employe.Initiales;
                case C_Id_planning: return RDBPL_V_DB0_Employe.Id_planning;
                case C_Id_espaceclient: return RDBPL_V_DB0_Employe.Id_espaceclient;
                case C_Nom: return RDBPL_V_DB0_Employe.Nom;
                case C_Prenom: return RDBPL_V_DB0_Employe.Prenom;
                case C_Feminin: return RDBPL_V_DB0_Employe.Feminin;
                case C_Id_utilisateur: return RDBPL_V_DB0_Employe.Id_utilisateur;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSDBPL_V_DB0_Employe ToStruct() => new DSDBPL_V_DB0_Employe 
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
    
    public class DDBPL_V_DB0_Employe_List_generated : TBfrData_List
    {

        public DDBPL_V_DB0_Employe_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Employe_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RDBPL_V_DB0_Employe.ObjectList;

        public override string AbsoluteXmlName(int index) => "DBPL_V_DB0_Employe_" + (index==-1 ? "List" : index.ToString());

        public List<DSDBPL_V_DB0_Employe> ToStruct() => this.Select(x => ((DDBPL_V_DB0_Employe)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DDBPL_V_DB0_Employe(tBfrData_Type, true);

    }

    public partial class DDBPL_V_DB0_Employe : DDBPL_V_DB0_Employe_generated
    {
          public DDBPL_V_DB0_Employe(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DDBPL_V_DB0_Employe_List : DDBPL_V_DB0_Employe_List_generated
    {
          public DDBPL_V_DB0_Employe_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSDBPL_V_DB0_Employe
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
     

  */

