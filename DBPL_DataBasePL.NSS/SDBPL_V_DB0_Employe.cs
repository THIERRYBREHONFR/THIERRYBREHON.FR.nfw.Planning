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
    public partial class SDBPL_V_DB0_Employe : SDBPL_V_DB0_Employe_generated
    {
        public SDBPL_V_DB0_Employe(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
        // liste des colonnes à la fin de  _gen
         => true
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Initiales, DDBPL_V_DB0_Employe.C_Id_planning)
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Employe.C_Nom, DDBPL_V_DB0_Employe.C_Prenom, DDBPL_V_DB0_Employe.C_Feminin, DDBPL_V_DB0_Employe.C_Id_planning);

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<long> dId_planning, TBfrData<string> dInitiales, TBfrData<string> dNom, TBfrData<string> dPrenom, TBfrData<bool> dFeminin)
        {
            var data_List = new DDBPL_V_DB0_Employe(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DId_planning.SetValue(dId_planning);
            data_List.DInitiales.SetValue(dInitiales);
            data_List.DNom.SetValue(dNom);
            data_List.DPrenom.SetValue(dPrenom);
            data_List.DFeminin.SetValue(dFeminin);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
            => true 
            // &new SDBPL_V_DB0_Ephemeride(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
             &new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            //& new SDBPL_V_DB0_Planification(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Realisation(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            //& new SDBPL_V_DB0_ReunionEmploye(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            //& new SDBPL_V_DB0_Admin(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            //& new SDBPL_V_DB0_TacheEmploye(IStorageAccess).NoUseCheckId_employe(id, forPhysicalDelete, iHMObject, errors)
            ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                //bMaj += new SDBPL_V_DB0_CongeEmploye(IStorageAccess).ReplacementId_employe(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).ReplacementId_employe(oldId, newId);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).ReplacementId_employe(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).ReplacementId_employe(oldId, newId);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).ReplacementId_employe(oldId, newId);
                //bMaj += new SDBPL_V_DB0_ReunionEmploye(IStorageAccess).ReplacementId_employe(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Admin(IStorageAccess).ReplacementId_employe(oldId, newId);
                //bMaj += new SDBPL_V_DB0_TacheEmploye(IStorageAccess).ReplacementId_employe(oldId, newId);

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
                //bMaj += new SDBPL_V_DB0_CongeEmploye(IStorageAccess).DeletingId_employe(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).DeletingId_employe(id);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).DeletingId_employe(id);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).DeletingId_employe(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).DeletingId_employe(id);
                //bMaj += new SDBPL_V_DB0_ReunionEmploye(IStorageAccess).DeletingId_employe(id);
                //bMaj += new SDBPL_V_DB0_Admin(IStorageAccess).DeletingId_employe(id);
                //bMaj += new SDBPL_V_DB0_TacheEmploye(IStorageAccess).DeletingId_employe(id);

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
                //bMaj += new SDBPL_V_DB0_CongeEmploye(IStorageAccess).NeutralizationId_employe(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).NeutralizationId_employe(id);
                bMaj += new SDBPL_V_DB0_EquipeEmployeVersion(IStorageAccess).NeutralizationId_employe(id);
                //bMaj += new SDBPL_V_DB0_Planification(IStorageAccess).NeutralizationId_employe(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).NeutralizationId_employe(id);
                //bMaj += new SDBPL_V_DB0_ReunionEmploye(IStorageAccess).NeutralizationId_employe(id);
                //bMaj += new SDBPL_V_DB0_Admin(IStorageAccess).NeutralizationId_employe(id);
                //bMaj += new SDBPL_V_DB0_TacheEmploye(IStorageAccess).NeutralizationId_employe(id);

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

