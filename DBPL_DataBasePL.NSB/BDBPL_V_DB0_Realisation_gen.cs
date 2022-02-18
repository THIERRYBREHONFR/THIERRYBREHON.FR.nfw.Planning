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
    public class BDBPL_V_DB0_Realisation_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Realisation_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, false, true)
        { for (int vIChild = 0; vIChild < DDBPL_V_DB0_Realisation.C_UpdateColumnsCount + DDBPL_V_DB0_Realisation.C_AdditionalColumnsCount; vIChild++) new TBfrBusiness().Parent = this; }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Realisation_generated(IStorageAccess);

        #endregion

        #region associated objects
        
        public override ITBfrData NewITBfrData(TBfrData_Type type, bool withChildren) => new DDBPL_V_DB0_Realisation(type, withChildren); 

        public override ITBfrStorageView NewITBfrStorage() => new SDBPL_V_DB0_Realisation(IStorageAccess);
		
        #endregion
    
        protected override void ExceptOnIDataNotInterpretable(ITBfrData data) { if (!(data is DDBPL_V_DB0_Realisation)) base.ExceptOnIDataNotInterpretable(null); }

        #region Children
        
       public override TBfrBusiness BId => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Id]; // 0 Id long

       public TBfrBusiness BDebut => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Debut]; // 1 Debut DateTime

       public TBfrBusiness BId_employe => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Id_employe]; // 2 Id_employe long

       public TBfrBusiness BDuree => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Duree]; // 3 Duree int

       public TBfrBusiness BLogicaldeleted => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Logicaldeleted]; // 4 Logicaldeleted bool

       public TBfrBusiness BId_espaceclient => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Id_espaceclient]; // 5 Id_espaceclient long

       public TBfrBusiness BId_contrainterealisee => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Id_contrainterealisee]; // 6 Id_contrainterealisee long

       public TBfrBusiness BId_contrainte => (TBfrBusiness)this[DDBPL_V_DB0_Realisation.C_Id_contrainte]; // 7 Id_contrainte long

      
        #endregion

	}
	
    public class BDBPL_V_DB0_Realisation_List_generated : TBfrBusiness_ListWithUpdate
    {
        #region object itself

        public BDBPL_V_DB0_Realisation_List_generated(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess, true, false) => new BDBPL_V_DB0_Realisation(iStorageAccess).Parent = this;

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Realisation_List_generated(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Realisation : BDBPL_V_DB0_Realisation_generated
    {
        #region object itself

        public BDBPL_V_DB0_Realisation(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Realisation(IStorageAccess);

        #endregion

    }

    public partial class BDBPL_V_DB0_Realisation_List : BDBPL_V_DB0_Realisation_List_generated
    {
        #region object itself

        public BDBPL_V_DB0_Realisation_List(ITBfrStorageAccess iStorageAccess) : base(iStorageAccess) { }

        public override ITBfrBusiness NewITBfrBusiness() => new BDBPL_V_DB0_Realisation_generated(IStorageAccess);

        #endregion

    }


}
