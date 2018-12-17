CREATE PROC SP_Check_Print_SINHVIEN_PHIEUDIEMTHI
@NHOM nvarchar(10) NULL,
@MALOP char(8) NULL
AS
BEGIN
	DECLARE @errorTable Table(Code INT, ErrorDescription nvarchar(100))
	if (@NHOM = Null AND @MALOP = Null) INSERT INTO @errorTable SELECT 0, N'Nhóm quyền và Mã lớp không được trống.';
	ELSE BEGIN
		if not (@NHOM = 'PGV' or @NHOM = 'KHOA' or @NHOM = 'KETOAN') 
		INSERT INTO @errorTable SELECT 1, N'Nhóm quyền '+@NHOM+N' không tồn tại.';
		if not EXISTS (SELECT MALOP FROM dbo.LOP WHERE @MALOP = dbo.LOP.MALOP)
		INSERT INTO @errorTable SELECT 2, N'Lớp với Mã lớp '+@MALOP+N' không tồn tại.';
	END
	SELECT * FROM @errorTable;
END