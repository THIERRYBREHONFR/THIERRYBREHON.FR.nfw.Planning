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
    public partial class SDBPL_V_DB0_Realisation : SDBPL_V_DB0_Realisation_generated
    {
        public SDBPL_V_DB0_Realisation(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
          // liste des colonnes à la fin de  _gen
        => true
       ;

        public bool UniquenessCheck(Object iHMObject, TBfrError_List errors, TBfrData<long> dId)
        {
            var data_List = new DDBPL_V_DB0_Realisation(TBfrData_Type.Base, true);
            data_List.DId.SetValue(dId);

            return UniquenessCheck(data_List, iHMObject, errors);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
      => true
       //& new SDBPL_V_DB0_Contrainte(IStorageAccess).NoUseCheck<FOREIGNKEY>(id, forPhysicalDelete, iHMObject, errors)
            ;

       //public override int Merge(long oldId, long newId)
       //{
       //    IStorageAccess.Start();
       //    int bMaj = 0;
       //    try
       //    {
       //        bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).Replacement<FOREIGNKEY>(oldId, newId);
       //
       //        bMaj += base.Merge(oldId, newId);
       //        IStorageAccess.Validate();
       //    }
       //    catch (Exception e) { IStorageAccess.Cancel(); throw e; }
       //    return bMaj;
       //}

        //public override int Delete(long id)
        //{
        //    IStorageAccess.Start();
        //    int bMaj = 0;
        //    try
        //    {
        //        bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).Deleting<FOREIGNKEY>(id);
        //
        //        bMaj += base.Delete(id);
        //        IStorageAccess.Validate();
        //    }
        //    catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        //    return bMaj;
        //}

        //public override int Neutralize(long id)
        //{
        //    IStorageAccess.Start();
        //    int bMaj = 0;
        //    try
        //    {
        //        bMaj += new SDBPL_V_DB0_Contrainte(IStorageAccess).Neutralization<FOREIGNKEY>(id);
        //
        //        IStorageAccess.Validate();
        //    }
        //    catch (Exception e) { IStorageAccess.Cancel(); throw e; }
        //    return bMaj;
        //}


    }
}

