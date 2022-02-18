// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:02
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
    public class BPL_V_PL0_CategorieContrainte_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_CategorieContrainte_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_CategorieContrainte.C_UpdateColumnsCount + DPL_V_PL0_CategorieContrainte.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_CategorieContrainte_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_CategorieContrainte(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_CategorieContrainte(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_CategorieContrainte)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_CategorieContrainte.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_CategorieContrainte.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_CategorieContrainte.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_categorie => (TBfrBusiness)this[DPL_V_PL0_CategorieContrainte.C_Id_categorie]; // 3 Id_categorie long

       public TBfrBusiness BId_contrainte => (TBfrBusiness)this[DPL_V_PL0_CategorieContrainte.C_Id_contrainte]; // 4 Id_contrainte long

      
        #endregion

	}
	
    public class BPL_V_PL0_CategorieContrainte_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_CategorieContrainte_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_CategorieContrainte(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_CategorieContrainte_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_CategorieContrainte : BPL_V_PL0_CategorieContrainte_generated
    {
        #region object itself

        public BPL_V_PL0_CategorieContrainte(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_CategorieContrainte(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_CategorieContrainte_List : BPL_V_PL0_CategorieContrainte_List_generated
    {
        #region object itself

        public BPL_V_PL0_CategorieContrainte_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_CategorieContrainte_generated(IStorageAccess);

        #endregion

    }


}
