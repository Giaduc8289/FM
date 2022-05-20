------------------------Danh sách đơn đặt hàng chi tiết-------------
If Object_ID('dbo.Danhsachhopdongbanhangchitiet','P') is not null
	Drop Procedure dbo.Danhsachhopdongbanhangchitiet;
Go

Create Procedure dbo.Danhsachhopdongbanhangchitiet
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
	From dbo.Hopdongbanhangchitiet
	Where Ngayhopdong BETWEEN @Tungay AND @Denngay
		AND (Sohopdong=@Sohopdong OR @Sohopdong='')
		AND (Macangden = @Macangden OR @Macangden = '')
		AND (Makhach=@Makhachhang OR @Makhachhang='')
		AND (Mahangphiakhach=@Mahang OR @Mahang='')

Go

Exec Danhsachhopdongbanhangchitiet '03/01/2021', '05/30/2021','','','',''
