﻿using System;
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
    public partial class SDBPL_V_DB0_Utilisateur : SDBPL_V_DB0_Utilisateur_generated
    {
        public SDBPL_V_DB0_Utilisateur(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
         // liste des colonnes à la fin de  _gen
         => true
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Utilisateur.C_Nom, DDBPL_V_DB0_Utilisateur.C_Prenom, DDBPL_V_DB0_Utilisateur.C_Feminin)
            ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<string> dNom, TBfrData<string> dPrenom, TBfrData<bool> dFeminin)
        {
            var data_List = new DDBPL_V_DB0_Utilisateur(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DNom.SetValue(dNom);
            data_List.DPrenom.SetValue(dPrenom);
            data_List.DFeminin.SetValue(dFeminin);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
      => true
           & new SDBPL_V_DB0_Employe(IStorageAccess).NoUseCheckId_utilisateur(id, forPhysicalDelete, iHMObject, errors)
            ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).ReplacementId_utilisateur(oldId, newId);

                bMaj += base.Merge(oldId, newId);
                IStorageAccess.Validate();
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
            return bMaj;
        }

        public override int Delete(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).DeletingId_utilisateur(id);

                bMaj += base.Delete(id);
                IStorageAccess.Validate();
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
            return bMaj;
        }

        public override int Neutralize(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Employe(IStorageAccess).NeutralizationId_utilisateur(id);

                IStorageAccess.Validate();
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
            return bMaj;
        }






    }
}

