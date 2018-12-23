CREATE PROC SP_List_LOGIN
AS
BEGIN 
	SELECT LG.LOGINNAME, GIANGVIEN.MAGV, GIANGVIEN.HO, GIANGVIEN.TEN, GIANGVIEN.MAKH FROM 
	(SELECT logins.name AS LOGINNAME, users.name AS USERNAME
		FROM sys.database_principals AS users 
			INNER JOIN sys.server_principals AS logins 
			ON logins.sid = users.sid ) AS LG full outer join
			GIANGVIEN 
		ON LG.USERNAME = GIANGVIEN.MAGV WHERE MAGV IS NOT NULL;
END
