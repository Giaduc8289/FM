------------------------Báo giá -------------
If Object_ID('dbo.Inbaogiachokhachnoidia','P') is not null
	Drop Procedure dbo.Inbaogiachokhachnoidia;
Go
Create Procedure dbo.Inbaogiachokhachnoidia
	@Ngaybaogia		DATETIME,
	@Sobaogia		NVARCHAR(20)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	SELECT bg.*, hh.Loai
		, Diachi, Sodienthoai, Sofax, Masothue, Taikhoannganhang, Tennganhang, Email
		, Nguoilienhehoten, Nguoilienhechucvu, Nguoilienhesodienthoai, Nguoilienhethongtinbosung, Tenrutgon
	FROM dbo.Baogiachokhach_d bg LEFT JOIN dbo.Danhmuchanghoa hh ON hh.Mahieu=bg.Mahang
		LEFT join Danhmuckhach kh on kh.Mahieu = hh.Makhach
	WHERE Sobaogia = @Sobaogia AND Ngaybaogia = @Ngaybaogia

GO

EXEC dbo.Inbaogiachokhachnoidia '12/07/2021','BG01-GHTK'

SELECT * FROM dbo.Baogiachokhach_d