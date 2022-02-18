use PL
GO
--DROP VIEW V_DB0_Action
--DROP VIEW V_DB0_Admin
--DROP VIEW V_DB0_AdminVersion
--DROP VIEW V_DB0_Application
--DROP VIEW V_DB0_Calendrier
--DROP VIEW V_DB0_CongeEmploye
--DROP VIEW V_DB0_CongeVersion
DROP VIEW V_DB0_Categorie
DROP VIEW V_DB0_CategorieContrainte
DROP VIEW V_DB0_Contrainte
DROP VIEW V_DB0_Employe
--DROP VIEW V_DB0_Ephemeride
DROP VIEW V_DB0_Equipe
DROP VIEW V_DB0_EquipeEmployeVersion
--DROP VIEW V_DB0_Ferie
--DROP VIEW V_DB0_ModeTravail
--DROP VIEW V_DB0_Planification
DROP VIEW V_DB0_Planning
--DROP VIEW V_DB0_Contrainte
--DROP VIEW V_DB0_Projet
--DROP VIEW V_DB0_Qualif
DROP VIEW V_DB0_Realisation
--DROP VIEW V_DB0_RecapVersion
--DROP VIEW V_DB0_ReunionEmploye
--DROP VIEW V_DB0_ReunionVersion
--DROP VIEW V_DB0_Societe
--DROP VIEW V_DB0_Statut
--DROP VIEW V_DB0_TacheEmploye
--DROP VIEW V_DB0_TacheVersion
DROP view V_DB0_TypeCategorie
DROP VIEW V_DB0_TypeTache
--DROP VIEW V_DB0_UniteHoraire
DROP VIEW V_DB0_Utilisateur
DROP VIEW V_DB0_Version
--DROP VIEW V_PL0_Action
--DROP VIEW V_PL0_Admin
--DROP VIEW V_PL0_Admin_W
--DROP VIEW V_PL0_AdminPlanification
--DROP VIEW V_PL0_Application
--DROP VIEW V_PL0_Calendrier
--DROP VIEW V_PL0_Calendrier_W
--DROP VIEW V_PL0_CalendrierPlanification
--DROP VIEW V_PL0_CongeEmploye
--DROP VIEW V_PL0_CongeEmploye_W
--DROP VIEW V_PL0_CongePlanification
--DROP VIEW V_PL0_CongeVersion
--DROP VIEW V_PL0_CongeVersion_W
DROP VIEW V_PL0_Categorie
DROP VIEW V_PL0_Categorie_W
DROP VIEW V_PL0_CategorieContrainte
DROP VIEW V_PL0_CategorieContrainte_W
DROP VIEW V_PL0_Contrainte
DROP VIEW V_PL0_Contrainte_W
DROP VIEW V_PL0_Employe
DROP VIEW V_PL0_Employe_W
--DROP VIEW V_PL0_Ephemeride
--DROP VIEW V_PL0_Ephemeride_W
DROP VIEW V_PL0_Equipe
DROP VIEW V_PL0_Equipe_W
DROP VIEW V_PL0_EquipeEmployeVersion
DROP VIEW V_PL0_EquipeEmployeVersion_w
--DROP VIEW V_PL0_Ferie
--DROP VIEW V_PL0_Ferie_W
--DROP VIEW V_PL0_FeriePlanification
--DROP VIEW V_PL0_ModeTravail
--DROP VIEW V_PL0_Planification
--DROP VIEW V_PL0_Planification_W
DROP VIEW V_PL0_Planning
--DROP VIEW V_PL0_Projet
DROP VIEW V_PL0_Realisation
DROP VIEW V_PL0_Realisation_W
--DROP VIEW V_PL0_RealisationPlanification
--DROP VIEW V_PL0_RecapPlanification
--DROP VIEW V_PL0_RecapVersion
--DROP VIEW V_PL0_RecapVersion_W
--DROP VIEW V_PL0_ReunionEmploye
--DROP VIEW V_PL0_ReunionEmploye_W
--DROP VIEW V_PL0_ReunionPlanification
--DROP VIEW V_PL0_ReunionVersion
--DROP VIEW V_PL0_ReunionVersion_W
--DROP VIEW V_PL0_Societe
--DROP VIEW V_PL0_Statut
--DROP VIEW V_PL0_TachePlanification
DROP view V_PL0_TypeCategorie
DROP view V_PL0_TypeCategorie_W
DROP VIEW V_PL0_TypeTache
--DROP VIEW V_PL0_UniteHoraire
DROP VIEW V_PL0_Utilisateur
DROP VIEW V_PL0_Utilisateur_W
DROP VIEW V_PL0_Version
DROP VIEW V_PL0_Version_W
DROP VIEW V_PL9_Droits
--DROP VIEW V_PLC_Action
--DROP VIEW V_PLC_Application
--DROP VIEW V_PLC_Employe
--DROP VIEW V_PLC_Equipe
--DROP VIEW V_PLC_ModeTravail
--DROP VIEW V_PLC_Planning
--DROP VIEW V_PLC_Projet
--DROP VIEW V_PLC_Societe
--DROP VIEW V_PLC_Statut
--DROP VIEW V_PLC_TypeTache
--DROP VIEW V_PLC_UniteHoraire
--DROP VIEW V_PLC_Utilisateur
--DROP VIEW V_PLC_Version
--GO
--create view [V_DB0_Action] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_action 
--go
--create view [V_DB0_Admin] as
--SELECT Id, Logicaldeleted, Id_employe,Decalesioccupe, Secable, Dureemini, Debut,Duree,Periode,Fin,Decalagemaxi,Id_espaceclient
--FROM T_Admin
--go
--create view [V_DB0_AdminVersion] as
--SELECT Id, Logicaldeleted, Id_admin, Id_version,Id_espaceclient
--FROM T_AdminVersion
--go
--create view [V_DB0_Application] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Application 
--go
--create view [V_DB0_Calendrier] as
--select Id,Logicaldeleted,Debut,Fin,Periode,Id_equipe,Duree,Id_prevision,Id_espaceclient from t_calendrier
--go
--create view [V_DB0_CongeEmploye] as
--SELECT Id, Logicaldeleted, Id_employe,Id_prevision,Id_espaceclient
--FROM T_CongeEmploye
--go
--create view [V_DB0_CongeVersion] as
--SELECT  Id, Logicaldeleted, Id_congeemploye, Id_version, Debut, Fin,Id_espaceclient
--FROM T_CongeVersion
go
CREATE VIEW V_DB0_Categorie as
SELECT Id,Logicaldeleted,Id_espaceclient,Id_typecategorie,Libelle,Ordreaff,Id_mere from t_categorie
go
CREATE VIEW V_DB0_CategorieContrainte as
SELECT Id,Logicaldeleted,Id_espaceclient,Id_categorie,Id_contrainte from t_categorieContrainte
go
create view [dbo].[V_DB0_Contrainte] as
SELECT Id,Logicaldeleted,Id_espaceclient,Id_planning,Ref,Abreviation,Libelle,Commentaire,Id_typecontrainte,Realisee
FROM  T_Contrainte
GO
create view [V_DB0_Employe] as
select Id,Logicaldeleted,Initiales,Id_planning,Id_espaceclient,Nom,Prenom,Feminin,Id_utilisateur from t_Employe 
go
--create view [V_DB0_Ephemeride] as
--SELECT Id, Logicaldeleted, Id_planning, Id_version, Id_employe, Debut, Duree, Id_type, Id_prevision,Id_espaceclient
--FROM T_Ephemeride
go
create view [V_DB0_Equipe] as
select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_equipe
go
create view [V_DB0_EquipeEmployeVersion] as
select Id,Logicaldeleted,Id_version,Id_equipe,Id_employe,Id_espaceclient from t_EquipeEmployeVersion
go
--create view [V_DB0_Ferie] as
--SELECT Id, Logicaldeleted, Debut, Duree,Id_prevision,Id_espaceclient
--FROM T_Ferie
--go
--create view [V_DB0_ModeTravail] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_ModeTravail 
--go
--create view [V_DB0_Planification] as
--SELECT Id, Logicaldeleted, Info, Debutcalc, Fincalc, Dureecalc, Debutreal, Finreal, Dureereal,Id_prevision,Id_version,Id_employe,Prevision,Id_espaceclient
--FROM T_Planification
go
create view [V_DB0_Planning] as
select Id,Logicaldeleted,Libelle,Abreviation,Debut,Fin,Id_espaceclient from t_planning
go
--create view [V_DB0_Projet] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Projet 
--go
--create view [dbo].[V_DB0_Qualif] as
--SELECT Id, Logicaldeleted, Id_societe, Id_application, Id_projet, Id_action, Id_modetravail, Id_prevision, Id_statut,Id_espaceclient
--FROM T_Qualif
go
create view [V_DB0_Realisation] as
SELECT Id,Debut,Id_employe,Duree,Logicaldeleted,Id_espaceclient,Id_contrainterealisee,Id_contrainte
FROM T_Realisation
go
--create view [V_DB0_RecapVersion] as 
--SELECT  Id, Logicaldeleted, Id_previsionrecap, Id_version, Id_prevision,Id_espaceclient
--FROM T_recapVersion
--go
--create view [V_DB0_ReunionEmploye] as
--SELECT   Id, Logicaldeleted, Id_employe, Id_reunionversion,Id_espaceclient
--FROM  T_ReunionEmploye
--go
--create view [V_DB0_ReunionVersion] as
--SELECT Id, Logicaldeleted, Debut, Duree, Id_prevision, Id_version,Id_espaceclient
--FROM  T_ReunionVersion
--go
--create view [V_DB0_Societe] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Societe 
--go
--create view [V_DB0_Statut] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_statut 
--go
--create view [V_DB0_TacheEmploye] as
--SELECT Id, Logicaldeleted, Id_employe, Id_tacheversion,Id_espaceclient
--FROM T_TacheEmploye
--go
--create view [V_DB0_TacheVersion] as
--SELECT Id, Logicaldeleted, Id_version, Debut, Duree, Secable, Secablesurconge, Dureemini, Debutimperatif, Ordre, Id_prevision,Id_espaceclient
--FROM T_TacheVersion
go
create view [V_DB0_TypeCategorie] as
select Id,Logicaldeleted,Id_espaceclient,Id_planning,Id_mere,Libelle from t_TypeCategorie
go
create view [V_DB0_TypeTache] as
select Id,Logicaldeleted,Libelle,Id_espaceclient from t_TypeTache
go
--create view [V_DB0_UniteHoraire] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_espaceclient from t_UniteHoraire
go
create view [V_DB0_Utilisateur] as
select Id,Logicaldeleted,Modif,Id_espaceclient,Nom,Prenom,Feminin from t_utilisateur
go
create view [V_DB0_Version] as
SELECT Id, Logicaldeleted, Libelle, Id_planning, Abreviation, Figee,Id_espaceclient
FROM T_Version
go
--create view [V_PL0_Action] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_action 
--go
--create view [V_PL0_Admin] as
--SELECT  a.Id,a.Logicaldeleted,a.Id_employe,a.Decalesioccupe,a.Secable,a.Dureemini,a.Debut,a.Duree,a.Periode,a.Fin,a.Decalagemaxi,a.Id_espaceclient,
--pr.Id_planning,pr.Libelle,pr.Ref,pr.Commentaire
--FROM T_Admin a
--left outer join t_contrainte pr on pr.Id=a.Id
--go
--create view [V_PL0_Admin_W] as
--SELECT  a.Id,a.Logicaldeleted,a.Id_employe,a.Decalesioccupe,a.Secable,a.Dureemini,a.Debut,a.Duree,a.Periode,a.Fin,a.Decalagemaxi,Id_espaceclient FROM T_Admin a
--go
--create view [dbo].[V_PL0_AdminPlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,a.Debut,a.Duree,a.Decalesioccupe,a.Fin,a.Periode,a.Secable,a.Dureemini,a.Decalagemaxi,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join T_admin a on a.Id=pr.Id and a.Id_employe=pl.Id_employe and a.Logicaldeleted=0
--where pl.Prevision=1
--go
--create view [V_PL0_Application] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Application 
--go
--create view [V_PL0_Calendrier] as
--select c.Id,c.Logicaldeleted,c.Debut,c.Fin,c.Periode,c.Id_equipe,c.Duree ,c.Id_prevision,c.Id_espaceclient,
--pp.Libelle,pp.Id_planning
--from t_calendrier c
--left outer join t_prevision pp on pp.Id=c.Id
--go
--create view [V_PL0_Calendrier_W] as
--select Id,c.Logicaldeleted,c.Debut,c.Fin,c.Periode,c.Id_equipe,c.Duree ,c.Id_prevision,Id_espaceclient
--from t_calendrier c
--go
--create view [dbo].[V_PL0_CalendrierPlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,f.Debut,f.Duree,f.Fin,f.Periode,pr.Id_planning,ee.Id_equipe
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_Calendrier f on f.Id_prevision=pr.Id
--inner join T_EquipeEmploye ee on ee.Id_version=pl.Id_version and ee.Id_employe=pl.Id_employe and f.Id_equipe=ee.Id_equipe
--where pl.Prevision=1
--go
--create view [V_PL0_CongeEmploye] as
--SELECT c.Id,C.Logicaldeleted,C.Id_employe,C.Id_prevision,c.Id_espaceclient,
--pp.Libelle,pp.Id_planning,pp.Commentaire,pp.Ref,
--e.Identite as Ident_employe,e.Initiales as Init_employe
--FROM T_Congeemploye C
--left outer join t_prevision  pp on pp.Id=c.Id_prevision
--left outer join t_employe e on e.Id=c.Id_employe
--go
--create view [V_PL0_CongeEmploye_W] as
--SELECT c.Id,C.Logicaldeleted,C.Id_employe,C.Id_prevision,Id_espaceclient
--FROM T_CongeEmploye C
--go
--create view [V_PL0_CongePlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,cv.Debut,cv.Fin,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_congeemploye ce on ce.Id_prevision=pr.Id and ce.Id_employe=pl.Id_employe
--inner join t_congeversion cv on cv.Id_congeemploye=ce.Id and cv.Id_version=pl.Id_version
--where pl.Prevision=1
--go
--create view [V_PL0_CongeVersion] as
--SELECT  c.Id,c.Logicaldeleted,c.Id_congeemploye,c.Id_version,c.Debut,c.Fin,c.Id_espaceclient,
--pl.Info,pl.Finreal,pl.Dureereal,pl.Debutreal,
--g.Id_employe,
--v.Libelle as Lib_version,v.Abreviation as Abr_version
--FROM T_CongeVersion c
--left outer join t_version v on v.Id=c.Id_version
--left outer join T_CongeEmploye g on g.Id=c.Id_congeemploye
--left outer join t_prevision pr on pr.Id=g.Id_prevision
--left outer join T_Planification pl on pl.Id_prevision=pr.Id and pl.Id_employe=g.Id_employe and pl.Id_version=c.Id_version and Prevision=1
--go
--create view [V_PL0_CongeVersion_W] as
--SELECT  c.Id,c.Logicaldeleted,c.Id_congeemploye,c.Id_version,c.Debut,c.Fin,Id_espaceclient
--FROM T_CongeVersion c
go
create view [V_PL0_Categorie_W] as
select C.Id,C.Logicaldeleted,C.Id_espaceclient,C.Id_typecategorie,C.Id_mere,C.Libelle,c.Ordreaff from t_Categorie c
go
create view [V_PL0_Categorie] as
select C.Id,C.Logicaldeleted,C.Id_espaceclient,C.Id_typecategorie,C.Id_mere,C.Libelle,c.Ordreaff,
tC.Id_planning,TC.libelle as Lib_typecategorie,
p.libelle as Lib_planning,p.abreviation as Abr_planning,
m.libelle as Lib_mere
from t_Categorie c left join t_typecategorie tc on tc.id=c.id_typecategorie left join t_planning p on p.id=tC.id_planning
left join t_categorie m on m.Id=C.id_mere
go
CREATE VIEW V_PL0_CategorieContrainte as
SELECT cc.Id,cc.Logicaldeleted,cc.Id_espaceclient,cc.Id_categorie,cc.Id_contrainte,
c.libelle as Lib_categorie,
tc.libelle as Lib_typecategorie,tc.Id_planning,
p.libelle as Lib_planning,p.abreviation as Abr_planning,
ct.ref as Ref_contrainte,ct.libelle as Lib_contrainte,ct.commentaire as Comm_contrainte,ct.Id_typecontrainte,ct.abreviation as Abr_contrainte,ct.Realisee as Contrainterealisee,
tt.libelle as Lib_typecontrainte
from t_categorieContrainte cc
left join t_categorie c on c.id=cc.id_categorie
left join t_typecategorie tc on tc.id=c.id_typecategorie
left join t_contrainte ct on ct.id=cc.id_contrainte
left join t_planning p on p.id=ct.id_planning
left join t_typetache tt on tt.id=ct.id_typecontrainte
go
CREATE VIEW V_PL0_CategorieContrainte_W as
SELECT Id,Logicaldeleted,Id_espaceclient,Id_categorie,Id_contrainte from t_categorieContrainte
go
create view [dbo].[V_PL0_Contrainte_W] as
SELECT C.Id,C.Logicaldeleted,C.Id_espaceclient,C.Id_planning,C.Ref,C.Abreviation,C.Libelle,C.Commentaire,C.Id_typecontrainte,C.Realisee
FROM  T_Contrainte C
go
create view [dbo].[V_PL0_Contrainte] as
SELECT C.Id,C.Logicaldeleted,C.Id_espaceclient,C.Id_planning,C.Ref,C.Abreviation,C.Libelle,C.Commentaire,C.Id_typecontrainte,C.Realisee,
P.abreviation AS Abr_planning, P.Libelle as Lib_planning,TT.libelle as Lib_typecontrainte
FROM  T_Contrainte C left join t_planning p on p.id=C.id_planning left join T_TypeTache TT on TT.id=C.id_typecontrainte
go
create view [V_PL0_Employe_W] as
select Id,Logicaldeleted,Initiales,Id_planning,Id_espaceclient,Nom,Prenom,Feminin,Id_utilisateur from t_Employe 
go
create view [V_PL0_Employe] as
select e.Id,e.Logicaldeleted,e.Initiales,e.Id_planning,e.Id_espaceclient,e.Nom,e.Prenom,e.Feminin,e.Id_utilisateur,
coalesce(e.Prenom + ' ','') + e.Nom as Identite,p.libelle as Lib_planning, p.abreviation as Abr_planning
from t_Employe e left join t_planning p on p.id=e.id_planning
go
--create view [V_PL0_Ephemeride] as
--SELECT e.Id,e.Logicaldeleted,e.Id_planning,e.Id_version,e.Id_employe,e.Debut,e.Duree,e.Id_type,e.Id_prevision,e.Id_espaceclient,
--v.Abreviation as Abr_version,v.Libelle as Lib_version,
--em.Identite as Ident_employe,em.Initiales as Init_employe,
--tt.Abreviation as Abr_type,tt.Libelle as Lib_type,
--pr.Libelle,x.Debut as Debutprevision,x.Duree as Dureeprevision,x.Fin as Finprevision
----x.Info,x.Ref,x.Commentaire,x.Debutcalc,x.Fincalc,x.Debutreal,x.Finreal,x.Dureecalc,x.Dureereal,
----x.Id_statut,x.Id_societe,x.Id_application,x.Id_action,x.Id_modetravail,x.Id_projet,
----x.Abr_statut,x.Lib_statut,
----x.Abr_societe,x.Lib_societe,
----x.Abr_application,x.Lib_application,
----x.Abr_action,x.Lib_action,
----x.Abr_modetravail,x.Lib_modetravail,
----x.Abr_projet,x.Lib_projet 
--FROM T_Ephemeride e
--left outer join t_version v on v.Id=e.Id_version
--left outer join t_employe em on em.Id=e.Id_employe
--left outer join t_typetache tt on tt.Id=e.Id_type
--left outer join T_Planification pl on pl.Id_prevision=e.Id_prevision and pl.Id_employe=e.Id_employe and pl.Id_version=e.Id_version and pl.Logicaldeleted=0 and pl.Prevision=1
--left outer join t_prevision pr on pr.Id=pl.Id_prevision
--left outer join 
--(select ce.Id_prevision,cv.Debut,cv.Fin,cast(null as int)as Duree 
--from T_CongeVersion cv inner join T_Congeemploye ce on cv.Id=cv.Id_congeemploye  where ce.Id>0
--union 
--select Id_prevision,Debut,null as Fin, Duree from t_calendrier where Id>0
--union
--select Id_prevision,Debut,null as Fin,Duree from t_ferie where Id>0
--union
--select Id_prevision,Debut,null,Duree from t_realisation where Id>0
--union
--select rv.Id_prevision,rv.Debut,null as Fin, rv.Duree from t_reunionemploye re inner join t_reunionversion rv on rv.Id=re.Id_reunionversion where re.Id>0
--union
--select tv.Id_prevision,tv.Debut,null as Fin, tv.Duree from t_tacheemploye te inner join t_tacheversion tv on tv.Id=te.Id_tacheversion where te.Id>0
--)x on x.Id_prevision=pr.Id
--go
--create view [V_PL0_Ephemeride_W] as
--SELECT e.Id,e.Logicaldeleted,e.Id_planning,e.Id_version,e.Id_employe,e.Debut,e.Duree,e.Id_type,e.Id_prevision,Id_espaceclient
--FROM T_Ephemeride e
go
create view [dbo].[V_PL0_Equipe] as
select e.Id,e.Logicaldeleted,e.Libelle,e.Abreviation,e.Id_planning,e.Id_espaceclient,p.Libelle as Lib_planning,p.abreviation as Abr_planning,
p.Libelle+'-'+e.libelle as Lib_planning_equipe,p.abreviation+'-'+e.Abreviation as Abr_planning_equipe
from t_Equipe e left outer join t_planning p on p.Id=e.Id_planning
go
create view [V_PL0_Equipe_W] as
select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Equipe
go
create view [V_PL0_EquipeEmployeVersion] as
select e.Id,e.Logicaldeleted,e.Id_version,e.Id_equipe,e.Id_employe,e.Id_espaceclient,
v.Id_planning,p.Libelle as Lib_planning,p.abreviation as Abr_planning,
em.nom as Nom_employe,em.prenom as Prenom_employe,em.Feminin as Feminin_employe,coalesce(em.Prenom + ' ','') + em.Nom  as Ident_employe,em.Initiales as Init_employe,
eq.Abreviation as Abr_equipe,eq.Libelle as Lib_equipe,
p.Libelle+'-'+eq.libelle as Lib_planning_equipe,p.abreviation+'-'+eq.Abreviation as Abr_planning_equipe,
v.Abreviation as Abr_version,v.Libelle as Lib_version,
p.Libelle+'-'+v.libelle as Lib_planning_version,p.abreviation+'-'+v.Abreviation as Abr_planning_version
from t_EquipeEmployeVersion e
left outer join t_employe em on em.Id=e.Id_employe
left outer join t_equipe eq on eq.Id=e.Id_equipe
left outer join t_version v on v.Id=e.Id_version
left outer join t_planning p on p.id=v.id_planning
go
create view [V_PL0_EquipeEmployeVersion_W] as
select e.Id,e.Logicaldeleted,e.Id_version,e.Id_equipe,e.Id_employe,Id_espaceclient
from t_EquipeEmployeVersion e
go
--create view [V_PL0_Ferie] as
--SELECT f.Id, f.Logicaldeleted, f.Debut, f.Duree,f.Id_prevision,f.Id_espaceclient,
--pr.Libelle,  pr.Id_planning, pr. Ref, pr.Commentaire
--FROM T_Ferie f
--left outer join t_prevision pr on pr.Id=f.Id_prevision
--left outer join T_Planification pl on pl.Id_prevision=pr.Id and pl.Prevision=1
--go
--create view [V_PL0_Ferie_W] as
--SELECT f.Id, f.Logicaldeleted, f.Debut, f.Duree,f.Id_prevision,Id_espaceclient
--FROM T_Ferie f
--go
--create view [V_PL0_FeriePlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,f.Debut,f.Duree,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_ferie f on f.Id_prevision=pr.Id
--where pl.Prevision=1
--go
--create view [V_PL0_ModeTravail] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_ModeTravail 
--go
--create view [V_PL0_Planification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--a.Debut,a.Fin,tt.Libelle as Lib_type,tt.Abreviation as Abr_type,pr.Libelle,pr.Id_typetache,a.Duree,e.Identite as Ident_employe,e.Initiales as Init_employe,
--v.Libelle as Lib_version
--FROM T_Planification pl
--left outer join t_prevision pr on pr.Id=pl.Id_prevision 
--left outer join t_typetache tt on tt.Id=pr.Id_typetache
--left outer join t_employe e on e.Id=pl.Id_employe
--left outer join t_version v on v.Id=pl.Id_version
--inner join 
--(select ce.Id_prevision,cv.Id_version,ce.Id_employe,cv.Debut,cv.Fin,cast(null as int) as Duree 
--from T_CongeEmploye ce inner join t_congeversion cv on cv.Id_congeemploye=ce.Id where ce.Id>0
--union
--select rv.Id_prevision,rv.Id_version,re.Id_employe,rv.Debut,null as Fin,rv.Duree 
--from  t_reunionversion rv
--inner join t_reunionemploye re on re.Id_reunionversion=rv.Id and re.Logicaldeleted=0
--where rv.Id>0
--union
--select tv.Id_prevision,tv.Id_version,te.Id_employe,tv.Debut,null as Fin,tv.Duree 
--from  t_tacheversion tv 
--inner join t_tacheemploye te on te.Id_tacheversion=tv.Id and te.Logicaldeleted=0
--where tv.Id>0
--union
--select c.Id_prevision,ee.Id_version,ee.Id_employe,c.Debut,null,c.Duree 
--from t_calendrier c left outer join T_EquipeEmploye ee on ee.Id_equipe=c.Id_equipe where c.Id>0
--union
--select f.Id_prevision, ve.Id,-1,f.Debut,null,f.Duree
--from t_ferie f left outer join t_prevision pr on pr.Id=f.Id_prevision 
--left outer join t_version ve on ve.Id_planning=pr.Id_planning and ve.Logicaldeleted=0 left outer join t_employe e on e.Id_planning=pr.Id_planning and e.Logicaldeleted=0 where f.Id>0
--union 
--select Id_prevision,ve.Id,Id_employe,Debut,Duree,null from t_realisation r 
--left outer join t_prevision pr on pr.Id=r.Id_prevision left outer join t_version ve on ve.Id_planning=pr.Id_planning and ve.Logicaldeleted=0
-- )a
--on a.Id_prevision=pr.Id and pl.Id_version=a.Id_version and a.Id_employe=pl.Id_employe
--go
--create view [V_PL0_Planification_W] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision
--FROM T_Planification pl
go
create view [V_PL0_Planning] as
select Id,Logicaldeleted,Libelle,Abreviation,Debut,Fin,Id_espaceclient from t_planning
go
--create view [V_PL0_Projet] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Projet 
go
create view [V_PL0_Realisation] as
SELECT r.Id,r.Debut,r.Id_employe,r.Duree,r.Logicaldeleted,r.Id_espaceclient,r.Id_contrainterealisee,r.Id_contrainte,
c.Id_planning,c.Ref,c.Abreviation,c.Libelle,c.Commentaire,c.Id_typecontrainte,c.Realisee,
TT.libelle as Lib_typecontrainte,
P.Abreviation as Abr_planning,P.Libelle as Lib_planning
from T_Realisation r left join t_Contrainte c on c.id=r.id left join T_Typetache TT on TT.id=C.id_typecontrainte left join t_planning P on P.id=C.id_planning
go
create view [V_PL0_Realisation_W] as
SELECT r.Id,r.Debut,r.Id_employe,r.Duree,r.Logicaldeleted,r.Id_espaceclient,r.Id_contrainterealisee,r.Id_contrainte
from T_Realisation r 
go
--create view [dbo].[V_PL0_RealisationPlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,r.Debut,r.Duree,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_Realisation r on pr.Id=r.Id_prevision  and r.Id_employe=pl.Id_employe
--where pl.Prevision=1
--go
--create view [dbo].[V_PL0_RecapPlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join T_recapversion rv on rv.Id_prevision=pr.Id and rv.Id_version=pl.Id_version and rv.Logicaldeleted=0
--where pl.Prevision=1
--go
--create view [V_PL0_RecapVersion] as 
--SELECT  r.Id,R.Logicaldeleted,R.Id_previsionrecap,R.Id_version,R.Id_prevision,r.Id_espaceclient,
--pr.Libelle,pr.Id_planning,pr.Ref,pr.Commentaire
--FROM T_recapVersion r
--left outer join t_prevision pr on pr.Id=r.Id_previsionrecap
--go
--create view [V_PL0_RecapVersion_W] as 
--SELECT  r.Id,R.Logicaldeleted,R.Id_previsionrecap,R.Id_version,R.Id_prevision,Id_espaceclient
--FROM T_recapversion r
--go
--create view [V_PL0_ReunionEmploye] as
--SELECT  re.Id,re.Logicaldeleted,re.Id_employe,re.Id_reunionversion,re.Id_espaceclient,
--pl.Info,pl.Debutcalc,pl.Fincalc,pl.Debutreal,pl.Finreal,pl.Dureecalc,pl.Dureereal,
--rv.Debut,rv.Duree,
--e.Initiales as Init_employe,e.Identite as Ident_employe
--FROM  T_ReunionEmploye re
--left outer join t_employe e on e.Id=re.Id_employe
--left outer join T_ReunionVersion rv on re.Id_reunionversion=rv.Id
--left outer join T_Planification pl on pl.Id_prevision=rv.Id_prevision and pl.Id_employe=re.Id_employe and pl.Id_version=rv.Id_version
--go
--create view [V_PL0_ReunionEmploye_W] as
--SELECT  re.Id,re.Logicaldeleted,re.Id_employe,re.Id_reunionversion,Id_espaceclient
--FROM  T_ReunionEmploye re
--go
--create view [V_PL0_ReunionPlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,cv.Debut,cv.Duree,pr.Id_planning
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_Reunionversion cv on cv.Id_prevision=pr.Id and cv.Id_version=pl.Id_version and cv.Logicaldeleted=0
--inner join t_Reunionemploye ce on ce.Id_reunionversion=cv.Id and ce.Id_employe=pl.Id_employe
--where pl.Prevision=1
--go
--create view [V_PL0_ReunionVersion] as
--SELECT rv.Id,rv.Logicaldeleted,rv.Debut,rv.Duree,rv.Id_prevision,rv.Id_version,rv.Id_espaceclient,
--v.Libelle as Lib_version,v.Abreviation as Abr_version
--FROM  T_ReunionVersion rv
--left outer join t_version v on v.Id=rv.Id_version
--go
--create view [V_PL0_ReunionVersion_W] as
--SELECT rv.Id,rv.Logicaldeleted,rv.Debut,rv.Duree,rv.Id_prevision,rv.Id_version,Id_espaceclient
--FROM  T_ReunionVersion rv
--go
--create view [V_PL0_Societe] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Societe 
--go
--create view [V_PL0_Statut] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_statut 
--go
--create view [V_PL0_TachePlanification] as
--SELECT pl.Id,pl.Logicaldeleted,pl.Info,pl.Debutcalc,pl.Fincalc,pl.Dureecalc,pl.Debutreal,pl.Finreal,pl.Dureereal,pl.Id_prevision,pl.Id_version,pl.Id_employe,pl.Prevision,pl.Id_espaceclient,
--pr.Id_typetache,cv.Debut,cv.Duree,pr.Id_planning,cv.Ordre,cv.Secable,cv.Secablesurconge,cv.Dureemini
--FROM T_Planification pl
--inner join t_prevision pr on pr.Id=pl.Id_prevision
--inner join t_Tacheversion cv on cv.Id_prevision=pr.Id and cv.Id_version=pl.Id_version 
--inner join t_Tacheemploye ce on ce.Id_tacheversion=cv.Id and ce.Id_employe=pl.Id_employe
--where pl.Prevision=1
go
create view [V_PL0_TypeCategorie_W] as
select t.Id,t.Logicaldeleted,t.Id_espaceclient,t.Id_planning,t.Id_mere,t.Libelle from t_TypeCategorie t
go
create view [V_PL0_TypeCategorie] as
select t.Id,t.Logicaldeleted,t.Id_espaceclient,t.Id_planning,t.Id_mere,t.Libelle,
p.libelle as Lib_planning,p.abreviation as Abr_planning,
m.libelle as Lib_mere
from t_TypeCategorie t left join t_planning p on p.id=t.id_planning
left join t_typecategorie m on m.Id=t.id_mere
go
create view [V_PL0_TypeTache] as
select Id,Logicaldeleted,Libelle,Id_espaceclient from t_TypeTache
go
--create view [V_PL0_UniteHoraire] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_espaceclient from t_UniteHoraire
go
create view [V_PL0_Utilisateur_W] as
select Id,Logicaldeleted,Modif,Id_espaceclient,Nom,Prenom,Feminin from t_utilisateur
go
create view [V_PL0_Utilisateur] as
select Id,Logicaldeleted,Modif,Id_espaceclient,Nom,Prenom,Feminin,coalesce(prenom+' ','')+nom as Identite from t_utilisateur
go
create view [V_PL0_Version] as
SELECT v.Id, v.Logicaldeleted, v.Libelle, v.Id_planning, v.Abreviation, v.Figee,v.Id_espaceclient,P.Debut,p.Fin,
p.libelle as Lib_planning,p.abreviation as Abr_planning,
p.libelle+'-'+v.libelle as Lib_planning_version,p.abreviation+'-'+v.abreviation as Abr_planning_version
FROM T_Version v left outer join t_planning p on p.Id=v.Id_planning
go
create view [V_PL0_Version_W] as
SELECT Id, Logicaldeleted, Libelle, Id_planning, Abreviation, Figee,Id_espaceclient
FROM T_Version
go
create view [V_PL9_Droits] as
select Id,Logicaldeleted,Modif,Id_espaceclient,Nom,Prenom,Feminin,coalesce(prenom+' ','')+nom as Identite from t_utilisateur where Logicaldeleted=0
go
--create view [V_PLC_Action] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_action where Logicaldeleted=0
--go
--create view [V_PLC_Application] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Application where Logicaldeleted=0
--go
--create view [V_PLC_Employe] as
--select Id,Logicaldeleted,Initiales,Identite,Id_planning,Id_espaceclient from t_Employe where Logicaldeleted=0
--go
--create view [V_PLC_Equipe] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Equipe where Logicaldeleted=0
--go
--create view [V_PLC_ModeTravail] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_ModeTravail  where Logicaldeleted=0
--go
--create view [V_PLC_Planning] as
--select Id,Logicaldeleted,Libelle,Abreviation,Debut,Fin,Id_espaceclient from t_planning where Logicaldeleted=0
--go
--create view [V_PLC_Projet] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Projet  where Logicaldeleted=0
--go
--create view [V_PLC_Societe] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_Societe  where Logicaldeleted=0
--go
--create view [V_PLC_Statut] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_planning,Id_espaceclient from t_statut  where Logicaldeleted=0
--go
--create view [V_PLC_TypeTache] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_espaceclient from t_TypeTache where Logicaldeleted=0
--go
--create view [V_PLC_UniteHoraire] as
--select Id,Logicaldeleted,Libelle,Abreviation,Id_espaceclient from t_UniteHoraire where Logicaldeleted=0
--go
--create view [V_PLC_Utilisateur] as
--select Id,Logicaldeleted,Pt_visu,Pt_modif,Identite,Id_espaceclient from t_utilisateur where Logicaldeleted=0
--go
--create view [V_PLC_Version] as
--SELECT Id, Logicaldeleted, Libelle, Id_planning, Abreviation, Figee,Id_espaceclient
--FROM T_Version
--go

