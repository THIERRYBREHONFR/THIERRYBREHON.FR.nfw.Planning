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

    public class SDBPL_V_DB0_Realisation_generated : TBfrStorageSqlUpdateView

    {

        // public SDBPL_V_DB0_Realisation_generated() : base() { }

        public SDBPL_V_DB0_Realisation_generated(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }

        public SDBPL_V_DB0_Realisation_generated(ITBfrStorageAccess iTBfrStorageAccess, ITBfrStorageTrace iTBfrStorageTrace, ITBfrStorageNextId iTBfrStorageNextId) : base(iTBfrStorageAccess, iTBfrStorageTrace, iTBfrStorageNextId) { }

        protected const int C_NViewV_DB0_Realisation = 0;

        protected override TBfrData_List NewTBfrData(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Realisation(tBfrData_Type, withChildren); 



        protected override TBfrData_List NewTBfrData_List(TBfrData_Type tBfrData_Type, bool withChildren) => new DDBPL_V_DB0_Realisation_List(tBfrData_Type, withChildren); 
     


        protected override void Initialize() 
        {
           Initialize("V_DB0_Realisation", DDBPL_V_DB0_Realisation.C_UpdateColumnsCount, DDBPL_V_DB0_Realisation.C_AdditionalColumnsCount, DDBPL_V_DB0_Realisation.C_Id); 
              pLogicalDeletedColumn = DDBPL_V_DB0_Realisation.C_Logicaldeleted;

              pId_espaceclientColumn = DDBPL_V_DB0_Realisation.C_Id_espaceclient;
       
        }

        protected override string RawDbNameColumn(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Realisation.C_Id: return "Id";
                case DDBPL_V_DB0_Realisation.C_Debut: return "Debut";
                case DDBPL_V_DB0_Realisation.C_Id_employe: return "Id_employe";
                case DDBPL_V_DB0_Realisation.C_Duree: return "Duree";
                case DDBPL_V_DB0_Realisation.C_Logicaldeleted: return "Logicaldeleted";
                case DDBPL_V_DB0_Realisation.C_Id_espaceclient: return "Id_espaceclient";
                case DDBPL_V_DB0_Realisation.C_Id_contrainterealisee: return "Id_contrainterealisee";
                case DDBPL_V_DB0_Realisation.C_Id_contrainte: return "Id_contrainte";

                case -1: return null;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        protected override string SqlColumnType(short column)
        {
            switch (column)
            {
                case DDBPL_V_DB0_Realisation.C_Id: return "long";
                case DDBPL_V_DB0_Realisation.C_Debut: return "DateTime";
                case DDBPL_V_DB0_Realisation.C_Id_employe: return "long";
                case DDBPL_V_DB0_Realisation.C_Duree: return "int";
                case DDBPL_V_DB0_Realisation.C_Logicaldeleted: return "bool";
                case DDBPL_V_DB0_Realisation.C_Id_espaceclient: return "long";
                case DDBPL_V_DB0_Realisation.C_Id_contrainterealisee: return "long";
                case DDBPL_V_DB0_Realisation.C_Id_contrainte: return "long";

                default: throw new ArgumentOutOfRangeException();
            }
        }

        #region Id_employe

        public bool NoUseCheckId_employe(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Realisation.Object, iHMObject, errors, DDBPL_V_DB0_Realisation.C_Id_employe, forPhysicalDelete);

        public int ReplacementId_employe(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Realisation.C_Id_employe, OldId, NewId);

        public virtual int DeletingId_employe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Realisation.C_Id_employe, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_employe, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_employe(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Realisation.C_Id_employe, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_employe, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion

        #region Id_contrainterealisee

        public bool NoUseCheckId_contrainterealisee(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Realisation.Object, iHMObject, errors, DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, forPhysicalDelete);

        public int ReplacementId_contrainterealisee(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, OldId, NewId);

        public virtual int DeletingId_contrainterealisee(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_contrainterealisee(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_contrainterealisee, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion

        #region Id_contrainte

        public bool NoUseCheckId_contrainte(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => base.NotUsedCheck(id, RDBPL_V_DB0_Realisation.Object, iHMObject, errors, DDBPL_V_DB0_Realisation.C_Id_contrainte, forPhysicalDelete);

        public int ReplacementId_contrainte(long OldId, long NewId) => ReplaceId(DDBPL_V_DB0_Realisation.C_Id_contrainte, OldId, NewId);

        public virtual int DeletingId_contrainte(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Delete(DDBPL_V_DB0_Realisation.C_Id_contrainte, Id);;
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_contrainte, Id)) vResult += Delete(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }
        
        public virtual int NeutralizationId_contrainte(long Id)
        {
            IStorageAccess.Start();
            try
            {
                int vResult = Neutralization(DDBPL_V_DB0_Realisation.C_Id_contrainte, Id);
                foreach (var vId in IdsList(DDBPL_V_DB0_Realisation.C_Id_contrainte, Id)) vResult += Neutralize(vId);
                IStorageAccess.Validate();
                return vResult;
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        }

        #endregion



    }
    public partial class SDBPL_V_DB0_Realisation : SDBPL_V_DB0_Realisation_generated
    {
        //public SDBPL_V_DB0_Realisation(ITBfrStorageAccess storageAccess) : base(storageAccess, new SSERV_V_SERV0_TraceSql(storageAccess.IServiceStorageAccess), new SSERV_V_SERV0_Ids(storageAccess.IServiceStorageAccess)) { }



    }
}
/*
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Id)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Debut)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Id_employe)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Duree)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Logicaldeleted)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Id_espaceclient)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Id_contrainterealisee)
            // & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Realisation.C_Id_contrainte)

*/
