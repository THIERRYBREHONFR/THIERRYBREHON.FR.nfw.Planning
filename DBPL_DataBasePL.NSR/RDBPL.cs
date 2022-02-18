using System;
using System.Collections.Generic;
using System.Text;

namespace DataBasePL.NSR
{
    public partial class RDBPL
    {
        #region communs

        const string C_Logicaldeleted = "Supprimé";
        const string C_Id_espaceclient = "Espace client";

        public readonly static string Logicaldeleted = C_Logicaldeleted;
        public readonly static string LblLogicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string LgdLogicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string TtpLogicaldeleted = Logicaldeleted; //"Logicaldeleted";

        public static readonly string Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

        #endregion

        #region utilisateur

        public readonly static string DBPL_V_DB0_Utilisateur_Id = "Utilisateur";
        public readonly static string DBPL_V_DB0_Utilisateur_LblId = DBPL_V_DB0_Utilisateur_Id; //"Id";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdId = DBPL_V_DB0_Utilisateur_Id; //"Id";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpId = DBPL_V_DB0_Utilisateur_Id; //"Id";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpId = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Object = DBPL_V_DB0_Utilisateur_Id;
        public readonly static string DBPL_V_DB0_Utilisateur_ObjectList = "Liste des utilisateurs";
        public readonly static string DBPL_V_DB0_Utilisateur_TitrePage = "Utilisateurs";
        public static readonly string DBPL_V_DB0_Utilisateur_HelpPage = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Utilisateur_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Modif = "Modifier";
        public readonly static string DBPL_V_DB0_Utilisateur_LblModif = DBPL_V_DB0_Utilisateur_Modif; //"Modif";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdModif = DBPL_V_DB0_Utilisateur_Modif; //"Modif";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpModif = DBPL_V_DB0_Utilisateur_Modif; //"Modif";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpModif = "";

        public static readonly string DBPL_V_DB0_Utilisateur_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Utilisateur_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Utilisateur_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Utilisateur_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Utilisateur_HlpId_espaceclient = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Nom = "Nom";
        public readonly static string DBPL_V_DB0_Utilisateur_LblNom = DBPL_V_DB0_Utilisateur_Nom; //"Nom";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdNom = DBPL_V_DB0_Utilisateur_Nom; //"Nom";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpNom = DBPL_V_DB0_Utilisateur_Nom; //"Nom";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpNom = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Prenom = "Prenom";
        public readonly static string DBPL_V_DB0_Utilisateur_LblPrenom = DBPL_V_DB0_Utilisateur_Prenom; //"Prenom";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdPrenom = DBPL_V_DB0_Utilisateur_Prenom; //"Prenom";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpPrenom = DBPL_V_DB0_Utilisateur_Prenom; //"Prenom";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpPrenom = "";

        public readonly static string DBPL_V_DB0_Utilisateur_Feminin = "Ecrire au féminin";
        public readonly static string DBPL_V_DB0_Utilisateur_LblFeminin = DBPL_V_DB0_Utilisateur_Feminin; //"Feminin";
        public readonly static string DBPL_V_DB0_Utilisateur_LgdFeminin = "Féminin";
        public readonly static string DBPL_V_DB0_Utilisateur_TtpFeminin = DBPL_V_DB0_Utilisateur_Feminin; //"Feminin";
        public static readonly string DBPL_V_DB0_Utilisateur_HlpFeminin = "";

        #endregion

        #region planning

        public readonly static string DBPL_V_DB0_Planning_Id = "Planning";
        public readonly static string DBPL_V_DB0_Planning_LblId = DBPL_V_DB0_Planning_Id; //"Id";
        public readonly static string DBPL_V_DB0_Planning_LgdId = DBPL_V_DB0_Planning_Id; //"Id";
        public readonly static string DBPL_V_DB0_Planning_TtpId = DBPL_V_DB0_Planning_Id; //"Id";
        public static readonly string DBPL_V_DB0_Planning_HlpId = "";

        public readonly static string DBPL_V_DB0_Planning_Object = DBPL_V_DB0_Planning_Id; //"Fin";
        public readonly static string DBPL_V_DB0_Planning_ObjectList = "Liste des plannings";
        public readonly static string DBPL_V_DB0_Planning_TitrePage = "Plannings";
        public static readonly string DBPL_V_DB0_Planning_HelpPage = "";

        public readonly static string DBPL_V_DB0_Planning_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Planning_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Planning_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Planning_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Planning_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_Planning_Libelle = "Nom du planning";
        public readonly static string DBPL_V_DB0_Planning_LblLibelle = DBPL_V_DB0_Planning_Libelle; //"Libelle";
        public readonly static string DBPL_V_DB0_Planning_LgdLibelle = "Nom";
        public readonly static string DBPL_V_DB0_Planning_TtpLibelle = DBPL_V_DB0_Planning_Libelle; //"Libelle";
        public static readonly string DBPL_V_DB0_Planning_HlpLibelle = "";

        public readonly static string DBPL_V_DB0_Planning_Abreviation = "Code du planning";
        public readonly static string DBPL_V_DB0_Planning_LblAbreviation = DBPL_V_DB0_Planning_Abreviation; //"Abreviation";
        public readonly static string DBPL_V_DB0_Planning_LgdAbreviation = "Code"; //"Abreviation";
        public readonly static string DBPL_V_DB0_Planning_TtpAbreviation = DBPL_V_DB0_Planning_Abreviation; //"Abreviation";
        public static readonly string DBPL_V_DB0_Planning_HlpAbreviation = "";

        public readonly static string DBPL_V_DB0_Planning_Debut = "Début de planning";
        public readonly static string DBPL_V_DB0_Planning_LblDebut = DBPL_V_DB0_Planning_Debut; //"Debut";
        public readonly static string DBPL_V_DB0_Planning_LgdDebut = "Début";
        public readonly static string DBPL_V_DB0_Planning_TtpDebut = DBPL_V_DB0_Planning_Debut; //"Debut";
        public static readonly string DBPL_V_DB0_Planning_HlpDebut = "";

        public readonly static string DBPL_V_DB0_Planning_Fin = "Fin de planning";
        public readonly static string DBPL_V_DB0_Planning_LblFin = DBPL_V_DB0_Planning_Fin; //"Fin";
        public readonly static string DBPL_V_DB0_Planning_LgdFin = "Fin";
        public readonly static string DBPL_V_DB0_Planning_TtpFin = DBPL_V_DB0_Planning_Fin; //"Fin";
        public static readonly string DBPL_V_DB0_Planning_HlpFin = "";

        public static readonly string DBPL_V_DB0_Planning_Id_espaceclient = Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Planning_LblId_espaceclient = LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Planning_LgdId_espaceclient = LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Planning_TtpId_espaceclient = TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Planning_HlpId_espaceclient = "";

        #endregion

        #region version

        public readonly static string DBPL_V_DB0_Version_Id = "Version";
        public readonly static string DBPL_V_DB0_Version_LblId = DBPL_V_DB0_Version_Id; //"Id";
        public readonly static string DBPL_V_DB0_Version_LgdId = DBPL_V_DB0_Version_Id; //"Id";
        public readonly static string DBPL_V_DB0_Version_TtpId = DBPL_V_DB0_Version_Id; //"Id";
        public static readonly string DBPL_V_DB0_Version_HlpId = "";

        public readonly static string DBPL_V_DB0_Version_Object = DBPL_V_DB0_Version_Id;
        public readonly static string DBPL_V_DB0_Version_ObjectList = "Liste des versions";
        public readonly static string DBPL_V_DB0_Version_TitrePage = "Versions";
        public static readonly string DBPL_V_DB0_Version_HelpPage = "";

        public readonly static string DBPL_V_DB0_Version_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Version_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Version_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Version_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Version_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_Version_Libelle = "Nom de la version";
        public readonly static string DBPL_V_DB0_Version_LblLibelle = DBPL_V_DB0_Version_Libelle; //"Libelle";
        public readonly static string DBPL_V_DB0_Version_LgdLibelle = "Nom";
        public readonly static string DBPL_V_DB0_Version_TtpLibelle = DBPL_V_DB0_Version_Libelle; //"Libelle";
        public static readonly string DBPL_V_DB0_Version_HlpLibelle = "";

        public readonly static string DBPL_V_DB0_Version_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_Version_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Version_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Version_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";
        public static readonly string DBPL_V_DB0_Version_HlpId_planning = "";

        public readonly static string DBPL_V_DB0_Version_Abreviation = "Code de la version";
        public readonly static string DBPL_V_DB0_Version_LblAbreviation = DBPL_V_DB0_Version_Abreviation; //"Abreviation";
        public readonly static string DBPL_V_DB0_Version_LgdAbreviation = "Code";
        public readonly static string DBPL_V_DB0_Version_TtpAbreviation = DBPL_V_DB0_Version_Abreviation; //"Abreviation";
        public static readonly string DBPL_V_DB0_Version_HlpAbreviation = "";

        public readonly static string DBPL_V_DB0_Version_Figee = "Version C_Figée";
        public readonly static string DBPL_V_DB0_Version_LblFigee = DBPL_V_DB0_Version_Figee; //"Figee";
        public readonly static string DBPL_V_DB0_Version_LgdFigee = "Figée";
        public readonly static string DBPL_V_DB0_Version_TtpFigee = DBPL_V_DB0_Version_Figee; //"Figee";
        public static readonly string DBPL_V_DB0_Version_HlpFigee = "";

        public static readonly string DBPL_V_DB0_Version_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Version_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Version_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Version_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Version_HlpId_espaceclient = "";

        #endregion

        #region employé

        public readonly static string DBPL_V_DB0_Employe_Id = "Employé";
        public readonly static string DBPL_V_DB0_Employe_LblId = DBPL_V_DB0_Employe_Id; //"Id";
        public readonly static string DBPL_V_DB0_Employe_LgdId = DBPL_V_DB0_Employe_Id; //"Id";
        public readonly static string DBPL_V_DB0_Employe_TtpId = DBPL_V_DB0_Employe_Id; //"Id";
        public static readonly string DBPL_V_DB0_Employe_HlpId = "";

        public readonly static string DBPL_V_DB0_Employe_Object = DBPL_V_DB0_Employe_Id;
        public readonly static string DBPL_V_DB0_Employe_ObjectList = "Liste des employés";
        public readonly static string DBPL_V_DB0_Employe_TitrePage = "Employés";
        public static readonly string DBPL_V_DB0_Employe_HelpPage = "";

        public readonly static string DBPL_V_DB0_Employe_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Employe_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Employe_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Employe_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Employe_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_Employe_Initiales = "Initiales";
        public readonly static string DBPL_V_DB0_Employe_LblInitiales = DBPL_V_DB0_Employe_Initiales; //"Initiales";
        public readonly static string DBPL_V_DB0_Employe_LgdInitiales = DBPL_V_DB0_Employe_Initiales; //"Initiales";
        public readonly static string DBPL_V_DB0_Employe_TtpInitiales = DBPL_V_DB0_Employe_Initiales; //"Initiales";
        public static readonly string DBPL_V_DB0_Employe_HlpInitiales = "";

        public readonly static string DBPL_V_DB0_Employe_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_Employe_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Employe_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Employe_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";
        public static readonly string DBPL_V_DB0_Employe_HlpId_planning = "";

        public static readonly string DBPL_V_DB0_Employe_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Employe_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Employe_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Employe_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Employe_HlpId_espaceclient = "";

        public readonly static string DBPL_V_DB0_Employe_Nom = "Nom";
        public readonly static string DBPL_V_DB0_Employe_LblNom = DBPL_V_DB0_Employe_Nom; //"Nom";
        public readonly static string DBPL_V_DB0_Employe_LgdNom = DBPL_V_DB0_Employe_Nom; //"Nom";
        public readonly static string DBPL_V_DB0_Employe_TtpNom = DBPL_V_DB0_Employe_Nom; //"Nom";
        public static readonly string DBPL_V_DB0_Employe_HlpNom = "";

        public readonly static string DBPL_V_DB0_Employe_Prenom = "Prénom";
        public readonly static string DBPL_V_DB0_Employe_LblPrenom = DBPL_V_DB0_Employe_Prenom; //"Prenom";
        public readonly static string DBPL_V_DB0_Employe_LgdPrenom = DBPL_V_DB0_Employe_Prenom; //"Prenom";
        public readonly static string DBPL_V_DB0_Employe_TtpPrenom = DBPL_V_DB0_Employe_Prenom; //"Prenom";
        public static readonly string DBPL_V_DB0_Employe_HlpPrenom = "";

        public readonly static string DBPL_V_DB0_Employe_Feminin = "Ecrire au féminin";
        public readonly static string DBPL_V_DB0_Employe_LblFeminin = DBPL_V_DB0_Employe_Feminin; //"Feminin";
        public readonly static string DBPL_V_DB0_Employe_LgdFeminin = DBPL_V_DB0_Employe_Feminin; //"Feminin";
        public readonly static string DBPL_V_DB0_Employe_TtpFeminin = DBPL_V_DB0_Employe_Feminin; //"Feminin";
        public static readonly string DBPL_V_DB0_Employe_HlpFeminin = "";

