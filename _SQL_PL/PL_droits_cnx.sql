use PL
GO
--SELECT * from voirvues('F_','')
--union
--SELECT * from voirvues('V_','')
--union
--SELECT * from voirvues('W_','')
--go
--grant select,insert,update to cnx on
--grant select to cnx on
drop user cnx
create user cnx
alter user cnx with login=cnx
grant references to cnx
go
--grant select,insert,update on V_DB0_Action to cnx
--grant select,insert,update on V_DB0_Admin to cnx
--grant select,insert,update on V_DB0_AdminVersion to cnx
--grant select,insert,update on V_DB0_Application to cnx
--grant select,insert,update on V_DB0_Calendrier to cnx
--grant select,insert,update on V_DB0_CongeEmploye to cnx
--grant select,insert,update on V_DB0_CongeVersion to cnx
grant select,insert,update on V_DB0_Contrainte to cnx
grant select,insert,update on V_DB0_CategorieContrainte to cnx
grant select,insert,update on V_DB0_Contrainte to cnx
grant select,insert,update on V_DB0_Employe to cnx
--grant select,insert,update on V_DB0_Ephemeride to cnx
grant select,insert,update on V_DB0_Equipe to cnx
--grant select,insert,update on V_DB0_EquipeEmploye to cnx
--grant select,insert,update on V_DB0_Ferie to cnx
--grant select,insert,update on V_DB0_ModeTravail to cnx
--grant select,insert,update on V_DB0_Planification to cnx
grant select,insert,update on V_DB0_Planning to cnx
--grant select,insert,update on V_DB0_Projet to cnx
--grant select,insert,update on V_DB0_Qualif to cnx
grant select,insert,update on V_DB0_Realisation to cnx
--grant select,insert,update on V_DB0_RecapVersion to cnx
--grant select,insert,update on V_DB0_ReunionEmploye to cnx
--grant select,insert,update on V_DB0_ReunionVersion to cnx
--grant select,insert,update on V_DB0_Societe to cnx
--grant select,insert,update on V_DB0_Statut to cnx
--grant select,insert,update on V_DB0_TacheEmploye to cnx
--grant select,insert,update on V_DB0_TacheVersion to cnx
grant select,insert,update on V_DB0_TypeCategorie to cnx
grant select,insert,update on V_DB0_TypeTache to cnx
--grant select,insert,update on V_DB0_UniteHoraire to cnx
grant select,insert,update on V_DB0_Utilisateur to cnx
grant select,insert,update on V_DB0_Version to cnx
--grant select,insert,update on V_PL0_Action to cnx
--grant select,insert,update on V_PL0_Admin_W to cnx
--grant select,insert,update on V_PL0_AdminPlanification to cnx
--grant select,insert,update on V_PL0_Application to cnx
--grant select,insert,update on V_PL0_Calendrier_W to cnx
--grant select,insert,update on V_PL0_CalendrierPlanification to cnx
--grant select,insert,update on V_PL0_CongeEmploye_W to cnx
--grant select,insert,update on V_PL0_CongePlanification to cnx
--grant select,insert,update on V_PL0_CongeVersion_W to cnx
grant select,insert,update on V_PL0_Categorie_W to cnx
grant select,insert,update on V_PL0_CategorieContrainte_W to cnx
grant select,insert,update on V_PL0_Contrainte_W to cnx
grant select,insert,update on V_PL0_Employe_W to cnx
--grant select,insert,update on V_PL0_Ephemeride_W to cnx
grant select,insert,update on V_PL0_Equipe_W to cnx
grant select,insert,update on V_PL0_EquipeEmployeVersion_w to cnx
--grant select,insert,update on V_PL0_Ferie_W to cnx
--grant select,insert,update on V_PL0_FeriePlanification to cnx
--grant select,insert,update on V_PL0_ModeTravail to cnx
--grant select,insert,update on V_PL0_Planification_W to cnx
grant select,insert,update on V_PL0_Planning to cnx
--grant select,insert,update on V_PL0_Projet to cnx
grant select,insert,update on V_PL0_Realisation_W to cnx
--grant select,insert,update on V_PL0_RealisationPlanification to cnx
--grant select,insert,update on V_PL0_RecapPlanification to cnx
--grant select,insert,update on V_PL0_RecapVersion_W to cnx
--grant select,insert,update on V_PL0_ReunionEmploye_W to cnx
--grant select,insert,update on V_PL0_ReunionPlanification to cnx
--grant select,insert,update on V_PL0_ReunionVersion_W to cnx
--grant select,insert,update on V_PL0_Societe to cnx
--grant select,insert,update on V_PL0_Statut to cnx
--grant select,insert,update on V_PL0_TachePlanification to cnx
grant select,insert,update on V_PL0_TypeCategorie_W to cnx
grant select,insert,update on V_PL0_TypeTache to cnx
--grant select,insert,update on V_PL0_UniteHoraire to cnx
grant select,insert,update on V_PL0_Utilisateur_W to cnx
grant select,insert,update on V_PL0_Version_W to cnx
grant select on V_PL9_Droits to cnx
--grant select on V_PLC_Action to cnx
--grant select on V_PLC_Application to cnx
--grant select on V_PLC_Employe to cnx
--grant select on V_PLC_Equipe to cnx
--grant select on V_PLC_ModeTravail to cnx
--grant select on V_PLC_Planning to cnx
--grant select on V_PLC_Projet to cnx
--grant select on V_PLC_Societe to cnx
--grant select on V_PLC_Statut to cnx
--grant select on V_PLC_TypeTache to cnx
--grant select on V_PLC_UniteHoraire to cnx
--grant select on V_PLC_Utilisateur to cnx
--grant select on V_PLC_Version to cnx
----grant select on V_PLG_Prevision to cnx
--grant select on V_PL0_Admin to cnx
--grant select on V_PL0_Calendrier to cnx
--grant select on V_PL0_CongeEmploye to cnx
--grant select on V_PL0_CongeVersion to cnx
grant select on V_PL0_Categorie to cnx
grant select on V_PL0_CategorieContrainte to cnx
grant select on V_PL0_Contrainte to cnx
grant select on V_PL0_Employe to cnx
--grant select on V_PL0_Ephemeride to cnx
grant select on V_PL0_Equipe to cnx
grant select on V_PL0_EquipeEmployeVersion to cnx
--grant select on V_PL0_Ferie to cnx
--grant select on V_PL0_Planification to cnx
grant select on V_PL0_Realisation to cnx
--grant select on V_PL0_RecapVersion to cnx
--grant select on V_PL0_ReunionEmploye to cnx
--grant select on V_PL0_ReunionVersion to cnx
grant select on V_PL0_TypeCategorie to cnx
grant select on V_PL0_Utilisateur to cnx
grant select on V_PL0_Version to cnx
--go
grant references on type::foreignkey to cnx
grant references on type::foreignkeybig to cnx
grant references on type::foreignkeysmall to cnx
grant references on type::foreignkeytiny to cnx
grant references on type::primarykey to cnx
grant references on type::primarykeybig to cnx
grant references on type::primarykeysmall to cnx
grant references on type::primarykeytiny to cnx
grant references on type::argent to cnx
go
