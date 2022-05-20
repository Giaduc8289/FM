------------------------Danh sách đơn đặt hàng-------------
If Object_ID('dbo.Danhsachhopdongbanhang','P') is not null
	Drop Procedure dbo.Danhsachhopdongbanhang;
Go

Create Procedure dbo.Danhsachhopdongbanhang
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Sohopdong		NVARCHAR(50),
	@Makhachhang	NVARCHAR(50),
	@Mahang			Nvarchar(50),
	@Macangden		Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select *
	From dbo.Hopdongbanhang
	Where Ngayhopdong BETWEEN @Tungay AND @Denngay
		AND (Sohopdong=@Sohopdong OR @Sohopdong='')
		AND (Macangden = @Macangden OR @Macangden = '')
		AND (Makhach=@Makhachhang OR @Makhachhang='')
		AND	((Sohopdong IN (SELECT DISTINCT Sohopdong FROM dbo.Hopdongbanhangchitiet WHERE  Mahangphiakhach=@Mahang)) OR @Mahang='')
	ORDER BY Ngayhopdong DESC
Go

Exec Danhsachhopdongbanhang '03/01/2021', '03/30/2021','','','',''
