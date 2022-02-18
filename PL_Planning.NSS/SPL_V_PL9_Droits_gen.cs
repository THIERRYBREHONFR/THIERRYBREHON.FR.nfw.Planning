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

    public class SPL_V_PL9_Droits_generated : TBfrStorageSqlView

    {

        // public SPL_V_PL9_Droits_generated() : base() { }

        public SPL_V_PL9_Droits_generated(ITBfrStorageAccess iTBfrStorageAccess) : base(iTBfrStorageAccess) { }

        protected const int C_NViewV_PL9_Droits = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL9_Droits(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DPL_V_PL9_Droits_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_PL9_Droits", DPL_V_PL9_Droits.C_UpdateColumnsCount, DPL_V_PL9_Droits.C_AdditionalColumnsCount, DPL_V_PL9_Droits.C_Id); 
              pLogicalDeletedColumn = DPL_V_PL9_Droits.C_Logicaldeleted;

              pId_espaceclientColumn = DPL_V_PL9_Droits.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DPL_V_PL9_Droits.C_Id: return "Id";
                case DPL_V_PL9_Droits.C_Logicaldeleted: return "Logicaldeleted";
                case DPL_V_PL9_Droits.C_Modif: return "Modif";
                case DPL_V_PL9_Droits.C_Id_espaceclient: return "Id_espaceclient";
                case DPL_V_PL9_Droits.C_Nom: return "Nom";
                case DPL_V_PL9_Droits.C_Prenom: return "Prenom";
                case DPL_V_PL9_Droits.C_Feminin: return "Feminin";
                case DPL_V_PL9_Droits.C_Identite: return "Identite";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DPL_V_PL9_Droits.C_Id: return "long";
                case DPL_V_PL9_Droits.C_Logicaldeleted: return "bool";
                case DPL_V_PL9_Droits.C_Modif: return "bool";
                case DPL_V_PL9_Droits.C_Id_espaceclient: return "long";
                case DPL_V_PL9_Droits.C_Nom: return "string";
                case DPL_V_PL9_Droits.C_Prenom: return "string";
                case DPL_V_PL9_Droits.C_Feminin: return "bool";
                case DPL_V_PL9_Droits.C_Identite: return "string";

                default: throw new ArgumentOutOfRangeException();
            }
        }



    }
    public partial class SPL_V_PL9_Droits : SPL_V_PL9_Droits_generated
    {
        public SPL_V_PL9_Droits(ITBfrStorageAccess iTBfrStorageAccess) : base(iTBfrStorageAccess) { }



    }
}
/*

*/
