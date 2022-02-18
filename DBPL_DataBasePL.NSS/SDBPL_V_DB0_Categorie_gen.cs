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

    public class SDBPL_V_DB0_Categorie_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Categorie_generated() : base() { }

        public SDBPL_V_DB0_Categorie_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Categorie_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Categorie = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Categorie(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Categorie_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Categorie", DDBPL_V_DB0_Categorie.C_UpdateColumnsCount, DDBPL_V_DB0_Categorie.C_AdditionalColumnsCount, DDBPL_V_DB0_Categorie.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Categorie.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Categorie.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Categorie.C_Id: return "Id";
                case DDBPL_V_DB0_Categorie.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Categorie.C_Id_espaceclient: return "Id_espaceclient";
                case DDBPL_V_DB0_Categorie.C_Id_typecategorie: return "Id_typecategorie";
                case DDBPL_V_DB0_Categorie.C_Libelle: return "Libelle";
                case DDBPL_V_DB0_Categorie.C_Ordreaff: return "Ordreaff";
                case DDBPL_V_DB0_Categorie.C_Id_mere: return "Id_mere";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Categorie.C_Id: return "long";
                case DDBPL_V_DB0_Categorie.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Categorie.C_Id_espaceclient: return "long";
                case DDBPL_V_DB0_Categorie.C_Id_typecategorie: return "long";
                case DDBPL_V_DB0_Categorie.C_Libelle: return "string";
                case DDBPL_V_DB0_Categorie.C_Ordreaff: return "int";
                case DDBPL_V_DB0_Categorie.C_Id_mere: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }

        #region Id_typecategorie

        public bool NoUseCheckId_typecategorie(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Categorie.Object, iHMObject, errors, DDBPL_V_DB0_Categorie.C_Id_typecategorie, forPhysicalDelete);

        public int ReplacementId_typecategorie(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Categorie.C_Id_typecategorie, OldId, NewId);

        public virtual int DeletingId_typecategorie(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Categorie.C_Id_typecategorie, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Categorie.C_Id_typecategorie, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_typecategorie(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Categorie.C_Id_typecategorie, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Categorie.C_Id_typecategorie, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion

        #region Id_mere

        public bool NoUseCheckId_mere(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Categorie.Object, iHMObject, errors, DDBPL_V_DB0_Categorie.C_Id_mere, forPhysicalDelete);

        public int ReplacementId_mere(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Categorie.C_Id_mere, OldId, NewId);

        public virtual int DeletingId_mere(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Categorie.C_Id_mere, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Categorie.C_Id_mere, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_mere(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Categorie.C_Id_mere, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Categorie.C_Id_mere, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion



    }
    public partial class SDBPL_V_DB0_Categorie : SDBPL_V_DB0_Categorie_generated
    {
        //public SDBPL_V_DB0_Categorie(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Id_typecategorie)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Libelle)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Ordreaff)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Id_mere)

*/
