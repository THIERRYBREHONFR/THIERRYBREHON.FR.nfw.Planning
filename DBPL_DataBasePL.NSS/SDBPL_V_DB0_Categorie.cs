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
    public partial class SDBPL_V_DB0_Categorie : SDBPL_V_DB0_Categorie_generated
    {
        public SDBPL_V_DB0_Categorie(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
        // liste des colonnes à la fin de  _gen
         => true
            & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Categorie.C_Id_typecategorie, DDBPL_V_DB0_Categorie.C_Libelle)
        ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<long> dId_typecategorie, TBfrData<string> dLibelle)
        {
            var data_List = new DDBPL_V_DB0_Categorie(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DId_typecategorie.SetValue(dId_typecategorie);
            data_List.DLibelle.SetValue(dLibelle);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).NoUseCheckId_categorie(id, forPhysicalDelete, iHMObject, errors)
            ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).ReplacementId_categorie(oldId, newId);

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
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).DeletingId_categorie(id);

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
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).NeutralizationId_categorie(id);

                IStorageAccess.Validate();
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
            return bMaj;
        }

    }
}

