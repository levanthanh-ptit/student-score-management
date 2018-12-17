CREATE PROC SP_Print_BANGDIEM_MONHOC
@NHOM nvarchar(10),
@MALOP char(8),
@MAMH char(6),
@LAN smallint
AS 
BEGIN
	-- temp table for SINHVIEN table where MALOP matchs
	DECLARE @tempTableSINHVIEN table(MASV char(12) NOT NULL,HOTEN nvarchar(50) NULL);
	INSERT INTO @tempTableSINHVIEN 
		SELECT MASV, (HO +' '+TEN) AS HOTEN FROM SINHVIEN WHERE SINHVIEN.MALOP = @MALOP;
	if(@NHOM = 'PGV')
	begin
		INSERT INTO @tempTableSINHVIEN 
		SELECT MASV, (HO +' '+TEN) AS HOTEN FROM KHOA_LINKED.QLDSV.dbo.SINHVIEN WHERE SINHVIEN.MALOP = @MALOP
		UNION SELECT * FROM @tempTableSINHVIEN;
	end
	-- temp table for DIEM table where MAMH and LAN matchs
	DECLARE @TableDIEM table([MASV] [char](12) NOT NULL,DIEM float);
	INSERT INTO @TableDIEM 
		SELECT MASV, DIEM FROM dbo.DIEM WHERE @MAMH = MAMH and @LAN = LAN;
	SELECT ROW_NUMBER() OVER(ORDER BY MASV asc) AS STT, * FROM ( SELECT tableSV.MASV, tableSV.HOTEN, TableDIEM.DIEM  FROM @tempTableSINHVIEN as tableSV inner JOIN @TableDIEM as TableDIEM ON tableSV.MASV = TableDIEM.MASV) DIEM
END