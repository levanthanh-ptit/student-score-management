CREATE PROC SP_List_NHOM
@NHOM nvarchar(10)
AS
BEGIN
	DECLARE @tempTable table(MANHOM nvarchar(10), TENNHOM nvarchar(40));
	INSERT INTO @tempTable VALUES(N'KETOAN', N'Kế toán');
	if(@NHOM = 'PGV' OR @NHOM = 'KHOA')
	INSERT INTO @tempTable VALUES(N'PGV', N'Phòng giáo vụ');
	if(@NHOM = 'PGV')
	INSERT INTO @tempTable VALUES(N'KHOA', N'Khoa');
	
	SELECT * FROM @tempTable;
END