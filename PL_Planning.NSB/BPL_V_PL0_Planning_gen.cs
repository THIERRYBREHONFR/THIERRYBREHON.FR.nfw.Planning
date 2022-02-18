// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:23:04
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
    public class BPL_V_PL0_Planning_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Planning_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Planning.C_UpdateColumnsCount + DPL_V_PL0_Planning.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Planning(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Planning(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Planning)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Abreviation]; // 3 Abreviation string

       public TBfrBusiness BDebut => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Debut]; // 4 Debut DateTime

       public TBfrBusiness BFin => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Fin]; // 5 Fin DateTime

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Planning.C_Id_espaceclient]; // 6 Id_espaceclient long

      
        #endregion

	}
	
    public class BPL_V_PL0_Planning_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Planning_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Planning(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Planning : BPL_V_PL0_Planning_generated
    {
        #region object itself

        public BPL_V_PL0_Planning(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Planning_List : BPL_V_PL0_Planning_List_generated
    {
        #region object itself

        public BPL_V_PL0_Planning_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Planning_Choice_generated : BPL_V_PL0_Planning_generated
    {
        #region object itself

        public BPL_V_PL0_Planning_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Planning_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Planning_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Planning_ChoiceList_generated : BPL_V_PL0_Planning_List_generated
    {
        #region object itself

        public BPL_V_PL0_Planning_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Planning_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Planning_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Planning_Choice : BPL_V_PL0_Planning_Choice_generated
    {
        public BPL_V_PL0_Planning_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Planning_ChoiceList : BPL_V_PL0_Planning_ChoiceList_generated
    {
        public BPL_V_PL0_Planning_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
