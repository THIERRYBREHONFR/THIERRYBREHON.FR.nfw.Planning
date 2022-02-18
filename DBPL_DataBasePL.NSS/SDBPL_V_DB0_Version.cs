using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.NSR;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.SERVICE.NSS;
using DataBasePL.NSR;
using DataBasePL.NSD;

namespace DataBasePL.NSS
{
    public partial class SDBPL_V_DB0_Version : SDBPL_V_DB0_Version_generated
    {
        public SDBPL_V_DB0_Version(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
         // liste des colonnes à la fin de  _gen
         => true
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Version.C_Libelle, DDBPL_V_DB0_Version.C_Id_planning)
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Version.C_Abreviation, DDBPL_V_DB0_Version.C_Id_planning)
            ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<long> dId_planning, TBfrData<string> dLibelle, TBfrData<string> dAbreviation)
        {
            var data_List = new DDBPL_V_DB0_Version(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DId_planning.SetValue(dId_planning);
            data_List.DLibelle.SetValue(dLibelle);
            data_List.DAbreviation.SetValue(dAbreviation);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
        => true
          // & new SDBPL_V_DB0_AdminVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
          // & new SDBPL_V_DB0_CongeVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
          // & new SDBPL_V_DB0_Ephemeride(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
          & new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
        //& new SDBPL_V_DB0_Planification(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
        //& new SDBPL_V_DB0_ReunionVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
        //& new SDBPL_V_DB0_TacheVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
        //& new SDBPL_V_DB0_RecapVersion(IStorageAccess).NoUseCheckId_version(id, forPhysicalDelete, iHMObject, errors)
        ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                //bMaj += new SDBPL_V_DB0_AdminVersion(IStorageAccess).ReplacementId_version(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).ReplacementId_version(oldId, newId);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).ReplacementId_version(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).ReplacementId_version(oldId, newId);
                //bMaj += new SDBPL_V_DB0_ReunionVersion(IStorageAccess).ReplacementId_version(oldId, newId);
                //bMaj += new SDBPL_V_DB0_TacheVersion(IStorageAccess).ReplacementId_version(oldId, newId);
                //bMaj += new SDBPL_V_DB0_RecapVersion(IStorageAccess).ReplacementId_version(oldId, newId);

                bMaj += base.Merge(oldId, newId);
                IStorageAccess.Validate();

            }
            catch (Exception e)
            {
                IStorageAccess.Cancel();
                throw e;
            }
            return bMaj;
        }
        public override int Delete(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                //bMaj += new SDBPL_V_DB0_AdminVersion(IStorageAccess).DeletingId_version(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).DeletingId_version(id);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).DeletingId_version(id);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).DeletingId_version(id);
                //bMaj += new SDBPL_V_DB0_ReunionVersion(IStorageAccess).DeletingId_version(id);
                //bMaj += new SDBPL_V_DB0_TacheVersion(IStorageAccess).DeletingId_version(id);
                //bMaj += new SDBPL_V_DB0_RecapVersion(IStorageAccess).DeletingId_version(id);

                bMaj += base.Delete(id);
                IStorageAccess.Validate();
            }
            catch (Exception e)
            {
                IStorageAccess.Cancel();
                throw e;
            }
            return bMaj;
        }

        public override int Neutralize(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                //bMaj += new SDBPL_V_DB0_AdminVersion(IStorageAccess).NeutralizationId_version(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).NeutralizationId_version(id);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).NeutralizationId_version(id);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).NeutralizationId_version(id);
                //bMaj += new SDBPL_V_DB0_ReunionVersion(IStorageAccess).NeutralizationId_version(id);
                //bMaj += new SDBPL_V_DB0_TacheVersion(IStorageAccess).NeutralizationId_version(id);
                //bMaj += new SDBPL_V_DB0_RecapVersion(IStorageAccess).NeutralizationId_version(id);

                IStorageAccess.Validate();
            }
            catch (Exception e)
            {
                IStorageAccess.Cancel();
                throw e;
            }
            return bMaj;
        }

    }
}

