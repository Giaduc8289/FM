------------------------Danh sách đơn đặt hàng-------------
If Object_ID('dbo.Danhsachdondathangkhachnoidia','P') is not null
	Drop Procedure dbo.Danhsachdondathangkhachnoidia;
Go

Create Procedure dbo.Danhsachdondathangkhachnoidia
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Madondathang		NVARCHAR(50),
	@Sobaogia			NVARCHAR(50),
	@Sopo				NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select *
	From dbo.Dondathangcuakhach_h
	Where Ngaydat BETWEEN @Tungay AND @Denngay
		AND (Madondathang=@Madondathang OR @Madondathang='')
		AND (Sobaogia = @Sobaogia OR @Sobaogia = '')
		AND (Sopo=@Sopo OR @Sopo='')
		AND (Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Madondathang IN (SELECT DISTINCT Madondathang FROM dbo.Dondathangcuakhach_d WHERE  Mahang=@Mahang)) OR @Mahang='')
	ORDER BY Ngaydat DESC
Go

Exec Danhsachdondathangkhachnoidia '12/01/2021', '12/30/2021','','','','',''
