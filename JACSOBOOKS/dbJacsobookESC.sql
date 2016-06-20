/*************************************************************************************************************
Nombre Script            : dbJacsobookESC
Description              : Script to creation of database
Version	                 : 1.0
Historia de Modificacion : IS	-	Fecha		-	Descripcion Cambio
                           ----		----------		----------------------------------------------------------
						   HECP		20/06/2016		Se creo la estructura para la creacion de la base de datos
**************************************************************************************************************/

USE master
GO

--DECLARE VARIABLES
DECLARE @Errormessage VARCHAR(MAX)

--CREATE USERNAME IN INSTANCE OF SQL SERVER
IF NOT EXISTS(SELECT sid, name FROM MASTER..SYSLOGINS WHERE name = 'JacsobookAppMTYAppMty' )
	BEGIN
		EXEC sp_addlogin 'JacsobookAppMTY', '0walt3kmtysafic'
	END
ELSE
	BEGIN
		SET @Errormessage = 'Username already exist'
		SELECT @Errormessage AS 'Msg'
	END
GO

--CREATE DATABASE
IF EXISTS(SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'dbJacsobookESC_UAT')
	BEGIN
		ALTER DATABASE [dbJacsobookESC_UAT] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
		USE master
		DROP DATABASE dbJacsobookESC_UAT
		CREATE DATABASE dbJacsobookESC_UAT
	END
ELSE
	BEGIN
		CREATE DATABASE dbJacsobookESC_UAT
	END
GO

--USE DATABASE
USE dbSaficMTY_UAT
GO

--DECLARE VARIABLES
DECLARE @Errormessage VARCHAR(MAX)

--VIEW USERNAMES FOR DATABASE ACTUALLY
IF NOT EXISTS(SELECT uid, name, sid FROM SYSUSERS WHERE name = 'JacsobookAppESC' AND islogin = 1)
	BEGIN
		--CREATE LOGIN
		CREATE USER SaficAppMTY FOR LOGIN SaficAppMTY;
			
		--ADD ROLES TO USER
		EXEC sp_addrolemember 'db_owner', 'JacsobookAppESC';
		EXEC sp_addrolemember 'db_accessadmin', 'JacsobookAppESC';
	END
	ELSE
		BEGIN
			SET @Errormessage = 'Username already exist'
			SELECT @Errormessage AS 'Msg'
		END

--CREATE TABLES IN DATABASE
BEGIN TRY	
	BEGIN TRAN
		IF EXISTS(SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'dbJacsobookESC_UAT')
			BEGIN		
				IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
							WHERE TABLE_SCHEMA = 'dbo' 
							AND  TABLE_NAME = 'Country'))
					BEGIN
						SELECT 'Table Country already exists' AS 'Msg'
					END
					ELSE
						BEGIN
							CREATE TABLE Country
							(

							);
						END
						
				COMMIT	
				
			END
			ELSE
				BEGIN
					
					ROLLBACK
					
					SET @Errormessage = 'Database not exist'
					RAISERROR(@Errormessage,16,1);
				END
END TRY
BEGIN CATCH
	
	SELECT  @Errormessage = 'Error: ' + CAST(ERROR_NUMBER() AS NVARCHAR) + ' -> ' + ERROR_MESSAGE() + '. Error Line: *' + CAST(ERROR_LINE() AS VARCHAR(50)) + '*.'; 
	
	--SELECT  @Errormessage AS Msg;
	
	RAISERROR(@Errormessage,16,1);
	
	IF(@@TRANCOUNT > 0)
		ROLLBACK
		
END CATCH