-- procedimiento almacenado de mantenimiento de contratista (para la proxima sesión) 
/* Homework */

-- PROCEDIMIENTO ALMACENADO PARA NUEVO CONTRATISTA
IF OBJECT_ID('SP_NUEVOCONTRATISTA') IS NOT NULL
DROP PROC SP_NUEVOCONTRATISTA
GO
CREATE PROCEDURE SP_NUEVOCONTRATISTA(@IDE CHAR(6),@NOM VARCHAR(30),@PAT VARCHAR(20),
    @MAT VARCHAR(20),@FON VARCHAR(15),@EMA VARCHAR(50))
AS
    INSERT INTO CONTRATISTA VALUES (@IDE, @NOM, @PAT, @MAT, @FON, @EMA)
GO


-- PROCEDIMIENTO ALMACENADO PARA ACTUALIZAR CONTRATISTA
IF OBJECT_ID('SP_ACTUALIZACONTRATISTA') IS NOT NULL
DROP PROC SP_ACTUALIZACONTRATISTA
GO
CREATE PROCEDURE SP_ACTUALIZACONTRATISTA(@IDE CHAR(6),@NOM VARCHAR(30),@PAT VARCHAR(20),
    @MAT VARCHAR(20),@FON VARCHAR(15),@EMA VARCHAR(50))
AS
    UPDATE CONTRATISTA
    SET NOM_CON = @NOM, 
        PAT_CON = @PAT,
        MAT_CON = @MAT,
        FON_CON = @FON,
        EMA_CON = @EMA
    WHERE IDE_CON = @IDE
GO

-- PROCEDIMIENTO ALMACENADO PARA ELIMINAR CONTRATISTA
IF OBJECT_ID('SP_ELIMINARCONTRATISTA') IS NOT NULL
DROP PROC SP_ELIMINARCONTRATISTA
GO
CREATE PROCEDURE SP_ELIMINARCONTRATISTA(@IDE CHAR(6))
AS
    DELETE FROM CONTRATISTA WHERE IDE_CON = @IDE
GO

/*LISTADO DE DATOS DE CONTRATISTA*/
-- LISTADO DE TODOS LOS CONTRATISTAS

IF OBJECT_ID('SP_LISTADOCONTRATISTAS') IS NOT NULL
DROP PROC SP_LISTADOCONTRATISTAS
GO
CREATE PROCEDURE SP_LISTADOCONTRATISTAS
AS 
	SELECT 
	C.IDE_CON AS CODIGO,
	C.NOM_CON AS NOMBRE,
	C.PAT_CON AS APELLIDO_PATERNO,
	C.MAT_CON AS APELLIDO_MATERNO,
	C.FON_CON AS TELEFONO,
	C.EMA_CON AS EMAIL
	FROM CONTRATISTA C
GO

IF OBJECT_ID('SP_ULTIMOCONTRATISTA') IS NOT NULL
DROP PROC SP_ULTIMOCONTRATISTA
GO
CREATE PROCEDURE SP_ULTIMOCONTRATISTA
AS 
	SELECT TOP 1 CON.IDE_CON AS CODIGO
	FROM CONTRATISTA CON
	ORDER BY 1 DESC
GO

SELECT * FROM CONTRATISTA
