CREATE PROC SP_INSERT_GIANGVIEN
@MAGV nchar(10),
@HO nvarchar(50),
@TEN nvarchar(10),
@MAKH char(4)	
AS
BEGIN
	INSERT INTO GIANGVIEN (MAGV,HO,TEN,MAKH) VALUES(@MAGV, @HO, @TEN, @MAKH)
END