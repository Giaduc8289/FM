------------------------Danh sách báo giá chọn-------------
If Object_ID('dbo.Danhsachbaogiakhachnoidiachon','P') is not null
	Drop Procedure dbo.Danhsachbaogiakhachnoidiachon;
Go

Create Procedure dbo.Danhsachbaogiakhachnoidiachon
	@Sobaogia		nvarchar(250)
As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Id, bg.Sobaogia, bg.Ngaybaogia, bg.Ngayhieuluc, bg.Chungloai, bg.Kichthuoc, bg.Trongluongbao, bg.Trongluongpe
		, bg.Dongiatongchuavat, bg.Dongiatongcovat
		, bg.Ghichu, bg.Giavon
		, dmhh.Mahieu AS Mahang, Mauin, dmhh.Loai
		, dmhh.Makhach, 0 AS Loaihang
	From Baogiachokhach_d bg LEFT JOIN Danhmuchanghoa dmhh ON bg.Mahang = dmhh.Mahieu
	Where bg.Sobaogia = @Sobaogia AND ISNULL(bg.Loaihang,0)=0
	--UNION
	--Select Id, bg.Sobaogia, bg.Ngaybaogia, bg.Ngayhieuluc, bg.Chungloai, bg.Kichthuoc, bg.Trongluongbao, bg.Trongluongpe
	--	, bg.Dongiabaochuavat, bg.Dongiabaocovat, bg.Dongiapechuavat, bg.Dongiapecovat, bg.Dongiatongchuavat, bg.Dongiatongcovat
	--	, bg.Ghichu, bg.Giavon
	--	, pe.Mahieu AS Mahang, pe.Mahieu AS Mauin, N'Túi' AS Loai
	--	, bgh.Makhach, NULL AS Ngaymarket, bg.Loaihang
	--From Baogiachokhach_d bg left join Danhmucpe pe ON pe.Mahieu=bg.Mahang
	--	LEFT JOIN dbo.Baogiachokhach_h bgh ON bgh.Sobaogia = bg.Sobaogia 
	--Where bg.Sobaogia = @Sobaogia AND bg.Loaihang=1
	--UNION
	--Select Id, bg.Sobaogia, bg.Ngaybaogia, bg.Ngayhieuluc, bg.Chungloai, bg.Kichthuoc, bg.Trongluongbao, bg.Trongluongpe
	--	, bg.Dongiabaochuavat, bg.Dongiabaocovat, bg.Dongiapechuavat, bg.Dongiapecovat, bg.Dongiatongchuavat, bg.Dongiatongcovat
	--	, bg.Ghichu, bg.Giavon
	--	, dmm.Mahieu AS Mahang, dmm.Mahieu AS Mauin, N'Manh' AS Loai
	--	, bgh.Makhach, NULL AS Ngaymarket, bg.Loaihang
	--From Baogia_d bg left join dbo.Danhmucmanh dmm on dmm.Mahieu = bg.Mahang
	--	LEFT JOIN dbo.Baogia_h bgh ON bgh.Sobaogia = bg.Sobaogia 
	--Where bg.Sobaogia = @Sobaogia AND bg.Loaihang=2
	
Go

Exec Danhsachbaogiakhachnoidiachon '01012021HCVT'
--SELECT * FROM dbo.Baogia_d WHERE Sobaogia='001'
--SELECT * FROM dbo.Baogia_h