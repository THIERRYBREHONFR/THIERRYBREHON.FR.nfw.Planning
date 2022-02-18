// Généré par GENERATEUR.THIERRYBREHON.FR le 03/01/2022 14:35:31
using System;
using System.Collections.Generic;
using System.Data;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.NSS;
using THIERRYBREHON.FR.NSB;
using DataBasePL.NSD;
using DataBasePL.NSS;
namespace DataBasePL.NSB

{
    public class BDBPL_V_DB0_Contrainte_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Contrainte_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Contrainte.C_UpdateColumnsCount + DDBPL_V_DB0_Contrainte.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Contrainte_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Contrainte(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Contrainte(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Contrainte)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BRef => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Ref]; // 4 Ref int

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Abreviation]; // 5 Abreviation string

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Libelle]; // 6 Libelle string

       public TBfrBusiness BCommentaire => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Commentaire]; // 7 Commentaire string

       public TBfrBusiness BId_typecontrainte => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Id_typecontrainte]; // 8 Id_typecontrainte long

       public TBfrBusiness BRealisee => (TBfrBusiness)this[DDBPL_V_DB0_Contrainte.C_Realisee]; // 9 Realisee bool

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Contrainte_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Contrainte_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Contrainte(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Contrainte_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Contrainte : BDBPL_V_DB0_Contrainte_generated
    {
        #region object itself

        public BDBPL_V_DB0_Contrainte(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Contrainte(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Contrainte_List : BDBPL_V_DB0_Contrainte_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Contrainte_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Contrainte_generated(IStorageAccess);

        #endregion

    }


}
