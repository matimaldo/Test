
--TRUNCATE  TABLE PERSONAS -- BorraTabla  - Reinicia Contador
--DROP TABLE PERSONAS  -- BorraTabla  - No Reinicia Contador
--DELETE FROM PERSONAS   -Elimina datos - No Reinicia Contador
--DBCC CHECKIDENT (PERSONAS, RESEED, 0)  --Reinicia Contador
--SELECT * from personas

USE MALDONADO2_DB

INSERT INTO Personas 
VALUES 
('Matias','Maldonado',123,'1989-06-19','M','@',1), 
('Pamela','Sosa',124,'1993-01-25','F','@',1),  
('Rocio','Maldonado',122,'1993-12-03','F','@',1),
('M','M',1,'1990-01-01','M','@',1),
('M','M',2,'1990-01-01','M','@',1),
('M','M',3,'1990-01-01','M','@',1),
('M','M',4,'1990-01-01','M','@',1),
('M','M',5,'1990-01-01','M','@',1),
('M','M',6,'1990-01-01','M','@',1);  

GO

INSERT INTO TipoTelefonos 
VALUES 
('Celular'),
('Residencial'),
('Nextel');

GO

INSERT INTO Telefonos 
VALUES 
(1,1,'0303456','Mama Maldo'),
(2,1,'0303456','Abuela'),
(3,2,'0303456','Doña Marta');

GO

INSERT INTO Roles (NM_Rol)
VALUES 
('Admin'),
('Administrativo'),
('Profesor');

GO

INSERT INTO Usuarios 
VALUES 
(1,'MATIASMA','QWERTY'),
(2,'PAMEYSOSA','123'),
(3,'ROCIMA','123');

GO

INSERT INTO AnioLectivo
VALUES 
('2017'),
('2018'),
('2019');

GO

INSERT INTO Horarios
VALUES 
('1990-01-01 07:00:00.000' , '1990-01-01 08:00:00.000'),
('1990-01-01 08:00:00.000' , '1990-01-01 09:00:00.000'),
('1990-01-01 09:00:00.000' , '1990-01-01 10:00:00.000'),
('1990-01-01 10:00:00.000' , '1990-01-01 11:00:00.000'),
('1990-01-01 12:00:00.000' , '1990-01-01 13:00:00.000');

GO

INSERT Dias
VALUES
('Lunes'),
('Martes'),
('Miercoles'),
('Jueves'),
('Viernes');

GO

INSERT Aulas
VALUES
('Aula I'),
('Aula II');

GO

INSERT INTO Cursos
VALUES 
('Ingles Nivel 1'),
('Ingles Nivel 2'),
('Ingles Nivel 3'),
('Ingles Nivel 4'),
('Ingles Nivel 5');

GO

INSERT INTO Comisiones
VALUES 
('Mañana'),
('Tarde');

GO

INSERT INTO Cursadas
VALUES 
(1,2,1,1,30,1),
(2,2,1,2,28,1);

GO

INSERT INTO CursadaXAlumnos
VALUES 
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(2,6),
(2,7),
(2,8),
(2,9);

GO

INSERT INTO CursadaXDias
VALUES 
(1,1,1),
(1,1,2),
(1,1,3),
(1,3,1),
(1,3,2),
(1,3,3),
(1,5,1),
(1,5,2),
(1,5,3),
(2,2,1),
(2,2,2),
(2,2,3),
(2,4,1),
(2,4,2),
(2,4,3);

GO

INSERT INTO Disponiblidad
VALUES 
(1,1,1,1),
(1,1,2,1),
(1,1,3,1),
(1,1,4,null),
(1,1,5,null),
(1,3,1,1),
(1,3,2,1),
(1,3,3,1),
(1,3,4,null),
(1,3,5,null),
(1,5,1,1),
(1,5,2,1),
(1,5,3,1),
(1,5,4,null),
(1,5,5,null),
(2,2,1,2),
(2,2,2,2),
(2,2,3,2),
(2,4,1,2),
(2,4,2,2),
(2,4,3,2);

GO

INSERT INTO TipoExamen
VALUES 
('Parcial'),
('Final'),
('Recuperatorio'),
('Ingreso');

GO

INSERT INTO Examen
VALUES 
('Parcial 1','2018-05-04',1,1);

GO

INSERT INTO ExamenXAlumno
VALUES 
(1,1,10.00);

GO

INSERT INTO Avisos
VALUES 
('2018-05-04',1,'Entrega de TPC','*Arquitectura de clases  *Armado de pantallas  *Lectura desde base');

GO

INSERT INTO RolxPersona
VALUES
(1,2);