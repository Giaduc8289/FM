------------------------Danh sách đơn đặt hàng chi tiết-------------
If Object_ID('dbo.Danhsachdondathangkhachnoidiachitiet','P') is not null
	Drop Procedure dbo.Danhsachdondathangkhachnoidiachitiet;
Go

Create Procedure dbo.Danhsachdondathangkhachnoidiachitiet
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
	From dbo.Dondathangcuakhach_d
	Where Ngaydat BETWEEN @Tungay AND @Denngay
		AND (Madondathang=@Madondathang OR @Madondathang='')
		AND (Sobaogia = @Sobaogia OR @Sobaogia = '')
		AND (Sopo=@Sopo OR @Sopo='')
		AND (Mahang=@Mahang OR @Mahang='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')

Go

Exec Danhsachdondathangkhachnoidiachitiet '03/01/2021', '05/30/2021','','','','',''
