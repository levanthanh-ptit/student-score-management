CREATE PROC SP_Check_GIANGVIEN
@MAGV nvarchar(10)
AS
BEGIN
	IF EXISTS (SELECT MAGV FROM GIANGVIEN WHERE MAGV = @MAGV)
		RETURN 1
	ELSE RETURN 0
END