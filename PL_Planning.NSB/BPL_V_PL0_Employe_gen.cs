// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 11:25:17
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
    public class BPL_V_PL0_Employe_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Employe_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Employe.C_UpdateColumnsCount + DPL_V_PL0_Employe.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Employe(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Employe(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Employe)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BInitiales => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Initiales]; // 2 Initiales string

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Id_espaceclient]; // 4 Id_espaceclient long

       public TBfrBusiness BNom => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Nom]; // 5 Nom string

       public TBfrBusiness BPrenom => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Prenom]; // 6 Prenom string

       public TBfrBusiness BFeminin => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Feminin]; // 7 Feminin bool

       public TBfrBusiness BId_utilisateur => (TBfrBusiness)this[DPL_V_PL0_Employe.C_Id_utilisateur]; // 8 Id_utilisateur long

      
        #endregion

	}
	
    public class BPL_V_PL0_Employe_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Employe_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Employe(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Employe : BPL_V_PL0_Employe_generated
    {
        #region object itself

        public BPL_V_PL0_Employe(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Employe_List : BPL_V_PL0_Employe_List_generated
    {
        #region object itself

        public BPL_V_PL0_Employe_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Employe_Choice_generated : BPL_V_PL0_Employe_generated
    {
        #region object itself

        public BPL_V_PL0_Employe_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Employe_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Employe_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Employe_ChoiceList_generated : BPL_V_PL0_Employe_List_generated
    {
        #region object itself

        public BPL_V_PL0_Employe_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Employe_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Employe_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Employe_Choice : BPL_V_PL0_Employe_Choice_generated
    {
        public BPL_V_PL0_Employe_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Employe_ChoiceList : BPL_V_PL0_Employe_ChoiceList_generated
    {
        public BPL_V_PL0_Employe_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
