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

    public class SPL_V_PL0_EquipeEmployeVersion_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_EquipeEmployeVersion_generated() : base() { }

        public SPL_V_PL0_EquipeEmployeVersion_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_EquipeEmployeVersion_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_EquipeEmployeVersion = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_EquipeEmployeVersion(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_EquipeEmployeVersion_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_PL0_EquipeEmployeVersion", DPL_V_PL0_EquipeEmployeVersion.C_UpdateColumnsCount, DPL_V_PL0_EquipeEmployeVersion.C_AdditionalColumnsCount, DPL_V_PL0_EquipeEmployeVersion.C_Id); 
              pLogicalDeletedColumn = DPL_V_PL0_EquipeEmployeVersion.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_EquipeEmployeVersion.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_EquipeEmployeVersion.C_Id: return "Id";
                case DPL_V_PL0_EquipeEmployeVersion.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_version: return "Id_version";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe: return "Id_equipe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_employe: return "Id_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_planning: return "Id_planning";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning: return "Lib_planning";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning: return "Abr_planning";
                case DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe: return "Nom_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe: return "Prenom_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe: return "Feminin_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe: return "Ident_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Init_employe: return "Init_employe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe: return "Abr_equipe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe: return "Lib_equipe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe: return "Lib_planning_equipe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe: return "Abr_planning_equipe";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_version: return "Abr_version";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_version: return "Lib_version";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version: return "Lib_planning_version";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version: return "Abr_planning_version";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_EquipeEmployeVersion.C_Id: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_version: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_employe: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_espaceclient: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Id_planning: return "long";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Nom_employe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Prenom_employe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Feminin_employe: return "bool";
                case DPL_V_PL0_EquipeEmployeVersion.C_Ident_employe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Init_employe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_equipe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_equipe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_equipe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_equipe: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_version: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_version: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Lib_planning_version: return "string";
                case DPL_V_PL0_EquipeEmployeVersion.C_Abr_planning_version: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_EquipeEmployeVersion : SPL_V_PL0_EquipeEmployeVersion_generated
    {
        //public SPL_V_PL0_EquipeEmployeVersion(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Id_version)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Id_equipe)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Id_employe)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_EquipeEmployeVersion.C_Id_espaceclient)

*/
