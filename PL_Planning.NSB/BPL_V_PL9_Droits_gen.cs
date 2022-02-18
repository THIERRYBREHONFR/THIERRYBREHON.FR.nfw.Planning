// Généré par GENERATEUR.THIERRYBREHON.FR le 22/12/2021 18:53:05
using System;
using System.Collections.Generic;
using System.Data;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.NSB;
using Planning.NSD;
using Planning.NSS;
namespace Planning.NSB

{
    public class BPL_V_PL9_Droits_generated : TBfrBusiness_ListWithRead
    {
        #region object itself

        public BPL_V_PL9_Droits_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL9_Droits.C_UpdateColumnsCount + DPL_V_PL9_Droits.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL9_Droits_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL9_Droits(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL9_Droits(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL9_Droits)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL9_Droits.C_Id]; // 0 Id long

      
        #endregion

	}
	
    public class BPL_V_PL9_Droits_List_generated : TBfrBusiness_ListWithRead
    {
        #region object itself

        public BPL_V_PL9_Droits_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL9_Droits(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL9_Droits_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL9_Droits : BPL_V_PL9_Droits_generated
    {
        #region object itself

        public BPL_V_PL9_Droits(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL9_Droits(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL9_Droits_List : BPL_V_PL9_Droits_List_generated
    {
        #region object itself

        public BPL_V_PL9_Droits_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL9_Droits_generated(IStorageAccess);

        #endregion

    }


}
