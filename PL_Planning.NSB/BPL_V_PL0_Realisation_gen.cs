// Généré par GENERATEUR.THIERRYBREHON.FR le 24/12/2021 10:23:27
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
    public class BPL_V_PL0_Realisation_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Realisation_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Realisation.C_UpdateColumnsCount + DPL_V_PL0_Realisation.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Realisation(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Realisation(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Realisation)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Id]; // 0 Id long

       public TBfrBusiness BDebut => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Debut]; // 1 Debut DateTime

       public TBfrBusiness BId_employe => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Id_employe]; // 2 Id_employe long

       public TBfrBusiness BDuree => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Duree]; // 3 Duree int

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Logicaldeleted]; // 4 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Id_espaceclient]; // 5 Id_espaceclient long

       public TBfrBusiness BId_contrainterealisee => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Id_contrainterealisee]; // 6 Id_contrainterealisee long

       public TBfrBusiness BId_contrainte => (TBfrBusiness)this[DPL_V_PL0_Realisation.C_Id_contrainte]; // 7 Id_contrainte long

      
        #endregion

	}
	
    public class BPL_V_PL0_Realisation_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Realisation_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Realisation(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Realisation : BPL_V_PL0_Realisation_generated
    {
        #region object itself

        public BPL_V_PL0_Realisation(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Realisation_List : BPL_V_PL0_Realisation_List_generated
    {
        #region object itself

        public BPL_V_PL0_Realisation_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Realisation_Choice_generated : BPL_V_PL0_Realisation_generated
    {
        #region object itself

        public BPL_V_PL0_Realisation_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Realisation_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Realisation_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Realisation_ChoiceList_generated : BPL_V_PL0_Realisation_List_generated
    {
        #region object itself

        public BPL_V_PL0_Realisation_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Realisation_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Realisation_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Realisation_Choice : BPL_V_PL0_Realisation_Choice_generated
    {
        public BPL_V_PL0_Realisation_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Realisation_ChoiceList : BPL_V_PL0_Realisation_ChoiceList_generated
    {
        public BPL_V_PL0_Realisation_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