        public readonly static string DBPL_V_DB0_Employe_Id_utilisateur = DBPL_V_DB0_Utilisateur_Id;
        public readonly static string DBPL_V_DB0_Employe_LblId_utilisateur = DBPL_V_DB0_Utilisateur_LblId; //"Id_utilisateur";
        public readonly static string DBPL_V_DB0_Employe_LgdId_utilisateur = DBPL_V_DB0_Utilisateur_LgdId; //"Id_utilisateur";
        public readonly static string DBPL_V_DB0_Employe_TtpId_utilisateur = DBPL_V_DB0_Utilisateur_TtpId; //"Id_utilisateur";
        public static readonly string DBPL_V_DB0_Employe_HlpId_utilisateur = "";

        #endregion

        #region Equipe

        public readonly static string DBPL_V_DB0_Equipe_Id = "Equipe";
        public readonly static string DBPL_V_DB0_Equipe_LblId = DBPL_V_DB0_Equipe_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_Equipe_LgdId = DBPL_V_DB0_Equipe_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_Equipe_TtpId = DBPL_V_DB0_Equipe_Id; //"Id_planning";

        public readonly static string DBPL_V_DB0_Equipe_Object = DBPL_V_DB0_Equipe_Id;
        public readonly static string DBPL_V_DB0_Equipe_ObjectList = "Liste des équipes";
        public readonly static string DBPL_V_DB0_Equipe_TitrePage = "Equipes";
        public static readonly string DBPL_V_DB0_Equipe_HelpPage = "";
        public static readonly string DBPL_V_DB0_Equipe_HlpId = "";

        public readonly static string DBPL_V_DB0_Equipe_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Equipe_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Equipe_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Equipe_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Equipe_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_Equipe_Libelle = "Nom de l'équipe";
        public readonly static string DBPL_V_DB0_Equipe_LblLibelle = DBPL_V_DB0_Equipe_Libelle; //"Libelle";
        public readonly static string DBPL_V_DB0_Equipe_LgdLibelle = "Nom";
        public readonly static string DBPL_V_DB0_Equipe_TtpLibelle = DBPL_V_DB0_Equipe_Libelle; //"Libelle";
        public static readonly string DBPL_V_DB0_Equipe_HlpLibelle = "";

        public readonly static string DBPL_V_DB0_Equipe_Abreviation = "Code de l'équipe";
        public readonly static string DBPL_V_DB0_Equipe_LblAbreviation = DBPL_V_DB0_Equipe_Abreviation; //"Abreviation";
        public readonly static string DBPL_V_DB0_Equipe_LgdAbreviation = "Code";
        public readonly static string DBPL_V_DB0_Equipe_TtpAbreviation = DBPL_V_DB0_Equipe_Abreviation; //"Abreviation";
        public static readonly string DBPL_V_DB0_Equipe_HlpAbreviation = "";

        public readonly static string DBPL_V_DB0_Equipe_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_Equipe_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Equipe_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
        public readonly static string DBPL_V_DB0_Equipe_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";
        public static readonly string DBPL_V_DB0_Equipe_HlpId_planning = "";

        public static readonly string DBPL_V_DB0_Equipe_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Equipe_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Equipe_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Equipe_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Equipe_HlpId_espaceclient = "";


        #endregion

        #region equipeemployeversion

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Id = "Employé d'équipe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LblId = DBPL_V_DB0_EquipeEmployeVersion_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LgdId = DBPL_V_DB0_EquipeEmployeVersion_Id; //"Id_planning";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TtpId = DBPL_V_DB0_EquipeEmployeVersion_Id; //"Id_planning";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpId = "";

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Object = DBPL_V_DB0_EquipeEmployeVersion_Id;
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_ObjectList = "Liste des employés d'équipes";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TitrePage = "Employés d'équipes";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HelpPage = "";

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpId_version = "";

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Id_equipe = DBPL_V_DB0_Equipe_Id; //"Id_equipe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LblId_equipe = DBPL_V_DB0_Equipe_LblId; //"Id_equipe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LgdId_equipe = DBPL_V_DB0_Equipe_LgdId; //"Id_equipe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TtpId_equipe = DBPL_V_DB0_Equipe_TtpId; //"Id_equipe";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpId_equipe = "";

        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
        public readonly static string DBPL_V_DB0_EquipeEmployeVersion_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpId_employe = "";

        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_EquipeEmployeVersion_HlpId_espaceclient = "";

        #endregion

        #region type tache

        public readonly static string DBPL_V_DB0_TypeTache_Id = "Type de tâche";
        public readonly static string DBPL_V_DB0_TypeTache_LblId = DBPL_V_DB0_TypeTache_Id; //"Id";
        public readonly static string DBPL_V_DB0_TypeTache_LgdId = DBPL_V_DB0_TypeTache_Id; //"Id";
        public readonly static string DBPL_V_DB0_TypeTache_TtpId = DBPL_V_DB0_TypeTache_Id; //"Id";
        public static readonly string DBPL_V_DB0_TypeTache_HlpId = "";

        public readonly static string DBPL_V_DB0_TypeTache_Object = DBPL_V_DB0_TypeTache_Id; //"Abreviation";
        public readonly static string DBPL_V_DB0_TypeTache_ObjectList = "Liste des types de tâche";
        public readonly static string DBPL_V_DB0_TypeTache_TitrePage = "Types de tâche";
        public static readonly string DBPL_V_DB0_TypeTache_HelpPage = "";

        public readonly static string DBPL_V_DB0_TypeTache_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_TypeTache_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_TypeTache_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_TypeTache_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_TypeTache_HlpLogicaldeleted = "";

        public readonly static string DBPL_V_DB0_TypeTache_Libelle = "Nom du type de tâche";
        public readonly static string DBPL_V_DB0_TypeTache_LblLibelle = DBPL_V_DB0_TypeTache_Libelle; //"Libelle";
        public readonly static string DBPL_V_DB0_TypeTache_LgdLibelle = "Nom";
        public readonly static string DBPL_V_DB0_TypeTache_TtpLibelle = DBPL_V_DB0_TypeTache_Libelle; //"Libelle";
        public static readonly string DBPL_V_DB0_TypeTache_HlpLibelle = "";

        public static readonly string DBPL_V_DB0_TypeTache_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeTache_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeTache_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeTache_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeTache_HlpId_espaceclient = "";

        #endregion

        #region TypeCategorie

        public static readonly string DBPL_V_DB0_TypeCategorie_Id = "Type de catégorie";
        public static readonly string DBPL_V_DB0_TypeCategorie_LblId = DBPL_V_DB0_TypeCategorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdId = DBPL_V_DB0_TypeCategorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpId = DBPL_V_DB0_TypeCategorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpId = DBPL_V_DB0_TypeCategorie_Id; //{ "Id" };

        public static readonly string DBPL_V_DB0_TypeCategorie_Object = DBPL_V_DB0_TypeCategorie_Id;
        public static readonly string DBPL_V_DB0_TypeCategorie_ObjectList = "Liste des types de catégorie";
        public static readonly string DBPL_V_DB0_TypeCategorie_TitrePage = "Types de catégorie";
        public static readonly string DBPL_V_DB0_TypeCategorie_HelpPage = "";

        public static readonly string DBPL_V_DB0_TypeCategorie_Logicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LblLogicaldeleted = LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdLogicaldeleted = LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpLogicaldeleted = TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpLogicaldeleted = ""; //{ "Logicaldeleted" };

        public static readonly string DBPL_V_DB0_TypeCategorie_Id_espaceclient = Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LblId_espaceclient = LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdId_espaceclient = LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpId_espaceclient = TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpId_espaceclient = ""; //{ "Id_espaceclient" };

        public static readonly string DBPL_V_DB0_TypeCategorie_Id_planning = DBPL_V_DB0_Planning_Id; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LblId_planning = DBPL_V_DB0_Planning_LblId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpId_planning = ""; //{ "Id_planning" };

        public static readonly string DBPL_V_DB0_TypeCategorie_Id_mere = "Type de catégorie principal";
        public static readonly string DBPL_V_DB0_TypeCategorie_LblId_mere = DBPL_V_DB0_TypeCategorie_Id_mere; //{ "Id_mere" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdId_mere = DBPL_V_DB0_TypeCategorie_Id_mere; //{ "Id_mere" };
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpId_mere = DBPL_V_DB0_TypeCategorie_Id_mere; //{ "Id_mere" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpId_mere = ""; //{ "Id_mere" };

        public static readonly string DBPL_V_DB0_TypeCategorie_Libelle = "Nom du type de catégorie";
        public static readonly string DBPL_V_DB0_TypeCategorie_LblLibelle = DBPL_V_DB0_TypeCategorie_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_TypeCategorie_LgdLibelle = "Nom";
        public static readonly string DBPL_V_DB0_TypeCategorie_TtpLibelle = DBPL_V_DB0_TypeCategorie_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_TypeCategorie_HlpLibelle = ""; //{ "Libelle" };

        #endregion

        #region categorie

        public static readonly string DBPL_V_DB0_Categorie_Id = "Catégorie";
        public static readonly string DBPL_V_DB0_Categorie_LblId = DBPL_V_DB0_Categorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Categorie_LgdId = DBPL_V_DB0_Categorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Categorie_TtpId = DBPL_V_DB0_Categorie_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Categorie_HlpId = DBPL_V_DB0_Categorie_Id; //{ "Id" };


        public static readonly string DBPL_V_DB0_Categorie_Object = DBPL_V_DB0_Categorie_Id;
        public static readonly string DBPL_V_DB0_Categorie_ObjectList = "Liste des catégories";
        public static readonly string DBPL_V_DB0_Categorie_TitrePage = "Catégories";
        public static readonly string DBPL_V_DB0_Categorie_HelpPage = "";

        public static readonly string DBPL_V_DB0_Categorie_Logicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Categorie_LblLogicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Categorie_LgdLogicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Categorie_TtpLogicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Categorie_HlpLogicaldeleted = ""; //{ "Logicaldeleted" };

        public static readonly string DBPL_V_DB0_Categorie_Id_espaceclient = Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Categorie_LblId_espaceclient = LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Categorie_LgdId_espaceclient = LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Categorie_TtpId_espaceclient = TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Categorie_HlpId_espaceclient = ""; //{ "Id_espaceclient" };

        public static readonly string DBPL_V_DB0_Categorie_Id_typecategorie = DBPL_V_DB0_TypeCategorie_Id; //{ "Id_typecategorie" };
        public static readonly string DBPL_V_DB0_Categorie_LblId_typecategorie = DBPL_V_DB0_TypeCategorie_LblId; //{ "Id_typecategorie" };
        public static readonly string DBPL_V_DB0_Categorie_LgdId_typecategorie = DBPL_V_DB0_TypeCategorie_LgdId; //{ "Id_typecategorie" };
        public static readonly string DBPL_V_DB0_Categorie_TtpId_typecategorie = DBPL_V_DB0_TypeCategorie_TtpId; //{ "Id_typecategorie" };
        public static readonly string DBPL_V_DB0_Categorie_HlpId_typecategorie = ""; //{ "Id_typecategorie" };

        public static readonly string DBPL_V_DB0_Categorie_Libelle = "Nom de la catégorie";
        public static readonly string DBPL_V_DB0_Categorie_LblLibelle = DBPL_V_DB0_Categorie_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Categorie_LgdLibelle = "Nom";
        public static readonly string DBPL_V_DB0_Categorie_TtpLibelle = DBPL_V_DB0_Categorie_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Categorie_HlpLibelle = ""; //{ "Libelle" };

        public static readonly string DBPL_V_DB0_Categorie_Ordreaff = "Ordre d'affichage";
        public static readonly string DBPL_V_DB0_Categorie_LblOrdreaff = DBPL_V_DB0_Categorie_Ordreaff; //{ "Ordreaff" };
        public static readonly string DBPL_V_DB0_Categorie_LgdOrdreaff = "Ordre";
        public static readonly string DBPL_V_DB0_Categorie_TtpOrdreaff = DBPL_V_DB0_Categorie_Ordreaff; //{ "Ordreaff" };
        public static readonly string DBPL_V_DB0_Categorie_HlpOrdreaff = ""; //{ "Ordreaff" };

        public static readonly string DBPL_V_DB0_Categorie_Id_mere = "Catégorie mère";
        public static readonly string DBPL_V_DB0_Categorie_LblId_mere = DBPL_V_DB0_Categorie_Id_mere; //{ "Ordreaff" };
        public static readonly string DBPL_V_DB0_Categorie_LgdId_mere = DBPL_V_DB0_Categorie_Id_mere;
        public static readonly string DBPL_V_DB0_Categorie_TtpId_mere = DBPL_V_DB0_Categorie_Id_mere; //{ "Ordreaff" };
        public static readonly string DBPL_V_DB0_Categorie_HlpId_mere = ""; //{ "Ordreaff" };

        #endregion

        #region contrainte

