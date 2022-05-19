------------------------Tạo view Dondathang_d_dieuchinhcuoi-------------
If Object_ID('dbo.Dondathangkhachnoidia_d_dieuchinhcuoi','V') is not null
	Drop VIEW dbo.Dondathangkhachnoidia_d_dieuchinhcuoi;
Go

CREATE VIEW Dondathangkhachnoidia_d_dieuchinhcuoi
AS
	SELECT *
		, CASE WHEN ISNULL(dct.Sobaogiadieuchinh,'')<>'' THEN dct.Sobaogiadieuchinh ELSE dct.Sobaogia END AS Chotsobaogia
		, ISNULL(dct.Dongiadieuchinh,dct.Dongia) AS Chotdongia
		, ISNULL(dct.Soluongdieuchinh,dct.Soluong) AS Chotsoluong
		, ISNULL(dct.Ngaygiaodieuchinh,dct.Ngaygiao) AS Chotngaygiao
		, ISNULL((SELECT Sum(Soluong) FROM dbo.Phieugiaohang_d WHERE Madondathangchitiet = dct.Id),0) AS Soluongdagiao
		, ISNULL(dct.Soluongdieuchinh,dct.Soluong)
			- ISNULL((SELECT Sum(Soluong) FROM dbo.Phieugiaohang_d WHERE Madondathangchitiet = dct.Id),0) AS Soluongconlai
	FROM dbo.Dondathangcuakhach_d dct
	WHERE id NOT IN (SELECT Iddieuchinhtruoc FROM dbo.Dondathangcuakhach_d WHERE ISNULL(Iddieuchinhtruoc,'')<>'')
	
Go	

SELECT * FROM Dondathangkhachnoidia_d_dieuchinhcuoi

--SELECT * FROM dbo.Phieugiaohang_d
--SELECT * FROM dbo.Dondathang_d
