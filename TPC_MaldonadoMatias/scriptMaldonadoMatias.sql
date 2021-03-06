USE [MALDONADO_DB]
GO
/****** Object:  Table [dbo].[AnioLectivo]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnioLectivo](
	[Id_Anio] [int] IDENTITY(1,1) NOT NULL,
	[Anio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Anio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__AnioLect__05ABF73559876802] UNIQUE NONCLUSTERED 
(
	[Anio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[Id_Cursada] [int] NOT NULL,
	[Id_Persona] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Presente] [bit] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[Id_Cursada] ASC,
	[Fecha] ASC,
	[Id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aulas]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aulas](
	[Id_Aula] [int] IDENTITY(1,1) NOT NULL,
	[NM_Aula] [varchar](30) NOT NULL,
	[Eliminado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Avisos]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avisos](
	[Id_Aviso] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Id_Usuario] [int] NULL,
	[Asunto] [varchar](100) NULL,
	[Detalle] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Aviso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comisiones]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comisiones](
	[Id_Comision] [int] IDENTITY(1,1) NOT NULL,
	[NM_Comision] [varchar](30) NOT NULL,
	[Eliminado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursadas]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursadas](
	[Id_Cursada] [int] IDENTITY(1,1) NOT NULL,
	[Id_Curso] [int] NULL,
	[Id_Anio] [int] NULL,
	[Id_Comision] [int] NULL,
	[Cant_Max] [int] NOT NULL,
	[Estado] [bit] NULL,
	[Id_Profesor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cursada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursadaXAlumnos]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursadaXAlumnos](
	[Id_Cursada] [int] NOT NULL,
	[Id_Persona] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cursada] ASC,
	[Id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursadaXDias]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursadaXDias](
	[Id_Cursada] [int] NOT NULL,
	[Id_Dia] [int] NOT NULL,
	[Id_Horario] [int] NOT NULL,
	[Id_Aula] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cursada] ASC,
	[Id_Dia] ASC,
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id_Curso] [int] IDENTITY(1,1) NOT NULL,
	[NM_Curso] [varchar](30) NOT NULL,
	[Eliminado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dias]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias](
	[Id_Dia] [int] IDENTITY(1,1) NOT NULL,
	[NM_Dia] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiasXHorario]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiasXHorario](
	[Id_Dia] [int] NOT NULL,
	[Id_Horario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Dia] ASC,
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Disponiblidad]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponiblidad](
	[Id_Dispo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Aula] [int] NULL,
	[Id_Dia] [int] NULL,
	[Id_Horario] [int] NULL,
	[Id_Cursada] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Dispo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Id_Aula] ASC,
	[Id_Dia] ASC,
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[Id_Examen] [int] IDENTITY(1,1) NOT NULL,
	[NM_Examen] [varchar](30) NULL,
	[Fecha] [datetime] NULL,
	[Id_TipoExa] [int] NULL,
	[Id_Cursada] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__ExamenCursada] UNIQUE NONCLUSTERED 
(
	[Id_Cursada] ASC,
	[NM_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenXAlumno]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenXAlumno](
	[Id_Examen] [int] NOT NULL,
	[Id_Persona] [int] NOT NULL,
	[Nota] [decimal](4, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Examen] ASC,
	[Id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horarios]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horarios](
	[Id_Horario] [int] IDENTITY(1,1) NOT NULL,
	[Horario_Desde] [datetime] NULL,
	[Horario_Hasta] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_DESDE] UNIQUE NONCLUSTERED 
(
	[Horario_Desde] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UNIQUE_HASTA] UNIQUE NONCLUSTERED 
(
	[Horario_Hasta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id_Persona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Dni] [varchar](10) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[Sexo] [varchar](1) NOT NULL,
	[Mail] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[Eliminado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[NM_Rol] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolxPersona]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolxPersona](
	[Id_Persona] [int] NULL,
	[Id_Rol] [int] NULL,
UNIQUE NONCLUSTERED 
(
	[Id_Persona] ASC,
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos](
	[Id_Telefono] [int] IDENTITY(1,1) NOT NULL,
	[Id_Persona] [int] NULL,
	[Id_TipoTel] [int] NULL,
	[Numero] [varchar](15) NULL,
	[Contacto] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoExamen]    Script Date: 29/06/2018 19:41:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoExamen](
	[Id_TipoExa] [int] IDENTITY(1,1) NOT NULL,
	[NM_Tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_TipoExa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTelefonos]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTelefonos](
	[Id_TipoTel] [int] IDENTITY(1,1) NOT NULL,
	[NM_Tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_TipoTel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NM_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Id_Turno] [int] IDENTITY(1,1) NOT NULL,
	[Nm_Turno] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nm_Turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TurnoxHorario]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurnoxHorario](
	[Id_Turno] [int] NULL,
	[Id_Horario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Id_Persona] [int] NULL,
	[Usuario] [varchar](10) NOT NULL,
	[Clave] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cursos] ADD  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [dbo].[Personas] ADD  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD FOREIGN KEY([Id_Cursada])
REFERENCES [dbo].[Cursadas] ([Id_Cursada])
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[Avisos]  WITH CHECK ADD FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Cursadas]  WITH CHECK ADD FOREIGN KEY([Id_Anio])
REFERENCES [dbo].[AnioLectivo] ([Id_Anio])
GO
ALTER TABLE [dbo].[Cursadas]  WITH CHECK ADD FOREIGN KEY([Id_Comision])
REFERENCES [dbo].[Comisiones] ([Id_Comision])
GO
ALTER TABLE [dbo].[Cursadas]  WITH CHECK ADD FOREIGN KEY([Id_Curso])
REFERENCES [dbo].[Cursos] ([Id_Curso])
GO
ALTER TABLE [dbo].[Cursadas]  WITH CHECK ADD FOREIGN KEY([Id_Profesor])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[CursadaXAlumnos]  WITH CHECK ADD FOREIGN KEY([Id_Cursada])
REFERENCES [dbo].[Cursadas] ([Id_Cursada])
GO
ALTER TABLE [dbo].[CursadaXAlumnos]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[CursadaXDias]  WITH CHECK ADD FOREIGN KEY([Id_Cursada])
REFERENCES [dbo].[Cursadas] ([Id_Cursada])
GO
ALTER TABLE [dbo].[CursadaXDias]  WITH CHECK ADD FOREIGN KEY([Id_Dia])
REFERENCES [dbo].[Dias] ([Id_Dia])
GO
ALTER TABLE [dbo].[CursadaXDias]  WITH CHECK ADD FOREIGN KEY([Id_Horario])
REFERENCES [dbo].[Horarios] ([Id_Horario])
GO
ALTER TABLE [dbo].[CursadaXDias]  WITH CHECK ADD  CONSTRAINT [FK_Aula] FOREIGN KEY([Id_Aula])
REFERENCES [dbo].[Aulas] ([Id_Aula])
GO
ALTER TABLE [dbo].[CursadaXDias] CHECK CONSTRAINT [FK_Aula]
GO
ALTER TABLE [dbo].[DiasXHorario]  WITH CHECK ADD  CONSTRAINT [FK_Horario] FOREIGN KEY([Id_Horario])
REFERENCES [dbo].[Horarios] ([Id_Horario])
GO
ALTER TABLE [dbo].[DiasXHorario] CHECK CONSTRAINT [FK_Horario]
GO
ALTER TABLE [dbo].[Disponiblidad]  WITH CHECK ADD FOREIGN KEY([Id_Aula])
REFERENCES [dbo].[Aulas] ([Id_Aula])
GO
ALTER TABLE [dbo].[Disponiblidad]  WITH CHECK ADD FOREIGN KEY([Id_Cursada])
REFERENCES [dbo].[Cursadas] ([Id_Cursada])
GO
ALTER TABLE [dbo].[Disponiblidad]  WITH CHECK ADD FOREIGN KEY([Id_Dia])
REFERENCES [dbo].[Dias] ([Id_Dia])
GO
ALTER TABLE [dbo].[Disponiblidad]  WITH CHECK ADD FOREIGN KEY([Id_Horario])
REFERENCES [dbo].[Horarios] ([Id_Horario])
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD FOREIGN KEY([Id_Cursada])
REFERENCES [dbo].[Cursadas] ([Id_Cursada])
GO
ALTER TABLE [dbo].[Examen]  WITH CHECK ADD FOREIGN KEY([Id_TipoExa])
REFERENCES [dbo].[TipoExamen] ([Id_TipoExa])
GO
ALTER TABLE [dbo].[ExamenXAlumno]  WITH CHECK ADD FOREIGN KEY([Id_Examen])
REFERENCES [dbo].[Examen] ([Id_Examen])
GO
ALTER TABLE [dbo].[ExamenXAlumno]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[RolxPersona]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[RolxPersona]  WITH CHECK ADD FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Telefonos]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[Telefonos]  WITH CHECK ADD FOREIGN KEY([Id_TipoTel])
REFERENCES [dbo].[TipoTelefonos] ([Id_TipoTel])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Id_Persona])
REFERENCES [dbo].[Personas] ([Id_Persona])
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD CHECK  (([SEXO]='M' OR [SEXO]='F'))
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_Agregar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_AA_Agregar](
@Cursada int,
@Alumno int
)

AS

INSERT INTO CursadaXAlumnos 
VALUES (@Cursada, @Alumno)
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_Eliminar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_AA_Eliminar](
@Cursada int,
@Alumno int
)

AS

DELETE FROM CursadaXAlumnos 
WHERE Id_Cursada = @Cursada and Id_Persona = @Alumno
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_ListarAlumnosDisponibles]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_AA_ListarAlumnosDisponibles]

as

SELECT P.Id_Persona, P.Apellido, P.Nombre FROM Personas P LEFT JOIN RolxPersona RP ON P.Id_Persona = RP.Id_Persona
WHERE Id_Rol IS NULL AND P.Id_Persona NOT IN (SELECT DISTINCT CA.Id_Persona FROM CursadaXAlumnos CA)
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_ListarAlumnosEnCurso]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_AA_ListarAlumnosEnCurso](
@Cursada INT
)
as

SELECT CA.Id_Cursada , CA.Id_Persona, A.Apellido,A.Nombre FROM CursadaXAlumnos CA INNER JOIN 
(SELECT P.Id_Persona, P.Apellido, P.Nombre FROM Personas P LEFT JOIN RolxPersona RP ON P.Id_Persona = RP.Id_Persona
WHERE Id_Rol IS NULL) AS A ON CA.Id_Persona = A.Id_Persona
WHERE CA.Id_Cursada = @Cursada
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_ListarAnios]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[SP_AA_ListarAnios]
  AS
  SELECT DISTINCT A.Id_Anio, A.Anio FROM Cursadas C inner join AnioLectivo A on C.Id_Anio = A.Id_Anio
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_ListarComision]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AA_ListarComision] (
@Anio INT,
@Curso INT
)

AS

SELECT DISTINCT CC.Id_Comision, CC.NM_Comision FROM Cursadas C inner join Comisiones CC on C.Id_Comision = CC.Id_Comision 
WHERE C.Id_Anio = @Anio and  C.Id_Curso = @Curso
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_ListarCurso]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   CREATE PROCEDURE [dbo].[SP_AA_ListarCurso] (
   @Anio int
   )

  AS

  SELECT DISTINCT CC.Id_Curso, CC.NM_Curso FROM Cursadas C inner join Cursos CC on C.Id_Curso = CC.Id_Curso 
  WHERE C.Id_Anio = @Anio
GO
/****** Object:  StoredProcedure [dbo].[SP_AA_SeleccionarCursada]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_AA_SeleccionarCursada](
@Anio INT,
@Curso INT,
@Comision INT
)
as


SELECT Id_Cursada, Cant_Max FROM Cursadas
WHERE Id_Anio = @Anio AND Id_Curso = @Curso AND Id_Comision = @Comision

GO
/****** Object:  StoredProcedure [dbo].[SP_Agregar_Cursada]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Agregar_Cursada](
@IdCurso INT,
@IdAnio INT,
@IdComision INT, 
@Cantidad INT,
@IdProfesor INT
)
AS

INSERT INTO Cursadas VALUES (@IdCurso, @IdAnio, @IdComision, @Cantidad, 1, @IdProfesor)
SELECT scope_identity() AS Id
GO
/****** Object:  StoredProcedure [dbo].[SP_Asistencia]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Asistencia] (

@Cursada int)

AS


Declare @columnas varchar(max),  @coma varchar(5),@col varchar(max)

set @columnas = ''
set @col =''

select @columnas = coalesce(@columnas + '[' + CONVERT(varchar(10), Fecha, 103) + '],', '')
FROM (select distinct Fecha from Asistencia) as DTM

set @columnas = left(@columnas,LEN(@columnas)-1)

select @col = coalesce(@col + 'CASE WHEN [' + CONVERT(varchar(10), Fecha, 103) + ']=1 THEN '+char(39)+'P'+char(39)+' ELSE '+char(39)+'A'+char(39)+' END AS ['+ CONVERT(varchar(10), Fecha, 103)+'],', '')
FROM (select distinct Fecha from Asistencia where Id_Cursada = @Cursada) as DTM

set @col = left(@col,LEN(@col)-1)

DECLARE @SQLString nvarchar(max);
DECLARE @CUR nvarchar(10);

set @coma =char(39)+', ' + char(39)
set @CUR = @Cursada


set @SQLString = N'
SELECT Id_Persona, APNO, '+@col+'
FROM
(SELECT Id_Cursada,P.Id_Persona, P.Apellido +'+ @coma + '+ P.Nombre APNO , CONVERT(varchar(10), Fecha, 103) as Fecha, Presente FROM Asistencia A LEFT JOIN 
Personas P ON A.Id_Persona = P.Id_Persona
 ) D

PIVOT (
	COUNT(Fecha)
	for  [Fecha] in (' + @Columnas +')
) P
where Id_Cursada = '+@CUR+' and Presente = 1'

EXECUTE sp_executesql @SQLString

GO
/****** Object:  StoredProcedure [dbo].[SP_CARGA_HORARIOS]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CARGA_HORARIOS]
AS
SELECT T.Nm_Turno,H.Id_Horario, SUBSTRING(convert(char(9),Horario_Desde,8),1,5) AS Desde,SUBSTRING(convert(char(9),Horario_Hasta,8),1,5)AS Hasta FROM Horarios H LEFT JOIN TurnoxHorario TH ON H.Id_Horario = TH.Id_Horario LEFT JOIN Turnos T
ON TH.Id_Turno = T.Id_Turno ORDER BY 4
GO
/****** Object:  StoredProcedure [dbo].[SP_Crear_Avisos]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Crear_Avisos](
@Fecha datetime,
@Usuario INT, 
@Asunto varchar(100), 
@Detalle varchar(500)
)

AS

INSERT INTO Avisos VALUES (@Fecha,@Usuario, @Asunto, @Detalle)
GO
/****** Object:  StoredProcedure [dbo].[SP_Eliminar_HorarioCursadas]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Eliminar_HorarioCursadas] (
@Id_Cursada INT,
@Id_Dia	INT,
@Id_Horario INT, 
@Id_Aula INT
)
AS
DELETE FROM CursadaxDias 
WHERE Id_Cursada = @Id_Cursada AND Id_Dia = @Id_Dia AND Id_Horario = @Id_Horario AND Id_Aula = @Id_Aula
GO
/****** Object:  StoredProcedure [dbo].[SP_Examen_ActualizarNota]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Examen_ActualizarNota] (
  @IdExamen INT,
  @IdPersona INT,
  @Nota DECIMAL NULL
  )
  as
  UPDATE ExamenXAlumno SET Nota = @Nota WHERE Id_Examen = @IdExamen and Id_Persona = @IdPersona
GO
/****** Object:  StoredProcedure [dbo].[SP_Examen_Agregar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Examen_Agregar] (
@Cursada INT,
@Fecha DATE,
@Tipo INT,
@Nombre VARCHAR(30)
)
AS

INSERT INTO Examen VALUES (@Nombre, @Fecha, @Tipo, @Cursada)
GO
/****** Object:  StoredProcedure [dbo].[SP_Examen_CargaNota]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[SP_Examen_CargaNota] (
  @IdExamen INT,
  @IdPersona INT,
  @Nota DECIMAL NULL
  )
  as
  INSERT INTO ExamenXAlumno VALUES (@IdExamen,@IdPersona,@Nota)
GO
/****** Object:  StoredProcedure [dbo].[SP_Examen_Listar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Examen_Listar](
@Cursada INT
)
AS
SELECT Id_Examen, NM_Examen  FROM Examen WHERE Id_Cursada = @Cursada
GO
/****** Object:  StoredProcedure [dbo].[SP_Examen_ListarRecuperar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Examen_ListarRecuperar] (
@Cursada INT
)
AS

SELECT Id_Examen, NM_Examen FROM  Examen 
WHERE Id_TipoExa IN (1,3) and Id_Cursada = @Cursada

GO
/****** Object:  StoredProcedure [dbo].[SP_ListaActualizar]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[SP_ListaActualizar](
@Cursada INT,
@Persona INT,
@Fecha Datetime,
@Presente bit
)

as

UPDATE Asistencia set Presente = @Presente WHERE Id_Cursada = @Cursada AND Id_Persona = @Persona AND Fecha = @Fecha
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_Cursadas]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_Cursadas]

AS

SELECT        Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, 
                         Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado--, Cursadas.Id_Turno, Turnos.NM_Turno
FROM            Cursadas INNER JOIN 
                         Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN
                         AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN
                         Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN
                         Personas ON Cursadas.Id_Profesor = Personas.Id_Persona --INNER JOIN
                         --Aulas ON Cursadas.Id_Aula = Aulas.Id_Aula INNER JOIN   Cursadas.Id_Aula, Aulas.NM_Aula, 
						 --Turnos ON Cursadas.Id_Turno = Turnos.Id_Turno 
						 --where Id_Persona = @Profesor
						 ORDER BY 1
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_Cursadas_Alumnos]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[SP_Listar_Cursadas_Alumnos]
(@Cursada INT)
as

SELECT P.Id_Persona, P.Apellido, P.Nombre FROM CursadaXAlumnos CA inner join Personas P on CA.Id_Persona = P.Id_Persona
WHERE ca.Id_Cursada = @Cursada ORDER BY 3 ASC
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_Cursadas_Profesor]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_Cursadas_Profesor]
(@Profesor  INT)
AS

SELECT        Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, 
                         Personas.Nombre, Personas.Apellido, Cursadas.Cant_Max, Cursadas.Estado--, Cursadas.Id_Turno, Turnos.NM_Turno
FROM            Cursadas INNER JOIN 
                         Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso INNER JOIN
                         AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN
                         Comisiones ON Cursadas.Id_Comision = Comisiones.Id_Comision INNER JOIN
                         Personas ON Cursadas.Id_Profesor = Personas.Id_Persona --INNER JOIN
                         --Aulas ON Cursadas.Id_Aula = Aulas.Id_Aula INNER JOIN   Cursadas.Id_Aula, Aulas.NM_Aula, 
						 --Turnos ON Cursadas.Id_Turno = Turnos.Id_Turno 
						 where Id_Persona = @Profesor
						 ORDER BY 1
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_Dias]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_Dias]

AS

SELECT Id_Dia, NM_Dia FROM Dias ORDER BY 1
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_HorarioCursadas]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_HorarioCursadas](
@IdCursada INT)

AS

SELECT CD.Id_Cursada,CD.Id_Dia,CD.Id_Horario, CD.Id_Aula, D.NM_Dia as Dia, SUBSTRING(convert(char(9),Horario_Desde,8),1,5) AS Desde,SUBSTRING(convert(char(9),Horario_Hasta,8),1,5)AS Hasta, A.NM_Aula Aula  FROM CursadaXDias CD 
INNER JOIN Dias D ON CD.Id_Dia = D.Id_Dia
INNER JOIN Horarios H ON CD.Id_Horario = H.Id_Horario
INNER JOIN Aulas A ON CD.Id_Aula = A.Id_Aula
WHERE Id_Cursada = @IdCursada
ORDER BY D.Id_Dia ASC , H.Horario_Desde ASC
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_HorarioxDia]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_HorarioxDia]
(
@Id_dia int,
@Id_aula int,
@Id_Prof int,
@Id_Turno int
)

AS

SELECT * FROM Horarios WHERE Id_Horario IN(
SELECT Id_Horario FROM
(
	SELECT DH.Id_Horario FROM DiasXHorario AS DH 
	LEFT OUTER JOIN 
	(
		SELECT * FROM CursadaXDias 
		WHERE Id_Aula = @Id_aula
	) AS CD 
	ON DH.Id_Horario = CD.Id_Horario AND DH.Id_Dia = CD.Id_Dia
	WHERE (DH.Id_Dia = @Id_dia) AND CD.Id_Horario IS NULL
) Libres 
WHERE Id_Horario NOT IN 
(
	SELECT CD.Id_Horario FROM Cursadas C 
	INNER JOIN CursadaXDias CD ON C.Id_Cursada = CD.Id_Cursada
	WHERE (C.Id_Profesor = @Id_Prof) AND (CD.Id_Dia = @Id_dia)
) AND Id_Horario IN 
(
	SELECT TH.Id_Horario FROM TurnoxHorario TH 
	WHERE TH.Id_Turno = @Id_Turno
)
) ORDER BY 2
GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_Mail_Todos]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Listar_Mail_Todos]
AS
SELECT DISTINCT Mail FROM Personas P 
LEFT JOIN RolxPersona R ON R.Id_Persona = P.Id_Persona 
where Mail LIKE '%@%' and R.Id_Rol IS NULL
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarEmpleado]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ListarEmpleado]

as

SELECT P.Id_Persona, P.Nombre, P.Apellido, P.DNI, R.NM_Rol as Rol, P.FechaNac, P.Mail, T.Numero, TT.NM_Tipo,RP.Id_Rol 
FROM dbo.PERSONAS AS P 
LEFT OUTER JOIN dbo.Telefonos AS T ON P.Id_Persona = T.Id_Persona 
LEFT OUTER JOIN TipoTelefonos AS TT ON T.Id_TipoTel = TT.Id_TipoTel 
LEFT JOIN RolxPersona RP ON p.Id_Persona = RP.Id_Persona 
LEFT JOIN Roles R ON RP.Id_Rol = R.Id_Rol
WHERE RP.Id_Rol IS NOT NULL AND P.Eliminado = 0
GO
/****** Object:  StoredProcedure [dbo].[SP_ObtenerUsuario]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ObtenerUsuario](
@Usuario varchar(10),
@Clave varchar(10)
)
as

SELECT  Id_Usuario, Usuario,P.Id_Persona, Apellido, Nombre, R.Id_Rol,R.NM_Rol FROM Usuarios U inner join Personas P ON U.Id_Persona = P.Id_Persona inner join
 RolxPersona RP ON P.Id_Persona = RP.Id_Persona inner join Roles R ON RP.Id_Rol = R.Id_Rol WHERE Usuario = @Usuario and Clave = @Clave 
GO
/****** Object:  StoredProcedure [dbo].[SP_PIVOT_Horarios]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_PIVOT_Horarios]

AS

SELECT Desde , Hasta,
CASE WHEN Lunes =1 THEN 'X' ELSE '' END AS Lunes,
CASE WHEN Martes =1 THEN 'X' ELSE '' END AS Martes,
CASE WHEN Miercoles =1 THEN 'X' ELSE '' END AS Miercoles,
CASE WHEN Jueves =1 THEN 'X' ELSE '' END AS Jueves,
CASE WHEN Viernes =1 THEN 'X' ELSE '' END AS Viernes,
CASE WHEN Sabado =1 THEN 'X' ELSE '' END AS Sabado
FROM (
SELECT SUBSTRING(convert(char(9),Horario_Desde,8),1,5) AS Desde,SUBSTRING(convert(char(9),Horario_Hasta,8),1,5)AS Hasta, DH.Id_Horario, NM_Dia FROM Horarios H FULL JOIN DiasXHorario DH ON H.Id_Horario = DH.Id_Horario 
FULL JOIN Dias D ON D.Id_Dia = DH.Id_Dia
) D
PIVOT (
	COUNT(Id_Horario)
	for  [NM_Dia] in ([Lunes],[Martes],[Miercoles],[Jueves],[Viernes],[Sabado])
) P
WHERE Desde IS NOT NULL





GO
/****** Object:  StoredProcedure [dbo].[SP_SeTomoLista]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeTomoLista](
@Cursada INT,
@Fecha datetime
)
AS
SELECT TOP(1) * FROM Asistencia
WHERE Id_Cursada = @Cursada AND Fecha = @Fecha
GO
/****** Object:  StoredProcedure [dbo].[SP_TomarLista]    Script Date: 29/06/2018 19:41:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TomarLista](
@Cursada INT,
@Persona INT,
@Fecha Datetime,
@Presente bit
)

as

INSERT INTO Asistencia VALUES (@Cursada, @Persona, @Fecha, @Presente)
GO
