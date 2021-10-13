# co.SaludTotal

Se Crearon las siguientes Entidades/tablas:
- Aplicativo
- Desarrollador
- Requerimiento

Se utilizo Ado.net con .Net 5 (core) 

Solucion N-Layered
1. co.Saludtotal.Infrastructure.Data
2. co.Saludtotal.Domain.Entities
3. co.Saludtotal.Domain.Core
4. co.Saludtotal.Aplication
5. co.Saludtotal.UI.Mvc

Esta ultima se utilizo Razor Pages para agilizar el desarrollo de la prueba


Para la conexion no se tuvo encuenta la instancia de SQL Server “SRVBDDEV002\POS”  y para cambiar a este servidor se usó "(localdb)\\MSSQLLocalDB"
se provee de los scripts tanto de creación Tablas como los StoredPRocedures del CRUD


USE [PruebaTecnicaGermanLopezR]

GO

/****** Object:  Table [dbo].[Aplicativo]    Script Date: 13/10/2021 3:23:40 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[Aplicativo](

	[AplicativoID] [int] IDENTITY(1,1) NOT NULL,

	[DesarrolladorID] [int] NULL,

	[NombreAplicativo] [nvarchar](40) NOT NULL,

	[DiasDesarrollo] [int] NULL,

	[FechaDesarrollo] [smalldatetime] NULL,

	[FechaPruebas] [smalldatetime] NULL,

PRIMARY KEY CLUSTERED 
(
	[AplicativoID] ASC

)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Desarrollador]    Script Date: 13/10/2021 3:23:41 p. m. ******/
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[Desarrollador](

	[DesarrolladorID] [int] IDENTITY(1,1) NOT NULL,

	[NombreDesarrollador] [nvarchar](40) NOT NULL,

PRIMARY KEY CLUSTERED 

(
	[DesarrolladorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Requerimiento]    Script Date: 13/10/2021 3:23:41 p. m. ******/
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[Requerimiento](

	[RequerimientoID] [int] IDENTITY(1,1) NOT NULL,
	
	[NombreRequerimiento] [nvarchar](40) NOT NULL,
	
	[AlcanceRequerimiento] [nvarchar](10) NULL,
	
	[FechaSolicitud] [smalldatetime] NULL,
	
	[AplicativoID] [int] NULL,
	
PRIMARY KEY CLUSTERED 
(
	[RequerimientoID] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO

SET IDENTITY_INSERT [dbo].[Aplicativo] ON 

GO

INSERT [dbo].[Aplicativo] ([AplicativoID], [DesarrolladorID], [NombreAplicativo], [DiasDesarrollo], [FechaDesarrollo], [FechaPruebas]) VALUES (3, 1, N'Requerimientos', 180, CAST(N'2021-10-13T00:00:00' AS SmallDateTime), CAST(N'2021-10-13T00:00:00' AS SmallDateTime))

GO

SET IDENTITY_INSERT [dbo].[Aplicativo] OFF

GO

SET IDENTITY_INSERT [dbo].[Desarrollador] ON

GO

INSERT [dbo].[Desarrollador] ([DesarrolladorID], [NombreDesarrollador]) VALUES (1, N'Victor Diaz')

GO

INSERT [dbo].[Desarrollador] ([DesarrolladorID], [NombreDesarrollador]) VALUES (2, N'Hugo Jimenez')

GO

SET IDENTITY_INSERT [dbo].[Desarrollador] OFF

GO

SET IDENTITY_INSERT [dbo].[Requerimiento] ON 

GO

INSERT [dbo].[Requerimiento] ([RequerimientoID], [NombreRequerimiento], [AlcanceRequerimiento], [FechaSolicitud], [AplicativoID]) VALUES (11, N'Model', N'estructura', CAST(N'2013-10-21T00:00:00' AS SmallDateTime), 3)

GO

SET IDENTITY_INSERT [dbo].[Requerimiento] OFF

GO

ALTER TABLE [dbo].[Aplicativo]  WITH CHECK ADD FOREIGN KEY([DesarrolladorID])
REFERENCES [dbo].[Desarrollador] ([DesarrolladorID])

GO

ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD FOREIGN KEY([AplicativoID])
REFERENCES [dbo].[Aplicativo] ([AplicativoID])

GO

/****** Object:  StoredProcedure [dbo].[deleteaplicativo]    Script Date: 13/10/2021 3:23:41 p. m. ******/
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[deleteaplicativo] @id INT
AS
  BEGIN
      DELETE FROM aplicativo
      WHERE  aplicativoid = @id
  END 
  
GO
/****** Object:  StoredProcedure [dbo].[deleteDesarrollador]    Script Date: 13/10/2021 3:23:41 p. m. ******/
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

  CREATE PROCEDURE [dbo].[deleteDesarrollador] @id INT
AS
  BEGIN
      DELETE FROM Desarrollador
      WHERE  DesarrolladorID = @id
  END

GO

/****** Object:  StoredProcedure [dbo].[deleterequerimiento]    Script Date: 13/10/2021 3:23:41 p. m. ******/
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO


CREATE PROCEDURE [dbo].[deleterequerimiento] @id INT
AS
  BEGIN
      DELETE FROM requerimiento
      WHERE  RequerimientoID = @id
  END

GO

/****** Object:  StoredProcedure [dbo].[Getaplicativoall]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[Getaplicativoall]
AS
  BEGIN
      SELECT *
      FROM   aplicativo
  END 

GO

/****** Object:  StoredProcedure [dbo].[GetDesarrolladorAll]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

  --Visualizar Desarrolladores
  
CREATE PROCEDURE [dbo].[GetDesarrolladorAll]
AS
  BEGIN
      SELECT *
      FROM   Desarrollador
  END 
  
  -- Inserts
  
GO

/****** Object:  StoredProcedure [dbo].[Getrequerimientoall]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[Getrequerimientoall]
AS
  BEGIN
      SELECT *
      FROM   Requerimiento
  END 

GO

/****** Object:  StoredProcedure [dbo].[insertaplicativo]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

 CREATE PROCEDURE [dbo].[insertaplicativo] 
                                      @DesarrolladorID  INT,
                                      @NombreAplicativo NVARCHAR(40),
                                      @DiasDesarrollo   INT,
                                      @FechaDesarrollo  SMALLDATETIME
AS
  BEGIN
      INSERT INTO aplicativo
                  (
                   desarrolladorid,
                   nombreaplicativo,
                   diasdesarrollo,
                   fechadesarrollo)
      VALUES      ( 
                    @DesarrolladorID,
                    @NombreAplicativo,
                    @DiasDesarrollo,
                    @FechaDesarrollo )
  END 

GO

/****** Object:  StoredProcedure [dbo].[insertDesarrollador]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[insertDesarrollador] @DesarrolladorID      INT,
                                         @NombreDesarrollador  NVARCHAR(40)
AS
  BEGIN
      INSERT INTO Desarrollador
                  (
                   NombreDesarrollador)
      VALUES      ( @NombreDesarrollador )
  END


GO

/****** Object:  StoredProcedure [dbo].[insertRequerimiento]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[insertRequerimiento] 
                                        @NombreRequerimiento  NVARCHAR(40),
                                        @AlcanceRequerimiento NVARCHAR(10),
                                        @FechaSolicitud       SMALLDATETIME,
                                        @AplicativoID         INT
AS
  BEGIN
      INSERT INTO Requerimiento
                  (
                   nombrerequerimiento,
                   alcancerequerimiento,
                   fechasolicitud,
                   aplicativoid)
      VALUES      ( 
                    @NombreRequerimiento,
                    @AlcanceRequerimiento,
                    @FechaSolicitud,
                    @AplicativoID )
  END 
  
GO

/****** Object:  StoredProcedure [dbo].[updateaplicativo]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[updateaplicativo] @id               INT,
                                      @DesarrolladorID  INT,
                                      @NombreAplicativo NVARCHAR(40),
                                      @DiasDesarrollo   INT,
                                      @FechaDesarrollo  SMALLDATETIME
AS
  BEGIN
      UPDATE aplicativo
      SET    
             desarrolladorid = @DesarrolladorID,
             nombreaplicativo = @NombreAplicativo,
             diasdesarrollo = @DiasDesarrollo,
             fechadesarrollo = @FechaDesarrollo
      WHERE  aplicativoid = @id
  END 

GO

/****** Object:  StoredProcedure [dbo].[updatedesarrollador]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[updatedesarrollador] @id INT,
           @Nombredesarrollador NVARCHAR(40)
AS
  BEGIN
      UPDATE Desarrollador
      SET    
             NombreDesarrollador = @Nombredesarrollador
      WHERE  DesarrolladorID  = @id
  END 
  
  -- delete 
  
GO
/****** Object: StoredProcedure [dbo].[updaterequerimiento]    Script Date: 13/10/2021 3:23:41 p. m. ******/

SET ANSI_NULLS ON

GO


SET QUOTED_IDENTIFIER ON

GO

CREATE PROCEDURE [dbo].[updaterequerimiento] @id                   INT,
                                         @RequerimientoID      INT,
                                         @NombreRequerimiento  NVARCHAR(40),
                                         @AlcanceRequerimiento NVARCHAR(10),
                                         @FechaSolicitud       SMALLDATETIME,
                                         @AplicativoID         INT
AS
  BEGIN
      UPDATE requerimiento
      SET   
             nombrerequerimiento = @NombreRequerimiento,
             alcancerequerimiento = @AlcanceRequerimiento,
             fechasolicitud = @FechaSolicitud,
             aplicativoid = @AplicativoID
      WHERE  requerimientoid = @id
  END

GO
