// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 10:24:22
using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using Planning.NSR;
using Planning.NSD;
using THIERRYBREHON.FR.SERVICE.NSS;
namespace Planning.NSS
{

    public class SPL_V_PL0_Utilisateur_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_Utilisateur_generated() : base() { }

        public SPL_V_PL0_Utilisateur_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_Utilisateur_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_Utilisateur = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Utilisateur(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Utilisateur_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Utilisateur_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Utilisateur_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_Utilisateur", DPL_V_PL0_Utilisateur.C_UpdateColumnsCount, DPL_V_PL0_Utilisateur.C_AdditionalColumnsCount, DPL_V_PL0_Utilisateur.C_Id, DPL_V_PL0_Utilisateur.C_Identite); 
              pLogicalDeletedColumn = DPL_V_PL0_Utilisateur.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_Utilisateur.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Utilisateur.C_Id: return "Id";
                case DPL_V_PL0_Utilisateur.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_Utilisateur.C_Modif: return "Modif";
                case DPL_V_PL0_Utilisateur.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_Utilisateur.C_Nom: return "Nom";
                case DPL_V_PL0_Utilisateur.C_Prenom: return "Prenom";
                case DPL_V_PL0_Utilisateur.C_Feminin: return "Feminin";
                case DPL_V_PL0_Utilisateur.C_Identite: return "Identite";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Utilisateur.C_Id: return "long";
                case DPL_V_PL0_Utilisateur.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_Utilisateur.C_Modif: return "bool";
                case DPL_V_PL0_Utilisateur.C_Id_espaceclient: return "long";
                case DPL_V_PL0_Utilisateur.C_Nom: return "string";
                case DPL_V_PL0_Utilisateur.C_Prenom: return "string";
                case DPL_V_PL0_Utilisateur.C_Feminin: return "bool";
                case DPL_V_PL0_Utilisateur.C_Identite: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_Utilisateur : SPL_V_PL0_Utilisateur_generated
    {
        //public SPL_V_PL0_Utilisateur(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Modif)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Nom)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Prenom)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Utilisateur.C_Feminin)

*/
