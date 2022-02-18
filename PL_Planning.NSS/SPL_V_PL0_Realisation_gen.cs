// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:23:28
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

    public class SPL_V_PL0_Realisation_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_Realisation_generated() : base() { }

        public SPL_V_PL0_Realisation_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_Realisation_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_Realisation = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Realisation_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_Realisation", DPL_V_PL0_Realisation.C_UpdateColumnsCount, DPL_V_PL0_Realisation.C_AdditionalColumnsCount, DPL_V_PL0_Realisation.C_Id, DPL_V_PL0_Realisation.C_Libelle); 
              pLogicalDeletedColumn = DPL_V_PL0_Realisation.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_Realisation.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Realisation.C_Id: return "Id";
                case DPL_V_PL0_Realisation.C_Debut: return "Debut";
                case DPL_V_PL0_Realisation.C_Id_employe: return "Id_employe";
                case DPL_V_PL0_Realisation.C_Duree: return "Duree";
                case DPL_V_PL0_Realisation.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_Realisation.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_Realisation.C_Id_contrainterealisee: return "Id_contrainterealisee";
                case DPL_V_PL0_Realisation.C_Id_contrainte: return "Id_contrainte";
                case DPL_V_PL0_Realisation.C_Id_planning: return "Id_planning";
                case DPL_V_PL0_Realisation.C_Ref: return "Ref";
                case DPL_V_PL0_Realisation.C_Abreviation: return "Abreviation";
                case DPL_V_PL0_Realisation.C_Libelle: return "Libelle";
                case DPL_V_PL0_Realisation.C_Commentaire: return "Commentaire";
                case DPL_V_PL0_Realisation.C_Id_typecontrainte: return "Id_typecontrainte";
                case DPL_V_PL0_Realisation.C_Realisee: return "Realisee";
                case DPL_V_PL0_Realisation.C_Lib_typecontrainte: return "Lib_typecontrainte";
                case DPL_V_PL0_Realisation.C_Abr_planning: return "Abr_planning";
                case DPL_V_PL0_Realisation.C_Lib_planning: return "Lib_planning";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Realisation.C_Id: return "long";
                case DPL_V_PL0_Realisation.C_Debut: return "DateTime";
                case DPL_V_PL0_Realisation.C_Id_employe: return "long";
                case DPL_V_PL0_Realisation.C_Duree: return "int";
                case DPL_V_PL0_Realisation.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_Realisation.C_Id_espaceclient: return "long";
                case DPL_V_PL0_Realisation.C_Id_contrainterealisee: return "long";
                case DPL_V_PL0_Realisation.C_Id_contrainte: return "long";
                case DPL_V_PL0_Realisation.C_Id_planning: return "long";
                case DPL_V_PL0_Realisation.C_Ref: return "int";
                case DPL_V_PL0_Realisation.C_Abreviation: return "string";
                case DPL_V_PL0_Realisation.C_Libelle: return "string";
                case DPL_V_PL0_Realisation.C_Commentaire: return "string";
                case DPL_V_PL0_Realisation.C_Id_typecontrainte: return "long";
                case DPL_V_PL0_Realisation.C_Realisee: return "bool";
                case DPL_V_PL0_Realisation.C_Lib_typecontrainte: return "string";
                case DPL_V_PL0_Realisation.C_Abr_planning: return "string";
                case DPL_V_PL0_Realisation.C_Lib_planning: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_Realisation : SPL_V_PL0_Realisation_generated
    {
        //public SPL_V_PL0_Realisation(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Debut)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Id_employe)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Duree)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Id_contrainterealisee)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Realisation.C_Id_contrainte)

*/
