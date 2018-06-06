  CREATE PROCEDURE SP_AA_ListarAnios
  AS
  SELECT DISTINCT A.Id_Anio, A.Anio FROM Cursadas C inner join AnioLectivo A on C.Id_Anio = A.Id_Anio

GO

CREATE PROCEDURE SP_AA_ListarCurso (
@Anio int
)

AS

SELECT DISTINCT CC.Id_Curso, CC.NM_Curso FROM Cursadas C inner join Cursos CC on C.Id_Curso = CC.Id_Curso 
WHERE C.Id_Anio = @Anio

GO

CREATE PROCEDURE SP_AA_ListarComision (
@Anio INT,
@Curso INT
)

AS

SELECT DISTINCT CC.Id_Comision, CC.NM_Comision FROM Cursadas C inner join Comisiones CC on C.Id_Comision = CC.Id_Comision 
WHERE C.Id_Anio = @Anio and  C.Id_Curso = @Curso



