CREATE TABLE Donvitinh(
Mahieu		NVARCHAR(50) NOT NULL,
Tenhieu			NVARCHAR(50),
Tentienganh		NVARCHAR(50),
constraint Donvitinh_PK primary key (Mahieu)) ON [PRIMARY]


CREATE TABLE Baogiaxuatkhau_h(
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Noidung			NVARCHAR(MAX),
Maphuongthuctt			NVARCHAR(50),
Macanggiao				NVARCHAR(50),
Phuongthucthanhtoan		NVARCHAR(250),
Diadiemgiao		NVARCHAR(250), -----Port 
PortCIF			NVARCHAR(250),
PortFOB			NVARCHAR(250),
Kieudongkien	Nvarchar(50),
Packaging		NVARCHAR(MAX),
Tolerance		NVARCHAR(MAX),
Loaigia			INT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Baogiaxuatkhau_h_PK primary key (Sobaogia)) ON [PRIMARY]

ALTER TABLE dbo.Baogiaxuatkhau_h ALTER COLUMN Loaigia			INT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
ALTER TABLE dbo.Baogiaxuatkhau_h ADD Loaigia			BIT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
Kieudongkien	Nvarchar(50),
Maphuongthuctt			NVARCHAR(50),
Macanggiao				NVARCHAR(50),

CREATE TABLE Baogiaxuatkhau_d(
Id				BIGINT IDENTITY NOT NULL,
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Donvitinh		NVARCHAR(50),
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Chungloai		NVARCHAR(MAX),
Mota			NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),
DongiabaoCIF	DECIMAL(20,4),
DongiapeCIF		DECIMAL(20,4),
DongiatongCIF	DECIMAL(20,4),	
DongiabaoFOB	DECIMAL(20,4),
DongiapeFOB		DECIMAL(20,4),
DongiatongFOB	DECIMAL(20,4),	
DongiatongCNF			DECIMAL(20,4),
DongiatongExworks		DECIMAL(20,4),
Ghichu				NVARCHAR(250),
Giavon			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Baogiaxuatkhau_d_Baogiaxuatkhau_h_FK Foreign Key (Sobaogia) References Baogiaxuatkhau_h (Sobaogia) On Delete No Action On Update Cascade,
constraint Baogiaxuatkhau_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN Chungloai		NVARCHAR(MAX)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiabaoCIF	DECIMAL(20,4)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiapeCIF	DECIMAL(20,4)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiatongCIF	DECIMAL(20,4)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiabaoFOB	DECIMAL(20,4)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiapeFOB	DECIMAL(20,4)
ALTER TABLE dbo.Baogiaxuatkhau_d ALTER COLUMN DongiatongFOB	DECIMAL(20,4)

ALTER TABLE dbo.Baogiaxuatkhau_d ADD DongiatongCNF			DECIMAL(20,4),
DongiatongExworks		DECIMAL(20,4),
Donvitinh		NVARCHAR(50),