        public static readonly string DBPL_V_DB0_Contrainte_Id = "Contrainte";
        public static readonly string DBPL_V_DB0_Contrainte_LblId = DBPL_V_DB0_Contrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdId = DBPL_V_DB0_Contrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpId = DBPL_V_DB0_Contrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpId = ""; //{ "Id" };

        public static readonly string DBPL_V_DB0_Contrainte_Object = DBPL_V_DB0_Contrainte_Id;
        public static readonly string DBPL_V_DB0_Contrainte_ObjectList = "Liste des contraintes";
        public static readonly string DBPL_V_DB0_Contrainte_TitrePage = "Contraintes";
        public static readonly string DBPL_V_DB0_Contrainte_HelpPage = "";

        public static readonly string DBPL_V_DB0_Contrainte_Logicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Contrainte_LblLogicaldeleted = LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdLogicaldeleted = LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpLogicaldeleted = TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpLogicaldeleted = ""; //{ "Logicaldeleted" };

        public static readonly string DBPL_V_DB0_Contrainte_Id_espaceclient = Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Contrainte_LblId_espaceclient = LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdId_espaceclient = LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpId_espaceclient = TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpId_espaceclient = ""; //{ "Id_espaceclient" };

        public static readonly string DBPL_V_DB0_Contrainte_Id_planning = DBPL_V_DB0_Planning_Id; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_Contrainte_LblId_planning = DBPL_V_DB0_Planning_LblId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //{ "Id_planning" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpId_planning = ""; //{ "Id_planning" };

        public static readonly string DBPL_V_DB0_Contrainte_Ref = "Référence";
        public static readonly string DBPL_V_DB0_Contrainte_LblRef = DBPL_V_DB0_Contrainte_Ref; //{ "Ref" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdRef = "Réf";
        public static readonly string DBPL_V_DB0_Contrainte_TtpRef = DBPL_V_DB0_Contrainte_Ref; //{ "Ref" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpRef = ""; //{ "Ref" };

        public static readonly string DBPL_V_DB0_Contrainte_Libelle = "Nom de la contrainte";
        public static readonly string DBPL_V_DB0_Contrainte_LblLibelle = DBPL_V_DB0_Contrainte_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdLibelle = "Nom";
        public static readonly string DBPL_V_DB0_Contrainte_TtpLibelle = DBPL_V_DB0_Contrainte_Libelle; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpLibelle = ""; //{ "Libelle" };

        public static readonly string DBPL_V_DB0_Contrainte_Commentaire = "Commentaire";
        public static readonly string DBPL_V_DB0_Contrainte_LblCommentaire = DBPL_V_DB0_Contrainte_Commentaire; //{ "Commentaire" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdCommentaire = DBPL_V_DB0_Contrainte_Commentaire; //{ "Commentaire" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpCommentaire = DBPL_V_DB0_Contrainte_Commentaire; //{ "Commentaire" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpCommentaire = ""; //{ "Commentaire" };

        public static readonly string DBPL_V_DB0_Contrainte_Id_typecontrainte = DBPL_V_DB0_TypeTache_Id; //{ "Id_typecontrainte" };
        public static readonly string DBPL_V_DB0_Contrainte_LblId_typecontrainte = DBPL_V_DB0_TypeTache_LblId; //{ "Id_typecontrainte" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdId_typecontrainte = DBPL_V_DB0_TypeTache_LgdId; //{ "Id_typecontrainte" };
        public static readonly string DBPL_V_DB0_Contrainte_TtpId_typecontrainte = DBPL_V_DB0_TypeTache_TtpId; //{ "Id_typecontrainte" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpId_typecontrainte = ""; //{ "Id_typecontrainte" };

        public static readonly string DBPL_V_DB0_Contrainte_Realisee = "Totalement réalisée";
        public static readonly string DBPL_V_DB0_Contrainte_LblRealisee = DBPL_V_DB0_Contrainte_Realisee; //{ "Realisee" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdRealisee = "Réalisée";
        public static readonly string DBPL_V_DB0_Contrainte_TtpRealisee = DBPL_V_DB0_Contrainte_Realisee; //{ "Realisee" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpRealisee = ""; //{ "Realisee" };

        public static readonly string DBPL_V_DB0_Contrainte_Abreviation = "Code de la contrainte";
        public static readonly string DBPL_V_DB0_Contrainte_LblAbreviation = DBPL_V_DB0_Contrainte_Abreviation; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Contrainte_LgdAbreviation = "Code";
        public static readonly string DBPL_V_DB0_Contrainte_TtpAbreviation = DBPL_V_DB0_Contrainte_Abreviation; //{ "Libelle" };
        public static readonly string DBPL_V_DB0_Contrainte_HlpAbreviation = ""; //{ "Libelle" };

        #endregion

        #region CategorieContrainte

        public static readonly string DBPL_V_DB0_CategorieContrainte_Id = "Catégorie de contrainte";
        public static readonly string DBPL_V_DB0_CategorieContrainte_LblId = DBPL_V_DB0_CategorieContrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LgdId = DBPL_V_DB0_CategorieContrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_TtpId = DBPL_V_DB0_CategorieContrainte_Id; //{ "Id" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_HlpId = "";

        public static readonly string DBPL_V_DB0_CategorieContrainte_Object = DBPL_V_DB0_CategorieContrainte_Id;
        public static readonly string DBPL_V_DB0_CategorieContrainte_ObjectList = "Liste des catégories de contrainte";
        public static readonly string DBPL_V_DB0_CategorieContrainte_TitrePage = "Catégories de contrainte";
        public static readonly string DBPL_V_DB0_CategorieContrainte_HelpPage = "";

        public static readonly string DBPL_V_DB0_CategorieContrainte_Logicaldeleted = Logicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LblLogicaldeleted = LblLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LgdLogicaldeleted = LgdLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_TtpLogicaldeleted = TtpLogicaldeleted; //{ "Logicaldeleted" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_HlpLogicaldeleted = ""; //{ "Logicaldeleted" };

        public static readonly string DBPL_V_DB0_CategorieContrainte_Id_espaceclient = Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LblId_espaceclient = LblId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LgdId_espaceclient = LgdId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_TtpId_espaceclient = TtpId_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_HlpId_espaceclient = ""; //{ "Id_espaceclient" };

        public static readonly string DBPL_V_DB0_CategorieContrainte_Id_categorie = DBPL_V_DB0_Categorie_Id; //{ "Id_categorie" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LblId_categorie = DBPL_V_DB0_Categorie_LblId; //{ "Id_categorie" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LgdId_categorie = DBPL_V_DB0_Categorie_LgdId; //{ "Id_categorie" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_TtpId_categorie = DBPL_V_DB0_Categorie_TtpId; //{ "Id_categorie" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_HlpId_categorie = ""; //{ "Id_categorie" };

        public static readonly string DBPL_V_DB0_CategorieContrainte_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //{ "Id_contrainte" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //{ "Id_contrainte" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //{ "Id_contrainte" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //{ "Id_contrainte" };
        public static readonly string DBPL_V_DB0_CategorieContrainte_HlpId_contrainte = ""; //{ "Id_contrainte" };

        #endregion

        #region realisation

        public readonly static string DBPL_V_DB0_Realisation_Id = "Réalisation";
        public readonly static string DBPL_V_DB0_Realisation_LblId = DBPL_V_DB0_Realisation_Id; //"Id";
        public readonly static string DBPL_V_DB0_Realisation_LgdId = DBPL_V_DB0_Realisation_Id; //"Id";
        public readonly static string DBPL_V_DB0_Realisation_TtpId = DBPL_V_DB0_Realisation_Id; //"Id";
        public static readonly string DBPL_V_DB0_Realisation_HlpId = "";

        public readonly static string DBPL_V_DB0_Realisation_Object = DBPL_V_DB0_Realisation_Id; //"Id_contrainte";
        public readonly static string DBPL_V_DB0_Realisation_ObjectList = "Liste des réalisations";
        public readonly static string DBPL_V_DB0_Realisation_TitrePage = "Réalisations";
        public static readonly string DBPL_V_DB0_Realisation_HelpPage = "";

        public readonly static string DBPL_V_DB0_Realisation_Debut = "Début";
        public readonly static string DBPL_V_DB0_Realisation_LblDebut = DBPL_V_DB0_Realisation_Debut; //"Debut";
        public readonly static string DBPL_V_DB0_Realisation_LgdDebut = DBPL_V_DB0_Realisation_Debut; //"Debut";
        public readonly static string DBPL_V_DB0_Realisation_TtpDebut = DBPL_V_DB0_Realisation_Debut; //"Debut";
        public static readonly string DBPL_V_DB0_Realisation_HlpDebut = "";

        public readonly static string DBPL_V_DB0_Realisation_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
        public readonly static string DBPL_V_DB0_Realisation_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
        public readonly static string DBPL_V_DB0_Realisation_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
        public readonly static string DBPL_V_DB0_Realisation_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";
        public static readonly string DBPL_V_DB0_Realisation_HlpId_employe = "";

        public readonly static string DBPL_V_DB0_Realisation_Duree = "Durée";
        public readonly static string DBPL_V_DB0_Realisation_LblDuree = DBPL_V_DB0_Realisation_Duree; //"Duree";
        public readonly static string DBPL_V_DB0_Realisation_LgdDuree = DBPL_V_DB0_Realisation_Duree; //"Duree";
        public readonly static string DBPL_V_DB0_Realisation_TtpDuree = DBPL_V_DB0_Realisation_Duree; //"Duree";
        public static readonly string DBPL_V_DB0_Realisation_HlpDuree = "";

        public readonly static string DBPL_V_DB0_Realisation_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Realisation_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Realisation_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
        public readonly static string DBPL_V_DB0_Realisation_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";
        public static readonly string DBPL_V_DB0_Realisation_HlpLogicaldeleted = "";

        public static readonly string DBPL_V_DB0_Realisation_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Realisation_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Realisation_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Realisation_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
        public static readonly string DBPL_V_DB0_Realisation_HlpId_espaceclient = "";

        public readonly static string DBPL_V_DB0_Realisation_Id_contrainterealisee = "Contrainte réalisée";
        public readonly static string DBPL_V_DB0_Realisation_LblId_contrainterealisee = DBPL_V_DB0_Realisation_Id_contrainterealisee; //"Id_contrainterealisee";
        public readonly static string DBPL_V_DB0_Realisation_LgdId_contrainterealisee = DBPL_V_DB0_Realisation_Id_contrainterealisee; //"Id_contrainterealisee";
        public readonly static string DBPL_V_DB0_Realisation_TtpId_contrainterealisee = DBPL_V_DB0_Realisation_Id_contrainterealisee; //"Id_contrainterealisee";
        public readonly static string DBPL_V_DB0_Realisation_HlpId_contrainterealisee = ""; //"Id_contrainte";

        public readonly static string DBPL_V_DB0_Realisation_Id_contrainte = "Contrainte";
        public readonly static string DBPL_V_DB0_Realisation_LblId_contrainte = DBPL_V_DB0_Realisation_Id_contrainte; //"Id_contrainte";
        public readonly static string DBPL_V_DB0_Realisation_LgdId_contrainte = DBPL_V_DB0_Realisation_Id_contrainte; //"Id_contrainte";
        public readonly static string DBPL_V_DB0_Realisation_TtpId_contrainte = DBPL_V_DB0_Realisation_Id_contrainte; //"Id_contrainte";
        public readonly static string DBPL_V_DB0_Realisation_HlpId_contrainte = ""; //"Id_contrainte";

        #endregion

