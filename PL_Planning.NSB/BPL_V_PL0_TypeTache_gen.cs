// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:26:46
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
    public class BPL_V_PL0_TypeTache_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_TypeTache_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_TypeTache.C_UpdateColumnsCount + DPL_V_PL0_TypeTache.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_TypeTache(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_TypeTache(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_TypeTache)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_TypeTache.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_TypeTache.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_TypeTache.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_TypeTache.C_Id_espaceclient]; // 3 Id_espaceclient long

      
        #endregion

	}
	
    public class BPL_V_PL0_TypeTache_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_TypeTache_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_TypeTache(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeTache : BPL_V_PL0_TypeTache_generated
    {
        #region object itself

        public BPL_V_PL0_TypeTache(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeTache_List : BPL_V_PL0_TypeTache_List_generated
    {
        #region object itself

        public BPL_V_PL0_TypeTache_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_TypeTache_Choice_generated : BPL_V_PL0_TypeTache_generated
    {
        #region object itself

        public BPL_V_PL0_TypeTache_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_TypeTache_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_TypeTache_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_TypeTache_ChoiceList_generated : BPL_V_PL0_TypeTache_List_generated
    {
        #region object itself

        public BPL_V_PL0_TypeTache_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_TypeTache_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeTache_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeTache_Choice : BPL_V_PL0_TypeTache_Choice_generated
    {
        public BPL_V_PL0_TypeTache_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_TypeTache_ChoiceList : BPL_V_PL0_TypeTache_ChoiceList_generated
    {
        public BPL_V_PL0_TypeTache_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
