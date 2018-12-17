CREATE PROC SP_Print_PHIEUDIEMTHI
@NHOM nvarchar(10),
@MALOP char(8)
AS 
BEGIN
	DECLARE @tempTableSINHVIEN table(MASV char(12) NOT NULL,HOTEN nvarchar(50) NULL)

	INSERT INTO @tempTableSINHVIEN 
		SELECT MASV, (HO +' '+TEN) AS HOTEN FROM SINHVIEN WHERE SINHVIEN.MALOP = @MALOP;
	if(@NHOM = 'PGV' AND @NHOM = 'KETOAN')
	begin
		INSERT INTO @tempTableSINHVIEN 
		SELECT MASV, (HO +' '+TEN) AS HOTEN FROM KHOA_LINKED.QLDSV.dbo.SINHVIEN WHERE SINHVIEN.MALOP = @MALOP
		UNION SELECT * FROM @tempTableSINHVIEN;
	end
	SELECT * FROM @tempTableSINHVIEN;
END