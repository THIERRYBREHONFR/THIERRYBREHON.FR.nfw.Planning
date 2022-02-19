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
    public partial class SDBPL_V_DB0_TypeCategorie : SDBPL_V_DB0_TypeCategorie_generated
    {
        public SDBPL_V_DB0_TypeCategorie(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
         // liste des colonnes à la fin de  _gen
         => true
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_TypeCategorie.C_Id_planning, DDBPL_V_DB0_TypeCategorie.C_Libelle)
     ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<long> dId_planning, TBfrData<string> dLibelle)
        {
            var data_List = new DDBPL_V_DB0_TypeCategorie(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DId_planning.SetValue(dId_planning);
            data_List.DLibelle.SetValue(dLibelle);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
      => true
       & new SDBPL_V_DB0_Categorie(IStorageAccess).NoUseCheckId_typecategorie(id, forPhysicalDelete, iHMObject, errors)
       & new SDBPL_V_DB0_TypeCategorie(IStorageAccess).NoUseCheckId_mere(id, forPhysicalDelete, iHMObject, errors)
            ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Categorie(IStorageAccess).ReplacementId_typecategorie(oldId, newId);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).ReplacementId_mere(oldId, newId);

                bMaj += base.Merge(oldId, newId);
                IStorageAccess.Validate();
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
            return bMaj;
        }

        public override int Delete(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Categorie(IStorageAccess).DeletingId_typecategorie(id);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).DeletingId_mere(id);

                bMaj += base.Delete(id);
                IStorageAccess.Validate();
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
            return bMaj;
        }

        public override int Neutralize(long id)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_Categorie(IStorageAccess).NeutralizationId_typecategorie(id);
                bMaj += new SDBPL_V_DB0_TypeCategorie(IStorageAccess).NeutralizationId_mere(id);

                IStorageAccess.Validate();
            }
            catch (Exception) { IStorageAccess.Cancel(); throw; }
            return bMaj;
        }

    }
}

