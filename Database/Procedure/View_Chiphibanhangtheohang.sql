------------------------View Chi phí bán hàng theo hàng------------
If Object_ID('dbo.View_Chiphibanhangtheohang','P') is not null
	Drop Procedure dbo.View_Chiphibanhangtheohang;
Go
Create Procedure dbo.View_Chiphibanhangtheohang
	@Thang		NVARCHAR(20)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	DECLARE @v_columns	NVARCHAR(MAX), 
			@v_sql		NVARCHAR(MAX)


	SET @v_columns = N''
	SELECT @v_columns += N', ' + QUOTENAME(Mahieu) FROM (SELECT Mahieu FROM Danhmucchiphibanhang GROUP BY Mahieu) AS x ORDER BY x.Mahieu
	SET	@v_sql = N'Select Mahang, Makhach, Tenkhach, Mauin, Loai, Chungloai, Kichthuoc, Trongluongpe, Trongluongbao, ' 
		+ STUFF(@v_columns, 1, 2, '') 
		+ ' From (Select Mahang, Makhach, Tenkhach, Mauin, Loai, Chungloai, Kichthuoc, Trongluongpe, Trongluongbao, Machiphi As Mahieu, Chiphitheocai From Chiphibanhangtheohang Where Thang=''' + @Thang + ''') As j '
		+ ' PIVOT ('
		+ ' SUM(Chiphitheocai) FOR Mahieu IN ('
		+ STUFF(REPLACE(@v_columns,', [',',['),1,1,'')
		+ ') 
		) As p Order by Mahang'

	EXEC sp_executesql @v_sql;

Go

Exec View_Chiphibanhangtheohang '07/2021'

