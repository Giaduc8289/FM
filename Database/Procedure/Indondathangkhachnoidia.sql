------------------------Đơn đặt hàng -------------
If Object_ID('dbo.Indondathangkhachnoidia','P') is not null
	Drop Procedure dbo.Indondathangkhachnoidia;
Go
Create Procedure dbo.Indondathangkhachnoidia
	@Madondathang		NVARCHAR(20)
With Encryption As
	SET NOCOUNT ON;
	SET XACT_ABORT ON;


	SELECT dh.Id, dh.Mahang, dh.Mauin, Madondathang, Sopo, Sobaogia, dmhh.Makhach
			, REPLACE(REPLACE(dh.Chungloai,' '+dmhh.Tenmau,''),' '+dmhh.Kichthuocbao,'')
				+ CASE WHEN ISNULL(dmhh.Chatluongkhachyeucau,'')<>'' THEN ', '+dmhh.Chatluongkhachyeucau
					ELSE '' END As Chungloai
			, dmhh.Loai
			, dmhh.Mauin, dmhh.Kichthuocbao, dmhh.Trongluongbao, dmhh.KichthuocPE, dmhh.TrongluongPE, dmhh.Tenmau
			, dh.Chotsobaogia Sobaogia, dh.Chotdongia Dongia, dh.Chotngaygiao Ngaygiao, dh.Chotsoluong Soluong
			, Ghichu
	FROM dbo.Dondathangkhachnoidia_d_dieuchinhcuoi dh LEFT JOIN dbo.Danhmuchanghoa dmhh ON dmhh.Mahieu = dh.Mahang
	WHERE dh.Madondathang = @Madondathang AND ISNULL(Loaihang,0)=0
	UNION
	SELECT dh.Id, dh.Mahang, dh.Mauin, Madondathang, dh.Sopo, dh.Sobaogia, dh.Makhach
			, dh.Chungloai
			, dh.Loai
			, dh.Mauin, bg.Kichthuoc, bg.Trongluongpe, bg.Kichthuoc, bg.Trongluongpe, '' AS Tenmau
			, dh.Chotsobaogia Sobaogia, dh.Chotdongia Dongia, dh.Chotngaygiao Ngaygiao, dh.Chotsoluong Soluong
			, dh.Ghichu
	FROM dbo.Dondathangkhachnoidia_d_dieuchinhcuoi dh LEFT JOIN dbo.Baogiachokhach_d bg ON bg.Sobaogia = dh.Sobaogia AND bg.Mahang = dh.Mahang
	WHERE dh.Madondathang = @Madondathang AND ISNULL(dh.Loaihang,0)=1
	--UNION
	--SELECT dh.Id, dh.Mahang, dh.Mauin, Madondathang, dh.Sopo, dh.Sobaogia, dh.Makhach
	--		, dh.Chungloai
	--		, dh.Loai
	--		, dh.Mauin, bg.Kichthuoc, bg.Trongluongbao, bg.Kichthuoc, bg.Trongluongpe, dmm.Mausac As Tenmau
	--		, dh.Chotsobaogia Sobaogia, dh.Chotdongia Dongia, dh.Chotngaygiao Ngaygiao, dh.Chotsoluong Soluong
	--		, dh.Ghichu
	--FROM dbo.Dondathang_D_dieuchinhcuoi dh LEFT JOIN dbo.Baogiachokhach_d bg ON bg.Sobaogia = dh.Sobaogia AND bg.Mahang = dh.Mahang
	--	LEFT JOIN dbo.Danhmucmanh_soi dmm ON dh.Mahang=dmm.Mahieu
	--WHERE dh.Madondathang = @Madondathang AND ISNULL(dh.Loaihang,0)=2
	
	ORDER BY dh.Chotngaygiao
	
GO

EXEC dbo.Indondathangkhachnoidia N'HĐ/01-GHTK'
--SELECT * FROM dbo.Danhmucmanh
--SELECT * FROM dbo.Danhmuchanghoa
--SELECT * FROM dbo.Dondathang_D_dieuchinhcuoi
--SELECT * FROM dbo.Baogia_d