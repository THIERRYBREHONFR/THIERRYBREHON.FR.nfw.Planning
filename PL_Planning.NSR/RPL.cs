using System;
using System.Collections.Generic;
using System.Text;
using THIERRYBREHON.FR.NSR;
using DataBasePL.NSR;
namespace Planning.NSR
{
    public partial class RPL
    {

        #region constantes
        /*
                public string Lib_TypeTache(long VId_typetache)
                {
                    switch (VId_typetache)
                    {
                        case Id_TypeTacheRecapVersion: return "Récap";
                        case Id_TypeTacheFerie: return "Férié";
                        case Id_TypeTacheConge: return "Congé";
                        case Id_TypeTacheReunion: return "Réunion";
                        case Id_TypeTacheAdmin: return "Admin";
                        case Id_TypeTacheNormale: return "Prévision";
                        case Id_TypeTacheLibre: return "Libre";
                        case Id_TypeTacheNonTravaille: return "Non travaillé";
                        case Id_TypeTacheRealisation: return "Réalisation";
                    }
                    return "inconnu";
                }
                public const long Id_TypeTacheRecapVersion = -9100;
                public const long Id_TypeTacheFerie = -9120;
                public const long Id_TypeTacheConge = -9130;
                public const long Id_TypeTacheReunion = -9140;
                public const long Id_TypeTacheAdmin = -9150;
                public const long Id_TypeTacheNormale = -9160;
                public const long Id_TypeTacheLibre = -9170;
                public const long Id_TypeTacheNonTravaille = -9180;
                public const long Id_TypeTacheRealisation = -9190;

                public const short Id_Uniteminute = -9199;
                public const short Id_Uniteheure = -9200;
                public const short Id_Unitejour = -9201;
                public const short Id_Unitesemaine = -9202;
                public const short Id_Unitemois = -9203;
                public const short Id_Unitejourouvrable = -9204;
                public const short Id_Unitejourouvre = -9205;

                //public const short Debutmatin = 8;
                //public const short Finmatin = 12;
                //public const short Debutaprem = 14;
                //public const short Finaprem = 18;

                public const string ParmPlanning = "pl";
                public const string ParmVersion = "ve";
                public const string ParmEmploye = "emp";
        */
        #endregion

        #region PL0_Categorie

        public static readonly string PL_V_PL0_Categorie_Object = RDBPL.DBPL_V_DB0_Categorie_Object;
        public static readonly string PL_V_PL0_Categorie_ObjectList = RDBPL.DBPL_V_DB0_Categorie_ObjectList;
        public static readonly string PL_V_PL0_Categorie_TitrePage = RDBPL.DBPL_V_DB0_Categorie_TitrePage;
        public static readonly string PL_V_PL0_Categorie_HelpPage = RDBPL.DBPL_V_DB0_Categorie_HelpPage;

        public static readonly string PL_V_PL0_Categorie_Id = RDBPL.DBPL_V_DB0_Categorie_Id; //{ "Id" };
        public static readonly string PL_V_PL0_Categorie_LblId = RDBPL.DBPL_V_DB0_Categorie_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_Categorie_LgdId = RDBPL.DBPL_V_DB0_Categorie_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_Categorie_TtpId = RDBPL.DBPL_V_DB0_Categorie_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_Categorie_HlpId = RDBPL.DBPL_V_DB0_Categorie_HlpId; //{ "Id" };

        public static readonly string PL_V_PL0_Categorie_Logicaldeleted = RDBPL.DBPL_V_DB0_Categorie_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Categorie_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Categorie_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Categorie_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Categorie_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Categorie_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Categorie_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Categorie_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Categorie_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL0_Categorie_Id_espaceclient = RDBPL.DBPL_V_DB0_Categorie_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Categorie_LblId_espaceclient = RDBPL.DBPL_V_DB0_Categorie_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Categorie_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Categorie_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Categorie_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Categorie_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Categorie_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Categorie_HlpId_espaceclient; //{ "Id_espaceclient" };

        public static readonly string PL_V_PL0_Categorie_Id_typecategorie = RDBPL.DBPL_V_DB0_Categorie_Id_typecategorie; //{ "Id_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_LblId_typecategorie = RDBPL.DBPL_V_DB0_Categorie_LblId_typecategorie; //{ "Id_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_LgdId_typecategorie = RDBPL.DBPL_V_DB0_Categorie_LgdId_typecategorie; //{ "Id_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_TtpId_typecategorie = RDBPL.DBPL_V_DB0_Categorie_TtpId_typecategorie; //{ "Id_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_HlpId_typecategorie = RDBPL.DBPL_V_DB0_Categorie_HlpId_typecategorie; //{ "Id_typecategorie" };

        public static readonly string PL_V_PL0_Categorie_Id_mere = RDBPL.DBPL_V_DB0_Categorie_Id_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_Categorie_LblId_mere = RDBPL.DBPL_V_DB0_Categorie_LblId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_Categorie_LgdId_mere = RDBPL.DBPL_V_DB0_Categorie_LgdId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_Categorie_TtpId_mere = RDBPL.DBPL_V_DB0_Categorie_TtpId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_Categorie_HlpId_mere = RDBPL.DBPL_V_DB0_Categorie_HlpId_mere; //{ "Id_mere" };

        public static readonly string PL_V_PL0_Categorie_Libelle = RDBPL.DBPL_V_DB0_Categorie_Libelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Categorie_LblLibelle = RDBPL.DBPL_V_DB0_Categorie_LblLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Categorie_LgdLibelle = RDBPL.DBPL_V_DB0_Categorie_LgdLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Categorie_TtpLibelle = RDBPL.DBPL_V_DB0_Categorie_TtpLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Categorie_HlpLibelle = RDBPL.DBPL_V_DB0_Categorie_HlpLibelle; //{ "Libelle" };

        public static readonly string PL_V_PL0_Categorie_Ordreaff = RDBPL.DBPL_V_DB0_Categorie_Ordreaff; //{ "Ordreaff" };
        public static readonly string PL_V_PL0_Categorie_LblOrdreaff = RDBPL.DBPL_V_DB0_Categorie_LblOrdreaff; //{ "Ordreaff" };
        public static readonly string PL_V_PL0_Categorie_LgdOrdreaff = RDBPL.DBPL_V_DB0_Categorie_LgdOrdreaff; //{ "Ordreaff" };
        public static readonly string PL_V_PL0_Categorie_TtpOrdreaff = RDBPL.DBPL_V_DB0_Categorie_TtpOrdreaff; //{ "Ordreaff" };
        public static readonly string PL_V_PL0_Categorie_HlpOrdreaff = RDBPL.DBPL_V_DB0_Categorie_HlpOrdreaff; //{ "Ordreaff" };

        public static readonly string PL_V_PL0_Categorie_Lib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_Libelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_LblLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_LblLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_LgdLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_LgdLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_TtpLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_TtpLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_Categorie_HlpLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_HlpLibelle; //{ "Lib_typecategorie" };

        public static readonly string PL_V_PL0_Categorie_Id_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Categorie_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Categorie_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Categorie_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Categorie_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Id_planning" };

        public static readonly string PL_V_PL0_Categorie_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Categorie_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Categorie_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Categorie_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Categorie_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_Categorie_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Categorie_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Categorie_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Categorie_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Categorie_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_Categorie_Lib_mere = "Catégorie mère";
        public static readonly string PL_V_PL0_Categorie_LblLib_mere = PL_V_PL0_Categorie_Lib_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_Categorie_LgdLib_mere = PL_V_PL0_Categorie_Lib_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_Categorie_TtpLib_mere = PL_V_PL0_Categorie_Lib_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_Categorie_HlpLib_mere = PL_V_PL0_Categorie_Lib_mere; //{ "Lib_mere" };

        #endregion

        #region PL0_categoriecontrainte

        public static readonly string PL_V_PL0_CategorieContrainte_Object = RDBPL.DBPL_V_DB0_CategorieContrainte_Object;
        public static readonly string PL_V_PL0_CategorieContrainte_ObjectList = RDBPL.DBPL_V_DB0_CategorieContrainte_ObjectList;
        public static readonly string PL_V_PL0_CategorieContrainte_TitrePage = RDBPL.DBPL_V_DB0_CategorieContrainte_TitrePage;
        public static readonly string PL_V_PL0_CategorieContrainte_HelpPage = RDBPL.DBPL_V_DB0_CategorieContrainte_HelpPage;

        public static readonly string PL_V_PL0_CategorieContrainte_Id = RDBPL.DBPL_V_DB0_CategorieContrainte_Id; //{ "Id" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId = RDBPL.DBPL_V_DB0_CategorieContrainte_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId = RDBPL.DBPL_V_DB0_CategorieContrainte_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId = RDBPL.DBPL_V_DB0_CategorieContrainte_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId = RDBPL.DBPL_V_DB0_CategorieContrainte_HlpId; //{ "Id" };

        public static readonly string PL_V_PL0_CategorieContrainte_Logicaldeleted = RDBPL.DBPL_V_DB0_CategorieContrainte_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLogicaldeleted = RDBPL.DBPL_V_DB0_CategorieContrainte_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_CategorieContrainte_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_CategorieContrainte_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_CategorieContrainte_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL0_CategorieContrainte_Id_espaceclient = RDBPL.DBPL_V_DB0_CategorieContrainte_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId_espaceclient = RDBPL.DBPL_V_DB0_CategorieContrainte_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId_espaceclient = RDBPL.DBPL_V_DB0_CategorieContrainte_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId_espaceclient = RDBPL.DBPL_V_DB0_CategorieContrainte_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId_espaceclient = RDBPL.DBPL_V_DB0_CategorieContrainte_HlpId_espaceclient; //{ "Id_espaceclient" };

        public static readonly string PL_V_PL0_CategorieContrainte_Id_categorie = RDBPL.DBPL_V_DB0_CategorieContrainte_Id_categorie; //{ "Id_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId_categorie = RDBPL.DBPL_V_DB0_CategorieContrainte_LblId_categorie; //{ "Id_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId_categorie = RDBPL.DBPL_V_DB0_CategorieContrainte_LgdId_categorie; //{ "Id_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId_categorie = RDBPL.DBPL_V_DB0_CategorieContrainte_TtpId_categorie; //{ "Id_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId_categorie = RDBPL.DBPL_V_DB0_CategorieContrainte_HlpId_categorie; //{ "Id_categorie" };

        public static readonly string PL_V_PL0_CategorieContrainte_Id_contrainte = RDBPL.DBPL_V_DB0_CategorieContrainte_Id_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId_contrainte = RDBPL.DBPL_V_DB0_CategorieContrainte_LblId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId_contrainte = RDBPL.DBPL_V_DB0_CategorieContrainte_LgdId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId_contrainte = RDBPL.DBPL_V_DB0_CategorieContrainte_TtpId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId_contrainte = RDBPL.DBPL_V_DB0_CategorieContrainte_HlpId_contrainte; //{ "Id_contrainte" };


        // Colonnes supplémentaires   PL_V_PL0_CategorieContrainte_
        public static readonly string PL_V_PL0_CategorieContrainte_Lib_categorie = RDBPL.DBPL_V_DB0_Categorie_Libelle; //{ "Lib_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLib_categorie = RDBPL.DBPL_V_DB0_Categorie_LblLibelle; //{ "Lib_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLib_categorie = RDBPL.DBPL_V_DB0_Categorie_LgdLibelle; //{ "Lib_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLib_categorie = RDBPL.DBPL_V_DB0_Categorie_TtpLibelle; //{ "Lib_categorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLib_categorie = RDBPL.DBPL_V_DB0_Categorie_HlpLibelle; //{ "Lib_categorie" };

        public static readonly string PL_V_PL0_CategorieContrainte_Lib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_Libelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_LblLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_LgdLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_TtpLibelle; //{ "Lib_typecategorie" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLib_typecategorie = RDBPL.DBPL_V_DB0_TypeCategorie_HlpLibelle; //{ "Lib_typecategorie" };

        public static readonly string PL_V_PL0_CategorieContrainte_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //{ "Id_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //{ "Id_planning" };

        public static readonly string PL_V_PL0_CategorieContrainte_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_CategorieContrainte_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_CategorieContrainte_Ref_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Ref; //{ "Ref_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblRef_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //{ "Ref_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdRef_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //{ "Ref_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpRef_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //{ "Ref_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpRef_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //{ "Ref_contrainte" };

        public static readonly string PL_V_PL0_CategorieContrainte_Lib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //{ "Lib_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //{ "Lib_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //{ "Lib_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //{ "Lib_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //{ "Lib_contrainte" };

        public static readonly string PL_V_PL0_CategorieContrainte_Comm_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //{ "Comm_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblComm_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //{ "Comm_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdComm_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //{ "Comm_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpComm_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //{ "Comm_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpComm_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //{ "Comm_contrainte" };

        public static readonly string PL_V_PL0_CategorieContrainte_Id_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_Id; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LblId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //{ "Id_typecontrainte" };

        public static readonly string PL_V_PL0_CategorieContrainte_Abr_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Abreviation; //{ "Abr_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblAbr_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblAbreviation; //{ "Abr_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdAbr_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdAbreviation; //{ "Abr_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpAbr_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpAbreviation; //{ "Abr_contrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpAbr_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpAbreviation; //{ "Abr_contrainte" };

        public static readonly string PL_V_PL0_CategorieContrainte_Contrainterealisee = "Contrainte realisée";
        public static readonly string PL_V_PL0_CategorieContrainte_LblContrainterealisee = PL_V_PL0_CategorieContrainte_Contrainterealisee; //{ "Contrainterealisee" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdContrainterealisee = PL_V_PL0_CategorieContrainte_Contrainterealisee; //{ "Contrainterealisee" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpContrainterealisee = PL_V_PL0_CategorieContrainte_Contrainterealisee; //{ "Contrainterealisee" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpContrainterealisee = PL_V_PL0_CategorieContrainte_Contrainterealisee; //{ "Contrainterealisee" };

        public static readonly string PL_V_PL0_CategorieContrainte_Lib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LblLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_LgdLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_TtpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_CategorieContrainte_HlpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //{ "Lib_typecontrainte" };


        #endregion

        #region PL0_Contrainte

        public static readonly string PL_V_PL0_Contrainte_Object = RDBPL.DBPL_V_DB0_Contrainte_Object;
        public static readonly string PL_V_PL0_Contrainte_ObjectList = RDBPL.DBPL_V_DB0_Contrainte_ObjectList;
        public static readonly string PL_V_PL0_Contrainte_TitrePage = RDBPL.DBPL_V_DB0_Contrainte_TitrePage;
        public static readonly string PL_V_PL0_Contrainte_HelpPage = RDBPL.DBPL_V_DB0_Contrainte_HelpPage;

        public static readonly string PL_V_PL0_Contrainte_Id = RDBPL.DBPL_V_DB0_Contrainte_Id; //{ "Id" };
        public static readonly string PL_V_PL0_Contrainte_LblId = RDBPL.DBPL_V_DB0_Contrainte_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_Contrainte_LgdId = RDBPL.DBPL_V_DB0_Contrainte_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_Contrainte_TtpId = RDBPL.DBPL_V_DB0_Contrainte_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_Contrainte_HlpId = RDBPL.DBPL_V_DB0_Contrainte_HlpId; //{ "Id" };

        public static readonly string PL_V_PL0_Contrainte_Logicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Contrainte_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Contrainte_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Contrainte_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Contrainte_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL0_Contrainte_Id_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Contrainte_LblId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Contrainte_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Contrainte_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Contrainte_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_HlpId_espaceclient; //{ "Id_espaceclient" };

        public static readonly string PL_V_PL0_Contrainte_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Contrainte_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Contrainte_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Contrainte_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Contrainte_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //{ "Id_planning" };

        public static readonly string PL_V_PL0_Contrainte_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //{ "Ref" };
        public static readonly string PL_V_PL0_Contrainte_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Contrainte_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Contrainte_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Contrainte_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //{ "Ref" };

        public static readonly string PL_V_PL0_Contrainte_Abreviation = RDBPL.DBPL_V_DB0_Contrainte_Abreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Contrainte_LblAbreviation = RDBPL.DBPL_V_DB0_Contrainte_LblAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Contrainte_LgdAbreviation = RDBPL.DBPL_V_DB0_Contrainte_LgdAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Contrainte_TtpAbreviation = RDBPL.DBPL_V_DB0_Contrainte_TtpAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Contrainte_HlpAbreviation = RDBPL.DBPL_V_DB0_Contrainte_HlpAbreviation; //{ "Abreviation" };

        public static readonly string PL_V_PL0_Contrainte_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Contrainte_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Contrainte_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Contrainte_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Contrainte_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //{ "Libelle" };

        public static readonly string PL_V_PL0_Contrainte_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Contrainte_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Contrainte_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Contrainte_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Contrainte_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //{ "Commentaire" };

        public static readonly string PL_V_PL0_Contrainte_Id_typecontrainte = RDBPL.DBPL_V_DB0_Contrainte_Id_typecontrainte; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_LblId_typecontrainte = RDBPL.DBPL_V_DB0_Contrainte_LblId_typecontrainte; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_LgdId_typecontrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdId_typecontrainte; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_TtpId_typecontrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpId_typecontrainte; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_HlpId_typecontrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpId_typecontrainte; //{ "Id_typecontrainte" };

        public static readonly string PL_V_PL0_Contrainte_Realisee = RDBPL.DBPL_V_DB0_Contrainte_Realisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Contrainte_LblRealisee = RDBPL.DBPL_V_DB0_Contrainte_LblRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Contrainte_LgdRealisee = RDBPL.DBPL_V_DB0_Contrainte_LgdRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Contrainte_TtpRealisee = RDBPL.DBPL_V_DB0_Contrainte_TtpRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Contrainte_HlpRealisee = RDBPL.DBPL_V_DB0_Contrainte_HlpRealisee; //{ "Realisee" };


        // Colonnes supplémentaires   PL_V_PL0_Contrainte_
        public static readonly string PL_V_PL0_Contrainte_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Contrainte_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Contrainte_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Contrainte_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Contrainte_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_Contrainte_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Contrainte_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Contrainte_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Contrainte_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Contrainte_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_Contrainte_Lib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_LblLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_LgdLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_TtpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Contrainte_HlpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //{ "Lib_typecontrainte" };

        #endregion

        #region PL0_Employe_

        public readonly static string PL_V_PL0_Employe_Id = RDBPL.DBPL_V_DB0_Employe_Id; //"Id";
        public readonly static string PL_V_PL0_Employe_LblId = RDBPL.DBPL_V_DB0_Employe_LblId; //"Id";
        public readonly static string PL_V_PL0_Employe_LgdId = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Id";
        public readonly static string PL_V_PL0_Employe_TtpId = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Id";
        public readonly static string PL_V_PL0_Employe_HlpId = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Id";

        public readonly static string PL_V_PL0_Employe_Object = RDBPL.DBPL_V_DB0_Employe_Object; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_ObjectList = RDBPL.DBPL_V_DB0_Employe_ObjectList; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_TitrePage = RDBPL.DBPL_V_DB0_Employe_TitrePage; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_HelpPage = RDBPL.DBPL_V_DB0_Employe_HelpPage; //"Id_planning";

        public readonly static string PL_V_PL0_Employe_Logicaldeleted = RDBPL.DBPL_V_DB0_Employe_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Employe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Employe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Employe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Employe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_Employe_Initiales = RDBPL.DBPL_V_DB0_Employe_Initiales; //"Initiales";
        public readonly static string PL_V_PL0_Employe_LblInitiales = RDBPL.DBPL_V_DB0_Employe_LblInitiales; //"Initiales";
        public readonly static string PL_V_PL0_Employe_LgdInitiales = RDBPL.DBPL_V_DB0_Employe_LgdInitiales; //"Initiales";
        public readonly static string PL_V_PL0_Employe_TtpInitiales = RDBPL.DBPL_V_DB0_Employe_TtpInitiales; //"Initiales";
        public readonly static string PL_V_PL0_Employe_HlpInitiales = RDBPL.DBPL_V_DB0_Employe_HlpInitiales; //"Initiales";

        public readonly static string PL_V_PL0_Employe_Id_planning = RDBPL.DBPL_V_DB0_Employe_Id_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_LblId_planning = RDBPL.DBPL_V_DB0_Employe_LblId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_LgdId_planning = RDBPL.DBPL_V_DB0_Employe_LgdId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_TtpId_planning = RDBPL.DBPL_V_DB0_Employe_TtpId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Employe_HlpId_planning = RDBPL.DBPL_V_DB0_Employe_HlpId_planning; //"Id_planning";

        public readonly static string PL_V_PL0_Employe_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //"Lib_planning";
        public readonly static string PL_V_PL0_Employe_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //"Lib_planning";
        public readonly static string PL_V_PL0_Employe_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //"Lib_planning";
        public readonly static string PL_V_PL0_Employe_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //"Lib_planning";
        public readonly static string PL_V_PL0_Employe_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //"Lib_planning";

        public static readonly string PL_V_PL0_Employe_Identite = "Identite";
        public static readonly string PL_V_PL0_Employe_LblIdentite = PL_V_PL0_Employe_Identite; //{ "Identite" };
        public static readonly string PL_V_PL0_Employe_LgdIdentite = PL_V_PL0_Employe_Identite; //{ "Identite" };
        public static readonly string PL_V_PL0_Employe_TtpIdentite = PL_V_PL0_Employe_Identite; //{ "Identite" };
        public static readonly string PL_V_PL0_Employe_HlpIdentite = PL_V_PL0_Employe_Identite; //{ "Identite" };

        public static readonly string PL_V_PL0_Employe_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Employe_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Employe_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Employe_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Employe_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public readonly static string PL_V_PL0_Employe_Id_espaceclient = RDBPL.DBPL_V_DB0_Employe_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Employe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Employe_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Employe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Employe_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Employe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Employe_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Employe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Employe_HlpId_espaceclient; //"Id_espaceclient";

        public readonly static string PL_V_PL0_Employe_Nom = RDBPL.DBPL_V_DB0_Employe_Nom; //"Nom";
        public readonly static string PL_V_PL0_Employe_LblNom = RDBPL.DBPL_V_DB0_Employe_LblNom; //"Nom";
        public readonly static string PL_V_PL0_Employe_LgdNom = RDBPL.DBPL_V_DB0_Employe_LgdNom; //"Nom";
        public readonly static string PL_V_PL0_Employe_TtpNom = RDBPL.DBPL_V_DB0_Employe_TtpNom; //"Nom";
        public readonly static string PL_V_PL0_Employe_HlpNom = RDBPL.DBPL_V_DB0_Employe_HlpNom; //"Nom";

        public readonly static string PL_V_PL0_Employe_Prenom = RDBPL.DBPL_V_DB0_Employe_Prenom; //"Prenom";
        public readonly static string PL_V_PL0_Employe_LblPrenom = RDBPL.DBPL_V_DB0_Employe_LblPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Employe_LgdPrenom = RDBPL.DBPL_V_DB0_Employe_LgdPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Employe_TtpPrenom = RDBPL.DBPL_V_DB0_Employe_TtpPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Employe_HlpPrenom = RDBPL.DBPL_V_DB0_Employe_HlpPrenom; //"Prenom";

        public readonly static string PL_V_PL0_Employe_Feminin = RDBPL.DBPL_V_DB0_Employe_Feminin; //"Feminin";
        public readonly static string PL_V_PL0_Employe_LblFeminin = RDBPL.DBPL_V_DB0_Employe_LblFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Employe_LgdFeminin = RDBPL.DBPL_V_DB0_Employe_LgdFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Employe_TtpFeminin = RDBPL.DBPL_V_DB0_Employe_TtpFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Employe_HlpFeminin = RDBPL.DBPL_V_DB0_Employe_HlpFeminin; //"Feminin";

        public static readonly string PL_V_PL0_Employe_Id_utilisateur = RDBPL.DBPL_V_DB0_Employe_Id_utilisateur; //{ "Id_utilisateur" };
        public static readonly string PL_V_PL0_Employe_LblId_utilisateur = RDBPL.DBPL_V_DB0_Employe_LblId_utilisateur; //{ "Id_utilisateur" };
        public static readonly string PL_V_PL0_Employe_LgdId_utilisateur = RDBPL.DBPL_V_DB0_Employe_LgdId_utilisateur; //{ "Id_utilisateur" };
        public static readonly string PL_V_PL0_Employe_TtpId_utilisateur = RDBPL.DBPL_V_DB0_Employe_TtpId_utilisateur; //{ "Id_utilisateur" };
        public static readonly string PL_V_PL0_Employe_HlpId_utilisateur = RDBPL.DBPL_V_DB0_Employe_HlpId_utilisateur; //{ "Id_utilisateur" };


        #endregion

        #region PL0_Equipe

        public readonly static string PL_V_PL0_Equipe_Id = RDBPL.DBPL_V_DB0_Equipe_Id; //"Id";
        public readonly static string PL_V_PL0_Equipe_LblId = RDBPL.DBPL_V_DB0_Equipe_LblId; //"Id";
        public readonly static string PL_V_PL0_Equipe_LgdId = RDBPL.DBPL_V_DB0_Equipe_LgdId; //"Id";
        public readonly static string PL_V_PL0_Equipe_TtpId = RDBPL.DBPL_V_DB0_Equipe_TtpId; //"Id";
        public readonly static string PL_V_PL0_Equipe_HlpId = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Id";

        public readonly static string PL_V_PL0_Equipe_Object = RDBPL.DBPL_V_DB0_Equipe_Object; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_ObjectList = RDBPL.DBPL_V_DB0_Equipe_ObjectList; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_TitrePage = RDBPL.DBPL_V_DB0_Equipe_TitrePage; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_HelpPage = RDBPL.DBPL_V_DB0_Equipe_HelpPage; //"Id_planning";

        public readonly static string PL_V_PL0_Equipe_Logicaldeleted = RDBPL.DBPL_V_DB0_Equipe_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Equipe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Equipe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Equipe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Equipe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_Equipe_Libelle = RDBPL.DBPL_V_DB0_Equipe_Libelle; //"Libelle";
        public readonly static string PL_V_PL0_Equipe_LblLibelle = RDBPL.DBPL_V_DB0_Equipe_LblLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Equipe_LgdLibelle = RDBPL.DBPL_V_DB0_Equipe_LgdLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Equipe_TtpLibelle = RDBPL.DBPL_V_DB0_Equipe_TtpLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Equipe_HlpLibelle = RDBPL.DBPL_V_DB0_Equipe_HlpLibelle; //"Libelle";

        public readonly static string PL_V_PL0_Equipe_Abreviation = RDBPL.DBPL_V_DB0_Equipe_Abreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Equipe_LblAbreviation = RDBPL.DBPL_V_DB0_Equipe_LblAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Equipe_LgdAbreviation = RDBPL.DBPL_V_DB0_Equipe_LgdAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Equipe_TtpAbreviation = RDBPL.DBPL_V_DB0_Equipe_TtpAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Equipe_HlpAbreviation = RDBPL.DBPL_V_DB0_Equipe_HlpAbreviation; //"Abreviation";

        public readonly static string PL_V_PL0_Equipe_Id_planning = RDBPL.DBPL_V_DB0_Equipe_Id_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_LblId_planning = RDBPL.DBPL_V_DB0_Equipe_LblId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_LgdId_planning = RDBPL.DBPL_V_DB0_Equipe_LgdId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_TtpId_planning = RDBPL.DBPL_V_DB0_Equipe_TtpId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Equipe_HlpId_planning = RDBPL.DBPL_V_DB0_Equipe_HlpId_planning; //"Id_planning";

        public readonly static string PL_V_PL0_Equipe_Lib_planning = RDBPL.DBPL_V_DB0_Equipe_Id_planning; //"Lib_planning";
        public readonly static string PL_V_PL0_Equipe_LblLib_planning = RDBPL.DBPL_V_DB0_Equipe_LblId_planning; //"Lib_planning";
        public readonly static string PL_V_PL0_Equipe_LgdLib_planning = RDBPL.DBPL_V_DB0_Equipe_LgdId_planning; //"Lib_planning";
        public readonly static string PL_V_PL0_Equipe_TtpLib_planning = RDBPL.DBPL_V_DB0_Equipe_TtpId_planning; //"Lib_planning";
        public readonly static string PL_V_PL0_Equipe_HlpLib_planning = RDBPL.DBPL_V_DB0_Equipe_HlpId_planning; //"Lib_planning";

        public readonly static string PL_V_PL0_Equipe_Id_espaceclient = RDBPL.DBPL_V_DB0_Equipe_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Equipe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Equipe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Equipe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Equipe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_HlpId_espaceclient; //"Id_espaceclient";

        public static readonly string PL_V_PL0_Equipe_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Equipe_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Equipe_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Equipe_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Equipe_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_Equipe_Lib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_Libelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_LblLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LblLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_LgdLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_TtpLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_HlpLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpLibelle; //{ "Lib_planning_equipe" };

        public static readonly string PL_V_PL0_Equipe_Abr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_Abreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_LblAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LblAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_LgdAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_TtpAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_Equipe_HlpAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpAbreviation; //{ "Abr_planning_equipe" };

        #endregion

        #region PL0_EquipeEmployeVersion

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Id; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblId; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdId; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpId; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpId; //"Id";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Object = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Object; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_ObjectList = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_ObjectList; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TitrePage = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TitrePage; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HelpPage = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HelpPage; //"Lib_version";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Logicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblLogicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id_version = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Id_version; //"Id_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId_version = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblId_version; //"Id_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId_version = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdId_version; //"Id_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId_version = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpId_version; //"Id_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId_version = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpId_version; //"Id_version";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id_equipe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Id_equipe; //"Id_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId_equipe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblId_equipe; //"Id_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId_equipe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdId_equipe; //"Id_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId_equipe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpId_equipe; //"Id_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId_equipe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpId_equipe; //"Id_equipe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id_employe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Id_employe; //"Id_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId_employe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblId_employe; //"Id_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId_employe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdId_employe; //"Id_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId_employe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpId_employe; //"Id_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId_employe = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpId_employe; //"Id_employe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmployeVersion_HlpId_espaceclient; //"Id_espaceclient";

        // Colonnes supplémentaires PL0_EquipeEmployeVersion_
        public readonly static string PL_V_PL0_EquipeEmployeVersion_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_planning";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_planning";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_planning";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_planning";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_planning";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Ident_employe = "Identité";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblIdent_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Ident_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdIdent_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Ident_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpIdent_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Ident_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Init_employe = RDBPL.DBPL_V_DB0_Employe_Initiales; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblInit_employe = RDBPL.DBPL_V_DB0_Employe_LblInitiales; //"Init_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdInit_employe = RDBPL.DBPL_V_DB0_Employe_LgdInitiales; //"Init_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpInit_employe = RDBPL.DBPL_V_DB0_Employe_TtpInitiales; //"Init_employe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpInitiales; //"Init_employe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Abr_equipe = RDBPL.DBPL_V_DB0_Equipe_Abreviation; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblAbr_equipe = RDBPL.DBPL_V_DB0_Equipe_LblAbreviation; //"Abr_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdAbr_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdAbreviation; //"Abr_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpAbr_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpAbreviation; //"Abr_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpAbr_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpAbreviation; //"Abr_equipe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Lib_equipe = RDBPL.DBPL_V_DB0_Equipe_Libelle; //"Id";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblLib_equipe = RDBPL.DBPL_V_DB0_Equipe_LblId; //"Lib_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdLib_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdId; //"Lib_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpLib_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpId; //"Lib_equipe";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpLib_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Lib_equipe";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Abr_version = RDBPL.DBPL_V_DB0_Version_Abreviation; //"Abr";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblAbr_version = RDBPL.DBPL_V_DB0_Version_LblAbreviation; //"Abr_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdAbr_version = RDBPL.DBPL_V_DB0_Version_LgdAbreviation; //"Abr_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpAbr_version = RDBPL.DBPL_V_DB0_Version_TtpAbreviation; //"Abr_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpAbr_version = RDBPL.DBPL_V_DB0_Version_HlpAbreviation; //"Abr_version";

        public readonly static string PL_V_PL0_EquipeEmployeVersion_Lib_version = RDBPL.DBPL_V_DB0_Version_Libelle; //"Lib";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LblLib_version = RDBPL.DBPL_V_DB0_Version_LblLibelle; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_LgdLib_version = RDBPL.DBPL_V_DB0_Version_LgdLibelle; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_TtpLib_version = RDBPL.DBPL_V_DB0_Version_TtpLibelle; //"Lib_version";
        public readonly static string PL_V_PL0_EquipeEmployeVersion_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpLibelle; //"Lib_version";

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Nom_employe = RDBPL.DBPL_V_DB0_Employe_Nom; //{ "Nom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblNom_employe = RDBPL.DBPL_V_DB0_Employe_LblNom; //{ "Nom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdNom_employe = RDBPL.DBPL_V_DB0_Employe_LgdNom; //{ "Nom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpNom_employe = RDBPL.DBPL_V_DB0_Employe_TtpNom; //{ "Nom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpNom_employe = RDBPL.DBPL_V_DB0_Employe_HlpNom; //{ "Nom_employe" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Prenom_employe = RDBPL.DBPL_V_DB0_Employe_Prenom; //{ "Prenom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblPrenom_employe = RDBPL.DBPL_V_DB0_Employe_LblPrenom; //{ "Prenom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdPrenom_employe = RDBPL.DBPL_V_DB0_Employe_LgdPrenom; //{ "Prenom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpPrenom_employe = RDBPL.DBPL_V_DB0_Employe_TtpPrenom; //{ "Prenom_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpPrenom_employe = RDBPL.DBPL_V_DB0_Employe_HlpPrenom; //{ "Prenom_employe" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Feminin_employe = RDBPL.DBPL_V_DB0_Employe_Feminin; //{ "Feminin_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblFeminin_employe = RDBPL.DBPL_V_DB0_Employe_LblFeminin; //{ "Feminin_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdFeminin_employe = RDBPL.DBPL_V_DB0_Employe_LgdFeminin; //{ "Feminin_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpFeminin_employe = RDBPL.DBPL_V_DB0_Employe_TtpFeminin; //{ "Feminin_employe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpFeminin_employe = RDBPL.DBPL_V_DB0_Employe_HlpFeminin; //{ "Feminin_employe" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Lib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_Libelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LblLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpLibelle; //{ "Lib_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpLib_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpLibelle; //{ "Lib_planning_equipe" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Abr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_Abreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LblAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpAbreviation; //{ "Abr_planning_equipe" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpAbr_planning_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpAbreviation; //{ "Abr_planning_equipe" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Lib_planning_version = RDBPL.DBPL_V_DB0_Version_Libelle; //{ "Lib_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblLib_planning_version = RDBPL.DBPL_V_DB0_Version_LblLibelle; //{ "Lib_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdLib_planning_version = RDBPL.DBPL_V_DB0_Version_LgdLibelle; //{ "Lib_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpLib_planning_version = RDBPL.DBPL_V_DB0_Version_TtpLibelle; //{ "Lib_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpLib_planning_version = RDBPL.DBPL_V_DB0_Version_HlpLibelle; //{ "Lib_planning_version" };

        public static readonly string PL_V_PL0_EquipeEmployeVersion_Abr_planning_version = RDBPL.DBPL_V_DB0_Version_Abreviation; //{ "Abr_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LblAbr_planning_version = RDBPL.DBPL_V_DB0_Version_LblAbreviation; //{ "Abr_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_LgdAbr_planning_version = RDBPL.DBPL_V_DB0_Version_LgdAbreviation; //{ "Abr_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_TtpAbr_planning_version = RDBPL.DBPL_V_DB0_Version_TtpAbreviation; //{ "Abr_planning_version" };
        public static readonly string PL_V_PL0_EquipeEmployeVersion_HlpAbr_planning_version = RDBPL.DBPL_V_DB0_Version_HlpAbreviation; //{ "Abr_planning_version" };

        #endregion

        #region PL0_Planning_

        public readonly static string PL_V_PL0_Planning_Id = RDBPL.DBPL_V_DB0_Planning_Id; //"Id";
        public readonly static string PL_V_PL0_Planning_LblId = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id";
        public readonly static string PL_V_PL0_Planning_LgdId = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id";
        public readonly static string PL_V_PL0_Planning_TtpId = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id";
        public readonly static string PL_V_PL0_Planning_HlpId = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id";

        public readonly static string PL_V_PL0_Planning_Object = RDBPL.DBPL_V_DB0_Planning_Object; //"Fin";
        public readonly static string PL_V_PL0_Planning_ObjectList = RDBPL.DBPL_V_DB0_Planning_ObjectList; //"Fin";
        public readonly static string PL_V_PL0_Planning_TitrePage = RDBPL.DBPL_V_DB0_Planning_TitrePage; //"Fin";
        public readonly static string PL_V_PL0_Planning_HelpPage = RDBPL.DBPL_V_DB0_Planning_HelpPage; //"Fin";

        public readonly static string PL_V_PL0_Planning_Logicaldeleted = RDBPL.DBPL_V_DB0_Planning_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Planning_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Planning_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Planning_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Planning_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_Planning_Libelle = RDBPL.DBPL_V_DB0_Planning_Libelle; //"Libelle";
        public readonly static string PL_V_PL0_Planning_LblLibelle = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Planning_LgdLibelle = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Planning_TtpLibelle = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Planning_HlpLibelle = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //"Libelle";

        public readonly static string PL_V_PL0_Planning_Abreviation = RDBPL.DBPL_V_DB0_Planning_Abreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Planning_LblAbreviation = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Planning_LgdAbreviation = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Planning_TtpAbreviation = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Planning_HlpAbreviation = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //"Abreviation";

        public readonly static string PL_V_PL0_Planning_Debut = RDBPL.DBPL_V_DB0_Planning_Debut; //"Debut";
        public readonly static string PL_V_PL0_Planning_LblDebut = RDBPL.DBPL_V_DB0_Planning_LblDebut; //"Debut";
        public readonly static string PL_V_PL0_Planning_LgdDebut = RDBPL.DBPL_V_DB0_Planning_LgdDebut; //"Debut";
        public readonly static string PL_V_PL0_Planning_TtpDebut = RDBPL.DBPL_V_DB0_Planning_TtpDebut; //"Debut";
        public readonly static string PL_V_PL0_Planning_HlpDebut = RDBPL.DBPL_V_DB0_Planning_HlpDebut; //"Debut";

        public readonly static string PL_V_PL0_Planning_Fin = RDBPL.DBPL_V_DB0_Planning_Fin; //"Fin";
        public readonly static string PL_V_PL0_Planning_LblFin = RDBPL.DBPL_V_DB0_Planning_LblFin; //"Fin";
        public readonly static string PL_V_PL0_Planning_LgdFin = RDBPL.DBPL_V_DB0_Planning_LgdFin; //"Fin";
        public readonly static string PL_V_PL0_Planning_TtpFin = RDBPL.DBPL_V_DB0_Planning_TtpFin; //"Fin";
        public readonly static string PL_V_PL0_Planning_HlpFin = RDBPL.DBPL_V_DB0_Planning_HlpFin; //"Fin";

        public readonly static string PL_V_PL0_Planning_Id_espaceclient = RDBPL.DBPL_V_DB0_Planning_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Planning_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Planning_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Planning_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Planning_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_HlpId_espaceclient; //"Id_espaceclient";

        #endregion

        #region PL0_Realisation

        public static readonly string PL_V_PL0_Realisation_Object = RDBPL.DBPL_V_DB0_Realisation_Object;
        public static readonly string PL_V_PL0_Realisation_ObjectList = RDBPL.DBPL_V_DB0_Realisation_ObjectList;
        public static readonly string PL_V_PL0_Realisation_TitrePage = RDBPL.DBPL_V_DB0_Realisation_TitrePage;
        public static readonly string PL_V_PL0_Realisation_HelpPage = RDBPL.DBPL_V_DB0_Realisation_HelpPage;

