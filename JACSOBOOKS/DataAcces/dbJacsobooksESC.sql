/*****************************************************************************************************
Nombre Script                      :dbJacsobooksESC
Description                       :Script to creation of database
Version                           :1.0
Historia de Modificacion          : IS   -     Fecha          -    Descripcion Cambio

                                  ----         ----------        ------------------------------------
								  OCV          13/06/2016        Se creo el script de la base de dato
*****************************************************************************************************/
Use master
Go

--DECLARE VARIABLES
DECLARE @Errormessage VARCHAR(MAX)

--CREATE USERNAME IN INSTANCE OF SQL SERVER 
IF NOT EXISTS(SELEC sid, name FROM MASTER..SYSLOGINS WHERE name = 'JacsobooksAppESC')
   BEGIN
      EXEC sp_addlogin 'JacsobooksAppESC', 'Jac50b00k5'
  END
ELSE
    BEGIN
	    SET @Errormessage = 'Username already exist in datebase'
		SELEC @Errormessage AS 'MSG'
   END
GO

If Exists (Select *from DBO.SYSDATABASES WHERE NAME = 'dbJacsobooksESC_UAT')
BEGIN
ALTER DATABASE[dboMovbisESC_UAT] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
USE master
DROP DATABASE dboMovbisESC_UAT
END
ELSE
BEGIN
CREATE DATABASE dboMovbilESC_UAT
END
GO

--USE DATABASE

USE dbJacsobooksESC_UAT
go


- - DECLARE VARIABLE
DECLARE @Errormessage VARCHAR (MAX)
-- VIEW USERNAMES FOR DATABASE ACTUALLY

IF NOT EXISTS (SELECT uid, name, sid FROM SYSUSERS WHERE name = 'JacsobooksappESC AND is login = 1
BEGIN
-- CREATE LOGIN
CREATE USER JacsobooksAppESC FOR LOGIN JacsobookAppESC

--ADD ROLES TO USER
EXEC sp_addrolemember 'db_owner', 'JacsobookAppESC'
EXEC sp_addrolemember 'db_accessadmin', 'JacsobookAppESC'
END
ELSE
BEGIN
SET @Errormessage = 'Username alredy exist in server'
SELECT  @Errormessage AS 'Msg'
END
-- CREATE TABLES IN DATABASE
BEGIN TRY
BEGIN TRANIF EXISTS (SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'jacsobooksESC_UAT')
BEGIN





    COMMIT
END 
ELSE 
   BEGIN
      ROLLBACK
	  SET @Errormessage = 'Database not exist'
	  RAISERROR(@Errormessage,39,79,13);
	END
	
