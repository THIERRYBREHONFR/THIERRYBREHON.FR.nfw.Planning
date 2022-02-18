// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 15:53:24
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
    public class BPL_V_PL0_Categorie_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Categorie_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Categorie.C_UpdateColumnsCount + DPL_V_PL0_Categorie.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Categorie(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Categorie(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Categorie)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_typecategorie => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Id_typecategorie]; // 3 Id_typecategorie long

       public TBfrBusiness BId_mere => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Id_mere]; // 4 Id_mere long

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Libelle]; // 5 Libelle string

       public TBfrBusiness BOrdreaff => (TBfrBusiness)this[DPL_V_PL0_Categorie.C_Ordreaff]; // 6 Ordreaff int

      
        #endregion

	}
	
    public class BPL_V_PL0_Categorie_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Categorie_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Categorie(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Categorie : BPL_V_PL0_Categorie_generated
    {
        #region object itself

        public BPL_V_PL0_Categorie(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Categorie_List : BPL_V_PL0_Categorie_List_generated
    {
        #region object itself

        public BPL_V_PL0_Categorie_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Categorie_Choice_generated : BPL_V_PL0_Categorie_generated
    {
        #region object itself

        public BPL_V_PL0_Categorie_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Categorie_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Categorie_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Categorie_ChoiceList_generated : BPL_V_PL0_Categorie_List_generated
    {
        #region object itself

        public BPL_V_PL0_Categorie_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Categorie_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Categorie_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Categorie_Choice : BPL_V_PL0_Categorie_Choice_generated
    {
        public BPL_V_PL0_Categorie_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Categorie_ChoiceList : BPL_V_PL0_Categorie_ChoiceList_generated
    {
        public BPL_V_PL0_Categorie_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
