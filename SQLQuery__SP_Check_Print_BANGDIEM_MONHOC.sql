CREATE PROC [dbo].[SP_Check_Print_BANGDIEM_MONHOC]
@NHOM nvarchar(10),
@MALOP char(8),
@MAMH char(6),
@LAN smallint
AS
BEGIN
	DECLARE @errorTable Table(Code INT, ErrorDescription nvarchar(100))

	if (@NHOM IS NULL) INSERT INTO @errorTable SELECT 400, N'Nhóm quyền không được trống.';
	if (@MALOP IS NULL) INSERT INTO @errorTable SELECT 400, N'Mã lớp không được trống.';
	if (@MAMH IS NULL) INSERT INTO @errorTable SELECT 400, N'Mã môn học không được trống.';
	if (@LAN IS NULL) INSERT INTO @errorTable SELECT 400, N'Lần thi không được trống.';

	if (@NHOM IS NOT NULL AND @MALOP IS NOT NULL AND @MAMH IS NOT NULL AND @LAN IS NOT NULL) 
	BEGIN	
		if not (@NHOM = 'PGV' OR @NHOM = 'KHOA' OR @NHOM = 'KETOAN') 
		INSERT INTO @errorTable SELECT 404, N'Nhóm quyền '+@NHOM+N' không tồn tại.';
		ELSE BEGIN
			if(@NHOM = 'PGV')
				BEGIN
					if (not EXISTS (SELECT MALOP FROM dbo.LOP WHERE @MALOP = dbo.LOP.MALOP)
						AND (not EXISTS (SELECT MALOP FROM KHOA_LINKED.QLDSV.dbo.LOP WHERE @MALOP = MALOP)))
						INSERT INTO @errorTable SELECT 404, N'Lớp với Mã lớp '+@MALOP+N' không tồn tại.';
				END
				ELSE BEGIN
					if not EXISTS (SELECT MALOP FROM dbo.LOP WHERE @MALOP = dbo.LOP.MALOP)
					INSERT INTO @errorTable SELECT 404, N'Lớp với Mã lớp '+@MALOP+N' không tồn tại.';
				END
			if not EXISTS (SELECT MAMH FROM dbo.MONHOC WHERE @MAMH = dbo.MONHOC.MAMH)
			INSERT INTO @errorTable SELECT 404, N'Môn học với Mã môn học'+@MAMH+N' không tồn tại.';
			if(@LAN <=0) INSERT INTO @errorTable SELECT 400, N'Lần thi phải lớn hơn 0.';
		END	
	END
	SELECT * FROM @errorTable;
END