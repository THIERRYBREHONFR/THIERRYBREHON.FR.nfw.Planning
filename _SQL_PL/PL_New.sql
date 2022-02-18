
-------------------------
CREATE TABLE [dbo].[T_CategorieContrainte](
	[Id] [dbo].[PrimaryKeyBig] NOT NULL,
	[Logicaldeleted] [dbo].[boolean] NOT NULL,
	[Id_espaceclient] [bigint] NOT NULL,
	[Id_categorie] ForeignKeyBig NOT NULL,
	Id_contrainte ForeignKeyBig not null,
	[libelle] [dbo].[lib_100] NOT NULL,
	[abreviation] [dbo].[code_8] not NULL,
 CONSTRAINT [PK_T_TypeCategorie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
exec sp_unbindefault 'T_CategorieContrainte.logicaldeleted'
ALTER TABLE [dbo].[T_CategorieContrainte] ADD  CONSTRAINT [T_CategorieContrainte_logicaldeleted_default]  DEFAULT ((0)) FOR [Logicaldeleted]
ALTER TABLE [dbo].[T_CategorieContrainte] ADD  CONSTRAINT [T_CategorieContrainte_mere_default]  DEFAULT ((0)) FOR [id_mere]
ALTER TABLE [dbo].[T_CategorieContrainte]  WITH CHECK ADD  CONSTRAINT [FK_t_CategorieContrainte_t_mere] FOREIGN KEY([id_mere])
REFERENCES [dbo].[T_CategorieContrainte] ([id])
ALTER TABLE [dbo].[T_CategorieContrainte] CHECK CONSTRAINT [FK_t_CategorieContrainte_t_mere]
go
