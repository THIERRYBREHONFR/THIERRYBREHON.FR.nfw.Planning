// Généré par GENERATEUR.THIERRYBREHON.FR le 23/12/2021 09:13:59
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
    public class BPL_V_PL0_Utilisateur_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Utilisateur_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DPL_V_PL0_Utilisateur.C_UpdateColumnsCount + DPL_V_PL0_Utilisateur.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Utilisateur(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SPL_V_PL0_Utilisateur(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Utilisateur)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BModif => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Modif]; // 2 Modif bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Id_espaceclient]; // 3 Id_espaceclient long

       public TBfrBusiness BNom => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Nom]; // 4 Nom string

       public TBfrBusiness BPrenom => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Prenom]; // 5 Prenom string

       public TBfrBusiness BFeminin => (TBfrBusiness)this[DPL_V_PL0_Utilisateur.C_Feminin]; // 6 Feminin bool

      
        #endregion

	}
	
    public class BPL_V_PL0_Utilisateur_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BPL_V_PL0_Utilisateur_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BPL_V_PL0_Utilisateur(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Utilisateur : BPL_V_PL0_Utilisateur_generated
    {
        #region object itself

        public BPL_V_PL0_Utilisateur(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Utilisateur_List : BPL_V_PL0_Utilisateur_List_generated
    {
        #region object itself

        public BPL_V_PL0_Utilisateur_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur_generated(IStorageAccess);

        #endregion

    }

    public class BPL_V_PL0_Utilisateur_Choice_generated : BPL_V_PL0_Utilisateur_generated
    {
        #region object itself

        public BPL_V_PL0_Utilisateur_Choice_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur_Choice_generated(IStorageAccess);

        #endregion

        #region associated objects

        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DPL_V_PL0_Utilisateur_Choice(type, withChildren);

        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DPL_V_PL0_Utilisateur_Choice)) base.ExceptOnIDataNotInterpretable(null); }

        #endregion
        
    }
    
    public class BPL_V_PL0_Utilisateur_ChoiceList_generated : BPL_V_PL0_Utilisateur_List_generated
    {
        #region object itself

        public BPL_V_PL0_Utilisateur_ChoiceList_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) => new BPL_V_PL0_Utilisateur_Choice(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BPL_V_PL0_Utilisateur_ChoiceList_generated(IStorageAccess);

        #endregion

    }

    public partial class BPL_V_PL0_Utilisateur_Choice : BPL_V_PL0_Utilisateur_Choice_generated
    {
        public BPL_V_PL0_Utilisateur_Choice(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

    public partial class BPL_V_PL0_Utilisateur_ChoiceList : BPL_V_PL0_Utilisateur_ChoiceList_generated
    {
        public BPL_V_PL0_Utilisateur_ChoiceList(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }
    }

}
