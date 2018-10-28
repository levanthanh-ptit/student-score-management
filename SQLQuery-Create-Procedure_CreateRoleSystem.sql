SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CreateRoleSystem
AS
BEGIN
	EXEC sp_addrole 'KHOA'; 
	EXEC sp_addrole 'KETOAN';
	EXEC sp_addrole 'PGV';
	EXEC sp_addrole 'USER';
	EXEC sp_addrolemember db_owner, 'KHOA';
	EXEC sp_addrolemember db_owner, 'PGV';
	EXEC sp_addrolemember db_securityadmin, 'KHOA';
	EXEC sp_addrolemember db_securityadmin, 'PGV';
	EXEC sp_addrolemember db_securityadmin, 'KETOAN';
	EXEC sp_addrolemember db_accessadmin, 'KETOAN';
	EXEC sp_addrolemember db_datareader, 'USER';
END