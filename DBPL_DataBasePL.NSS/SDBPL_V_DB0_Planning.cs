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
    public partial class SDBPL_V_DB0_Planning : SDBPL_V_DB0_Planning_generated
    {
        public SDBPL_V_DB0_Planning(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
         // liste des colonnes à la fin de  _gen
         => true
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Libelle)
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Planning.C_Abreviation);

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<string> dLibelle, TBfrData<string> dAbreviation)
        {
            var data_List = new DDBPL_V_DB0_Planning(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DLibelle.SetValue(dLibelle);
            data_List.DAbreviation.SetValue(dAbreviation);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
        => true
            //&   new SDBPL_V_DB0_Action(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            //    & new SDBPL_V_DB0_Application(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Contrainte(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Employe(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            //& new SDBPL_V_DB0_Ephemeride(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Equipe(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
              //& new SDBPL_V_DB0_ModeTravail(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
              //& new SDBPL_V_DB0_Projet(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
              //& new SDBPL_V_DB0_Societe(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
              //& new SDBPL_V_DB0_Statut(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_TypeCategorie(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Version(IStorageAccess).NoUseCheckId_planning(id, forPhysicalDelete, iHMObject, errors)
        ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                //bMaj += new SDBPL_V_DB0_Action(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Application(IStorageAccess).ReplacementId_planning(oldId, newId);
                bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).ReplacementId_planning(oldId, newId);
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).ReplacementId_planning(oldId, newId);
                bMaj += new SDBPL_V_DB0_Equipe(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_ModeTravail(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Projet(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Societe(IStorageAccess).ReplacementId_planning(oldId, newId);
                //bMaj += new SDBPL_V_DB0_Statut(IStorageAccess).ReplacementId_planning(oldId, newId);
                bMaj += new SDBPL_V_DB0_Version(IStorageAccess).ReplacementId_planning(oldId, newId);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).ReplacementId_planning(oldId, newId);

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
                //bMaj += new SDBPL_V_DB0_Action(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_Application(IStorageAccess).DeletingId_planning(id);
                bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).DeletingId_planning(id);
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).DeletingId_planning(id);
                bMaj += new SDBPL_V_DB0_Equipe(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_ModeTravail(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_Projet(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_Societe(IStorageAccess).DeletingId_planning(id);
                //bMaj += new SDBPL_V_DB0_Statut(IStorageAccess).DeletingId_planning(id);
                bMaj += new SDBPL_V_DB0_Version(IStorageAccess).DeletingId_planning(id);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).DeletingId_planning(id);

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
                //bMaj += new SDBPL_V_DB0_Action(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_Application(IStorageAccess).NeutralizationId_planning(id);
                bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).NeutralizationId_planning(id);
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_Ephemeride(IStorageAccess).NeutralizationId_planning(id);
                bMaj += new SDBPL_V_DB0_Equipe(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_ModeTravail(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_Projet(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_Societe(IStorageAccess).NeutralizationId_planning(id);
                //bMaj += new SDBPL_V_DB0_Statut(IStorageAccess).NeutralizationId_planning(id);
                bMaj += new SDBPL_V_DB0_Version(IStorageAccess).NeutralizationId_planning(id);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).NeutralizationId_planning(id);

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

