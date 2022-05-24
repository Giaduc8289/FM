------------------------Danh sách đơn đặt hàng chi tiết-------------
If Object_ID('dbo.Baocaophantichdulieuxnk','P') is not null
	Drop Procedure dbo.Baocaophantichdulieuxnk;
Go

Create Procedure dbo.Baocaophantichdulieuxnk
	@Tungay		Datetime,
	@Denngay	Datetime,
	@Maquocgia		Nvarchar(50),
	@Macang			Nvarchar(50)
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select *
	From dbo.Dulieuxnk
	Where Ngaythongquan BETWEEN @Tungay AND @Denngay
		AND (Tennuocnhapkhau=@Maquocgia OR @Maquocgia='')
		AND (Diadiemnhanhangcuoicung = @Macang OR @Macang = '')

Go

Exec Baocaophantichdulieuxnk '01/01/2022', '05/30/2022','',''
