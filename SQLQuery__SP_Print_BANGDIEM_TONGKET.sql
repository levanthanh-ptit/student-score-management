CREATE PROC SP_Print_BANGDIEM_TONGKET
@NHOM nvarchar(10),
@MALOP char(8)
AS
BEGIN
	--create ##tempTableDIEMTONGKET table--------------------------------------------------
	CREATE TABLE ##tempTableDIEMTONGKET(MASV char(12) NOT NULL);
	---------------------------------------------------
	--SELECT MASV FROM SINHVIEN WHERE MALOP = @MALOP;
	DECLARE @tempTableDIEM_LOP table(MASV char(12), MAMH char(6), LAN smallint, DIEM float)
	INSERT INTO @tempTableDIEM_LOP 
		SELECT dbo.DIEM.MASV, dbo.DIEM.MAMH, dbo.DIEM.LAN, dbo.DIEM.DIEM
			FROM (dbo.DIEM inner join (SELECT MASV FROM SINHVIEN WHERE MALOP = @MALOP) AS tableSV 
				ON dbo.DIEM.MASV = tableSV.MASV)
	---------------------------------------------------
	DECLARE @tempDSMON_for_CS_MONHOC table(MAMH char(6));
	INSERT INTO @tempDSMON_for_CS_MONHOC SELECT DISTINCT MAMH FROM @tempTableDIEM_LOP ORDER BY MAMH;
	DECLARE @tempMAMH char(6);
	DECLARE CS_MONHOC Cursor FOR (SELECT * FROM @tempDSMON_for_CS_MONHOC);
	OPEN CS_MONHOC;
	FETCH NEXT FROM CS_MONHOC INTO @tempMAMH;
	while @@FETCH_STATUS = 0
	BEGIN
		--DECLARE @name nvarchar(40) = dbo.FN_GetName_MONHOC(@tempMAMH)
		EXEC('ALTER TABLE ##tempTableDIEMTONGKET ADD '+@tempMAMH+' float') 
		FETCH NEXT FROM CS_MONHOC INTO @tempMAMH;
	END
	CLOSE CS_MONHOC
	DEALLOCATE CS_MONHOC
	----end of create ##tempTableDIEMTONGKET table------------------------------------------
	-------------------------------------------------
	DECLARE @tempMASV char(12);
	DECLARE CS_SINHVIEN Cursor FOR (SELECT DISTINCT MASV FROM @tempTableDIEM_LOP);
	OPEN CS_SINHVIEN;
	FETCH NEXT FROM CS_SINHVIEN INTO @tempMASV;
	while @@FETCH_STATUS = 0
	BEGIN
		--Get DIEM of MSV --------------------------
		CREATE TABLE ##TEMP_DS_DIEM(MAMH char(6), DIEM FLOAT);
		CREATE TABLE ##TEMP_DS_MON(MAMH char(6));
		CREATE TABLE ##TEMP_FINAL_DS_DIEM(MAMH char(6), DIEM FLOAT, STT int);

		INSERT INTO ##TEMP_DS_DIEM SELECT MAMH, Max(DIEM) as DIEM FROM @tempTableDIEM_LOP WHERE MASV = @tempMASV GROUP BY MAMH ORDER BY MAMH;
		INSERT INTO ##TEMP_DS_MON SELECT DISTINCT MAMH FROM @tempTableDIEM_LOP;
		INSERT INTO ##TEMP_FINAL_DS_DIEM SELECT ##TEMP_DS_MON.MAMH ,##TEMP_DS_DIEM.DIEM, ROW_NUMBER() OVER(ORDER BY ##TEMP_DS_DIEM.MAMH) AS STT FROM ##TEMP_DS_DIEM FULL OUTER JOIN ##TEMP_DS_MON 
		ON ##TEMP_DS_DIEM.MAMH = ##TEMP_DS_MON.MAMH;
		--Add to String-----------------------
		DECLARE @DIEMString nvarchar(500) = '';
		DECLARE @elementMAMH nvarchar(10);
		DECLARE @elementDIEM float;
		DECLARE CS_DIEM Cursor FOR (SELECT MAMH, DIEM FROM ##TEMP_FINAL_DS_DIEM);
		OPEN CS_DIEM;
		FETCH NEXT FROM CS_DIEM INTO @elementMAMH, @elementDIEM;
		WHILE @@FETCH_STATUS = 0 
		BEGIN	
			if(@elementDIEM is not NUll)
			begin
				SET	@DIEMString +=(STR(@elementDIEM,4,2)+' AS '+RTRIM(@elementMAMH)+', ');
			end
			if(@elementDIEM is NUll)
			begin
				SET	@DIEMString +=(N'NULL AS '+RTRIM(@elementMAMH)+', ');
			end
			SET @elementMAMH = NULL;
			SET @elementDIEM = NULL;
			FETCH NEXT FROM CS_DIEM INTO @elementMAMH, @elementDIEM;
		END
		DECLARE @COMAMD NVARCHAR(500) ='INSERT INTO ##tempTableDIEMTONGKET SELECT '+char(39)+@tempMASV+char(39)+' AS MASV, '+LEFT(@DIEMString,LEN(@DIEMString)-1);
		EXEC sp_executesql  @COMAMD
		CLOSE CS_DIEM
		DEALLOCATE CS_DIEM
		--------------------------------------
		DROP TABLE ##TEMP_DS_DIEM
		DROP TABLE ##TEMP_DS_MON
		DROP TABLE ##TEMP_FINAL_DS_DIEM
		FETCH NEXT FROM CS_SINHVIEN INTO @tempMASV;
	END
	CLOSE CS_SINHVIEN
	DEALLOCATE CS_SINHVIEN
	-------------------------------------------------
	SELECT * FROM ##tempTableDIEMTONGKET
	DROP TABLE ##tempTableDIEMTONGKET
END