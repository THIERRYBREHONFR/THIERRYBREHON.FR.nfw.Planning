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
    public class BDBPL_V_DB0_Planning_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Planning_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Planning.C_UpdateColumnsCount + DDBPL_V_DB0_Planning.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Planning_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Planning(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Planning(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Planning)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Abreviation]; // 3 Abreviation string

       public TBfrBusiness BDebut => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Debut]; // 4 Debut DateTime

       public TBfrBusiness BFin => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Fin]; // 5 Fin DateTime

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Planning.C_Id_espaceclient]; // 6 Id_espaceclient long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Planning_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Planning_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Planning(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Planning_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Planning : BDBPL_V_DB0_Planning_generated
    {
        #region object itself

        public BDBPL_V_DB0_Planning(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Planning(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Planning_List : BDBPL_V_DB0_Planning_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Planning_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Planning_generated(IStorageAccess);

        #endregion

    }


}
