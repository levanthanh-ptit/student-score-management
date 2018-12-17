USE [QLDSV]
GO
/****** Object:  UserDefinedFunction [dbo].[FS_GetName_MONHOC]    Script Date: 17/12/2018 5:28:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[FN_GetName_MONHOC](@MAMH char(6))
RETURNS nvarchar(40)
AS
BEGIN
	DECLARE @RetVal nvarchar(40) = NULL;
	DECLARE CS_MONHOC Cursor FOR (SELECT TENMH FROM MONHOC WHERE MAMH = @MAMH);
	OPEN CS_MONHOC;
	FETCH NEXT FROM CS_MONHOC INTO @RetVal;
	if(@RetVal is not Null) RETURN @RetVal;	
	RETURN N'';
END