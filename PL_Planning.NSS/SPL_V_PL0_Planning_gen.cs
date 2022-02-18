// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:23:04
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

    public class SPL_V_PL0_Planning_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_Planning_generated() : base() { }

        public SPL_V_PL0_Planning_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_Planning_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_Planning = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Planning(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Planning_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Planning_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Planning_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_Planning", DPL_V_PL0_Planning.C_UpdateColumnsCount, DPL_V_PL0_Planning.C_AdditionalColumnsCount, DPL_V_PL0_Planning.C_Id, DPL_V_PL0_Planning.C_Libelle); 
              pLogicalDeletedColumn = DPL_V_PL0_Planning.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_Planning.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Planning.C_Id: return "Id";
                case DPL_V_PL0_Planning.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_Planning.C_Libelle: return "Libelle";
                case DPL_V_PL0_Planning.C_Abreviation: return "Abreviation";
                case DPL_V_PL0_Planning.C_Debut: return "Debut";
                case DPL_V_PL0_Planning.C_Fin: return "Fin";
                case DPL_V_PL0_Planning.C_Id_espaceclient: return "Id_espaceclient";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Planning.C_Id: return "long";
                case DPL_V_PL0_Planning.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_Planning.C_Libelle: return "string";
                case DPL_V_PL0_Planning.C_Abreviation: return "string";
                case DPL_V_PL0_Planning.C_Debut: return "DateTime";
                case DPL_V_PL0_Planning.C_Fin: return "DateTime";
                case DPL_V_PL0_Planning.C_Id_espaceclient: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_Planning : SPL_V_PL0_Planning_generated
    {
        //public SPL_V_PL0_Planning(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Abreviation)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Debut)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Fin)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Planning.C_Id_espaceclient)

*/
