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

    public class SDBPL_V_DB0_Contrainte_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Contrainte_generated() : base() { }

        public SDBPL_V_DB0_Contrainte_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Contrainte_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Contrainte = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Contrainte(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Contrainte_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Contrainte", DDBPL_V_DB0_Contrainte.C_UpdateColumnsCount, DDBPL_V_DB0_Contrainte.C_AdditionalColumnsCount, DDBPL_V_DB0_Contrainte.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Contrainte.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Contrainte.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Contrainte.C_Id: return "Id";
                case DDBPL_V_DB0_Contrainte.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Contrainte.C_Id_espaceclient: return "Id_espaceclient";
                case DDBPL_V_DB0_Contrainte.C_Id_planning: return "Id_planning";
                case DDBPL_V_DB0_Contrainte.C_Ref: return "Ref";
                case DDBPL_V_DB0_Contrainte.C_Abreviation: return "Abreviation";
                case DDBPL_V_DB0_Contrainte.C_Libelle: return "Libelle";
                case DDBPL_V_DB0_Contrainte.C_Commentaire: return "Commentaire";
                case DDBPL_V_DB0_Contrainte.C_Id_typecontrainte: return "Id_typecontrainte";
                case DDBPL_V_DB0_Contrainte.C_Realisee: return "Realisee";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Contrainte.C_Id: return "long";
                case DDBPL_V_DB0_Contrainte.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Contrainte.C_Id_espaceclient: return "long";
                case DDBPL_V_DB0_Contrainte.C_Id_planning: return "long";
                case DDBPL_V_DB0_Contrainte.C_Ref: return "int";
                case DDBPL_V_DB0_Contrainte.C_Abreviation: return "string";
                case DDBPL_V_DB0_Contrainte.C_Libelle: return "string";
                case DDBPL_V_DB0_Contrainte.C_Commentaire: return "string";
                case DDBPL_V_DB0_Contrainte.C_Id_typecontrainte: return "long";
                case DDBPL_V_DB0_Contrainte.C_Realisee: return "bool";

                default: throw new ArgumentOutOfRangeException();
            }
        }

        #region Id_planning

        public bool NoUseCheckId_planning(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Contrainte.Object, iHMObject, errors, DDBPL_V_DB0_Contrainte.C_Id_planning, forPhysicalDelete);

        public int ReplacementId_planning(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Contrainte.C_Id_planning, OldId, NewId);

        public virtual int DeletingId_planning(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Contrainte.C_Id_planning, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Contrainte.C_Id_planning, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_planning(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Contrainte.C_Id_planning, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Contrainte.C_Id_planning, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion

        #region Id_typecontrainte

        public bool NoUseCheckId_typecontrainte(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Contrainte.Object, iHMObject, errors, DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, forPhysicalDelete);

        public int ReplacementId_typecontrainte(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, OldId, NewId);

        public virtual int DeletingId_typecontrainte(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_typecontrainte(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Contrainte.C_Id_typecontrainte, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion



    }
    public partial class SDBPL_V_DB0_Contrainte : SDBPL_V_DB0_Contrainte_generated
    {
        //public SDBPL_V_DB0_Contrainte(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_planning)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Ref)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Abreviation)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Commentaire)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_typecontrainte)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Realisee)

*/
