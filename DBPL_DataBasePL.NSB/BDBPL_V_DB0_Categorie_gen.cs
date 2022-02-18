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
    public class BDBPL_V_DB0_Categorie_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Categorie_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Categorie.C_UpdateColumnsCount + DDBPL_V_DB0_Categorie.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Categorie_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Categorie(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Categorie(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Categorie)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Id_espaceclient]; // 2 Id_espaceclient long

       public TBfrBusiness BId_typecategorie => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Id_typecategorie]; // 3 Id_typecategorie long

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Libelle]; // 4 Libelle string

       public TBfrBusiness BOrdreaff => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Ordreaff]; // 5 Ordreaff int

       public TBfrBusiness BId_mere => (TBfrBusiness)this[DDBPL_V_DB0_Categorie.C_Id_mere]; // 6 Id_mere long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Categorie_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Categorie_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Categorie(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Categorie_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Categorie : BDBPL_V_DB0_Categorie_generated
    {
        #region object itself

        public BDBPL_V_DB0_Categorie(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Categorie(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Categorie_List : BDBPL_V_DB0_Categorie_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Categorie_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Categorie_generated(IStorageAccess);

        #endregion

    }


}
