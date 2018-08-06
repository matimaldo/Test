CREATE PROCEDURE SP_Buscar_DNI (
@DNI INT
) 
AS
BEGIN
SELECT ID_Persona,Nombre,Apellido,DNI,Mail,Huella1,Huella2,Huella3,ID_TipoPersona FROM Personas WHERE DNI = @DNI

END

CREATE PROCEDURE SP_Obtener_PrecioDia
AS
BEGIN
SELECT Valor FROM Abonos WHERE Vigente = 1 and Cantidad_Ingresos = 1
END


CREATE PROCEDURE SP_Obtener_Ingreso(
@ID_Persona INT
)
AS
BEGIN

SELECT  * FROM IngresosVehiculos WHERE CONVERT (date,FechaIngreso) = CONVERT (date,GETDATE()) AND ID_Persona = @ID_Persona

END




SELECT * FROM AplicacionAbonos

SELECT * FROM AbonosVendidos
 
SELECT * FROM AbonosDisponibles

CREATE PROCEDURE SP_Obtener_Abono (
@Cantidad INT
) 
AS
BEGIN
SELECT ID_Abono,Cantidad_Ingresos,Valor,Vigente,Fecha_Alta FROM Abonos WHERE Vigente = 1 AND Cantidad_Ingresos = 1
END

GO

CREATE TRIGGER tr_AGREGAR_AbonoVendido ON AbonosVendidos
INSTEAD OF INSERT
AS
BEGIN
	
	DECLARE @NroComprobante BIGINT
	SELECT @NroComprobante = ISNULL(MAX (NroComprobante),0) FROM AbonosVendidos

	DECLARE @ID_Persona INT
	SELECT @ID_Persona = ID_Persona FROM inserted

	DECLARE @ID_Ingreso INT
	SELECT @ID_Ingreso = ID FROM IngresosVehiculos WHERE ID_Persona = @ID_Persona

	INSERT INTO AbonosVendidos
	SELECT GETDATE(),ID_Abono, ID_Persona,ID_MediodePago, @NroComprobante+1
	FROM inserted

	DECLARE @ID_AbonoVendido INT
	SELECT @ID_AbonoVendido = MAX(ID_AbonoVendido) FROM AbonosVendidos WHERE ID_Persona = @ID_Persona

	INSERT INTO AplicacionAbonos VALUES(@ID_Ingreso,@ID_AbonoVendido)

END
