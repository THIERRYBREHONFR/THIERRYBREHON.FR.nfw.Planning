USE [PL]
GO

---admin
exec sp_unbindefault 't_admin.id_prevision'
alter TABLE [dbo].[T_Admin] drop column id_prevision
go
ALTER TABLE [dbo].[T_Admin]  WITH CHECK ADD  CONSTRAINT [FK_t_Admin_t_Contrainte] FOREIGN KEY([id])
REFERENCES [dbo].[T_Contrainte] ([Id])
ALTER TABLE [dbo].[T_Admin] CHECK CONSTRAINT [FK_t_Admin_t_Contrainte]
GO
alter view [V_DB0_Admin] as
SELECT Id, Logicaldeleted, Id_employe,Decalesioccupe, Secable, Dureemini, Debut,Duree,Periode,Fin,Decalagemaxi,Id_espaceclient
FROM T_Admin
go
alter view [V_PT0_Admin] as
SELECT  a.Id,a.Logicaldeleted,a.Id_employe,a.Decalesioccupe,a.Secable,a.Dureemini,a.Debut,a.Duree,a.Periode,a.Fin,a.Decalagemaxi,a.Id_espaceclient,
pr.Id_planning,pr.Libelle,pr.Ref,pr.Commentaire
FROM T_Admin a
left outer join t_contrainte pr on pr.Id=a.Id
go
alter view [V_PT0_Admin_W] as
SELECT  a.Id,a.Logicaldeleted,a.Id_employe,a.Decalesioccupe,a.Secable,a.Dureemini,a.Debut,a.Duree,a.Periode,a.Fin,a.Decalagemaxi,Id_espaceclient FROM T_Admin a
go







alter view [dbo].[V_PT0_Realisation] as
SELECT r.Id, r.Logicaldeleted, r.Debut,  r.Id_employe,r.Duree,r.Id_contrainterealisee,r.Id_contrainte,Id_espaceclient
from T_Realisation r 
GO
USE [PT]
GO

/****** Object:  View [dbo].[V_PT0_Realisation_W]    Script Date: 20/12/2021 10:59:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[V_PT0_Realisation_W] as
SELECT r.Id, r.Logicaldeleted, r.Debut,  r.Id_employe,r.Duree,r.Id_previsionrealisee,r.Id_prevision,Id_espaceclient
from T_Realisation r 
GO

drop table T_Prevision
go




