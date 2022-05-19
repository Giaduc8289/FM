------------------------Danh sach tong hop chi phi chung-------------
If Object_ID('dbo.Danhsachtonghopchiphichung','P') is not null
	Drop Procedure dbo.Danhsachtonghopchiphichung;
Go

Create Procedure dbo.Danhsachtonghopchiphichung
--With Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Thang--, Makhach, Tenkhach
	From dbo.Tonghopchiphichung 

Go

Exec Danhsachtonghopchiphichung
