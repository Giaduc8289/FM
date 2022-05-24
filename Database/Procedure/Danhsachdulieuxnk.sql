------------------------Danh sách đơn đặt hàng-------------
If Object_ID('dbo.Danhsachdulieuxnk','P') is not null
	Drop Procedure dbo.Danhsachdulieuxnk;
Go

Create Procedure dbo.Danhsachdulieuxnk
	@Tungay		Datetime,
	@Denngay	Datetime
  As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	Select Distinct Nam, Thang
	From dbo.Dulieuxnk
	Where Ngaythongquan BETWEEN @Tungay AND @Denngay
	ORDER BY Nam DESC, Thang Desc
Go

Exec Danhsachdulieuxnk '01/01/2022', '12/31/2022'
