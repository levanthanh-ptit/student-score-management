CREATE PROC  SP_Check_Print_PHIEUDIEM
@NHOM nvarchar(10),
@MASV char(12)
AS
BEGIN
	DECLARE @errorTable Table(Code INT, ErrorDescription nvarchar(100))

	if (@NHOM IS NULL) INSERT INTO @errorTable SELECT 400, N'Nhóm quyền không được trống.';
	if (@MASV IS NULL) INSERT INTO @errorTable SELECT 400, N'Mã lớp không được trống.';
	if (@NHOM IS NOT NULL AND @MASV IS NOT NULL) 
	BEGIN	
		if not (@NHOM = 'PGV' OR @NHOM = 'KHOA' OR @NHOM = 'KETOAN') 
		INSERT INTO @errorTable SELECT 404, N'Nhóm quyền '+@NHOM+N' không tồn tại.';
		ELSE BEGIN
		if(@NHOM = 'PGV')
			BEGIN
				if (not EXISTS (SELECT MASV FROM dbo.SINHVIEN WHERE dbo.SINHVIEN.MASV = @MASV)
						AND (not EXISTS (SELECT MASV FROM KHOA_LINKED.QLDSV.dbo.SINHVIEN WHERE MASV = @MASV)))
						INSERT INTO @errorTable SELECT 404, N'Lớp với Mã lớp '+@MASV+N' không tồn tại.';
			END
			ELSE BEGIN
			if not EXISTS (SELECT MASV FROM dbo.SINHVIEN WHERE @MASV = dbo.SINHVIEN.MASV)
					INSERT INTO @errorTable SELECT 404, N'Lớp với Mã lớp '+@MASV+N' không tồn tại.';
			END
		END
	END
	SELECT * FROM @errorTable
END