        /*

        public readonly static string Libelle = "Libellé";
         public readonly static string LblLibelle = Libelle; //"Libelle";
         public readonly static string TtpLibelle = Libelle; //"Libelle";

         public readonly static string Ref = "Référence";
         public readonly static string LblRef = Ref; //"Ref";
         public readonly static string LgdRef = "Réf";
         public readonly static string TtpRef = Ref; //"Ref";

         public readonly static string Commentaire = "Commentaire";
         public readonly static string LblCommentaire = Commentaire; //"Commentaire";
         public readonly static string LgdCommentaire = Commentaire; //"Commentaire";
         public readonly static string TtpCommentaire = Commentaire; //"Commentaire";

         public readonly static string Abreviation = "Abréviation";
         public readonly static string LblAbreviation = Abreviation; //"Abreviation";
         public readonly static string TtpAbreviation = Abreviation; //"Abreviation";

         public readonly static string Info = "Information";
         public readonly static string LblInfo = Info; //"Info";
         public readonly static string LgdInfo = Info; //"Info";
         public readonly static string TtpInfo = Info; //"Info";

         public readonly static string Debutcalc = "Début calculé";
         public readonly static string LblDebutcalc = Debutcalc; //"Debutcalc";
         public readonly static string LgdDebutcalc = Debutcalc; //"Debutcalc";
         public readonly static string TtpDebutcalc = Debutcalc; //"Debutcalc";

         public readonly static string Fincalc = "Fin calculée";
         public readonly static string LblFincalc = Fincalc; //"Fincalc";
         public readonly static string LgdFincalc = Fincalc; //"Fincalc";
         public readonly static string TtpFincalc = Fincalc; //"Fincalc";

         public readonly static string Debutreal = "Début de réalisations";
         public readonly static string LblDebutreal = Debutreal; //"Debutreal";
         public readonly static string LgdDebutreal = "Début réal";
         public readonly static string TtpDebutreal = Debutreal; //"Debutreal";

         public readonly static string Finreal = "Fin de réalisations";
         public readonly static string LblFinreal = Finreal; //"Finreal";
         public readonly static string LgdFinreal = "Fin réal";
         public readonly static string TtpFinreal = Finreal; //"Finreal";

         public readonly static string Dureecalc = "Durée calculée";
         public readonly static string LblDureecalc = Dureecalc; //"Dureecalc";
         public readonly static string LgdDureecalc = Dureecalc; //"Dureecalc";
         public readonly static string TtpDureecalc = Dureecalc; //"Dureecalc";

         public readonly static string Dureereal = "Durée de réalisation";
         public readonly static string LblDureereal = Dureereal; //"Dureereal";
         public readonly static string LgdDureereal = "Durée réal";
         public readonly static string TtpDureereal = Dureereal; //"Dureereal";

         public readonly static string Debut = "Début";
         public readonly static string LblDebut = Debut; //"Debut";
         public readonly static string LgdDebut = Debut; //"Debut";
         public readonly static string TtpDebut = Debut; //"Debut";

         public readonly static string Fin = "Fin";
         public readonly static string LblFin = Fin; //"Fin";
         public readonly static string LgdFin = Fin; //"Fin";
         public readonly static string TtpFin = Fin; //"Fin";

         public readonly static string Duree = "Durée";
         public readonly static string LblDuree = Duree; //"Duree";
         public readonly static string LgdDuree = Duree; //"Duree";
         public readonly static string TtpDuree = Duree; //"Duree";


         #endregion

 

         #region Action

         public readonly static string DBPL_V_DB0_Action_Id = "Action";
         public readonly static string DBPL_V_DB0_Action_LblId = DBPL_V_DB0_Action_Id; //"Id";
         public readonly static string DBPL_V_DB0_Action_LgdId = DBPL_V_DB0_Action_Id; //"Id";
         public readonly static string DBPL_V_DB0_Action_TtpId = DBPL_V_DB0_Action_Id; //"Id";

         public readonly static string DBPL_V_DB0_Action_Object = DBPL_V_DB0_Action_Id;
         public readonly static string DBPL_V_DB0_Action_ObjectList = "Liste des actions";
         public readonly static string DBPL_V_DB0_Action_TitrePage = "Actions";
         public static readonly string DBPL_V_DB0_Action_HelpPage = "";

         public static readonly string DBPL_V_DB0_Action_HlpId = "";
         public static readonly string DBPL_V_DB0_Action_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Action_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Action_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_Action_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Action_HlpId_espaceclient = "";


         public readonly static string DBPL_V_DB0_Action_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Action_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Action_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Action_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Action_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Action_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Action_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Action_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Action_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Action_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Action_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Action_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Action_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Action_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Action_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Action_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Action_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Action_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Action_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Action_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region Application

         public readonly static string DBPL_V_DB0_Application_Id = "Application";
         public readonly static string DBPL_V_DB0_Application_LblId = DBPL_V_DB0_Application_Id; //"Id";
         public readonly static string DBPL_V_DB0_Application_LgdId = DBPL_V_DB0_Application_Id; //"Id";
         public readonly static string DBPL_V_DB0_Application_TtpId = DBPL_V_DB0_Application_Id; //"Id";

         public readonly static string DBPL_V_DB0_Application_Object = DBPL_V_DB0_Application_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Application_ObjectList = "Liste des applications";
         public readonly static string DBPL_V_DB0_Application_TitrePage = "Applications";
         public static readonly string DBPL_V_DB0_Application_HelpPage = "";

         public static readonly string DBPL_V_DB0_Application_HlpId = "";
         public static readonly string DBPL_V_DB0_Application_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Application_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Application_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_Application_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Application_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Application_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Application_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Application_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Application_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Application_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Application_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Application_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Application_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Application_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Application_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Application_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Application_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Application_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Application_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Application_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Application_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Application_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Application_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Application_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Application_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region unité horaire

         public readonly static string DBPL_V_DB0_UniteHoraire_Id = "Unité horaire";
         public readonly static string DBPL_V_DB0_UniteHoraire_LblId = DBPL_V_DB0_UniteHoraire_Id; //"Id";
         public readonly static string DBPL_V_DB0_UniteHoraire_LgdId = DBPL_V_DB0_UniteHoraire_Id; //"Id";
         public readonly static string DBPL_V_DB0_UniteHoraire_TtpId = DBPL_V_DB0_UniteHoraire_Id; //"Id";

         public readonly static string DBPL_V_DB0_UniteHoraire_Object = DBPL_V_DB0_UniteHoraire_Id;
         public readonly static string DBPL_V_DB0_UniteHoraire_ObjectList = "Liste des unités horaire";
         public readonly static string DBPL_V_DB0_UniteHoraire_TitrePage = "Unités horaire";
         public static readonly string DBPL_V_DB0_UniteHoraire_HelpPage = "";

         public static readonly string DBPL_V_DB0_UniteHoraire_HlpId = "";
         public static readonly string DBPL_V_DB0_UniteHoraire_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_UniteHoraire_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_UniteHoraire_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_UniteHoraire_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_UniteHoraire_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_UniteHoraire_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_UniteHoraire_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_UniteHoraire_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_UniteHoraire_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_UniteHoraire_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_UniteHoraire_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_UniteHoraire_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_UniteHoraire_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_UniteHoraire_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_UniteHoraire_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_UniteHoraire_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public static readonly string DBPL_V_DB0_UniteHoraire_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_UniteHoraire_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_UniteHoraire_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_UniteHoraire_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion





         #region contrainte

         public readonly static string DBPL_V_DB0_Contrainte_Id = "Prévision ";
         public readonly static string DBPL_V_DB0_Contrainte_LblId = DBPL_V_DB0_Contrainte_Id; //"Id";
         public readonly static string DBPL_V_DB0_Contrainte_LgdId = DBPL_V_DB0_Contrainte_Id; //"Id";
         public readonly static string DBPL_V_DB0_Contrainte_TtpId = DBPL_V_DB0_Contrainte_Id; //"Id";

         public readonly static string DBPL_V_DB0_Contrainte_Object = DBPL_V_DB0_Contrainte_LblId;
         public readonly static string DBPL_V_DB0_Contrainte_ObjectList = "Liste des prévisions";
         public readonly static string DBPL_V_DB0_Contrainte_TitrePage = "Prévisions";
         public static readonly string DBPL_V_DB0_Contrainte_HelpPage = "";

         public static readonly string DBPL_V_DB0_Contrainte_HlpId = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpId_typetache = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpCommentaire = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpRef = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpId_espaceclient = "";
         public static readonly string DBPL_V_DB0_Contrainte_HlpDuree = "";


         public readonly static string DBPL_V_DB0_Contrainte_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Contrainte_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Contrainte_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Contrainte_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Contrainte_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Contrainte_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Contrainte_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Contrainte_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Contrainte_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Contrainte_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Contrainte_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Contrainte_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public readonly static string DBPL_V_DB0_Contrainte_Id_typetache = DBPL_V_DB0_TypeTache_Id; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Contrainte_LblId_typetache = DBPL_V_DB0_TypeTache_LblId; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Contrainte_LgdId_typetache = DBPL_V_DB0_TypeTache_LgdId; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Contrainte_TtpId_typetache = DBPL_V_DB0_TypeTache_TtpId; //"Id_typetache";

         public readonly static string DBPL_V_DB0_Contrainte_Commentaire = Commentaire; //"Commentaire";
         public readonly static string DBPL_V_DB0_Contrainte_LblCommentaire = LblCommentaire; //"Commentaire";
         public readonly static string DBPL_V_DB0_Contrainte_LgdCommentaire = LgdCommentaire; //"Commentaire";
         public readonly static string DBPL_V_DB0_Contrainte_TtpCommentaire = TtpCommentaire; //"Commentaire";

         public readonly static string DBPL_V_DB0_Contrainte_Ref = Ref; //"Ref";
         public readonly static string DBPL_V_DB0_Contrainte_LblRef = LblRef; //"Ref";
         public readonly static string DBPL_V_DB0_Contrainte_LgdRef = LgdRef; //"Ref";
         public readonly static string DBPL_V_DB0_Contrainte_TtpRef = TtpRef; //"Ref";

         public static readonly string DBPL_V_DB0_Contrainte_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Contrainte_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Contrainte_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Contrainte_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region Calendrier

         public readonly static string DBPL_V_DB0_Calendrier_Id = "Calendrier";
         public readonly static string DBPL_V_DB0_Calendrier_LblId = DBPL_V_DB0_Calendrier_Id; //"Id";
         public readonly static string DBPL_V_DB0_Calendrier_LgdId = DBPL_V_DB0_Calendrier_Id; //"Id";
         public readonly static string DBPL_V_DB0_Calendrier_TtpId = DBPL_V_DB0_Calendrier_Id; //"Id";

         public readonly static string DBPL_V_DB0_Calendrier_Object = DBPL_V_DB0_Calendrier_Id; //"Id_uniteperiode";
         public readonly static string DBPL_V_DB0_Calendrier_ObjectList = "Liste des calendriers";
         public readonly static string DBPL_V_DB0_Calendrier_TitrePage = "Calendriers";
         public static readonly string DBPL_V_DB0_Calendrier_HelpPage = "";

         public static readonly string DBPL_V_DB0_Calendrier_HlpId = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpDebut = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpFin = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpPeriode = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpId_equipe = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpDuree = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Calendrier_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Calendrier_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Calendrier_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Calendrier_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Calendrier_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Calendrier_Debut = "Début de plage";
         public readonly static string DBPL_V_DB0_Calendrier_LblDebut = DBPL_V_DB0_Calendrier_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_Calendrier_LgdDebut = "Début";
         public readonly static string DBPL_V_DB0_Calendrier_TtpDebut = DBPL_V_DB0_Calendrier_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_Calendrier_Fin = "Fin de plage";
         public readonly static string DBPL_V_DB0_Calendrier_LblFin = DBPL_V_DB0_Calendrier_Fin; //"Fin";
         public readonly static string DBPL_V_DB0_Calendrier_LgdFin = "Fin";
         public readonly static string DBPL_V_DB0_Calendrier_TtpFin = DBPL_V_DB0_Calendrier_Fin; //"Fin";

         public readonly static string DBPL_V_DB0_Calendrier_Periode = "Périodicité";
         public readonly static string DBPL_V_DB0_Calendrier_LblPeriode = DBPL_V_DB0_Calendrier_Periode; //"Periode";
         public readonly static string DBPL_V_DB0_Calendrier_LgdPeriode = DBPL_V_DB0_Calendrier_Periode; //"Periode";
         public readonly static string DBPL_V_DB0_Calendrier_TtpPeriode = DBPL_V_DB0_Calendrier_Periode; //"Periode";

         public readonly static string DBPL_V_DB0_Calendrier_Finperiode = "Fin d'application";
         public readonly static string DBPL_V_DB0_Calendrier_LblFinperiode = DBPL_V_DB0_Calendrier_Finperiode; //"Finperiode";
         public readonly static string DBPL_V_DB0_Calendrier_LgdFinperiode = DBPL_V_DB0_Calendrier_Finperiode; //"Finperiode";
         public readonly static string DBPL_V_DB0_Calendrier_TtpFinperiode = DBPL_V_DB0_Calendrier_Finperiode; //"Finperiode";

         public readonly static string DBPL_V_DB0_Calendrier_Id_uniteperiode = "Unité de périodicité";
         public readonly static string DBPL_V_DB0_Calendrier_LblId_uniteperiode = DBPL_V_DB0_Calendrier_Id_uniteperiode; //"Id_uniteperiode";
         public readonly static string DBPL_V_DB0_Calendrier_LgdId_uniteperiode = DBPL_V_DB0_Calendrier_Id_uniteperiode; //"Id_uniteperiode";
         public readonly static string DBPL_V_DB0_Calendrier_TtpId_uniteperiode = DBPL_V_DB0_Calendrier_Id_uniteperiode; //"Id_uniteperiode";

         public readonly static string DBPL_V_DB0_Calendrier_Id_equipe = DBPL_V_DB0_Equipe_Id; //"Id_equipe";
         public readonly static string DBPL_V_DB0_Calendrier_LblId_equipe = DBPL_V_DB0_Equipe_LblId; //"Id_equipe";
         public readonly static string DBPL_V_DB0_Calendrier_LgdId_equipe = DBPL_V_DB0_Equipe_LgdId; //"Id_equipe";
         public readonly static string DBPL_V_DB0_Calendrier_TtpId_equipe = DBPL_V_DB0_Equipe_TtpId; //"Id_equipe";

         public readonly static string DBPL_V_DB0_Calendrier_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Calendrier_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Calendrier_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Calendrier_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Calendrier_Duree = "Durée";
         public readonly static string DBPL_V_DB0_Calendrier_LblDuree = DBPL_V_DB0_Calendrier_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Calendrier_LgdDuree = DBPL_V_DB0_Calendrier_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Calendrier_TtpDuree = DBPL_V_DB0_Calendrier_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_Calendrier_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Calendrier_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Calendrier_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Calendrier_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public static readonly string DBPL_V_DB0_Calendrier_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Calendrier_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Calendrier_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Calendrier_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion



         #region mode de travail

         public readonly static string DBPL_V_DB0_ModeTravail_Id = "Mode de travail";
         public readonly static string DBPL_V_DB0_ModeTravail_LblId = DBPL_V_DB0_ModeTravail_Id; //"Id";
         public readonly static string DBPL_V_DB0_ModeTravail_LgdId = DBPL_V_DB0_ModeTravail_Id; //"Id";
         public readonly static string DBPL_V_DB0_ModeTravail_TtpId = DBPL_V_DB0_ModeTravail_Id; //"Id";

         public readonly static string DBPL_V_DB0_ModeTravail_Object = DBPL_V_DB0_ModeTravail_Id;
         public readonly static string DBPL_V_DB0_ModeTravail_ObjectList = "Liste des modes de travail";
         public readonly static string DBPL_V_DB0_ModeTravail_TitrePage = "Modes de travail";
         public static readonly string DBPL_V_DB0_ModeTravail_HelpPage = "";

         public static readonly string DBPL_V_DB0_ModeTravail_HlpId = "";
         public static readonly string DBPL_V_DB0_ModeTravail_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_ModeTravail_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_ModeTravail_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_ModeTravail_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_ModeTravail_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_ModeTravail_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ModeTravail_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ModeTravail_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ModeTravail_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_ModeTravail_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_ModeTravail_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_ModeTravail_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_ModeTravail_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_ModeTravail_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_ModeTravail_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_ModeTravail_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_ModeTravail_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_ModeTravail_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_ModeTravail_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_ModeTravail_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_ModeTravail_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_ModeTravail_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ModeTravail_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ModeTravail_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ModeTravail_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion



         #region societe

         public readonly static string DBPL_V_DB0_Societe_Id = "Société";
         public readonly static string DBPL_V_DB0_Societe_LblId = DBPL_V_DB0_Societe_Id; //"Id";
         public readonly static string DBPL_V_DB0_Societe_LgdId = DBPL_V_DB0_Societe_Id; //"Id";
         public readonly static string DBPL_V_DB0_Societe_TtpId = DBPL_V_DB0_Societe_Id; //"Id";

         public readonly static string DBPL_V_DB0_Societe_Object = DBPL_V_DB0_Societe_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Societe_ObjectList = "Liste des sociétés";
         public readonly static string DBPL_V_DB0_Societe_TitrePage = "Sociétés";
         public static readonly string DBPL_V_DB0_Societe_HelpPage = "";

         public static readonly string DBPL_V_DB0_Societe_HlpId = "";
         public static readonly string DBPL_V_DB0_Societe_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Societe_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Societe_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_Societe_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Societe_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Societe_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Societe_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Societe_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Societe_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Societe_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Societe_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Societe_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Societe_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Societe_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Societe_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Societe_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Societe_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Societe_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Societe_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Societe_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Societe_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Societe_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Societe_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Societe_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Societe_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region statut

         public readonly static string DBPL_V_DB0_Statut_Id = "Statut";
         public readonly static string DBPL_V_DB0_Statut_LblId = DBPL_V_DB0_Statut_Id; //"Id";
         public readonly static string DBPL_V_DB0_Statut_LgdId = DBPL_V_DB0_Statut_Id; //"Id";
         public readonly static string DBPL_V_DB0_Statut_TtpId = DBPL_V_DB0_Statut_Id; //"Id";

         public readonly static string DBPL_V_DB0_Statut_Object = DBPL_V_DB0_Statut_Id;
         public readonly static string DBPL_V_DB0_Statut_ObjectList = "Liste des statuts";
         public readonly static string DBPL_V_DB0_Statut_TitrePage = "Statuts";
         public static readonly string DBPL_V_DB0_Statut_HelpPage = "";

         public static readonly string DBPL_V_DB0_Statut_HlpId = "";
         public static readonly string DBPL_V_DB0_Statut_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Statut_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Statut_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_Statut_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Statut_HlpId_espaceclient = "";


         public readonly static string DBPL_V_DB0_Statut_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Statut_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Statut_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Statut_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Statut_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Statut_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Statut_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Statut_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Statut_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Statut_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Statut_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Statut_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Statut_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Statut_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Statut_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Statut_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Statut_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Statut_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Statut_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Statut_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region projet

         public readonly static string DBPL_V_DB0_Projet_Id = "Projet";
         public readonly static string DBPL_V_DB0_Projet_LblId = DBPL_V_DB0_TypeTache_Id; //"Id";
         public readonly static string DBPL_V_DB0_Projet_LgdId = DBPL_V_DB0_TypeTache_Id; //"Id";
         public readonly static string DBPL_V_DB0_Projet_TtpId = DBPL_V_DB0_TypeTache_Id; //"Id";

         public readonly static string DBPL_V_DB0_Projet_Object = DBPL_V_DB0_Projet_Id;
         public readonly static string DBPL_V_DB0_Projet_ObjectList = "Liste des projets";
         public readonly static string DBPL_V_DB0_Projet_TitrePage = "Projets";
         public static readonly string DBPL_V_DB0_Projet_HelpPage = "";

         public static readonly string DBPL_V_DB0_Projet_HlpId = "";
         public static readonly string DBPL_V_DB0_Projet_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Projet_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Projet_HlpAbreviation = "";
         public static readonly string DBPL_V_DB0_Projet_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Projet_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Projet_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Projet_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Projet_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Projet_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Projet_Libelle = Libelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Projet_LblLibelle = LblLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Projet_LgdLibelle = LgdLibelle; //"Libelle";
         public readonly static string DBPL_V_DB0_Projet_TtpLibelle = TtpLibelle; //"Libelle";

         public readonly static string DBPL_V_DB0_Projet_Abreviation = Abreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Projet_LblAbreviation = LblAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Projet_LgdAbreviation = LgdAbreviation; //"Abreviation";
         public readonly static string DBPL_V_DB0_Projet_TtpAbreviation = TtpAbreviation; //"Abreviation";

         public readonly static string DBPL_V_DB0_Projet_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Projet_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Projet_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Projet_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Projet_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Projet_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Projet_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Projet_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region congeEmploye

         public readonly static string DBPL_V_DB0_CongeEmploye_Id = "Congé";
         public readonly static string DBPL_V_DB0_CongeEmploye_LblId = DBPL_V_DB0_CongeEmploye_Id; //"Id";
         public readonly static string DBPL_V_DB0_CongeEmploye_LgdId = DBPL_V_DB0_CongeEmploye_Id; //"Id";
         public readonly static string DBPL_V_DB0_CongeEmploye_TtpId = DBPL_V_DB0_CongeEmploye_Id; //"Id";

         public readonly static string DBPL_V_DB0_CongeEmploye_Object = DBPL_V_DB0_CongeEmploye_Id;
         public readonly static string DBPL_V_DB0_CongeEmploye_ObjectList = "Liste des congés";
         public readonly static string DBPL_V_DB0_CongeEmploye_TitrePage = "Congés";
         public static readonly string DBPL_V_DB0_CongeEmploye_HelpPage = "";

         public static readonly string DBPL_V_DB0_CongeEmploye_HlpId = "";
         public static readonly string DBPL_V_DB0_CongeEmploye_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_CongeEmploye_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_CongeEmploye_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_CongeEmploye_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_CongeEmploye_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeEmploye_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeEmploye_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeEmploye_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_CongeEmploye_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_CongeEmploye_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_CongeEmploye_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_CongeEmploye_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_CongeEmploye_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_CongeEmploye_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_CongeEmploye_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_CongeEmploye_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public static readonly string DBPL_V_DB0_CongeEmploye_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeEmploye_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeEmploye_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeEmploye_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region congé version

         public readonly static string DBPL_V_DB0_CongeVersion_Id = "Congé version";
         public readonly static string DBPL_V_DB0_CongeVersion_LblId = DBPL_V_DB0_CongeVersion_Id; //"Id_conge";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdId = DBPL_V_DB0_CongeVersion_Id; //"Id_conge";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpId = DBPL_V_DB0_CongeVersion_Id; //"Id_conge";

         public readonly static string DBPL_V_DB0_CongeVersion_Object = DBPL_V_DB0_CongeVersion_Id;
         public readonly static string DBPL_V_DB0_CongeVersion_ObjectList = "Liste des congés versions";
         public readonly static string DBPL_V_DB0_CongeVersion_TitrePage = "Congés versions";
         public static readonly string DBPL_V_DB0_CongeVersion_HelpPage = "";

         public static readonly string DBPL_V_DB0_CongeVersion_HlpId = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpId_congeemploye = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpId_version = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpDebut = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpFin = "";
         public static readonly string DBPL_V_DB0_CongeVersion_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_CongeVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_CongeVersion_Id_congeemploye = DBPL_V_DB0_CongeEmploye_Id; //"Id_conge";
         public readonly static string DBPL_V_DB0_CongeVersion_LblId_congeemploye = DBPL_V_DB0_CongeEmploye_LblId; //"Id_conge";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdId_congeemploye = DBPL_V_DB0_CongeEmploye_LgdId; //"Id_conge";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpId_congeemploye = DBPL_V_DB0_CongeEmploye_TtpId; //"Id_conge";

         public readonly static string DBPL_V_DB0_CongeVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_CongeVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_CongeVersion_Debut = "Début de congé";
         public readonly static string DBPL_V_DB0_CongeVersion_LblDebut = DBPL_V_DB0_CongeVersion_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdDebut = "Début congé";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpDebut = DBPL_V_DB0_CongeVersion_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_CongeVersion_Fin = "Début de reprise";
         public readonly static string DBPL_V_DB0_CongeVersion_LblFin = DBPL_V_DB0_CongeVersion_Fin; //"Fin";
         public readonly static string DBPL_V_DB0_CongeVersion_LgdFin = "Début reprise";
         public readonly static string DBPL_V_DB0_CongeVersion_TtpFin = DBPL_V_DB0_CongeVersion_Fin; //"Fin";

         public static readonly string DBPL_V_DB0_CongeVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_CongeVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region Ferie

         public readonly static string DBPL_V_DB0_Ferie_Id = "Férié";
         public readonly static string DBPL_V_DB0_Ferie_LblId = DBPL_V_DB0_Ferie_Id; //"Id";
         public readonly static string DBPL_V_DB0_Ferie_LgdId = DBPL_V_DB0_Ferie_Id; //"Id";
         public readonly static string DBPL_V_DB0_Ferie_TtpId = DBPL_V_DB0_Ferie_Id; //"Id";

         public readonly static string DBPL_V_DB0_Ferie_Object = DBPL_V_DB0_Ferie_Id; //"Dureereal";
         public readonly static string DBPL_V_DB0_Ferie_ObjectList = "Liste des C_ériés";
         public readonly static string DBPL_V_DB0_Ferie_TitrePage = "Fériés";
         public static readonly string DBPL_V_DB0_Ferie_HelpPage = "";

         public static readonly string DBPL_V_DB0_Ferie_HlpId = "";
         public static readonly string DBPL_V_DB0_Ferie_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Ferie_HlpDebut = "";
         public static readonly string DBPL_V_DB0_Ferie_HlpDuree = "";
         public static readonly string DBPL_V_DB0_Ferie_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Ferie_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Ferie_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ferie_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ferie_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ferie_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Ferie_Debut = "Début de Congé";
         public readonly static string DBPL_V_DB0_Ferie_LblDebut = DBPL_V_DB0_Ferie_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_Ferie_LgdDebut = "Début congé";
         public readonly static string DBPL_V_DB0_Ferie_TtpDebut = DBPL_V_DB0_Ferie_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_Ferie_Duree = "Durée";
         public readonly static string DBPL_V_DB0_Ferie_LblDuree = DBPL_V_DB0_Ferie_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Ferie_LgdDuree = DBPL_V_DB0_Ferie_Duree;
         public readonly static string DBPL_V_DB0_Ferie_TtpDuree = DBPL_V_DB0_Ferie_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_Ferie_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Ferie_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Ferie_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Ferie_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public static readonly string DBPL_V_DB0_Ferie_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ferie_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ferie_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ferie_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region planification

         public readonly static string DBPL_V_DB0_Planification_Id = "Prévision planifiée";
         public readonly static string DBPL_V_DB0_Planification_LblId = DBPL_V_DB0_Planification_Id; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Planification_LgdId = DBPL_V_DB0_Planification_Id; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Planification_TtpId = DBPL_V_DB0_Planification_Id; //"Id_typetache";

         public readonly static string DBPL_V_DB0_Planification_Object = DBPL_V_DB0_Planification_Id;
         public readonly static string DBPL_V_DB0_Planification_ObjectList = "Liste des prévisions planifiées";
         public readonly static string DBPL_V_DB0_Planification_TitrePage = "Prévisions planifiées";
         public static readonly string DBPL_V_DB0_Planification_HelpPage = "";

         public static readonly string DBPL_V_DB0_Planification_HlpId = "";
         public static readonly string DBPL_V_DB0_Planification_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Planification_HlpInfo = "";
         public static readonly string DBPL_V_DB0_Planification_HlpDebutcalc = "";
         public static readonly string DBPL_V_DB0_Planification_HlpFincalc = "";
         public static readonly string DBPL_V_DB0_Planification_HlpDureecalc = "";
         public static readonly string DBPL_V_DB0_Planification_HlpDebutreal = "";
         public static readonly string DBPL_V_DB0_Planification_HlpFinreal = "";
         public static readonly string DBPL_V_DB0_Planification_HlpDureereal = "";
         public static readonly string DBPL_V_DB0_Planification_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Planification_HlpId_version = "";
         public static readonly string DBPL_V_DB0_Planification_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_Planification_HlpContrainte = "";
         public static readonly string DBPL_V_DB0_Planification_HlpId_espaceclient = "";
         public static readonly string DBPL_V_DB0_Planification_HlpId_typetache = "";
         public readonly static string DBPL_V_DB0_Planification_HlpDebut = "";
         public readonly static string DBPL_V_DB0_Planification_HlpDuree = "";
         public readonly static string DBPL_V_DB0_Planification_HlpId_planning = "";

         public readonly static string DBPL_V_DB0_Planification_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Planification_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Planification_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Planification_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Planification_Id_typetache = DBPL_V_DB0_TypeTache_Id; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Planification_LblId_typetache = DBPL_V_DB0_TypeTache_LblId; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Planification_LgdId_typetache = DBPL_V_DB0_TypeTache_LgdId; //"Id_typetache";
         public readonly static string DBPL_V_DB0_Planification_TtpId_typetache = DBPL_V_DB0_TypeTache_TtpId; //"Id_typetache";

         public readonly static string DBPL_V_DB0_Planification_Info = Info; //"Info";
         public readonly static string DBPL_V_DB0_Planification_LblInfo = LblInfo; //"Info";
         public readonly static string DBPL_V_DB0_Planification_LgdInfo = LgdInfo; //"Info";
         public readonly static string DBPL_V_DB0_Planification_TtpInfo = TtpInfo; //"Info";

         public readonly static string DBPL_V_DB0_Planification_Debutcalc = Debutcalc; //"Debutcalc";
         public readonly static string DBPL_V_DB0_Planification_LblDebutcalc = LblDebutcalc; //"Debutcalc";
         public readonly static string DBPL_V_DB0_Planification_LgdDebutcalc = LgdDebutcalc; //"Debutcalc";
         public readonly static string DBPL_V_DB0_Planification_TtpDebutcalc = TtpDebutcalc; //"Debutcalc";

         public readonly static string DBPL_V_DB0_Planification_Fincalc = Fincalc; //"Fincalc";
         public readonly static string DBPL_V_DB0_Planification_LblFincalc = LblFincalc; //"Fincalc";
         public readonly static string DBPL_V_DB0_Planification_LgdFincalc = LgdFincalc; //"Fincalc";
         public readonly static string DBPL_V_DB0_Planification_TtpFincalc = TtpFincalc; //"Fincalc";

         public readonly static string DBPL_V_DB0_Planification_Dureecalc = Dureecalc; //"Dureecalc";
         public readonly static string DBPL_V_DB0_Planification_LblDureecalc = LblDureecalc; //"Dureecalc";
         public readonly static string DBPL_V_DB0_Planification_LgdDureecalc = LgdDureecalc; //"Dureecalc";
         public readonly static string DBPL_V_DB0_Planification_TtpDureecalc = TtpDureecalc; //"Dureecalc";

         public readonly static string DBPL_V_DB0_Planification_Debutreal = Debutreal; //"Debutreal";
         public readonly static string DBPL_V_DB0_Planification_LblDebutreal = LblDebutreal; //"Debutreal";
         public readonly static string DBPL_V_DB0_Planification_LgdDebutreal = LgdDebutreal; //"Debutreal";
         public readonly static string DBPL_V_DB0_Planification_TtpDebutreal = TtpDebutreal; //"Debutreal";

         public readonly static string DBPL_V_DB0_Planification_Finreal = Finreal; //"Finreal";
         public readonly static string DBPL_V_DB0_Planification_LblFinreal = LblFinreal; //"Finreal";
         public readonly static string DBPL_V_DB0_Planification_LgdFinreal = LgdFinreal; //"Finreal";
         public readonly static string DBPL_V_DB0_Planification_TtpFinreal = TtpFinreal; //"Finreal";

         public readonly static string DBPL_V_DB0_Planification_Dureereal = Dureereal; //"Dureereal";
         public readonly static string DBPL_V_DB0_Planification_LblDureereal = LblDureereal; //"Dureereal";
         public readonly static string DBPL_V_DB0_Planification_LgdDureereal = LgdDureereal; //"Dureereal";
         public readonly static string DBPL_V_DB0_Planification_TtpDureereal = TtpDureereal; //"Dureereal";

         public readonly static string DBPL_V_DB0_Planification_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Planification_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Planification_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Planification_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public readonly static string DBPL_V_DB0_Planification_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_Planification_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_Planification_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_Planification_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_Planification_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_Planification_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Planification_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Planification_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_Planification_Contrainte = "Prévision";
         public readonly static string DBPL_V_DB0_Planification_LblContrainte = DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
         public readonly static string DBPL_V_DB0_Planification_LgdContrainte = DBPL_V_DB0_Planification_Contrainte; //"Contrainte";
         public readonly static string DBPL_V_DB0_Planification_TtpContrainte = DBPL_V_DB0_Planification_Contrainte; //"Contrainte";

         public readonly static string DBPL_V_DB0_Planification_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Planification_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Planification_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Planification_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public static readonly string DBPL_V_DB0_Planification_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Planification_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Planification_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Planification_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion



         #region recap

         public readonly static string DBPL_V_DB0_RecapVersion_Id = "Tâche récapitulative";
         public readonly static string DBPL_V_DB0_RecapVersion_LblId = DBPL_V_DB0_RecapVersion_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_RecapVersion_LgdId = "Récap";
         public readonly static string DBPL_V_DB0_RecapVersion_TtpId = DBPL_V_DB0_RecapVersion_Id; //"Id_planning";

         public readonly static string DBPL_V_DB0_RecapVersion_Object = DBPL_V_DB0_RecapVersion_Id;
         public readonly static string DBPL_V_DB0_RecapVersion_ObjectList = "Liste des tâches récapitulatives";
         public readonly static string DBPL_V_DB0_RecapVersion_TitrePage = "Tâches récapitulatives";
         public static readonly string DBPL_V_DB0_RecapVersion_HelpPage = "";

         public static readonly string DBPL_V_DB0_RecapVersion_HlpId = "";
         public static readonly string DBPL_V_DB0_RecapVersion_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_RecapVersion_HlpId_contrainterecap = "";
         public static readonly string DBPL_V_DB0_RecapVersion_HlpId_version = "";
         public static readonly string DBPL_V_DB0_RecapVersion_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_RecapVersion_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_RecapVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_RecapVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_RecapVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_RecapVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_RecapVersion_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_RecapVersion_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_RecapVersion_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_RecapVersion_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public readonly static string DBPL_V_DB0_RecapVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_RecapVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_RecapVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_RecapVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_RecapVersion_Id_contrainterecap = "Contrainte";
         public readonly static string DBPL_V_DB0_RecapVersion_LblId_contrainterecap = DBPL_V_DB0_RecapVersion_Id_contrainterecap; //"Id_contrainterecap";
         public readonly static string DBPL_V_DB0_RecapVersion_LgdId_contrainterecap = DBPL_V_DB0_RecapVersion_Id_contrainterecap; //"Id_contrainterecap";
         public readonly static string DBPL_V_DB0_RecapVersion_TtpId_contrainterecap = DBPL_V_DB0_RecapVersion_Id_contrainterecap; //"Id_contrainterecap";

         public static readonly string DBPL_V_DB0_RecapVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_RecapVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_RecapVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_RecapVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region reunion

         public readonly static string DBPL_V_DB0_Reunion_Id = "Réunion";
         public readonly static string DBPL_V_DB0_Reunion_LblId = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Reunion_LgdId = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Reunion_TtpId = DBPL_V_DB0_Planning_Id; //"Id_planning";

         public readonly static string DBPL_V_DB0_Reunion_Object = DBPL_V_DB0_Reunion_Id;
         public readonly static string DBPL_V_DB0_Reunion_ObjectList = "Liste des réunions";
         public readonly static string DBPL_V_DB0_Reunion_TitrePage = "Réunions";

         public readonly static string DBPL_V_DB0_Reunion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Reunion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Reunion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Reunion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Reunion_Id_societe = DBPL_V_DB0_Societe_Id; //"Id_societe";
         public readonly static string DBPL_V_DB0_Reunion_LblId_societe = DBPL_V_DB0_Societe_LblId; //"Id_societe";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_societe = DBPL_V_DB0_Societe_LgdId; //"Id_societe";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_societe = DBPL_V_DB0_Societe_TtpId; //"Id_societe";

         public readonly static string DBPL_V_DB0_Reunion_Id_application = DBPL_V_DB0_Application_Id; //"Id_application";
         public readonly static string DBPL_V_DB0_Reunion_LblId_application = DBPL_V_DB0_Application_LblId; //"Id_application";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_application = DBPL_V_DB0_Application_LgdId; //"Id_application";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_application = DBPL_V_DB0_Application_TtpId; //"Id_application";

         public readonly static string DBPL_V_DB0_Reunion_Id_projet = DBPL_V_DB0_Projet_Id; //"Id_projet";
         public readonly static string DBPL_V_DB0_Reunion_LblId_projet = DBPL_V_DB0_Projet_LblId; //"Id_projet";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_projet = DBPL_V_DB0_Projet_LgdId; //"Id_projet";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_projet = DBPL_V_DB0_Projet_TtpId; //"Id_projet";

         public readonly static string DBPL_V_DB0_Reunion_Id_action = DBPL_V_DB0_Action_Id; //"Id_action";
         public readonly static string DBPL_V_DB0_Reunion_LblId_action = DBPL_V_DB0_Action_LblId; //"Id_action";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_action = DBPL_V_DB0_Action_LgdId; //"Id_action";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_action = DBPL_V_DB0_Action_TtpId; //"Id_action";

         public readonly static string DBPL_V_DB0_Reunion_Id_modetravail = DBPL_V_DB0_ModeTravail_Id; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Reunion_LblId_modetravail = DBPL_V_DB0_ModeTravail_LblId; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_modetravail = DBPL_V_DB0_ModeTravail_LgdId; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_modetravail = DBPL_V_DB0_ModeTravail_TtpId; //"Id_modetravail";

         public readonly static string DBPL_V_DB0_Reunion_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Reunion_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Reunion_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Reunion_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public static readonly string DBPL_V_DB0_Reunion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Reunion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Reunion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Reunion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region ReunionVersion

         public readonly static string DBPL_V_DB0_ReunionVersion_Id = "Version de réunion";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblId = DBPL_V_DB0_ReunionVersion_Id; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdId = DBPL_V_DB0_ReunionVersion_Id; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpId = DBPL_V_DB0_ReunionVersion_Id; //"Id_reunion";

         public readonly static string DBPL_V_DB0_ReunionVersion_Object = DBPL_V_DB0_ReunionVersion_Id;
         public readonly static string DBPL_V_DB0_ReunionVersion_ObjectList = "Liste des versions de réunions";
         public readonly static string DBPL_V_DB0_ReunionVersion_TitrePage = "Versions de réunions";
         public static readonly string DBPL_V_DB0_ReunionVersion_HelpPage = "";

         public static readonly string DBPL_V_DB0_ReunionVersion_HlpId = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpDebut = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpDuree = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpId_version = "";
         public static readonly string DBPL_V_DB0_ReunionVersion_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_ReunionVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_ReunionVersion_Debut = "Début de réunion";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblDebut = DBPL_V_DB0_ReunionVersion_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdDebut = DBPL_V_DB0_ReunionVersion_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpDebut = DBPL_V_DB0_ReunionVersion_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_ReunionVersion_Duree = "Durée de réunion";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblDuree = DBPL_V_DB0_ReunionVersion_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdDuree = DBPL_V_DB0_ReunionVersion_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpDuree = DBPL_V_DB0_ReunionVersion_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_ReunionVersion_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_Contrainte";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_Contrainte";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_Contrainte";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_Contrainte";

         public readonly static string DBPL_V_DB0_ReunionVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public static readonly string DBPL_V_DB0_ReunionVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region ReunionEmploye

         public readonly static string DBPL_V_DB0_ReunionEmploye_Id = "Participant de réunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblId = DBPL_V_DB0_ReunionEmploye_Id; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdId = DBPL_V_DB0_ReunionEmploye_Id; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpId = DBPL_V_DB0_ReunionEmploye_Id; //"Id_reunion";

         public readonly static string DBPL_V_DB0_ReunionEmploye_Object = DBPL_V_DB0_ReunionEmploye_Id;
         public readonly static string DBPL_V_DB0_ReunionEmploye_ObjectList = "Liste des participants de réunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TitrePage = "Participants de réunion";
         public static readonly string DBPL_V_DB0_ReunionEmploye_HelpPage = "";

         public static readonly string DBPL_V_DB0_ReunionEmploye_HlpId = "";
         public static readonly string DBPL_V_DB0_ReunionEmploye_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_ReunionEmploye_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_ReunionEmploye_HlpId_reunionversion = "";
         public static readonly string DBPL_V_DB0_ReunionEmploye_HlpId_espaceclient = "";


         public readonly static string DBPL_V_DB0_ReunionEmploye_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_ReunionEmploye_Id_reunion = DBPL_V_DB0_Reunion_Id; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblId_reunion = DBPL_V_DB0_Reunion_LblId; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdId_reunion = DBPL_V_DB0_Reunion_LgdId; //"Id_reunion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpId_reunion = DBPL_V_DB0_Reunion_TtpId; //"Id_reunion";

         public readonly static string DBPL_V_DB0_ReunionEmploye_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_ReunionEmploye_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_ReunionEmploye_Id_reunionversion = DBPL_V_DB0_ReunionVersion_Id; //"Id_reunionversion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LblId_reunionversion = DBPL_V_DB0_ReunionVersion_LblId; //"Id_reunionversion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_LgdId_reunionversion = DBPL_V_DB0_ReunionVersion_LgdId; //"Id_reunionversion";
         public readonly static string DBPL_V_DB0_ReunionEmploye_TtpId_reunionversion = DBPL_V_DB0_ReunionVersion_TtpId; //"Id_reunionversion";

         public static readonly string DBPL_V_DB0_ReunionEmploye_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionEmploye_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionEmploye_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_ReunionEmploye_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region ephemeride

         public readonly static string DBPL_V_DB0_Ephemeride_Id = "Ephéméride";
         public readonly static string DBPL_V_DB0_Ephemeride_LblId = DBPL_V_DB0_Ephemeride_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId = DBPL_V_DB0_Ephemeride_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId = DBPL_V_DB0_Ephemeride_Id; //"Id_planning";

         public readonly static string DBPL_V_DB0_Ephemeride_Object = DBPL_V_DB0_Ephemeride_Id;
         public readonly static string DBPL_V_DB0_Ephemeride_ObjectList = "Liste des éphémérides";
         public readonly static string DBPL_V_DB0_Ephemeride_TitrePage = "Ephémérides";
         public static readonly string DBPL_V_DB0_Ephemeride_HelpPage = "";

         public static readonly string DBPL_V_DB0_Ephemeride_HlpId = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_planning = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_version = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDebut = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDuree = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_type = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpId_espaceclient = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpLibelle = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDebutcontrainte = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDureecontrainte = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpFincontrainte = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpInfo = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpRef = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpCommentaire = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDebutcalc = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpFincalc = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDebutreal = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpFinreal = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDureecalc = "";
         public static readonly string DBPL_V_DB0_Ephemeride_HlpDureereal = "";

         public readonly static string DBPL_V_DB0_Ephemeride_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ephemeride_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Ephemeride_Id_planning = DBPL_V_DB0_Planning_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Ephemeride_LblId_planning = DBPL_V_DB0_Planning_LblId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId_planning = DBPL_V_DB0_Planning_LgdId; //"Id_planning";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId_planning = DBPL_V_DB0_Planning_TtpId; //"Id_planning";

         public readonly static string DBPL_V_DB0_Ephemeride_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_Ephemeride_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_Ephemeride_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_Ephemeride_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_Ephemeride_Debut = "Début";
         public readonly static string DBPL_V_DB0_Ephemeride_LblDebut = DBPL_V_DB0_Ephemeride_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdDebut = DBPL_V_DB0_Ephemeride_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpDebut = DBPL_V_DB0_Ephemeride_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_Ephemeride_Duree = "Durée";
         public readonly static string DBPL_V_DB0_Ephemeride_LblDuree = DBPL_V_DB0_Ephemeride_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdDuree = DBPL_V_DB0_Ephemeride_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpDuree = DBPL_V_DB0_Ephemeride_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_Ephemeride_Id_type = DBPL_V_DB0_TypeTache_Id; //"Id_type";
         public readonly static string DBPL_V_DB0_Ephemeride_LblId_type = DBPL_V_DB0_TypeTache_LblId; //"Id_type";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId_type = DBPL_V_DB0_TypeTache_LgdId; //"Id_type";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId_type = DBPL_V_DB0_TypeTache_TtpId; //"Id_type";

         public readonly static string DBPL_V_DB0_Ephemeride_Id_contrainte = DBPL_V_DB0_Contrainte_Id;
         public readonly static string DBPL_V_DB0_Ephemeride_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Ephemeride_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Ephemeride_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public static readonly string DBPL_V_DB0_Ephemeride_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ephemeride_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ephemeride_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Ephemeride_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion


         #region Admin

         public readonly static string DBPL_V_DB0_Admin_Id = "Tâche administrative";
         public readonly static string DBPL_V_DB0_Admin_LblId = DBPL_V_DB0_Admin_Id; //"Id_planning";
         public readonly static string DBPL_V_DB0_Admin_LgdId = "Admin";
         public readonly static string DBPL_V_DB0_Admin_TtpId = DBPL_V_DB0_Admin_Id; //"Id_planning";

         public readonly static string DBPL_V_DB0_Admin_Object = DBPL_V_DB0_Admin_Id; //"Dureereal";
         public readonly static string DBPL_V_DB0_Admin_ObjectList = "Liste des tâches administratives";
         public readonly static string DBPL_V_DB0_Admin_TitrePage = "Tâches administratives";
         public static readonly string DBPL_V_DB0_Admin_HelpPage = "";

         public static readonly string DBPL_V_DB0_Admin_HlpId = "";
         public static readonly string DBPL_V_DB0_Admin_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Admin_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDecalesioccupe = "";
         public static readonly string DBPL_V_DB0_Admin_HlpSecable = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDureemini = "";
         public static readonly string DBPL_V_DB0_Admin_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDebut = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDuree = "";
         public static readonly string DBPL_V_DB0_Admin_HlpPeriode = "";
         public static readonly string DBPL_V_DB0_Admin_HlpFin = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDecalagemaxi = "";
         public static readonly string DBPL_V_DB0_Admin_HlpId_espaceclient = "";
         public static readonly string DBPL_V_DB0_Admin_HlpDureereal = "";
         public static readonly string DBPL_V_DB0_Admin_HlpId_version = "";
         public readonly static string DBPL_V_DB0_Admin_HlpDureeinitiale = "";


         public readonly static string DBPL_V_DB0_Admin_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Admin_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Admin_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Admin_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Admin_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_Admin_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_Admin_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_Admin_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_Admin_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_Admin_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Admin_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_Admin_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_Admin_Debut = "Début de tâche";
         public readonly static string DBPL_V_DB0_Admin_LblDebut = DBPL_V_DB0_Admin_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_Admin_LgdDebut = "Début";
         public readonly static string DBPL_V_DB0_Admin_TtpDebut = DBPL_V_DB0_Admin_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_Admin_Duree = "Durée";
         public readonly static string DBPL_V_DB0_Admin_LblDuree = DBPL_V_DB0_Admin_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Admin_LgdDuree = DBPL_V_DB0_Admin_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_Admin_TtpDuree = DBPL_V_DB0_Admin_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_Admin_Periode = "Période";
         public readonly static string DBPL_V_DB0_Admin_LblPeriode = DBPL_V_DB0_Admin_Periode; //"Periode";
         public readonly static string DBPL_V_DB0_Admin_LgdPeriode = DBPL_V_DB0_Admin_Periode; //"Periode";
         public readonly static string DBPL_V_DB0_Admin_TtpPeriode = DBPL_V_DB0_Admin_Periode; //"Periode";

         public readonly static string DBPL_V_DB0_Admin_Decalagemaxi = "Décalage maximum";
         public readonly static string DBPL_V_DB0_Admin_LblDecalagemaxi = DBPL_V_DB0_Admin_Decalagemaxi; //"Decalagemaxi";
         public readonly static string DBPL_V_DB0_Admin_LgdDecalagemaxi = "Décalage maxi";
         public readonly static string DBPL_V_DB0_Admin_TtpDecalagemaxi = DBPL_V_DB0_Admin_Decalagemaxi; //"Decalagemaxi";

         public readonly static string DBPL_V_DB0_Admin_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Admin_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Admin_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Admin_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public readonly static string DBPL_V_DB0_Admin_Fin = "Fin";
         public readonly static string DBPL_V_DB0_Admin_LblFin = DBPL_V_DB0_Admin_Fin; //"Fin";
         public readonly static string DBPL_V_DB0_Admin_LgdFin = DBPL_V_DB0_Admin_Fin; //"Fin";
         public readonly static string DBPL_V_DB0_Admin_TtpFin = DBPL_V_DB0_Admin_Fin; //"Fin";

         public readonly static string DBPL_V_DB0_Admin_Decalesioccupe = "Décaler si créneau occupé";
         public readonly static string DBPL_V_DB0_Admin_LblDecalesioccupe = DBPL_V_DB0_Admin_Decalesioccupe; //"Decalesioccupe";
         public readonly static string DBPL_V_DB0_Admin_LgdDecalesioccupe = "Decalé si occupé";
         public readonly static string DBPL_V_DB0_Admin_TtpDecalesioccupe = DBPL_V_DB0_Admin_Decalesioccupe; //"Decalesioccupe";

         public readonly static string DBPL_V_DB0_Admin_Secable = "Sécable";
         public readonly static string DBPL_V_DB0_Admin_LblSecable = DBPL_V_DB0_Admin_Secable; //"Secable";
         public readonly static string DBPL_V_DB0_Admin_LgdSecable = DBPL_V_DB0_Admin_Secable; //"Secable";
         public readonly static string DBPL_V_DB0_Admin_TtpSecable = DBPL_V_DB0_Admin_Secable; //"Secable";

         public readonly static string DBPL_V_DB0_Admin_Dureemini = "Durée minimale d'un créneau";
         public readonly static string DBPL_V_DB0_Admin_LblDureemini = DBPL_V_DB0_Admin_Dureemini; //"Dureemini";
         public readonly static string DBPL_V_DB0_Admin_LgdDureemini = "Minimum";
         public readonly static string DBPL_V_DB0_Admin_TtpDureemini = DBPL_V_DB0_Admin_Dureemini; //"Dureemini";

         public readonly static string DBPL_V_DB0_Admin_Dureeinitiale = "Durée initiale";
         public readonly static string DBPL_V_DB0_Admin_LblDureeinitiale = DBPL_V_DB0_Admin_Dureeinitiale; //"Dureeinitiale";
         public readonly static string DBPL_V_DB0_Admin_LgdDureeinitiale = DBPL_V_DB0_Admin_Dureeinitiale; //"Dureeinitiale";
         public readonly static string DBPL_V_DB0_Admin_TtpDureeinitiale = DBPL_V_DB0_Admin_Dureeinitiale; //"Dureeinitiale";

         public static readonly string DBPL_V_DB0_Admin_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Admin_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Admin_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Admin_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region DB0_AdminVersion

         public readonly static string DBPL_V_DB0_AdminVersion_Id = "Version de tâche admin";
         public readonly static string DBPL_V_DB0_AdminVersion_LblId = DBPL_V_DB0_AdminVersion_Id; //"Id";
         public readonly static string DBPL_V_DB0_AdminVersion_LgdId = "Version admin";
         public readonly static string DBPL_V_DB0_AdminVersion_TtpId = DBPL_V_DB0_AdminVersion_Id; //"Id";

         public readonly static string DBPL_V_DB0_AdminVersion_Object = DBPL_V_DB0_AdminVersion_Id;
         public readonly static string DBPL_V_DB0_AdminVersion_ObjectList = "Liste des versions de tâche admin";
         public readonly static string DBPL_V_DB0_AdminVersion_TitrePage = "Versions de tâche admin";
         public static readonly string DBPL_V_DB0_AdminVersion_HelpPage = "";

         public static readonly string DBPL_V_DB0_AdminVersion_HlpId = "";
         public static readonly string DBPL_V_DB0_AdminVersion_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_AdminVersion_HlpId_admin = "";
         public static readonly string DBPL_V_DB0_AdminVersion_HlpId_version = "";
         public static readonly string DBPL_V_DB0_AdminVersion_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_AdminVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_AdminVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_AdminVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_AdminVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_AdminVersion_Id_admin = DBPL_V_DB0_Admin_Id; //"Id_admin";
         public readonly static string DBPL_V_DB0_AdminVersion_LblId_admin = DBPL_V_DB0_Admin_LblId; //"Id_admin";
         public readonly static string DBPL_V_DB0_AdminVersion_LgdId_admin = DBPL_V_DB0_Admin_LgdId; //"Id_admin";
         public readonly static string DBPL_V_DB0_AdminVersion_TtpId_admin = DBPL_V_DB0_Admin_TtpId; //"Id_admin";

         public readonly static string DBPL_V_DB0_AdminVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_AdminVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_AdminVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_AdminVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public static readonly string DBPL_V_DB0_AdminVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_AdminVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_AdminVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_AdminVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region TacheVersion

         public readonly static string DBPL_V_DB0_TacheVersion_Id = "Version de réunion";
         public readonly static string DBPL_V_DB0_TacheVersion_LblId = DBPL_V_DB0_TacheVersion_Id; //"Id_tache";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdId = DBPL_V_DB0_TacheVersion_Id; //"Id_tache";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpId = DBPL_V_DB0_TacheVersion_Id; //"Id_tache";

         public readonly static string DBPL_V_DB0_TacheVersion_Object = DBPL_V_DB0_TacheVersion_Id;
         public readonly static string DBPL_V_DB0_TacheVersion_ObjectList = "Liste des versions de réunions";
         public readonly static string DBPL_V_DB0_TacheVersion_TitrePage = "Versions de réunions";
         public static readonly string DBPL_V_DB0_TacheVersion_HelpPage = "";

         public static readonly string DBPL_V_DB0_TacheVersion_HlpId = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpId_version = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpDebut = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpDuree = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpSecable = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpSecablesurconge = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpDureemini = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpDebutimperatif = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpOrdre = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_TacheVersion_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_TacheVersion_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheVersion_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_TacheVersion_Debut = "Début de réunion";
         public readonly static string DBPL_V_DB0_TacheVersion_LblDebut = DBPL_V_DB0_TacheVersion_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdDebut = DBPL_V_DB0_TacheVersion_Debut; //"Debut";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpDebut = DBPL_V_DB0_TacheVersion_Debut; //"Debut";

         public readonly static string DBPL_V_DB0_TacheVersion_Duree = "Durée de réunion";
         public readonly static string DBPL_V_DB0_TacheVersion_LblDuree = DBPL_V_DB0_TacheVersion_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdDuree = DBPL_V_DB0_TacheVersion_Duree; //"Duree";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpDuree = DBPL_V_DB0_TacheVersion_Duree; //"Duree";

         public readonly static string DBPL_V_DB0_TacheVersion_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_TacheVersion_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public readonly static string DBPL_V_DB0_TacheVersion_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheVersion_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_TacheVersion_Secable = "Sécable";
         public readonly static string DBPL_V_DB0_TacheVersion_LblSecable = DBPL_V_DB0_TacheVersion_Secable; //"Secable";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdSecable = DBPL_V_DB0_TacheVersion_Secable; //"Secable";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpSecable = DBPL_V_DB0_TacheVersion_Secable; //"Secable";

         public readonly static string DBPL_V_DB0_TacheVersion_Secablesurconge = "Sécable sur congé";
         public readonly static string DBPL_V_DB0_TacheVersion_LblSecablesurconge = DBPL_V_DB0_TacheVersion_Secablesurconge; //"Secablesurconge";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdSecablesurconge = DBPL_V_DB0_TacheVersion_Secablesurconge; //"Secablesurconge";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpSecablesurconge = DBPL_V_DB0_TacheVersion_Secablesurconge; //"Secablesurconge";

         public readonly static string DBPL_V_DB0_TacheVersion_Dureemini = "Durée minimale d'un segment";
         public readonly static string DBPL_V_DB0_TacheVersion_LblDureemini = DBPL_V_DB0_TacheVersion_Dureemini; //"Dureemini";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdDureemini = "Durée mini";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpDureemini = DBPL_V_DB0_TacheVersion_Dureemini; //"Dureemini";

         public readonly static string DBPL_V_DB0_TacheVersion_Debutimperatif = "Début impératif";
         public readonly static string DBPL_V_DB0_TacheVersion_LblDebutimperatif = DBPL_V_DB0_TacheVersion_Debutimperatif; //"Debutimperatif";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdDebutimperatif = DBPL_V_DB0_TacheVersion_Debutimperatif; //"Debutimperatif";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpDebutimperatif = DBPL_V_DB0_TacheVersion_Debutimperatif; //"Debutimperatif";

         public readonly static string DBPL_V_DB0_TacheVersion_Ordre = "Ordre";
         public readonly static string DBPL_V_DB0_TacheVersion_LblOrdre = DBPL_V_DB0_TacheVersion_Ordre; //"Ordre";
         public readonly static string DBPL_V_DB0_TacheVersion_LgdOrdre = DBPL_V_DB0_TacheVersion_Ordre; //"Ordre";
         public readonly static string DBPL_V_DB0_TacheVersion_TtpOrdre = DBPL_V_DB0_TacheVersion_Ordre; //"Ordre";

         public static readonly string DBPL_V_DB0_TacheVersion_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheVersion_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheVersion_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheVersion_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region TacheEmploye

         public readonly static string DBPL_V_DB0_TacheEmploye_Id = "Participant de réunion";
         public readonly static string DBPL_V_DB0_TacheEmploye_LblId = DBPL_V_DB0_TacheEmploye_Id; //"Id_tache";
         public readonly static string DBPL_V_DB0_TacheEmploye_LgdId = DBPL_V_DB0_TacheEmploye_Id; //"Id_tache";
         public readonly static string DBPL_V_DB0_TacheEmploye_TtpId = DBPL_V_DB0_TacheEmploye_Id; //"Id_tache";

         public readonly static string DBPL_V_DB0_TacheEmploye_Object = DBPL_V_DB0_TacheEmploye_Id;
         public readonly static string DBPL_V_DB0_TacheEmploye_ObjectList = "Liste des participants de réunion";
         public readonly static string DBPL_V_DB0_TacheEmploye_TitrePage = "Participants de réunion";
         public static readonly string DBPL_V_DB0_TacheEmploye_HelpPage = "";

         public static readonly string DBPL_V_DB0_TacheEmploye_HlpId = "";
         public static readonly string DBPL_V_DB0_TacheEmploye_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_TacheEmploye_HlpId_employe = "";
         public static readonly string DBPL_V_DB0_TacheEmploye_HlpId_tacheversion = "";
         public static readonly string DBPL_V_DB0_TacheEmploye_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_TacheEmploye_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheEmploye_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheEmploye_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_TacheEmploye_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_TacheEmploye_Id_version = DBPL_V_DB0_Version_Id; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheEmploye_LblId_version = DBPL_V_DB0_Version_LblId; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheEmploye_LgdId_version = DBPL_V_DB0_Version_LgdId; //"Id_version";
         public readonly static string DBPL_V_DB0_TacheEmploye_TtpId_version = DBPL_V_DB0_Version_TtpId; //"Id_version";

         public readonly static string DBPL_V_DB0_TacheEmploye_Id_employe = DBPL_V_DB0_Employe_Id; //"Id_employe";
         public readonly static string DBPL_V_DB0_TacheEmploye_LblId_employe = DBPL_V_DB0_Employe_LblId; //"Id_employe";
         public readonly static string DBPL_V_DB0_TacheEmploye_LgdId_employe = DBPL_V_DB0_Employe_LgdId; //"Id_employe";
         public readonly static string DBPL_V_DB0_TacheEmploye_TtpId_employe = DBPL_V_DB0_Employe_TtpId; //"Id_employe";

         public readonly static string DBPL_V_DB0_TacheEmploye_Id_tacheversion = DBPL_V_DB0_TacheVersion_Id; //"Id_tacheversion";
         public readonly static string DBPL_V_DB0_TacheEmploye_LblId_tacheversion = DBPL_V_DB0_TacheVersion_LblId; //"Id_tacheversion";
         public readonly static string DBPL_V_DB0_TacheEmploye_LgdId_tacheversion = DBPL_V_DB0_TacheVersion_LgdId; //"Id_tacheversion";
         public readonly static string DBPL_V_DB0_TacheEmploye_TtpId_tacheversion = DBPL_V_DB0_TacheVersion_TtpId; //"Id_tacheversion";

         public static readonly string DBPL_V_DB0_TacheEmploye_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheEmploye_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheEmploye_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_TacheEmploye_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion

         #region Qualif

         public readonly static string DBPL_V_DB0_Qualif_Id = "Qualification";
         public readonly static string DBPL_V_DB0_Qualif_LblId = DBPL_V_DB0_Qualif_Id; //"Id";
         public readonly static string DBPL_V_DB0_Qualif_LgdId = DBPL_V_DB0_Qualif_Id; //"Id";
         public readonly static string DBPL_V_DB0_Qualif_TtpId = DBPL_V_DB0_Qualif_Id; //"Id";

         public readonly static string DBPL_V_DB0_Qualif_Object = DBPL_V_DB0_Qualif_Id;
         public readonly static string DBPL_V_DB0_Qualif_ObjectList = "Liste des qualifications";
         public readonly static string DBPL_V_DB0_Qualif_TitrePage = "Qualifications";
         public static readonly string DBPL_V_DB0_Qualif_HelpPage = "";

         public static readonly string DBPL_V_DB0_Qualif_HlpId = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpLogicaldeleted = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_societe = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_application = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_projet = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_action = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_modetravail = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_contrainte = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_statut = "";
         public static readonly string DBPL_V_DB0_Qualif_HlpId_espaceclient = "";

         public readonly static string DBPL_V_DB0_Qualif_Logicaldeleted = Logicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Qualif_LblLogicaldeleted = LblLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Qualif_LgdLogicaldeleted = LgdLogicaldeleted; //"Logicaldeleted";
         public readonly static string DBPL_V_DB0_Qualif_TtpLogicaldeleted = TtpLogicaldeleted; //"Logicaldeleted";

         public readonly static string DBPL_V_DB0_Qualif_Id_contrainte = DBPL_V_DB0_Contrainte_Id; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Qualif_LblId_contrainte = DBPL_V_DB0_Contrainte_LblId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_contrainte = DBPL_V_DB0_Contrainte_LgdId; //"Id_contrainte";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_contrainte = DBPL_V_DB0_Contrainte_TtpId; //"Id_contrainte";

         public readonly static string DBPL_V_DB0_Qualif_Id_societe = DBPL_V_DB0_Societe_Id; //"Id_societe";
         public readonly static string DBPL_V_DB0_Qualif_LblId_societe = DBPL_V_DB0_Societe_LblId; //"Id_societe";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_societe = DBPL_V_DB0_Societe_LgdId; //"Id_societe";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_societe = DBPL_V_DB0_Societe_TtpId; //"Id_societe";

         public readonly static string DBPL_V_DB0_Qualif_Id_application = DBPL_V_DB0_Application_Id; //"Id_application";
         public readonly static string DBPL_V_DB0_Qualif_LblId_application = DBPL_V_DB0_Application_LblId; //"Id_application";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_application = DBPL_V_DB0_Application_LgdId; //"Id_application";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_application = DBPL_V_DB0_Application_TtpId; //"Id_application";

         public readonly static string DBPL_V_DB0_Qualif_Id_projet = DBPL_V_DB0_Projet_Id; //"Id_projet";
         public readonly static string DBPL_V_DB0_Qualif_LblId_projet = DBPL_V_DB0_Projet_LblId; //"Id_projet";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_projet = DBPL_V_DB0_Projet_LgdId; //"Id_projet";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_projet = DBPL_V_DB0_Projet_TtpId; //"Id_projet";

         public readonly static string DBPL_V_DB0_Qualif_Id_modetravail = DBPL_V_DB0_ModeTravail_Id; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Qualif_LblId_modetravail = DBPL_V_DB0_ModeTravail_LblId; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_modetravail = DBPL_V_DB0_ModeTravail_LgdId; //"Id_modetravail";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_modetravail = DBPL_V_DB0_ModeTravail_TtpId; //"Id_modetravail";

         public readonly static string DBPL_V_DB0_Qualif_Id_action = DBPL_V_DB0_Action_Id; //"Id_action";
         public readonly static string DBPL_V_DB0_Qualif_LblId_action = DBPL_V_DB0_Action_LblId; //"Id_action";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_action = DBPL_V_DB0_Action_LgdId; //"Id_action";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_action = DBPL_V_DB0_Action_TtpId; //"Id_action";

         public readonly static string DBPL_V_DB0_Qualif_Id_statut = DBPL_V_DB0_Statut_Id; //"Id_statut";
         public readonly static string DBPL_V_DB0_Qualif_LblId_statut = DBPL_V_DB0_Statut_LblId; //"Id_statut";
         public readonly static string DBPL_V_DB0_Qualif_LgdId_statut = DBPL_V_DB0_Statut_LgdId; //"Id_statut";
         public readonly static string DBPL_V_DB0_Qualif_TtpId_statut = DBPL_V_DB0_Statut_TtpId; //"Id_statut";

         public static readonly string DBPL_V_DB0_Qualif_Id_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Qualif_LblId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Qualif_LgdId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };
         public static readonly string DBPL_V_DB0_Qualif_TtpId_espaceclient = C_Id_espaceclient; //{ "Id_espaceclient" };

         #endregion
 */
    }
}
