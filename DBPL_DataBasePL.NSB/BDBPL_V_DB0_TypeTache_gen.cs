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
    public class BDBPL_V_DB0_TypeTache_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_TypeTache_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_TypeTache.C_UpdateColumnsCount + DDBPL_V_DB0_TypeTache.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_TypeTache_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_TypeTache(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_TypeTache(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_TypeTache)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_TypeTache.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_TypeTache.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DDBPL_V_DB0_TypeTache.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_TypeTache.C_Id_espaceclient]; // 3 Id_espaceclient long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_TypeTache_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_TypeTache_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_TypeTache(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_TypeTache_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_TypeTache : BDBPL_V_DB0_TypeTache_generated
    {
        #region object itself

        public BDBPL_V_DB0_TypeTache(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_TypeTache(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_TypeTache_List : BDBPL_V_DB0_TypeTache_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_TypeTache_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_TypeTache_generated(IStorageAccess);

        #endregion

    }


}
