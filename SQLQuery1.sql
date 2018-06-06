create procedure SP_AA_ListarAlumnosDisponibles

as

SELECT P.Id_Persona, P.Apellido, P.Nombre FROM Personas P LEFT JOIN RolxPersona RP ON P.Id_Persona = RP.Id_Persona
WHERE Id_Rol IS NULL AND P.Id_Persona NOT IN (SELECT DISTINCT CA.Id_Persona FROM CursadaXAlumnos CA)

go

create procedure SP_AA_ListarAlumnosEnCurso(
@Cursada INT
)
as

SELECT CA.Id_Cursada , CA.Id_Persona, A.Apellido,A.Nombre FROM CursadaXAlumnos CA INNER JOIN 
(SELECT P.Id_Persona, P.Apellido, P.Nombre FROM Personas P LEFT JOIN RolxPersona RP ON P.Id_Persona = RP.Id_Persona
WHERE Id_Rol IS NULL) AS A ON CA.Id_Persona = A.Id_Persona
WHERE CA.Id_Cursada = @Cursada

SP_AA_ListarAlumnosEnCurso 1

go

alter procedure SP_AA_SeleccionarCursada(
@Anio INT,
@Curso INT,
@Comision INT
)
as


SELECT Id_Cursada, Cant_Max FROM Cursadas
WHERE Id_Anio = @Anio AND Id_Curso = @Curso AND Id_Comision = @Comision

go

create procedure SP_AA_Agregar(
@Cursada int,
@Alumno int
)

AS

INSERT INTO CursadaXAlumnos 
VALUES (@Cursada, @Alumno)

go

create procedure SP_AA_Eliminar(
@Cursada int,
@Alumno int
)

AS

DELETE FROM CursadaXAlumnos 
WHERE Id_Cursada = @Cursada and Id_Persona = @Alumno


go

create procedure SP_ObtenerUsuario(
@Usuario varchar(10),
@Clave varchar(10)
)
as

SELECT  Id_Usuario, Usuario,P.Id_Persona, Apellido, Nombre, R.Id_Rol,R.NM_Rol, Clave FROM Usuarios U inner join Personas P ON U.Id_Persona = P.Id_Persona inner join
 RolxPersona RP ON P.Id_Persona = RP.Id_Persona inner join Roles R ON RP.Id_Rol = R.Id_Rol WHERE Usuario = @Usuario and Clave = @Clave 

 go

 alter procedure SP_Listar_Cursadas_Alumnos
(@Cursada INT)
as

SELECT P.Id_Persona, P.Apellido, P.Nombre FROM CursadaXAlumnos CA inner join Personas P on CA.Id_Persona = P.Id_Persona
WHERE ca.Id_Cursada = @Cursada ORDER BY 3 ASC

CREATE TABLE Asistencia(
Id_Cursada INT foreign key references Cursadas(Id_Cursada) not null,
Id_Persona INT foreign key references Personas(Id_Persona) not null,
Fecha Datetime not null,
Presente bit not null

unique (Id_Cursada, Fecha,Id_Persona)
)


go

CREATE PROCEDURE SP_TomarLista(
@Cursada INT,
@Persona INT,
@Fecha Datetime,
@Presente bit
)

as

INSERT INTO Asistencia VALUES (@Cursada, @Persona, @Fecha, @Presente)




alter PROCEDURE SP_SeTomoLista(
@Cursada INT,
@Fecha datetime
)
AS
SELECT TOP(1) * FROM Asistencia
WHERE Id_Cursada = @Cursada AND Fecha = @Fecha


EXEC SP_SeTomoLista 11 , '2018/06/04'