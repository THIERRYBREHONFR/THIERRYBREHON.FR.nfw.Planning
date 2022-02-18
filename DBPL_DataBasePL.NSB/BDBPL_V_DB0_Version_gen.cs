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
    public class BDBPL_V_DB0_Version_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Version_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Version.C_UpdateColumnsCount + DDBPL_V_DB0_Version.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Version_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Version(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Version(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Version)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BLibelle => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Libelle]; // 2 Libelle string

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BAbreviation => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Abreviation]; // 4 Abreviation string

       public TBfrBusiness BFigee => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Figee]; // 5 Figee bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Version.C_Id_espaceclient]; // 6 Id_espaceclient long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Version_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Version_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Version(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Version_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Version : BDBPL_V_DB0_Version_generated
    {
        #region object itself

        public BDBPL_V_DB0_Version(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Version(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Version_List : BDBPL_V_DB0_Version_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Version_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Version_generated(IStorageAccess);

        #endregion

    }


}
