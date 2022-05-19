------------------------Danh sách báo giá-------------
If Object_ID('dbo.Danhsachbaogiakhachnoidia','P') is not null
	Drop Procedure dbo.Danhsachbaogiakhachnoidia;
Go

Create Procedure dbo.Danhsachbaogiakhachnoidia
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sobaogia		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select *
	From dbo.Baogiachokhach_h
	Where Ngayhieuluc BETWEEN @Tungay AND @Denngay
		AND (Sobaogia=@Sobaogia OR @Sobaogia='')
		AND	(Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Sobaogia IN (SELECT DISTINCT Sobaogia FROM dbo.Baogiachokhach_d WHERE  Mahang=@Mahang)) OR @Mahang='')

Go

Exec Danhsachbaogiakhachnoidia '04/01/2021', '04/30/2021','','',''
