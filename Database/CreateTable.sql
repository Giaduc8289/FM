-----Filler Masterbatch-------------Sản xuất hạt Bical------------
------------------------------------------------------------------
Create table Danhmuckhach(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250) Not null,
Tenrutgon	Nvarchar(50),
Diachi		Nvarchar(250),
Sodienthoai	Nvarchar(100),
Sofax		NVARCHAR(100),
Masothue	NVARCHAR(100),
Taikhoannganhang	NVARCHAR(100),
Tennganhang		NVARCHAR(250),
Email		Nvarchar(100),
Noidia		BIT	DEFAULT 1,
Truyenthong	Bit default 1,
Nguoilienhehoten	NVARCHAR(100),
Nguoilienhechucvu	NVARCHAR(100),
Nguoilienhesodienthoai	NVARCHAR(100),
Nguoilienhethongtinbosung	NVARCHAR(250),
Manhanvien		Nvarchar(50),
Tennhanvien		Nvarchar(250),
Macode			Nvarchar(Max),
Mafiller		Nvarchar(Max),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmuckhach_PK primary key (Mahieu)) ON [PRIMARY]


Create table Danhmucungdung(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucungdung_PK primary key (Mahieu)) ON [PRIMARY]


Create table Danhmuchanghoa(
Mahieu		Nvarchar(50) Not null,	---Code Filler
Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mahangphiakhach		Nvarchar(50),
Maungdung			Nvarchar(50),
Tocdomay			Decimal(20,2),
Caco3kh				Decimal(20,2),
Tio2kh			Decimal(20,2),
Mikh			Nvarchar(50),
Khackh			Nvarchar(250),
Caco3fm				Decimal(20,2),
Tio2fm			Decimal(20,2),
Mifm			Nvarchar(50),
Khacfm			Nvarchar(250),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Danhmuchanghoa_Danhmucloai_FK Foreign Key (Maloai) References Danhmucloai (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Danhmucmanh_FK Foreign Key (Mamanh) References Danhmucmanh (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Hinhthuchanghoa_FK Foreign Key (Mahinhthuc) References Hinhthuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuchanghoa_PK primary key (Mahieu)) ON [PRIMARY]


CREATE TABLE Donvitinh(
Mahieu		NVARCHAR(50) NOT NULL,
Tenhieu			NVARCHAR(50),
Tentienganh		NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Donvitinh_PK primary key (Mahieu)) ON [PRIMARY]

-----Hợp đồng bán hàng-------------------------------------------------
-----------------------------------------------------------------------
CREATE TABLE Hopdongbanhang(
Sohopdong		Nvarchar(50) Not Null,
Ngayhopdong		Date,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Macangden			Nvarchar(50),
Tencangden			Nvarchar(250),
Thanhtienvnd	Decimal(20,2),
Thanhtienusd	Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hopdongbanhang_PK primary key (Sohopdong)) ON [PRIMARY]

Create Table Hopdongbanhangchitiet(
Id		Bigint Identity Not null,
Sohopdong		Nvarchar(50),
Ngayhopdong		Date,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Macangden			Nvarchar(50),
Tencangden			Nvarchar(250),
Mahangphiakhach		Nvarchar(50),
Codefiller			Nvarchar(50),
Soluong			Decimal(20,2),
Ngaygiao		Date,
Dongiavnd		Decimal(20,2),
Tygia			Decimal(20,2),
Dongiausd		Decimal(20,4),
Thanhtienvnd	Decimal(20,2),
Thanhtienusd	Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hopdongbanhangchitiet_PK primary key (Id)) ON [PRIMARY]


CREATE TABLE Thuchienhopdongbanhang(
Id		Bigint Identity Not null,
Sohopdong		Nvarchar(50),
Ngayhopdong		Date,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Mahangphiakhach		Nvarchar(50),
Codefiller			Nvarchar(50),
Soluonggiao		Decimal(20,2),
Ngaygiao		Date,
Dongiavnd		Decimal(20,2),
Tygia			Decimal(20,2),
Dongiausd		Decimal(20,4),
Thanhtienvnd	Decimal(20,2),
Thanhtienusd	Decimal(20,2),
Thanhtoanvnd	Decimal(20,2),
Thanhtoanusd	Decimal(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Thuchienhopdongbanhang_PK primary key (Id)) ON [PRIMARY]



-----Xuất khẩu---------------------------------------------------------
-----------------------------------------------------------------------
CREATE TABLE Phuongthucthanhtoan(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	NVARCHAR(50),
Deposit		DECIMAL(20,2),
Pay			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phuongthucthanhtoan_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Formco(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Formco_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Danhmucnganhang(
Mahieu			NVARCHAR(50) Not null,
AccountHolder		NVARCHAR(250),
Bank			NVARCHAR(250),
Address			NVARCHAR(250),
Accountnumber	NVARCHAR(50),
Swift			NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucnganhang_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Danhmuccang(
Mahieu			NVARCHAR(50) Not null,
Tenhieu			NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Maquocgia			NVARCHAR(50),
Tenquocgia			NVARCHAR(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmuccang_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Danhmucquocgia(
Mahieu			NVARCHAR(50) Not null,
Tenhieu			NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucquocgia_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Phuongthucvanchuyen(
Mahieu			NVARCHAR(50) Not null,
Tenhieu			NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phuongthucvanchuyen_PK primary key (Mahieu)) ON [PRIMARY]

Create Table Cacbuoclogistic(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Cacbuoclogistic_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Thuchienlogistic(
Id		Bigint Identity Not null,
Sohopdong		Nvarchar(50),
Ngayhopdong		Date,
Makhach			Nvarchar(50),
Tenkhach		Nvarchar(250),
Mahangphiakhach		Nvarchar(50),
Codefiller			Nvarchar(50),
Soluonggiao		Decimal(20,2),
Ngaygiao		Date,
Buoclogistic		Nvarchar(50),
Tenbuoclogistic		Nvarchar(250),
Ngaythuchien		Date,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Thuchienlogistic_PK primary key (Id)) ON [PRIMARY]







-----Khác------------------------------------------------------
---------------------------------------------------------------
CREATE TABLE Tygia(
Thang		Nvarchar(20) Not null,
Tygia		DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Tygia_PK primary key (Thang)) ON [PRIMARY]



CREATE TABLE Nhanvien(
Manhanvien			NVARCHAR(50) NOT NULL,
Hoten			NVARCHAR(50),
Maphongban			NVARCHAR(50),
Tenphongban			Nvarchar(250),
Machucvu			NVARCHAR(50),
Tenchucvu			Nvarchar(250),
Gioitinh		BIT,
Ngaysinh		DATE,
Diachi			NVARCHAR(250),
Sodienthoai		NVARCHAR(50),
Email			NVARCHAR(50),
CONSTRAINT Nhanvien_PK primary key (Manhanvien)) ON [PRIMARY]

Create Table Phongban(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phongban_PK primary key (Mahieu)) ON [PRIMARY]

Create Table Danhmucchucvu(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	Nvarchar(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucchucvu_PK primary key (Mahieu)) ON [PRIMARY]









-----Quản trị-----------------------------------------------------
------------------------------------------------------------------
Create table Logbackup(
	Mahieu bigint IDENTITY(1,1) NOT NULL,
	Nam int NULL,
	Duongdan nvarchar(250) NULL,
	Ngay datetime NULL,
 constraint Logbackup_PK PRIMARY KEY (Mahieu) 
) ON [PRIMARY]

Create table Roles(
Rolesid			Nvarchar(50) Not null,
Rolesname		Nvarchar(50),
Description		Nvarchar(200),
constraint Roles_PK primary key (Rolesid)) ON [PRIMARY]

Create table Menu(
	MenuId Nvarchar(20) NOT NULL,
	MenuName Nvarchar(500) NULL,
	Icon Nvarchar(500) NULL,
	Issudung int NULL,
	Istrangthai int NULL,
	Menuparent Nvarchar(50) NULL,
	Thutu int NULL,
	FormName Nvarchar(1000) NULL,
	LoaiMenu int NULL,
	Param Nvarchar(500) NULL,
	Maphanhe Nvarchar(50) NULL,
 constraint Menu_PK PRIMARY KEY (MenuId) 
) ON [PRIMARY]

Create table Menurole(
Menuid			Nvarchar(20) not null,
Rolesid			Nvarchar(50) not null,
constraint Menurole_PK primary key (Menuid, Rolesid),
constraint Menurole_Roles_FK Foreign Key (Rolesid) References Roles (Rolesid) On Delete No Action On Update Cascade,
constraint Menurole_Menu_FK Foreign Key (Menuid) References Menu (Menuid) On Delete No Action On Update Cascade) ON [PRIMARY]

Create table Users(
	Userid Nvarchar(50) NOT NULL,
	Rolesid Nvarchar(50) NOT NULL,
	Username Nvarchar(150) NOT NULL,
	Fullname Nvarchar(500) NULL,
	Phone Nvarchar(50) NULL,
	Address Nvarchar(500) NULL,
	Password Nvarchar(50) NOT NULL,
	Active		Bit default 1,	
 constraint Users_PK PRIMARY KEY (Userid),
 constraint Users_Roles_FK Foreign Key (Rolesid) References Roles (Rolesid) On Delete No Action On Update Cascade  
) ON [PRIMARY]

Create table Dmcapma(
	Macappk	Nvarchar(50) NOT NULL,
	Loaima	Nvarchar(50) NOT NULL,
	Mastart	Nvarchar(50) NULL,
 CONSTRAINT Dmcapma_PK PRIMARY KEY (Loaima) 
) ON [PRIMARY]

Create table Thamso(
Mahieu			Nvarchar(20) not null,
Stt				Int not null,
Tenthamso		Nvarchar(200) not null,
Giatri			Nvarchar(200),
Thaydoi			Bit default 1 not null,
Kieudulieu		Int not null, --1: Ký tự, 2: Số, 3: Ngày tháng, 4: Boolean, 
Ghichu			Nvarchar(200),
Loaithamso		Int,
An 			Bit default 0,
constraint Thamso_PK primary key (Mahieu)) ON [PRIMARY]
