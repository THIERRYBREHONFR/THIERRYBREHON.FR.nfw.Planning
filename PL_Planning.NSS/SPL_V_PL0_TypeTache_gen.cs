// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:26:46
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

    public class SPL_V_PL0_TypeTache_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_TypeTache_generated() : base() { }

        public SPL_V_PL0_TypeTache_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_TypeTache_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_TypeTache = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeTache(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeTache_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeTache_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_TypeTache_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_TypeTache", DPL_V_PL0_TypeTache.C_UpdateColumnsCount, DPL_V_PL0_TypeTache.C_AdditionalColumnsCount, DPL_V_PL0_TypeTache.C_Id, DPL_V_PL0_TypeTache.C_Libelle); 
              pLogicalDeletedColumn = DPL_V_PL0_TypeTache.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_TypeTache.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_TypeTache.C_Id: return "Id";
                case DPL_V_PL0_TypeTache.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_TypeTache.C_Libelle: return "Libelle";
                case DPL_V_PL0_TypeTache.C_Id_espaceclient: return "Id_espaceclient";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_TypeTache.C_Id: return "long";
                case DPL_V_PL0_TypeTache.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_TypeTache.C_Libelle: return "string";
                case DPL_V_PL0_TypeTache.C_Id_espaceclient: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_TypeTache : SPL_V_PL0_TypeTache_generated
    {
        //public SPL_V_PL0_TypeTache(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_TypeTache.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_TypeTache.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_TypeTache.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_TypeTache.C_Id_espaceclient)

*/
