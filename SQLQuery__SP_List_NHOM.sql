CREATE PROC SP_List_NHOM
AS
BEGIN
	DECLARE @tempTable table(MANHOM nvarchar(10), TENNHOM nvarchar(40));
	INSERT INTO @tempTable VALUES(N'PGV', N'Phòng giáo vụ');
	INSERT INTO @tempTable VALUES(N'KHOA', N'Khoa');
	INSERT INTO @tempTable VALUES(N'KETOAN', N'Kế toán');
	SELECT * FROM @tempTable;
END