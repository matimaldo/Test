
alter PROCEDURE SP_Listar_Cursadas

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


						 exec SP_Listar_Cursadas_Profesor 58



SELECT Cursadas.Id_Cursada, Cursadas.Id_Curso, Cursos.NM_Curso, Cursadas.Id_Anio, AnioLectivo.Anio, 
Cursadas.Id_Comision, Comisiones.NM_Comision, Cursadas.Id_Profesor, Personas.Nombre, Personas.Apellido, 
Cursadas.Cant_Max, Cursadas.Estado FROM Cursadas INNER JOIN Cursos ON Cursadas.Id_Curso = Cursos.Id_Curso 
INNER JOIN AnioLectivo ON Cursadas.Id_Anio = AnioLectivo.Id_Anio INNER JOIN Comisiones ON Cursadas.Id_Comision = 
Comisiones.Id_Comision INNER JOIN Personas ON Cursadas.Id_Profesor = Personas.Id_Persona WHERE Cursadas.Id_Cursada =6   
ORDER BY 1 ASC;