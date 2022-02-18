// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 09:14:42
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
    public class BPL_V_PL0_Equipe_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Equipe_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Equipe.C_UpdateColumnsCount + DPL_V_PL0_Equipe.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Equipe(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Equipe(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Equipe)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Abreviation]; // 3 Abreviation string

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Id_planning]; // 4 Id_planning long

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Equipe.C_Id_espaceclient]; // 5 Id_espaceclient long

      
        #endregion

	}
	
    public class BPL_V_PL0_Equipe_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Equipe_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Equipe(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Equipe : BPL_V_PL0_Equipe_generated
    {
        #region object itself

        public BPL_V_PL0_Equipe(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Equipe_List : BPL_V_PL0_Equipe_List_generated
    {
        #region object itself

        public BPL_V_PL0_Equipe_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Equipe_Choice_generated : BPL_V_PL0_Equipe_generated
    {
        #region object itself

        public BPL_V_PL0_Equipe_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Equipe_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Equipe_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Equipe_ChoiceList_generated : BPL_V_PL0_Equipe_List_generated
    {
        #region object itself

        public BPL_V_PL0_Equipe_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Equipe_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Equipe_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Equipe_Choice : BPL_V_PL0_Equipe_Choice_generated
    {
        public BPL_V_PL0_Equipe_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Equipe_ChoiceList : BPL_V_PL0_Equipe_ChoiceList_generated
    {
        public BPL_V_PL0_Equipe_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
