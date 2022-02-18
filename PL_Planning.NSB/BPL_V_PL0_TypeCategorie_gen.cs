// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:24:11
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
    public class BPL_V_PL0_TypeCategorie_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_TypeCategorie.C_UpdateColumnsCount + DPL_V_PL0_TypeCategorie.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_TypeCategorie(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_TypeCategorie(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_TypeCategorie)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BId_mere => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Id_mere]; // 4 Id_mere long

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_TypeCategorie.C_Libelle]; // 5 Libelle string

      
        #endregion

	}
	
    public class BPL_V_PL0_TypeCategorie_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_TypeCategorie(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeCategorie : BPL_V_PL0_TypeCategorie_generated
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeCategorie_List : BPL_V_PL0_TypeCategorie_List_generated
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_TypeCategorie_Choice_generated : BPL_V_PL0_TypeCategorie_generated
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_TypeCategorie_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_TypeCategorie_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_TypeCategorie_ChoiceList_generated : BPL_V_PL0_TypeCategorie_List_generated
    {
        #region object itself

        public BPL_V_PL0_TypeCategorie_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_TypeCategorie_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_TypeCategorie_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_TypeCategorie_Choice : BPL_V_PL0_TypeCategorie_Choice_generated
    {
        public BPL_V_PL0_TypeCategorie_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_TypeCategorie_ChoiceList : BPL_V_PL0_TypeCategorie_ChoiceList_generated
    {
        public BPL_V_PL0_TypeCategorie_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