        public static readonly string PL_V_PL0_Realisation_Id = RDBPL.DBPL_V_DB0_Realisation_Id; //{ "Id" };
        public static readonly string PL_V_PL0_Realisation_LblId = RDBPL.DBPL_V_DB0_Realisation_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_Realisation_LgdId = RDBPL.DBPL_V_DB0_Realisation_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_Realisation_TtpId = RDBPL.DBPL_V_DB0_Realisation_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_Realisation_HlpId = RDBPL.DBPL_V_DB0_Realisation_HlpId; //{ "Id" };

        public static readonly string PL_V_PL0_Realisation_Debut = RDBPL.DBPL_V_DB0_Realisation_Debut; //{ "Debut" };
        public static readonly string PL_V_PL0_Realisation_LblDebut = RDBPL.DBPL_V_DB0_Realisation_LblDebut; //{ "Debut" };
        public static readonly string PL_V_PL0_Realisation_LgdDebut = RDBPL.DBPL_V_DB0_Realisation_LgdDebut; //{ "Debut" };
        public static readonly string PL_V_PL0_Realisation_TtpDebut = RDBPL.DBPL_V_DB0_Realisation_TtpDebut; //{ "Debut" };
        public static readonly string PL_V_PL0_Realisation_HlpDebut = RDBPL.DBPL_V_DB0_Realisation_HlpDebut; //{ "Debut" };

        public static readonly string PL_V_PL0_Realisation_Id_employe = RDBPL.DBPL_V_DB0_Realisation_Id_employe; //{ "Id_employe" };
        public static readonly string PL_V_PL0_Realisation_LblId_employe = RDBPL.DBPL_V_DB0_Realisation_LblId_employe; //{ "Id_employe" };
        public static readonly string PL_V_PL0_Realisation_LgdId_employe = RDBPL.DBPL_V_DB0_Realisation_LgdId_employe; //{ "Id_employe" };
        public static readonly string PL_V_PL0_Realisation_TtpId_employe = RDBPL.DBPL_V_DB0_Realisation_TtpId_employe; //{ "Id_employe" };
        public static readonly string PL_V_PL0_Realisation_HlpId_employe = RDBPL.DBPL_V_DB0_Realisation_HlpId_employe; //{ "Id_employe" };

        public static readonly string PL_V_PL0_Realisation_Duree = RDBPL.DBPL_V_DB0_Realisation_Duree; //{ "Duree" };
        public static readonly string PL_V_PL0_Realisation_LblDuree = RDBPL.DBPL_V_DB0_Realisation_LblDuree; //{ "Duree" };
        public static readonly string PL_V_PL0_Realisation_LgdDuree = RDBPL.DBPL_V_DB0_Realisation_LgdDuree; //{ "Duree" };
        public static readonly string PL_V_PL0_Realisation_TtpDuree = RDBPL.DBPL_V_DB0_Realisation_TtpDuree; //{ "Duree" };
        public static readonly string PL_V_PL0_Realisation_HlpDuree = RDBPL.DBPL_V_DB0_Realisation_HlpDuree; //{ "Duree" };

        public static readonly string PL_V_PL0_Realisation_Logicaldeleted = RDBPL.DBPL_V_DB0_Realisation_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Realisation_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Realisation_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Realisation_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_Realisation_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL0_Realisation_Id_espaceclient = RDBPL.DBPL_V_DB0_Realisation_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Realisation_LblId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Realisation_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Realisation_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_Realisation_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_HlpId_espaceclient; //{ "Id_espaceclient" };

        public static readonly string PL_V_PL0_Realisation_Id_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_Id_contrainterealisee; //{ "Id_contrainterealisee" };
        public static readonly string PL_V_PL0_Realisation_LblId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_LblId_contrainterealisee; //{ "Id_contrainterealisee" };
        public static readonly string PL_V_PL0_Realisation_LgdId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_LgdId_contrainterealisee; //{ "Id_contrainterealisee" };
        public static readonly string PL_V_PL0_Realisation_TtpId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_TtpId_contrainterealisee; //{ "Id_contrainterealisee" };
        public static readonly string PL_V_PL0_Realisation_HlpId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_HlpId_contrainterealisee; //{ "Id_contrainterealisee" };

        public static readonly string PL_V_PL0_Realisation_Id_contrainte = RDBPL.DBPL_V_DB0_Realisation_Id_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_Realisation_LblId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LblId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_Realisation_LgdId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LgdId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_Realisation_TtpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_TtpId_contrainte; //{ "Id_contrainte" };
        public static readonly string PL_V_PL0_Realisation_HlpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_HlpId_contrainte; //{ "Id_contrainte" };


        // Colonnes supplémentaires   PL_V_PL0_Realisation_
        public static readonly string PL_V_PL0_Realisation_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Realisation_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Realisation_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Realisation_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //{ "Id_planning" };
        public static readonly string PL_V_PL0_Realisation_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //{ "Id_planning" };

        public static readonly string PL_V_PL0_Realisation_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //{ "Ref" };
        public static readonly string PL_V_PL0_Realisation_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Realisation_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Realisation_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //{ "Ref" };
        public static readonly string PL_V_PL0_Realisation_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //{ "Ref" };

        public static readonly string PL_V_PL0_Realisation_Abreviation = RDBPL.DBPL_V_DB0_Contrainte_Abreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Realisation_LblAbreviation = RDBPL.DBPL_V_DB0_Contrainte_LblAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Realisation_LgdAbreviation = RDBPL.DBPL_V_DB0_Contrainte_LgdAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Realisation_TtpAbreviation = RDBPL.DBPL_V_DB0_Contrainte_TtpAbreviation; //{ "Abreviation" };
        public static readonly string PL_V_PL0_Realisation_HlpAbreviation = RDBPL.DBPL_V_DB0_Contrainte_HlpAbreviation; //{ "Abreviation" };

        public static readonly string PL_V_PL0_Realisation_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Realisation_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Realisation_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Realisation_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_Realisation_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //{ "Libelle" };

        public static readonly string PL_V_PL0_Realisation_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Realisation_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Realisation_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Realisation_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //{ "Commentaire" };
        public static readonly string PL_V_PL0_Realisation_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //{ "Commentaire" };

        public static readonly string PL_V_PL0_Realisation_Id_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_Id; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_LblId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LblId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_LgdId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_TtpId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //{ "Id_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_HlpId_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //{ "Id_typecontrainte" };

        public static readonly string PL_V_PL0_Realisation_Realisee = RDBPL.DBPL_V_DB0_Contrainte_Realisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Realisation_LblRealisee = RDBPL.DBPL_V_DB0_Contrainte_LblRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Realisation_LgdRealisee = RDBPL.DBPL_V_DB0_Contrainte_LgdRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Realisation_TtpRealisee = RDBPL.DBPL_V_DB0_Contrainte_TtpRealisee; //{ "Realisee" };
        public static readonly string PL_V_PL0_Realisation_HlpRealisee = RDBPL.DBPL_V_DB0_Contrainte_HlpRealisee; //{ "Realisee" };

        public static readonly string PL_V_PL0_Realisation_Lib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_LblLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_LgdLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_TtpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //{ "Lib_typecontrainte" };
        public static readonly string PL_V_PL0_Realisation_HlpLib_typecontrainte = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //{ "Lib_typecontrainte" };

        public static readonly string PL_V_PL0_Realisation_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Realisation_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Realisation_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Realisation_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Realisation_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        public static readonly string PL_V_PL0_Realisation_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Realisation_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Realisation_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Realisation_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Realisation_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        #endregion

        #region PL0_TypeCategorie

        public static readonly string PL_V_PL0_TypeCategorie_Object = RDBPL.DBPL_V_DB0_TypeCategorie_Object;
        public static readonly string PL_V_PL0_TypeCategorie_ObjectList = RDBPL.DBPL_V_DB0_TypeCategorie_ObjectList;
        public static readonly string PL_V_PL0_TypeCategorie_TitrePage = RDBPL.DBPL_V_DB0_TypeCategorie_TitrePage;
        public static readonly string PL_V_PL0_TypeCategorie_HelpPage = RDBPL.DBPL_V_DB0_TypeCategorie_HelpPage;
                  
        public static readonly string PL_V_PL0_TypeCategorie_Id = RDBPL.DBPL_V_DB0_TypeCategorie_Id; //{ "Id" };
        public static readonly string PL_V_PL0_TypeCategorie_LblId = RDBPL.DBPL_V_DB0_TypeCategorie_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdId = RDBPL.DBPL_V_DB0_TypeCategorie_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpId = RDBPL.DBPL_V_DB0_TypeCategorie_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpId = RDBPL.DBPL_V_DB0_TypeCategorie_HlpId; //{ "Id" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Logicaldeleted = RDBPL.DBPL_V_DB0_TypeCategorie_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeCategorie_LblLogicaldeleted = RDBPL.DBPL_V_DB0_TypeCategorie_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_TypeCategorie_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeCategorie_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeCategorie_HlpLogicaldeleted; //{ "Logicaldeleted" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Id_espaceclient = RDBPL.DBPL_V_DB0_TypeCategorie_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeCategorie_LblId_espaceclient = RDBPL.DBPL_V_DB0_TypeCategorie_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdId_espaceclient = RDBPL.DBPL_V_DB0_TypeCategorie_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpId_espaceclient = RDBPL.DBPL_V_DB0_TypeCategorie_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpId_espaceclient = RDBPL.DBPL_V_DB0_TypeCategorie_HlpId_espaceclient; //{ "Id_espaceclient" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Id_planning = RDBPL.DBPL_V_DB0_TypeCategorie_Id_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LblId_planning = RDBPL.DBPL_V_DB0_TypeCategorie_LblId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdId_planning = RDBPL.DBPL_V_DB0_TypeCategorie_LgdId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpId_planning = RDBPL.DBPL_V_DB0_TypeCategorie_TtpId_planning; //{ "Id_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpId_planning = RDBPL.DBPL_V_DB0_TypeCategorie_HlpId_planning; //{ "Id_planning" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Id_mere = RDBPL.DBPL_V_DB0_TypeCategorie_Id_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_LblId_mere = RDBPL.DBPL_V_DB0_TypeCategorie_LblId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdId_mere = RDBPL.DBPL_V_DB0_TypeCategorie_LgdId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpId_mere = RDBPL.DBPL_V_DB0_TypeCategorie_TtpId_mere; //{ "Id_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpId_mere = RDBPL.DBPL_V_DB0_TypeCategorie_HlpId_mere; //{ "Id_mere" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Libelle = RDBPL.DBPL_V_DB0_TypeCategorie_Libelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeCategorie_LblLibelle = RDBPL.DBPL_V_DB0_TypeCategorie_LblLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdLibelle = RDBPL.DBPL_V_DB0_TypeCategorie_LgdLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpLibelle = RDBPL.DBPL_V_DB0_TypeCategorie_TtpLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpLibelle = RDBPL.DBPL_V_DB0_TypeCategorie_HlpLibelle; //{ "Libelle" };
                  
                  
        // Colonnes supplémentaires   PL_V_PL0_TypeCategorie_
        public static readonly string PL_V_PL0_TypeCategorie_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_TypeCategorie_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };
                  
        public static readonly string PL_V_PL0_TypeCategorie_Lib_mere = RDBPL.DBPL_V_DB0_TypeCategorie_Id_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_LblLib_mere = RDBPL.DBPL_V_DB0_TypeCategorie_LblId_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_LgdLib_mere = RDBPL.DBPL_V_DB0_TypeCategorie_LgdId_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_TtpLib_mere = RDBPL.DBPL_V_DB0_TypeCategorie_TtpId_mere; //{ "Lib_mere" };
        public static readonly string PL_V_PL0_TypeCategorie_HlpLib_mere = RDBPL.DBPL_V_DB0_TypeCategorie_HlpId_mere; //{ "Lib_mere" };

        #endregion

        #region PL0_Typetache

        public static readonly string PL_V_PL0_TypeTache_Object = RDBPL.DBPL_V_DB0_TypeTache_Object;
        public static readonly string PL_V_PL0_TypeTache_ObjectList = RDBPL.DBPL_V_DB0_TypeTache_ObjectList;
        public static readonly string PL_V_PL0_TypeTache_TitrePage = RDBPL.DBPL_V_DB0_TypeTache_TitrePage;
        public static readonly string PL_V_PL0_TypeTache_HelpPage = RDBPL.DBPL_V_DB0_TypeTache_HelpPage;

        public static readonly string PL_V_PL0_TypeTache_Id = RDBPL.DBPL_V_DB0_TypeTache_Id; //{ "Id" };
        public static readonly string PL_V_PL0_TypeTache_LblId = RDBPL.DBPL_V_DB0_TypeTache_LblId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeTache_LgdId = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeTache_TtpId = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //{ "Id" };
        public static readonly string PL_V_PL0_TypeTache_HlpId = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //{ "Id" };

        public static readonly string PL_V_PL0_TypeTache_Logicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeTache_LblLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeTache_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeTache_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL0_TypeTache_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL0_TypeTache_Libelle = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeTache_LblLibelle = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeTache_LgdLibelle = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeTache_TtpLibelle = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //{ "Libelle" };
        public static readonly string PL_V_PL0_TypeTache_HlpLibelle = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //{ "Libelle" };

        public static readonly string PL_V_PL0_TypeTache_Id_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeTache_LblId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeTache_LgdId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeTache_TtpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL0_TypeTache_HlpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_HlpId_espaceclient; //{ "Id_espaceclient" };

        #endregion

        #region PL0_Utilisateur_

        public readonly static string PL_V_PL0_Utilisateur_Id = RDBPL.DBPL_V_DB0_Utilisateur_Id; //"Id";
        public readonly static string PL_V_PL0_Utilisateur_LblId = RDBPL.DBPL_V_DB0_Utilisateur_LblId; //"Id";
        public readonly static string PL_V_PL0_Utilisateur_LgdId = RDBPL.DBPL_V_DB0_Utilisateur_LgdId; //"Id";
        public readonly static string PL_V_PL0_Utilisateur_TtpId = RDBPL.DBPL_V_DB0_Utilisateur_TtpId; //"Id";
        public readonly static string PL_V_PL0_Utilisateur_HlpId = RDBPL.DBPL_V_DB0_Utilisateur_HlpId; //"Id";

        public readonly static string PL_V_PL0_Utilisateur_Object = RDBPL.DBPL_V_DB0_Utilisateur_Object; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_ObjectList = RDBPL.DBPL_V_DB0_Utilisateur_ObjectList; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_TitrePage = RDBPL.DBPL_V_DB0_Utilisateur_TitrePage; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_HelpPage = RDBPL.DBPL_V_DB0_Utilisateur_HelpPage; //"Identite";

        public readonly static string PL_V_PL0_Utilisateur_Logicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Utilisateur_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Utilisateur_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Utilisateur_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Utilisateur_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_Utilisateur_Modif = RDBPL.DBPL_V_DB0_Utilisateur_Modif; //"Modif";
        public readonly static string PL_V_PL0_Utilisateur_LblModif = RDBPL.DBPL_V_DB0_Utilisateur_LblModif; //"Modif";
        public readonly static string PL_V_PL0_Utilisateur_LgdModif = RDBPL.DBPL_V_DB0_Utilisateur_LgdModif; //"Modif";
        public readonly static string PL_V_PL0_Utilisateur_TtpModif = RDBPL.DBPL_V_DB0_Utilisateur_TtpModif; //"Modif";
        public readonly static string PL_V_PL0_Utilisateur_HlpModif = RDBPL.DBPL_V_DB0_Utilisateur_HlpModif; //"Pt_modif";

        public readonly static string PL_V_PL0_Utilisateur_Id_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Utilisateur_LblId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Utilisateur_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Utilisateur_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Utilisateur_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_HlpId_espaceclient; //"Id_espaceclient";

        public readonly static string PL_V_PL0_Utilisateur_Nom = RDBPL.DBPL_V_DB0_Utilisateur_Nom; //"Nom";
        public readonly static string PL_V_PL0_Utilisateur_LblNom = RDBPL.DBPL_V_DB0_Utilisateur_LblNom; //"Nom";
        public readonly static string PL_V_PL0_Utilisateur_LgdNom = RDBPL.DBPL_V_DB0_Utilisateur_LgdNom; //"Nom";
        public readonly static string PL_V_PL0_Utilisateur_TtpNom = RDBPL.DBPL_V_DB0_Utilisateur_TtpNom; //"Nom";
        public readonly static string PL_V_PL0_Utilisateur_HlpNom = RDBPL.DBPL_V_DB0_Utilisateur_HlpNom; //"Identite";

        public readonly static string PL_V_PL0_Utilisateur_Prenom = RDBPL.DBPL_V_DB0_Utilisateur_Prenom; //"Prenom";
        public readonly static string PL_V_PL0_Utilisateur_LblPrenom = RDBPL.DBPL_V_DB0_Utilisateur_LblPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Utilisateur_LgdPrenom = RDBPL.DBPL_V_DB0_Utilisateur_LgdPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Utilisateur_TtpPrenom = RDBPL.DBPL_V_DB0_Utilisateur_TtpPrenom; //"Prenom";
        public readonly static string PL_V_PL0_Utilisateur_HlpPrenom = RDBPL.DBPL_V_DB0_Utilisateur_HlpPrenom; //"Identite";

        public readonly static string PL_V_PL0_Utilisateur_Feminin = RDBPL.DBPL_V_DB0_Utilisateur_Feminin; //"Feminin";
        public readonly static string PL_V_PL0_Utilisateur_LblFeminin = RDBPL.DBPL_V_DB0_Utilisateur_LblFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Utilisateur_LgdFeminin = RDBPL.DBPL_V_DB0_Utilisateur_LgdFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Utilisateur_TtpFeminin = RDBPL.DBPL_V_DB0_Utilisateur_TtpFeminin; //"Feminin";
        public readonly static string PL_V_PL0_Utilisateur_HlpFeminin = RDBPL.DBPL_V_DB0_Utilisateur_HlpFeminin; //"Identite";

        public readonly static string PL_V_PL0_Utilisateur_Identite = "Identité";
        public readonly static string PL_V_PL0_Utilisateur_LblIdentite = PL_V_PL0_Utilisateur_Identite; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_LgdIdentite = PL_V_PL0_Utilisateur_Identite; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_TtpIdentite = PL_V_PL0_Utilisateur_Identite; //"Identite";
        public readonly static string PL_V_PL0_Utilisateur_HlpIdentite = ""; //"Identite";

        #endregion

        #region PL0_Version_

        public readonly static string PL_V_PL0_Version_Id = RDBPL.DBPL_V_DB0_Version_Id; //"Id";
        public readonly static string PL_V_PL0_Version_LblId = RDBPL.DBPL_V_DB0_Version_LblId; //"Id";
        public readonly static string PL_V_PL0_Version_LgdId = RDBPL.DBPL_V_DB0_Version_LgdId; //"Id";
        public readonly static string PL_V_PL0_Version_TtpId = RDBPL.DBPL_V_DB0_Version_TtpId; //"Id";
        public readonly static string PL_V_PL0_Version_HlpId = RDBPL.DBPL_V_DB0_Version_HlpId; //"Id";

        public readonly static string PL_V_PL0_Version_Object = RDBPL.DBPL_V_DB0_Version_Object; //"Id_planning";
        public readonly static string PL_V_PL0_Version_ObjectList = RDBPL.DBPL_V_DB0_Version_ObjectList; //"Id_planning";
        public readonly static string PL_V_PL0_Version_TitrePage = RDBPL.DBPL_V_DB0_Version_TitrePage; //"Id_planning";
        public readonly static string PL_V_PL0_Version_HelpPage = RDBPL.DBPL_V_DB0_Version_HelpPage; //"Id_planning";

        public readonly static string PL_V_PL0_Version_Logicaldeleted = RDBPL.DBPL_V_DB0_Version_Logicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Version_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Version_LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Version_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Version_LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Version_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Version_TtpLogicaldeleted; //"Logicaldeleted";
        public readonly static string PL_V_PL0_Version_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Version_HlpLogicaldeleted; //"Logicaldeleted";

        public readonly static string PL_V_PL0_Version_Libelle = RDBPL.DBPL_V_DB0_Version_Libelle; //"Libelle";
        public readonly static string PL_V_PL0_Version_LblLibelle = RDBPL.DBPL_V_DB0_Version_LblLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Version_LgdLibelle = RDBPL.DBPL_V_DB0_Version_LgdLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Version_TtpLibelle = RDBPL.DBPL_V_DB0_Version_TtpLibelle; //"Libelle";
        public readonly static string PL_V_PL0_Version_HlpLibelle = RDBPL.DBPL_V_DB0_Version_HlpLibelle; //"Libelle";

        public readonly static string PL_V_PL0_Version_Id_planning = RDBPL.DBPL_V_DB0_Version_Id_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Version_LblId_planning = RDBPL.DBPL_V_DB0_Version_LblId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Version_LgdId_planning = RDBPL.DBPL_V_DB0_Version_LgdId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Version_TtpId_planning = RDBPL.DBPL_V_DB0_Version_TtpId_planning; //"Id_planning";
        public readonly static string PL_V_PL0_Version_HlpId_planning = RDBPL.DBPL_V_DB0_Version_HlpId_planning; //"Id_planning";

        public readonly static string PL_V_PL0_Version_Abreviation = RDBPL.DBPL_V_DB0_Version_Abreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Version_LblAbreviation = RDBPL.DBPL_V_DB0_Version_LblAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Version_LgdAbreviation = RDBPL.DBPL_V_DB0_Version_LgdAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Version_TtpAbreviation = RDBPL.DBPL_V_DB0_Version_TtpAbreviation; //"Abreviation";
        public readonly static string PL_V_PL0_Version_HlpAbreviation = RDBPL.DBPL_V_DB0_Version_HlpAbreviation; //"Abreviation";

        public readonly static string PL_V_PL0_Version_Figee = RDBPL.DBPL_V_DB0_Version_Figee; //"Figee";
        public readonly static string PL_V_PL0_Version_LblFigee = RDBPL.DBPL_V_DB0_Version_LblFigee; //"Figee";
        public readonly static string PL_V_PL0_Version_LgdFigee = RDBPL.DBPL_V_DB0_Version_LgdFigee; //"Figee";
        public readonly static string PL_V_PL0_Version_TtpFigee = RDBPL.DBPL_V_DB0_Version_TtpFigee; //"Figee";
        public readonly static string PL_V_PL0_Version_HlpFigee = RDBPL.DBPL_V_DB0_Version_HlpFigee; //"Figee";

        public readonly static string PL_V_PL0_Version_Debut = RDBPL.DBPL_V_DB0_Planning_Debut; //"Debut";
        public readonly static string PL_V_PL0_Version_LblDebut = RDBPL.DBPL_V_DB0_Planning_LblDebut; //"Debut";
        public readonly static string PL_V_PL0_Version_LgdDebut = RDBPL.DBPL_V_DB0_Planning_LgdDebut; //"Debut";
        public readonly static string PL_V_PL0_Version_TtpDebut = RDBPL.DBPL_V_DB0_Planning_TtpDebut; //"Debut";
        public readonly static string PL_V_PL0_Version_HlpDebut = RDBPL.DBPL_V_DB0_Planning_HlpDebut; //"Debut";

        public readonly static string PL_V_PL0_Version_Fin = RDBPL.DBPL_V_DB0_Planning_Fin; //"Fin";
        public readonly static string PL_V_PL0_Version_LblFin = RDBPL.DBPL_V_DB0_Planning_LblFin; //"Fin";
        public readonly static string PL_V_PL0_Version_LgdFin = RDBPL.DBPL_V_DB0_Planning_LgdFin; //"Fin";
        public readonly static string PL_V_PL0_Version_TtpFin = RDBPL.DBPL_V_DB0_Planning_TtpFin; //"Fin";
        public readonly static string PL_V_PL0_Version_HlpFin = RDBPL.DBPL_V_DB0_Planning_HlpFin; //"Fin";

        public readonly static string PL_V_PL0_Version_Id_espaceclient = RDBPL.DBPL_V_DB0_Version_Id_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Version_LblId_espaceclient = RDBPL.DBPL_V_DB0_Version_LblId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Version_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Version_LgdId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Version_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Version_TtpId_espaceclient; //"Id_espaceclient";
        public readonly static string PL_V_PL0_Version_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Version_HlpId_espaceclient; //"Id_espaceclient";

        public static readonly string PL_V_PL0_Version_Lib_planning_version = RDBPL.DBPL_V_DB0_Version_Libelle;
        public static readonly string PL_V_PL0_Version_LblLib_planning_version = RDBPL.DBPL_V_DB0_Version_LblLibelle; //{ "Lib_planningversion" };
        public static readonly string PL_V_PL0_Version_LgdLib_planning_version = RDBPL.DBPL_V_DB0_Version_LgdLibelle; //{ "Lib_planningversion" };
        public static readonly string PL_V_PL0_Version_TtpLib_planning_version = RDBPL.DBPL_V_DB0_Version_TtpLibelle; //{ "Lib_planningversion" };
        public static readonly string PL_V_PL0_Version_HlpLib_planning_version = RDBPL.DBPL_V_DB0_Version_HlpLibelle; //{ "Lib_planningversion" };

        public static readonly string PL_V_PL0_Version_Abr_planning_version = RDBPL.DBPL_V_DB0_Version_Abreviation;
        public static readonly string PL_V_PL0_Version_LblAbr_planning_version = RDBPL.DBPL_V_DB0_Version_LblAbreviation; //{ "Abr_planningversion" };
        public static readonly string PL_V_PL0_Version_LgdAbr_planning_version = RDBPL.DBPL_V_DB0_Version_LgdAbreviation; //{ "Abr_planningversion" };
        public static readonly string PL_V_PL0_Version_TtpAbr_planning_version = RDBPL.DBPL_V_DB0_Version_TtpAbreviation; //{ "Abr_planningversion" };
        public static readonly string PL_V_PL0_Version_HlpAbr_planning_version = RDBPL.DBPL_V_DB0_Version_HlpAbreviation; //{ "Abr_planningversion" };

        public static readonly string PL_V_PL0_Version_Lib_planning = RDBPL.DBPL_V_DB0_Planning_Libelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Version_LblLib_planning = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Version_LgdLib_planning = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Version_TtpLib_planning = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //{ "Lib_planning" };
        public static readonly string PL_V_PL0_Version_HlpLib_planning = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //{ "Lib_planning" };

        public static readonly string PL_V_PL0_Version_Abr_planning = RDBPL.DBPL_V_DB0_Planning_Abreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Version_LblAbr_planning = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Version_LgdAbr_planning = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Version_TtpAbr_planning = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //{ "Abr_planning" };
        public static readonly string PL_V_PL0_Version_HlpAbr_planning = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //{ "Abr_planning" };

        #endregion

        #region PL9_Droits

        public static readonly string PL_V_PL9_Droits_Object = RDBPL.DBPL_V_DB0_Utilisateur_Object;
        public static readonly string PL_V_PL9_Droits_ObjectList = RDBPL.DBPL_V_DB0_Utilisateur_ObjectList;
        public static readonly string PL_V_PL9_Droits_TitrePage = RDBPL.DBPL_V_DB0_Utilisateur_TitrePage;
        public static readonly string PL_V_PL9_Droits_HelpPage = RDBPL.DBPL_V_DB0_Utilisateur_HelpPage;

        // Colonnes supplémentaires
        public static readonly string PL_V_PL9_Droits_Id = RDBPL.DBPL_V_DB0_Utilisateur_Id; //{ "Id" };
        public static readonly string PL_V_PL9_Droits_LblId = RDBPL.DBPL_V_DB0_Utilisateur_LblId; //{ "Id" };
        public static readonly string PL_V_PL9_Droits_LgdId = RDBPL.DBPL_V_DB0_Utilisateur_LgdId; //{ "Id" };
        public static readonly string PL_V_PL9_Droits_TtpId = RDBPL.DBPL_V_DB0_Utilisateur_TtpId; //{ "Id" };
        public static readonly string PL_V_PL9_Droits_HlpId = RDBPL.DBPL_V_DB0_Utilisateur_HlpId; //{ "Id" };

        public static readonly string PL_V_PL9_Droits_Logicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL9_Droits_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL9_Droits_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL9_Droits_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string PL_V_PL9_Droits_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_HlpLogicaldeleted; //{ "Logicaldeleted" };

        public static readonly string PL_V_PL9_Droits_Modif = RDBPL.DBPL_V_DB0_Utilisateur_Modif; //{ "Modif" };
        public static readonly string PL_V_PL9_Droits_LblModif = RDBPL.DBPL_V_DB0_Utilisateur_LblModif; //{ "Modif" };
        public static readonly string PL_V_PL9_Droits_LgdModif = RDBPL.DBPL_V_DB0_Utilisateur_LgdModif; //{ "Modif" };
        public static readonly string PL_V_PL9_Droits_TtpModif = RDBPL.DBPL_V_DB0_Utilisateur_TtpModif; //{ "Modif" };
        public static readonly string PL_V_PL9_Droits_HlpModif = RDBPL.DBPL_V_DB0_Utilisateur_HlpModif; //{ "Modif" };

        public static readonly string PL_V_PL9_Droits_Id_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL9_Droits_LblId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL9_Droits_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL9_Droits_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string PL_V_PL9_Droits_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_HlpId_espaceclient; //{ "Id_espaceclient" };

        public static readonly string PL_V_PL9_Droits_Nom = RDBPL.DBPL_V_DB0_Utilisateur_Nom; //{ "Nom" };
        public static readonly string PL_V_PL9_Droits_LblNom = RDBPL.DBPL_V_DB0_Utilisateur_LblNom; //{ "Nom" };
        public static readonly string PL_V_PL9_Droits_LgdNom = RDBPL.DBPL_V_DB0_Utilisateur_LgdNom; //{ "Nom" };
        public static readonly string PL_V_PL9_Droits_TtpNom = RDBPL.DBPL_V_DB0_Utilisateur_TtpNom; //{ "Nom" };
        public static readonly string PL_V_PL9_Droits_HlpNom = RDBPL.DBPL_V_DB0_Utilisateur_HlpNom; //{ "Nom" };

        public static readonly string PL_V_PL9_Droits_Prenom = RDBPL.DBPL_V_DB0_Utilisateur_Prenom; //{ "Prenom" };
        public static readonly string PL_V_PL9_Droits_LblPrenom = RDBPL.DBPL_V_DB0_Utilisateur_LblPrenom; //{ "Prenom" };
        public static readonly string PL_V_PL9_Droits_LgdPrenom = RDBPL.DBPL_V_DB0_Utilisateur_LgdPrenom; //{ "Prenom" };
        public static readonly string PL_V_PL9_Droits_TtpPrenom = RDBPL.DBPL_V_DB0_Utilisateur_TtpPrenom; //{ "Prenom" };
        public static readonly string PL_V_PL9_Droits_HlpPrenom = RDBPL.DBPL_V_DB0_Utilisateur_HlpPrenom; //{ "Prenom" };

        public static readonly string PL_V_PL9_Droits_Feminin = RDBPL.DBPL_V_DB0_Utilisateur_Feminin; //{ "Feminin" };
        public static readonly string PL_V_PL9_Droits_LblFeminin = RDBPL.DBPL_V_DB0_Utilisateur_LblFeminin; //{ "Feminin" };
        public static readonly string PL_V_PL9_Droits_LgdFeminin = RDBPL.DBPL_V_DB0_Utilisateur_LgdFeminin; //{ "Feminin" };
        public static readonly string PL_V_PL9_Droits_TtpFeminin = RDBPL.DBPL_V_DB0_Utilisateur_TtpFeminin; //{ "Feminin" };
        public static readonly string PL_V_PL9_Droits_HlpFeminin = RDBPL.DBPL_V_DB0_Utilisateur_HlpFeminin; //{ "Feminin" };

        public static readonly string PL_V_PL9_Droits_Identite = PL_V_PL0_Utilisateur_Identite; //{ "Identite" };
        public static readonly string PL_V_PL9_Droits_LblIdentite = PL_V_PL0_Utilisateur_LblIdentite; //{ "Identite" };
        public static readonly string PL_V_PL9_Droits_LgdIdentite = PL_V_PL0_Utilisateur_LgdIdentite; //{ "Identite" };
        public static readonly string PL_V_PL9_Droits_TtpIdentite = PL_V_PL0_Utilisateur_TtpIdentite; //{ "Identite" };
        public static readonly string PL_V_PL9_Droits_HlpIdentite = PL_V_PL0_Utilisateur_HlpIdentite; //{ "Identite" };

        #endregion

