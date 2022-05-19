------------------------Danh sach chi phi ban hang theo hang-------------
If Object_ID('dbo.Danhsachchiphibanhangtheohang','P') is not null
	Drop Procedure dbo.Danhsachchiphibanhangtheohang;
Go

Create Procedure dbo.Danhsachchiphibanhangtheohang
--With Encryption As
As	SET NOCOUNT ON;
	SET XACT_ABORT ON;
	
	Select Distinct Thang--, Makhach, Tenkhach
	From Chiphibanhangtheohang 

Go

Exec Danhsachchiphibanhangtheohang
