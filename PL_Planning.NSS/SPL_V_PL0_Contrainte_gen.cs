// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:22:49
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

    public class SPL_V_PL0_Contrainte_generated : TBfrStorageSqlUpdateView

    {

        // public SPL_V_PL0_Contrainte_generated() : base() { }

        public SPL_V_PL0_Contrainte_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SPL_V_PL0_Contrainte_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_PL0_Contrainte = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Contrainte(tBfrData_Type, withChildren); 

        protected override TBfrData_List NewTBfrData_Choice(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Contrainte_Choice(tBfrData_Type, withChildren); 


        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Contrainte_List(tBfrData_Type, withChildren); 
     
        protected override TBfrData_List NewTBfrData_Choice_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL0_Contrainte_ChoiceList(tBfrData_Type, withChildren); 


        protected override void Initialize() 
        {
           Initialize("V_PL0_Contrainte", DPL_V_PL0_Contrainte.C_UpdateColumnsCount, DPL_V_PL0_Contrainte.C_AdditionalColumnsCount, DPL_V_PL0_Contrainte.C_Id, DPL_V_PL0_Contrainte.C_Libelle); 
              pLogicalDeletedColumn = DPL_V_PL0_Contrainte.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL0_Contrainte.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Contrainte.C_Id: return "Id";
                case DPL_V_PL0_Contrainte.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL0_Contrainte.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL0_Contrainte.C_Id_planning: return "Id_planning";
                case DPL_V_PL0_Contrainte.C_Ref: return "Ref";
                case DPL_V_PL0_Contrainte.C_Abreviation: return "Abreviation";
                case DPL_V_PL0_Contrainte.C_Libelle: return "Libelle";
                case DPL_V_PL0_Contrainte.C_Commentaire: return "Commentaire";
                case DPL_V_PL0_Contrainte.C_Id_typecontrainte: return "Id_typecontrainte";
                case DPL_V_PL0_Contrainte.C_Realisee: return "Realisee";
                case DPL_V_PL0_Contrainte.C_Abr_planning: return "Abr_planning";
                case DPL_V_PL0_Contrainte.C_Lib_planning: return "Lib_planning";
                case DPL_V_PL0_Contrainte.C_Lib_typecontrainte: return "Lib_typecontrainte";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL0_Contrainte.C_Id: return "long";
                case DPL_V_PL0_Contrainte.C_Logicaldeleted: return "bool";
                case DPL_V_PL0_Contrainte.C_Id_espaceclient: return "long";
                case DPL_V_PL0_Contrainte.C_Id_planning: return "long";
                case DPL_V_PL0_Contrainte.C_Ref: return "int";
                case DPL_V_PL0_Contrainte.C_Abreviation: return "string";
                case DPL_V_PL0_Contrainte.C_Libelle: return "string";
                case DPL_V_PL0_Contrainte.C_Commentaire: return "string";
                case DPL_V_PL0_Contrainte.C_Id_typecontrainte: return "long";
                case DPL_V_PL0_Contrainte.C_Realisee: return "bool";
                case DPL_V_PL0_Contrainte.C_Abr_planning: return "string";
                case DPL_V_PL0_Contrainte.C_Lib_planning: return "string";
                case DPL_V_PL0_Contrainte.C_Lib_typecontrainte: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL0_Contrainte : SPL_V_PL0_Contrainte_generated
    {
        //public SPL_V_PL0_Contrainte(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Id_planning)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Ref)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Abreviation)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Commentaire)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Id_typecontrainte)
            // & UniquenessCheck(data_List, errors, iHMObject, DPL_V_PL0_Contrainte.C_Realisee)

*/
