// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:22:49
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
    public class BPL_V_PL0_Contrainte_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Contrainte_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Contrainte.C_UpdateColumnsCount + DPL_V_PL0_Contrainte.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Contrainte(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Contrainte(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Contrainte)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BRef => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Ref]; // 4 Ref int

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Abreviation]; // 5 Abreviation string

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Libelle]; // 6 Libelle string

       public TBfrBusiness BCommentaire => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Commentaire]; // 7 Commentaire string

       public TBfrBusiness BId_typecontrainte => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Id_typecontrainte]; // 8 Id_typecontrainte long

       public TBfrBusiness BRealisee => (TBfrBusiness)this[DPL_V_PL0_Contrainte.C_Realisee]; // 9 Realisee bool

      
        #endregion

	}
	
    public class BPL_V_PL0_Contrainte_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Contrainte_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Contrainte(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Contrainte : BPL_V_PL0_Contrainte_generated
    {
        #region object itself

        public BPL_V_PL0_Contrainte(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Contrainte_List : BPL_V_PL0_Contrainte_List_generated
    {
        #region object itself

        public BPL_V_PL0_Contrainte_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Contrainte_Choice_generated : BPL_V_PL0_Contrainte_generated
    {
        #region object itself

        public BPL_V_PL0_Contrainte_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Contrainte_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Contrainte_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Contrainte_ChoiceList_generated : BPL_V_PL0_Contrainte_List_generated
    {
        #region object itself

        public BPL_V_PL0_Contrainte_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Contrainte_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Contrainte_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Contrainte_Choice : BPL_V_PL0_Contrainte_Choice_generated
    {
        public BPL_V_PL0_Contrainte_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Contrainte_ChoiceList : BPL_V_PL0_Contrainte_ChoiceList_generated
    {
        public BPL_V_PL0_Contrainte_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
