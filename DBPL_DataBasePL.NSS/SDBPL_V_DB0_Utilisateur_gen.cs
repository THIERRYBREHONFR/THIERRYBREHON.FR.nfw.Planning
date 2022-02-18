// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using DataBasePL.NSR;
using DataBasePL.NSD;
using THIERRYBREHON.FR.SERVICE.NSS;
namespace DataBasePL.NSS
{

    public class SDBPL_V_DB0_Utilisateur_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Utilisateur_generated() : base() { }

        public SDBPL_V_DB0_Utilisateur_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Utilisateur_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Utilisateur = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Utilisateur(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Utilisateur_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Utilisateur", DDBPL_V_DB0_Utilisateur.C_UpdateColumnsCount, DDBPL_V_DB0_Utilisateur.C_AdditionalColumnsCount, DDBPL_V_DB0_Utilisateur.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Utilisateur.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Utilisateur.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Utilisateur.C_Id: return "Id";
                case DDBPL_V_DB0_Utilisateur.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Utilisateur.C_Modif: return "Modif";
                case DDBPL_V_DB0_Utilisateur.C_Id_espaceclient: return "Id_espaceclient";
                case DDBPL_V_DB0_Utilisateur.C_Nom: return "Nom";
                case DDBPL_V_DB0_Utilisateur.C_Prenom: return "Prenom";
                case DDBPL_V_DB0_Utilisateur.C_Feminin: return "Feminin";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Utilisateur.C_Id: return "long";
                case DDBPL_V_DB0_Utilisateur.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Utilisateur.C_Modif: return "bool";
                case DDBPL_V_DB0_Utilisateur.C_Id_espaceclient: return "long";
                case DDBPL_V_DB0_Utilisateur.C_Nom: return "string";
                case DDBPL_V_DB0_Utilisateur.C_Prenom: return "string";
                case DDBPL_V_DB0_Utilisateur.C_Feminin: return "bool";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SDBPL_V_DB0_Utilisateur : SDBPL_V_DB0_Utilisateur_generated
    {
        //public SDBPL_V_DB0_Utilisateur(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Modif)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Nom)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Prenom)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Feminin)

*/
