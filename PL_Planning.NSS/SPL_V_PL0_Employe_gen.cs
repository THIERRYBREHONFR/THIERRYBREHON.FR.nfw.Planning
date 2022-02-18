// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:17
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

    public class SPL_V_PL0_Employe_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_Employe_generated() : base() { }

        public SPL_V_PL0_Employe_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_Employe_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_Employe = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Employe_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_Employe", DPL_V_PL0_Employe.C_UpdateColumnsCount, DPL_V_PL0_Employe.C_AdditionalColumnsCount, DPL_V_PL0_Employe.C_Id, DPL_V_PL0_Employe.C_Identite); 
              pLogicalDeletedColumn = DPL_V_PL0_Employe.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_Employe.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Employe.C_Id: return "Id";
                case DPL_V_PL0_Employe.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_Employe.C_Initiales: return "Initiales";
                case DPL_V_PL0_Employe.C_Id_planning: return "Id_planning";
                case DPL_V_PL0_Employe.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_Employe.C_Nom: return "Nom";
                case DPL_V_PL0_Employe.C_Prenom: return "Prenom";
                case DPL_V_PL0_Employe.C_Feminin: return "Feminin";
                case DPL_V_PL0_Employe.C_Id_utilisateur: return "Id_utilisateur";
                case DPL_V_PL0_Employe.C_Identite: return "Identite";
                case DPL_V_PL0_Employe.C_Lib_planning: return "Lib_planning";
                case DPL_V_PL0_Employe.C_Abr_planning: return "Abr_planning";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Employe.C_Id: return "long";
                case DPL_V_PL0_Employe.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_Employe.C_Initiales: return "string";
                case DPL_V_PL0_Employe.C_Id_planning: return "long";
                case DPL_V_PL0_Employe.C_Id_espaceclient: return "long";
                case DPL_V_PL0_Employe.C_Nom: return "string";
                case DPL_V_PL0_Employe.C_Prenom: return "string";
                case DPL_V_PL0_Employe.C_Feminin: return "bool";
                case DPL_V_PL0_Employe.C_Id_utilisateur: return "long";
                case DPL_V_PL0_Employe.C_Identite: return "string";
                case DPL_V_PL0_Employe.C_Lib_planning: return "string";
                case DPL_V_PL0_Employe.C_Abr_planning: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_Employe : SPL_V_PL0_Employe_generated
    {
        //public SPL_V_PL0_Employe(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Initiales)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Id_planning)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Nom)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Prenom)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Feminin)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Employe.C_Id_utilisateur)

*/
