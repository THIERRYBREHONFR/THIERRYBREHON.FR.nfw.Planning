// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:02
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

    public class SPL_V_PL0_CategorieContrainte_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_CategorieContrainte_generated() : base() { }

        public SPL_V_PL0_CategorieContrainte_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_CategorieContrainte_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_CategorieContrainte = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_CategorieContrainte(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_CategorieContrainte_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_PL0_CategorieContrainte", DPL_V_PL0_CategorieContrainte.C_UpdateColumnsCount, DPL_V_PL0_CategorieContrainte.C_AdditionalColumnsCount, DPL_V_PL0_CategorieContrainte.C_Id); 
              pLogicalDeletedColumn = DPL_V_PL0_CategorieContrainte.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_CategorieContrainte.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_CategorieContrainte.C_Id: return "Id";
                case DPL_V_PL0_CategorieContrainte.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_CategorieContrainte.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_CategorieContrainte.C_Id_categorie: return "Id_categorie";
                case DPL_V_PL0_CategorieContrainte.C_Id_contrainte: return "Id_contrainte";
                case DPL_V_PL0_CategorieContrainte.C_Lib_categorie: return "Lib_categorie";
                case DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie: return "Lib_typecategorie";
                case DPL_V_PL0_CategorieContrainte.C_Id_planning: return "Id_planning";
                case DPL_V_PL0_CategorieContrainte.C_Lib_planning: return "Lib_planning";
                case DPL_V_PL0_CategorieContrainte.C_Abr_planning: return "Abr_planning";
                case DPL_V_PL0_CategorieContrainte.C_Ref_contrainte: return "Ref_contrainte";
                case DPL_V_PL0_CategorieContrainte.C_Lib_contrainte: return "Lib_contrainte";
                case DPL_V_PL0_CategorieContrainte.C_Comm_contrainte: return "Comm_contrainte";
                case DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte: return "Id_typecontrainte";
                case DPL_V_PL0_CategorieContrainte.C_Abr_contrainte: return "Abr_contrainte";
                case DPL_V_PL0_CategorieContrainte.C_Contrainterealisee: return "Contrainterealisee";
                case DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte: return "Lib_typecontrainte";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_CategorieContrainte.C_Id: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_CategorieContrainte.C_Id_espaceclient: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Id_categorie: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Id_contrainte: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Lib_categorie: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Lib_typecategorie: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Id_planning: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Lib_planning: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Abr_planning: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Ref_contrainte: return "int";
                case DPL_V_PL0_CategorieContrainte.C_Lib_contrainte: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Comm_contrainte: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Id_typecontrainte: return "long";
                case DPL_V_PL0_CategorieContrainte.C_Abr_contrainte: return "string";
                case DPL_V_PL0_CategorieContrainte.C_Contrainterealisee: return "bool";
                case DPL_V_PL0_CategorieContrainte.C_Lib_typecontrainte: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_CategorieContrainte : SPL_V_PL0_CategorieContrainte_generated
    {
        //public SPL_V_PL0_CategorieContrainte(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_CategorieContrainte.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_CategorieContrainte.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_CategorieContrainte.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_CategorieContrainte.C_Id_categorie)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_CategorieContrainte.C_Id_contrainte)

*/
