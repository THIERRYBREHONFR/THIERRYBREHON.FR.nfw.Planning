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

    public class SDBPL_V_DB0_Employe_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Employe_generated() : base() { }

        public SDBPL_V_DB0_Employe_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Employe_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Employe = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Employe(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Employe_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Employe", DDBPL_V_DB0_Employe.C_UpdateColumnsCount, DDBPL_V_DB0_Employe.C_AdditionalColumnsCount, DDBPL_V_DB0_Employe.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Employe.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Employe.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Employe.C_Id: return "Id";
                case DDBPL_V_DB0_Employe.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Employe.C_Initiales: return "Initiales";
                case DDBPL_V_DB0_Employe.C_Id_planning: return "Id_planning";
                case DDBPL_V_DB0_Employe.C_Id_espaceclient: return "Id_espaceclient";
                case DDBPL_V_DB0_Employe.C_Nom: return "Nom";
                case DDBPL_V_DB0_Employe.C_Prenom: return "Prenom";
                case DDBPL_V_DB0_Employe.C_Feminin: return "Feminin";
                case DDBPL_V_DB0_Employe.C_Id_utilisateur: return "Id_utilisateur";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Employe.C_Id: return "long";
                case DDBPL_V_DB0_Employe.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Employe.C_Initiales: return "string";
                case DDBPL_V_DB0_Employe.C_Id_planning: return "long";
                case DDBPL_V_DB0_Employe.C_Id_espaceclient: return "long";
                case DDBPL_V_DB0_Employe.C_Nom: return "string";
                case DDBPL_V_DB0_Employe.C_Prenom: return "string";
                case DDBPL_V_DB0_Employe.C_Feminin: return "bool";
                case DDBPL_V_DB0_Employe.C_Id_utilisateur: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }

        #region Id_planning

        public bool NoUseCheckId_planning(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Employe.Object, iHMObject, errors, DDBPL_V_DB0_Employe.C_Id_planning, forPhysicalDelete);

        public int ReplacementId_planning(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Employe.C_Id_planning, OldId, NewId);

        public virtual int DeletingId_planning(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Employe.C_Id_planning, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Employe.C_Id_planning, Id)) vResult += Delete(vId);
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
                int vResult = Neutralization(DDBPL_V_DB0_Employe.C_Id_planning, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Employe.C_Id_planning, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion

        #region Id_utilisateur

        public bool NoUseCheckId_utilisateur(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Employe.Object, iHMObject, errors, DDBPL_V_DB0_Employe.C_Id_utilisateur, forPhysicalDelete);

        public int ReplacementId_utilisateur(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Employe.C_Id_utilisateur, OldId, NewId);

        public virtual int DeletingId_utilisateur(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Employe.C_Id_utilisateur, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Employe.C_Id_utilisateur, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_utilisateur(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Employe.C_Id_utilisateur, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Employe.C_Id_utilisateur, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion



    }
    public partial class SDBPL_V_DB0_Employe : SDBPL_V_DB0_Employe_generated
    {
        //public SDBPL_V_DB0_Employe(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Initiales)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Id_planning)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Nom)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Prenom)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Feminin)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Id_utilisateur)

*/
