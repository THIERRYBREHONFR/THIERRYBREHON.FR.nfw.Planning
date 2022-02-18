using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.NSR;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.SERVICE.NSS;
using Planning.NSR;
using Planning.NSD;
using DataBasePL.NSS;
namespace Planning.NSS
{
    public partial class SPL_V_PL0_Contrainte : SPL_V_PL0_Contrainte_generated
    {
        public SPL_V_PL0_Contrainte(ITBfrStorageAccess storageAccess) : base(storageAccess) { }

        public override bool UniquenessCheck(TBfrData_List data_List, Object iHMObject, TBfrError_List errors)
        {
            var vData_List = (DPL_V_PL0_Contrainte)data_List;
            return new SDBPL_V_DB0_Contrainte(IStorageAccess).UniquenessCheck(iHMObject, errors, vData_List.DId, vData_List.DRef, vData_List.DAbreviation, vData_List.DLibelle);
        }

        public override bool NotUsedCheck(long id, bool forPhysicalDelete, object iHMObject, TBfrError_List errors)
           => new SDBPL_V_DB0_Contrainte(IStorageAccess).NotUsedCheck(id, forPhysicalDelete, iHMObject, errors);

        public override int Merge(long oldId, long newId)
           => new SDBPL_V_DB0_Contrainte(IStorageAccess).Merge(oldId, newId);

        public override int Delete(long id)
           => new SDBPL_V_DB0_Contrainte(IStorageAccess).Delete(id);

        public override int Neutralize(long id)
           => new SDBPL_V_DB0_Contrainte(IStorageAccess).Neutralize(id);

        protected override string ViewName(int view)
        {
            string vResult = base.ViewName(view);
            switch (view)
            {
                case TBfrConst.NInsertView:
                case TBfrConst.NUpdateView:
                case TBfrConst.NDeleteView: { vResult += "_W"; break; }
            }
            return vResult;
        }




    }
}

