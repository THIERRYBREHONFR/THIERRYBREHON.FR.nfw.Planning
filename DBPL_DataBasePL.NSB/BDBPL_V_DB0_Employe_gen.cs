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
    public class BDBPL_V_DB0_Employe_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Employe_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Employe.C_UpdateColumnsCount + DDBPL_V_DB0_Employe.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Employe_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Employe(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Employe(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Employe)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Id]; // 0 Id long

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Logicaldeleted]; // 1 Logicaldeleted bool

       public TBfrBusiness BInitiales => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Initiales]; // 2 Initiales string

       public TBfrBusiness BId_planning => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Id_planning]; // 3 Id_planning long

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Id_espaceclient]; // 4 Id_espaceclient long

       public TBfrBusiness BNom => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Nom]; // 5 Nom string

       public TBfrBusiness BPrenom => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Prenom]; // 6 Prenom string

       public TBfrBusiness BFeminin => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Feminin]; // 7 Feminin bool

       public TBfrBusiness BId_utilisateur => (TBfrBusiness)this[DDBPL_V_DB0_Employe.C_Id_utilisateur]; // 8 Id_utilisateur long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Employe_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Employe_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Employe(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Employe_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Employe : BDBPL_V_DB0_Employe_generated
    {
        #region object itself

        public BDBPL_V_DB0_Employe(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Employe(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Employe_List : BDBPL_V_DB0_Employe_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Employe_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Employe_generated(IStorageAccess);

        #endregion

    }


}
