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
    public partial class SDBPL_V_DB0_Contrainte : SDBPL_V_DB0_Contrainte_generated
    {
        public SDBPL_V_DB0_Contrainte(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
        // liste des colonnes à la fin de  _gen
         => true
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_planning, DDBPL_V_DB0_Contrainte.C_Ref)
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_planning, DDBPL_V_DB0_Contrainte.C_Abreviation)
           & UniquenessCheck(data_List, errors, iHMObject, DDBPL_V_DB0_Contrainte.C_Id_planning, DDBPL_V_DB0_Contrainte.C_Libelle)
            ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId, TBfrData<int> dRef, TBfrData<string> dAbreviation, TBfrData<string> dLibelle)
        {
            var data_List = new DDBPL_V_DB0_Contrainte(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);
            data_List.DRef.SetValue(dRef);
            data_List.DAbreviation.SetValue(dAbreviation);
            data_List.DLibelle.SetValue(dLibelle);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
      => true
            & new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).NoUseCheckId_contrainte(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Realisation(IStorageAccess).NoUseCheckId_contrainte(id, forPhysicalDelete, iHMObject, errors)
            & new SDBPL_V_DB0_Realisation(IStorageAccess).NoUseCheckId_contrainterealisee(id, forPhysicalDelete, iHMObject, errors)
     ;

        public override int Merge(long oldId, long newId)
        {
            IStorageAccess.Start();
            int bMaj = 0;
            try
            {
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).ReplacementId_contrainte(oldId, newId);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).ReplacementId_contrainte(oldId, newId);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).ReplacementId_contrainterealisee(oldId, newId);

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
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).DeletingId_contrainte(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).DeletingId_contrainte(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).DeletingId_contrainterealisee(id);

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
                bMaj += new SDBPL_V_DB0_CategorieContrainte(IStorageAccess).NeutralizationId_contrainte(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).NeutralizationId_contrainte(id);
                bMaj += new SDBPL_V_DB0_Realisation(IStorageAccess).NeutralizationId_contrainterealisee(id);

                IStorageAccess.Validate();
            }
            catch (Exception e) { IStorageAccess.Cancel(); throw e; }
            return bMaj;
        }

    }
}