CREATE TABLE Dondathangxuatkhau_h(
Madondathang	NVARCHAR(50) NOT NULL,
Ngaydat			DATE,
Sopo			NVARCHAR(50),
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Manhanvien			NVARCHAR(50),
Hoten			NVARCHAR(50),
Ghichu			NVARCHAR(MAX),
Phuongthucvanchuyen		NVARCHAR(250),
Phuongthucthanhtoan		NVARCHAR(250),
SohieuLC			NVARCHAR(50),
NgaymoLC			DATE,
Deposit				DECIMAL(20,2),
Pay					DECIMAL(20,2),				
Kieudongkien	Nvarchar(50),
Packaging		NVARCHAR(MAX),
PortFOB			NVARCHAR(250),
PortCIF			NVARCHAR(250),
Manganhang		NVARCHAR(50),
MaFormCo		NVARCHAR(50),
Loaigia			BIT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
Hangiaohang			NVARCHAR(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dondathangxuatkhau_h_PK primary key (Madondathang)) ON [PRIMARY]

ALTER TABLE dbo.Dondathangxuatkhau_h ALTER COLUMN Loaigia			INT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
ALTER TABLE dbo.Dondathangxuatkhau_h ADD Hangiaohang			NVARCHAR(250),
Loaigia			BIT,			-----0: FOB; 1: CIF; 2: CNF; 3: Exworks
Kieudongkien	Nvarchar(50),

CREATE TABLE Dondathangxuatkhau_d(
Id				BIGINT IDENTITY NOT NULL,
Madondathang	NVARCHAR(50) NOT NULL,
Ngaydat			DATE,
Sopo		NVARCHAR(50),
Makhach		NVARCHAR(50),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Donvitinh		NVARCHAR(50),
Mahang		NVARCHAR(50),
Tenhang		NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Chungloai	NVARCHAR(MAX),
Sobaogia		NVARCHAR(50),
Soluong			INT,
Dongia			DECIMAL(20,4),
Ngaygiao		DATE,
Ngayhethanpo		DATE,
Ngaydieuchinh		DATE,
Sobaogiadieuchinh	NVARCHAR(50),
Soluongdieuchinh	INT,
Dongiadieuchinh		DECIMAL(20,4),
Ngaygiaodieuchinh	DATE,
Iddieuchinhtruoc	BIGINT,
Ngaymarket			DATE,
Ghichu				NVARCHAR(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dondathangxuatkhau_d_Dondathangxuatkhau_h_FK Foreign Key (Madondathang) References Dondathangxuatkhau_h (Madondathang) On Delete No Action On Update Cascade,
constraint Dondathangxuatkhau_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Dondathangxuatkhau_d ALTER COLUMN Chungloai	NVARCHAR(MAX)
ALTER TABLE dbo.Dondathangxuatkhau_d ALTER COLUMN Dongia			DECIMAL(20,4)
ALTER TABLE dbo.Dondathangxuatkhau_d ALTER COLUMN Dongiadieuchinh			DECIMAL(20,4)
ALTER TABLE dbo.Dondathangxuatkhau_d ADD Donvitinh		NVARCHAR(50),

-----Kế hoạch xuất hàng
CREATE TABLE Phieuxuathangxuatkhau(
Sophieuxuat		NVARCHAR(50) NOT NULL,
Ngayxuat		DATE,
Thoigianbatdau		NVARCHAR(50),
Thoigianketthuc		NVARCHAR(50),
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phieuxuathangxuatkhau_PK primary key (Sophieuxuat)) ON [PRIMARY]

ALTER TABLE dbo.Phieuxuathangxuatkhau ALTER COLUMN Thoigianbatdau NVARCHAR(50) 
ALTER TABLE dbo.Phieuxuathangxuatkhau ALTER COLUMN Thoigianketthuc NVARCHAR(50)

-----Kế hoạch xuất hàng chi tiết
CREATE TABLE Hanggiaoxuatkhau(
Id			BIGINT IDENTITY NOT NULL,
Sophieuxuat		NVARCHAR(50) NOT NULL,
Ngayxuat		DATE,
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Socontainer			NVARCHAR(50),
Kichcocontainer		NVARCHAR(50),
Khoiluongcontainer	DECIMAL(20,2),
Ghichucontainer		NVARCHAR(250),
Madonhang		NVARCHAR(50),
Makhach			NVARCHAR(50),
Iddondathang_d			BIGINT,
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Donvitinh		NVARCHAR(50),
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluongdat			INT,
Soluongdagiao		INT,
Soluonggiao			INT,
Sokien			INT,
Sothutuxep		INT,
Ghichu				NVARCHAR(250),
Ngaygiao		DATE,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hanggiaoxuatkhau_Dondathangxuatkhau_d_FK Foreign Key (Iddondathang_d) References Dondathangxuatkhau_d (Id) On Delete No Action On Update Cascade,
constraint Hanggiaoxuatkhau_Phieuxuathangxuatkhau_FK Foreign Key (Sophieuxuat) References Phieuxuathangxuatkhau (Sophieuxuat) On Delete No Action On Update Cascade,
CONSTRAINT Hanggiaoxuatkhau_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Hanggiaoxuatkhau ADD Donvitinh		NVARCHAR(50),
Khoiluongcontainer	DECIMAL(20,2),
Socontainer			NVARCHAR(50),
Kichcocontainer		NVARCHAR(50),
Ghichucontainer		NVARCHAR(250),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh

---------Phiếu xuất hàng bán (đề nghị xuất hóa đơn)
CREATE TABLE Phieugiaohangxuatkhau_h(
Sophieugiao		NVARCHAR(50) NOT NULL,
Ngaygiao		DATE,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat			DATE,
Madonhang		NVARCHAR(50),
Ngaydat			DATE,
Sopo			NVARCHAR(50),
Ngayden		DATE,
Sobl		NVARCHAR(250),
Tau			NVARCHAR(250),
--Sobaogia		NVARCHAR(50),
Makhach			NVARCHAR(50),
Tenkhach			Nvarchar(250),
Tongtien		DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Phieugiaohangxuatkhau_h_PK primary key (Sophieugiao)) ON [PRIMARY]

ALTER TABLE dbo.Phieugiaohangxuatkhau_h ADD Ngayden		DATE,
Sobl		NVARCHAR(250),
Tau			NVARCHAR(250),

CREATE TABLE Phieugiaohangxuatkhau_d(
Id			BIGINT IDENTITY NOT NULL,
Sophieugiao		NVARCHAR(50) NOT NULL,
Ngaygiao		DATE,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
Madonhang		NVARCHAR(50),
Makhach			NVARCHAR(50),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Donvitinh		NVARCHAR(50),
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluong			INT,
Dongia			DECIMAL(20,4),
Thanhtien		DECIMAL(20,2),
Ghichu			NVARCHAR(250),
Madondathangchitiet			BIGINT,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phieugiaohangxuatkhau_d_Phieugiaohangxuatkhau_h_FK Foreign Key (Sophieugiao) References Phieugiaohangxuatkhau_h (Sophieugiao) On Delete No Action On Update Cascade,
CONSTRAINT Phieugiaohangxuatkhau_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Phieugiaohangxuatkhau_d ALTER COLUMN Dongia			DECIMAL(20,4)
ALTER TABLE dbo.Phieugiaohangxuatkhau_d ADD Donvitinh		NVARCHAR(50),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh

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

ALTER TABLE dbo.Phuongthucthanhtoan ADD Deposit		DECIMAL(20,2),
Pay			DECIMAL(20,2),

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




CREATE TABLE Danhmucmang(
Id			BigInt Identity Not null,
Mahieu		Nvarchar(20) Not null,
Tenhieu		NVARCHAR(250),
Dongia		DECIMAL(20,2),
Ngay		DATE,

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucmang_PK primary key (Id)) ON [PRIMARY]


CREATE TABLE Danhmucdayxienluon(
Id			BigInt Identity Not null,
Mahieu		Nvarchar(20) Not null,
Tenhieu		NVARCHAR(250),
Dongia		DECIMAL(20,2),
Ngay		DATE,

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucdayxienluon_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Danhmucchimay(
Id			BigInt Identity Not null,
Mahieu		Nvarchar(20) Not null,
Tenhieu		NVARCHAR(250),
Dongia		DECIMAL(20,2),
Ngay		DATE,

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucchimay_PK primary key (Id)) ON [PRIMARY]

DROP TABLE dbo.Danhmucchimay

CREATE table Danhmucmauhang(        --Taodungmauhang(
Mahieu		Nvarchar(50) Not null,	---Mã của mẫu hàng
Chungloai			NVARCHAR(MAX),

Mahangphiakhach		NVARCHAR(50),
Mabophansanxuat		NVARCHAR(50),

Maloai			Nvarchar(20),
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Kichthuocbao		Nvarchar(250),
Trongluongbao		DECIMAL(20,2),
MaPE				NVARCHAR(50),	---Bổ sung quản lý PE theo danh mục
MaloaiPE			NVARCHAR(20),
KichthuocPE			NVARCHAR(250),
TrongluongPE		DECIMAL(20,2),
Mamau			NVARCHAR(20),
Tenmau			NVARCHAR(100),

Hinhthuctrang	NVARCHAR(50),
Kieugap			Nvarchar(250),
Kieumayday		Nvarchar(250),
Loaichimay		Nvarchar(250),
Kieudongkien	Nvarchar(250),
Kieuvienmieng	NVARCHAR(250),
Loaidayxienluon		NVARCHAR(50),
Mamang			NVARCHAR(50),

--Chatluongkhachyeucau		NVARCHAR(MAX),
--Chatluongnoibo			NVARCHAR(MAX),

--Ngaymarket		DATETIME,

-----Phục vụ tính giá
Mamanh			Nvarchar(50),	
Tenmanh				Nvarchar(250),	
Masoi			Nvarchar(20),
Tensoi				Nvarchar(250),	
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
Kichthuoccat		Nvarchar(250),
Chieudaicat			Decimal(20,2),
Loaimayin		Nvarchar(20),
Codem			BIT,
Madongmay		NVARCHAR(250),

--Tinhtrang		INT, --0: Chưa duyệt, 1: Đã duyệt
Ngaytinhgia		DATE,				-----Chọn ngày khi tính giá
Makhach			Nvarchar(50),		---Phục vụ tạo key chính, Thêm vào danh mục hàng hóa cho khách hàng, Chọn khách khi tính giá bán cho sợi, manh
Tenkhach		Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính, Nhập mẫu in khi thêm vào danh mục hàng hóa

-----Phục vụ lưu chi phí, giá
cpnguyenlieusoi		DECIMAL(20,2),
cpgiacongsoi		DECIMAL(20,2),
cpchungsoi			DECIMAL(20,2),
cpbanhangsoi		DECIMAL(20,2),
giavonsoi				DECIMAL(20,2),
loinhuansoi				DECIMAL(20,2),
giabansoi				DECIMAL(20,2),

cpnguyenlieumanh	DECIMAL(20,2),
cpgiacongmanh		DECIMAL(20,2),
cpchungmanh			DECIMAL(20,2),
cpbanhangmanh		DECIMAL(20,2),
giavonmanh				DECIMAL(20,2),
loinhuanmanh			DECIMAL(20,2),
giabanmanh				DECIMAL(20,2),

cpnguyenlieuhang	DECIMAL(20,2),
cpgiaconghang		DECIMAL(20,2),
cpchunghang			DECIMAL(20,2),
cpbanhanghang		DECIMAL(20,2),
cpnguyenlieupe		DECIMAL(20,2),
cpgiacongpe			DECIMAL(20,2),
giavonhangcai			DECIMAL(20,2),
loinhuanhangcai			DECIMAL(20,2),
giabanhangcai			DECIMAL(20,2),
giavonhangkg			DECIMAL(20,2),
loinhuanhangkg			DECIMAL(20,2),
giabanhangkg			DECIMAL(20,2),


Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Danhmucmauhang_Danhmucloai_FK Foreign Key (Maloai) References Danhmucloai (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Danhmucmanh_FK Foreign Key (Mamanh) References Danhmucmanh (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Hinhthuchanghoa_FK Foreign Key (Mahinhthuc) References Hinhthuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucmauhang_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Danhmucmauhang ADD Mamang			NVARCHAR(50),
cpnguyenlieusoi		DECIMAL(20,2),
cpgiacongsoi		DECIMAL(20,2),
cpchungsoi			DECIMAL(20,2),
cpbanhangsoi		DECIMAL(20,2),
giavonsoi				DECIMAL(20,2),
loinhuansoi				DECIMAL(20,2),
giabansoi				DECIMAL(20,2),

cpnguyenlieumanh	DECIMAL(20,2),
cpgiacongmanh		DECIMAL(20,2),
cpchungmanh			DECIMAL(20,2),
cpbanhangmanh		DECIMAL(20,2),
giavonmanh				DECIMAL(20,2),
loinhuanmanh			DECIMAL(20,2),
giabanmanh				DECIMAL(20,2),

cpnguyenlieuhang	DECIMAL(20,2),
cpgiaconghang		DECIMAL(20,2),
cpchunghang			DECIMAL(20,2),
cpbanhanghang		DECIMAL(20,2),
cpnguyenlieupe		DECIMAL(20,2),
cpgiacongpe			DECIMAL(20,2),
giavonhangcai			DECIMAL(20,2),
loinhuanhangcai			DECIMAL(20,2),
giabanhangcai			DECIMAL(20,2),
giavonhangkg			DECIMAL(20,2),
loinhuanhangkg			DECIMAL(20,2),
giabanhangkg			DECIMAL(20,2),
Loaidayxienluon		NVARCHAR(50),
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
MaPE				NVARCHAR(50),	---Bổ sung quản lý PE theo danh mục
MaloaiPE			NVARCHAR(20),


CREATE table Giavonhangban(
Id			BigInt IDENTITY Not null,
Thang			Nvarchar(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Chiphinguyenlieucai		DECIMAL(20,2),
Chiphigiacongcai		DECIMAL(20,2),
Chiphichungcai			DECIMAL(20,2),
Chiphibanhangcai		DECIMAL(20,2),
ChiphinguyenlieuPE		DECIMAL(20,2),
ChiphigiacongPE			DECIMAL(20,2),
	
Giavontheocai		Decimal(20,2),
Giavontheokg		Decimal(20,2),
Tyleloinhuan		DECIMAL(20,2),
Loinhuantheocai		DECIMAL(20,2),
Loinhuantheokg		DECIMAL(20,2),
Giabantheocai		DECIMAL(20,2),
Giabantheokg		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Giavonhangban_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Giavonhangban_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Giavonhangban ADD ChiphinguyenlieuPE		DECIMAL(20,2),
ChiphigiacongPE			DECIMAL(20,2),


CREATE TABLE Tygia(
Thang		Nvarchar(20) Not null,
Tygia		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Tygia_PK primary key (Thang)) ON [PRIMARY]


CREATE table Kehoachbanhang(
Id			BigInt IDENTITY Not null,
Thang			Nvarchar(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Sanluongtoida				DECIMAL(20,2),
Phantramcongsuatnhamay		DECIMAL(20,2),

Soluong			Int,
Ngaygiao		Datetime,
Mamanh				Nvarchar(50),	
Masoi				Nvarchar(20),	
Khoiluongmanh		Decimal(20,2),
Khoiluongsoi		Decimal(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Kehoachbanhang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Kehoachbanhang_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Kehoachbanhang DROP CONSTRAINT Kehoachbanhang_Danhmuchanghoa_FK

CREATE TABLE Congsuatnhamay(
Thang		NVARCHAR(20)  Not null,
Congsuatdukien			DECIMAL(20,2),
Congsuatthucte			DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Congsuatnhamay_PK primary key (Thang)) ON [PRIMARY]


CREATE TABLE Congsuattheohang(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Congsuatsoi			DECIMAL(20,2),	---Phần mềm tự tính dựa theo máy móc, nhân công
Congsuatdet			DECIMAL(20,2),
Congsuattrang		DECIMAL(20,2),
Congsuatin			DECIMAL(20,2),
Congsuatlechsuon		DECIMAL(20,2),
Congsuatcat			DECIMAL(20,2),
Congsuatmay			DECIMAL(20,2),
Congsuatlong		DECIMAL(20,2),
Congsuatvien		DECIMAL(20,2),
Congsuatdongkien	DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Congsuattheohang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuattheohang_PK primary key (Id)) ON [PRIMARY]


CREATE TABLE Hieusuatsanxuat(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Hieusuatsoi			DECIMAL(20,2),	---Người dùng ước lượng và cập nhật
Hieusuatdet			DECIMAL(20,2),
Hieusuattrang		DECIMAL(20,2),
Hieusuatin			DECIMAL(20,2),
Hieusuatlechsuon		DECIMAL(20,2),
Hieusuatcat			DECIMAL(20,2),
Hieusuatmay			DECIMAL(20,2),
Hieusuatlong		DECIMAL(20,2),
Hieusuatvien		DECIMAL(20,2),
Hieusuatdongkien	DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Hieusuatsanxuat_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Hieusuatsanxuat_PK primary key (Id)) ON [PRIMARY]


CREATE TABLE Sanluongtoida(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Sanluongsoi			DECIMAL(20,2),	---Sản lượng = Công suất * Hiệu suất 
Sanluongdet			DECIMAL(20,2),
Sanluongtrang		DECIMAL(20,2),
Sanluongin			DECIMAL(20,2),
Sanluonglechsuon		DECIMAL(20,2),
Sanluongcat			DECIMAL(20,2),
Sanluongmay			DECIMAL(20,2),
Sanluonglong		DECIMAL(20,2),
Sanluongvien		DECIMAL(20,2),
Sanluongdongkien	DECIMAL(20,2),
Sanluong			DECIMAL(20,2),  ---Là sản lượng thấp nhất của các công đoạn

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Sanluongtoida_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Sanluongtoida_PK primary key (Id)) ON [PRIMARY]


CREATE TABLE Danhmucchiphichung(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	NVARCHAR(50),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucchiphichung_PK primary key (Mahieu)) ON [PRIMARY]


CREATE TABLE Tonghopchiphichung(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Machiphi		NVARCHAR(50),
Tenchiphi		NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Chiphitong		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Tonghopchiphichung_Danhmucchiphichung_FK Foreign Key (Machiphi) References Danhmucchiphichung (Mahieu) On Delete No Action On Update Cascade,
constraint Tonghopchiphichung_PK primary key (Id)) ON [PRIMARY]



CREATE TABLE Chiphichungtheohang(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Sanluong			DECIMAL(20,2), -----Từ table Sanluongtoida

Machiphi		NVARCHAR(50),
Tenchiphi		NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Chiphitong			DECIMAL(20,2),-----Từ table Tonghopchiphichung
Chiphitheokg		DECIMAL(20,2),-----Chiphitheocai*1000/(Trongluongbao+Trongluongpe)
Chiphitheocai		DECIMAL(20,2),-----Chiphitong/Sanluong

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Chiphichungtheohang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphichungtheohang_PK primary key (Id)) ON [PRIMARY]


-----Chi phí bán hàng theo hàng
CREATE TABLE Danhmucchiphibanhang(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Tenrutgon	NVARCHAR(50),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucchiphibanhang_PK primary key (Mahieu)) ON [PRIMARY]


CREATE TABLE Chiphibanhangtheohang(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Machiphi		NVARCHAR(50),
Tenchiphi		NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Chiphitheokg		DECIMAL(20,2),
Chiphitheocai		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Chiphibanhangtheohang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphibanhangtheohang_PK primary key (Id)) ON [PRIMARY]


-----Chi phí nguyên liệu theo hàng
CREATE TABLE Chiphinguyenlieutheohang(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Masoi				NVARCHAR(20),
Macongthuc			NVARCHAR(50),
Chiphitheokg		DECIMAL(20,2),
Chiphitheocai		DECIMAL(20,2),

MaPE				NVARCHAR(50),
MacongthucPE		NVARCHAR(50),
ChiphinguyenlieuPE		DECIMAL(20,2),
Tongchiphitheocai		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Chiphinguyenlieutheohang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphinguyenlieutheohang_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Chiphinguyenlieutheohang ADD Tongchiphitheocai		DECIMAL(20,2),
MaPE				NVARCHAR(50),
MacongthucPE		NVARCHAR(50),
ChiphinguyenlieuPE		DECIMAL(20,2),


-----Chi phí gia công theo hàng
CREATE TABLE Chiphigiacongtheohang(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),
Mahang			Nvarchar(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Chungloai		NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),

Macongdoan		NVARCHAR(50),
Tencongdoan		NVARCHAR(250),
Chiphitheokg		DECIMAL(20,2),-----Chiphitheocai*1000/(Trongluongbao+Trongluongpe)
Chiphitheocai		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Chiphigiacongtheohang_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphigiacongtheohang_PK primary key (Id)) ON [PRIMARY]




-----Các bảng lưu trữ chi phí theo sợi, manh (kg)
-----Chi phí nguyên liệu theo sợi, manh (kg)
CREATE TABLE Chiphinguyenlieutheosoimanh(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),

Mamanh				NVARCHAR(50),
Masoi				NVARCHAR(20),
Macongthuc			NVARCHAR(50),
Chiphitheokg		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--CONSTRAINT Chiphinguyenlieutheosoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphinguyenlieutheosoimanh_PK primary key (Id)) ON [PRIMARY]

-----Chi phí gia công theo sợi, manh (kg)
CREATE TABLE Chiphigiacongtheosoimanh(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),

Mamanh				NVARCHAR(50),
Masoi				NVARCHAR(20),
Chiphisoitheokg	DECIMAL(20,2),
Chiphidettheokg		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--CONSTRAINT Chiphigiacongtheosoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphigiacongtheosoimanh_PK primary key (Id)) ON [PRIMARY]

-----Chi phí chung theo sợi, manh (kg)
CREATE TABLE Chiphichungtheosoimanh(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),

Mamanh				NVARCHAR(50),
Masoi				NVARCHAR(20),

Sanluong			DECIMAL(20,2), -----Từ table Sanluongtoida

Machiphi		NVARCHAR(50),
Tenchiphi		NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Chiphitong			DECIMAL(20,2),-----Từ table Tonghopchiphichung
Chiphitheokg		DECIMAL(20,2),-----Chiphitheocai*1000/(Trongluongbao+Trongluongpe)
--Chiphitheocai		DECIMAL(20,2),-----Chiphitong/Sanluong

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--CONSTRAINT Chiphichungtheosoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphichungtheosoimanh_PK primary key (Id)) ON [PRIMARY]


-----Chi phí bán hàng theo sợi, manh (kg)
CREATE TABLE Chiphibanhangtheosoimanh(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),

Machiphi		NVARCHAR(50),
Tenchiphi		NVARCHAR(250),
Tenrutgon		NVARCHAR(50),
Chiphisoitheokg		DECIMAL(20,2),
Chiphimanhtheokg	DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--CONSTRAINT Chiphibanhangtheosoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Chiphibanhangtheosoimanh_PK primary key (Id)) ON [PRIMARY]

-----Sản lượng sợi, manh (kg) (công suất tối đa, hiệu suất 100%, công suất nhà máy)
CREATE TABLE Sanluongsoimanh(
Id			BigInt Identity Not null,
Thang		NVARCHAR(20),

Mamanh				NVARCHAR(50),
Masoi				NVARCHAR(20),

Sanluongsoi			DECIMAL(20,2),	---Sản lượng = Công suất * Hiệu suất 
Sanluongdet			DECIMAL(20,2),
Sanluong			DECIMAL(20,2),  ---Là sản lượng thấp nhất của các công đoạn

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--CONSTRAINT Sanluongsoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Sanluongsoimanh_PK primary key (Id)) ON [PRIMARY]

CREATE table Giavonsoimanh(
Id			BigInt IDENTITY Not null,
Thang			Nvarchar(20),

Mamanh				NVARCHAR(50),
Masoi				NVARCHAR(20),

Chiphinguyenlieukg		DECIMAL(20,2),
Chiphigiacongkg			DECIMAL(20,2),
Chiphichungkg			DECIMAL(20,2),
Chiphibanhangkg			DECIMAL(20,2),
	
Giavontheokg		Decimal(20,2),
Tyleloinhuan		DECIMAL(20,2),
Loinhuantheokg		DECIMAL(20,2),
Giabantheokg		DECIMAL(20,2),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Giavonsoimanh_Danhmuchanghoa_FK Foreign Key (Mahang) References Danhmuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Giavonsoimanh_PK primary key (Id)) ON [PRIMARY]





CREATE TABLE Quycachin(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
constraint Quycachin_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Quycachgap(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
constraint Quycachgap_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Quycachmayday(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Kichthuoctang		DECIMAL(20,2),
constraint Quycachmayday_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Quycachmayday ADD Kichthuoctang		DECIMAL(20,2)

CREATE TABLE Quycachvienmieng(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Kichthuoctang		DECIMAL(20,2),
constraint Quycachvienmieng_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Quycachvienmieng ADD Kichthuoctang		DECIMAL(20,2)

CREATE TABLE Quycachdongkien(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
Packaging		NVARCHAR(MAX),
constraint Quycachdongkien_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Quycachdongkien ADD Packaging		NVARCHAR(MAX),

Create table Nhomnguyenlieu(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250),
constraint Nhomnguyenlieu_PK primary key (Mahieu)) ON [PRIMARY]
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'01', N'Hạt PP nguyên sinh')
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'02', N'Hạt nhựa HDPE')
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'03', N'Hạt nhựa LLDPE')
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'04', N'Hạt nhựa LDPE')
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'05', N'Hạt nhựa PP tráng')
INSERT [dbo].[Nhomnguyenlieu] ([Mahieu], [Tenhieu]) VALUES (N'06', N'Hạt PP tái sinh')

CREATE TABLE Danhmucnguyenlieu(
Id			BigInt Identity Not null,
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(100),
Gia			DECIMAL(20,2),
Ngay		DATE,
Giahientai		DECIMAL(20,2),
Tang			DECIMAL(20,2),
Giam			DECIMAL(20,2),
Manhom		NVARCHAR(50),
Tennhom		NVARCHAR(250),
Giangoai	DECIMAL(20,2),
Giaquydoi	DECIMAL(20,2),
constraint Danhmucnguyenlieu_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Danhmucnguyenlieu ADD Manhom		NVARCHAR(50),
Tennhom		NVARCHAR(250),
Giangoai	DECIMAL(20,2),
Giaquydoi	DECIMAL(20,2),
Giahientai		DECIMAL(20,2),
Tang			DECIMAL(20,2),
Giam			DECIMAL(20,2),

--ALTER TABLE dbo.Danhmucnguyenlieu ADD Id			BigInt Identity Not NULL
--ALTER TABLE dbo.Thanhphanpe DROP CONSTRAINT Thanhphanpe_Danhmucnguyenlieu_FK
--ALTER TABLE dbo.Thanhphansoi DROP CONSTRAINT Thanhphansoi_Danhmucnguyenlieu_FK
--ALTER TABLE dbo.Danhmucnguyenlieu DROP CONSTRAINT Danhmucnguyenlieu_PK
--ALTER TABLE dbo.Danhmucnguyenlieu ADD constraint Danhmucnguyenlieu_PK primary key (Id)


CREATE table Congsuatsoidenier(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Congsuatsoidenier_PK primary key (Mahieu)) ON [PRIMARY]

CREATE table Luongkho(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Luongkho_PK primary key (Mahieu)) ON [PRIMARY]

Create table Luongbansoi(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Luongbansoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Congsuatdetkho(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Congsuatdetkho_PK primary key (Mahieu)) ON [PRIMARY]

Create table Congsuatdetbansoi(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Congsuatdetbansoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Congsuatdetdenier(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Congsuatdetdenier_PK primary key (Mahieu)) ON [PRIMARY]

Create table Bansoi(
Mahieu		Nvarchar(20) Not null,
Dorong		Decimal(20,2),
Muccsdet	Nvarchar(20),
Mucluong		NVARCHAR(20),
constraint Bansoi_Luongbansoi_FK Foreign Key (Mucluong) References Luongbansoi (Mahieu) On Delete No Action On Update Cascade,
constraint Bansoi_Congsuatdetbansoi_FK Foreign Key (Muccsdet) References Congsuatdetbansoi (Mahieu) On Delete No Action On Update Cascade,
constraint Bansoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Trongluong(
Mahieu		Nvarchar(20) Not null,
Trongluong	Int,
Muccsdet	Nvarchar(20),
Muccssoi	Nvarchar(20),
constraint Trongluong_Congsuatsoidenier_FK Foreign Key (Muccssoi) References Congsuatsoidenier (Mahieu) On Delete No Action On Update Cascade,
constraint Trongluong_Congsuatdetdenier_FK Foreign Key (Muccsdet) References Congsuatdetdenier (Mahieu) On Delete No Action On Update Cascade,
constraint Trongluong_PK primary key (Mahieu)) ON [PRIMARY]

Create table Mausac(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100) Not null,
Color		NVARCHAR(100),
constraint Mausac_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Mausac ADD Color		NVARCHAR(100),

Create table Chatluong(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100) Not null,
constraint Chatluong_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Thanhphansoi_h(
Id			BigInt Identity Not null,
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
Ngayapdung		DATE,
Doben			DECIMAL(20,2),
Dodandai		DECIMAL(20,2),
Dobensoingang		DECIMAL(20,2),
Dobensoidoc			DECIMAL(20,2),
Dobenbangngang		DECIMAL(20,2),
Dobenbangdoc		DECIMAL(20,2),
constraint Thanhphansoi_h_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Thanhphansoi(
Id			BigInt Identity Not null,
Idheader			BigInt,
Ngayapdung			DATE,
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
Manguyenlieu	NVARCHAR(50),
Tennguyenlieu	NVARCHAR(100),
Khoiluong		DECIMAL(20,2),
Tylephantram	DECIMAL(20,6),
--Doben			DECIMAL(20,2),
--Dodandai		DECIMAL(20,2),
--Dobensoingang		DECIMAL(20,2),
--Dobensoidoc			DECIMAL(20,2),
--Dobenbangngang		DECIMAL(20,2),
--Dobenbangdoc		DECIMAL(20,2),
--constraint Thanhphansoi_Danhmucnguyenlieu_FK Foreign Key (Manguyenlieu) References Danhmucnguyenlieu (Mahieu) On Delete No Action On Update Cascade,
constraint Thanhphansoi_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Thanhphansoi DROP COLUMN Doben, Dodandai, Dobensoingang, Dobensoidoc, Dobenbangngang, Dobenbangdoc 

ALTER TABLE dbo.Thanhphansoi ADD Idheader		BIGINT,
Ngayapdung			DATE,
Dobensoingang		DECIMAL(20,2),
Dobensoidoc			DECIMAL(20,2),
Dobenbangngang		DECIMAL(20,2),
Dobenbangdoc		DECIMAL(20,2)

Create table Danhmucsoi(
Mahieu 		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
Bansoi			Nvarchar(20) Not null,
Dorong				Decimal(20,2),
Matrongluong	Nvarchar(20) Not null,
Trongluong			Int,
Mamausac		Nvarchar(20) Not null,
Mausac				Nvarchar(100),
Machatluong		Nvarchar(20) Not null,
Chatluong			Nvarchar(100),
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
constraint Danhmucsoi_Bansoi_FK Foreign Key (Bansoi) References Bansoi (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucsoi_Trongluong_FK Foreign Key (Matrongluong) References Trongluong (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucsoi_Mausac_FK Foreign Key (Mamausac) References Mausac (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucsoi_Chatluong_FK Foreign Key (Machatluong) References Chatluong (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucsoi_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Congthucsoi(
Id			BigInt Identity Not null,
Masoi			NVARCHAR(20),
Macongthuc		NVARCHAR(50),
Ngayapdung		DATE,
--constraint Congthucsoi_Thanhphansoi_FK Foreign Key (Macongthuc) References Thanhphansoi (Macongthuc) On Delete No Action On Update Cascade,
constraint Congthucsoi_Danhmucsoi_FK Foreign Key (Masoi) References Danhmucsoi (Mahieu) On Delete No Action On Update Cascade,
constraint Congthucsoi_PK primary key (Id)) ON [PRIMARY]


Create table Danhmuckho(
Mahieu		Nvarchar(20) Not null,
Dorong		Decimal(20,2),
Muccsdet	Nvarchar(20),
Mucluong		NVARCHAR(20),
constraint Danhmuckho_Luongkho_FK Foreign Key (Mucluong) References Luongkho (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuckho_Congsuatdetkho_FK Foreign Key (Muccsdet) References Congsuatdetkho (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuckho_PK primary key (Mahieu)) ON [PRIMARY]

Create table Dacdiemmanh(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100) Not null,
constraint Dacdiemmanh_PK primary key (Mahieu)) ON [PRIMARY]

Create table Danhmucmanh(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(100),
Name			NVARCHAR(250),
Masoi		Nvarchar(20) Not null,
Makho		Nvarchar(20) Not null,
Dorong			Decimal(20,2),
Trongluongmet	DECIMAL(20,6),
Madacdiem		NVARCHAR(20),
Tendacdiem		NVARCHAR(250),
Manhsudung		NVARCHAR(50),
Hinhthuctrang	NVARCHAR(20),
constraint Danhmucmanh_Danhmucsoi_FK Foreign Key (Masoi) References Danhmucsoi (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucmanh_Danhmuckho_FK Foreign Key (Makho) References Danhmuckho (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmucmanh_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Danhmucmanh ADD Name			NVARCHAR(250),


Create table Danhmucnhamay(
Mahieu		Nvarchar(20) Not null,
Tenhieu			Nvarchar(100),
constraint Danhmucnhamay_PK primary key (Mahieu)) ON [PRIMARY]

Create table Dongmaysoi(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100) Not null,
Nuocsx		Nvarchar(100),
Tieuhaodien		DECIMAL(20,2),
Khauhao			DECIMAL(20,2),
constraint Dongmaysoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Dongmaydet(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100) Not null,
Nuocsx		Nvarchar(100),
Tylephequydinh		DECIMAL(20,2),
Tieuhaodien		DECIMAL(20,2),
Khauhao			DECIMAL(20,2),
constraint Dongmaydet_PK primary key (Mahieu)) ON [PRIMARY]

Create table Maysoi(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
Manhamay	Nvarchar(20),
Nhamay			Nvarchar(100),
Vitri		Nvarchar(250),
Madongmay	Nvarchar(20) Not null,
Tendongmay		Nvarchar(100),
constraint Maysoi_Danhmucnhamay_FK Foreign Key (Manhamay) References Danhmucnhamay (Mahieu) On Delete No Action On Update Cascade,
constraint Maysoi_Dongmaysoi_FK Foreign Key (Madongmay) References Dongmaysoi (Mahieu) On Delete No Action On Update Cascade,
constraint Maysoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Maydet(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
Manhamay	Nvarchar(20),
Nhamay			Nvarchar(100),
Vitri		Nvarchar(250),
Madongmay	Nvarchar(20) Not null,
Tendongmay		Nvarchar(100),
constraint Maydet_Danhmucnhamay_FK Foreign Key (Manhamay) References Danhmucnhamay (Mahieu) On Delete No Action On Update Cascade,
constraint Maydet_Dongmaydet_FK Foreign Key (Madongmay) References Dongmaydet (Mahieu) On Delete No Action On Update Cascade,
constraint Maydet_PK primary key (Mahieu)) ON [PRIMARY]

Create table Congsuatmaysoi(
Mahieu		BigInt Identity Not null,
Madongmay	Nvarchar(20) Not null,
Muccsdenier	NVARCHAR(20),
Tenmuccsdenier	NVARCHAR(100),
Congsuat	Decimal(20,2),
constraint Congsuatmaysoi_Congsuatsoidenier_FK Foreign Key (Muccsdenier) References Congsuatsoidenier (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaysoi_Dongmaysoi_FK Foreign Key (Madongmay) References Dongmaysoi (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaysoi_PK primary key (Mahieu)) ON [PRIMARY]

Create table Congsuatmaydet(
Mahieu		BigInt Identity Not null,
Madongmay	Nvarchar(20) Not null,
Muccsbansoi		Nvarchar(20),
Tenmuccsbansoi		Nvarchar(100),
Muccskho		Nvarchar(20),
Tenmuccskho			Nvarchar(100),
Muccsdenier		Nvarchar(20),
Tenmuccsdenier		Nvarchar(100),
Congsuat	Decimal(20,2),
constraint Congsuatmaydet_Dongmaydet_FK Foreign Key (Madongmay) References Dongmaydet (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaydet_Congsuatdetkho_FK Foreign Key (Muccskho) References Congsuatdetkho (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaydet_Congsuatdetbansoi_FK Foreign Key (Muccsbansoi) References Congsuatdetbansoi (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaydet_Congsuatdetdenier_FK Foreign Key (Muccsdenier) References Congsuatdetdenier (Mahieu) On Delete No Action On Update Cascade,
constraint Congsuatmaydet_PK primary key (Mahieu)) ON [PRIMARY]

Create table Danhmucphongban(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Danhmucphongban_PK primary key (Mahieu)) ON [PRIMARY]

Create table Danhmucchucvu(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(100),
constraint Danhmucchucvu_PK primary key (Mahieu)) ON [PRIMARY]

Create table Danhmuccongnhan(
Mahieu		Nvarchar(20) Not null,
Hovaten		Nvarchar(100) Not null,
Ten			Nvarchar(100),
Maphongban	Nvarchar(20),
Phongban		Nvarchar(100),
Machucvu	Nvarchar(20),
Chucvu			Nvarchar(100),
Sodienthoai		Nvarchar(100),
Danghi		BIT DEFAULT 0,
constraint Danhmuccongnhan_Danhmucphongban_FK Foreign Key (Maphongban) References Danhmucphongban (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuccongnhan_Danhmucchucvu_FK Foreign Key (Machucvu) References Danhmucchucvu (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuccongnhan_PK primary key (Mahieu)) ON [PRIMARY]

Create table Hinhthucdet(
Mahieu		Nvarchar(20) Not null,
Tenhieu		Nvarchar(250),
constraint Hinhthucdet_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Dongialuong(
Id			BigInt Identity Not null,
Tenhieu				NVARCHAR(250),
Dongmaydet		NVARCHAR(20),
Mucluongkho		NVARCHAR(20),
Ca				INT,
Hinhthucdet		NVARCHAR(20),
Mucluongbansoi		NVARCHAR(20),
Luong			DECIMAL(20,2),
Ngayapdung		DATE,
constraint Dongialuong_Luongbansoi_FK Foreign Key (Mucluongbansoi) References Luongbansoi (Mahieu) On Delete No Action On Update Cascade,
constraint Dongialuong_Hinhthucdet_FK Foreign Key (Hinhthucdet) References Hinhthucdet (Mahieu) On Delete No Action On Update Cascade,
constraint Dongialuong_Luongkho_FK Foreign Key (Mucluongkho) References Luongkho (Mahieu) On Delete No Action On Update Cascade,
constraint Dongialuong_Dongmaydet_FK Foreign Key (Dongmaydet) References Dongmaydet (Mahieu) On Delete No Action On Update Cascade,
constraint Dongialuong_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Dongialuong ADD Ngayapdung	DATE
UPDATE dbo.Dongialuong SET Ngayapdung = '01/01/2021'


Create table Danhmucloai(
Mahieu		Nvarchar(20) Not null,
Tenhieu			Nvarchar(100),
constraint Danhmucloai_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Hinhthuctrang(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
Somattrang		DECIMAL(20,2),
constraint Hinhthuctrang_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Hinhthuctrang ADD Somattrang		DECIMAL(20,2),
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
INSERT INTO dbo.Thamso (Mahieu,Stt,Tenthamso,Giatri,Thaydoi,Kieudulieu,Ghichu,Loaithamso,An)
	VALUES ('Dinhluongtrang',49,'Dinhluongtrang','13',1,2,N'Định lượng tráng',0,0)


CREATE TABLE Dongmaytrang(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Congsuat		DECIMAL(20,2),
Tieuhaodien		DECIMAL(20,2),
Khauhao			DECIMAL(20,2),
constraint Loaimaytrang_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Maytrang(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Madongmay		NVARCHAR(20),
Tendongmay		NVARCHAR(250),
constraint Maytrang_Dongmaytrang_FK Foreign Key (Madongmay) References Dongmaytrang (Mahieu) On Delete No Action On Update Cascade,
constraint Maytrang_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Dongmayin(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Congsuat		DECIMAL(20,2),
Tieuhaodien		DECIMAL(20,2),
Khauhao			DECIMAL(20,2),
constraint Loaimayin_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Mayin(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Madongmay		NVARCHAR(20),
Tendongmay		NVARCHAR(250),
constraint Mayin_Dongmayin_FK Foreign Key (Madongmay) References Dongmayin (Mahieu) On Delete No Action On Update Cascade,
constraint Mayin_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Nguyenvatlieutrang(
Id			BigInt Identity Not null,
Macongthuc		NVARCHAR(50),
Tencongthuc		NVARCHAR(100),
Tennguyenlieu	NVARCHAR(100),
Khoiluong		DECIMAL(20,2),
Dongia			DECIMAL(20,2),
Tylephantram	DECIMAL(20,6),
constraint Nguyenvatlieutrang_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Thanhphanpe_h(
Id			BigInt Identity Not null,
Macongthuc		NVARCHAR(50),----CT01
Tencongthuc		NVARCHAR(100),---Chất lượng thấp
Ngayapdung		DATE,
constraint Thanhphanpe_h_PK primary key (Id)) ON [PRIMARY]

CREATE TABLE Thanhphanpe(
Id			BigInt Identity Not null,
Idheader		BIGINT,
Ngayapdung		DATE,
Macongthuc		NVARCHAR(50),----CT01
Tencongthuc		NVARCHAR(100),---Chất lượng thấp
Manguyenlieu	NVARCHAR(50),---NL01, NL02, NL03, NL04...
Tennguyenlieu	NVARCHAR(100),---HẠT HDPE, HẠT LLDPE, HẠT PE2 CTY, HẠT CACO3(CHÂU ÂU)
Khoiluong		DECIMAL(20,2),
Tylephantram	DECIMAL(20,6),
--constraint Thanhphanpe_Danhmucnguyenlieu_FK Foreign Key (Manguyenlieu) References Danhmucnguyenlieu (Mahieu) On Delete No Action On Update Cascade,
constraint Thanhphanpe_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Thanhphanpe ADD Idheader		BIGINT,
Ngayapdung		DATE,


CREATE TABLE Danhmucloaipe(
Mahieu			Nvarchar(20) NOT NULL,
Tenhieu			Nvarchar(50),
constraint Danhmucloaipe_PK primary key (Mahieu)) ON [PRIMARY]
INSERT INTO dbo.Danhmucloaipe (Mahieu, Tenhieu) VALUES ('PE','PE')
INSERT INTO dbo.Danhmucloaipe (Mahieu, Tenhieu) VALUES ('HD','HD')

CREATE TABLE Danhmucpe(
--Id			BigInt Identity Not null,
Mahieu			Nvarchar(50) NOT NULL,--HD58x96/22gr, HD65x112/33gr
Tenhieu			Nvarchar(250),
Makhachhang		Nvarchar(20),
Tenkhachhang	Nvarchar(250),
Maychay			Nvarchar(250),
Maloaipe			NVARCHAR(20),
Tenloaipe			NVARCHAR(50),
Kichthuoc		Nvarchar(50),---58x96, 65x112
Trongluong		Decimal(20,2),---22, 33
Macongthuc		Nvarchar(50),---CT01, CT02, CT03
Tencongthuc		NVARCHAR(100),---Chất lượng thấp, Chất lượng trung bình, Chất lượng cao
constraint Danhmucpe_PK primary key (Mahieu)) ON [PRIMARY]

DROP TABLE dbo.Danhmucpe
ALTER TABLE dbo.Danhmucpe ADD Maloaipe			NVARCHAR(20),
Tenloaipe			NVARCHAR(50),
UPDATE dbo.Danhmucpe SET Maloaipe=LEFT(Mahieu,2), Tenloaipe=LEFT(Mahieu,2) 

CREATE TABLE Danhmuccongdoan(
Mahieu		NVARCHAR(20) NOT NULL,
Tenhieu		NVARCHAR(250),
Cosudungmay		BIT DEFAULT 0,
Truoccat		BIT	DEFAULT 0,
Sothutu			INTEGER,
constraint Danhmuccongdoan_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Danhmucquycachsp(
Mahieu		NVARCHAR(20) NOT NULL,
Tenhieu		NVARCHAR(250),
Macongdoan		NVARCHAR(20),
Tencongdoan		NVARCHAR(250),
Maquycachcha	NVARCHAR(20),
Sudungthongke	BIT DEFAULT 0,
Sudungtinhluong	BIT DEFAULT 0,
Nhapkhotoanbo BIT DEFAULT 0,
constraint Danhmucquycachsp_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Danhmucquycachsp ADD Nhapkhotoanbo BIT DEFAULT 0
UPDATE dbo.Danhmucquycachsp SET Nhapkhotoanbo = 0
UPDATE dbo.Danhmucquycachsp SET Nhapkhotoanbo = 1 WHERE Mahieu IN ('TO', 'RU', 'LA', 'DP', 'DH', 'LN', 'TU', 'CPHE')


CREATE TABLE Dongiacongdoan(
Id			BIGINT IDENTITY NOT NULL,
Tendongia		NVARCHAR(250),
Macongdoan		NVARCHAR(20) NOT NULL,
Tencongdoan		NVARCHAR(250),
Maquycachsp		NVARCHAR(20) NOT NULL,
Tenquycachsp		NVARCHAR(250),
Tukho			NVARCHAR(20),
Rongtu			DECIMAL(20,2),
Denkho			NVARCHAR(20),
Rongden			DECIMAL(20,2),
Makhachs		NVARCHAR(MAX),
Mahangs			NVARCHAR(MAX),
Madongmay		NVARCHAR(MAX),
Mamays			NVARCHAR(MAX),
Ca				INT,
Chieudaicattu		DECIMAL,
Chieudaicatden		DECIMAL,
Hinhthuctrangs	NVARCHAR(250),
--Ngayhieuluc		DATE,
CoPE			BIT,
CoIn			BIT,
CoDem			BIT,
Quycachgaps			NVARCHAR(MAX),
Quycachmaydays		NVARCHAR(MAX),
Quycachvienmiengs	NVARCHAR(MAX),
Quycachdongkiens	NVARCHAR(MAX),
Phongbans			NVARCHAR(MAX),
Dongia				DECIMAL(20,2),
Ngayapdung			DATE,
constraint Dongiacongdoan_Danhmucquycachsp_FK Foreign Key (Maquycachsp) References Danhmucquycachsp (Mahieu) On Delete No Action On Update Cascade,
constraint Dongiacongdoan_Danhmuccongdoan_FK Foreign Key (Macongdoan) References Danhmuccongdoan (Mahieu) On Delete No Action On Update Cascade,
constraint Dongiacongdoan_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Dongiacongdoan ADD Mamays			NVARCHAR(MAX)
ALTER TABLE dbo.Dongiacongdoan DROP COLUMN Ngayhieuluc
ALTER TABLE dbo.Dongiacongdoan ADD Ngayapdung			DATE
ALTER TABLE dbo.Dongiacongdoan ALTER COLUMN Madongmay		NVARCHAR(MAX)
UPDATE Dongiacongdoan SET Ngayapdung = '01/01/2021'



CREATE TABLE Dongmayhoanthien(
Mahieu			NVARCHAR(20) NOT NULL,
Tenhieu			NVARCHAR(250),
Macongdoan		NVARCHAR(20),
Tencongdoan		NVARCHAR(250),
Congsuat		DECIMAL(20,2),
Tieuhaodien		DECIMAL(20,2),
Khauhao			DECIMAL(20,2),
constraint Dongmayhoanthien_Danhmuccongdoan_FK Foreign Key (Macongdoan) References Danhmuccongdoan (Mahieu) On Delete No Action On Update Cascade,
constraint Dongmayhoanthien_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Mayhoanthien(
Mamay		NVARCHAR(20) NOT NULL,
Tenmay		NVARCHAR(250),
Madongmay		NVARCHAR(20),
Tendongmay		NVARCHAR(250),
Macongdoan		NVARCHAR(20),
Tencongdoan		NVARCHAR(250),
constraint Mayhoanthien_Dongmayhoanthien_FK Foreign Key (Madongmay) References Dongmayhoanthien (Mahieu) On Delete No Action On Update Cascade,
constraint Mayhoanthien_PK primary key (Mamay)) ON [PRIMARY]







CREATE TABLE Nhanvien(
Manhanvien			NVARCHAR(50) NOT NULL,
Hoten			NVARCHAR(50),
Chucvu			NVARCHAR(50),
Gioitinh		BIT,
Ngaysinh		DATE,
Diachi			NVARCHAR(250),
Sodienthoai		NVARCHAR(50),
Email			NVARCHAR(50),
CONSTRAINT Nhanvien_PK primary key (Manhanvien)) ON [PRIMARY]

CREATE TABLE Nhacungcap(
Mahieu		Nvarchar(50) Not null,
Tenhieu		Nvarchar(250) Not null,
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
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Nhacungcap_PK primary key (Mahieu)) ON [PRIMARY]

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
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmuckhach_PK primary key (Mahieu)) ON [PRIMARY]

CREATE TABLE Danhmucchungloai(
Mahieu			NVARCHAR(50) NOT NULL,
Makhach			NVARCHAR(50),
Tenkhach		NVARCHAR(250),
Chungloai		NVARCHAR(MAX),
Loai				Nvarchar(100),	
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),
constraint Danhmucchungloai_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Danhmucchungloai ADD Loai		NVARCHAR(100)
UPDATE dbo.Danhmucchungloai SET Loai=hh.Loai
FROM dbo.Danhmucchungloai cl INNER JOIN dbo.Danhmuchanghoa hh 
	ON cl.Makhach=hh.Makhach AND cl.Chungloai=hh.Chungloai AND cl.Kichthuoc=hh.Kichthuocbao AND cl.Trongluongbao=hh.Trongluongbao


ALTER TABLE dbo.Danhmuchanghoa ALTER COLUMN Chungloai		NVARCHAR(MAX)
ADD Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2)

Create table Danhmuchanghoa(
Mahieu		Nvarchar(50) Not null,	---Makhach + 3 chữ số tự động tăng
Chungloai			NVARCHAR(MAX),

Mahangphiakhach		NVARCHAR(50),
Mabophansanxuat		NVARCHAR(50),

Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Maloai			Nvarchar(20),
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Kichthuocbao		Nvarchar(250),
Trongluongbao		DECIMAL(20,2),
MaPE				NVARCHAR(50),	---Bổ sung quản lý PE theo danh mục
MaloaiPE			NVARCHAR(20),
KichthuocPE			NVARCHAR(250),
TrongluongPE		DECIMAL(20,2),
Mamau			NVARCHAR(20),
Tenmau			NVARCHAR(100),

Hinhthuctrang	NVARCHAR(50),
Kieugap			Nvarchar(250),
Kieumayday		Nvarchar(250),
Loaichimay		Nvarchar(250),
Kieudongkien	Nvarchar(250),
Kieuvienmieng	NVARCHAR(250),
Loaidayxienluon		NVARCHAR(50),
Mamang			NVARCHAR(50),
Kieuin			NVARCHAR(50),

Chatluongkhachyeucau		NVARCHAR(MAX),
Chatluongnoibo				NVARCHAR(MAX),

Ngaymarket		DATETIME,

-----Phục vụ tính giá
Mamanh			Nvarchar(50),	
Tenmanh				Nvarchar(250),	
Masoi			Nvarchar(20),
Tensoi				Nvarchar(250),	
Kichthuoccat		Nvarchar(250),
Chieudaicat			Decimal(20,2),
Loaimayin		Nvarchar(20),
Codem			BIT,
Madongmay		NVARCHAR(250),

-----Hàng xuất khẩu
Color		NVARCHAR(100),
Size		NVARCHAR(100),
Weight		NVARCHAR(100),
Quality		NVARCHAR(MAX),

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
--constraint Danhmuchanghoa_Danhmucloai_FK Foreign Key (Maloai) References Danhmucloai (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Danhmucmanh_FK Foreign Key (Mamanh) References Danhmucmanh (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Hinhthuchanghoa_FK Foreign Key (Mahinhthuc) References Hinhthuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuchanghoa_PK primary key (Mahieu)) ON [PRIMARY]

ALTER TABLE dbo.Danhmuchanghoa DROP CONSTRAINT Danhmuchanghoa_Danhmucloai_FK
ALTER TABLE dbo.Danhmuchanghoa ADD Mamang			NVARCHAR(50),
Color		NVARCHAR(100),
Size		NVARCHAR(100),
Weight		NVARCHAR(100),
Quality		NVARCHAR(MAX),
Kieuin			NVARCHAR(50),
Loaidayxienluon		NVARCHAR(50),
MaloaiPE			NVARCHAR(20),
MaPE				NVARCHAR(50),
Madongmay		NVARCHAR(250),
Codem			BIT,
Loaimayin		Nvarchar(20),
Mamanh			Nvarchar(50),	
Tenmanh				Nvarchar(250),	
Masoi			Nvarchar(20),
Tensoi				Nvarchar(250),	
Kichthuoccat		Nvarchar(250),
Chieudaicat			Decimal(20,2),
Ngaymarket		DATETIME,
Hinhthuctrang	NVARCHAR(50)
ALTER COLUMN Chatluongkhachyeucau		NVARCHAR(MAX),
Chatluongnoibo				NVARCHAR(MAX)

Create table Danhmuchanghoasanxuat(
Mahieu		Nvarchar(50) Not null,	---Makhach + 3 chữ số tự động tăng
Tenhieu		Nvarchar(250) Not null,
Makhach			Nvarchar(50),		---Phục vụ tạo key chính
Tenkhach			Nvarchar(250),
Mauin			Nvarchar(250),		---Phục vụ tạo key chính
Maloai			Nvarchar(20),
Loai				Nvarchar(100),	---Phục vụ tạo key chính
Trongluongphoi		Decimal(20,2),
TrongluongkhongPE	Decimal(20,2),
Tongtrongluong		Decimal(20,2),
Kichthuocbao		Nvarchar(250),
Kichthuoccat		Nvarchar(250),
Chieudaicat			Decimal(20,2),
Masoi			Nvarchar(20),
Tensoi				Nvarchar(250),	
Khoiluongsoi		Decimal(20,2),
Mamanh			Nvarchar(50),	
Tenmanh				Nvarchar(250),	
Khoiluongmanh		Decimal(20,2),
Loaimayin		Nvarchar(250),
Kieugap			Nvarchar(250),
Kieumayday		Nvarchar(250),
Loaichimay		Nvarchar(250),
LongHDPE		Nvarchar(250),
Kieudongkien	Nvarchar(250),
Kieuvienmieng	NVARCHAR(250),
--Mahinhthuc		Nvarchar(20), --01: Không tráng, 02: tráng ngoài, 03: tráng lộn
--Tenhinhthuc			Nvarchar(250),
--Songaytruluisoi			Int,
--Songaytruluidet			Int,
--Makho				NVARCHAR(50),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmuchanghoasanxuat_Danhmucloai_FK Foreign Key (Maloai) References Danhmucloai (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuchanghoasanxuat_Danhmucmanh_FK Foreign Key (Mamanh) References Danhmucmanh (Mahieu) On Delete No Action On Update Cascade,
--constraint Danhmuchanghoa_Hinhthuchanghoa_FK Foreign Key (Mahinhthuc) References Hinhthuchanghoa (Mahieu) On Delete No Action On Update Cascade,
constraint Danhmuchanghoasanxuat_PK primary key (Mahieu)) ON [PRIMARY]


CREATE TABLE Hopdong(
Sohopdong		NVARCHAR(50) NOT NULL,
Ngayhopdong		DATE,
Thoihanhopdong	NVARCHAR(250),
Nguoidaidienhoten		NVARCHAR(250),
Nguoidaidienchucvu		NVARCHAR(250),
Nguoidaidiengiayuyquyenso		NVARCHAR(100),
Nguoidaidiengiayuyquyenngay		DATE,
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Lahopdongnguyentac		BIT	DEFAULT 1,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hopdong_PK primary key (Sohopdong)) ON [PRIMARY]

CREATE TABLE Baogia_h(
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Noidung			NVARCHAR(MAX),
Phuongthucthanhtoan		NVARCHAR(250),
Diadiemgiao		NVARCHAR(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Baogia_h_PK primary key (Sobaogia)) ON [PRIMARY]

CREATE TABLE Baogia_d(
Id				BIGINT IDENTITY NOT NULL,
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Chungloai		NVARCHAR(MAX),
Mota			NVARCHAR(MAX),
Kichthuoc		NVARCHAR(250),
Trongluongbao		DECIMAL(20,2),
Trongluongpe		DECIMAL(20,2),
Dongiabaochuavat	DECIMAL(20,2),
Dongiabaocovat		DECIMAL(20,2),
Dongiapechuavat		DECIMAL(20,2),
Dongiapecovat		DECIMAL(20,2),
Dongiatongchuavat	DECIMAL(20,2),	
Dongiatongcovat		DECIMAL(20,2),
Ghichu				NVARCHAR(250),
Giavon			DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Baogia_d_Baogia_h_FK Foreign Key (Sobaogia) References Baogia_h (Sobaogia) On Delete No Action On Update Cascade,
constraint Baogia_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Baogia_d ALTER COLUMN Chungloai		NVARCHAR(MAX)
ALTER TABLE dbo.Baogia_d ADD Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Mota			NVARCHAR(MAX)

CREATE TABLE Dondathang_h(
Madondathang	NVARCHAR(50) NOT NULL,
Ngaydat			DATE,
Sopo			NVARCHAR(50),
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Sobaogia		NVARCHAR(50) NOT NULL,
Ngaybaogia		DATE,
Ngayhieuluc		DATE,
Manhanvien			NVARCHAR(50),
Hoten			NVARCHAR(50),
Ghichu			NVARCHAR(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dondathang_h_PK primary key (Madondathang)) ON [PRIMARY]

ALTER TABLE dbo.Dondathang_h ADD Ghichu			NVARCHAR(MAX)

CREATE TABLE Dondathang_d(
Id				BIGINT IDENTITY NOT NULL,
Madondathang	NVARCHAR(50) NOT NULL,
Ngaydat			DATE,
Sopo		NVARCHAR(50),
Makhach		NVARCHAR(50),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Mahang		NVARCHAR(50),
Tenhang		NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Chungloai	NVARCHAR(MAX),
Sobaogia		NVARCHAR(50),
Soluong			INT,
Dongia			DECIMAL(20,2),
Ngaygiao		DATE,
Ngayhethanpo		DATE,
Ngaydieuchinh		DATE,
Sobaogiadieuchinh	NVARCHAR(50),
Soluongdieuchinh	INT,
Dongiadieuchinh		DECIMAL(20,2),
Ngaygiaodieuchinh	DATE,
Iddieuchinhtruoc	BIGINT,
Ngaymarket			DATE,
Ghichu				NVARCHAR(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Dondathang_d_Dondathang_h_FK Foreign Key (Madondathang) References Dondathang_h (Madondathang) On Delete No Action On Update Cascade,
constraint Dondathang_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Dondathang_d ALTER COLUMN Chungloai	NVARCHAR(MAX)
ALTER TABLE dbo.Dondathang_d ALTER COLUMN Soluong INT
ALTER TABLE dbo.Dondathang_d ALTER COLUMN Soluongdieuchinh INT
ALTER TABLE dbo.Dondathang_d ADD Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Loai		NVARCHAR(100),
Ghichu				NVARCHAR(250),
Ngaymarket			DATE,
Mauin		NVARCHAR(250),
Ngayhethanpo		DATE

CREATE TABLE Hopdongmuaban_h(
Sohopdong		NVARCHAR(50) NOT NULL,
Ngayhopdong		DATE,
Thoihanhopdong	NVARCHAR(250),
Nguoidaidienhoten		NVARCHAR(250),
Nguoidaidienchucvu		NVARCHAR(250),
Nguoidaidiengiayuyquyenso		NVARCHAR(100),
Nguoidaidiengiayuyquyenngay		DATE,
Makhach				NVARCHAR(20),
Tenkhach			Nvarchar(250),
Lahopdongnguyentac		BIT	DEFAULT 1,
Manhanvien			NVARCHAR(50),
Hoten			NVARCHAR(50),

Chatluong		NVARCHAR(MAX),
Dongiadatcoc	NVARCHAR(250),
Tongtiendatcoc	NVARCHAR(MAX),
Ngayhethieuluc	DATE,

Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hopdongmuaban_h_PK primary key (Sohopdong)) ON [PRIMARY]

CREATE TABLE Hopdongmuaban_d(
Id				BIGINT IDENTITY NOT NULL,
Sohopdong		NVARCHAR(50) NOT NULL,
Ngayhopdong			DATE,
Mahang		NVARCHAR(50),
Tenhang		NVARCHAR(250),
Chungloai	NVARCHAR(MAX),
Soluong			INT,
Dongia			DECIMAL(20,2),
Ngaygiao		DATE,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hopdongmuaban_d_Hopdongmuaban_h_FK Foreign Key (Sohopdong) References Hopdongmuaban_h (Sohopdong) On Delete No Action On Update Cascade,
constraint Hopdongmuaban_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Hopdongmuaban_d ALTER COLUMN Chungloai	NVARCHAR(MAX)


CREATE TABLE Danhmucxe(
Bienkiemsoat		NVARCHAR(50) NOT NULL,
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Danhmucxe_PK primary key (Bienkiemsoat)) ON [PRIMARY]

--CREATE TABLE Yeucauxuathang_h(
--Soyeucau		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
--Ngaytao			DATETIME,
--Nguoitao		NVARCHAR(50),
--Ngaysua			DATETIME,
--Nguoisua		NVARCHAR(50),
--constraint Yeucauxuathang_h_PK primary key (Soyeucau)) ON [PRIMARY]

--CREATE TABLE Yeucauxuathang_d(
--Id			BIGINT IDENTITY NOT NULL,
--Soyeucau		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
--Madonhang		NVARCHAR(50),
--Makhach			NVARCHAR(50),
--Iddondathang_d			BIGINT,
--Mahang			NVARCHAR(50),
--Tenhang			NVARCHAR(250),
--Soluongdat			INT,
--Soluongdagiao		INT,
--Soluonggiao			INT,
--Ngaygiao		DATE,
--Ngaytao			DATETIME,
--Nguoitao		NVARCHAR(50),
--Ngaysua			DATETIME,
--Nguoisua		NVARCHAR(50),
--constraint Yeucauxuathang_d_Dondathang_d_FK Foreign Key (Iddondathang_d) References Dondathang_d (Id) On Delete No Action On Update Cascade,
--constraint Yeucauxuathang_d_Yeucauxuathang_h_FK Foreign Key (Soyeucau) References Yeucauxuathang_h (Soyeucau) On Delete No Action On Update Cascade,
--CONSTRAINT Yeucauxuathang_d_PK primary key (Id)) ON [PRIMARY]

-----Kế hoạch xuất hàng
CREATE TABLE Phieuxuathang(
Sophieuxuat		NVARCHAR(50) NOT NULL,
Ngayxuat		DATE,
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phieuxuathang_PK primary key (Sophieuxuat)) ON [PRIMARY]

-----Kế hoạch xuất hàng chi tiết
CREATE TABLE Hanggiao(
Id			BIGINT IDENTITY NOT NULL,
Sophieuxuat		NVARCHAR(50) NOT NULL,
Ngayxuat		DATE,
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Madonhang		NVARCHAR(50),
Makhach			NVARCHAR(50),
Iddondathang_d			BIGINT,
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluongdat			INT,
Soluongdagiao		INT,
Soluonggiao			INT,
Ghichu				NVARCHAR(250),
Ngaygiao		DATE,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hanggiao_Dondathang_d_FK Foreign Key (Iddondathang_d) References Dondathang_d (Id) On Delete No Action On Update Cascade,
constraint Hanggiao_Phieuxuathang_FK Foreign Key (Sophieuxuat) References Phieuxuathang (Sophieuxuat) On Delete No Action On Update Cascade,
CONSTRAINT Hanggiao_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Hanggiao ADD Loai		NVARCHAR(100),
Mauin		NVARCHAR(250),
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Ghichu				NVARCHAR(250)

-------Phiếu nhập hàng trả lại
--CREATE TABLE Phieunhaphang(
--Sophieunhap		NVARCHAR(50) NOT NULL,
--Ngaynhap		DATE,
--Ngaytao			DATETIME,
--Nguoitao		NVARCHAR(50),
--Ngaysua			DATETIME,
--Nguoisua		NVARCHAR(50),
--constraint Phieunhaphang_PK primary key (Sophieunhap)) ON [PRIMARY]

-------Nhập hàng trả lại
CREATE TABLE Hangtralai(
Id			BIGINT IDENTITY NOT NULL,
Sophieuxuat		NVARCHAR(50) NOT NULL,
Ngayxuat		DATE,
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Madonhang		NVARCHAR(50),
Makhach			NVARCHAR(50),
Idhanggiao			BIGINT,
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluonggiao			INT,
Soluongtralai		INT,
Ngaytra			DATE,
Nguyennhan		NVARCHAR(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hangtralai_Hanggiao_FK Foreign Key (Idhanggiao) References dbo.Hanggiao (Id) On Delete No Action On Update Cascade,
CONSTRAINT Hangtralai_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Hangtralai ADD Loai		NVARCHAR(100),
Mauin		NVARCHAR(250),
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100)



---------Phiếu xuất hàng bán (đề nghị xuất hóa đơn)
CREATE TABLE Phieugiaohang_h(
Sophieugiao		NVARCHAR(50) NOT NULL,
Ngaygiao		DATE,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat			DATE,
Madonhang		NVARCHAR(50),
Ngaydat			DATE,
Sopo			NVARCHAR(50),
--Sobaogia		NVARCHAR(50),
Makhach			NVARCHAR(50),
Tenkhach			Nvarchar(250),
Tongtien		DECIMAL(20,2),
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
VAT				DECIMAL(20,2),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Phieugiaohang_h_PK primary key (Sophieugiao)) ON [PRIMARY]

ALTER TABLE dbo.Phieugiaohang_h ADD VAT				DECIMAL(20,2),
Bienkiemsoat	NVARCHAR(50),
Laixehoten		NVARCHAR(50),
Laixeghichu		NVARCHAR(100),
Tenkhach			Nvarchar(250),
ALTER TABLE dbo.Phieugiaohang_h DROP COLUMN Sophieuxuat, Ngayxuat, Sobaogia


CREATE TABLE Phieugiaohang_d(
Id			BIGINT IDENTITY NOT NULL,
Sophieugiao		NVARCHAR(50) NOT NULL,
Ngaygiao		DATE,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
Madonhang		NVARCHAR(50),
Makhach			NVARCHAR(50),
Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluong			INT,
Dongia			DECIMAL(20,2),
Thanhtien		DECIMAL(20,2),
Ghichu			NVARCHAR(250),
Madondathangchitiet			BIGINT,
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Phieugiaohang_d_Phieugiaohang_h_FK Foreign Key (Sophieugiao) References Phieugiaohang_h (Sophieugiao) On Delete No Action On Update Cascade,
CONSTRAINT Phieugiaohang_d_PK primary key (Id)) ON [PRIMARY]

ALTER TABLE dbo.Phieugiaohang_d ALTER COLUMN Soluong			INT

ALTER TABLE dbo.Phieugiaohang_d ADD Loaihang		INT,	--0: Bao PP (hàng hóa); 1: Túi (PE); 2: Manh
Loai		NVARCHAR(100),
Thanhtien		DECIMAL(20,2),
Ghichu			NVARCHAR(250),
Ngaygiao		DATE,
Mauin		NVARCHAR(250)

ALTER TABLE dbo.Phieugiaohang_d DROP COLUMN Sophieuxuat, Ngayxuat



--- Phiếu nhập hàng trả lại
CREATE TABLE Hangtralai_h(
Sophieunhap		NVARCHAR(50) NOT NULL,
Ngaynhap		DATE,
Ngayphatsinh		DATE,
Makhach			NVARCHAR(50),
Tenkhach			Nvarchar(250),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
CONSTRAINT Hangtralai_h_PK primary key (Sophieunhap)) ON [PRIMARY]

ALTER TABLE dbo.Hangtralai_h ADD Ngayphatsinh		DATE

CREATE TABLE Hangtralai_d(
Id			BIGINT IDENTITY NOT NULL,
Sophieunhap		NVARCHAR(50) NOT NULL,
Ngaynhap		DATE,
Madonhang		NVARCHAR(50),
Mahang			NVARCHAR(50),
Tenhang			NVARCHAR(250),
Mauin		NVARCHAR(250),
Loai		NVARCHAR(100),
Soluonggiao			INT,
Soluongtralai		INT,
Ngaytra			DATE,
Nguyennhan		NVARCHAR(MAX),
Ngaytao			DATETIME,
Nguoitao		NVARCHAR(50),
Ngaysua			DATETIME,
Nguoisua		NVARCHAR(50),
constraint Hangtralai_d_Hangtralai_h_FK Foreign Key (Sophieunhap) References dbo.Hangtralai_h (Sophieunhap) On Delete No Action On Update Cascade,
CONSTRAINT Hangtralai_d_PK primary key (Id)) ON [PRIMARY]


--CREATE TABLE Hoadon_h(
--Sohoadon		NVARCHAR(50) NOT NULL,
--Ngayhoadon		DATE,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
--Madonhang		NVARCHAR(50),
--Ngaydat			DATE,
--Sopo			NVARCHAR(50),
--Sobaogia		NVARCHAR(50),
--Makhach			NVARCHAR(50),
--Tongtien		DECIMAL(20,2),
--Ngaytao			DATETIME,
--Nguoitao		NVARCHAR(50),
--Ngaysua			DATETIME,
--Nguoisua		NVARCHAR(50),
--CONSTRAINT Hoadon_h_PK primary key (Sohoadon)) ON [PRIMARY]

--CREATE TABLE Hoadon_d(
--Id			BIGINT IDENTITY NOT NULL,
--Sohoadon		NVARCHAR(50) NOT NULL,
--Sophieuxuat		NVARCHAR(50) NOT NULL,
--Ngayxuat		DATE,
--Madonhang		NVARCHAR(50),
--Makhach			NVARCHAR(50),
--Mahang			NVARCHAR(50),
--Tenhang			NVARCHAR(250),
--Soluong			DECIMAL(20,2),
--Dongia			DECIMAL(20,2),
--Madondathangchitiet			BIGINT,
--Ngaytao			DATETIME,
--Nguoitao		NVARCHAR(50),
--Ngaysua			DATETIME,
--Nguoisua		NVARCHAR(50),
--constraint Hoadon_d_Hoadon_h_FK Foreign Key (Sohoadon) References Hoadon_h (Sohoadon) On Delete No Action On Update Cascade,
--CONSTRAINT Hoadon_d_PK primary key (Id)) ON [PRIMARY]







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