        /*
                   #region PL0_Action_

                   public readonly static string PL_V_PL0_Action_Id = RDBPL.DBPL_V_DB0_Action_Id; //"Id";
                   public readonly static string PL_V_PL0_Action_LblId = RDBPL.DBPL_V_DB0_Action_LblId; //"Id";
                   public readonly static string PL_V_PL0_Action_LgdId = RDBPL.DBPL_V_DB0_Action_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Action_TtpId = RDBPL.DBPL_V_DB0_Action_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Action_Object = RDBPL.DBPL_V_DB0_Action_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_ObjectList = RDBPL.DBPL_V_DB0_Action_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_TitrePage = RDBPL.DBPL_V_DB0_Action_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_Action_Logicaldeleted = RDBPL.DBPL_V_DB0_Action_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Action_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Action_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Action_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Action_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Action_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Action_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Action_Libelle = RDBPL.DBPL_V_DB0_Action_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Action_LblLibelle = RDBPL.DBPL_V_DB0_Action_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Action_LgdLibelle = RDBPL.DBPL_V_DB0_Action_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Action_TtpLibelle = RDBPL.DBPL_V_DB0_Action_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Action_Abreviation = RDBPL.DBPL_V_DB0_Action_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Action_LblAbreviation = RDBPL.DBPL_V_DB0_Action_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Action_LgdAbreviation = RDBPL.DBPL_V_DB0_Action_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Action_TtpAbreviation = RDBPL.DBPL_V_DB0_Action_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Action_Id_planning = RDBPL.DBPL_V_DB0_Action_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_LblId_planning = RDBPL.DBPL_V_DB0_Action_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_LgdId_planning = RDBPL.DBPL_V_DB0_Action_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_TtpId_planning = RDBPL.DBPL_V_DB0_Action_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Action_Id_espaceclient = RDBPL.DBPL_V_DB0_Action_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Action_LblId_espaceclient = RDBPL.DBPL_V_DB0_Action_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Action_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Action_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Action_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Action_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Application_

                   public readonly static string PL_V_PL0_Application_Id = RDBPL.DBPL_V_DB0_Application_Id; //"Id";
                   public readonly static string PL_V_PL0_Application_LblId = RDBPL.DBPL_V_DB0_Application_LblId; //"Id";
                   public readonly static string PL_V_PL0_Application_LgdId = RDBPL.DBPL_V_DB0_Application_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Application_TtpId = RDBPL.DBPL_V_DB0_Application_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Application_Object = RDBPL.DBPL_V_DB0_Application_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_ObjectList = RDBPL.DBPL_V_DB0_Application_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_TitrePage = RDBPL.DBPL_V_DB0_Application_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_Application_Logicaldeleted = RDBPL.DBPL_V_DB0_Application_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Application_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Application_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Application_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Application_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Application_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Application_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Application_Libelle = RDBPL.DBPL_V_DB0_Application_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Application_LblLibelle = RDBPL.DBPL_V_DB0_Application_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Application_LgdLibelle = RDBPL.DBPL_V_DB0_Application_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Application_TtpLibelle = RDBPL.DBPL_V_DB0_Application_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Application_Abreviation = RDBPL.DBPL_V_DB0_Application_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Application_LblAbreviation = RDBPL.DBPL_V_DB0_Application_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Application_LgdAbreviation = RDBPL.DBPL_V_DB0_Application_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Application_TtpAbreviation = RDBPL.DBPL_V_DB0_Application_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Application_Id_planning = RDBPL.DBPL_V_DB0_Application_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_LblId_planning = RDBPL.DBPL_V_DB0_Application_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_LgdId_planning = RDBPL.DBPL_V_DB0_Application_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_TtpId_planning = RDBPL.DBPL_V_DB0_Application_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Application_Id_espaceclient = RDBPL.DBPL_V_DB0_Application_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Application_LblId_espaceclient = RDBPL.DBPL_V_DB0_Application_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Application_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Application_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Application_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Application_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Calendrier_

                   public readonly static string PL_V_PL0_Calendrier_Id = RDBPL.DBPL_V_DB0_Calendrier_Id; //"Id";
                   public readonly static string PL_V_PL0_Calendrier_LblId = RDBPL.DBPL_V_DB0_Calendrier_LblId; //"Id";
                   public readonly static string PL_V_PL0_Calendrier_LgdId = RDBPL.DBPL_V_DB0_Calendrier_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Calendrier_TtpId = RDBPL.DBPL_V_DB0_Calendrier_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Calendrier_Object = RDBPL.DBPL_V_DB0_Calendrier_Object; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_ObjectList = RDBPL.DBPL_V_DB0_Calendrier_ObjectList; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_TitrePage = RDBPL.DBPL_V_DB0_Calendrier_TitrePage; //"Id_uniteperiode";

                   public readonly static string PL_V_PL0_Calendrier_Logicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Calendrier_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Calendrier_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Calendrier_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Calendrier_Debut = RDBPL.DBPL_V_DB0_Calendrier_Debut; //"Debut";
                   public readonly static string PL_V_PL0_Calendrier_LblDebut = RDBPL.DBPL_V_DB0_Calendrier_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Calendrier_LgdDebut = RDBPL.DBPL_V_DB0_Calendrier_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Calendrier_TtpDebut = RDBPL.DBPL_V_DB0_Calendrier_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Calendrier_Fin = RDBPL.DBPL_V_DB0_Calendrier_Fin; //"Fin";
                   public readonly static string PL_V_PL0_Calendrier_LblFin = RDBPL.DBPL_V_DB0_Calendrier_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_Calendrier_LgdFin = RDBPL.DBPL_V_DB0_Calendrier_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_Calendrier_TtpFin = RDBPL.DBPL_V_DB0_Calendrier_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_Calendrier_Periode = RDBPL.DBPL_V_DB0_Calendrier_Periode; //"Periode";
                   public readonly static string PL_V_PL0_Calendrier_LblPeriode = RDBPL.DBPL_V_DB0_Calendrier_LblPeriode; //"Periode";
                   public readonly static string PL_V_PL0_Calendrier_LgdPeriode = RDBPL.DBPL_V_DB0_Calendrier_LgdPeriode; //"Periode";
                   public readonly static string PL_V_PL0_Calendrier_TtpPeriode = RDBPL.DBPL_V_DB0_Calendrier_TtpPeriode; //"Periode";

                   public readonly static string PL_V_PL0_Calendrier_Finperiode = RDBPL.DBPL_V_DB0_Calendrier_Finperiode; //"Finperiode";
                   public readonly static string PL_V_PL0_Calendrier_LblFinperiode = RDBPL.DBPL_V_DB0_Calendrier_LblFinperiode; //"Finperiode";
                   public readonly static string PL_V_PL0_Calendrier_LgdFinperiode = RDBPL.DBPL_V_DB0_Calendrier_LgdFinperiode; //"Finperiode";
                   public readonly static string PL_V_PL0_Calendrier_TtpFinperiode = RDBPL.DBPL_V_DB0_Calendrier_TtpFinperiode; //"Finperiode";

                   public readonly static string PL_V_PL0_Calendrier_Id_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_Id_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_LblId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_LblId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_LgdId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_LgdId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_TtpId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_TtpId_uniteperiode; //"Id_uniteperiode";

                   public readonly static string PL_V_PL0_Calendrier_Id_equipe = RDBPL.DBPL_V_DB0_Calendrier_Id_equipe; //"Id_equipe";
                   public readonly static string PL_V_PL0_Calendrier_LblId_equipe = RDBPL.DBPL_V_DB0_Calendrier_LblId_equipe; //"Id_equipe";
                   public readonly static string PL_V_PL0_Calendrier_LgdId_equipe = RDBPL.DBPL_V_DB0_Calendrier_LgdId_equipe; //"Id_equipe";
                   public readonly static string PL_V_PL0_Calendrier_TtpId_equipe = RDBPL.DBPL_V_DB0_Calendrier_TtpId_equipe; //"Id_equipe";

                   public readonly static string PL_V_PL0_Calendrier_Abreviation = RDBPL.DBPL_V_DB0_Calendrier_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Calendrier_LblAbreviation = RDBPL.DBPL_V_DB0_Calendrier_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Calendrier_LgdAbreviation = RDBPL.DBPL_V_DB0_Calendrier_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Calendrier_TtpAbreviation = RDBPL.DBPL_V_DB0_Calendrier_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Calendrier_Duree = RDBPL.DBPL_V_DB0_Calendrier_Duree; //"Duree";
                   public readonly static string PL_V_PL0_Calendrier_LblDuree = RDBPL.DBPL_V_DB0_Calendrier_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Calendrier_LgdDuree = RDBPL.DBPL_V_DB0_Calendrier_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Calendrier_TtpDuree = RDBPL.DBPL_V_DB0_Calendrier_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_Calendrier_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Calendrier_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Calendrier_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Calendrier_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Calendrier_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Calendrier_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Calendrier_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Calendrier_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Calendrier_Id_contrainte = RDBPL.DBPL_V_DB0_Calendrier_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Calendrier_LblId_contrainte = RDBPL.DBPL_V_DB0_Calendrier_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Calendrier_LgdId_contrainte = RDBPL.DBPL_V_DB0_Calendrier_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Calendrier_TtpId_contrainte = RDBPL.DBPL_V_DB0_Calendrier_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Calendrier_Id_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Calendrier_LblId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Calendrier_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Calendrier_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion


                   #region PL0_ModeTravail_

                   public readonly static string PL_V_PL0_ModeTravail_Id = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id";
                   public readonly static string PL_V_PL0_ModeTravail_LblId = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id";
                   public readonly static string PL_V_PL0_ModeTravail_LgdId = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ModeTravail_TtpId = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id";

                   public readonly static string PL_V_PL0_ModeTravail_Object = RDBPL.DBPL_V_DB0_ModeTravail_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_ObjectList = RDBPL.DBPL_V_DB0_ModeTravail_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_TitrePage = RDBPL.DBPL_V_DB0_ModeTravail_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_ModeTravail_Logicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ModeTravail_LblLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ModeTravail_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ModeTravail_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_ModeTravail_Libelle = RDBPL.DBPL_V_DB0_ModeTravail_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_ModeTravail_LblLibelle = RDBPL.DBPL_V_DB0_ModeTravail_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_ModeTravail_LgdLibelle = RDBPL.DBPL_V_DB0_ModeTravail_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_ModeTravail_TtpLibelle = RDBPL.DBPL_V_DB0_ModeTravail_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_ModeTravail_Abreviation = RDBPL.DBPL_V_DB0_ModeTravail_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_ModeTravail_LblAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_ModeTravail_LgdAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_ModeTravail_TtpAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_ModeTravail_Id_planning = RDBPL.DBPL_V_DB0_ModeTravail_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_LblId_planning = RDBPL.DBPL_V_DB0_ModeTravail_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_LgdId_planning = RDBPL.DBPL_V_DB0_ModeTravail_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_TtpId_planning = RDBPL.DBPL_V_DB0_ModeTravail_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_ModeTravail_Id_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ModeTravail_LblId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ModeTravail_LgdId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ModeTravail_TtpId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion


                   #region PL0_Projet_

                   public readonly static string PL_V_PL0_Projet_Id = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PL0_Projet_LblId = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PL0_Projet_LgdId = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Projet_TtpId = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Projet_Object = RDBPL.DBPL_V_DB0_Projet_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_ObjectList = RDBPL.DBPL_V_DB0_Projet_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_TitrePage = RDBPL.DBPL_V_DB0_Projet_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_Projet_Logicaldeleted = RDBPL.DBPL_V_DB0_Projet_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Projet_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Projet_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Projet_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Projet_Libelle = RDBPL.DBPL_V_DB0_Projet_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Projet_LblLibelle = RDBPL.DBPL_V_DB0_Projet_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Projet_LgdLibelle = RDBPL.DBPL_V_DB0_Projet_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Projet_TtpLibelle = RDBPL.DBPL_V_DB0_Projet_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Projet_Abreviation = RDBPL.DBPL_V_DB0_Projet_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Projet_LblAbreviation = RDBPL.DBPL_V_DB0_Projet_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Projet_LgdAbreviation = RDBPL.DBPL_V_DB0_Projet_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Projet_TtpAbreviation = RDBPL.DBPL_V_DB0_Projet_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Projet_Id_planning = RDBPL.DBPL_V_DB0_Projet_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_LblId_planning = RDBPL.DBPL_V_DB0_Projet_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_LgdId_planning = RDBPL.DBPL_V_DB0_Projet_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_TtpId_planning = RDBPL.DBPL_V_DB0_Projet_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Projet_Id_espaceclient = RDBPL.DBPL_V_DB0_Projet_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Projet_LblId_espaceclient = RDBPL.DBPL_V_DB0_Projet_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Projet_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Projet_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Projet_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Projet_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Societe_

                   public readonly static string PL_V_PL0_Societe_Id = RDBPL.DBPL_V_DB0_Societe_Id; //"Id";
                   public readonly static string PL_V_PL0_Societe_LblId = RDBPL.DBPL_V_DB0_Societe_LblId; //"Id";
                   public readonly static string PL_V_PL0_Societe_LgdId = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Societe_TtpId = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Societe_Object = RDBPL.DBPL_V_DB0_Societe_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_ObjectList = RDBPL.DBPL_V_DB0_Societe_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_TitrePage = RDBPL.DBPL_V_DB0_Societe_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_Societe_Logicaldeleted = RDBPL.DBPL_V_DB0_Societe_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Societe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Societe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Societe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Societe_Libelle = RDBPL.DBPL_V_DB0_Societe_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Societe_LblLibelle = RDBPL.DBPL_V_DB0_Societe_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Societe_LgdLibelle = RDBPL.DBPL_V_DB0_Societe_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Societe_TtpLibelle = RDBPL.DBPL_V_DB0_Societe_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Societe_Abreviation = RDBPL.DBPL_V_DB0_Societe_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Societe_LblAbreviation = RDBPL.DBPL_V_DB0_Societe_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Societe_LgdAbreviation = RDBPL.DBPL_V_DB0_Societe_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Societe_TtpAbreviation = RDBPL.DBPL_V_DB0_Societe_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Societe_Id_planning = RDBPL.DBPL_V_DB0_Societe_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_LblId_planning = RDBPL.DBPL_V_DB0_Societe_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_LgdId_planning = RDBPL.DBPL_V_DB0_Societe_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_TtpId_planning = RDBPL.DBPL_V_DB0_Societe_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Societe_Id_espaceclient = RDBPL.DBPL_V_DB0_Societe_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Societe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Societe_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Societe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Societe_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Societe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Societe_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Statut_

                   public readonly static string PL_V_PL0_Statut_Id = RDBPL.DBPL_V_DB0_Statut_Id; //"Id";
                   public readonly static string PL_V_PL0_Statut_LblId = RDBPL.DBPL_V_DB0_Statut_LblId; //"Id";
                   public readonly static string PL_V_PL0_Statut_LgdId = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Statut_TtpId = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Statut_Object = RDBPL.DBPL_V_DB0_Statut_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_ObjectList = RDBPL.DBPL_V_DB0_Statut_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_TitrePage = RDBPL.DBPL_V_DB0_Statut_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_Statut_Logicaldeleted = RDBPL.DBPL_V_DB0_Statut_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Statut_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Statut_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Statut_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Statut_Libelle = RDBPL.DBPL_V_DB0_Statut_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Statut_LblLibelle = RDBPL.DBPL_V_DB0_Statut_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Statut_LgdLibelle = RDBPL.DBPL_V_DB0_Statut_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Statut_TtpLibelle = RDBPL.DBPL_V_DB0_Statut_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Statut_Abreviation = RDBPL.DBPL_V_DB0_Statut_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Statut_LblAbreviation = RDBPL.DBPL_V_DB0_Statut_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Statut_LgdAbreviation = RDBPL.DBPL_V_DB0_Statut_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Statut_TtpAbreviation = RDBPL.DBPL_V_DB0_Statut_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_Statut_Id_planning = RDBPL.DBPL_V_DB0_Statut_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_LblId_planning = RDBPL.DBPL_V_DB0_Statut_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_LgdId_planning = RDBPL.DBPL_V_DB0_Statut_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_TtpId_planning = RDBPL.DBPL_V_DB0_Statut_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Statut_Id_espaceclient = RDBPL.DBPL_V_DB0_Statut_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Statut_LblId_espaceclient = RDBPL.DBPL_V_DB0_Statut_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Statut_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Statut_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Statut_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Statut_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_TypeTache_

                   public readonly static string PL_V_PL0_TypeTache_Id = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Id";
                   public readonly static string PL_V_PL0_TypeTache_LblId = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Id";
                   public readonly static string PL_V_PL0_TypeTache_LgdId = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Id";
                   public readonly static string PL_V_PL0_TypeTache_TtpId = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Id";

                   public readonly static string PL_V_PL0_TypeTache_Object = RDBPL.DBPL_V_DB0_TypeTache_Object; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_ObjectList = RDBPL.DBPL_V_DB0_TypeTache_ObjectList; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_TitrePage = RDBPL.DBPL_V_DB0_TypeTache_TitrePage; //"Abreviation";

                   public readonly static string PL_V_PL0_TypeTache_Logicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TypeTache_LblLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TypeTache_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TypeTache_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_TypeTache_Libelle = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_TypeTache_LblLibelle = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_TypeTache_LgdLibelle = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_TypeTache_TtpLibelle = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_TypeTache_Abreviation = RDBPL.DBPL_V_DB0_TypeTache_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_LblAbreviation = RDBPL.DBPL_V_DB0_TypeTache_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_LgdAbreviation = RDBPL.DBPL_V_DB0_TypeTache_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_TtpAbreviation = RDBPL.DBPL_V_DB0_TypeTache_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_TypeTache_Id_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TypeTache_LblId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TypeTache_LgdId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TypeTache_TtpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_UniteHoraire_

                   public readonly static string PL_V_PL0_UniteHoraire_Id = RDBPL.DBPL_V_DB0_UniteHoraire_Id; //"Id";
                   public readonly static string PL_V_PL0_UniteHoraire_LblId = RDBPL.DBPL_V_DB0_UniteHoraire_LblId; //"Id";
                   public readonly static string PL_V_PL0_UniteHoraire_LgdId = RDBPL.DBPL_V_DB0_UniteHoraire_LgdId; //"Id";
                   public readonly static string PL_V_PL0_UniteHoraire_TtpId = RDBPL.DBPL_V_DB0_UniteHoraire_TtpId; //"Id";

                   public readonly static string PL_V_PL0_UniteHoraire_Object = RDBPL.DBPL_V_DB0_UniteHoraire_Object; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_ObjectList = RDBPL.DBPL_V_DB0_UniteHoraire_ObjectList; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_TitrePage = RDBPL.DBPL_V_DB0_UniteHoraire_TitrePage; //"Abreviation";

                   public readonly static string PL_V_PL0_UniteHoraire_Logicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_UniteHoraire_LblLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_UniteHoraire_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_UniteHoraire_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_UniteHoraire_Libelle = RDBPL.DBPL_V_DB0_UniteHoraire_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_UniteHoraire_LblLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_UniteHoraire_LgdLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_UniteHoraire_TtpLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_UniteHoraire_Abreviation = RDBPL.DBPL_V_DB0_UniteHoraire_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_LblAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_LgdAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_TtpAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PL0_UniteHoraire_Id_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_UniteHoraire_LblId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_UniteHoraire_LgdId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_UniteHoraire_TtpId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion



                   #region PL0_Planification

                   public readonly static string PL_V_PL0_Planification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_Planification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_Planification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Planification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Planification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Lib_version";

                   public readonly static string PL_V_PL0_Planification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Planification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Planification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Planification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Planification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Planification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Planification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Planification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Planification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_Planification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Planification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Planification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_Planification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_Planification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_Planification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_Planification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_Planification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Planification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Planification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Planification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_Planification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Planification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Planification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Planification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_Planification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Planification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Planification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Planification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_Planification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Planification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Planification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Planification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_Planification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Planification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Planification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Planification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_Planification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_Planification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Planification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Planification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_Planification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Planification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Planification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Planification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_Planification_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_planning";
                   public readonly static string PL_V_PL0_Planification_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_planning";
                   public readonly static string PL_V_PL0_Planification_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_planning";
                   public readonly static string PL_V_PL0_Planification_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_planning";


                   public readonly static string PL_V_PL0_Planification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_Planification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_Planification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_Planification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_Planification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Planification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Planification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Planification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_espaceclient";


                   // Colonnes supplémentaires
                   //public readonly static string PL_V_PL0_Planification_Id_recap = DB_ConstPT.DB0_Contrainte_Id_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Planification_LblId_recap = DB_ConstPT.DB0_Contrainte_LblId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Planification_LgdId_recap = DB_ConstPT.DB0_Contrainte_LgdId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Planification_TtpId_recap = DB_ConstPT.DB0_Contrainte_TtpId_recap; //"Id_recap";

                   //public readonly static string PL_V_PL0_Planification_Ordre = DB_ConstPT.DB0_Contrainte_Ordre; //"Ordre";
                   //public readonly static string PL_V_PL0_Planification_LblOrdre = DB_ConstPT.DB0_Contrainte_LblOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Planification_LgdOrdre = DB_ConstPT.DB0_Contrainte_LgdOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Planification_TtpOrdre = DB_ConstPT.DB0_Contrainte_TtpOrdre; //"Ordre";

                   public readonly static string PL_V_PL0_Planification_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_Planification_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Planification_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Planification_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Planification_Id_type = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Id_type";
                   public readonly static string PL_V_PL0_Planification_LblId_type = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Id_type";
                   public readonly static string PL_V_PL0_Planification_LgdId_type = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Id_type";
                   public readonly static string PL_V_PL0_Planification_TtpId_type = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Id_type";

                   public readonly static string PL_V_PL0_Planification_Lib_type = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Lib_type";
                   public readonly static string PL_V_PL0_Planification_LblLib_type = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Lib_type";
                   public readonly static string PL_V_PL0_Planification_LgdLib_type = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Lib_type";
                   public readonly static string PL_V_PL0_Planification_TtpLib_type = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Lib_type";

                   public readonly static string PL_V_PL0_Planification_Abr_type = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Abr_type";
                   public readonly static string PL_V_PL0_Planification_LblAbr_type = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Abr_type";
                   public readonly static string PL_V_PL0_Planification_LgdAbr_type = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Abr_type";
                   public readonly static string PL_V_PL0_Planification_TtpAbr_type = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Abr_type";

                   public readonly static string PL_V_PL0_Planification_Lib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Id; //"Lib_contrainte";
                   public readonly static string PL_V_PL0_Planification_LblLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblId; //"Lib_contrainte";
                   public readonly static string PL_V_PL0_Planification_LgdLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdId; //"Lib_contrainte";
                   public readonly static string PL_V_PL0_Planification_TtpLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpId; //"Lib_contrainte";

                   //public readonly static string PL_V_PL0_Planification_Id_type = DB_ConstPT.DB0_Contrainte_Id_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Planification_LblId_type = DB_ConstPT.DB0_Contrainte_LblId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Planification_LgdId_type = DB_ConstPT.DB0_Contrainte_LgdId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Planification_TtpId_type = DB_ConstPT.DB0_Contrainte_TtpId_type; //"Id_type";

                   //public readonly static string PL_V_PL0_Planification_Lib_recap = DB_ConstPT.DB0_Contrainte_Id_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Planification_LblLib_recap = DB_ConstPT.DB0_Contrainte_LblId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Planification_LgdLib_recap = DB_ConstPT.DB0_Contrainte_LgdId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Planification_TtpLib_recap = DB_ConstPT.DB0_Contrainte_TtpId_recap; //"Lib_recap";

                   //public readonly static string PL_V_PL0_Planification_Infocontrainte = DB_ConstPT.DB0_Contrainte_Info; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Planification_LblInfocontrainte = DB_ConstPT.DB0_Contrainte_LblInfo; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Planification_LgdInfocontrainte = DB_ConstPT.DB0_Contrainte_LgdInfo; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Planification_TtpInfocontrainte = DB_ConstPT.DB0_Contrainte_TtpInfo; //"Infocontrainte";

                   public readonly static string PL_V_PL0_Planification_Ident_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Ident_employe";
                   public readonly static string PL_V_PL0_Planification_LblIdent_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Planification_LgdIdent_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Planification_TtpIdent_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Ident_employe";

                   public readonly static string PL_V_PL0_Planification_Init_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Init_employe";
                   public readonly static string PL_V_PL0_Planification_LblInit_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Init_employe";
                   public readonly static string PL_V_PL0_Planification_LgdInit_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Init_employe";
                   public readonly static string PL_V_PL0_Planification_TtpInit_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Init_employe";

                   public readonly static string PL_V_PL0_Planification_Lib_version = RDBPL.DBPL_V_DB0_Version_Id; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_LblLib_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_LgdLib_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_TtpLib_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Lib_version";

                   public readonly static string PL_V_PL0_Planification_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Planification_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Planification_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Planification_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Planification_Debut = RDBPL.Debut; //"Debut";
                   public readonly static string PL_V_PL0_Planification_LblDebut = RDBPL.LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Planification_LgdDebut = RDBPL.LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Planification_TtpDebut = RDBPL.TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Planification_Fin = RDBPL.Fin; //"Fin";
                   public readonly static string PL_V_PL0_Planification_LblFin = RDBPL.LblFin; //"Fin";
                   public readonly static string PL_V_PL0_Planification_LgdFin = RDBPL.LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_Planification_TtpFin = RDBPL.TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_Planification_Duree = RDBPL.Duree; //"Duree";
                   public readonly static string PL_V_PL0_Planification_LblDuree = RDBPL.LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Planification_LgdDuree = RDBPL.LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Planification_TtpDuree = RDBPL.TtpDuree; //"Duree";

                   #endregion

                   #region PL0_Realisation

                   //public readonly static string PL_V_PL0_Realisation_Id = DB_ConstPT._Id; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LblId = DB_ConstPT._LblId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LgdId = DB_ConstPT._LgdId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_TtpId = DB_ConstPT._TtpId; //"Id";

                   //public readonly static string PL_V_PL0_Realisation_Object = DB_ConstPT._Object; //"Lib_projet";
                   //public readonly static string PL_V_PL0_Realisation_ObjectList = DB_ConstPT._ObjectList; //"Lib_projet";
                   //public readonly static string PL_V_PL0_Realisation_TitrePage = DB_ConstPT._TitrePage; //"Lib_projet";


                   //public readonly static string PL_V_PL0_Realisation_Debut = DB_ConstPT._Debut; //"Debut";
                   //public readonly static string PL_V_PL0_Realisation_LblDebut = DB_ConstPT._LblDebut; //"Debut";
                   //public readonly static string PL_V_PL0_Realisation_LgdDebut = DB_ConstPT._LgdDebut; //"Debut";
                   //public readonly static string PL_V_PL0_Realisation_TtpDebut = DB_ConstPT._TtpDebut; //"Debut";

                   //public readonly static string PL_V_PL0_Realisation_Duree = DB_ConstPT._Duree; //"Duree";
                   //public readonly static string PL_V_PL0_Realisation_LblDuree = DB_ConstPT._LblDuree; //"Duree";
                   //public readonly static string PL_V_PL0_Realisation_LgdDuree = DB_ConstPT._LgdDuree; //"Duree";
                   //public readonly static string PL_V_PL0_Realisation_TtpDuree = DB_ConstPT._TtpDuree; //"Duree";

                   //public readonly static string PL_V_PL0_Realisation_Id_contrainte = DB_ConstPT._Id_contrainte; //"Id_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblId_contrainte = DB_ConstPT._LblId_contrainte; //"Id_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_contrainte = DB_ConstPT._LgdId_contrainte; //"Id_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_contrainte = DB_ConstPT._TtpId_contrainte; //"Id_contrainte";

                   //public readonly static string PL_V_PL0_Realisation_Fin = DB_ConstPT._Fin; //"Fin";
                   //public readonly static string PL_V_PL0_Realisation_LblFin = DB_ConstPT._LblFin; //"Fin";
                   //public readonly static string PL_V_PL0_Realisation_LgdFin = DB_ConstPT._LgdFin; //"Fin";
                   //public readonly static string PL_V_PL0_Realisation_TtpFin = DB_ConstPT._TtpFin; //"Fin";

                   //public readonly static string PL_V_PL0_Realisation_Id_societe = DB_ConstPT._Id_societe; //"Id_societe";
                   //public readonly static string PL_V_PL0_Realisation_LblId_societe = DB_ConstPT._LblId_societe; //"Id_societe";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_societe = DB_ConstPT._LgdId_societe; //"Id_societe";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_societe = DB_ConstPT._TtpId_societe; //"Id_societe";

                   //public readonly static string PL_V_PL0_Realisation_Id_application = DB_ConstPT._Id_application; //"Id_application";
                   //public readonly static string PL_V_PL0_Realisation_LblId_application = DB_ConstPT._LblId_application; //"Id_application";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_application = DB_ConstPT._LgdId_application; //"Id_application";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_application = DB_ConstPT._TtpId_application; //"Id_application";

                   //public readonly static string PL_V_PL0_Realisation_Id_modetravail = DB_ConstPT._Id_modetravail; //"Id_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LblId_modetravail = DB_ConstPT._LblId_modetravail; //"Id_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_modetravail = DB_ConstPT._LgdId_modetravail; //"Id_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_modetravail = DB_ConstPT._TtpId_modetravail; //"Id_modetravail";

                   //public readonly static string PL_V_PL0_Realisation_Id_action = DB_ConstPT._Id_action; //"Id_action";
                   //public readonly static string PL_V_PL0_Realisation_LblId_action = DB_ConstPT._LblId_action; //"Id_action";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_action = DB_ConstPT._LgdId_action; //"Id_action";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_action = DB_ConstPT._TtpId_action; //"Id_action";

                   //public readonly static string PL_V_PL0_Realisation_Id_employe = DB_ConstPT._Id_employe; //"Id_employe";
                   //public readonly static string PL_V_PL0_Realisation_LblId_employe = DB_ConstPT._LblId_employe; //"Id_employe";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_employe = DB_ConstPT._LgdId_employe; //"Id_employe";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_employe = DB_ConstPT._TtpId_employe; //"Id_employe";

                   //public readonly static string PL_V_PL0_Realisation_Id_projet = DB_ConstPT._Id_projet; //"Id_projet";
                   //public readonly static string PL_V_PL0_Realisation_LblId_projet = DB_ConstPT._LblId_projet; //"Id_projet";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_projet = DB_ConstPT._LgdId_projet; //"Id_projet";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_projet = DB_ConstPT._TtpId_projet; //"Id_projet";

                   //// Colonnes supplémentaires

                   //public readonly static string PL_V_PL0_Realisation_Libelle = DB_ConstPT.DB0_Contrainte_Libelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_LblLibelle = DB_ConstPT.DB0_Contrainte_LblLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_LgdLibelle = DB_ConstPT.DB0_Contrainte_LgdLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_TtpLibelle = DB_ConstPT.DB0_Contrainte_TtpLibelle; //"Libelle";

                   //public readonly static string PL_V_PL0_Realisation_Debutcalc = DB_ConstPT.DB0_Planification_Debutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_LblDebutcalc = DB_ConstPT.DB0_Planification_LblDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdDebutcalc = DB_ConstPT.DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpDebutcalc = DB_ConstPT.DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   //public readonly static string PL_V_PL0_Realisation_Fincalc = DB_ConstPT.DB0_Planification_Fincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_LblFincalc = DB_ConstPT.DB0_Planification_LblFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdFincalc = DB_ConstPT.DB0_Planification_LgdFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpFincalc = DB_ConstPT.DB0_Planification_TtpFincalc; //"Fincalc";

                   //public readonly static string PL_V_PL0_Realisation_Dureecalc = DB_ConstPT.DB0_Planification_Dureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_LblDureecalc = DB_ConstPT.DB0_Planification_LblDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureecalc = DB_ConstPT.DB0_Planification_LgdDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureecalc = DB_ConstPT.DB0_Planification_TtpDureecalc; //"Dureecalc";

                   //public readonly static string PL_V_PL0_Realisation_Id_planning = DB_ConstPT.DB0_Contrainte_Id_planning; //"Id_planning";
                   //public readonly static string PL_V_PL0_Realisation_LblId_planning = DB_ConstPT.DB0_Contrainte_LblId_planning; //"Id_planning";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_planning = DB_ConstPT.DB0_Contrainte_LgdId_planning; //"Id_planning";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_planning = DB_ConstPT.DB0_Contrainte_TtpId_planning; //"Id_planning";

                   //public readonly static string PL_V_PL0_Realisation_Commentaire = DB_ConstPT.DB0_Contrainte_Commentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_LblCommentaire = DB_ConstPT.DB0_Contrainte_LblCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_LgdCommentaire = DB_ConstPT.DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_TtpCommentaire = DB_ConstPT.DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   //public readonly static string PL_V_PL0_Realisation_Info = DB_ConstPT.DB0_Planification_Info; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_LblInfo = DB_ConstPT.DB0_Planification_LblInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_LgdInfo = DB_ConstPT.DB0_Planification_LgdInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_TtpInfo = DB_ConstPT.DB0_Planification_TtpInfo; //"Info";

                   //public readonly static string PL_V_PL0_Realisation_Ref = DB_ConstPT.DB0_Contrainte_Ref; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_LblRef = DB_ConstPT.DB0_Contrainte_LblRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_LgdRef = DB_ConstPT.DB0_Contrainte_LgdRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_TtpRef = DB_ConstPT.DB0_Contrainte_TtpRef; //"Ref";

                   //public readonly static string PL_V_PL0_Realisation_Lib_contrainte = DB_ConstPT.DB0_Contrainte_Id; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_contrainte = DB_ConstPT.DB0_Contrainte_LblId; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_contrainte = DB_ConstPT.DB0_Contrainte_LgdId; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_contrainte = DB_ConstPT.DB0_Contrainte_TtpId; //"Lib_contrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_type = DB_ConstPT.DB0_TypeTache_Id; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_LblId_type = DB_ConstPT.DB0_TypeTache_LblId; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_type = DB_ConstPT.DB0_TypeTache_LgdId; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_type = DB_ConstPT.DB0_TypeTache_TtpId; //"Id_type";

                   //public readonly static string PL_V_PL0_Realisation_Debutcontrainte = "Début de prévision";
                   //public readonly static string PL_V_PL0_Realisation_LblDebutcontrainte = PL0_Realisation_Debutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdDebutcontrainte = PL0_Realisation_Debutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpDebutcontrainte = PL0_Realisation_Debutcontrainte; //"Debutcontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Dureecontrainte = "Durée prevue";
                   //public readonly static string PL_V_PL0_Realisation_LblDureecontrainte = PL0_Realisation_Dureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureecontrainte = PL0_Realisation_Dureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureecontrainte = PL0_Realisation_Dureecontrainte; //"Dureecontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_recap = DB_ConstPT.DB0_Contrainte_Id_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_LblId_recap = DB_ConstPT.DB0_Contrainte_LblId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_recap = DB_ConstPT.DB0_Contrainte_LgdId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_recap = DB_ConstPT.DB0_Contrainte_TtpId_recap; //"Id_recap";

                   //public readonly static string PL_V_PL0_Realisation_Ordre = DB_ConstPT.DB0_Contrainte_Ordre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_LblOrdre = DB_ConstPT.DB0_Contrainte_LblOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_LgdOrdre = DB_ConstPT.DB0_Contrainte_LgdOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_TtpOrdre = DB_ConstPT.DB0_Contrainte_TtpOrdre; //"Ordre";

                   //public readonly static string PL_V_PL0_Realisation_Infocontrainte = "Information de prévision";
                   //public readonly static string PL_V_PL0_Realisation_LblInfocontrainte = PL0_Realisation_Infocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdInfocontrainte = "Info prévision";
                   //public readonly static string PL_V_PL0_Realisation_TtpInfocontrainte = PL0_Realisation_Infocontrainte; //"Infocontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Fincontrainte = "Fin de prévision";
                   //public readonly static string PL_V_PL0_Realisation_LblFincontrainte = DB_ConstPT.DB0_Contrainte_LblFin; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdFincontrainte = DB_ConstPT.DB0_Contrainte_LgdFin; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpFincontrainte = DB_ConstPT.DB0_Contrainte_TtpFin; //"Fincontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_uniteduree = DB_ConstPT.DB0_Contrainte_Id_uniteduree;
                   //public readonly static string PL_V_PL0_Realisation_LblId_uniteduree = DB_ConstPT.DB0_Contrainte_LblId_uniteduree; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_uniteduree = DB_ConstPT.DB0_Contrainte_LgdId_uniteduree; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_uniteduree = DB_ConstPT.DB0_Contrainte_TtpId_uniteduree; //"Fincontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Recurrente = DB_ConstPT.DB0_Contrainte_Recurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_LblRecurrente = DB_ConstPT.DB0_Contrainte_LblRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_LgdRecurrente = DB_ConstPT.DB0_Contrainte_LgdRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_TtpRecurrente = DB_ConstPT.DB0_Contrainte_TtpRecurrente; //"Recurrente";

                   //public readonly static string PL_V_PL0_Realisation_Periode = DB_ConstPT.DB0_Contrainte_Periode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_LblPeriode = DB_ConstPT.DB0_Contrainte_LblPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_LgdPeriode = DB_ConstPT.DB0_Contrainte_LgdPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_TtpPeriode = DB_ConstPT.DB0_Contrainte_TtpPeriode; //"Periode";

                   //public readonly static string PL_V_PL0_Realisation_Id_uniteperiode = DB_ConstPT.DB0_Contrainte_Id_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LblId_uniteperiode = DB_ConstPT.DB0_Contrainte_LblId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_uniteperiode = DB_ConstPT.DB0_Contrainte_LgdId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_uniteperiode = DB_ConstPT.DB0_Contrainte_TtpId_uniteperiode; //"Id_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Decalesioccupe = DB_ConstPT.DB0_Contrainte_Decalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_LblDecalesioccupe = DB_ConstPT.DB0_Contrainte_LblDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_LgdDecalesioccupe = DB_ConstPT.DB0_Contrainte_LgdDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_TtpDecalesioccupe = DB_ConstPT.DB0_Contrainte_TtpDecalesioccupe; //"Decalesioccupe";

                   //public readonly static string PL_V_PL0_Realisation_Secable = DB_ConstPT.DB0_Contrainte_Secable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_LblSecable = DB_ConstPT.DB0_Contrainte_LblSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_LgdSecable = DB_ConstPT.DB0_Contrainte_LgdSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_TtpSecable = DB_ConstPT.DB0_Contrainte_TtpSecable; //"Secable";

                   //public readonly static string PL_V_PL0_Realisation_Dureemini = DB_ConstPT.DB0_Contrainte_Dureemini; //"Dureemini";
                   //public readonly static string PL_V_PL0_Realisation_LblDureemini = DB_ConstPT.DB0_Contrainte_LblDureemini; //"Dureemini";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureemini = DB_ConstPT.DB0_Contrainte_LgdDureemini; //"Dureemini";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureemini = DB_ConstPT.DB0_Contrainte_TtpDureemini; //"Dureemini";

                   //public readonly static string PL_V_PL0_Realisation_Dureeinitiale = DB_ConstPT.DB0_Contrainte_Dureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_LblDureeinitiale = DB_ConstPT.DB0_Contrainte_LblDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureeinitiale = DB_ConstPT.DB0_Contrainte_LgdDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureeinitiale = DB_ConstPT.DB0_Contrainte_TtpDureeinitiale; //"Dureeinitiale";

                   //public readonly static string PL_V_PL0_Realisation_Abr_type = DB_ConstPT.DB0_TypeTache_Id; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_type = DB_ConstPT.DB0_TypeTache_LblId; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_type = DB_ConstPT.DB0_TypeTache_LgdId; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_type = DB_ConstPT.DB0_TypeTache_TtpId; //"Abr_type";

                   //public readonly static string PL_V_PL0_Realisation_Lib_type = DB_ConstPT.DB0_TypeTache_Id; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_type = DB_ConstPT.DB0_TypeTache_LblId; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_type = DB_ConstPT.DB0_TypeTache_LgdId; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_type = DB_ConstPT.DB0_TypeTache_TtpId; //"Lib_type";

                   //public readonly static string PL_V_PL0_Realisation_Lib_recap = DB_ConstPT.DB0_Contrainte_Id_recap;
                   //public readonly static string PL_V_PL0_Realisation_LblLib_recap = DB_ConstPT.DB0_Contrainte_LblId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_recap = DB_ConstPT.DB0_Contrainte_LgdId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_recap = DB_ConstPT.DB0_Contrainte_TtpId_recap; //"Lib_recap";

                   //public readonly static string PL_V_PL0_Realisation_Abr_uniteduree = DB_ConstPT.DB0_Contrainte_Id_uniteduree;
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_uniteduree = DB_ConstPT.DB0_Contrainte_LblId_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_uniteduree = DB_ConstPT.DB0_Contrainte_LgdId_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_uniteduree = DB_ConstPT.DB0_Contrainte_TtpId_uniteduree; //"Abr_uniteduree";

                   //public readonly static string PL_V_PL0_Realisation_Lib_uniteduree = DB_ConstPT.DB0_Contrainte_Id_uniteduree;
                   //public readonly static string PL_V_PL0_Realisation_LblLib_uniteduree = DB_ConstPT.DB0_Contrainte_LblId_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_uniteduree = DB_ConstPT.DB0_Contrainte_LgdId_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_uniteduree = DB_ConstPT.DB0_Contrainte_TtpId_uniteduree; //"Lib_uniteduree";

                   //public readonly static string PL_V_PL0_Realisation_Abr_uniteperiode = DB_ConstPT.DB0_Contrainte_Id_uniteperiode;
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_uniteperiode = DB_ConstPT.DB0_Contrainte_LblId_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_uniteperiode = DB_ConstPT.DB0_Contrainte_LgdId_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_uniteperiode = DB_ConstPT.DB0_Contrainte_TtpId_uniteperiode; //"Abr_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Lib_uniteperiode = DB_ConstPT.DB0_Contrainte_Id_uniteperiode;
                   //public readonly static string PL_V_PL0_Realisation_LblLib_uniteperiode = DB_ConstPT.DB0_Contrainte_LblId_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_uniteperiode = DB_ConstPT.DB0_Contrainte_LgdId_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_uniteperiode = DB_ConstPT.DB0_Contrainte_TtpId_uniteperiode; //"Lib_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Id_version = DB_ConstPT.DB0_Version_Id; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_LblId_version = DB_ConstPT.DB0_Version_LblId; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_version = DB_ConstPT.DB0_Version_LgdId; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_version = DB_ConstPT.DB0_Version_TtpId; //"Id_version";

                   //public readonly static string PL_V_PL0_Realisation_Abr_societe = DB_ConstPT.DB0_Societe_Id; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_societe = DB_ConstPT.DB0_Societe_LblId; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_societe = DB_ConstPT.DB0_Societe_LgdId; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_societe = DB_ConstPT.DB0_Societe_TtpId; //"Abr_societe";

                   //public readonly static string PL_V_PL0_Realisation_Lib_societe = DB_ConstPT.DB0_Societe_Id; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_societe = DB_ConstPT.DB0_Societe_LblId; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_societe = DB_ConstPT.DB0_Societe_LgdId; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_societe = DB_ConstPT.DB0_Societe_TtpId; //"Lib_societe";

                   //public readonly static string PL_V_PL0_Realisation_Abr_application = DB_ConstPT.DB0_Application_Id; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_application = DB_ConstPT.DB0_Application_LblId; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_application = DB_ConstPT.DB0_Application_LgdId; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_application = DB_ConstPT.DB0_Application_TtpId; //"Abr_application";

                   //public readonly static string PL_V_PL0_Realisation_Lib_application = DB_ConstPT.DB0_Application_Id; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_application = DB_ConstPT.DB0_Application_LblId; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_application = DB_ConstPT.DB0_Application_LgdId; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_application = DB_ConstPT.DB0_Application_TtpId; //"Lib_application";

                   //public readonly static string PL_V_PL0_Realisation_Abr_modetravail = DB_ConstPT.DB0_ModeTravail_Id; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_modetravail = DB_ConstPT.DB0_ModeTravail_LblId; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_modetravail = DB_ConstPT.DB0_ModeTravail_LgdId; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_modetravail = DB_ConstPT.DB0_ModeTravail_TtpId; //"Abr_modetravail";

                   //public readonly static string PL_V_PL0_Realisation_Lib_modetravail = DB_ConstPT.DB0_ModeTravail_Id; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_modetravail = DB_ConstPT.DB0_ModeTravail_LblId; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_modetravail = DB_ConstPT.DB0_ModeTravail_LgdId; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_modetravail = DB_ConstPT.DB0_ModeTravail_TtpId; //"Lib_modetravail";

                   //public readonly static string PL_V_PL0_Realisation_Abr_action = DB_ConstPT.DB0_Action_Id; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_action = DB_ConstPT.DB0_Action_LblId; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_action = DB_ConstPT.DB0_Action_LgdId; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_action = DB_ConstPT.DB0_Action_TtpId; //"Abr_action";

                   //public readonly static string PL_V_PL0_Realisation_Lib_action = DB_ConstPT.DB0_Action_Id; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_action = DB_ConstPT.DB0_Action_LblId; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_action = DB_ConstPT.DB0_Action_LgdId; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_action = DB_ConstPT.DB0_Action_TtpId; //"Lib_action";

                   //public readonly static string PL_V_PL0_Realisation_Init_employe = DB_ConstPT.DB0_Employe_Id; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_LblInit_employe = DB_ConstPT.DB0_Employe_LblId; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_LgdInit_employe = DB_ConstPT.DB0_Employe_LgdId; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_TtpInit_employe = DB_ConstPT.DB0_Employe_TtpId; //"Init_employe";

                   //public readonly static string PL_V_PL0_Realisation_Ident_employe = DB_ConstPT.DB0_Employe_Id; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_LblIdent_employe = DB_ConstPT.DB0_Employe_LblId; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_LgdIdent_employe = DB_ConstPT.DB0_Employe_LgdId; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_TtpIdent_employe = DB_ConstPT.DB0_Employe_TtpId; //"Ident_employe";

                   //public readonly static string PL_V_PL0_Realisation_Abr_projet = DB_ConstPT.DB0_Projet_Id; //"Abr_projet";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_projet = DB_ConstPT.DB0_Projet_LblId; //"Abr_projet";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_projet = DB_ConstPT.DB0_Projet_LgdId; //"Abr_projet";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_projet = DB_ConstPT.DB0_Projet_TtpId; //"Abr_projet";

                   //public readonly static string PL_V_PL0_Realisation_Lib_projet = DB_ConstPT.DB0_Projet_Id; //"Lib_projet";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_projet = DB_ConstPT.DB0_Projet_LblId; //"Lib_projet";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_projet = DB_ConstPT.DB0_Projet_LgdId; //"Lib_projet";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_projet = DB_ConstPT.DB0_Projet_TtpId; //"Lib_projet";

                   #endregion

                   #region PL0_Planification

                   public readonly static string PL_V_PL0_Planification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Planification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Planification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Planification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   #endregion

                   #region PL0_Contrainte

                   public readonly static string PL_V_PL0_Contrainte_Object = RDBPL.DBPL_V_DB0_Contrainte_Object; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_ObjectList = RDBPL.DBPL_V_DB0_Contrainte_ObjectList; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_TitrePage = RDBPL.DBPL_V_DB0_Contrainte_TitrePage; //"Ref";

                   public readonly static string PL_V_PL0_Contrainte_Id = RDBPL.DBPL_V_DB0_Contrainte_Id; //"Id";
                   public readonly static string PL_V_PL0_Contrainte_LblId = RDBPL.DBPL_V_DB0_Contrainte_LblId; //"Id";
                   public readonly static string PL_V_PL0_Contrainte_LgdId = RDBPL.DBPL_V_DB0_Contrainte_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Contrainte_TtpId = RDBPL.DBPL_V_DB0_Contrainte_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Contrainte_Logicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Contrainte_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Contrainte_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Contrainte_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Contrainte_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Contrainte_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Contrainte_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Contrainte_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Contrainte_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Contrainte_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Contrainte_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Contrainte_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Contrainte_Id_typetache = RDBPL.DBPL_V_DB0_Contrainte_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Contrainte_LblId_typetache = RDBPL.DBPL_V_DB0_Contrainte_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Contrainte_LgdId_typetache = RDBPL.DBPL_V_DB0_Contrainte_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Contrainte_TtpId_typetache = RDBPL.DBPL_V_DB0_Contrainte_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_Contrainte_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Contrainte_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Contrainte_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Contrainte_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_Contrainte_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Contrainte_Id_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Contrainte_LblId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Contrainte_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Contrainte_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PT9_Droits_

                   public readonly static string PL_V_PT9_Droits_Id = RDBPL.DBPL_V_DB0_Utilisateur_Id; //"Id";
                   public readonly static string PL_V_PT9_Droits_LblId = RDBPL.DBPL_V_DB0_Utilisateur_LblId; //"Id";
                   public readonly static string PL_V_PT9_Droits_LgdId = RDBPL.DBPL_V_DB0_Utilisateur_LgdId; //"Id";
                   public readonly static string PL_V_PT9_Droits_TtpId = RDBPL.DBPL_V_DB0_Utilisateur_TtpId; //"Id";

                   public readonly static string PL_V_PT9_Droits_Object = "Droits";
                   public readonly static string PL_V_PT9_Droits_ObjectList = "Liste des droits";
                   public readonly static string PL_V_PT9_Droits_TitrePage = "Droits";

                   public readonly static string PL_V_PT9_Droits_Logicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PT9_Droits_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PT9_Droits_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PT9_Droits_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PT9_Droits_Pt_visu = RDBPL.DBPL_V_DB0_Utilisateur_Pt_visu; //"Pt_visu";
                   public readonly static string PL_V_PT9_Droits_LblPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_LblPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PT9_Droits_LgdPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_LgdPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PT9_Droits_TtpPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_TtpPt_visu; //"Pt_visu";

                   public readonly static string PL_V_PT9_Droits_Pt_modif = RDBPL.DBPL_V_DB0_Utilisateur_Pt_modif; //"Pt_modif";
                   public readonly static string PL_V_PT9_Droits_LblPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_LblPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PT9_Droits_LgdPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_LgdPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PT9_Droits_TtpPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_TtpPt_modif; //"Pt_modif";

                   public readonly static string PL_V_PT9_Droits_Identite = RDBPL.DBPL_V_DB0_Utilisateur_Identite; //"Identite";
                   public readonly static string PL_V_PT9_Droits_LblIdentite = RDBPL.DBPL_V_DB0_Utilisateur_LblIdentite; //"Identite";
                   public readonly static string PL_V_PT9_Droits_LgdIdentite = RDBPL.DBPL_V_DB0_Utilisateur_LgdIdentite; //"Identite";
                   public readonly static string PL_V_PT9_Droits_TtpIdentite = RDBPL.DBPL_V_DB0_Utilisateur_TtpIdentite; //"Identite";

                   public readonly static string PL_V_PT9_Droits_Id_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PT9_Droits_LblId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PT9_Droits_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PT9_Droits_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Action_

                   public readonly static string PL_V_PTC_Action_Id = RDBPL.DBPL_V_DB0_Action_Id; //"Id";
                   public readonly static string PL_V_PTC_Action_LblId = RDBPL.DBPL_V_DB0_Action_LblId; //"Id";
                   public readonly static string PL_V_PTC_Action_LgdId = RDBPL.DBPL_V_DB0_Action_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Action_TtpId = RDBPL.DBPL_V_DB0_Action_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Action_Object = RDBPL.DBPL_V_DB0_Action_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_ObjectList = RDBPL.DBPL_V_DB0_Action_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_TitrePage = RDBPL.DBPL_V_DB0_Action_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Action_Logicaldeleted = RDBPL.DBPL_V_DB0_Action_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Action_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Action_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Action_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Action_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Action_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Action_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Action_Libelle = RDBPL.DBPL_V_DB0_Action_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Action_LblLibelle = RDBPL.DBPL_V_DB0_Action_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Action_LgdLibelle = RDBPL.DBPL_V_DB0_Action_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Action_TtpLibelle = RDBPL.DBPL_V_DB0_Action_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Action_Abreviation = RDBPL.DBPL_V_DB0_Action_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Action_LblAbreviation = RDBPL.DBPL_V_DB0_Action_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Action_LgdAbreviation = RDBPL.DBPL_V_DB0_Action_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Action_TtpAbreviation = RDBPL.DBPL_V_DB0_Action_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Action_Id_planning = RDBPL.DBPL_V_DB0_Action_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_LblId_planning = RDBPL.DBPL_V_DB0_Action_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_LgdId_planning = RDBPL.DBPL_V_DB0_Action_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_TtpId_planning = RDBPL.DBPL_V_DB0_Action_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Action_Id_espaceclient = RDBPL.DBPL_V_DB0_Action_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Action_LblId_espaceclient = RDBPL.DBPL_V_DB0_Action_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Action_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Action_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Action_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Action_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Application_

                   public readonly static string PL_V_PTC_Application_Id = RDBPL.DBPL_V_DB0_Application_Id; //"Id";
                   public readonly static string PL_V_PTC_Application_LblId = RDBPL.DBPL_V_DB0_Application_LblId; //"Id";
                   public readonly static string PL_V_PTC_Application_LgdId = RDBPL.DBPL_V_DB0_Application_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Application_TtpId = RDBPL.DBPL_V_DB0_Application_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Application_Object = RDBPL.DBPL_V_DB0_Application_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_ObjectList = RDBPL.DBPL_V_DB0_Application_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_TitrePage = RDBPL.DBPL_V_DB0_Application_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Application_Logicaldeleted = RDBPL.DBPL_V_DB0_Application_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Application_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Application_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Application_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Application_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Application_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Application_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Application_Libelle = RDBPL.DBPL_V_DB0_Application_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Application_LblLibelle = RDBPL.DBPL_V_DB0_Application_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Application_LgdLibelle = RDBPL.DBPL_V_DB0_Application_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Application_TtpLibelle = RDBPL.DBPL_V_DB0_Application_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Application_Abreviation = RDBPL.DBPL_V_DB0_Application_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Application_LblAbreviation = RDBPL.DBPL_V_DB0_Application_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Application_LgdAbreviation = RDBPL.DBPL_V_DB0_Application_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Application_TtpAbreviation = RDBPL.DBPL_V_DB0_Application_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Application_Id_planning = RDBPL.DBPL_V_DB0_Application_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_LblId_planning = RDBPL.DBPL_V_DB0_Application_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_LgdId_planning = RDBPL.DBPL_V_DB0_Application_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_TtpId_planning = RDBPL.DBPL_V_DB0_Application_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Application_Id_espaceclient = RDBPL.DBPL_V_DB0_Application_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Application_LblId_espaceclient = RDBPL.DBPL_V_DB0_Application_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Application_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Application_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Application_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Application_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Calendrier_

                   public readonly static string PL_V_PTC_Calendrier_Object = RDBPL.DBPL_V_DB0_Calendrier_Object; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_ObjectList = RDBPL.DBPL_V_DB0_Calendrier_ObjectList; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_TitrePage = RDBPL.DBPL_V_DB0_Calendrier_TitrePage; //"Id_uniteperiode";

                   public readonly static string PL_V_PTC_Calendrier_Logicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Calendrier_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Calendrier_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Calendrier_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_TtpLogicaldeleted; //"Logicaldeleted";

                   //public readonly static string PL_V_PTC_Calendrier_Id_planning = DB_ConstPT.DB0_Calendrier_Id_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Calendrier_LblId_planning = DB_ConstPT.DB0_Calendrier_LblId_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Calendrier_LgdId_planning = DB_ConstPT.DB0_Calendrier_LgdId_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Calendrier_TtpId_planning = DB_ConstPT.DB0_Calendrier_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Calendrier_Debut = RDBPL.DBPL_V_DB0_Calendrier_Debut; //"Debut";
                   public readonly static string PL_V_PTC_Calendrier_LblDebut = RDBPL.DBPL_V_DB0_Calendrier_LblDebut; //"Debut";
                   public readonly static string PL_V_PTC_Calendrier_LgdDebut = RDBPL.DBPL_V_DB0_Calendrier_LgdDebut; //"Debut";
                   public readonly static string PL_V_PTC_Calendrier_TtpDebut = RDBPL.DBPL_V_DB0_Calendrier_TtpDebut; //"Debut";

                   public readonly static string PL_V_PTC_Calendrier_Fin = RDBPL.DBPL_V_DB0_Calendrier_Fin; //"Fin";
                   public readonly static string PL_V_PTC_Calendrier_LblFin = RDBPL.DBPL_V_DB0_Calendrier_LblFin; //"Fin";
                   public readonly static string PL_V_PTC_Calendrier_LgdFin = RDBPL.DBPL_V_DB0_Calendrier_LgdFin; //"Fin";
                   public readonly static string PL_V_PTC_Calendrier_TtpFin = RDBPL.DBPL_V_DB0_Calendrier_TtpFin; //"Fin";

                   public readonly static string PL_V_PTC_Calendrier_Periode = RDBPL.DBPL_V_DB0_Calendrier_Periode; //"Periode";
                   public readonly static string PL_V_PTC_Calendrier_LblPeriode = RDBPL.DBPL_V_DB0_Calendrier_LblPeriode; //"Periode";
                   public readonly static string PL_V_PTC_Calendrier_LgdPeriode = RDBPL.DBPL_V_DB0_Calendrier_LgdPeriode; //"Periode";
                   public readonly static string PL_V_PTC_Calendrier_TtpPeriode = RDBPL.DBPL_V_DB0_Calendrier_TtpPeriode; //"Periode";

                   public readonly static string PL_V_PTC_Calendrier_Finperiode = RDBPL.DBPL_V_DB0_Calendrier_Finperiode; //"Finperiode";
                   public readonly static string PL_V_PTC_Calendrier_LblFinperiode = RDBPL.DBPL_V_DB0_Calendrier_LblFinperiode; //"Finperiode";
                   public readonly static string PL_V_PTC_Calendrier_LgdFinperiode = RDBPL.DBPL_V_DB0_Calendrier_LgdFinperiode; //"Finperiode";
                   public readonly static string PL_V_PTC_Calendrier_TtpFinperiode = RDBPL.DBPL_V_DB0_Calendrier_TtpFinperiode; //"Finperiode";

                   public readonly static string PL_V_PTC_Calendrier_Id_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_Id_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_LblId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_LblId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_LgdId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_LgdId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_TtpId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_TtpId_uniteperiode; //"Id_uniteperiode";

                   public readonly static string PL_V_PTC_Calendrier_Id_espaceclient = RDBPL.DBPL_V_DB0_Calendrier_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Calendrier_LblId_espaceclient = RDBPL.DBPL_V_DB0_Calendrier_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Calendrier_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Calendrier_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Calendrier_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Calendrier_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Employe_

                   public readonly static string PL_V_PTC_Employe_Id = RDBPL.DBPL_V_DB0_Employe_Id; //"Id";
                   public readonly static string PL_V_PTC_Employe_LblId = RDBPL.DBPL_V_DB0_Employe_LblId; //"Id";
                   public readonly static string PL_V_PTC_Employe_LgdId = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Employe_TtpId = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Employe_Object = RDBPL.DBPL_V_DB0_Employe_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_ObjectList = RDBPL.DBPL_V_DB0_Employe_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_TitrePage = RDBPL.DBPL_V_DB0_Employe_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Employe_Logicaldeleted = RDBPL.DBPL_V_DB0_Employe_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Employe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Employe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Employe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Employe_Initiales = RDBPL.DBPL_V_DB0_Employe_Initiales; //"Initiales";
                   public readonly static string PL_V_PTC_Employe_LblInitiales = RDBPL.DBPL_V_DB0_Employe_LblInitiales; //"Initiales";
                   public readonly static string PL_V_PTC_Employe_LgdInitiales = RDBPL.DBPL_V_DB0_Employe_LgdInitiales; //"Initiales";
                   public readonly static string PL_V_PTC_Employe_TtpInitiales = RDBPL.DBPL_V_DB0_Employe_TtpInitiales; //"Initiales";

                   public readonly static string PL_V_PTC_Employe_Identite = RDBPL.DBPL_V_DB0_Employe_Identite; //"Identite";
                   public readonly static string PL_V_PTC_Employe_LblIdentite = RDBPL.DBPL_V_DB0_Employe_LblIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Employe_LgdIdentite = RDBPL.DBPL_V_DB0_Employe_LgdIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Employe_TtpIdentite = RDBPL.DBPL_V_DB0_Employe_TtpIdentite; //"Identite";

                   public readonly static string PL_V_PTC_Employe_Id_planning = RDBPL.DBPL_V_DB0_Employe_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_LblId_planning = RDBPL.DBPL_V_DB0_Employe_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_LgdId_planning = RDBPL.DBPL_V_DB0_Employe_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_TtpId_planning = RDBPL.DBPL_V_DB0_Employe_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Employe_Id_espaceclient = RDBPL.DBPL_V_DB0_Employe_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Employe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Employe_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Employe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Employe_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Employe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Employe_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Equipe

                   public readonly static string PL_V_PTC_Equipe_Id = RDBPL.DBPL_V_DB0_Equipe_Id; //"Id";
                   public readonly static string PL_V_PTC_Equipe_LblId = RDBPL.DBPL_V_DB0_Equipe_LblId; //"Id";
                   public readonly static string PL_V_PTC_Equipe_LgdId = RDBPL.DBPL_V_DB0_Equipe_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Equipe_TtpId = RDBPL.DBPL_V_DB0_Equipe_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Equipe_Object = RDBPL.DBPL_V_DB0_Equipe_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_ObjectList = RDBPL.DBPL_V_DB0_Equipe_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_TitrePage = RDBPL.DBPL_V_DB0_Equipe_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Equipe_Logicaldeleted = RDBPL.DBPL_V_DB0_Equipe_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Equipe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Equipe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Equipe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Equipe_Libelle = RDBPL.DBPL_V_DB0_Equipe_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Equipe_LblLibelle = RDBPL.DBPL_V_DB0_Equipe_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Equipe_LgdLibelle = RDBPL.DBPL_V_DB0_Equipe_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Equipe_TtpLibelle = RDBPL.DBPL_V_DB0_Equipe_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Equipe_Abreviation = RDBPL.DBPL_V_DB0_Equipe_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Equipe_LblAbreviation = RDBPL.DBPL_V_DB0_Equipe_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Equipe_LgdAbreviation = RDBPL.DBPL_V_DB0_Equipe_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Equipe_TtpAbreviation = RDBPL.DBPL_V_DB0_Equipe_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Equipe_Id_planning = RDBPL.DBPL_V_DB0_Equipe_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_LblId_planning = RDBPL.DBPL_V_DB0_Equipe_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_LgdId_planning = RDBPL.DBPL_V_DB0_Equipe_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_TtpId_planning = RDBPL.DBPL_V_DB0_Equipe_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Equipe_Id_espaceclient = RDBPL.DBPL_V_DB0_Equipe_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Equipe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Equipe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Equipe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_ModeTravail_

                   public readonly static string PL_V_PTC_ModeTravail_Id = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id";
                   public readonly static string PL_V_PTC_ModeTravail_LblId = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id";
                   public readonly static string PL_V_PTC_ModeTravail_LgdId = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id";
                   public readonly static string PL_V_PTC_ModeTravail_TtpId = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id";

                   public readonly static string PL_V_PTC_ModeTravail_Object = RDBPL.DBPL_V_DB0_ModeTravail_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_ObjectList = RDBPL.DBPL_V_DB0_ModeTravail_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_TitrePage = RDBPL.DBPL_V_DB0_ModeTravail_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_ModeTravail_Logicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_ModeTravail_LblLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_ModeTravail_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_ModeTravail_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_ModeTravail_Libelle = RDBPL.DBPL_V_DB0_ModeTravail_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_ModeTravail_LblLibelle = RDBPL.DBPL_V_DB0_ModeTravail_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_ModeTravail_LgdLibelle = RDBPL.DBPL_V_DB0_ModeTravail_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_ModeTravail_TtpLibelle = RDBPL.DBPL_V_DB0_ModeTravail_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_ModeTravail_Abreviation = RDBPL.DBPL_V_DB0_ModeTravail_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_ModeTravail_LblAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_ModeTravail_LgdAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_ModeTravail_TtpAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_ModeTravail_Id_planning = RDBPL.DBPL_V_DB0_ModeTravail_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_LblId_planning = RDBPL.DBPL_V_DB0_ModeTravail_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_LgdId_planning = RDBPL.DBPL_V_DB0_ModeTravail_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_TtpId_planning = RDBPL.DBPL_V_DB0_ModeTravail_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_ModeTravail_Id_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_ModeTravail_LblId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_ModeTravail_LgdId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_ModeTravail_TtpId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Planification_

                   public readonly static string PL_V_PTC_Planification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_employe";

                   public readonly static string PL_V_PTC_Planification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Planification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Planification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Planification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Planification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   //public readonly static string PL_V_PTC_Planification_Info = DB_ConstPT.DB0_Planification_Info; //"Info";
                   //public readonly static string PL_V_PTC_Planification_LblInfo = DB_ConstPT.DB0_Planification_LblInfo; //"Info";
                   //public readonly static string PL_V_PTC_Planification_LgdInfo = DB_ConstPT.DB0_Planification_LgdInfo; //"Info";
                   //public readonly static string PL_V_PTC_Planification_TtpInfo = DB_ConstPT.DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PTC_Planification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public readonly static string PL_V_PTC_Planification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public readonly static string PL_V_PTC_Planification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PTC_Planification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   //public readonly static string PL_V_PTC_Planification_Fincalc = DB_ConstPT.DB0_Planification_Fincalc; //"Fincalc";
                   //public readonly static string PL_V_PTC_Planification_LblFincalc = DB_ConstPT.DB0_Planification_LblFincalc; //"Fincalc";
                   //public readonly static string PL_V_PTC_Planification_LgdFincalc = DB_ConstPT.DB0_Planification_LgdFincalc; //"Fincalc";
                   //public readonly static string PL_V_PTC_Planification_TtpFincalc = DB_ConstPT.DB0_Planification_TtpFincalc; //"Fincalc";

                   //public readonly static string PL_V_PTC_Planification_Debutcalc = DB_ConstPT.DB0_Planification_Debutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PTC_Planification_LblDebutcalc = DB_ConstPT.DB0_Planification_LblDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PTC_Planification_LgdDebutcalc = DB_ConstPT.DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PTC_Planification_TtpDebutcalc = DB_ConstPT.DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   //public readonly static string PL_V_PTC_Planification_Dureecalc = DB_ConstPT.DB0_Planification_Dureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PTC_Planification_LblDureecalc = DB_ConstPT.DB0_Planification_LblDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PTC_Planification_LgdDureecalc = DB_ConstPT.DB0_Planification_LgdDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PTC_Planification_TtpDureecalc = DB_ConstPT.DB0_Planification_TtpDureecalc; //"Dureecalc";

                   //public readonly static string PL_V_PTC_Planification_Realise = DB_ConstPT.DB0_Planification_Realise; //"Realise";
                   //public readonly static string PL_V_PTC_Planification_LblRealise = DB_ConstPT.DB0_Planification_LblRealise; //"Realise";
                   //public readonly static string PL_V_PTC_Planification_LgdRealise = DB_ConstPT.DB0_Planification_LgdRealise; //"Realise";
                   //public readonly static string PL_V_PTC_Planification_TtpRealise = DB_ConstPT.DB0_Planification_TtpRealise; //"Realise";

                   public readonly static string PL_V_PTC_Planification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PTC_Planification_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_planning";
                   public readonly static string PL_V_PTC_Planification_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_planning";
                   public readonly static string PL_V_PTC_Planification_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_planning";
                   public readonly static string PL_V_PTC_Planification_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_planning";

                   public readonly static string PL_V_PTC_Planification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_espaceclient";

                   #endregion

                   #region PTC_Planning_

                   public readonly static string PL_V_PTC_Planning_Id = RDBPL.DBPL_V_DB0_Planning_Id; //"Id";
                   public readonly static string PL_V_PTC_Planning_LblId = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id";
                   public readonly static string PL_V_PTC_Planning_LgdId = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Planning_TtpId = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Planning_Object = RDBPL.DBPL_V_DB0_Planning_Object; //"Fin";
                   public readonly static string PL_V_PTC_Planning_ObjectList = RDBPL.DBPL_V_DB0_Planning_ObjectList; //"Fin";
                   public readonly static string PL_V_PTC_Planning_TitrePage = RDBPL.DBPL_V_DB0_Planning_TitrePage; //"Fin";

                   public readonly static string PL_V_PTC_Planning_Logicaldeleted = RDBPL.DBPL_V_DB0_Planning_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planning_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planning_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planning_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Planning_Libelle = RDBPL.DBPL_V_DB0_Planning_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Planning_LblLibelle = RDBPL.DBPL_V_DB0_Planning_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Planning_LgdLibelle = RDBPL.DBPL_V_DB0_Planning_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Planning_TtpLibelle = RDBPL.DBPL_V_DB0_Planning_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Planning_Abreviation = RDBPL.DBPL_V_DB0_Planning_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Planning_LblAbreviation = RDBPL.DBPL_V_DB0_Planning_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Planning_LgdAbreviation = RDBPL.DBPL_V_DB0_Planning_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Planning_TtpAbreviation = RDBPL.DBPL_V_DB0_Planning_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Planning_Debut = RDBPL.DBPL_V_DB0_Planning_Debut; //"Debut";
                   public readonly static string PL_V_PTC_Planning_LblDebut = RDBPL.DBPL_V_DB0_Planning_LblDebut; //"Debut";
                   public readonly static string PL_V_PTC_Planning_LgdDebut = RDBPL.DBPL_V_DB0_Planning_LgdDebut; //"Debut";
                   public readonly static string PL_V_PTC_Planning_TtpDebut = RDBPL.DBPL_V_DB0_Planning_TtpDebut; //"Debut";

                   public readonly static string PL_V_PTC_Planning_Fin = RDBPL.DBPL_V_DB0_Planning_Fin; //"Fin";
                   public readonly static string PL_V_PTC_Planning_LblFin = RDBPL.DBPL_V_DB0_Planning_LblFin; //"Fin";
                   public readonly static string PL_V_PTC_Planning_LgdFin = RDBPL.DBPL_V_DB0_Planning_LgdFin; //"Fin";
                   public readonly static string PL_V_PTC_Planning_TtpFin = RDBPL.DBPL_V_DB0_Planning_TtpFin; //"Fin";

                   public readonly static string PL_V_PTC_Planning_Id_espaceclient = RDBPL.DBPL_V_DB0_Planning_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planning_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planning_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planning_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Planning_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Projet_

                   public readonly static string PL_V_PTC_Projet_Id = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PTC_Projet_LblId = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PTC_Projet_LgdId = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Projet_TtpId = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Projet_Object = RDBPL.DBPL_V_DB0_Projet_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_ObjectList = RDBPL.DBPL_V_DB0_Projet_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_TitrePage = RDBPL.DBPL_V_DB0_Projet_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Projet_Logicaldeleted = RDBPL.DBPL_V_DB0_Projet_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Projet_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Projet_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Projet_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Projet_Libelle = RDBPL.DBPL_V_DB0_Projet_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Projet_LblLibelle = RDBPL.DBPL_V_DB0_Projet_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Projet_LgdLibelle = RDBPL.DBPL_V_DB0_Projet_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Projet_TtpLibelle = RDBPL.DBPL_V_DB0_Projet_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Projet_Abreviation = RDBPL.DBPL_V_DB0_Projet_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Projet_LblAbreviation = RDBPL.DBPL_V_DB0_Projet_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Projet_LgdAbreviation = RDBPL.DBPL_V_DB0_Projet_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Projet_TtpAbreviation = RDBPL.DBPL_V_DB0_Projet_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Projet_Id_planning = RDBPL.DBPL_V_DB0_Projet_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_LblId_planning = RDBPL.DBPL_V_DB0_Projet_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_LgdId_planning = RDBPL.DBPL_V_DB0_Projet_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_TtpId_planning = RDBPL.DBPL_V_DB0_Projet_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Projet_Id_espaceclient = RDBPL.DBPL_V_DB0_Projet_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Projet_LblId_espaceclient = RDBPL.DBPL_V_DB0_Projet_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Projet_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Projet_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Projet_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Projet_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Realisation_

                   public readonly static string PL_V_PTC_Realisation_Object = RDBPL.DBPL_V_DB0_Realisation_Object; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_ObjectList = RDBPL.DBPL_V_DB0_Realisation_ObjectList; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_TitrePage = RDBPL.DBPL_V_DB0_Realisation_TitrePage; //"Id_contrainte";

                   public readonly static string PL_V_PTC_Realisation_Logicaldeleted = RDBPL.DBPL_V_DB0_Realisation_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Realisation_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Realisation_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Realisation_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Realisation_Debut = RDBPL.DBPL_V_DB0_Realisation_Debut; //"Debut";
                   public readonly static string PL_V_PTC_Realisation_LblDebut = RDBPL.DBPL_V_DB0_Realisation_LblDebut; //"Debut";
                   public readonly static string PL_V_PTC_Realisation_LgdDebut = RDBPL.DBPL_V_DB0_Realisation_LgdDebut; //"Debut";
                   public readonly static string PL_V_PTC_Realisation_TtpDebut = RDBPL.DBPL_V_DB0_Realisation_TtpDebut; //"Debut";

                   public readonly static string PL_V_PTC_Realisation_Fin = RDBPL.DBPL_V_DB0_Realisation_Fin; //"Fin";
                   public readonly static string PL_V_PTC_Realisation_LblFin = RDBPL.DBPL_V_DB0_Realisation_LblFin; //"Fin";
                   public readonly static string PL_V_PTC_Realisation_LgdFin = RDBPL.DBPL_V_DB0_Realisation_LgdFin; //"Fin";
                   public readonly static string PL_V_PTC_Realisation_TtpFin = RDBPL.DBPL_V_DB0_Realisation_TtpFin; //"Fin";

                   //public readonly static string PL_V_PTC_Realisation_Libelle = DB_ConstPT._Libelle; //"Libelle";
                   //public readonly static string PL_V_PTC_Realisation_LblLibelle = DB_ConstPT._LblLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_Realisation_LgdLibelle = DB_ConstPT._LgdLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_Realisation_TtpLibelle = DB_ConstPT._TtpLibelle; //"Libelle";

                   //public readonly static string PL_V_PTC_Realisation_Commentaire = DB_ConstPT._Commentaire; //"Commentaire";
                   //public readonly static string PL_V_PTC_Realisation_LblCommentaire = DB_ConstPT._LblCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PTC_Realisation_LgdCommentaire = DB_ConstPT._LgdCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PTC_Realisation_TtpCommentaire = DB_ConstPT._TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PTC_Realisation_Id_action = RDBPL.DBPL_V_DB0_Realisation_Id_action; //"Id_action";
                   public readonly static string PL_V_PTC_Realisation_LblId_action = RDBPL.DBPL_V_DB0_Realisation_LblId_action; //"Id_action";
                   public readonly static string PL_V_PTC_Realisation_LgdId_action = RDBPL.DBPL_V_DB0_Realisation_LgdId_action; //"Id_action";
                   public readonly static string PL_V_PTC_Realisation_TtpId_action = RDBPL.DBPL_V_DB0_Realisation_TtpId_action; //"Id_action";

                   public readonly static string PL_V_PTC_Realisation_Id_application = RDBPL.DBPL_V_DB0_Realisation_Id_application; //"Id_application";
                   public readonly static string PL_V_PTC_Realisation_LblId_application = RDBPL.DBPL_V_DB0_Realisation_LblId_application; //"Id_application";
                   public readonly static string PL_V_PTC_Realisation_LgdId_application = RDBPL.DBPL_V_DB0_Realisation_LgdId_application; //"Id_application";
                   public readonly static string PL_V_PTC_Realisation_TtpId_application = RDBPL.DBPL_V_DB0_Realisation_TtpId_application; //"Id_application";

                   public readonly static string PL_V_PTC_Realisation_Id_employe = RDBPL.DBPL_V_DB0_Realisation_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Realisation_LblId_employe = RDBPL.DBPL_V_DB0_Realisation_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Realisation_LgdId_employe = RDBPL.DBPL_V_DB0_Realisation_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Realisation_TtpId_employe = RDBPL.DBPL_V_DB0_Realisation_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PTC_Realisation_Id_modetravail = RDBPL.DBPL_V_DB0_Realisation_Id_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PTC_Realisation_LblId_modetravail = RDBPL.DBPL_V_DB0_Realisation_LblId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PTC_Realisation_LgdId_modetravail = RDBPL.DBPL_V_DB0_Realisation_LgdId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PTC_Realisation_TtpId_modetravail = RDBPL.DBPL_V_DB0_Realisation_TtpId_modetravail; //"Id_modetravail";

                   //public readonly static string PL_V_PTC_Realisation_Id_planning = DB_ConstPT._Id_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Realisation_LblId_planning = DB_ConstPT._LblId_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Realisation_LgdId_planning = DB_ConstPT._LgdId_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Realisation_TtpId_planning = DB_ConstPT._TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Realisation_Id_projet = RDBPL.DBPL_V_DB0_Realisation_Id_projet; //"Id_projet";
                   public readonly static string PL_V_PTC_Realisation_LblId_projet = RDBPL.DBPL_V_DB0_Realisation_LblId_projet; //"Id_projet";
                   public readonly static string PL_V_PTC_Realisation_LgdId_projet = RDBPL.DBPL_V_DB0_Realisation_LgdId_projet; //"Id_projet";
                   public readonly static string PL_V_PTC_Realisation_TtpId_projet = RDBPL.DBPL_V_DB0_Realisation_TtpId_projet; //"Id_projet";

                   public readonly static string PL_V_PTC_Realisation_Id_societe = RDBPL.DBPL_V_DB0_Realisation_Id_societe; //"Id_societe";
                   public readonly static string PL_V_PTC_Realisation_LblId_societe = RDBPL.DBPL_V_DB0_Realisation_LblId_societe; //"Id_societe";
                   public readonly static string PL_V_PTC_Realisation_LgdId_societe = RDBPL.DBPL_V_DB0_Realisation_LgdId_societe; //"Id_societe";
                   public readonly static string PL_V_PTC_Realisation_TtpId_societe = RDBPL.DBPL_V_DB0_Realisation_TtpId_societe; //"Id_societe";

                   public readonly static string PL_V_PTC_Realisation_Duree = RDBPL.DBPL_V_DB0_Realisation_Duree; //"Duree";
                   public readonly static string PL_V_PTC_Realisation_LblDuree = RDBPL.DBPL_V_DB0_Realisation_LblDuree; //"Duree";
                   public readonly static string PL_V_PTC_Realisation_LgdDuree = RDBPL.DBPL_V_DB0_Realisation_LgdDuree; //"Duree";
                   public readonly static string PL_V_PTC_Realisation_TtpDuree = RDBPL.DBPL_V_DB0_Realisation_TtpDuree; //"Duree";

                   public readonly static string PL_V_PTC_Realisation_Id_contrainte = RDBPL.DBPL_V_DB0_Realisation_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_LblId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_LgdId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_TtpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PTC_Realisation_Id_espaceclient = RDBPL.DBPL_V_DB0_Realisation_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Realisation_LblId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Realisation_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Realisation_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Societe_

                   public readonly static string PL_V_PTC_Societe_Id = RDBPL.DBPL_V_DB0_Societe_Id; //"Id";
                   public readonly static string PL_V_PTC_Societe_LblId = RDBPL.DBPL_V_DB0_Societe_LblId; //"Id";
                   public readonly static string PL_V_PTC_Societe_LgdId = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Societe_TtpId = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Societe_Object = RDBPL.DBPL_V_DB0_Societe_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_ObjectList = RDBPL.DBPL_V_DB0_Societe_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_TitrePage = RDBPL.DBPL_V_DB0_Societe_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Societe_Logicaldeleted = RDBPL.DBPL_V_DB0_Societe_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Societe_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Societe_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Societe_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Societe_Libelle = RDBPL.DBPL_V_DB0_Societe_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Societe_LblLibelle = RDBPL.DBPL_V_DB0_Societe_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Societe_LgdLibelle = RDBPL.DBPL_V_DB0_Societe_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Societe_TtpLibelle = RDBPL.DBPL_V_DB0_Societe_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Societe_Abreviation = RDBPL.DBPL_V_DB0_Societe_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Societe_LblAbreviation = RDBPL.DBPL_V_DB0_Societe_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Societe_LgdAbreviation = RDBPL.DBPL_V_DB0_Societe_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Societe_TtpAbreviation = RDBPL.DBPL_V_DB0_Societe_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Societe_Id_planning = RDBPL.DBPL_V_DB0_Societe_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_LblId_planning = RDBPL.DBPL_V_DB0_Societe_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_LgdId_planning = RDBPL.DBPL_V_DB0_Societe_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_TtpId_planning = RDBPL.DBPL_V_DB0_Societe_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Societe_Id_espaceclient = RDBPL.DBPL_V_DB0_Societe_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Societe_LblId_espaceclient = RDBPL.DBPL_V_DB0_Societe_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Societe_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Societe_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Societe_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Societe_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Statut_

                   public readonly static string PL_V_PTC_Statut_Id = RDBPL.DBPL_V_DB0_Statut_Id; //"Id";
                   public readonly static string PL_V_PTC_Statut_LblId = RDBPL.DBPL_V_DB0_Statut_LblId; //"Id";
                   public readonly static string PL_V_PTC_Statut_LgdId = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Statut_TtpId = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Statut_Object = RDBPL.DBPL_V_DB0_Statut_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_ObjectList = RDBPL.DBPL_V_DB0_Statut_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_TitrePage = RDBPL.DBPL_V_DB0_Statut_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Statut_Logicaldeleted = RDBPL.DBPL_V_DB0_Statut_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Statut_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Statut_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Statut_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Statut_Libelle = RDBPL.DBPL_V_DB0_Statut_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Statut_LblLibelle = RDBPL.DBPL_V_DB0_Statut_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Statut_LgdLibelle = RDBPL.DBPL_V_DB0_Statut_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Statut_TtpLibelle = RDBPL.DBPL_V_DB0_Statut_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Statut_Abreviation = RDBPL.DBPL_V_DB0_Statut_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Statut_LblAbreviation = RDBPL.DBPL_V_DB0_Statut_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Statut_LgdAbreviation = RDBPL.DBPL_V_DB0_Statut_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Statut_TtpAbreviation = RDBPL.DBPL_V_DB0_Statut_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Statut_Id_planning = RDBPL.DBPL_V_DB0_Statut_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_LblId_planning = RDBPL.DBPL_V_DB0_Statut_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_LgdId_planning = RDBPL.DBPL_V_DB0_Statut_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_TtpId_planning = RDBPL.DBPL_V_DB0_Statut_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Statut_Id_espaceclient = RDBPL.DBPL_V_DB0_Statut_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Statut_LblId_espaceclient = RDBPL.DBPL_V_DB0_Statut_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Statut_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Statut_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Statut_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Statut_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_TacheRecapVersion_

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Object = "Tâche récapitulative";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_ObjectList = "Tâche récapitulative";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TitrePage = "Tâches récapitulatives";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Libelle = DB_ConstPT.DB0_Contrainte_Libelle; //"Libelle";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LblLibelle = DB_ConstPT.DB0_Contrainte_LblLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LgdLibelle = DB_ConstPT.DB0_Contrainte_LgdLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TtpLibelle = DB_ConstPT.DB0_Contrainte_TtpLibelle; //"Libelle";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Id_projet = DB_ConstPT.DB0_Contrainte_Id_projet; //"Id_projet";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LblId_projet = DB_ConstPT.DB0_Contrainte_LblId_projet; //"Id_projet";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LgdId_projet = DB_ConstPT.DB0_Contrainte_LgdId_projet; //"Id_projet";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TtpId_projet = DB_ConstPT.DB0_Contrainte_TtpId_projet; //"Id_projet";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Ordre = DB_ConstPT.DB0_Contrainte_Ordre; //"Ordre";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LblOrdre = DB_ConstPT.DB0_Contrainte_LblOrdre; //"Ordre";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LgdOrdre = DB_ConstPT.DB0_Contrainte_LgdOrdre; //"Ordre";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TtpOrdre = DB_ConstPT.DB0_Contrainte_TtpOrdre; //"Ordre";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Ref = DB_ConstPT.DB0_Contrainte_Ref; //"Ref";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LblRef = DB_ConstPT.DB0_Contrainte_LblRef; //"Ref";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LgdRef = DB_ConstPT.DB0_Contrainte_LgdRef; //"Ref";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TtpRef = DB_ConstPT.DB0_Contrainte_TtpRef; //"Ref";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_Id_employe = DB_ConstPT.DB0_Contrainte_Id_employe; //"Id_employe";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LblId_employe = DB_ConstPT.DB0_Contrainte_LblId_employe; //"Id_employe";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_LgdId_employe = DB_ConstPT.DB0_Contrainte_LgdId_employe; //"Id_employe";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_TtpId_employe = DB_ConstPT.DB0_Contrainte_TtpId_employe; //"Id_employe";

                   #endregion

                   #region PTC_TypeTache_

                   public readonly static string PL_V_PTC_TypeTache_Id = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Id";
                   public readonly static string PL_V_PTC_TypeTache_LblId = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Id";
                   public readonly static string PL_V_PTC_TypeTache_LgdId = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Id";
                   public readonly static string PL_V_PTC_TypeTache_TtpId = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Id";

                   public readonly static string PL_V_PTC_TypeTache_Object = RDBPL.DBPL_V_DB0_TypeTache_Object; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_ObjectList = RDBPL.DBPL_V_DB0_TypeTache_ObjectList; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_TitrePage = RDBPL.DBPL_V_DB0_TypeTache_TitrePage; //"Abreviation";

                   public readonly static string PL_V_PTC_TypeTache_Logicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_TypeTache_LblLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_TypeTache_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_TypeTache_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_TypeTache_Libelle = RDBPL.DBPL_V_DB0_TypeTache_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_TypeTache_LblLibelle = RDBPL.DBPL_V_DB0_TypeTache_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_TypeTache_LgdLibelle = RDBPL.DBPL_V_DB0_TypeTache_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_TypeTache_TtpLibelle = RDBPL.DBPL_V_DB0_TypeTache_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_TypeTache_Abreviation = RDBPL.DBPL_V_DB0_TypeTache_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_LblAbreviation = RDBPL.DBPL_V_DB0_TypeTache_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_LgdAbreviation = RDBPL.DBPL_V_DB0_TypeTache_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_TtpAbreviation = RDBPL.DBPL_V_DB0_TypeTache_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_TypeTache_Id_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_TypeTache_LblId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_TypeTache_LgdId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_TypeTache_TtpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_UniteHoraire_

                   public readonly static string PL_V_PTC_UniteHoraire_Id = RDBPL.DBPL_V_DB0_UniteHoraire_Id; //"Id";
                   public readonly static string PL_V_PTC_UniteHoraire_LblId = RDBPL.DBPL_V_DB0_UniteHoraire_LblId; //"Id";
                   public readonly static string PL_V_PTC_UniteHoraire_LgdId = RDBPL.DBPL_V_DB0_UniteHoraire_LgdId; //"Id";
                   public readonly static string PL_V_PTC_UniteHoraire_TtpId = RDBPL.DBPL_V_DB0_UniteHoraire_TtpId; //"Id";

                   public readonly static string PL_V_PTC_UniteHoraire_Object = RDBPL.DBPL_V_DB0_UniteHoraire_Object; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_ObjectList = RDBPL.DBPL_V_DB0_UniteHoraire_ObjectList; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_TitrePage = RDBPL.DBPL_V_DB0_UniteHoraire_TitrePage; //"Abreviation";

                   public readonly static string PL_V_PTC_UniteHoraire_Logicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_UniteHoraire_LblLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_UniteHoraire_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_UniteHoraire_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_UniteHoraire_Libelle = RDBPL.DBPL_V_DB0_UniteHoraire_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_UniteHoraire_LblLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_UniteHoraire_LgdLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_UniteHoraire_TtpLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_UniteHoraire_Abreviation = RDBPL.DBPL_V_DB0_UniteHoraire_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_LblAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_LgdAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_TtpAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_UniteHoraire_Id_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_UniteHoraire_LblId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_UniteHoraire_LgdId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_UniteHoraire_TtpId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Utilisateur_

                   public readonly static string PL_V_PTC_Utilisateur_Id = RDBPL.DBPL_V_DB0_Utilisateur_Id; //"Id";
                   public readonly static string PL_V_PTC_Utilisateur_LblId = RDBPL.DBPL_V_DB0_Utilisateur_LblId; //"Id";
                   public readonly static string PL_V_PTC_Utilisateur_LgdId = RDBPL.DBPL_V_DB0_Utilisateur_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Utilisateur_TtpId = RDBPL.DBPL_V_DB0_Utilisateur_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Utilisateur_Object = RDBPL.DBPL_V_DB0_Utilisateur_Object; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_ObjectList = RDBPL.DBPL_V_DB0_Utilisateur_ObjectList; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_TitrePage = RDBPL.DBPL_V_DB0_Utilisateur_TitrePage; //"Identite";

                   public readonly static string PL_V_PTC_Utilisateur_Logicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Utilisateur_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Utilisateur_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Utilisateur_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Utilisateur_Pt_visu = RDBPL.DBPL_V_DB0_Utilisateur_Pt_visu; //"Pt_visu";
                   public readonly static string PL_V_PTC_Utilisateur_LblPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_LblPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PTC_Utilisateur_LgdPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_LgdPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PTC_Utilisateur_TtpPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_TtpPt_visu; //"Pt_visu";

                   public readonly static string PL_V_PTC_Utilisateur_Pt_modif = RDBPL.DBPL_V_DB0_Utilisateur_Pt_modif; //"Pt_modif";
                   public readonly static string PL_V_PTC_Utilisateur_LblPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_LblPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PTC_Utilisateur_LgdPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_LgdPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PTC_Utilisateur_TtpPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_TtpPt_modif; //"Pt_modif";

                   public readonly static string PL_V_PTC_Utilisateur_Identite = RDBPL.DBPL_V_DB0_Utilisateur_Identite; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_LblIdentite = RDBPL.DBPL_V_DB0_Utilisateur_LblIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_LgdIdentite = RDBPL.DBPL_V_DB0_Utilisateur_LgdIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_TtpIdentite = RDBPL.DBPL_V_DB0_Utilisateur_TtpIdentite; //"Identite";

                   public readonly static string PL_V_PTC_Utilisateur_Id_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Utilisateur_LblId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Utilisateur_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Utilisateur_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Version_

                   public readonly static string PL_V_PTC_Version_Id = RDBPL.DBPL_V_DB0_Version_Id; //"Id";
                   public readonly static string PL_V_PTC_Version_LblId = RDBPL.DBPL_V_DB0_Version_LblId; //"Id";
                   public readonly static string PL_V_PTC_Version_LgdId = RDBPL.DBPL_V_DB0_Version_LgdId; //"Id";
                   public readonly static string PL_V_PTC_Version_TtpId = RDBPL.DBPL_V_DB0_Version_TtpId; //"Id";

                   public readonly static string PL_V_PTC_Version_Object = RDBPL.DBPL_V_DB0_Version_Object; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_ObjectList = RDBPL.DBPL_V_DB0_Version_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_TitrePage = RDBPL.DBPL_V_DB0_Version_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PTC_Version_Logicaldeleted = RDBPL.DBPL_V_DB0_Version_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Version_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Version_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Version_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Version_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Version_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Version_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PTC_Version_Libelle = RDBPL.DBPL_V_DB0_Version_Libelle; //"Libelle";
                   public readonly static string PL_V_PTC_Version_LblLibelle = RDBPL.DBPL_V_DB0_Version_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Version_LgdLibelle = RDBPL.DBPL_V_DB0_Version_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Version_TtpLibelle = RDBPL.DBPL_V_DB0_Version_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PTC_Version_Id_planning = RDBPL.DBPL_V_DB0_Version_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_LblId_planning = RDBPL.DBPL_V_DB0_Version_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_LgdId_planning = RDBPL.DBPL_V_DB0_Version_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_TtpId_planning = RDBPL.DBPL_V_DB0_Version_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PTC_Version_Abreviation = RDBPL.DBPL_V_DB0_Version_Abreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Version_LblAbreviation = RDBPL.DBPL_V_DB0_Version_LblAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Version_LgdAbreviation = RDBPL.DBPL_V_DB0_Version_LgdAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Version_TtpAbreviation = RDBPL.DBPL_V_DB0_Version_TtpAbreviation; //"Abreviation";

                   public readonly static string PL_V_PTC_Version_Figee = RDBPL.DBPL_V_DB0_Version_Figee; //"Figee";
                   public readonly static string PL_V_PTC_Version_LblFigee = RDBPL.DBPL_V_DB0_Version_LblFigee; //"Figee";
                   public readonly static string PL_V_PTC_Version_LgdFigee = RDBPL.DBPL_V_DB0_Version_LgdFigee; //"Figee";
                   public readonly static string PL_V_PTC_Version_TtpFigee = RDBPL.DBPL_V_DB0_Version_TtpFigee; //"Figee";

                   public readonly static string PL_V_PTC_Version_Debut = RDBPL.DBPL_V_DB0_Planning_Debut; //"Debut";
                   public readonly static string PL_V_PTC_Version_LblDebut = RDBPL.DBPL_V_DB0_Planning_LblDebut; //"Debut";
                   public readonly static string PL_V_PTC_Version_LgdDebut = RDBPL.DBPL_V_DB0_Planning_LgdDebut; //"Debut";
                   public readonly static string PL_V_PTC_Version_TtpDebut = RDBPL.DBPL_V_DB0_Planning_TtpDebut; //"Debut";

                   public readonly static string PL_V_PTC_Version_Fin = RDBPL.DBPL_V_DB0_Planning_Fin; //"Fin";
                   public readonly static string PL_V_PTC_Version_LblFin = RDBPL.DBPL_V_DB0_Planning_LblFin; //"Fin";
                   public readonly static string PL_V_PTC_Version_LgdFin = RDBPL.DBPL_V_DB0_Planning_LgdFin; //"Fin";
                   public readonly static string PL_V_PTC_Version_TtpFin = RDBPL.DBPL_V_DB0_Planning_TtpFin; //"Fin";

                   public readonly static string PL_V_PTC_Version_Id_espaceclient = RDBPL.DBPL_V_DB0_Version_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Version_LblId_espaceclient = RDBPL.DBPL_V_DB0_Version_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Version_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Version_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PTC_Version_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Version_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Ephemeride

                   public readonly static string PL_V_PL0_Ephemeride_Object = RDBPL.DBPL_V_DB0_Ephemeride_Object; //"Lib_projet";
                   public readonly static string PL_V_PL0_Ephemeride_ObjectList = RDBPL.DBPL_V_DB0_Ephemeride_ObjectList; //"Lib_projet";
                   public readonly static string PL_V_PL0_Ephemeride_TitrePage = RDBPL.DBPL_V_DB0_Ephemeride_TitrePage; //"Lib_projet";

                   public readonly static string PL_V_PL0_Ephemeride_Id = RDBPL.DBPL_V_DB0_Ephemeride_Id; //"Id";
                   public readonly static string PL_V_PL0_Ephemeride_LblId = RDBPL.DBPL_V_DB0_Ephemeride_LblId; //"Id";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId = RDBPL.DBPL_V_DB0_Ephemeride_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId = RDBPL.DBPL_V_DB0_Ephemeride_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Ephemeride_Logicaldeleted = RDBPL.DBPL_V_DB0_Ephemeride_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ephemeride_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Ephemeride_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Ephemeride_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Ephemeride_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Ephemeride_Id_planning = RDBPL.DBPL_V_DB0_Ephemeride_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_planning = RDBPL.DBPL_V_DB0_Ephemeride_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_planning = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_planning = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Ephemeride_Id_version = RDBPL.DBPL_V_DB0_Ephemeride_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_version = RDBPL.DBPL_V_DB0_Ephemeride_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_version = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_version = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_Ephemeride_Id_employe = RDBPL.DBPL_V_DB0_Ephemeride_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_employe = RDBPL.DBPL_V_DB0_Ephemeride_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_employe = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_employe = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_Ephemeride_Debut = RDBPL.DBPL_V_DB0_Ephemeride_Debut; //"Debut";
                   public readonly static string PL_V_PL0_Ephemeride_LblDebut = RDBPL.DBPL_V_DB0_Ephemeride_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDebut = RDBPL.DBPL_V_DB0_Ephemeride_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDebut = RDBPL.DBPL_V_DB0_Ephemeride_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Ephemeride_Duree = RDBPL.DBPL_V_DB0_Ephemeride_Duree; //"Duree";
                   public readonly static string PL_V_PL0_Ephemeride_LblDuree = RDBPL.DBPL_V_DB0_Ephemeride_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDuree = RDBPL.DBPL_V_DB0_Ephemeride_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDuree = RDBPL.DBPL_V_DB0_Ephemeride_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_Ephemeride_Id_type = RDBPL.DBPL_V_DB0_Ephemeride_Id_type; //"Id_type";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_type = RDBPL.DBPL_V_DB0_Ephemeride_LblId_type; //"Id_type";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_type = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_type; //"Id_type";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_type = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_type; //"Id_type";

                   public readonly static string PL_V_PL0_Ephemeride_Id_contrainte = RDBPL.DBPL_V_DB0_Ephemeride_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_contrainte = RDBPL.DBPL_V_DB0_Ephemeride_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_contrainte = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_contrainte = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Ephemeride_Id_espaceclient = RDBPL.DBPL_V_DB0_Ephemeride_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_espaceclient = RDBPL.DBPL_V_DB0_Ephemeride_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Ephemeride_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Ephemeride_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaPL0_Ephemeride_ires
                   public readonly static string PL_V_PL0_Ephemeride_Abr_version = RDBPL.DBPL_V_DB0_Version_Id; //"Abr_version";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Abr_version";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Abr_version";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Abr_version";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_version = RDBPL.DBPL_V_DB0_Version_Id; //"Lib_version";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Lib_version";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Lib_version";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Lib_version";

                   public readonly static string PL_V_PL0_Ephemeride_Ident_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Ident_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LblIdent_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdIdent_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpIdent_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Ident_employe";

                   public readonly static string PL_V_PL0_Ephemeride_Init_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Init_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LblInit_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Init_employe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdInit_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Init_employe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpInit_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Init_employe";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_type = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Abr_type";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_type = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Abr_type";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_type = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Abr_type";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_type = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Abr_type";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_type = RDBPL.DBPL_V_DB0_TypeTache_Id; //"Lib_type";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_type = RDBPL.DBPL_V_DB0_TypeTache_LblId; //"Lib_type";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_type = RDBPL.DBPL_V_DB0_TypeTache_LgdId; //"Lib_type";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_type = RDBPL.DBPL_V_DB0_TypeTache_TtpId; //"Lib_type";

                   public readonly static string PL_V_PL0_Ephemeride_Libelle = "Libellé de tâche";
                   public readonly static string PL_V_PL0_Ephemeride_LblLibelle = PL_V_PL0_Ephemeride_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLibelle = "Libellé tâche";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLibelle = PL_V_PL0_Ephemeride_Libelle; //"Libelle";

                   public readonly static string PL_V_PL0_Ephemeride_Debutcontrainte = "Début de prévision";
                   public readonly static string PL_V_PL0_Ephemeride_LblDebutcontrainte = PL_V_PL0_Ephemeride_Debutcontrainte; //"Debutcontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDebutcontrainte = "Début prévision";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDebutcontrainte = PL_V_PL0_Ephemeride_Debutcontrainte; //"Debutcontrainte";

                   public readonly static string PL_V_PL0_Ephemeride_Dureecontrainte = "Durée de prévision";
                   public readonly static string PL_V_PL0_Ephemeride_LblDureecontrainte = PL_V_PL0_Ephemeride_Dureecontrainte; //"Dureecontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDureecontrainte = "Durée prévision";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDureecontrainte = PL_V_PL0_Ephemeride_Dureecontrainte; //"Dureecontrainte";

                   public readonly static string PL_V_PL0_Ephemeride_Fincontrainte = "Fin de prévision";
                   public readonly static string PL_V_PL0_Ephemeride_LblFincontrainte = PL_V_PL0_Ephemeride_Fincontrainte; //"Fincontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_LgdFincontrainte = "Fin prévision";
                   public readonly static string PL_V_PL0_Ephemeride_TtpFincontrainte = PL_V_PL0_Ephemeride_Fincontrainte; //"Fincontrainte";

                   public readonly static string PL_V_PL0_Ephemeride_Info = RDBPL.Info; //"Info";
                   public readonly static string PL_V_PL0_Ephemeride_LblInfo = RDBPL.LblInfo; //"Info";
                   public readonly static string PL_V_PL0_Ephemeride_LgdInfo = RDBPL.LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_Ephemeride_TtpInfo = RDBPL.TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_Ephemeride_Ref = RDBPL.Ref; //"Ref";
                   public readonly static string PL_V_PL0_Ephemeride_LblRef = RDBPL.LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Ephemeride_LgdRef = RDBPL.LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Ephemeride_TtpRef = RDBPL.TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Ephemeride_Commentaire = RDBPL.Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ephemeride_LblCommentaire = RDBPL.LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ephemeride_LgdCommentaire = RDBPL.LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ephemeride_TtpCommentaire = RDBPL.TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_Ephemeride_Debutcalc = RDBPL.Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Ephemeride_LblDebutcalc = RDBPL.LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDebutcalc = RDBPL.LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDebutcalc = RDBPL.TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_Ephemeride_Fincalc = RDBPL.Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Ephemeride_LblFincalc = RDBPL.LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Ephemeride_LgdFincalc = RDBPL.LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Ephemeride_TtpFincalc = RDBPL.TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_Ephemeride_Debutreal = RDBPL.Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Ephemeride_LblDebutreal = RDBPL.LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDebutreal = RDBPL.LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDebutreal = RDBPL.TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_Ephemeride_Finreal = RDBPL.Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_Ephemeride_LblFinreal = RDBPL.LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Ephemeride_LgdFinreal = RDBPL.LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Ephemeride_TtpFinreal = RDBPL.TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_Ephemeride_Dureecalc = RDBPL.Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Ephemeride_LblDureecalc = RDBPL.LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDureecalc = RDBPL.LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDureecalc = RDBPL.TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_Ephemeride_Dureereal = RDBPL.Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Ephemeride_LblDureereal = RDBPL.LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Ephemeride_LgdDureereal = RDBPL.LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Ephemeride_TtpDureereal = RDBPL.TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_Ephemeride_Id_statut = RDBPL.DBPL_V_DB0_Statut_Id; //"Id_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_statut = RDBPL.DBPL_V_DB0_Statut_LblId; //"Id_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_statut = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Id_statut";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_statut = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Id_statut";

                   public readonly static string PL_V_PL0_Ephemeride_Id_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Id_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Id_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Id_societe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Id_societe";

                   public readonly static string PL_V_PL0_Ephemeride_Id_application = RDBPL.DBPL_V_DB0_Application_Id; //"Id_application";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Id_application";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Id_application";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Id_application";

                   public readonly static string PL_V_PL0_Ephemeride_Id_action = RDBPL.DBPL_V_DB0_Action_Id; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_action = RDBPL.DBPL_V_DB0_Action_LblId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_action = RDBPL.DBPL_V_DB0_Action_LgdId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_action = RDBPL.DBPL_V_DB0_Action_TtpId; //"Id_action";

                   public readonly static string PL_V_PL0_Ephemeride_Id_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id_modetravail";

                   public readonly static string PL_V_PL0_Ephemeride_Id_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LblId_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LgdId_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_TtpId_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id_projet";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_statut = RDBPL.DBPL_V_DB0_Statut_Id; //"Abr_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_statut = RDBPL.DBPL_V_DB0_Statut_LblId; //"Abr_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_statut = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Abr_statut";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_statut = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Abr_statut";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_statut = RDBPL.DBPL_V_DB0_Statut_Id; //"Lib_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_statut = RDBPL.DBPL_V_DB0_Statut_LblId; //"Lib_statut";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_statut = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Lib_statut";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_statut = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Lib_statut";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Abr_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Abr_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Abr_societe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Abr_societe";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Lib_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Lib_societe";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Lib_societe";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Lib_societe";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_application = RDBPL.DBPL_V_DB0_Application_Id; //"Abr_application";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Abr_application";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Abr_application";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Abr_application";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_application = RDBPL.DBPL_V_DB0_Application_Id; //"Lib_application";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Lib_application";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Lib_application";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Lib_application";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_action = RDBPL.DBPL_V_DB0_Action_Id; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_action = RDBPL.DBPL_V_DB0_Action_LblId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_action = RDBPL.DBPL_V_DB0_Action_LgdId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_action = RDBPL.DBPL_V_DB0_Action_TtpId; //"Id_action";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_action = RDBPL.DBPL_V_DB0_Action_Id; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_action = RDBPL.DBPL_V_DB0_Action_LblId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_action = RDBPL.DBPL_V_DB0_Action_LgdId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_action = RDBPL.DBPL_V_DB0_Action_TtpId; //"Id_action";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id_modetravail";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Lib_modetravail";

                   public readonly static string PL_V_PL0_Ephemeride_Abr_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LblAbr_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LgdAbr_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_TtpAbr_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id_projet";

                   public readonly static string PL_V_PL0_Ephemeride_Lib_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LblLib_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_LgdLib_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_TtpLib_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id_projet";

                   #endregion


                   #region PL0_Ferie_

                   public readonly static string PL_V_PL0_Ferie_Id = RDBPL.DBPL_V_DB0_Ferie_Id; //"Id";
                   public readonly static string PL_V_PL0_Ferie_LblId = RDBPL.DBPL_V_DB0_Ferie_LblId; //"Id";
                   public readonly static string PL_V_PL0_Ferie_LgdId = RDBPL.DBPL_V_DB0_Ferie_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Ferie_TtpId = RDBPL.DBPL_V_DB0_Ferie_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Ferie_Object = RDBPL.DBPL_V_DB0_Ferie_Object; //"Dureereal";
                   public readonly static string PL_V_PL0_Ferie_ObjectList = RDBPL.DBPL_V_DB0_Ferie_ObjectList; //"Dureereal";
                   public readonly static string PL_V_PL0_Ferie_TitrePage = RDBPL.DBPL_V_DB0_Ferie_TitrePage; //"Dureereal";

                   public readonly static string PL_V_PL0_Ferie_Logicaldeleted = RDBPL.DBPL_V_DB0_Ferie_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ferie_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Ferie_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ferie_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Ferie_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ferie_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Ferie_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Ferie_Debut = RDBPL.DBPL_V_DB0_Ferie_Debut; //"Debut";
                   public readonly static string PL_V_PL0_Ferie_LblDebut = RDBPL.DBPL_V_DB0_Ferie_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ferie_LgdDebut = RDBPL.DBPL_V_DB0_Ferie_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ferie_TtpDebut = RDBPL.DBPL_V_DB0_Ferie_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Ferie_Duree = RDBPL.DBPL_V_DB0_Ferie_Duree; //"Duree";
                   public readonly static string PL_V_PL0_Ferie_LblDuree = RDBPL.DBPL_V_DB0_Ferie_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ferie_LgdDuree = RDBPL.DBPL_V_DB0_Ferie_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ferie_TtpDuree = RDBPL.DBPL_V_DB0_Ferie_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_Ferie_Id_contrainte = RDBPL.DBPL_V_DB0_Ferie_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ferie_LblId_contrainte = RDBPL.DBPL_V_DB0_Ferie_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ferie_LgdId_contrainte = RDBPL.DBPL_V_DB0_Ferie_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ferie_TtpId_contrainte = RDBPL.DBPL_V_DB0_Ferie_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Ferie_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ferie_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ferie_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ferie_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Ferie_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ferie_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ferie_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ferie_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Ferie_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_Ferie_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Ferie_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Ferie_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Ferie_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ferie_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ferie_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ferie_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_Ferie_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_Ferie_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_Ferie_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_Ferie_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   //public readonly static string PL_V_PL0_Ferie_Debutcalc = DB_ConstPT.DB0_Ferie_Debutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Ferie_LblDebutcalc = DB_ConstPT.DB0_Ferie_LblDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Ferie_LgdDebutcalc = DB_ConstPT.DB0_Ferie_LgdDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Ferie_TtpDebutcalc = DB_ConstPT.DB0_Ferie_TtpDebutcalc; //"Debutcalc";

                   //public readonly static string PL_V_PL0_Ferie_Fincalc = DB_ConstPT.DB0_Ferie_Fincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Ferie_LblFincalc = DB_ConstPT.DB0_Ferie_LblFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Ferie_LgdFincalc = DB_ConstPT.DB0_Ferie_LgdFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Ferie_TtpFincalc = DB_ConstPT.DB0_Ferie_TtpFincalc; //"Fincalc";

                   //public readonly static string PL_V_PL0_Ferie_Debutreal = DB_ConstPT.DB0_Ferie_Debutreal; //"Debutreal";
                   //public readonly static string PL_V_PL0_Ferie_LblDebutreal = DB_ConstPT.DB0_Ferie_LblDebutreal; //"Debutreal";
                   //public readonly static string PL_V_PL0_Ferie_LgdDebutreal = DB_ConstPT.DB0_Ferie_LgdDebutreal; //"Debutreal";
                   //public readonly static string PL_V_PL0_Ferie_TtpDebutreal = DB_ConstPT.DB0_Ferie_TtpDebutreal; //"Debutreal";

                   //public readonly static string PL_V_PL0_Ferie_Finreal = DB_ConstPT.DB0_Ferie_Finreal; //"Finreal";
                   //public readonly static string PL_V_PL0_Ferie_LblFinreal = DB_ConstPT.DB0_Ferie_LblFinreal; //"Finreal";
                   //public readonly static string PL_V_PL0_Ferie_LgdFinreal = DB_ConstPT.DB0_Ferie_LgdFinreal; //"Finreal";
                   //public readonly static string PL_V_PL0_Ferie_TtpFinreal = DB_ConstPT.DB0_Ferie_TtpFinreal; //"Finreal";

                   //public readonly static string PL_V_PL0_Ferie_Dureecalc = DB_ConstPT.DB0_Ferie_Dureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Ferie_LblDureecalc = DB_ConstPT.DB0_Ferie_LblDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Ferie_LgdDureecalc = DB_ConstPT.DB0_Ferie_LgdDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Ferie_TtpDureecalc = DB_ConstPT.DB0_Ferie_TtpDureecalc; //"Dureecalc";

                   //public readonly static string PL_V_PL0_Ferie_Dureereal = DB_ConstPT.DB0_Ferie_Dureereal; //"Dureereal";
                   //public readonly static string PL_V_PL0_Ferie_LblDureereal = DB_ConstPT.DB0_Ferie_LblDureereal; //"Dureereal";
                   //public readonly static string PL_V_PL0_Ferie_LgdDureereal = DB_ConstPT.DB0_Ferie_LgdDureereal; //"Dureereal";
                   //public readonly static string PL_V_PL0_Ferie_TtpDureereal = DB_ConstPT.DB0_Ferie_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_Ferie_Id_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ferie_LblId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ferie_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ferie_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_CongeEmploye

                   public readonly static string PL_V_PL0_CongeEmploye_Id = RDBPL.DBPL_V_DB0_CongeEmploye_Id; //"Id";
                   public readonly static string PL_V_PL0_CongeEmploye_LblId = RDBPL.DBPL_V_DB0_CongeEmploye_LblId; //"Id";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdId = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId; //"Id";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpId = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId; //"Id";

                   public readonly static string PL_V_PL0_CongeEmploye_Object = RDBPL.DBPL_V_DB0_CongeEmploye_Object; //"Init_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_ObjectList = RDBPL.DBPL_V_DB0_CongeEmploye_ObjectList; //"Init_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_TitrePage = RDBPL.DBPL_V_DB0_CongeEmploye_TitrePage; //"Init_employe";

                   public readonly static string PL_V_PL0_CongeEmploye_Logicaldeleted = RDBPL.DBPL_V_DB0_CongeEmploye_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongeEmploye_LblLogicaldeleted = RDBPL.DBPL_V_DB0_CongeEmploye_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_CongeEmploye_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_CongeEmploye_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_CongeEmploye_Id_employe = RDBPL.DBPL_V_DB0_CongeEmploye_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LblId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_CongeEmploye_Id_contrainte = RDBPL.DBPL_V_DB0_CongeEmploye_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongeEmploye_LblId_contrainte = RDBPL.DBPL_V_DB0_CongeEmploye_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdId_contrainte = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpId_contrainte = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_CongeEmploye_Id_espaceclient = RDBPL.DBPL_V_DB0_CongeEmploye_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeEmploye_LblId_espaceclient = RDBPL.DBPL_V_DB0_CongeEmploye_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdId_espaceclient = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpId_espaceclient = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_CongeEmploye_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_CongeEmploye_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_CongeEmploye_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongeEmploye_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_CongeEmploye_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_CongeEmploye_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_CongeEmploye_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_CongeEmploye_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_CongeEmploye_Ident_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Ident_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LblIdent_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Ident_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdIdent_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Ident_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpIdent_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Ident_employe";

                   public readonly static string PL_V_PL0_CongeEmploye_Init_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Init_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LblInit_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Init_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_LgdInit_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Init_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_TtpInit_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Init_employe";

                   #endregion

                   #region PL0_CongeVersion_

                   public readonly static string PL_V_PL0_CongeVersion_Id = RDBPL.DBPL_V_DB0_CongeVersion_Id; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LblId = RDBPL.DBPL_V_DB0_CongeVersion_LblId; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LgdId = RDBPL.DBPL_V_DB0_CongeVersion_LgdId; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_TtpId = RDBPL.DBPL_V_DB0_CongeVersion_TtpId; //"Id_conge";

                   public readonly static string PL_V_PL0_CongeVersion_Object = RDBPL.DBPL_V_DB0_CongeVersion_Object; //"Abr_version";
                   public readonly static string PL_V_PL0_CongeVersion_ObjectList = RDBPL.DBPL_V_DB0_CongeVersion_ObjectList; //"Abr_version";
                   public readonly static string PL_V_PL0_CongeVersion_TitrePage = RDBPL.DBPL_V_DB0_CongeVersion_TitrePage; //"Abr_version";

                   public readonly static string PL_V_PL0_CongeVersion_Logicaldeleted = RDBPL.DBPL_V_DB0_CongeVersion_Logicaldeleted; //"Logicaldeleted_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LblLogicaldeleted = RDBPL.DBPL_V_DB0_CongeVersion_LblLogicaldeleted; //"Logicaldeleted_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_CongeVersion_LgdLogicaldeleted; //"Logicaldeleted_conge";
                   public readonly static string PL_V_PL0_CongeVersion_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_CongeVersion_TtpLogicaldeleted; //"Logicaldeleted_conge";

                   public readonly static string PL_V_PL0_CongeVersion_Id_congeemploye = RDBPL.DBPL_V_DB0_CongeVersion_Id_congeemploye; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LblId_congeemploye = RDBPL.DBPL_V_DB0_CongeVersion_LblId_congeemploye; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_LgdId_congeemploye = RDBPL.DBPL_V_DB0_CongeVersion_LgdId_congeemploye; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_TtpId_congeemploye = RDBPL.DBPL_V_DB0_CongeVersion_TtpId_congeemploye; //"Id_conge";

                   public readonly static string PL_V_PL0_CongeVersion_Id_version = RDBPL.DBPL_V_DB0_CongeVersion_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongeVersion_LblId_version = RDBPL.DBPL_V_DB0_CongeVersion_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongeVersion_LgdId_version = RDBPL.DBPL_V_DB0_CongeVersion_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongeVersion_TtpId_version = RDBPL.DBPL_V_DB0_CongeVersion_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_CongeVersion_Debut = RDBPL.DBPL_V_DB0_CongeVersion_Debut; //"Debut";
                   public readonly static string PL_V_PL0_CongeVersion_LblDebut = RDBPL.DBPL_V_DB0_CongeVersion_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongeVersion_LgdDebut = RDBPL.DBPL_V_DB0_CongeVersion_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongeVersion_TtpDebut = RDBPL.DBPL_V_DB0_CongeVersion_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_CongeVersion_Fin = RDBPL.DBPL_V_DB0_CongeVersion_Fin; //"Fin";
                   public readonly static string PL_V_PL0_CongeVersion_LblFin = RDBPL.DBPL_V_DB0_CongeVersion_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_CongeVersion_LgdFin = RDBPL.DBPL_V_DB0_CongeVersion_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_CongeVersion_TtpFin = RDBPL.DBPL_V_DB0_CongeVersion_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_CongeVersion_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_CongeVersion_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_CongeVersion_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_CongeVersion_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   //public readonly static string PL_V_PL0_CongeVersion_Debutcalc = DB_ConstPT.DB0_Planification_Debutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LblDebutcalc = DB_ConstPT.DB0_Planification_LblDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LgdDebutcalc = DB_ConstPT.DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_CongeVersion_TtpDebutcalc = DB_ConstPT.DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   //public readonly static string PL_V_PL0_CongeVersion_Fincalc = DB_ConstPT.DB0_Planification_Fincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LblFincalc = DB_ConstPT.DB0_Planification_LblFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LgdFincalc = DB_ConstPT.DB0_Planification_LgdFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_CongeVersion_TtpFincalc = DB_ConstPT.DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_CongeVersion_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongeVersion_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongeVersion_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongeVersion_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_CongeVersion_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongeVersion_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongeVersion_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongeVersion_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   //public readonly static string PL_V_PL0_CongeVersion_Dureecalc = DB_ConstPT.DB0_Planification_Dureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LblDureecalc = DB_ConstPT.DB0_Planification_LblDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_CongeVersion_LgdDureecalc = DB_ConstPT.DB0_Planification_LgdDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_CongeVersion_TtpDureecalc = DB_ConstPT.DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_CongeVersion_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongeVersion_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongeVersion_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongeVersion_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_CongeVersion_Id_espaceclient = RDBPL.DBPL_V_DB0_CongeVersion_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeVersion_LblId_espaceclient = RDBPL.DBPL_V_DB0_CongeVersion_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeVersion_LgdId_espaceclient = RDBPL.DBPL_V_DB0_CongeVersion_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeVersion_TtpId_espaceclient = RDBPL.DBPL_V_DB0_CongeVersion_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_CongeVersion_Id_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeVersion_LblId_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeVersion_LgdId_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeVersion_TtpId_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Id_employe";

                   public readonly static string PL_V_PL0_CongeVersion_Lib_version = RDBPL.DBPL_V_DB0_Version_Id; //"Id";
                   public readonly static string PL_V_PL0_CongeVersion_LblLib_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Lib_version";
                   public readonly static string PL_V_PL0_CongeVersion_LgdLib_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Lib_version";
                   public readonly static string PL_V_PL0_CongeVersion_TtpLib_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Lib_version";

                   public readonly static string PL_V_PL0_CongeVersion_Abr_version = RDBPL.DBPL_V_DB0_Version_Id; //"Abr_version";
                   public readonly static string PL_V_PL0_CongeVersion_LblAbr_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Abr_version";
                   public readonly static string PL_V_PL0_CongeVersion_LgdAbr_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Abr_version";
                   public readonly static string PL_V_PL0_CongeVersion_TtpAbr_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Abr_version";

                   #endregion

                   #region PL0_RecapVersion

                   public readonly static string PL_V_PL0_RecapVersion_Object = RDBPL.DBPL_V_DB0_RecapVersion_Object; //"Lib_projet";
                   public readonly static string PL_V_PL0_RecapVersion_ObjectList = RDBPL.DBPL_V_DB0_RecapVersion_ObjectList; //"Lib_projet";
                   public readonly static string PL_V_PL0_RecapVersion_TitrePage = RDBPL.DBPL_V_DB0_RecapVersion_TitrePage; //"Lib_projet";

                   public readonly static string PL_V_PL0_RecapVersion_Id = RDBPL.DBPL_V_DB0_RecapVersion_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblId = RDBPL.DBPL_V_DB0_RecapVersion_LblId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId = RDBPL.DBPL_V_DB0_RecapVersion_LgdId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId = RDBPL.DBPL_V_DB0_RecapVersion_TtpId; //"Id";

                   public readonly static string PL_V_PL0_RecapVersion_Logicaldeleted = RDBPL.DBPL_V_DB0_RecapVersion_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RecapVersion_LblLogicaldeleted = RDBPL.DBPL_V_DB0_RecapVersion_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_RecapVersion_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_RecapVersion_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_RecapVersion_Id_contrainterecap = RDBPL.DBPL_V_DB0_RecapVersion_Id_contrainterecap; //"Id_contrainterecap";
                   public readonly static string PL_V_PL0_RecapVersion_LblId_contrainterecap = RDBPL.DBPL_V_DB0_RecapVersion_LblId_contrainterecap; //"Id_contrainterecap";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId_contrainterecap = RDBPL.DBPL_V_DB0_RecapVersion_LgdId_contrainterecap; //"Id_contrainterecap";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId_contrainterecap = RDBPL.DBPL_V_DB0_RecapVersion_TtpId_contrainterecap; //"Id_contrainterecap";

                   public readonly static string PL_V_PL0_RecapVersion_Id_version = RDBPL.DBPL_V_DB0_RecapVersion_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_RecapVersion_LblId_version = RDBPL.DBPL_V_DB0_RecapVersion_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId_version = RDBPL.DBPL_V_DB0_RecapVersion_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId_version = RDBPL.DBPL_V_DB0_RecapVersion_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_RecapVersion_Id_contrainte = RDBPL.DBPL_V_DB0_RecapVersion_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RecapVersion_LblId_contrainte = RDBPL.DBPL_V_DB0_RecapVersion_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId_contrainte = RDBPL.DBPL_V_DB0_RecapVersion_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId_contrainte = RDBPL.DBPL_V_DB0_RecapVersion_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_RecapVersion_Id_espaceclient = RDBPL.DBPL_V_DB0_RecapVersion_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RecapVersion_LblId_espaceclient = RDBPL.DBPL_V_DB0_RecapVersion_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId_espaceclient = RDBPL.DBPL_V_DB0_RecapVersion_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId_espaceclient = RDBPL.DBPL_V_DB0_RecapVersion_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaiPL0_RecapVersion_res
                   public readonly static string PL_V_PL0_RecapVersion_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_RecapVersion_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_RecapVersion_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RecapVersion_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RecapVersion_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RecapVersion_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_RecapVersion_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_RecapVersion_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_RecapVersion_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_RecapVersion_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_RecapVersion_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RecapVersion_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RecapVersion_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RecapVersion_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_RecapVersion_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RecapVersion_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RecapVersion_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RecapVersion_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_RecapVersion_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RecapVersion_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RecapVersion_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RecapVersion_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_RecapVersion_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_RecapVersion_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RecapVersion_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RecapVersion_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_RecapVersion_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RecapVersion_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RecapVersion_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RecapVersion_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_RecapVersion_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RecapVersion_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RecapVersion_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RecapVersion_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_RecapVersion_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_RecapVersion_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_RecapVersion_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_RecapVersion_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_RecapVersion_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_RecapVersion_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_RecapVersion_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_RecapVersion_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_statut = RDBPL.DBPL_V_DB0_Statut_Id; //"Abr_statut";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_statut = RDBPL.DBPL_V_DB0_Statut_LblId; //"Abr_statut";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_statut = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Abr_statut";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_statut = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Abr_statut";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_statut = RDBPL.DBPL_V_DB0_Statut_Id; //"Lib_statut";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_statut = RDBPL.DBPL_V_DB0_Statut_LblId; //"Lib_statut";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_statut = RDBPL.DBPL_V_DB0_Statut_LgdId; //"Lib_statut";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_statut = RDBPL.DBPL_V_DB0_Statut_TtpId; //"Lib_statut";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Abr_societe";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Abr_societe";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Abr_societe";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Abr_societe";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Lib_societe";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Lib_societe";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Lib_societe";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_application = RDBPL.DBPL_V_DB0_Application_Id; //"Abr_application";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Abr_application";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Abr_application";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Abr_application";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_application = RDBPL.DBPL_V_DB0_Application_Id; //"Lib_application";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Lib_application";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Lib_application";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Lib_application";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_action = RDBPL.DBPL_V_DB0_Action_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_action = RDBPL.DBPL_V_DB0_Action_LblId; //"Abr_action";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_action = RDBPL.DBPL_V_DB0_Action_LgdId; //"Abr_action";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_action = RDBPL.DBPL_V_DB0_Action_TtpId; //"Abr_action";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_action = RDBPL.DBPL_V_DB0_Action_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_action = RDBPL.DBPL_V_DB0_Action_LblId; //"Lib_action";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_action = RDBPL.DBPL_V_DB0_Action_LgdId; //"Lib_action";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_action = RDBPL.DBPL_V_DB0_Action_TtpId; //"Lib_action";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Abr_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Abr_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Abr_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Abr_modetravail";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Lib_modetravail";

                   public readonly static string PL_V_PL0_RecapVersion_Abr_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblAbr_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LgdAbr_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_TtpAbr_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   public readonly static string PL_V_PL0_RecapVersion_Lib_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LblLib_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_LgdLib_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_TtpLib_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   #endregion

                   #region DB0_Planification_

                   public readonly static string PL_V_PL0_ReunionEmploye_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_ReunionEmploye_Object = RDBPL.DBPL_V_DB0_ReunionEmploye_Object; //"Ident_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_ObjectList = RDBPL.DBPL_V_DB0_ReunionEmploye_ObjectList; //"Ident_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_TitrePage = RDBPL.DBPL_V_DB0_ReunionEmploye_TitrePage; //"Ident_employe";

                   public readonly static string PL_V_PL0_ReunionEmploye_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_ReunionEmploye_Id_reunionversion = RDBPL.DBPL_V_DB0_ReunionEmploye_Id_reunionversion; //"Id_reunion";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblId_reunionversion = RDBPL.DBPL_V_DB0_ReunionEmploye_LblId_reunionversion; //"Id_reunion";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdId_reunionversion = RDBPL.DBPL_V_DB0_ReunionEmploye_LgdId_reunionversion; //"Id_reunion";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpId_reunionversion = RDBPL.DBPL_V_DB0_ReunionEmploye_TtpId_reunionversion; //"Id_reunion";

                   public readonly static string PL_V_PL0_ReunionEmploye_Id_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_ReunionEmploye_Id_espaceclient = RDBPL.DBPL_V_DB0_ReunionEmploye_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblId_espaceclient = RDBPL.DBPL_V_DB0_ReunionEmploye_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdId_espaceclient = RDBPL.DBPL_V_DB0_ReunionEmploye_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpId_espaceclient = RDBPL.DBPL_V_DB0_ReunionEmploye_TtpId_espaceclient; //"Id_espaceclient";



                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_ReunionEmploye_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_ReunionEmploye_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_ReunionEmploye_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_ReunionEmploye_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_ReunionEmploye_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_ReunionEmploye_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_ReunionEmploye_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_ReunionEmploye_Debut = RDBPL.DBPL_V_DB0_ReunionVersion_Debut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_ReunionEmploye_Duree = RDBPL.DBPL_V_DB0_ReunionVersion_Duree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_ReunionEmploye_Init_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Init_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblInit_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Init_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdInit_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Init_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpInit_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Init_employe";

                   public readonly static string PL_V_PL0_ReunionEmploye_Ident_employe = RDBPL.DBPL_V_DB0_Employe_Id; //"Ident_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LblIdent_employe = RDBPL.DBPL_V_DB0_Employe_LblId; //"Ident_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_LgdIdent_employe = RDBPL.DBPL_V_DB0_Employe_LgdId; //"Ident_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_TtpIdent_employe = RDBPL.DBPL_V_DB0_Employe_TtpId; //"Ident_employe";

                   #endregion

                   #region DB0_Admin_

                   public readonly static string PL_V_PL0_Admin_Object = RDBPL.DBPL_V_DB0_Admin_Object; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_ObjectList = RDBPL.DBPL_V_DB0_Admin_ObjectList; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_TitrePage = RDBPL.DBPL_V_DB0_Admin_TitrePage; //"Dureereal";

                   public readonly static string PL_V_PL0_Admin_Id = RDBPL.DBPL_V_DB0_Admin_Id; //"Id";
                   public readonly static string PL_V_PL0_Admin_LblId = RDBPL.DBPL_V_DB0_Admin_LblId; //"Id";
                   public readonly static string PL_V_PL0_Admin_LgdId = RDBPL.DBPL_V_DB0_Admin_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Admin_TtpId = RDBPL.DBPL_V_DB0_Admin_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Admin_Logicaldeleted = RDBPL.DBPL_V_DB0_Admin_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Admin_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Admin_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Admin_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Admin_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Admin_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Admin_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Admin_Id_version = RDBPL.DBPL_V_DB0_Admin_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_Admin_LblId_version = RDBPL.DBPL_V_DB0_Admin_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Admin_LgdId_version = RDBPL.DBPL_V_DB0_Admin_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Admin_TtpId_version = RDBPL.DBPL_V_DB0_Admin_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_Admin_Id_employe = RDBPL.DBPL_V_DB0_Admin_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Admin_LblId_employe = RDBPL.DBPL_V_DB0_Admin_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Admin_LgdId_employe = RDBPL.DBPL_V_DB0_Admin_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Admin_TtpId_employe = RDBPL.DBPL_V_DB0_Admin_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_Admin_Debut = RDBPL.DBPL_V_DB0_Admin_Debut; //"Debut";
                   public readonly static string PL_V_PL0_Admin_LblDebut = RDBPL.DBPL_V_DB0_Admin_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Admin_LgdDebut = RDBPL.DBPL_V_DB0_Admin_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Admin_TtpDebut = RDBPL.DBPL_V_DB0_Admin_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Admin_Duree = RDBPL.DBPL_V_DB0_Admin_Duree; //"Duree";
                   public readonly static string PL_V_PL0_Admin_LblDuree = RDBPL.DBPL_V_DB0_Admin_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Admin_LgdDuree = RDBPL.DBPL_V_DB0_Admin_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Admin_TtpDuree = RDBPL.DBPL_V_DB0_Admin_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_Admin_Periode = RDBPL.DBPL_V_DB0_Admin_Periode; //"Periode";
                   public readonly static string PL_V_PL0_Admin_LblPeriode = RDBPL.DBPL_V_DB0_Admin_LblPeriode; //"Periode";
                   public readonly static string PL_V_PL0_Admin_LgdPeriode = RDBPL.DBPL_V_DB0_Admin_LgdPeriode; //"Periode";
                   public readonly static string PL_V_PL0_Admin_TtpPeriode = RDBPL.DBPL_V_DB0_Admin_TtpPeriode; //"Periode";

                   public readonly static string PL_V_PL0_Admin_Fin = RDBPL.DBPL_V_DB0_Admin_Fin; //"Fin";
                   public readonly static string PL_V_PL0_Admin_LblFin = RDBPL.DBPL_V_DB0_Admin_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_Admin_LgdFin = RDBPL.DBPL_V_DB0_Admin_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_Admin_TtpFin = RDBPL.DBPL_V_DB0_Admin_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_Admin_Decalagemaxi = RDBPL.DBPL_V_DB0_Admin_Decalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_Admin_LblDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_LblDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_Admin_LgdDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_LgdDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_Admin_TtpDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_TtpDecalagemaxi; //"Decalagemaxi";


                   public readonly static string PL_V_PL0_Admin_Id_contrainte = RDBPL.DBPL_V_DB0_Admin_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Admin_LblId_contrainte = RDBPL.DBPL_V_DB0_Admin_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Admin_LgdId_contrainte = RDBPL.DBPL_V_DB0_Admin_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Admin_TtpId_contrainte = RDBPL.DBPL_V_DB0_Admin_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Admin_Decalesioccupe = RDBPL.DBPL_V_DB0_Admin_Decalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_Admin_LblDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_LblDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_Admin_LgdDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_LgdDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_Admin_TtpDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_TtpDecalesioccupe; //"Decalesioccupe";

                   public readonly static string PL_V_PL0_Admin_Secable = RDBPL.DBPL_V_DB0_Admin_Secable; //"Secable";
                   public readonly static string PL_V_PL0_Admin_LblSecable = RDBPL.DBPL_V_DB0_Admin_LblSecable; //"Secable";
                   public readonly static string PL_V_PL0_Admin_LgdSecable = RDBPL.DBPL_V_DB0_Admin_LgdSecable; //"Secable";
                   public readonly static string PL_V_PL0_Admin_TtpSecable = RDBPL.DBPL_V_DB0_Admin_TtpSecable; //"Secable";

                   public readonly static string PL_V_PL0_Admin_Dureemini = RDBPL.DBPL_V_DB0_Admin_Dureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_Admin_LblDureemini = RDBPL.DBPL_V_DB0_Admin_LblDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_Admin_LgdDureemini = RDBPL.DBPL_V_DB0_Admin_LgdDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_Admin_TtpDureemini = RDBPL.DBPL_V_DB0_Admin_TtpDureemini; //"Dureemini";

                   public readonly static string PL_V_PL0_Admin_Dureeinitiale = RDBPL.DBPL_V_DB0_Admin_Dureeinitiale; //"Dureeinitiale";
                   public readonly static string PL_V_PL0_Admin_LblDureeinitiale = RDBPL.DBPL_V_DB0_Admin_LblDureeinitiale; //"Dureeinitiale";
                   public readonly static string PL_V_PL0_Admin_LgdDureeinitiale = RDBPL.DBPL_V_DB0_Admin_LgdDureeinitiale; //"Dureeinitiale";
                   public readonly static string PL_V_PL0_Admin_TtpDureeinitiale = RDBPL.DBPL_V_DB0_Admin_TtpDureeinitiale; //"Dureeinitiale";

                   public readonly static string PL_V_PL0_Admin_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Admin_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Admin_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Admin_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Admin_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_Admin_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Admin_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Admin_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Admin_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Admin_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Admin_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Admin_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_Admin_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Admin_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Admin_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Admin_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Admin_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_Admin_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_Admin_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_Admin_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_Admin_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Admin_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Admin_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Admin_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_Admin_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Admin_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Admin_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Admin_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_Admin_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Admin_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Admin_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Admin_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_Admin_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Admin_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Admin_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Admin_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_Admin_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_Admin_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Admin_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Admin_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_Admin_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_Admin_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Admin_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Admin_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Admin_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_ReunionVersion

                   public readonly static string PL_V_PL0_ReunionVersion_Object = RDBPL.DBPL_V_DB0_ReunionVersion_Object; //"Abr_version";
                   public readonly static string PL_V_PL0_ReunionVersion_ObjectList = RDBPL.DBPL_V_DB0_ReunionVersion_ObjectList; //"Abr_version";
                   public readonly static string PL_V_PL0_ReunionVersion_TitrePage = RDBPL.DBPL_V_DB0_ReunionVersion_TitrePage; //"Abr_version";

                   public readonly static string PL_V_PL0_ReunionVersion_Id = RDBPL.DBPL_V_DB0_ReunionVersion_Id; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LblId = RDBPL.DBPL_V_DB0_ReunionVersion_LblId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdId = RDBPL.DBPL_V_DB0_ReunionVersion_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpId = RDBPL.DBPL_V_DB0_ReunionVersion_TtpId; //"Id";

                   public readonly static string PL_V_PL0_ReunionVersion_Logicaldeleted = RDBPL.DBPL_V_DB0_ReunionVersion_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionVersion_LblLogicaldeleted = RDBPL.DBPL_V_DB0_ReunionVersion_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_ReunionVersion_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_ReunionVersion_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_ReunionVersion_Debut = RDBPL.DBPL_V_DB0_ReunionVersion_Debut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_ReunionVersion_Duree = RDBPL.DBPL_V_DB0_ReunionVersion_Duree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_ReunionVersion_Id_contrainte = RDBPL.DBPL_V_DB0_ReunionVersion_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionVersion_LblId_contrainte = RDBPL.DBPL_V_DB0_ReunionVersion_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdId_contrainte = RDBPL.DBPL_V_DB0_ReunionVersion_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpId_contrainte = RDBPL.DBPL_V_DB0_ReunionVersion_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_ReunionVersion_Id_version = RDBPL.DBPL_V_DB0_ReunionVersion_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionVersion_LblId_version = RDBPL.DBPL_V_DB0_ReunionVersion_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdId_version = RDBPL.DBPL_V_DB0_ReunionVersion_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpId_version = RDBPL.DBPL_V_DB0_ReunionVersion_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_ReunionVersion_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_ReunionVersion_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_ReunionVersion_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_ReunionVersion_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_ReunionVersion_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_ReunionVersion_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionVersion_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_ReunionVersion_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_ReunionVersion_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionVersion_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_ReunionVersion_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionVersion_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";



                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_ReunionVersion_Lib_version = RDBPL.DBPL_V_DB0_Version_Id; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LblLib_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdLib_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpLib_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Id";

                   public readonly static string PL_V_PL0_ReunionVersion_Abr_version = RDBPL.DBPL_V_DB0_Version_Id; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LblAbr_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_LgdAbr_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_TtpAbr_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Id";

                   #endregion

                   #region PL0_Reunion

                   public readonly static string PL_V_PL0_Reunion_Object = RDBPL.DBPL_V_DB0_Reunion_Object; //"Lib_projet";
                   public readonly static string PL_V_PL0_Reunion_ObjectList = RDBPL.DBPL_V_DB0_Reunion_ObjectList; //"Lib_projet";
                   public readonly static string PL_V_PL0_Reunion_TitrePage = RDBPL.DBPL_V_DB0_Reunion_TitrePage; //"Lib_projet";

                   public readonly static string PL_V_PL0_Reunion_Id = RDBPL.DBPL_V_DB0_Reunion_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblId = RDBPL.DBPL_V_DB0_Reunion_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdId = RDBPL.DBPL_V_DB0_Reunion_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpId = RDBPL.DBPL_V_DB0_Reunion_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Logicaldeleted = RDBPL.DBPL_V_DB0_Reunion_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Reunion_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Reunion_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Reunion_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Reunion_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Reunion_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Reunion_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Reunion_Id_societe = RDBPL.DBPL_V_DB0_Reunion_Id_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Reunion_LblId_societe = RDBPL.DBPL_V_DB0_Reunion_LblId_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Reunion_LgdId_societe = RDBPL.DBPL_V_DB0_Reunion_LgdId_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Reunion_TtpId_societe = RDBPL.DBPL_V_DB0_Reunion_TtpId_societe; //"Id_societe";

                   public readonly static string PL_V_PL0_Reunion_Id_application = RDBPL.DBPL_V_DB0_Reunion_Id_application; //"Id_application";
                   public readonly static string PL_V_PL0_Reunion_LblId_application = RDBPL.DBPL_V_DB0_Reunion_LblId_application; //"Id_application";
                   public readonly static string PL_V_PL0_Reunion_LgdId_application = RDBPL.DBPL_V_DB0_Reunion_LgdId_application; //"Id_application";
                   public readonly static string PL_V_PL0_Reunion_TtpId_application = RDBPL.DBPL_V_DB0_Reunion_TtpId_application; //"Id_application";

                   public readonly static string PL_V_PL0_Reunion_Id_projet = RDBPL.DBPL_V_DB0_Reunion_Id_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Reunion_LblId_projet = RDBPL.DBPL_V_DB0_Reunion_LblId_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Reunion_LgdId_projet = RDBPL.DBPL_V_DB0_Reunion_LgdId_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Reunion_TtpId_projet = RDBPL.DBPL_V_DB0_Reunion_TtpId_projet; //"Id_projet";

                   public readonly static string PL_V_PL0_Reunion_Id_action = RDBPL.DBPL_V_DB0_Reunion_Id_action; //"Id_action";
                   public readonly static string PL_V_PL0_Reunion_LblId_action = RDBPL.DBPL_V_DB0_Reunion_LblId_action; //"Id_action";
                   public readonly static string PL_V_PL0_Reunion_LgdId_action = RDBPL.DBPL_V_DB0_Reunion_LgdId_action; //"Id_action";
                   public readonly static string PL_V_PL0_Reunion_TtpId_action = RDBPL.DBPL_V_DB0_Reunion_TtpId_action; //"Id_action";

                   public readonly static string PL_V_PL0_Reunion_Id_modetravail = RDBPL.DBPL_V_DB0_Reunion_Id_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Reunion_LblId_modetravail = RDBPL.DBPL_V_DB0_Reunion_LblId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Reunion_LgdId_modetravail = RDBPL.DBPL_V_DB0_Reunion_LgdId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Reunion_TtpId_modetravail = RDBPL.DBPL_V_DB0_Reunion_TtpId_modetravail; //"Id_modetravail";

                   public readonly static string PL_V_PL0_Reunion_Id_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Reunion_LgdId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Reunion_TtpId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Reunion_Id_espaceclient = RDBPL.DBPL_V_DB0_Reunion_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Reunion_LblId_espaceclient = RDBPL.DBPL_V_DB0_Reunion_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Reunion_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Reunion_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Reunion_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Reunion_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaiPL0_Reunion_res
                   public readonly static string PL_V_PL0_Reunion_Libelle = RDBPL.DBPL_V_DB0_Contrainte_Libelle; //"Libelle";
                   public readonly static string PL_V_PL0_Reunion_LblLibelle = RDBPL.DBPL_V_DB0_Contrainte_LblLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Reunion_LgdLibelle = RDBPL.DBPL_V_DB0_Contrainte_LgdLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Reunion_TtpLibelle = RDBPL.DBPL_V_DB0_Contrainte_TtpLibelle; //"Libelle";

                   public readonly static string PL_V_PL0_Reunion_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Reunion_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Reunion_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Reunion_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_Reunion_Commentaire = RDBPL.DBPL_V_DB0_Contrainte_Commentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Reunion_LblCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LblCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Reunion_LgdCommentaire = RDBPL.DBPL_V_DB0_Contrainte_LgdCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Reunion_TtpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_TtpCommentaire; //"Commentaire";

                   public readonly static string PL_V_PL0_Reunion_Ref = RDBPL.DBPL_V_DB0_Contrainte_Ref; //"Ref";
                   public readonly static string PL_V_PL0_Reunion_LblRef = RDBPL.DBPL_V_DB0_Contrainte_LblRef; //"Ref";
                   public readonly static string PL_V_PL0_Reunion_LgdRef = RDBPL.DBPL_V_DB0_Contrainte_LgdRef; //"Ref";
                   public readonly static string PL_V_PL0_Reunion_TtpRef = RDBPL.DBPL_V_DB0_Contrainte_TtpRef; //"Ref";

                   public readonly static string PL_V_PL0_Reunion_Abr_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblAbr_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdAbr_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpAbr_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Lib_societe = RDBPL.DBPL_V_DB0_Societe_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblLib_societe = RDBPL.DBPL_V_DB0_Societe_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdLib_societe = RDBPL.DBPL_V_DB0_Societe_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpLib_societe = RDBPL.DBPL_V_DB0_Societe_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Abr_application = RDBPL.DBPL_V_DB0_Application_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblAbr_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdAbr_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpAbr_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Lib_application = RDBPL.DBPL_V_DB0_Application_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblLib_application = RDBPL.DBPL_V_DB0_Application_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdLib_application = RDBPL.DBPL_V_DB0_Application_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpLib_application = RDBPL.DBPL_V_DB0_Application_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Abr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Lib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Abr_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblAbr_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdAbr_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpAbr_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Reunion_Lib_projet = RDBPL.DBPL_V_DB0_Projet_Id; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LblLib_projet = RDBPL.DBPL_V_DB0_Projet_LblId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_LgdLib_projet = RDBPL.DBPL_V_DB0_Projet_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_TtpLib_projet = RDBPL.DBPL_V_DB0_Projet_TtpId; //"Id";

                   #endregion

                   #region PL0_AdminPlanification  

                   public readonly static string PL_V_PL0_AdminPlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Dureemini";

                   public readonly static string PL_V_PL0_AdminPlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_AdminPlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_AdminPlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_AdminPlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_AdminPlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_AdminPlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_AdminPlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_AdminPlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_AdminPlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_AdminPlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_AdminPlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_AdminPlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_AdminPlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaiPL0_AdminPlanification_res
                   public readonly static string PL_V_PL0_AdminPlanification_Debut = RDBPL.DBPL_V_DB0_Admin_Debut; //"Debut";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDebut = RDBPL.DBPL_V_DB0_Admin_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDebut = RDBPL.DBPL_V_DB0_Admin_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDebut = RDBPL.DBPL_V_DB0_Admin_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_AdminPlanification_Duree = RDBPL.DBPL_V_DB0_Admin_Duree; //"Duree";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDuree = RDBPL.DBPL_V_DB0_Admin_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDuree = RDBPL.DBPL_V_DB0_Admin_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDuree = RDBPL.DBPL_V_DB0_Admin_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_AdminPlanification_Decalesioccupe = RDBPL.DBPL_V_DB0_Admin_Decalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_LblDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_LgdDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_TtpDecalesioccupe; //"Decalesioccupe";

                   public readonly static string PL_V_PL0_AdminPlanification_Fin = RDBPL.DBPL_V_DB0_Admin_Fin; //"Fin";
                   public readonly static string PL_V_PL0_AdminPlanification_LblFin = RDBPL.DBPL_V_DB0_Admin_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdFin = RDBPL.DBPL_V_DB0_Admin_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpFin = RDBPL.DBPL_V_DB0_Admin_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_employe = RDBPL.DBPL_V_DB0_Admin_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_employe = RDBPL.DBPL_V_DB0_Admin_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_employe = RDBPL.DBPL_V_DB0_Admin_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_employe = RDBPL.DBPL_V_DB0_Admin_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_version = RDBPL.DBPL_V_DB0_Admin_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_version = RDBPL.DBPL_V_DB0_Admin_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_version = RDBPL.DBPL_V_DB0_Admin_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_version = RDBPL.DBPL_V_DB0_Admin_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_AdminPlanification_Periode = RDBPL.DBPL_V_DB0_Admin_Periode; //"Periode";
                   public readonly static string PL_V_PL0_AdminPlanification_LblPeriode = RDBPL.DBPL_V_DB0_Admin_LblPeriode; //"Periode";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdPeriode = RDBPL.DBPL_V_DB0_Admin_LgdPeriode; //"Periode";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpPeriode = RDBPL.DBPL_V_DB0_Admin_TtpPeriode; //"Periode";

                   public readonly static string PL_V_PL0_AdminPlanification_Secable = RDBPL.DBPL_V_DB0_Admin_Secable; //"Secable";
                   public readonly static string PL_V_PL0_AdminPlanification_LblSecable = RDBPL.DBPL_V_DB0_Admin_LblSecable; //"Secable";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdSecable = RDBPL.DBPL_V_DB0_Admin_LgdSecable; //"Secable";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpSecable = RDBPL.DBPL_V_DB0_Admin_TtpSecable; //"Secable";

                   public readonly static string PL_V_PL0_AdminPlanification_Dureemini = RDBPL.DBPL_V_DB0_Admin_Dureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDureemini = RDBPL.DBPL_V_DB0_Admin_LblDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDureemini = RDBPL.DBPL_V_DB0_Admin_LgdDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDureemini = RDBPL.DBPL_V_DB0_Admin_TtpDureemini; //"Dureemini";

                   public readonly static string PL_V_PL0_AdminPlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_AdminPlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_AdminPlanification_Decalagemaxi = RDBPL.DBPL_V_DB0_Admin_Decalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_AdminPlanification_LblDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_LblDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_AdminPlanification_LgdDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_LgdDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_AdminPlanification_TtpDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_TtpDecalagemaxi; //"Decalagemaxi";

                   #endregion

                   #region PL0_FeriePlanification

                   public readonly static string PL_V_PL0_FeriePlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Duree";

                   public readonly static string PL_V_PL0_FeriePlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_FeriePlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_FeriePlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_FeriePlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_FeriePlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_FeriePlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_FeriePlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_FeriePlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_FeriePlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_FeriePlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_FeriePlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_FeriePlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_FeriePlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaiPL0_FeriePlanification_res
                   public readonly static string PL_V_PL0_FeriePlanification_Debut = RDBPL.DBPL_V_DB0_Ferie_Debut; //"Debut";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDebut = RDBPL.DBPL_V_DB0_Ferie_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDebut = RDBPL.DBPL_V_DB0_Ferie_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDebut = RDBPL.DBPL_V_DB0_Ferie_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_FeriePlanification_Duree = RDBPL.DBPL_V_DB0_Ferie_Duree; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_LblDuree = RDBPL.DBPL_V_DB0_Ferie_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdDuree = RDBPL.DBPL_V_DB0_Ferie_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpDuree = RDBPL.DBPL_V_DB0_Ferie_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_FeriePlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_FeriePlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_FeriePlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_FeriePlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   #endregion

                   #region PL0_ReunionPlanification

                   public readonly static string PL_V_PL0_ReunionPlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_employe";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_ReunionPlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_ReunionPlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_ReunionPlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_ReunionPlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_ReunionPlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_ReunionPlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_ReunionPlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_ReunionPlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";


                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_ReunionPlanification_Debut = RDBPL.DBPL_V_DB0_ReunionVersion_Debut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDebut = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_ReunionPlanification_Duree = RDBPL.DBPL_V_DB0_ReunionVersion_Duree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdDuree = RDBPL.DBPL_V_DB0_ReunionVersion_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_version = RDBPL.DBPL_V_DB0_ReunionVersion_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_version = RDBPL.DBPL_V_DB0_ReunionVersion_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_version = RDBPL.DBPL_V_DB0_ReunionVersion_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_version = RDBPL.DBPL_V_DB0_ReunionVersion_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_ReunionPlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_ReunionPlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   #endregion

                   #region PL0_CongePlanification

                   public readonly static string PL_V_PL0_CongePlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_employe";

                   public readonly static string PL_V_PL0_CongePlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_CongePlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_CongePlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongePlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongePlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongePlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_CongePlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_CongePlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_CongePlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_CongePlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_CongePlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_CongePlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CongePlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CongePlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CongePlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_CongePlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CongePlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CongePlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CongePlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_CongePlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CongePlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CongePlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CongePlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_CongePlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongePlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongePlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongePlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_CongePlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongePlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongePlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongePlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_CongePlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongePlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongePlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongePlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_CongePlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_CongePlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";


                   // Colonnes supplémentaiPL0_CongePlanificationres
                   public readonly static string PL_V_PL0_CongePlanification_Debut = RDBPL.DBPL_V_DB0_CongeVersion_Debut; //"Debut";
                   public readonly static string PL_V_PL0_CongePlanification_LblDebut = RDBPL.DBPL_V_DB0_CongeVersion_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongePlanification_LgdDebut = RDBPL.DBPL_V_DB0_CongeVersion_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongePlanification_TtpDebut = RDBPL.DBPL_V_DB0_CongeVersion_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_CongePlanification_Fin = RDBPL.DBPL_V_DB0_CongeVersion_Fin; //"Fin";
                   public readonly static string PL_V_PL0_CongePlanification_LblFin = RDBPL.DBPL_V_DB0_CongeVersion_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_CongePlanification_LgdFin = RDBPL.DBPL_V_DB0_CongeVersion_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_CongePlanification_TtpFin = RDBPL.DBPL_V_DB0_CongeVersion_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_CongePlanification_Id_version = RDBPL.DBPL_V_DB0_CongeVersion_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_version = RDBPL.DBPL_V_DB0_CongeVersion_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_version = RDBPL.DBPL_V_DB0_CongeVersion_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_version = RDBPL.DBPL_V_DB0_CongeVersion_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_CongePlanification_Id_employe = RDBPL.DBPL_V_DB0_CongeEmploye_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_CongePlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongePlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongePlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongePlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_CongePlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   #endregion

                   #region PL0_CalendrierPlanification

                   public readonly static string PL_V_PL0_CalendrierPlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_employe";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";



                   // Colonnes supplémentaiPL0_CalendrierPlanificationres
                   public readonly static string PL_V_PL0_CalendrierPlanification_Debut = RDBPL.DBPL_V_DB0_Calendrier_Debut; //"Debut";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDebut = RDBPL.DBPL_V_DB0_Calendrier_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDebut = RDBPL.DBPL_V_DB0_Calendrier_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDebut = RDBPL.DBPL_V_DB0_Calendrier_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Duree = RDBPL.DBPL_V_DB0_Calendrier_Duree; //"Duree";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblDuree = RDBPL.DBPL_V_DB0_Calendrier_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdDuree = RDBPL.DBPL_V_DB0_Calendrier_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpDuree = RDBPL.DBPL_V_DB0_Calendrier_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Fin = RDBPL.DBPL_V_DB0_Calendrier_Fin; //"Fin";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblFin = RDBPL.DBPL_V_DB0_Calendrier_LblFin; //"Fin";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdFin = RDBPL.DBPL_V_DB0_Calendrier_LgdFin; //"Fin";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpFin = RDBPL.DBPL_V_DB0_Calendrier_TtpFin; //"Fin";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Periode = RDBPL.DBPL_V_DB0_Calendrier_Periode; //"Periode";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblPeriode = RDBPL.DBPL_V_DB0_Calendrier_LblPeriode; //"Periode";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdPeriode = RDBPL.DBPL_V_DB0_Calendrier_LgdPeriode; //"Periode";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpPeriode = RDBPL.DBPL_V_DB0_Calendrier_TtpPeriode; //"Periode";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_version = RDBPL.DBPL_V_DB0_Version_Id; //"Id_version";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_version = RDBPL.DBPL_V_DB0_Version_LblId; //"Id_version";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_version = RDBPL.DBPL_V_DB0_Version_LgdId; //"Id_version";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_version = RDBPL.DBPL_V_DB0_Version_TtpId; //"Id_version";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_employe = RDBPL.DBPL_V_DB0_CongeEmploye_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";


                   public readonly static string PL_V_PL0_CalendrierPlanification_Id_equipe = RDBPL.DBPL_V_DB0_Equipe_Id; //"Id_equipe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LblId_equipe = RDBPL.DBPL_V_DB0_Equipe_LblId; //"Id_equipe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_LgdId_equipe = RDBPL.DBPL_V_DB0_Equipe_LgdId; //"Id_equipe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_TtpId_equipe = RDBPL.DBPL_V_DB0_Equipe_TtpId; //"Id_equipe";

                   #endregion

                   #region  PL0_RealisationPlanification

                   public readonly static string PL_V_PL0_RealisationPlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_RealisationPlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_RealisationPlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_RealisationPlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_RealisationPlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_RealisationPlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_RealisationPlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_RealisationPlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_RealisationPlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_RealisationPlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_RealisationPlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_RealisationPlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";



                   // Colonnes supplémentaPL0_RealisationPlanification_ires
                   public readonly static string PL_V_PL0_RealisationPlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_RealisationPlanification_Debut = RDBPL.DBPL_V_DB0_Realisation_Debut; //"Debut";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDebut = RDBPL.DBPL_V_DB0_Realisation_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDebut = RDBPL.DBPL_V_DB0_Realisation_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDebut = RDBPL.DBPL_V_DB0_Realisation_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_RealisationPlanification_Duree = RDBPL.DBPL_V_DB0_Realisation_Duree; //"Duree";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblDuree = RDBPL.DBPL_V_DB0_Realisation_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdDuree = RDBPL.DBPL_V_DB0_Realisation_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpDuree = RDBPL.DBPL_V_DB0_Realisation_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_RealisationPlanification_Id_planning = RDBPL.DBPL_V_DB0_Contrainte_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RealisationPlanification_LblId_planning = RDBPL.DBPL_V_DB0_Contrainte_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RealisationPlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Contrainte_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RealisationPlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Contrainte_TtpId_planning; //"Id_planning";

                   #endregion

                   #region PL0_TachePlanification

                   public readonly static string PL_V_PL0_TachePlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_planning";

                   public readonly static string PL_V_PL0_TachePlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public readonly static string PL_V_PL0_TachePlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public readonly static string PL_V_PL0_TachePlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TachePlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TachePlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TachePlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_TachePlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public readonly static string PL_V_PL0_TachePlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public readonly static string PL_V_PL0_TachePlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public readonly static string PL_V_PL0_TachePlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public readonly static string PL_V_PL0_TachePlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_TachePlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public readonly static string PL_V_PL0_TachePlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_TachePlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_TachePlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_TachePlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public readonly static string PL_V_PL0_TachePlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_TachePlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public readonly static string PL_V_PL0_TachePlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_TachePlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public readonly static string PL_V_PL0_TachePlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public readonly static string PL_V_PL0_TachePlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_TachePlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_TachePlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public readonly static string PL_V_PL0_TachePlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_TachePlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public readonly static string PL_V_PL0_TachePlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_TachePlanification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   public readonly static string PL_V_PL0_TachePlanification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_TachePlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public readonly static string PL_V_PL0_TachePlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";

                   // Colonnes supplémentaiPL0_TachePlanification_res
                   public readonly static string PL_V_PL0_TachePlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public readonly static string PL_V_PL0_TachePlanification_Debut = RDBPL.Debut; //"Debut";
                   public readonly static string PL_V_PL0_TachePlanification_LblDebut = RDBPL.LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDebut = RDBPL.LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDebut = RDBPL.TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_TachePlanification_Duree = RDBPL.Duree; //"Duree";
                   public readonly static string PL_V_PL0_TachePlanification_LblDuree = RDBPL.LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDuree = RDBPL.LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDuree = RDBPL.TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_TachePlanification_Id_planning = RDBPL.DBPL_V_DB0_Planification_Id_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_LblId_planning = RDBPL.DBPL_V_DB0_Planification_LblId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Planification_LgdId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Planification_TtpId_planning; //"Id_planning";

                   public readonly static string PL_V_PL0_TachePlanification_Ordre = RDBPL.DBPL_V_DB0_TacheVersion_Ordre; //"Ordre";
                   public readonly static string PL_V_PL0_TachePlanification_LblOrdre = RDBPL.DBPL_V_DB0_TacheVersion_LblOrdre; //"Ordre";
                   public readonly static string PL_V_PL0_TachePlanification_LgdOrdre = RDBPL.DBPL_V_DB0_TacheVersion_LgdOrdre; //"Ordre";
                   public readonly static string PL_V_PL0_TachePlanification_TtpOrdre = RDBPL.DBPL_V_DB0_TacheVersion_TtpOrdre; //"Ordre";

                   public readonly static string PL_V_PL0_TachePlanification_Secable = RDBPL.DBPL_V_DB0_TacheVersion_Secable; //"Secable";
                   public readonly static string PL_V_PL0_TachePlanification_LblSecable = RDBPL.DBPL_V_DB0_TacheVersion_LblSecable; //"Secable";
                   public readonly static string PL_V_PL0_TachePlanification_LgdSecable = RDBPL.DBPL_V_DB0_TacheVersion_LgdSecable; //"Secable";
                   public readonly static string PL_V_PL0_TachePlanification_TtpSecable = RDBPL.DBPL_V_DB0_TacheVersion_TtpSecable; //"Secable";

                   public readonly static string PL_V_PL0_TachePlanification_Secablesurconge = RDBPL.DBPL_V_DB0_TacheVersion_Secablesurconge; //"Secablesurconge";
                   public readonly static string PL_V_PL0_TachePlanification_LblSecablesurconge = RDBPL.DBPL_V_DB0_TacheVersion_LblSecablesurconge; //"Secablesurconge";
                   public readonly static string PL_V_PL0_TachePlanification_LgdSecablesurconge = RDBPL.DBPL_V_DB0_TacheVersion_LgdSecablesurconge; //"Secablesurconge";
                   public readonly static string PL_V_PL0_TachePlanification_TtpSecablesurconge = RDBPL.DBPL_V_DB0_TacheVersion_TtpSecablesurconge; //"Secablesurconge";

                   public readonly static string PL_V_PL0_TachePlanification_Dureemini = RDBPL.DBPL_V_DB0_TacheVersion_Dureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_TachePlanification_LblDureemini = RDBPL.DBPL_V_DB0_TacheVersion_LblDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_TachePlanification_LgdDureemini = RDBPL.DBPL_V_DB0_TacheVersion_LgdDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_TachePlanification_TtpDureemini = RDBPL.DBPL_V_DB0_TacheVersion_TtpDureemini; //"Dureemini";

                   #endregion

                   #region _

                   public readonly static string PL_V_PL0_Realisation_Object = RDBPL.DBPL_V_DB0_Realisation_Object; //"Lib_projet";
                   public readonly static string PL_V_PL0_Realisation_ObjectList = RDBPL.DBPL_V_DB0_Realisation_ObjectList; //"Lib_projet";
                   public readonly static string PL_V_PL0_Realisation_TitrePage = RDBPL.DBPL_V_DB0_Realisation_TitrePage; //"Lib_projet";

                   public readonly static string PL_V_PL0_Realisation_Id = RDBPL.DBPL_V_DB0_Realisation_Id; //"Id";
                   public readonly static string PL_V_PL0_Realisation_LblId = RDBPL.DBPL_V_DB0_Realisation_LblId; //"Id";
                   public readonly static string PL_V_PL0_Realisation_LgdId = RDBPL.DBPL_V_DB0_Realisation_LgdId; //"Id";
                   public readonly static string PL_V_PL0_Realisation_TtpId = RDBPL.DBPL_V_DB0_Realisation_TtpId; //"Id";

                   public readonly static string PL_V_PL0_Realisation_Logicaldeleted = RDBPL.DBPL_V_DB0_Realisation_Logicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Realisation_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LblLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Realisation_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_LgdLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Realisation_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_TtpLogicaldeleted; //"Logicaldeleted";

                   public readonly static string PL_V_PL0_Realisation_Debut = RDBPL.DBPL_V_DB0_Realisation_Debut; //"Debut";
                   public readonly static string PL_V_PL0_Realisation_LblDebut = RDBPL.DBPL_V_DB0_Realisation_LblDebut; //"Debut";
                   public readonly static string PL_V_PL0_Realisation_LgdDebut = RDBPL.DBPL_V_DB0_Realisation_LgdDebut; //"Debut";
                   public readonly static string PL_V_PL0_Realisation_TtpDebut = RDBPL.DBPL_V_DB0_Realisation_TtpDebut; //"Debut";

                   public readonly static string PL_V_PL0_Realisation_Duree = RDBPL.DBPL_V_DB0_Realisation_Duree; //"Duree";
                   public readonly static string PL_V_PL0_Realisation_LblDuree = RDBPL.DBPL_V_DB0_Realisation_LblDuree; //"Duree";
                   public readonly static string PL_V_PL0_Realisation_LgdDuree = RDBPL.DBPL_V_DB0_Realisation_LgdDuree; //"Duree";
                   public readonly static string PL_V_PL0_Realisation_TtpDuree = RDBPL.DBPL_V_DB0_Realisation_TtpDuree; //"Duree";

                   public readonly static string PL_V_PL0_Realisation_Id_contrainte = RDBPL.DBPL_V_DB0_Realisation_Id_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Realisation_LblId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LblId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Realisation_LgdId_contrainte = RDBPL.DBPL_V_DB0_Realisation_LgdId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Realisation_TtpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_TtpId_contrainte; //"Id_contrainte";

                   public readonly static string PL_V_PL0_Realisation_Id_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_Id_contrainterealisee; //"Id_contrainterealisee";
                   public readonly static string PL_V_PL0_Realisation_LblId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_LblId_contrainterealisee; //"Id_contrainterealisee";
                   public readonly static string PL_V_PL0_Realisation_LgdId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_LgdId_contrainterealisee; //"Id_contrainterealisee";
                   public readonly static string PL_V_PL0_Realisation_TtpId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_TtpId_contrainterealisee; //"Id_contrainterealisee";

                   public readonly static string PL_V_PL0_Realisation_Id_societe = RDBPL.DBPL_V_DB0_Realisation_Id_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Realisation_LblId_societe = RDBPL.DBPL_V_DB0_Realisation_LblId_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Realisation_LgdId_societe = RDBPL.DBPL_V_DB0_Realisation_LgdId_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Realisation_TtpId_societe = RDBPL.DBPL_V_DB0_Realisation_TtpId_societe; //"Id_societe";

                   public readonly static string PL_V_PL0_Realisation_Id_application = RDBPL.DBPL_V_DB0_Realisation_Id_application; //"Id_application";
                   public readonly static string PL_V_PL0_Realisation_LblId_application = RDBPL.DBPL_V_DB0_Realisation_LblId_application; //"Id_application";
                   public readonly static string PL_V_PL0_Realisation_LgdId_application = RDBPL.DBPL_V_DB0_Realisation_LgdId_application; //"Id_application";
                   public readonly static string PL_V_PL0_Realisation_TtpId_application = RDBPL.DBPL_V_DB0_Realisation_TtpId_application; //"Id_application";

                   public readonly static string PL_V_PL0_Realisation_Id_modetravail = RDBPL.DBPL_V_DB0_Realisation_Id_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Realisation_LblId_modetravail = RDBPL.DBPL_V_DB0_Realisation_LblId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Realisation_LgdId_modetravail = RDBPL.DBPL_V_DB0_Realisation_LgdId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Realisation_TtpId_modetravail = RDBPL.DBPL_V_DB0_Realisation_TtpId_modetravail; //"Id_modetravail";

                   public readonly static string PL_V_PL0_Realisation_Id_action = RDBPL.DBPL_V_DB0_Realisation_Id_action; //"Id_action";
                   public readonly static string PL_V_PL0_Realisation_LblId_action = RDBPL.DBPL_V_DB0_Realisation_LblId_action; //"Id_action";
                   public readonly static string PL_V_PL0_Realisation_LgdId_action = RDBPL.DBPL_V_DB0_Realisation_LgdId_action; //"Id_action";
                   public readonly static string PL_V_PL0_Realisation_TtpId_action = RDBPL.DBPL_V_DB0_Realisation_TtpId_action; //"Id_action";

                   public readonly static string PL_V_PL0_Realisation_Id_employe = RDBPL.DBPL_V_DB0_Realisation_Id_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Realisation_LblId_employe = RDBPL.DBPL_V_DB0_Realisation_LblId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Realisation_LgdId_employe = RDBPL.DBPL_V_DB0_Realisation_LgdId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Realisation_TtpId_employe = RDBPL.DBPL_V_DB0_Realisation_TtpId_employe; //"Id_employe";

                   public readonly static string PL_V_PL0_Realisation_Id_projet = RDBPL.DBPL_V_DB0_Realisation_Id_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Realisation_LblId_projet = RDBPL.DBPL_V_DB0_Realisation_LblId_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Realisation_LgdId_projet = RDBPL.DBPL_V_DB0_Realisation_LgdId_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Realisation_TtpId_projet = RDBPL.DBPL_V_DB0_Realisation_TtpId_projet; //"Id_projet";

                   public readonly static string PL_V_PL0_Realisation_Id_espaceclient = RDBPL.DBPL_V_DB0_Realisation_Id_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Realisation_LblId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LblId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Realisation_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_LgdId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Realisation_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_TtpId_espaceclient; //"Id_espaceclient";




                   // Colonnes supplémentaires
                   public readonly static string PL_V_PL0_Realisation_Id_planning = RDBPL.DBPL_V_DB0_Planning_Id; //"Id_planning";
                   public readonly static string PL_V_PL0_Realisation_LblId_planning = RDBPL.DBPL_V_DB0_Planning_LblId; //"Id_planning";
                   public readonly static string PL_V_PL0_Realisation_LgdId_planning = RDBPL.DBPL_V_DB0_Planning_LgdId; //"Id_planning";
                   public readonly static string PL_V_PL0_Realisation_TtpId_planning = RDBPL.DBPL_V_DB0_Planning_TtpId; //"Id_planning";

                   //public readonly static string PL_V_PL0_Realisation_Info = DB_ConstPT._Info; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_LblInfo = DB_ConstPT._LblInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_LgdInfo = DB_ConstPT._LgdInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_TtpInfo = DB_ConstPT._TtpInfo; //"Info";

                   //public readonly static string PL_V_PL0_Realisation_Libelle = DB_ConstPT._Libelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_LblLibelle = DB_ConstPT._LblLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_LgdLibelle = DB_ConstPT._LgdLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_TtpLibelle = DB_ConstPT._TtpLibelle; //"Libelle";

                   //public readonly static string PL_V_PL0_Realisation_Commentaire = DB_ConstPT._Commentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_LblCommentaire = DB_ConstPT._LblCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_LgdCommentaire = DB_ConstPT._LgdCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_TtpCommentaire = DB_ConstPT._TtpCommentaire; //"Commentaire";

                   //public readonly static string PL_V_PL0_Realisation_Ref = DB_ConstPT._Ref; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_LblRef = DB_ConstPT._LblRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_LgdRef = DB_ConstPT._LgdRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_TtpRef = DB_ConstPT._TtpRef; //"Ref";

                   //public readonly static string PL_V_PL0_Realisation_Lib_contrainte = DB_ConstPT._Lib_contrainte; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_contrainte = DB_ConstPT._LblLib_contrainte; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_contrainte = DB_ConstPT._LgdLib_contrainte; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_contrainte = DB_ConstPT._TtpLib_contrainte; //"Lib_contrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_type = DB_ConstPT._Id_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_LblId_type = DB_ConstPT._LblId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_type = DB_ConstPT._LgdId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_type = DB_ConstPT._TtpId_type; //"Id_type";

                   //public readonly static string PL_V_PL0_Realisation_Debutcontrainte = DB_ConstPT._Debutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblDebutcontrainte = DB_ConstPT._LblDebutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdDebutcontrainte = DB_ConstPT._LgdDebutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpDebutcontrainte = DB_ConstPT._TtpDebutcontrainte; //"Debutcontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Dureecontrainte = DB_ConstPT._Dureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblDureecontrainte = DB_ConstPT._LblDureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureecontrainte = DB_ConstPT._LgdDureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureecontrainte = DB_ConstPT._TtpDureecontrainte; //"Dureecontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_recap = DB_ConstPT._Id_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_LblId_recap = DB_ConstPT._LblId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_recap = DB_ConstPT._LgdId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_recap = DB_ConstPT._TtpId_recap; //"Id_recap";

                   //public readonly static string PL_V_PL0_Realisation_Ordre = DB_ConstPT._Ordre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_LblOrdre = DB_ConstPT._LblOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_LgdOrdre = DB_ConstPT._LgdOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_TtpOrdre = DB_ConstPT._TtpOrdre; //"Ordre";

                   //public readonly static string PL_V_PL0_Realisation_Infocontrainte = DB_ConstPT._Infocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblInfocontrainte = DB_ConstPT._LblInfocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdInfocontrainte = DB_ConstPT._LgdInfocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpInfocontrainte = DB_ConstPT._TtpInfocontrainte; //"Infocontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Fincontrainte = DB_ConstPT._Fincontrainte; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LblFincontrainte = DB_ConstPT._LblFincontrainte; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_LgdFincontrainte = DB_ConstPT._LgdFincontrainte; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_TtpFincontrainte = DB_ConstPT._TtpFincontrainte; //"Fincontrainte";

                   //public readonly static string PL_V_PL0_Realisation_Id_uniteduree = DB_ConstPT._Id_uniteduree; //"Id_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LblId_uniteduree = DB_ConstPT._LblId_uniteduree; //"Id_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_uniteduree = DB_ConstPT._LgdId_uniteduree; //"Id_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_uniteduree = DB_ConstPT._TtpId_uniteduree; //"Id_uniteduree";

                   //public readonly static string PL_V_PL0_Realisation_Recurrente = DB_ConstPT._Recurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_LblRecurrente = DB_ConstPT._LblRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_LgdRecurrente = DB_ConstPT._LgdRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_TtpRecurrente = DB_ConstPT._TtpRecurrente; //"Recurrente";

                   //public readonly static string PL_V_PL0_Realisation_Periode = DB_ConstPT._Periode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_LblPeriode = DB_ConstPT._LblPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_LgdPeriode = DB_ConstPT._LgdPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_TtpPeriode = DB_ConstPT._TtpPeriode; //"Periode";

                   //public readonly static string PL_V_PL0_Realisation_Id_uniteperiode = DB_ConstPT._Id_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LblId_uniteperiode = DB_ConstPT._LblId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_uniteperiode = DB_ConstPT._LgdId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_uniteperiode = DB_ConstPT._TtpId_uniteperiode; //"Id_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Decalesioccupe = DB_ConstPT._Decalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_LblDecalesioccupe = DB_ConstPT._LblDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_LgdDecalesioccupe = DB_ConstPT._LgdDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_TtpDecalesioccupe = DB_ConstPT._TtpDecalesioccupe; //"Decalesioccupe";

                   //public readonly static string PL_V_PL0_Realisation_Secable = DB_ConstPT._Secable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_LblSecable = DB_ConstPT._LblSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_LgdSecable = DB_ConstPT._LgdSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_TtpSecable = DB_ConstPT._TtpSecable; //"Secable";

                   //public readonly static string PL_V_PL0_Realisation_Minparjour = DB_ConstPT._Minparjour; //"Minparjour";
                   //public readonly static string PL_V_PL0_Realisation_LblMinparjour = DB_ConstPT._LblMinparjour; //"Minparjour";
                   //public readonly static string PL_V_PL0_Realisation_LgdMinparjour = DB_ConstPT._LgdMinparjour; //"Minparjour";
                   //public readonly static string PL_V_PL0_Realisation_TtpMinparjour = DB_ConstPT._TtpMinparjour; //"Minparjour";

                   //public readonly static string PL_V_PL0_Realisation_Dureeinitiale = DB_ConstPT._Dureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_LblDureeinitiale = DB_ConstPT._LblDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureeinitiale = DB_ConstPT._LgdDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureeinitiale = DB_ConstPT._TtpDureeinitiale; //"Dureeinitiale";

                   //public readonly static string PL_V_PL0_Realisation_Abr_type = DB_ConstPT.DB0_TypeTache_Abr_type; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_type = DB_ConstPT.DB0_TypeTache_LblAbr_type; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_type = DB_ConstPT.DB0_TypeTache_LgdAbr_type; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_type = DB_ConstPT.DB0_TypeTache_TtpAbr_type; //"Abr_type";

                   //public readonly static string PL_V_PL0_Realisation_Lib_type = DB_ConstPT.DB0_TypeTache_Lib_type; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_type = DB_ConstPT.DB0_TypeTache_LblLib_type; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_type = DB_ConstPT.DB0_TypeTache_LgdLib_type; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_type = DB_ConstPT.DB0_TypeTache_TtpLib_type; //"Lib_type";

                   //public readonly static string PL_V_PL0_Realisation_Lib_recap = DB_ConstPT._Lib_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_recap = DB_ConstPT._LblLib_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_recap = DB_ConstPT._LgdLib_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_recap = DB_ConstPT._TtpLib_recap; //"Lib_recap";

                   //public readonly static string PL_V_PL0_Realisation_Abr_uniteduree = DB_ConstPT.DB0_UniteHorairefAbr_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_uniteduree = DB_ConstPT.DB0_UniteHorairefLblAbr_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_uniteduree = DB_ConstPT.DB0_UniteHorairefLgdAbr_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_uniteduree = DB_ConstPT.DB0_UniteHorairefTtpAbr_uniteduree; //"Abr_uniteduree";

                   //public readonly static string PL_V_PL0_Realisation_Lib_uniteduree = DB_ConstPT.DB0_UniteHorairefLib_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_uniteduree = DB_ConstPT.DB0_UniteHorairefLblLib_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_uniteduree = DB_ConstPT.DB0_UniteHorairefLgdLib_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_uniteduree = DB_ConstPT.DB0_UniteHorairefTtpLib_uniteduree; //"Lib_uniteduree";

                   //public readonly static string PL_V_PL0_Realisation_Abr_uniteperiode = DB_ConstPT.DB0_UniteHorairefAbr_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_uniteperiode = DB_ConstPT.DB0_UniteHorairefLblAbr_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_uniteperiode = DB_ConstPT.DB0_UniteHorairefLgdAbr_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_uniteperiode = DB_ConstPT.DB0_UniteHorairefTtpAbr_uniteperiode; //"Abr_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Lib_uniteperiode = DB_ConstPT.DB0_UniteHorairefLib_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_uniteperiode = DB_ConstPT.DB0_UniteHorairefLblLib_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_uniteperiode = DB_ConstPT.DB0_UniteHorairefLgdLib_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_uniteperiode = DB_ConstPT.DB0_UniteHorairefTtpLib_uniteperiode; //"Lib_uniteperiode";

                   //public readonly static string PL_V_PL0_Realisation_Debutcalc = DB_ConstPT.fDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_LblDebutcalc = DB_ConstPT.fLblDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdDebutcalc = DB_ConstPT.fLgdDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpDebutcalc = DB_ConstPT.fTtpDebutcalc; //"Debutcalc";

                   //public readonly static string PL_V_PL0_Realisation_Fincalc = DB_ConstPT.fFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_LblFincalc = DB_ConstPT.fLblFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdFincalc = DB_ConstPT.fLgdFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpFincalc = DB_ConstPT.fTtpFincalc; //"Fincalc";

                   //public readonly static string PL_V_PL0_Realisation_Dureecalc = DB_ConstPT.fDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_LblDureecalc = DB_ConstPT.fLblDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_LgdDureecalc = DB_ConstPT.fLgdDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_TtpDureecalc = DB_ConstPT.fTtpDureecalc; //"Dureecalc";

                   //public readonly static string PL_V_PL0_Realisation_Id_version = DB_ConstPT.DB0_Version_Id_version; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_LblId_version = DB_ConstPT.DB0_Version_LblId_version; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_LgdId_version = DB_ConstPT.DB0_Version_LgdId_version; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_TtpId_version = DB_ConstPT.DB0_Version_TtpId_version; //"Id_version";

                   //public readonly static string PL_V_PL0_Realisation_Abr_societe = DB_ConstPT.DB0_Societe_Abr_societe; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_societe = DB_ConstPT.DB0_Societe_LblAbr_societe; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_societe = DB_ConstPT.DB0_Societe_LgdAbr_societe; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_societe = DB_ConstPT.DB0_Societe_TtpAbr_societe; //"Abr_societe";

                   //public readonly static string PL_V_PL0_Realisation_Lib_societe = DB_ConstPT.DB0_Societe_Lib_societe; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_societe = DB_ConstPT.DB0_Societe_LblLib_societe; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_societe = DB_ConstPT.DB0_Societe_LgdLib_societe; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_societe = DB_ConstPT.DB0_Societe_TtpLib_societe; //"Lib_societe";

                   //public readonly static string PL_V_PL0_Realisation_Abr_application = DB_ConstPT.DB0_Application_Abr_application; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_application = DB_ConstPT.DB0_Application_LblAbr_application; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_application = DB_ConstPT.DB0_Application_LgdAbr_application; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_application = DB_ConstPT.DB0_Application_TtpAbr_application; //"Abr_application";

                   //public readonly static string PL_V_PL0_Realisation_Lib_application = DB_ConstPT.DB0_Application_Lib_application; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_application = DB_ConstPT.DB0_Application_LblLib_application; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_application = DB_ConstPT.DB0_Application_LgdLib_application; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_application = DB_ConstPT.DB0_Application_TtpLib_application; //"Lib_application";

                   //public readonly static string PL_V_PL0_Realisation_Abr_modetravail = DB_ConstPT.DB0_ModeTravail_Abr_modetravail; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_modetravail = DB_ConstPT.DB0_ModeTravail_LblAbr_modetravail; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_modetravail = DB_ConstPT.DB0_ModeTravail_LgdAbr_modetravail; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_modetravail = DB_ConstPT.DB0_ModeTravail_TtpAbr_modetravail; //"Abr_modetravail";

                   //public readonly static string PL_V_PL0_Realisation_Lib_modetravail = DB_ConstPT.DB0_ModeTravail_Lib_modetravail; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_modetravail = DB_ConstPT.DB0_ModeTravail_LblLib_modetravail; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_modetravail = DB_ConstPT.DB0_ModeTravail_LgdLib_modetravail; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_modetravail = DB_ConstPT.DB0_ModeTravail_TtpLib_modetravail; //"Lib_modetravail";

                   //public readonly static string PL_V_PL0_Realisation_Abr_action = DB_ConstPT.DB0_Action_Abr_action; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_action = DB_ConstPT.DB0_Action_LblAbr_action; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_action = DB_ConstPT.DB0_Action_LgdAbr_action; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_action = DB_ConstPT.DB0_Action_TtpAbr_action; //"Abr_action";

                   //public readonly static string PL_V_PL0_Realisation_Lib_action = DB_ConstPT.DB0_Action_Lib_action; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_action = DB_ConstPT.DB0_Action_LblLib_action; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_action = DB_ConstPT.DB0_Action_LgdLib_action; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_action = DB_ConstPT.DB0_Action_TtpLib_action; //"Lib_action";

                   //public readonly static string PL_V_PL0_Realisation_Init_employe = DB_ConstPT.DB0_Employe_Init_employe; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_LblInit_employe = DB_ConstPT.DB0_Employe_LblInit_employe; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_LgdInit_employe = DB_ConstPT.DB0_Employe_LgdInit_employe; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_TtpInit_employe = DB_ConstPT.DB0_Employe_TtpInit_employe; //"Init_employe";

                   //public readonly static string PL_V_PL0_Realisation_Ident_employe = DB_ConstPT.DB0_Employe_Ident_employe; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_LblIdent_employe = DB_ConstPT.DB0_Employe_LblIdent_employe; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_LgdIdent_employe = DB_ConstPT.DB0_Employe_LgdIdent_employe; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_TtpIdent_employe = DB_ConstPT.DB0_Employe_TtpIdent_employe; //"Ident_employe";

                   //public readonly static string PL_V_PL0_Realisation_Abr_projet = DB_ConstPT.DB0_Projet_Id; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LblAbr_projet = DB_ConstPT.DB0_Projet_LblId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LgdAbr_projet = DB_ConstPT.DB0_Projet_LgdId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_TtpAbr_projet = DB_ConstPT.DB0_Projet_TtpId; //"Id";

                   //public readonly static string PL_V_PL0_Realisation_Lib_projet = DB_ConstPT.DB0_Projet_Id; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LblLib_projet = DB_ConstPT.DB0_Projet_LblId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_LgdLib_projet = DB_ConstPT.DB0_Projet_LgdId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_TtpLib_projet = DB_ConstPT.DB0_Projet_TtpId; //"Id";

                   #endregion

                   #region PL0_RecapPlanification_

                   public static readonly string PL_V_PL0_RecapPlanification_Object = RDBPL.DBPL_V_DB0_Planification_Object;
                   public static readonly string PL_V_PL0_RecapPlanification_ObjectList = RDBPL.DBPL_V_DB0_Planification_ObjectList; //"Id_planning";
                   public static readonly string PL_V_PL0_RecapPlanification_TitrePage = RDBPL.DBPL_V_DB0_Planification_TitrePage; //"Id_planning";

                   public static readonly string PL_V_PL0_RecapPlanification_Id = RDBPL.DBPL_V_DB0_Planification_Id; //"Id";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId = RDBPL.DBPL_V_DB0_Planification_LblId; //"Id";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId = RDBPL.DBPL_V_DB0_Planification_LgdId; //"Id";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId = RDBPL.DBPL_V_DB0_Planification_TtpId; //"Id";

                   public static readonly string PL_V_PL0_RecapPlanification_Logicaldeleted = RDBPL.DBPL_V_DB0_Planification_Logicaldeleted; //"Logicaldeleted";
                   public static readonly string PL_V_PL0_RecapPlanification_LblLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LblLogicaldeleted; //"Logicaldeleted";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_LgdLogicaldeleted; //"Logicaldeleted";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_TtpLogicaldeleted; //"Logicaldeleted";

                   public static readonly string PL_V_PL0_RecapPlanification_Info = RDBPL.DBPL_V_DB0_Planification_Info; //"Info";
                   public static readonly string PL_V_PL0_RecapPlanification_LblInfo = RDBPL.DBPL_V_DB0_Planification_LblInfo; //"Info";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdInfo = RDBPL.DBPL_V_DB0_Planification_LgdInfo; //"Info";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpInfo = RDBPL.DBPL_V_DB0_Planification_TtpInfo; //"Info";

                   public static readonly string PL_V_PL0_RecapPlanification_Debutcalc = RDBPL.DBPL_V_DB0_Planification_Debutcalc; //"Debutcalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LblDebutcalc = RDBPL.DBPL_V_DB0_Planification_LblDebutcalc; //"Debutcalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdDebutcalc = RDBPL.DBPL_V_DB0_Planification_LgdDebutcalc; //"Debutcalc";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpDebutcalc = RDBPL.DBPL_V_DB0_Planification_TtpDebutcalc; //"Debutcalc";

                   public static readonly string PL_V_PL0_RecapPlanification_Fincalc = RDBPL.DBPL_V_DB0_Planification_Fincalc; //"Fincalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LblFincalc = RDBPL.DBPL_V_DB0_Planification_LblFincalc; //"Fincalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdFincalc = RDBPL.DBPL_V_DB0_Planification_LgdFincalc; //"Fincalc";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpFincalc = RDBPL.DBPL_V_DB0_Planification_TtpFincalc; //"Fincalc";

                   public static readonly string PL_V_PL0_RecapPlanification_Dureecalc = RDBPL.DBPL_V_DB0_Planification_Dureecalc; //"Dureecalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LblDureecalc = RDBPL.DBPL_V_DB0_Planification_LblDureecalc; //"Dureecalc";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdDureecalc = RDBPL.DBPL_V_DB0_Planification_LgdDureecalc; //"Dureecalc";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpDureecalc = RDBPL.DBPL_V_DB0_Planification_TtpDureecalc; //"Dureecalc";

                   public static readonly string PL_V_PL0_RecapPlanification_Debutreal = RDBPL.DBPL_V_DB0_Planification_Debutreal; //"Debutreal";
                   public static readonly string PL_V_PL0_RecapPlanification_LblDebutreal = RDBPL.DBPL_V_DB0_Planification_LblDebutreal; //"Debutreal";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdDebutreal = RDBPL.DBPL_V_DB0_Planification_LgdDebutreal; //"Debutreal";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpDebutreal = RDBPL.DBPL_V_DB0_Planification_TtpDebutreal; //"Debutreal";

                   public static readonly string PL_V_PL0_RecapPlanification_Finreal = RDBPL.DBPL_V_DB0_Planification_Finreal; //"Finreal";
                   public static readonly string PL_V_PL0_RecapPlanification_LblFinreal = RDBPL.DBPL_V_DB0_Planification_LblFinreal; //"Finreal";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdFinreal = RDBPL.DBPL_V_DB0_Planification_LgdFinreal; //"Finreal";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpFinreal = RDBPL.DBPL_V_DB0_Planification_TtpFinreal; //"Finreal";

                   public static readonly string PL_V_PL0_RecapPlanification_Dureereal = RDBPL.DBPL_V_DB0_Planification_Dureereal; //"Dureereal";
                   public static readonly string PL_V_PL0_RecapPlanification_LblDureereal = RDBPL.DBPL_V_DB0_Planification_LblDureereal; //"Dureereal";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdDureereal = RDBPL.DBPL_V_DB0_Planification_LgdDureereal; //"Dureereal";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpDureereal = RDBPL.DBPL_V_DB0_Planification_TtpDureereal; //"Dureereal";

                   public static readonly string PL_V_PL0_RecapPlanification_Id_contrainte = RDBPL.DBPL_V_DB0_Planification_Id_contrainte; //"Id_contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_contrainte = RDBPL.DBPL_V_DB0_Planification_LblId_contrainte; //"Id_contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_contrainte = RDBPL.DBPL_V_DB0_Planification_LgdId_contrainte; //"Id_contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_contrainte = RDBPL.DBPL_V_DB0_Planification_TtpId_contrainte; //"Id_contrainte";

                   public static readonly string PL_V_PL0_RecapPlanification_Id_version = RDBPL.DBPL_V_DB0_Planification_Id_version; //"Id_version";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_version = RDBPL.DBPL_V_DB0_Planification_LblId_version; //"Id_version";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_version = RDBPL.DBPL_V_DB0_Planification_LgdId_version; //"Id_version";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_version = RDBPL.DBPL_V_DB0_Planification_TtpId_version; //"Id_version";

                   public static readonly string PL_V_PL0_RecapPlanification_Id_employe = RDBPL.DBPL_V_DB0_Planification_Id_employe; //"Id_employe";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_employe = RDBPL.DBPL_V_DB0_Planification_LblId_employe; //"Id_employe";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_employe = RDBPL.DBPL_V_DB0_Planification_LgdId_employe; //"Id_employe";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_employe = RDBPL.DBPL_V_DB0_Planification_TtpId_employe; //"Id_employe";

                   public static readonly string PL_V_PL0_RecapPlanification_Contrainte = RDBPL.DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_LblContrainte = RDBPL.DBPL_V_DB0_Planification_LblContrainte; //"Contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdContrainte = RDBPL.DBPL_V_DB0_Planification_LgdContrainte; //"Contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpContrainte = RDBPL.DBPL_V_DB0_Planification_TtpContrainte; //"Contrainte";

                   public static readonly string PL_V_PL0_RecapPlanification_Id_espaceclient = RDBPL.DBPL_V_DB0_Planification_Id_espaceclient; //"Id_espaceclient";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LblId_espaceclient; //"Id_espaceclient";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_espaceclient = RDBPL.DBPL_V_DB0_Planification_LgdId_espaceclient; //"Id_espaceclient";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_TtpId_espaceclient; //"Id_espaceclient";


                   // Colonnes supplémentaires      PL0_RecapPlanification_
                   public static readonly string PL_V_PL0_RecapPlanification_Id_typetache = RDBPL.DBPL_V_DB0_Planification_Id_typetache; //"Id_typetache";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_typetache = RDBPL.DBPL_V_DB0_Planification_LblId_typetache; //"Id_typetache";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_typetache = RDBPL.DBPL_V_DB0_Planification_LgdId_typetache; //"Id_typetache";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_typetache = RDBPL.DBPL_V_DB0_Planification_TtpId_typetache; //"Id_typetache";

                   public static readonly string PL_V_PL0_RecapPlanification_Id_planning = RDBPL.DBPL_V_DB0_Planification_Id_planning; //"Id_planning";
                   public static readonly string PL_V_PL0_RecapPlanification_LblId_planning = RDBPL.DBPL_V_DB0_Planification_LblId_planning; //"Id_planning";
                   public static readonly string PL_V_PL0_RecapPlanification_LgdId_planning = RDBPL.DBPL_V_DB0_Planification_LgdId_planning; //"Id_planning";
                   public static readonly string PL_V_PL0_RecapPlanification_TtpId_planning = RDBPL.DBPL_V_DB0_Planification_TtpId_planning; //"Id_planning";

                   #endregion

                   #region help

                   #region PL0_Action_

                   public readonly static string PL_V_PL0_Action_HelpPage = RDBPL.DBPL_V_DB0_Action_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_Action_HlpId = RDBPL.DBPL_V_DB0_Action_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Action_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Action_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Action_HlpLibelle = RDBPL.DBPL_V_DB0_Action_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Action_HlpAbreviation = RDBPL.DBPL_V_DB0_Action_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Action_HlpId_planning = RDBPL.DBPL_V_DB0_Action_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Action_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Action_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Application_

                   public readonly static string PL_V_PL0_Application_HelpPage = RDBPL.DBPL_V_DB0_Application_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_Application_HlpId = RDBPL.DBPL_V_DB0_Application_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Application_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Application_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Application_HlpLibelle = RDBPL.DBPL_V_DB0_Application_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Application_HlpAbreviation = RDBPL.DBPL_V_DB0_Application_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Application_HlpId_planning = RDBPL.DBPL_V_DB0_Application_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Application_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Application_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Calendrier_

                   public readonly static string PL_V_PL0_Calendrier_HelpPage = RDBPL.DBPL_V_DB0_Calendrier_HelpPage; //"Id_uniteperiode";

                   public readonly static string PL_V_PL0_Calendrier_HlpId = RDBPL.DBPL_V_DB0_Calendrier_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Calendrier_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Calendrier_HlpDebut = RDBPL.DBPL_V_DB0_Calendrier_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Calendrier_HlpFin = RDBPL.DBPL_V_DB0_Calendrier_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_Calendrier_HlpPeriode = RDBPL.DBPL_V_DB0_Calendrier_HlpPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Calendrier_HlpFinperiode = RDBPL.DBPL_V_DB0_Calendrier_HlpFinperiode; //"Finperiode";
                   //public readonly static string PL_V_PL0_Calendrier_HlpId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_HlpId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PL0_Calendrier_HlpId_equipe = RDBPL.DBPL_V_DB0_Calendrier_HlpId_equipe; //"Id_equipe";
                   //public readonly static string PL_V_PL0_Calendrier_HlpAbreviation = RDBPL.DBPL_V_DB0_Calendrier_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Calendrier_HlpDuree = RDBPL.DBPL_V_DB0_Calendrier_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Calendrier_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Calendrier_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Calendrier_HlpId_contrainte = RDBPL.DBPL_V_DB0_Calendrier_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Calendrier_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_ModeTravail_

                   public readonly static string PL_V_PL0_ModeTravail_HelpPage = RDBPL.DBPL_V_DB0_ModeTravail_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_ModeTravail_HlpId = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id";
                   public readonly static string PL_V_PL0_ModeTravail_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ModeTravail_HlpLibelle = RDBPL.DBPL_V_DB0_ModeTravail_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_ModeTravail_HlpAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_ModeTravail_HlpId_planning = RDBPL.DBPL_V_DB0_ModeTravail_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ModeTravail_HlpId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Projet_

                   public readonly static string PL_V_PL0_Projet_HelpPage = RDBPL.DBPL_V_DB0_Projet_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_Projet_HlpId = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Projet_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Projet_HlpLibelle = RDBPL.DBPL_V_DB0_Projet_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Projet_HlpAbreviation = RDBPL.DBPL_V_DB0_Projet_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Projet_HlpId_planning = RDBPL.DBPL_V_DB0_Projet_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Projet_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Projet_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Societe_

                   public readonly static string PL_V_PL0_Societe_HelpPage = RDBPL.DBPL_V_DB0_Societe_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_Societe_HlpId = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Societe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Societe_HlpLibelle = RDBPL.DBPL_V_DB0_Societe_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Societe_HlpAbreviation = RDBPL.DBPL_V_DB0_Societe_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Societe_HlpId_planning = RDBPL.DBPL_V_DB0_Societe_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Societe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Societe_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Statut_

                   public readonly static string PL_V_PL0_Statut_HelpPage = RDBPL.DBPL_V_DB0_Statut_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_Statut_HlpId = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Statut_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Statut_HlpLibelle = RDBPL.DBPL_V_DB0_Statut_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Statut_HlpAbreviation = RDBPL.DBPL_V_DB0_Statut_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_Statut_HlpId_planning = RDBPL.DBPL_V_DB0_Statut_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Statut_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Statut_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_TypeTache_

                   public readonly static string PL_V_PL0_TypeTache_HelpPage = RDBPL.DBPL_V_DB0_TypeTache_HelpPage; //"Abreviation";

                   public readonly static string PL_V_PL0_TypeTache_HlpId = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Id";
                   public readonly static string PL_V_PL0_TypeTache_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TypeTache_HlpLibelle = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_TypeTache_HlpAbreviation = RDBPL.DBPL_V_DB0_TypeTache_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_TypeTache_HlpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_UniteHoraire_

                   public readonly static string PL_V_PL0_UniteHoraire_HelpPage = RDBPL.DBPL_V_DB0_UniteHoraire_HelpPage; //"Abreviation";

                   public readonly static string PL_V_PL0_UniteHoraire_HlpId = RDBPL.DBPL_V_DB0_UniteHoraire_HlpId; //"Id";
                   public readonly static string PL_V_PL0_UniteHoraire_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_UniteHoraire_HlpLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_UniteHoraire_HlpAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PL0_UniteHoraire_HlpId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Planification

                   public readonly static string PL_V_PL0_Planification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Lib_version";

                   public readonly static string PL_V_PL0_Planification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Planification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Planification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Planification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Planification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_Planification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Planification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Planification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Planification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Planification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Planification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Planification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Planification_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_planning";
                   public readonly static string PL_V_PL0_Planification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_Planification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_espaceclient";
                   //public readonly static string PL_V_PL0_Planification_HlpId_recap = RDBPL.DBPL_V_DB0_Contrainte_HlpId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Planification_HlpOrdre = RDBPL.DBPL_V_DB0_Contrainte_HlpOrdre; //"Ordre";
                   public readonly static string PL_V_PL0_Planification_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Planification_HlpId_type = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Id_type";
                   public readonly static string PL_V_PL0_Planification_HlpLib_type = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Lib_type";
                   public readonly static string PL_V_PL0_Planification_HlpDebut = RDBPL.DBPL_V_DB0_TypeTache_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Planification_HlpFin = RDBPL.DBPL_V_DB0_TypeTache_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_Planification_HlpAbr_type = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Abr_type";
                   public readonly static string PL_V_PL0_Planification_HlpLib_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpId; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Planification_HlpId_type = DB_ConstPT.DB0_Contrainte_HlpId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Planification_HlpLib_recap = DB_ConstPT.DB0_Contrainte_HlpId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Planification_HlpInfocontrainte = DB_ConstPT.DB0_Contrainte_HlpInfo; //"Infocontrainte";
                   public readonly static string PL_V_PL0_Planification_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Planification_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Init_employe";
                   public readonly static string PL_V_PL0_Planification_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Lib_version";
                   public readonly static string PL_V_PL0_Planification_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Planification_HlpDuree = RDBPL.DBPL_V_DB0_Contrainte_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Planification_HlpId_typetache = RDBPL.DBPL_V_DB0_Contrainte_HlpId_typetache; //"Duree";

                   #endregion

                   #region PL0_Realisation

                   //public readonly static string PL_V_PL0_Realisation_HelpPage = DB_ConstPT._HelpPage; //"Lib_projet";

                   //public readonly static string PL_V_PL0_Realisation_HlpId = DB_ConstPT._HlpId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_HlpDebut = DB_ConstPT._HlpDebut; //"Debut";
                   //public readonly static string PL_V_PL0_Realisation_HlpDuree = DB_ConstPT._HlpDuree; //"Duree";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_contrainte = DB_ConstPT._HlpId_contrainte; //"Id_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpFin = DB_ConstPT._HlpFin; //"Fin";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_societe = DB_ConstPT._HlpId_societe; //"Id_societe";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_application = DB_ConstPT._HlpId_application; //"Id_application";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_modetravail = DB_ConstPT._HlpId_modetravail; //"Id_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_action = DB_ConstPT._HlpId_action; //"Id_action";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_employe = DB_ConstPT._HlpId_employe; //"Id_employe";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_projet = DB_ConstPT._HlpId_projet; //"Id_projet";
                   //public readonly static string PL_V_PL0_Realisation_HlpLibelle = DB_ConstPT.DB0_Contrainte_HlpLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_HlpDebutcalc = DB_ConstPT.DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpFincalc = DB_ConstPT.DB0_Planification_HlpFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureecalc = DB_ConstPT.DB0_Planification_HlpDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_planning = DB_ConstPT.DB0_Contrainte_HlpId_planning; //"Id_planning";
                   //public readonly static string PL_V_PL0_Realisation_HlpCommentaire = DB_ConstPT.DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_HlpInfo = DB_ConstPT.DB0_Planification_HlpInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_HlpRef = DB_ConstPT.DB0_Contrainte_HlpRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_contrainte = DB_ConstPT.DB0_Contrainte_HlpId; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_type = DB_ConstPT.DB0_TypeTache_HlpId; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpDebutcontrainte = PL0_Realisation_Debutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureecontrainte = PL0_Realisation_Dureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_recap = DB_ConstPT.DB0_Contrainte_HlpId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_HlpOrdre = DB_ConstPT.DB0_Contrainte_HlpOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_HlpInfocontrainte = PL0_Realisation_Infocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpFincontrainte = DB_ConstPT.DB0_Contrainte_HlpFin; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_uniteduree = DB_ConstPT.DB0_Contrainte_HlpId_uniteduree; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpRecurrente = DB_ConstPT.DB0_Contrainte_HlpRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_HlpPeriode = DB_ConstPT.DB0_Contrainte_HlpPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_uniteperiode = DB_ConstPT.DB0_Contrainte_HlpId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpDecalesioccupe = DB_ConstPT.DB0_Contrainte_HlpDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_HlpSecable = DB_ConstPT.DB0_Contrainte_HlpSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureemini = DB_ConstPT.DB0_Contrainte_HlpDureemini; //"Dureemini";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureeinitiale = DB_ConstPT.DB0_Contrainte_HlpDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_type = DB_ConstPT.DB0_TypeTache_HlpId; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_type = DB_ConstPT.DB0_TypeTache_HlpId; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_recap = DB_ConstPT.DB0_Contrainte_HlpId_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_uniteduree = DB_ConstPT.DB0_Contrainte_HlpId_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_uniteduree = DB_ConstPT.DB0_Contrainte_HlpId_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_uniteperiode = DB_ConstPT.DB0_Contrainte_HlpId_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_uniteperiode = DB_ConstPT.DB0_Contrainte_HlpId_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_version = DB_ConstPT.DB0_Version_HlpId; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_societe = DB_ConstPT.DB0_Societe_HlpId; //"Abr_societe";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_societe = DB_ConstPT.DB0_Societe_HlpId; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_application = DB_ConstPT.DB0_Application_HlpId; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_application = DB_ConstPT.DB0_Application_HlpId; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_modetravail = DB_ConstPT.DB0_ModeTravail_HlpId; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_modetravail = DB_ConstPT.DB0_ModeTravail_HlpId; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_action = DB_ConstPT.DB0_Action_HlpId; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_action = DB_ConstPT.DB0_Action_HlpId; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_HlpInit_employe = DB_ConstPT.DB0_Employe_HlpId; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_HlpIdent_employe = DB_ConstPT.DB0_Employe_HlpId; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_projet = DB_ConstPT.DB0_Projet_HlpId; //"Abr_projet";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_projet = DB_ConstPT.DB0_Projet_HlpId; //"Lib_projet";

                   #endregion

                   #region PL0_Planification

                   //public readonly static string PL_V_PL0_Planification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";

                   #endregion

                   #region PL0_Contrainte

                   public readonly static string PL_V_PL0_Contrainte_HelpPage = RDBPL.DBPL_V_DB0_Contrainte_HelpPage; //"Ref";

                   public readonly static string PL_V_PL0_Contrainte_HlpId = RDBPL.DBPL_V_DB0_Contrainte_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Contrainte_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Contrainte_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Contrainte_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Contrainte_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Contrainte_HlpId_typetache = RDBPL.DBPL_V_DB0_Contrainte_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_Contrainte_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Contrainte_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Contrainte_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PT9_Droits_

                   public readonly static string PL_V_PT9_Droits_HelpPage = "Droits";

                   public readonly static string PL_V_PT9_Droits_HlpId = RDBPL.DBPL_V_DB0_Utilisateur_HlpId; //"Id";
                   public readonly static string PL_V_PT9_Droits_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PT9_Droits_HlpPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_HlpPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PT9_Droits_HlpPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_HlpPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PT9_Droits_HlpIdentite = RDBPL.DBPL_V_DB0_Utilisateur_HlpIdentite; //"Identite";
                   public readonly static string PL_V_PT9_Droits_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Action_

                   public readonly static string PL_V_PTC_Action_HelpPage = RDBPL.DBPL_V_DB0_Action_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Action_HlpId = RDBPL.DBPL_V_DB0_Action_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Action_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Action_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Action_HlpLibelle = RDBPL.DBPL_V_DB0_Action_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Action_HlpAbreviation = RDBPL.DBPL_V_DB0_Action_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Action_HlpId_planning = RDBPL.DBPL_V_DB0_Action_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Action_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Action_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Application_

                   public readonly static string PL_V_PTC_Application_HelpPage = RDBPL.DBPL_V_DB0_Application_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Application_HlpId = RDBPL.DBPL_V_DB0_Application_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Application_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Application_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Application_HlpLibelle = RDBPL.DBPL_V_DB0_Application_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Application_HlpAbreviation = RDBPL.DBPL_V_DB0_Application_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Application_HlpId_planning = RDBPL.DBPL_V_DB0_Application_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Application_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Application_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Calendrier_

                   public readonly static string PL_V_PTC_Calendrier_HelpPage = RDBPL.DBPL_V_DB0_Calendrier_HelpPage; //"Id_uniteperiode";

                   public readonly static string PL_V_PTC_Calendrier_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Calendrier_HlpLogicaldeleted; //"Logicaldeleted";
                   //public readonly static string PL_V_PTC_Calendrier_HlpId_planning = DB_ConstPT.DB0_Calendrier_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Calendrier_HlpDebut = RDBPL.DBPL_V_DB0_Calendrier_HlpDebut; //"Debut";
                   public readonly static string PL_V_PTC_Calendrier_HlpFin = RDBPL.DBPL_V_DB0_Calendrier_HlpFin; //"Fin";
                   public readonly static string PL_V_PTC_Calendrier_HlpPeriode = RDBPL.DBPL_V_DB0_Calendrier_HlpPeriode; //"Periode";
                   //public readonly static string PL_V_PTC_Calendrier_HlpFinperiode = RDBPL.DBPL_V_DB0_Calendrier_HlpFinperiode; //"Finperiode";
                   //public readonly static string PL_V_PTC_Calendrier_HlpId_uniteperiode = RDBPL.DBPL_V_DB0_Calendrier_HlpId_uniteperiode; //"Id_uniteperiode";
                   public readonly static string PL_V_PTC_Calendrier_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Calendrier_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Employe_

                   public readonly static string PL_V_PTC_Employe_HelpPage = RDBPL.DBPL_V_DB0_Employe_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Employe_HlpId = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Employe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Employe_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Employe_HlpInitiales = RDBPL.DBPL_V_DB0_Employe_HlpInitiales; //"Initiales";
                   public readonly static string PL_V_PTC_Employe_HlpIdentite = RDBPL.DBPL_V_DB0_Employe_HlpIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Employe_HlpId_planning = RDBPL.DBPL_V_DB0_Employe_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Employe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Employe_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Equipe

                   public readonly static string PL_V_PTC_Equipe_HelpPage = RDBPL.DBPL_V_DB0_Equipe_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Equipe_HlpId = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Equipe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Equipe_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Equipe_HlpLibelle = RDBPL.DBPL_V_DB0_Equipe_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Equipe_HlpAbreviation = RDBPL.DBPL_V_DB0_Equipe_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Equipe_HlpId_planning = RDBPL.DBPL_V_DB0_Equipe_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Equipe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Equipe_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_ModeTravail_

                   public readonly static string PL_V_PTC_ModeTravail_HelpPage = RDBPL.DBPL_V_DB0_ModeTravail_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_ModeTravail_HlpId = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id";
                   public readonly static string PL_V_PTC_ModeTravail_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_ModeTravail_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_ModeTravail_HlpLibelle = RDBPL.DBPL_V_DB0_ModeTravail_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_ModeTravail_HlpAbreviation = RDBPL.DBPL_V_DB0_ModeTravail_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_ModeTravail_HlpId_planning = RDBPL.DBPL_V_DB0_ModeTravail_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_ModeTravail_HlpId_espaceclient = RDBPL.DBPL_V_DB0_ModeTravail_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Planification_

                   public readonly static string PL_V_PTC_Planification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_employe";

                   public readonly static string PL_V_PTC_Planification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   //public readonly static string PL_V_PTC_Planification_HlpInfo = DB_ConstPT.DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PTC_Planification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   //public readonly static string PL_V_PTC_Planification_HlpFincalc = DB_ConstPT.DB0_Planification_HlpFincalc; //"Fincalc";
                   //public readonly static string PL_V_PTC_Planification_HlpDebutcalc = DB_ConstPT.DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PTC_Planification_HlpDureecalc = DB_ConstPT.DB0_Planification_HlpDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PTC_Planification_HlpRealise = DB_ConstPT.DB0_Planification_HlpRealise; //"Realise";
                   public readonly static string PL_V_PTC_Planification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PTC_Planification_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_planning";
                   public readonly static string PL_V_PTC_Planification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_espaceclient";

                   #endregion

                   #region PTC_Planning_

                   public readonly static string PL_V_PTC_Planning_HelpPage = RDBPL.DBPL_V_DB0_Planning_HelpPage; //"Fin";

                   public readonly static string PL_V_PTC_Planning_HlpId = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Planning_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planning_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Planning_HlpLibelle = RDBPL.DBPL_V_DB0_Planning_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Planning_HlpAbreviation = RDBPL.DBPL_V_DB0_Planning_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Planning_HlpDebut = RDBPL.DBPL_V_DB0_Planning_HlpDebut; //"Debut";
                   public readonly static string PL_V_PTC_Planning_HlpFin = RDBPL.DBPL_V_DB0_Planning_HlpFin; //"Fin";
                   public readonly static string PL_V_PTC_Planning_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planning_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Projet_

                   public readonly static string PL_V_PTC_Projet_HelpPage = RDBPL.DBPL_V_DB0_Projet_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Projet_HlpId = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Projet_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Projet_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Projet_HlpLibelle = RDBPL.DBPL_V_DB0_Projet_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Projet_HlpAbreviation = RDBPL.DBPL_V_DB0_Projet_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Projet_HlpId_planning = RDBPL.DBPL_V_DB0_Projet_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Projet_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Projet_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Realisation_

                   public readonly static string PL_V_PTC_Realisation_HelpPage = RDBPL.DBPL_V_DB0_Realisation_HelpPage; //"Id_contrainte";

                   public readonly static string PL_V_PTC_Realisation_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Realisation_HlpDebut = RDBPL.DBPL_V_DB0_Realisation_HlpDebut; //"Debut";
                   //public readonly static string PL_V_PTC_Realisation_HlpFin = RDBPL.DBPL_V_DB0_Realisation_HlpFin; //"Fin";
                   //public readonly static string PL_V_PTC_Realisation_HlpLibelle = DB_ConstPT._HlpLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_Realisation_HlpCommentaire = DB_ConstPT._HlpCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_action = RDBPL.DBPL_V_DB0_Realisation_HlpId_action; //"Id_action";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_application = RDBPL.DBPL_V_DB0_Realisation_HlpId_application; //"Id_application";
                   public readonly static string PL_V_PTC_Realisation_HlpId_employe = RDBPL.DBPL_V_DB0_Realisation_HlpId_employe; //"Id_employe";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_modetravail = RDBPL.DBPL_V_DB0_Realisation_HlpId_modetravail; //"Id_modetravail";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_planning = DB_ConstPT._HlpId_planning; //"Id_planning";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_projet = RDBPL.DBPL_V_DB0_Realisation_HlpId_projet; //"Id_projet";
                   //public readonly static string PL_V_PTC_Realisation_HlpId_societe = RDBPL.DBPL_V_DB0_Realisation_HlpId_societe; //"Id_societe";
                   public readonly static string PL_V_PTC_Realisation_HlpDuree = RDBPL.DBPL_V_DB0_Realisation_HlpDuree; //"Duree";
                   public readonly static string PL_V_PTC_Realisation_HlpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PTC_Realisation_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Societe_

                   public readonly static string PL_V_PTC_Societe_HelpPage = RDBPL.DBPL_V_DB0_Societe_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Societe_HlpId = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Societe_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Societe_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Societe_HlpLibelle = RDBPL.DBPL_V_DB0_Societe_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Societe_HlpAbreviation = RDBPL.DBPL_V_DB0_Societe_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Societe_HlpId_planning = RDBPL.DBPL_V_DB0_Societe_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Societe_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Societe_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Statut_

                   public readonly static string PL_V_PTC_Statut_HelpPage = RDBPL.DBPL_V_DB0_Statut_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Statut_HlpId = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Statut_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Statut_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Statut_HlpLibelle = RDBPL.DBPL_V_DB0_Statut_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Statut_HlpAbreviation = RDBPL.DBPL_V_DB0_Statut_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Statut_HlpId_planning = RDBPL.DBPL_V_DB0_Statut_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Statut_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Statut_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_TacheRecapVersion_

                   //public readonly static string PL_V_PTC_TacheRecapVersion_HelpPage = "Tâches récapitulatives";

                   //public readonly static string PL_V_PTC_TacheRecapVersion_HlpLibelle = DB_ConstPT.DB0_Contrainte_HlpLibelle; //"Libelle";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_HlpId_projet = DB_ConstPT.DB0_Contrainte_HlpId_projet; //"Id_projet";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_HlpOrdre = DB_ConstPT.DB0_Contrainte_HlpOrdre; //"Ordre";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_HlpRef = DB_ConstPT.DB0_Contrainte_HlpRef; //"Ref";
                   //public readonly static string PL_V_PTC_TacheRecapVersion_HlpId_employe = DB_ConstPT.DB0_Contrainte_HlpId_employe; //"Id_employe";

                   #endregion

                   #region PTC_TypeTache_

                   public readonly static string PL_V_PTC_TypeTache_HelpPage = RDBPL.DBPL_V_DB0_TypeTache_HelpPage; //"Abreviation";

                   public readonly static string PL_V_PTC_TypeTache_HlpId = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Id";
                   public readonly static string PL_V_PTC_TypeTache_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_TypeTache_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_TypeTache_HlpLibelle = RDBPL.DBPL_V_DB0_TypeTache_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_TypeTache_HlpAbreviation = RDBPL.DBPL_V_DB0_TypeTache_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_TypeTache_HlpId_espaceclient = RDBPL.DBPL_V_DB0_TypeTache_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_UniteHoraire_

                   public readonly static string PL_V_PTC_UniteHoraire_HelpPage = RDBPL.DBPL_V_DB0_UniteHoraire_HelpPage; //"Abreviation";

                   public readonly static string PL_V_PTC_UniteHoraire_HlpId = RDBPL.DBPL_V_DB0_UniteHoraire_HlpId; //"Id";
                   public readonly static string PL_V_PTC_UniteHoraire_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_UniteHoraire_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_UniteHoraire_HlpLibelle = RDBPL.DBPL_V_DB0_UniteHoraire_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_UniteHoraire_HlpAbreviation = RDBPL.DBPL_V_DB0_UniteHoraire_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_UniteHoraire_HlpId_espaceclient = RDBPL.DBPL_V_DB0_UniteHoraire_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Utilisateur_

                   public readonly static string PL_V_PTC_Utilisateur_HelpPage = RDBPL.DBPL_V_DB0_Utilisateur_HelpPage; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_HlpId = RDBPL.DBPL_V_DB0_Utilisateur_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Utilisateur_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Utilisateur_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Utilisateur_HlpPt_visu = RDBPL.DBPL_V_DB0_Utilisateur_HlpPt_visu; //"Pt_visu";
                   public readonly static string PL_V_PTC_Utilisateur_HlpPt_modif = RDBPL.DBPL_V_DB0_Utilisateur_HlpPt_modif; //"Pt_modif";
                   public readonly static string PL_V_PTC_Utilisateur_HlpIdentite = RDBPL.DBPL_V_DB0_Utilisateur_HlpIdentite; //"Identite";
                   public readonly static string PL_V_PTC_Utilisateur_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Utilisateur_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PTC_Version_

                   public readonly static string PL_V_PTC_Version_HelpPage = RDBPL.DBPL_V_DB0_Version_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PTC_Version_HlpId = RDBPL.DBPL_V_DB0_Version_HlpId; //"Id";
                   public readonly static string PL_V_PTC_Version_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Version_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PTC_Version_HlpLibelle = RDBPL.DBPL_V_DB0_Version_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PTC_Version_HlpId_planning = RDBPL.DBPL_V_DB0_Version_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PTC_Version_HlpAbreviation = RDBPL.DBPL_V_DB0_Version_HlpAbreviation; //"Abreviation";
                   public readonly static string PL_V_PTC_Version_HlpFigee = RDBPL.DBPL_V_DB0_Version_HlpFigee; //"Figee";
                   public readonly static string PL_V_PTC_Version_HlpDebut = RDBPL.DBPL_V_DB0_Planning_HlpDebut; //"Debut";
                   public readonly static string PL_V_PTC_Version_HlpFin = RDBPL.DBPL_V_DB0_Planning_HlpFin; //"Fin";
                   public readonly static string PL_V_PTC_Version_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Version_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_Ephemeride

                   public readonly static string PL_V_PL0_Ephemeride_HelpPage = RDBPL.DBPL_V_DB0_Ephemeride_HelpPage; //"Lib_projet";

                   public readonly static string PL_V_PL0_Ephemeride_HlpId = RDBPL.DBPL_V_DB0_Ephemeride_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Ephemeride_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_planning = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_version = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_employe = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDebut = RDBPL.DBPL_V_DB0_Ephemeride_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDuree = RDBPL.DBPL_V_DB0_Ephemeride_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_type = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_type; //"Id_type";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_contrainte = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Ephemeride_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Abr_version";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Lib_version";
                   public readonly static string PL_V_PL0_Ephemeride_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Init_employe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_type = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Abr_type";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_type = RDBPL.DBPL_V_DB0_TypeTache_HlpId; //"Lib_type";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLibelle = RDBPL.DBPL_V_DB0_Ephemeride_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDebutcontrainte = RDBPL.DBPL_V_DB0_Ephemeride_HlpDebutcontrainte; //"Debutcontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDureecontrainte = RDBPL.DBPL_V_DB0_Ephemeride_HlpDureecontrainte; //"Dureecontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_HlpFincontrainte = RDBPL.DBPL_V_DB0_Ephemeride_HlpFincontrainte; //"Fincontrainte";
                   public readonly static string PL_V_PL0_Ephemeride_HlpInfo = RDBPL.DBPL_V_DB0_Ephemeride_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_Ephemeride_HlpRef = RDBPL.DBPL_V_DB0_Ephemeride_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Ephemeride_HlpCommentaire = RDBPL.DBPL_V_DB0_Ephemeride_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDebutcalc = RDBPL.DBPL_V_DB0_Ephemeride_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Ephemeride_HlpFincalc = RDBPL.DBPL_V_DB0_Ephemeride_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDebutreal = RDBPL.DBPL_V_DB0_Ephemeride_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Ephemeride_HlpFinreal = RDBPL.DBPL_V_DB0_Ephemeride_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDureecalc = RDBPL.DBPL_V_DB0_Ephemeride_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Ephemeride_HlpDureereal = RDBPL.DBPL_V_DB0_Ephemeride_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_statut = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Id_statut";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Id_societe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Id_application";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_action = RDBPL.DBPL_V_DB0_Action_HlpId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_HlpId_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_statut = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Abr_statut";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_statut = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Lib_statut";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Abr_societe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Lib_societe";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Abr_application";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Lib_application";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_action = RDBPL.DBPL_V_DB0_Action_HlpId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_action = RDBPL.DBPL_V_DB0_Action_HlpId; //"Id_action";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_Ephemeride_HlpAbr_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id_projet";
                   public readonly static string PL_V_PL0_Ephemeride_HlpLib_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id_projet";

                   #endregion

                   #region PL0_EquipeEmploye

                   public readonly static string PL_V_PL0_EquipeEmploye_HelpPage = RDBPL.DBPL_V_DB0_EquipeEmploye_HelpPage; //"Lib_version";

                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpId; //"Id";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId_version = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId_equipe = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpId_equipe; //"Id_equipe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId_employe = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId_espaceclient = RDBPL.DBPL_V_DB0_EquipeEmploye_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_planning";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Init_employe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpAbr_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Abr_equipe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpLib_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Lib_equipe";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpAbr_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Abr_version";
                   public readonly static string PL_V_PL0_EquipeEmploye_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Lib_version";

                   #endregion

                   #region PL0_Ferie_

                   public readonly static string PL_V_PL0_Ferie_HelpPage = RDBPL.DBPL_V_DB0_Ferie_HelpPage; //"Dureereal";

                   public readonly static string PL_V_PL0_Ferie_HlpId = RDBPL.DBPL_V_DB0_Ferie_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Ferie_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Ferie_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Ferie_HlpDebut = RDBPL.DBPL_V_DB0_Ferie_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Ferie_HlpDuree = RDBPL.DBPL_V_DB0_Ferie_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Ferie_HlpId_contrainte = RDBPL.DBPL_V_DB0_Ferie_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Ferie_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Ferie_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Ferie_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Ferie_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Ferie_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   //public readonly static string PL_V_PL0_Ferie_HlpDebutcalc = DB_ConstPT.DB0_Ferie_HlpDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Ferie_HlpFincalc = DB_ConstPT.DB0_Ferie_HlpFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Ferie_HlpDebutreal = DB_ConstPT.DB0_Ferie_HlpDebutreal; //"Debutreal";
                   //public readonly static string PL_V_PL0_Ferie_HlpFinreal = DB_ConstPT.DB0_Ferie_HlpFinreal; //"Finreal";
                   //public readonly static string PL_V_PL0_Ferie_HlpDureecalc = DB_ConstPT.DB0_Ferie_HlpDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Ferie_HlpDureereal = DB_ConstPT.DB0_Ferie_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Ferie_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Contrainte_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_CongeEmploye

                   public readonly static string PL_V_PL0_CongeEmploye_HelpPage = RDBPL.DBPL_V_DB0_CongeEmploye_HelpPage; //"Init_employe";

                   public readonly static string PL_V_PL0_CongeEmploye_HlpId = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId; //"Id";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_CongeEmploye_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpId_contrainte = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpId_espaceclient = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";
                   public readonly static string PL_V_PL0_CongeEmploye_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Init_employe";

                   #endregion

                   #region PL0_CongeVersion_

                   public readonly static string PL_V_PL0_CongeVersion_HelpPage = RDBPL.DBPL_V_DB0_CongeVersion_HelpPage; //"Abr_version";

                   public readonly static string PL_V_PL0_CongeVersion_HlpId = RDBPL.DBPL_V_DB0_CongeVersion_HlpId; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_CongeVersion_HlpLogicaldeleted; //"Logicaldeleted_conge";
                   public readonly static string PL_V_PL0_CongeVersion_HlpId_congeemploye = RDBPL.DBPL_V_DB0_CongeVersion_HlpId_congeemploye; //"Id_conge";
                   public readonly static string PL_V_PL0_CongeVersion_HlpId_version = RDBPL.DBPL_V_DB0_CongeVersion_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongeVersion_HlpDebut = RDBPL.DBPL_V_DB0_CongeVersion_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongeVersion_HlpFin = RDBPL.DBPL_V_DB0_CongeVersion_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_CongeVersion_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   //public readonly static string PL_V_PL0_CongeVersion_HlpDebutcalc = DB_ConstPT.DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_CongeVersion_HlpFincalc = DB_ConstPT.DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CongeVersion_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongeVersion_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   //public readonly static string PL_V_PL0_CongeVersion_HlpDureecalc = DB_ConstPT.DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CongeVersion_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongeVersion_HlpId_espaceclient = RDBPL.DBPL_V_DB0_CongeVersion_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongeVersion_HlpId_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Id_employe";
                   public readonly static string PL_V_PL0_CongeVersion_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Lib_version";
                   public readonly static string PL_V_PL0_CongeVersion_HlpAbr_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Abr_version";

                   #endregion

                   #region PL0_RecapVersion

                   public readonly static string PL_V_PL0_RecapVersion_HelpPage = RDBPL.DBPL_V_DB0_RecapVersion_HelpPage; //"Lib_projet";

                   public readonly static string PL_V_PL0_RecapVersion_HlpId = RDBPL.DBPL_V_DB0_RecapVersion_HlpId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_RecapVersion_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RecapVersion_HlpId_contrainterecap = RDBPL.DBPL_V_DB0_RecapVersion_HlpId_contrainterecap; //"Id_contrainterecap";
                   public readonly static string PL_V_PL0_RecapVersion_HlpId_version = RDBPL.DBPL_V_DB0_RecapVersion_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RecapVersion_HlpId_contrainte = RDBPL.DBPL_V_DB0_RecapVersion_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RecapVersion_HlpId_espaceclient = RDBPL.DBPL_V_DB0_RecapVersion_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_RecapVersion_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_RecapVersion_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_RecapVersion_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RecapVersion_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RecapVersion_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RecapVersion_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RecapVersion_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RecapVersion_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RecapVersion_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_RecapVersion_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_statut = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Abr_statut";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_statut = RDBPL.DBPL_V_DB0_Statut_HlpId; //"Lib_statut";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Abr_societe";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Lib_societe";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Abr_application";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Lib_application";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_action = RDBPL.DBPL_V_DB0_Action_HlpId; //"Abr_action";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_action = RDBPL.DBPL_V_DB0_Action_HlpId; //"Lib_action";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Abr_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Lib_modetravail";
                   public readonly static string PL_V_PL0_RecapVersion_HlpAbr_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";
                   public readonly static string PL_V_PL0_RecapVersion_HlpLib_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";

                   #endregion

                   #region DB0_Planification_

                   public readonly static string PL_V_PL0_ReunionEmploye_HelpPage = RDBPL.DBPL_V_DB0_ReunionEmploye_HelpPage; //"Ident_employe";

                   public readonly static string PL_V_PL0_ReunionEmploye_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpId_reunionversion = RDBPL.DBPL_V_DB0_ReunionEmploye_HlpId_reunionversion; //"Id_reunion";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpId_espaceclient = RDBPL.DBPL_V_DB0_ReunionEmploye_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpInit_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Init_employe";
                   public readonly static string PL_V_PL0_ReunionEmploye_HlpIdent_employe = RDBPL.DBPL_V_DB0_Employe_HlpId; //"Ident_employe";

                   #endregion

                   #region DB0_Admin_

                   public readonly static string PL_V_PL0_Admin_HelpPage = RDBPL.DBPL_V_DB0_Admin_HelpPage; //"Dureereal";

                   public readonly static string PL_V_PL0_Admin_HlpId = RDBPL.DBPL_V_DB0_Admin_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Admin_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Admin_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Admin_HlpId_version = RDBPL.DBPL_V_DB0_Admin_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_Admin_HlpId_employe = RDBPL.DBPL_V_DB0_Admin_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Admin_HlpDebut = RDBPL.DBPL_V_DB0_Admin_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Admin_HlpDuree = RDBPL.DBPL_V_DB0_Admin_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Admin_HlpPeriode = RDBPL.DBPL_V_DB0_Admin_HlpPeriode; //"Periode";
                   public readonly static string PL_V_PL0_Admin_HlpFin = RDBPL.DBPL_V_DB0_Admin_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_Admin_HlpDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_HlpDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_Admin_HlpId_contrainte = RDBPL.DBPL_V_DB0_Admin_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Admin_HlpDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_HlpDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_Admin_HlpSecable = RDBPL.DBPL_V_DB0_Admin_HlpSecable; //"Secable";
                   public readonly static string PL_V_PL0_Admin_HlpDureemini = RDBPL.DBPL_V_DB0_Admin_HlpDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_Admin_HlpDureeinitiale = RDBPL.DBPL_V_DB0_Admin_HlpDureeinitiale; //"Dureeinitiale";
                   public readonly static string PL_V_PL0_Admin_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Admin_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Admin_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Admin_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Admin_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_Admin_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_Admin_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_Admin_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_Admin_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_Admin_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_Admin_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_Admin_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";

                   #endregion

                   #region PL0_ReunionVersion

                   public readonly static string PL_V_PL0_ReunionVersion_HelpPage = RDBPL.DBPL_V_DB0_ReunionVersion_HelpPage; //"Abr_version";

                   public readonly static string PL_V_PL0_ReunionVersion_HlpId = RDBPL.DBPL_V_DB0_ReunionVersion_HlpId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_ReunionVersion_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpId_contrainte = RDBPL.DBPL_V_DB0_ReunionVersion_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpId_version = RDBPL.DBPL_V_DB0_ReunionVersion_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpLib_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Id";
                   public readonly static string PL_V_PL0_ReunionVersion_HlpAbr_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Id";

                   #endregion

                   #region PL0_Reunion

                   //public readonly static string PL_V_PL0_Reunion_HelpPage = RDBPL.DBPL_V_DB0_Reunion_HelpPage; //"Lib_projet";

                   //public readonly static string PL_V_PL0_Reunion_HlpId = RDBPL.DBPL_V_DB0_Reunion_HlpId; //"Id";
                   //public readonly static string PL_V_PL0_Reunion_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Reunion_HlpLogicaldeleted; //"Logicaldeleted";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_societe = RDBPL.DBPL_V_DB0_Reunion_HlpId_societe; //"Id_societe";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_application = RDBPL.DBPL_V_DB0_Reunion_HlpId_application; //"Id_application";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_projet = RDBPL.DBPL_V_DB0_Reunion_HlpId_projet; //"Id_projet";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_action = RDBPL.DBPL_V_DB0_Reunion_HlpId_action; //"Id_action";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_modetravail = RDBPL.DBPL_V_DB0_Reunion_HlpId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Reunion_HlpId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpId; //"Id_contrainte";
                   //public readonly static string PL_V_PL0_Reunion_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Reunion_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Reunion_HlpLibelle = RDBPL.DBPL_V_DB0_Contrainte_HlpLibelle; //"Libelle";
                   public readonly static string PL_V_PL0_Reunion_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_Reunion_HlpCommentaire = RDBPL.DBPL_V_DB0_Contrainte_HlpCommentaire; //"Commentaire";
                   public readonly static string PL_V_PL0_Reunion_HlpRef = RDBPL.DBPL_V_DB0_Contrainte_HlpRef; //"Ref";
                   public readonly static string PL_V_PL0_Reunion_HlpAbr_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpLib_societe = RDBPL.DBPL_V_DB0_Societe_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpAbr_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpLib_application = RDBPL.DBPL_V_DB0_Application_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpAbr_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpLib_modetravail = RDBPL.DBPL_V_DB0_ModeTravail_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpAbr_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Reunion_HlpLib_projet = RDBPL.DBPL_V_DB0_Projet_HlpId; //"Id";

                   #endregion

                   #region PL0_AdminPlanification  

                   public readonly static string PL_V_PL0_AdminPlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Dureemini";

                   public readonly static string PL_V_PL0_AdminPlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                                                                                                                                     //public readonly static string PL_V_PL0_AdminPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDebut = RDBPL.DBPL_V_DB0_Admin_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDuree = RDBPL.DBPL_V_DB0_Admin_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDecalesioccupe = RDBPL.DBPL_V_DB0_Admin_HlpDecalesioccupe; //"Decalesioccupe";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpFin = RDBPL.DBPL_V_DB0_Admin_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_employe = RDBPL.DBPL_V_DB0_Admin_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_version = RDBPL.DBPL_V_DB0_Admin_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpPeriode = RDBPL.DBPL_V_DB0_Admin_HlpPeriode; //"Periode";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpSecable = RDBPL.DBPL_V_DB0_Admin_HlpSecable; //"Secable";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDureemini = RDBPL.DBPL_V_DB0_Admin_HlpDureemini; //"Dureemini";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDecalagemaxi = RDBPL.DBPL_V_DB0_Admin_HlpDecalagemaxi; //"Decalagemaxi";
                   public readonly static string PL_V_PL0_AdminPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Admin_HlpDureereal; //"Decalagemaxi";

                   #endregion

                   #region PL0_FeriePlanification

                   public readonly static string PL_V_PL0_FeriePlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Duree";

                   public readonly static string PL_V_PL0_FeriePlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDebut = RDBPL.DBPL_V_DB0_Ferie_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpDuree = RDBPL.DBPL_V_DB0_Ferie_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_FeriePlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";

                   #endregion

                   #region PL0_ReunionPlanification

                   public readonly static string PL_V_PL0_ReunionPlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_employe";

                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDebut = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpDuree = RDBPL.DBPL_V_DB0_ReunionVersion_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_version = RDBPL.DBPL_V_DB0_ReunionVersion_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_employe = RDBPL.DBPL_V_DB0_ReunionEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_ReunionPlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";

                   #endregion

                   #region PL0_CongePlanification

                   public readonly static string PL_V_PL0_CongePlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_employe";

                   public readonly static string PL_V_PL0_CongePlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_CongePlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   //public readonly static string PL_V_PL0_CongePlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CongePlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_CongePlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CongePlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CongePlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CongePlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CongePlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CongePlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CongePlanification_HlpDebut = RDBPL.DBPL_V_DB0_CongeVersion_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_CongePlanification_HlpFin = RDBPL.DBPL_V_DB0_CongeVersion_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_version = RDBPL.DBPL_V_DB0_CongeVersion_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CongePlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CongePlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";

                   #endregion

                   #region PL0_CalendrierPlanification

                   public readonly static string PL_V_PL0_CalendrierPlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_employe";

                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDebut = RDBPL.DBPL_V_DB0_Calendrier_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpDuree = RDBPL.DBPL_V_DB0_Calendrier_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpFin = RDBPL.DBPL_V_DB0_Calendrier_HlpFin; //"Fin";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpPeriode = RDBPL.DBPL_V_DB0_Calendrier_HlpPeriode; //"Periode";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_version = RDBPL.DBPL_V_DB0_Version_HlpId; //"Id_version";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Contrainte_HlpId; //"Id_contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_employe = RDBPL.DBPL_V_DB0_CongeEmploye_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_CalendrierPlanification_HlpId_equipe = RDBPL.DBPL_V_DB0_Equipe_HlpId; //"Id_equipe";

                   #endregion

                   #region  PL0_RealisationPlanification

                   public readonly static string PL_V_PL0_RealisationPlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDebut = RDBPL.DBPL_V_DB0_Realisation_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpDuree = RDBPL.DBPL_V_DB0_Realisation_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_RealisationPlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Contrainte_HlpId_planning; //"Id_planning";

                   #endregion

                   #region PL0_TachePlanification

                   public readonly static string PL_V_PL0_TachePlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_planning";

                   public readonly static string PL_V_PL0_TachePlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public readonly static string PL_V_PL0_TachePlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_TachePlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public readonly static string PL_V_PL0_TachePlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public readonly static string PL_V_PL0_TachePlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_TachePlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDebut = RDBPL.DBPL_V_DB0_Planification_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDuree = RDBPL.DBPL_V_DB0_Planification_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_TachePlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Planification_HlpId_planning; //"Id_planning";
                   public readonly static string PL_V_PL0_TachePlanification_HlpOrdre = RDBPL.DBPL_V_DB0_TacheVersion_HlpOrdre; //"Ordre";
                   public readonly static string PL_V_PL0_TachePlanification_HlpSecable = RDBPL.DBPL_V_DB0_TacheVersion_HlpSecable; //"Secable";
                   public readonly static string PL_V_PL0_TachePlanification_HlpSecablesurconge = RDBPL.DBPL_V_DB0_TacheVersion_HlpSecablesurconge; //"Secablesurconge";
                   public readonly static string PL_V_PL0_TachePlanification_HlpDureemini = RDBPL.DBPL_V_DB0_TacheVersion_HlpDureemini; //"Dureemini";

                   #endregion

                   #region _

                   public readonly static string PL_V_PL0_Realisation_HelpPage = RDBPL.DBPL_V_DB0_Realisation_HelpPage; //"Lib_projet";

                   public readonly static string PL_V_PL0_Realisation_HlpId = RDBPL.DBPL_V_DB0_Realisation_HlpId; //"Id";
                   public readonly static string PL_V_PL0_Realisation_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Realisation_HlpLogicaldeleted; //"Logicaldeleted";
                   public readonly static string PL_V_PL0_Realisation_HlpDebut = RDBPL.DBPL_V_DB0_Realisation_HlpDebut; //"Debut";
                   public readonly static string PL_V_PL0_Realisation_HlpDuree = RDBPL.DBPL_V_DB0_Realisation_HlpDuree; //"Duree";
                   public readonly static string PL_V_PL0_Realisation_HlpId_contrainte = RDBPL.DBPL_V_DB0_Realisation_HlpId_contrainte; //"Id_contrainte";
                   public readonly static string PL_V_PL0_Realisation_HlpId_contrainterealisee = RDBPL.DBPL_V_DB0_Realisation_HlpId_contrainterealisee; //"Id_contrainterealisee";
                   public readonly static string PL_V_PL0_Realisation_HlpId_societe = RDBPL.DBPL_V_DB0_Realisation_HlpId_societe; //"Id_societe";
                   public readonly static string PL_V_PL0_Realisation_HlpId_application = RDBPL.DBPL_V_DB0_Realisation_HlpId_application; //"Id_application";
                   public readonly static string PL_V_PL0_Realisation_HlpId_modetravail = RDBPL.DBPL_V_DB0_Realisation_HlpId_modetravail; //"Id_modetravail";
                   public readonly static string PL_V_PL0_Realisation_HlpId_action = RDBPL.DBPL_V_DB0_Realisation_HlpId_action; //"Id_action";
                   public readonly static string PL_V_PL0_Realisation_HlpId_employe = RDBPL.DBPL_V_DB0_Realisation_HlpId_employe; //"Id_employe";
                   public readonly static string PL_V_PL0_Realisation_HlpId_projet = RDBPL.DBPL_V_DB0_Realisation_HlpId_projet; //"Id_projet";
                   public readonly static string PL_V_PL0_Realisation_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Realisation_HlpId_espaceclient; //"Id_espaceclient";
                   public readonly static string PL_V_PL0_Realisation_HlpId_planning = RDBPL.DBPL_V_DB0_Planning_HlpId; //"Id_planning";
                   //public readonly static string PL_V_PL0_Realisation_HlpInfo = DB_ConstPT._HlpInfo; //"Info";
                   //public readonly static string PL_V_PL0_Realisation_HlpLibelle = DB_ConstPT._HlpLibelle; //"Libelle";
                   //public readonly static string PL_V_PL0_Realisation_HlpCommentaire = DB_ConstPT._HlpCommentaire; //"Commentaire";
                   //public readonly static string PL_V_PL0_Realisation_HlpRef = DB_ConstPT._HlpRef; //"Ref";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_contrainte = DB_ConstPT._HlpLib_contrainte; //"Lib_contrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_type = DB_ConstPT._HlpId_type; //"Id_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpDebutcontrainte = DB_ConstPT._HlpDebutcontrainte; //"Debutcontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureecontrainte = DB_ConstPT._HlpDureecontrainte; //"Dureecontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_recap = DB_ConstPT._HlpId_recap; //"Id_recap";
                   //public readonly static string PL_V_PL0_Realisation_HlpOrdre = DB_ConstPT._HlpOrdre; //"Ordre";
                   //public readonly static string PL_V_PL0_Realisation_HlpInfocontrainte = DB_ConstPT._HlpInfocontrainte; //"Infocontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpFincontrainte = DB_ConstPT._HlpFincontrainte; //"Fincontrainte";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_uniteduree = DB_ConstPT._HlpId_uniteduree; //"Id_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_HlpRecurrente = DB_ConstPT._HlpRecurrente; //"Recurrente";
                   //public readonly static string PL_V_PL0_Realisation_HlpPeriode = DB_ConstPT._HlpPeriode; //"Periode";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_uniteperiode = DB_ConstPT._HlpId_uniteperiode; //"Id_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpDecalesioccupe = DB_ConstPT._HlpDecalesioccupe; //"Decalesioccupe";
                   //public readonly static string PL_V_PL0_Realisation_HlpSecable = DB_ConstPT._HlpSecable; //"Secable";
                   //public readonly static string PL_V_PL0_Realisation_HlpMinparjour = DB_ConstPT._HlpMinparjour; //"Minparjour";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureeinitiale = DB_ConstPT._HlpDureeinitiale; //"Dureeinitiale";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_type = DB_ConstPT.DB0_TypeTache_HlpAbr_type; //"Abr_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_type = DB_ConstPT.DB0_TypeTache_HlpLib_type; //"Lib_type";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_recap = DB_ConstPT._HlpLib_recap; //"Lib_recap";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_uniteduree = DB_ConstPT.DB0_UniteHorairefHlpAbr_uniteduree; //"Abr_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_uniteduree = DB_ConstPT.DB0_UniteHorairefHlpLib_uniteduree; //"Lib_uniteduree";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_uniteperiode = DB_ConstPT.DB0_UniteHorairefHlpAbr_uniteperiode; //"Abr_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_uniteperiode = DB_ConstPT.DB0_UniteHorairefHlpLib_uniteperiode; //"Lib_uniteperiode";
                   //public readonly static string PL_V_PL0_Realisation_HlpDebutcalc = DB_ConstPT.fHlpDebutcalc; //"Debutcalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpFincalc = DB_ConstPT.fHlpFincalc; //"Fincalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpDureecalc = DB_ConstPT.fHlpDureecalc; //"Dureecalc";
                   //public readonly static string PL_V_PL0_Realisation_HlpId_version = DB_ConstPT.DB0_Version_HlpId_version; //"Id_version";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_societe = DB_ConstPT.DB0_Societe_HlpLib_societe; //"Lib_societe";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_application = DB_ConstPT.DB0_Application_HlpAbr_application; //"Abr_application";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_application = DB_ConstPT.DB0_Application_HlpLib_application; //"Lib_application";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_modetravail = DB_ConstPT.DB0_ModeTravail_HlpAbr_modetravail; //"Abr_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_modetravail = DB_ConstPT.DB0_ModeTravail_HlpLib_modetravail; //"Lib_modetravail";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_action = DB_ConstPT.DB0_Action_HlpAbr_action; //"Abr_action";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_action = DB_ConstPT.DB0_Action_HlpLib_action; //"Lib_action";
                   //public readonly static string PL_V_PL0_Realisation_HlpInit_employe = DB_ConstPT.DB0_Employe_HlpInit_employe; //"Init_employe";
                   //public readonly static string PL_V_PL0_Realisation_HlpIdent_employe = DB_ConstPT.DB0_Employe_HlpIdent_employe; //"Ident_employe";
                   //public readonly static string PL_V_PL0_Realisation_HlpAbr_projet = DB_ConstPT.DB0_Projet_HlpId; //"Id";
                   //public readonly static string PL_V_PL0_Realisation_HlpLib_projet = DB_ConstPT.DB0_Projet_HlpId; //"Id";

                   #endregion

                   #region PL0_RecapPlanification_

                   public static readonly string PL_V_PL0_RecapPlanification_HelpPage = RDBPL.DBPL_V_DB0_Planification_HelpPage; //"Id_planning";

                   public static readonly string PL_V_PL0_RecapPlanification_HlpId = RDBPL.DBPL_V_DB0_Planification_HlpId; //"Id";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpLogicaldeleted = RDBPL.DBPL_V_DB0_Planification_HlpLogicaldeleted; //"Logicaldeleted";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpInfo = RDBPL.DBPL_V_DB0_Planification_HlpInfo; //"Info";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpDebutcalc = RDBPL.DBPL_V_DB0_Planification_HlpDebutcalc; //"Debutcalc";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpFincalc = RDBPL.DBPL_V_DB0_Planification_HlpFincalc; //"Fincalc";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpDureecalc = RDBPL.DBPL_V_DB0_Planification_HlpDureecalc; //"Dureecalc";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpDebutreal = RDBPL.DBPL_V_DB0_Planification_HlpDebutreal; //"Debutreal";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpFinreal = RDBPL.DBPL_V_DB0_Planification_HlpFinreal; //"Finreal";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpDureereal = RDBPL.DBPL_V_DB0_Planification_HlpDureereal; //"Dureereal";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_contrainte = RDBPL.DBPL_V_DB0_Planification_HlpId_contrainte; //"Id_contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_version = RDBPL.DBPL_V_DB0_Planification_HlpId_version; //"Id_version";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_employe = RDBPL.DBPL_V_DB0_Planification_HlpId_employe; //"Id_employe";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpContrainte = RDBPL.DBPL_V_DB0_Planification_HlpContrainte; //"Contrainte";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_espaceclient = RDBPL.DBPL_V_DB0_Planification_HlpId_espaceclient; //"Id_espaceclient";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_typetache = RDBPL.DBPL_V_DB0_Planification_HlpId_typetache; //"Id_typetache";
                   public static readonly string PL_V_PL0_RecapPlanification_HlpId_planning = RDBPL.DBPL_V_DB0_Planification_HlpId_planning; //"Id_planning";

                   #endregion

                   #endregion
           */
    }
}
