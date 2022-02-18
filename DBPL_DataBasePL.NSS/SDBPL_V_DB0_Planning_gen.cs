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

    public class SDBPL_V_DB0_Planning_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Planning_generated() : base() { }

        public SDBPL_V_DB0_Planning_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Planning_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Planning = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Planning(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Planning_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Planning", DDBPL_V_DB0_Planning.C_UpdateColumnsCount, DDBPL_V_DB0_Planning.C_AdditionalColumnsCount, DDBPL_V_DB0_Planning.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Planning.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Planning.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Planning.C_Id: return "Id";
                case DDBPL_V_DB0_Planning.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Planning.C_Libelle: return "Libelle";
                case DDBPL_V_DB0_Planning.C_Abreviation: return "Abreviation";
                case DDBPL_V_DB0_Planning.C_Debut: return "Debut";
                case DDBPL_V_DB0_Planning.C_Fin: return "Fin";
                case DDBPL_V_DB0_Planning.C_Id_espaceclient: return "Id_espaceclient";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Planning.C_Id: return "long";
                case DDBPL_V_DB0_Planning.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Planning.C_Libelle: return "string";
                case DDBPL_V_DB0_Planning.C_Abreviation: return "string";
                case DDBPL_V_DB0_Planning.C_Debut: return "DateTime";
                case DDBPL_V_DB0_Planning.C_Fin: return "DateTime";
                case DDBPL_V_DB0_Planning.C_Id_espaceclient: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SDBPL_V_DB0_Planning : SDBPL_V_DB0_Planning_generated
    {
        //public SDBPL_V_DB0_Planning(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Abreviation)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Debut)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Fin)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Id_espaceclient)

*/
