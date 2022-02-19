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

    public class SDBPL_V_DB0_EquipeEmployeVersion_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_EquipeEmployeVersion_generated() : base() { }

        public SDBPL_V_DB0_EquipeEmployeVersion_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_EquipeEmployeVersion_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_EquipeEmployeVersion = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_EquipeEmployeVersion(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_EquipeEmployeVersion_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_EquipeEmployeVersion", DDBPL_V_DB0_EquipeEmployeVersion.C_UpdateColumnsCount, DDBPL_V_DB0_EquipeEmployeVersion.C_AdditionalColumnsCount, DDBPL_V_DB0_EquipeEmployeVersion.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_EquipeEmployeVersion.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_EquipeEmployeVersion.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id: return "Id";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version: return "Id_version";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe: return "Id_equipe";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe: return "Id_employe";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_espaceclient: return "Id_espaceclient";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id: return "long";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version: return "long";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe: return "long";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe: return "long";
                case DDBPL_V_DB0_EquipeEmployeVersion.C_Id_espaceclient: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }

        #region Id_version

        public bool NoUseCheckId_version(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_EquipeEmployeVersion.Object, iHMObject, errors, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, forPhysicalDelete);

        public int ReplacementId_version(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, OldId, NewId);

        public virtual int DeletingId_version(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }
        
        public virtual int NeutralizationId_version(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }

        #endregion

        #region Id_equipe

        public bool NoUseCheckId_equipe(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_EquipeEmployeVersion.Object, iHMObject, errors, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, forPhysicalDelete);

        public int ReplacementId_equipe(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, OldId, NewId);

        public virtual int DeletingId_equipe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }
        
        public virtual int NeutralizationId_equipe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }

        #endregion

        #region Id_employe

        public bool NoUseCheckId_employe(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_EquipeEmployeVersion.Object, iHMObject, errors, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, forPhysicalDelete);

        public int ReplacementId_employe(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, OldId, NewId);

        public virtual int DeletingId_employe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }
        
        public virtual int NeutralizationId_employe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
        }

        #endregion



    }
    public partial class SDBPL_V_DB0_EquipeEmployeVersion : SDBPL_V_DB0_EquipeEmployeVersion_generated
    {
        //public SDBPL_V_DB0_EquipeEmployeVersion(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_version)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_equipe)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_employe)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_EquipeEmployeVersion.C_Id_espaceclient)

*/
