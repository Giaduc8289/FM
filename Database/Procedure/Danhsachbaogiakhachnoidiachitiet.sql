------------------------Danh sách báo giá chi tiết-------------
If Object_ID('dbo.Danhsachbaogiakhachnoidiachitiet','P') is not null
	Drop Procedure dbo.Danhsachbaogiakhachnoidiachitiet;
Go

Create Procedure dbo.Danhsachbaogiakhachnoidiachitiet
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sobaogia		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select bgd.*, dmhh.Makhach Makhach
	From dbo.Baogiachokhach_d bgd LEFT JOIN dbo.Danhmuchanghoa dmhh ON dmhh.Mahieu = bgd.Mahang
	Where Ngayhieuluc BETWEEN @Tungay AND @Denngay
		AND (Sobaogia=@Sobaogia OR @Sobaogia='')
		AND	(Mahang=@Mahang OR @Mahang='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')

Go

Exec Danhsachbaogiakhachnoidiachitiet '03/01/2021', '03/30/2021','','',''
