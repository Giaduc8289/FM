------------------------Thêm mới chi phí bán hàng theo hàng-------------
If Object_ID('dbo.Themmoichiphibanhangtheohang','P') is not null
	Drop Procedure dbo.Themmoichiphibanhangtheohang;
Go

Create Procedure dbo.Themmoichiphibanhangtheohang
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_columns	NVARCHAR(MAX), 
			@v_sql		NVARCHAR(MAX)

	SELECT hh.Mahieu AS Mahang, hh.Makhach, hh.Tenkhach, hh.Mauin, hh.Loai
		, hh.Chungloai, hh.Kichthuocbao AS Kichthuoc, hh.Trongluongpe
		, hh.Trongluongbao, cp.Mahieu AS Machiphi, cp.Tenhieu AS Tenchiphi, cp.Tenrutgon
		, CONVERT(DECIMAL(20,2),0) AS Chiphitheocai, CONVERT(DECIMAL(20,2),0) AS Chiphitheokg
	INTO #Ketqua
	FROM dbo.Danhmuchanghoa hh, Danhmucchiphibanhang cp 
		
		
	SET @v_columns = N''
	SELECT @v_columns += N', ' + QUOTENAME(Mahieu) FROM (SELECT Mahieu FROM Danhmucchiphibanhang GROUP BY Mahieu) AS x ORDER BY x.Mahieu
	SET	@v_sql = N'Select Mahang, Makhach, Tenkhach, Mauin, Loai, Chungloai, Kichthuoc, Trongluongpe, Trongluongbao, ' 
		+ STUFF(@v_columns, 1, 2, '') 
		+ ' From (Select Mahang, Makhach, Tenkhach, Mauin, Loai, Chungloai, Kichthuoc, Trongluongpe, Trongluongbao, Machiphi As Mahieu, Chiphitheocai From #Ketqua) As j '
		+ ' PIVOT ('
		+ ' SUM(Chiphitheocai) FOR Mahieu IN ('
		+ STUFF(REPLACE(@v_columns,', [',',['),1,1,'')
		+ ') 
		) As p Order by Mahang'

	EXEC sp_executesql @v_sql;

GO

Exec Themmoichiphibanhangtheohang

--select * from Chiphibanhangtheohang
--select * from Danhmucchiphibanhang
