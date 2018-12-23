CREATE PROC SP_TAOLOGIN
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(10),
  @ROLE VARCHAR(10)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'PGV' OR @ROLE= 'KHOA'
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
RETURN 0  -- THANH CONG
