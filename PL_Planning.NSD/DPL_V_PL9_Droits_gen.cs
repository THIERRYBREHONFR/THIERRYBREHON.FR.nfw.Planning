// Généré par GENERATEUR.THIERRYBREHON.FR le 22/12/2021 18:53:05
using System;
using System.Linq;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using Planning.NSR;
namespace Planning.NSD
{

    public class DPL_V_PL9_Droits_generated : TBfrData_List
    {
        #region object itself

        public DPL_V_PL9_Droits_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, false, true) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL9_Droits(tBfrData_Type, withChildren);

        #endregion

        public const int C_UpdateColumnsCount = 0;
        public const int C_AdditionalColumnsCount = 8 - 0;

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
                case C_Identite: return NewDIdentite(tBfrData_Type);

                default: return null;
            }
        }

        #endregion

        #region 0 Id long

        public const int C_Id = 0;

        public virtual ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, false, false, this);

     
        public override TBfrData<long> DId => (TBfrData<long>)AssociatedChild(C_Id); 

     
        #endregion

        #region 1 Logicaldeleted bool

        public const int C_Logicaldeleted = 1;

        public virtual ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, false, false, this);

     
        public bool Logicaldeleted => DLogicaldeleted.Content; 
        public TBfrData<bool> DLogicaldeleted => (TBfrData<bool>)AssociatedChild(C_Logicaldeleted); 

     
        #endregion

        #region 2 Modif bool

        public const int C_Modif = 2;

        public virtual ITBfrData NewDModif(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Modif, false, true, false, false, this);

     
        public bool Modif => DModif.Content; 
        public TBfrData<bool> DModif => (TBfrData<bool>)AssociatedChild(C_Modif); 

     
        #endregion

        #region 3 Id_espaceclient long

        public const int C_Id_espaceclient = 3;

        public virtual ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

     
        public long Id_espaceclient => DId_espaceclient.Content; 
        public TBfrData<long> DId_espaceclient => (TBfrData<long>)AssociatedChild(C_Id_espaceclient); 

     
        #endregion

        #region 4 Nom string

        public const int C_Nom = 4;

        public virtual ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Nom, true, false, false, false, this);

     
        public string Nom => DNom.Content; 
        public TBfrData<string> DNom => (TBfrData<string>)AssociatedChild(C_Nom); 

     
        #endregion

        #region 5 Prenom string

        public const int C_Prenom = 5;

        public virtual ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Prenom, true, false, false, false, this);

     
        public string Prenom => DPrenom.Content; 
        public TBfrData<string> DPrenom => (TBfrData<string>)AssociatedChild(C_Prenom); 

     
        #endregion

        #region 6 Feminin bool

        public const int C_Feminin = 6;

        public virtual ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, false, false, this);

     
        public bool Feminin => DFeminin.Content; 
        public TBfrData<bool> DFeminin => (TBfrData<bool>)AssociatedChild(C_Feminin); 

     
        #endregion

        #region 7 Identite string

        public const int C_Identite = 7;

        public virtual ITBfrData NewDIdentite(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Identite, true, false, false, false, this);

     
        public string Identite => DIdentite.Content; 
        public TBfrData<string> DIdentite => (TBfrData<string>)AssociatedChild(C_Identite); 

     
        #endregion



        #region xml name

        public override string AbsoluteXmlName(int index) 
        {
          switch (index)
            {
                case -1: return "PL_V_PL9_Droits";
        case 0: return "Id";
        case 1: return "Logicaldeleted";
        case 2: return "Modif";
        case 3: return "Id_espaceclient";
        case 4: return "Nom";
        case 5: return "Prenom";
        case 6: return "Feminin";
        case 7: return "Identite";

                default: return base.AbsoluteXmlName(index);
            }
        }

        #endregion

        #region errrors name

        public override string AbsoluteErrorName() => RPL_V_PL9_Droits.Object;

        public override string ChildErrorName(int index)
        {
            switch (index)
            {
                case C_Id: return RPL_V_PL9_Droits.Id;
                case C_Modif: return RPL_V_PL9_Droits.Modif;
                case C_Id_espaceclient: return RPL_V_PL9_Droits.Id_espaceclient;
                case C_Nom: return RPL_V_PL9_Droits.Nom;
                case C_Prenom: return RPL_V_PL9_Droits.Prenom;
                case C_Feminin: return RPL_V_PL9_Droits.Feminin;
                case C_Identite: return RPL_V_PL9_Droits.Identite;

                default: return null;
            }
        }

        #endregion
        
        public virtual DSPL_V_PL9_Droits ToStruct() => new DSPL_V_PL9_Droits 
          {

          };
    }
    
    public class DPL_V_PL9_Droits_List_generated : TBfrData_List
    {

        public DPL_V_PL9_Droits_List_generated(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren, true, false) { }

        public override ITBfrData NewITBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL9_Droits_List(tBfrData_Type, withChildren);

        public override string AbsoluteErrorName() => RPL_V_PL9_Droits.ObjectList;

        public override string AbsoluteXmlName(int index) => "PL_V_PL9_Droits_" + (index==-1 ? "List" : index.ToString());

        public List<DSPL_V_PL9_Droits> ToStruct() => this.Select(x => ((DPL_V_PL9_Droits)x).ToStruct()).ToList();

        public override ITBfrData NewITBfrDataChild(short associatedIndex, TBfrData_Type tBfrData_Type) => new DPL_V_PL9_Droits(tBfrData_Type, true);

    }

    public partial class DPL_V_PL9_Droits : DPL_V_PL9_Droits_generated
    {
          public DPL_V_PL9_Droits(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);

  }

    public partial class DPL_V_PL9_Droits_List : DPL_V_PL9_Droits_List_generated
    {
          public DPL_V_PL9_Droits_List(TBfrData_Type tBfrData_Type, bool withChildren) : base(tBfrData_Type, withChildren) { }
    }

    public struct DSPL_V_PL9_Droits
    {

    }
      
      
}
  /* A recopier dans le fichier personnalisé si besoin
          public override ITBfrData NewDId(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id, false, false, false, false, this);
     
        public override ITBfrData NewDLogicaldeleted(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Logicaldeleted, false, true, false, false, this);
     
        public override ITBfrData NewDModif(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Modif, false, true, false, false, this);
     
        public override ITBfrData NewDId_espaceclient(TBfrData_Type tBfrData_Type) => ((TBfrData_long)TBfrData_long.NewITBfrData(tBfrData_Type)).Initialize(C_Id_espaceclient, false, false, false, false, this);
     
        public override ITBfrData NewDNom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Nom, true, false, false, false, this);
     
        public override ITBfrData NewDPrenom(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Prenom, true, false, false, false, this);
     
        public override ITBfrData NewDFeminin(TBfrData_Type tBfrData_Type) => ((TBfrData_bool)TBfrData_bool.NewITBfrData(tBfrData_Type)).Initialize(C_Feminin, false, true, false, false, this);
     
        public override ITBfrData NewDIdentite(TBfrData_Type tBfrData_Type) => ((TBfrData_string)TBfrData_string.NewITBfrData(tBfrData_Type)).Initialize(C_Identite, true, false, false, false, this);
     

  */

