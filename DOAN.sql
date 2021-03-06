CREATE DATABASE FlightManager
GO
CREATE TABLE KhachHang
(
	MaKH		CHAR(8) PRIMARY KEY,
	GioiTinh	NVARCHAR(3),
	TenKH		NVARCHAR(30),
	NgaySinh	SMALLDATETIME,
	LoaiKH		NVARCHAR(20),
	SDT			CHAR(10),
	DiaChi		NVARCHAR(50),
	Email		NVARCHAR(20),
	CCCD		NVARCHAR(20)
)

CREATE TABLE NhanVien
(
	MaNV		CHAR(5) PRIMARY KEY,
	TenNV		NVARCHAR(30),
	SDT			CHAR(10),
	DiaChi		NVARCHAR(50),
	ChucVu		NVARCHAR(30),
	CCCD		NVARCHAR(20),
	
)

CREATE TABLE MayBay
(
	MaMB		CHAR(5) PRIMARY KEY,
	TenMB		NVARCHAR(20),
	Hang		NVARCHAR(20),
	KichThuoc	NVARCHAR(10),
	SoCho		INT
)

CREATE TABLE DuongBay
(
	MaDB		CHAR(3) PRIMARY KEY,
	ViTri		NVARCHAR(30),
	ChieuDai	float,
	ChieuRong	float,
	TinhTrang	NVARCHAR(20)
)

CREATE TABLE ChuyenBay
(
	MaCB		CHAR(8) PRIMARY KEY,
	MaMB		CHAR(5) FOREIGN KEY REFERENCES MayBay (MaMB),
	MaDB		CHAR(3) FOREIGN KEY REFERENCES DuongBay (MaDB),
	TGKhoiHanh	SMALLDATETIME,
	TGDen		SMALLDATETIME,
	NoiKH		NVARCHAR(50),
	NoiDen		NVARCHAR(50),
	SL			INT,
	TinhTrang	NVARCHAR(20),
)

drop table HoaDon
CREATE TABLE HoaDon
(
	MaHD		CHAR(8) PRIMARY KEY,
	MaNV		CHAR(5) FOREIGN KEY REFERENCES NhanVien (MaNV),
	MaKH		CHAR(8) FOREIGN KEY REFERENCES KhachHang (MaKH),
	NgHD		SMALLDATETIME,
	TriGia		MONEY
)
drop table Ve
CREATE TABLE Ve
(
	MaVe		CHAR(8) PRIMARY KEY,
	MaCB		CHAR(8) FOREIGN KEY REFERENCES ChuyenBay (MaCB),
	MaHD		CHAR(8) FOREIGN KEY REFERENCES HoaDon (MaHD),
	ChoNgoi		CHAR(4),
	LoaiVe		NVARCHAR(20),
	Gia			MONEY
)

/*INSERT TABLE KHACHHANG**/
INSERT INTO KhachHang VALUES('10002001',N'Nam',N'Lê Văn Kim','10/12/1988',N'Thường','0184267382',N'Kiên Giang','Kim7846@gmail.com','357869463726')
INSERT INTO KhachHang VALUES('10002002',N'Nữ',N'Đăng Ngọc Minh','2/5/1997',N'Thân Thiết','0632891649',N'Trà Vinh','Maie46@gmail.com','167281074926')
INSERT INTO KhachHang VALUES('10002003',N'Nam',N'Nguyễn Thành Đạt','1/1/2000','Vip','0974521565',N'Nam Định','NTD026@gmail.com','167282047926')
INSERT INTO KhachHang VALUES('10002004',N'Nam',N'Gia Tấn Kim','8/8/1999','Vip','0856463733',N'Hải Phòng','KTG6@gmail.com','167229501926')
INSERT INTO KhachHang VALUES('10002005',N'Nữ',N'Lữ Minh Anh','6/9/2001',N'Thường','0756372819',N'Đà Nẵng','Ahdks16@gmail.com','167281071205')
INSERT INTO KhachHang VALUES('10002006',N'Nam',N'Trần Quang Minh','4/5/1992',N'Thân Thiết','0956372819',N'Bắc Giang','Minh246@gmail.com','167281104832')

/*INSERT TABLE NHANVIEN*/
INSERT INTO NhanVien VALUES('10001',N'Hà Kim Ngọc','0849362118','TP HCM',N'Thu Ngân','674827564821')
INSERT INTO NhanVien VALUES('10002',N'Trịnh Đình Quang','0647735218','TP HCM',N'Thu Ngân','674864900982')
INSERT INTO NhanVien VALUES('10003',N'Đinh Gia Huy','0658893220','TP HCM',N'Thu Ngân','671520564821')
INSERT INTO NhanVien VALUES('10004',N'Huỳnh Nữ','0748392758','TP HCM',N'Thu Ngân','162842756482')
INSERT INTO NhanVien VALUES('10005',N'Nguyễn Duy Linh','0645537778','TP HCM',N'Thu Ngân','674827500643')
INSERT INTO NhanVien VALUES('00000',N'Nguyễn Hiếu Nghĩa','0645537778','TP HCM',N'Thu Ngân','674827400643')

/*INSERT TABLE MayBay*/
INSERT INTO MayBay  VALUES('ABA01','Airbus A321','Airbus S.A.S',N'Lớn',305)
INSERT INTO MayBay  VALUES('ABA02','Airbus A321','Airbus S.A.S',N'Lớn',305)
INSERT INTO MayBay  VALUES('ABA03','Airbus A321','Airbus S.A.S',N'Lớn',305)
INSERT INTO MayBay  VALUES('BE001','Boeing 787','Boeing Airplane',N'Lớn',274)
INSERT INTO MayBay  VALUES('BE002','Boeing 787','Boeing Airplane',N'Lớn',274)
INSERT INTO MayBay  VALUES('BE003','Boeing 787','Boeing Airplane',N'Lớn',274)
INSERT INTO MayBay  VALUES('ATR01','ATR 72-500','Airbus S.A.S',N'Nhỏ',68)
INSERT INTO MayBay  VALUES('ATR02','ATR 72-500','Airbus S.A.S',N'Nhỏ',68)
INSERT INTO MayBay  VALUES('ATR03','ATR 72-500','Airbus S.A.S',N'Nhỏ',68)
INSERT INTO MayBay  VALUES('ATR04','ATR 72-500','Airbus S.A.S',N'Nhỏ',68)

--INSERT TABLE DuongBay
INSERT INTO DuongBay VALUES('TN1','07R/25L','12.468','3.8',N'Đang hoạt động')
INSERT INTO DuongBay VALUES('TN2','07L/25R','10','3.048',N'Đang hoạt động')
INSERT INTO DuongBay VALUES('NB1','11L/29R','10.497','3.2',N'Đang hoạt động')
INSERT INTO DuongBay VALUES('NB2','11R/29L','12.466','3.8',N'Đang hoạt động')

--INSERT TABLE CHUYENBAY
INSERT INTO ChuyenBay VALUES('11110001','ABA01','TN1','7/22/2021 6:00','7/23/2021 8:00',N'TP HCM',N'Hà Nội','290',N'Còn')
INSERT INTO ChuyenBay VALUES('11110002','BE002','TN2','8/1/2021 9:00','8/2/2021 11:00',N'TP HCM',N'Hà Nội','290',N'Còn')
INSERT INTO ChuyenBay VALUES('11110003','BE003','NB1','8/2/2021 9:00','8/2/2021 11:00',N'Hà Nội',N'TP HCM','200',N'Còn')
INSERT INTO ChuyenBay VALUES('11110004','BE003','NB2','7/10/2021 5:00','7/11/2021 7:00',N'Hà Nội',N'TP HCM','20',N'Hết')
INSERT INTO ChuyenBay VALUES('11110005','ATR03','NB2','7/11/2021 5:00','7/12/2021 7:00',N'Hà Nội',N'TP HCM','90',N'Còn')
--INSERT TABLE HoaDon
INSERT INTO HoaDon VALUES('HD001001','10001','10002001','6/6/2021','2000000')
INSERT INTO HoaDon VALUES('HD001002','10001','10002002','6/7/2021','2000000')
INSERT INTO HoaDon VALUES('HD001003','10002','10002003','6/5/2021','4500000')
INSERT INTO HoaDon VALUES('HD001004','10002','10002004','6/5/2021','2500000')
INSERT INTO HoaDon VALUES('HD001005','10002','10002005','6/5/2021','700000')
INSERT INTO HoaDon VALUES('HD001006','10002','10002006','6/5/2021','700000')
--INSERT TABLE VE'
INSERT INTO Ve VALUES('VNAL0001','11110001','HD001001','E106',N'Thường','2000000')
INSERT INTO Ve VALUES('VNAL0002','11110001','HD001002','A007',N'Thường','2000000')
INSERT INTO Ve VALUES('VNAL0003','11110001','HD001003','H006',N'Thường','2000000')
INSERT INTO Ve VALUES('VNAL0004','11110003','HD001003','L002',N'Thương Gia','2500000')
INSERT INTO Ve VALUES('VNAL0005','11110003','HD001004','L003',N'Thương Gia','2500000')
INSERT INTO Ve VALUES('VNAL0006','11110005','HD001005','E005',N'Thường','700000')
INSERT INTO Ve VALUES('VNAL0007','11110005','HD001006','E006',N'Thường','700000')


ALTER TABLE GV_HDDT ADD CONSTRAINT BAI3_1 CHECK (DIEM>=0 AND DIEM <=10) 
ALTER TABLE GV_PBDT ADD CONSTRAINT BAI3_1 CHECK (DIEM>=0 AND DIEM <=10) ALTER TABLE GV_UVDT ADD CONSTRAINT BAI3_1 CHECK (DIEM>=0 AND DIEM <=10)

----	TGKH trên bảng chuyến bay phải bé hơn TGDen.
ALTER TABLE ChuyenBay ADD CONSTRAINT TG_CB CHECK(TGKhoiHanh<TGDEN)
--test--
INSERT INTO ChuyenBay VALUES('10110002','BE002','TN2','8/2/2021 11:00','8/1/2021 9:00',N'TP HCM',N'Hà Nội','290',N'Còn')
--o	Số lượng trong bảng chuyến bay phải bé hơn hoặc bằng số chổ trong bảng máy bay.--
/*			insert	update	delete
chuyenbay	  +		  +(SL)		-
maybay		  -			+(sc)	-
*/
--table Chuyenbay insert,update
CREATE TRIGGER SoCho_CB_INS
ON ChuyenBay
FOR INSERT,update
AS
	BEGIN
		Declare @SL int
		Declare @SoCho int
		select @SL=SL from inserted
		select @SoCho=SoCho from MayBay, inserted where MayBay.MaMB=inserted.MaMB
		IF(@SL>@SoCho)
		BEGIN
			ROLLBACK TRAN
			Print 'SL VE <= SO CUA MAY BAY'
		
	END
END

--TRIGGER KHACHHANG KIEMTRA NGAY SINH,THAYDOI MAKH TREN HOADON THEO KHACHHANG
CREATE TRIGGER NgHD_NgaySinh_on_KhachHang_FOR_UPDATE
ON KhachHang
FOR UPDATE
AS
	DECLARE @NgHD SMALLDATETIME,@NgaySinh SMALLDATETIME, @MAKH CHAR(8),@MAKH2 CHAR(8)
	SELECT @MAKH=MaKH FROM INSERTED 
	SELECT @MAKH2=MaKH FROM DELETED
	UPDATE HoaDon SET MaKH=@MAKH WHERE MaKH=@MAKH2
	SELECT @NgHD=min(NgHD) FROM inserted,HoaDon WHERE HoaDon.MaKH=inserted.MaKH
	SELECT @NgaySinh=NgaySinh FROM INSERTED 
	IF(@NgaySinh>@NgHD)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Ngay hoa don phai lon hon ngay sinh',16,1)
		RETURN
	END

--update KhachHang set MaKH='0' where MaKH='10002001'

--TRIGGER TABLE VE
--INSERT Ve Tinh tri gia HD
CREATE TRIGGER TriGia_HD_INSERTVe
ON Ve
FOR INSERT
AS
	DECLARE @MaHD CHAR(8), @TRIGIA MONEY
	SELECT @MaHD=MaHD FROM INSERTED
	SELECT @TRIGIA=SUM(Gia) FROM Ve WHERE Ve.MaHD=@MaHD 
	UPDATE HoaDon SET TriGia=@TRIGIA WHERE MaHD=@MaHD
	PRINT('DA CAP NHAT TRI GIA HD')

INSERT INTO Ve VALUES('VNAL0008','11110005','HD001006','A4',N'Thường','700000')
--UPDATE VE TINH TRIGIA HD
CREATE TRIGGER TRIGIA_HD_UPDATEVE
ON Ve
FOR UPDATE
AS
	DECLARE @MAHDC CHAR(8),@MAHDM CHAR(8),@TRIGIA MONEY
	SELECT @MAHDC=MaHD FROM deleted
	SELECT @MAHDM=MaHD FROM inserted
	IF( (SELECT COUNT(*) FROM Ve WHERE MaHD=@MAHDC)>0)
	BEGIN
	SELECT @TRIGIA=SUM(Gia) FROM Ve WHERE Ve.MaHD=@MAHDC 
	UPDATE HoaDon SET TriGia=@TRIGIA WHERE MaHD=@MAHDC
	END
	ELSE 
	BEGIN
		UPDATE HoaDon SET TriGia=0 WHERE MaHD=@MAHDC
	END
	SELECT @TRIGIA=SUM(Gia) FROM Ve WHERE Ve.MaHD=@MAHDM
	UPDATE HoaDon SET TriGia=@TRIGIA WHERE MaHD=@MAHDM
	PRINT('DA CAP NHAT TRI GIA HD')
UPDATE Ve SET MaHD='HD001001' WHERE MaVe='VNAL0001'
--DELETE VE TINH TRIGIA HD
CREATE TRIGGER TriGia_HD_DELETEVe
ON Ve
FOR DELETE
AS
	DECLARE @MaHD CHAR(8), @TRIGIA MONEY
	SELECT @MaHD=MaHD FROM deleted
	IF( (SELECT COUNT(*) FROM Ve WHERE MaHD=@MAHD)>0)
	BEGIN
	SELECT @TRIGIA=SUM(Gia) FROM Ve WHERE Ve.MaHD=@MAHD
	UPDATE HoaDon SET TriGia=@TRIGIA WHERE MaHD=@MAHD
	END
	ELSE 
	BEGIN
		UPDATE HoaDon SET TriGia=0 WHERE MaHD=@MAHD
	END
	PRINT('DA CAP NHAT TRI GIA HD')
DELETE Ve WHERE MaVe='VNAL0008'

--TRIGGER TABLE NHANVIEN 
CREATE TRIGGER ALTER_NHANVIEN
ON NHANVIEN
FOR UPDATE
AS
	DECLARE @MANVM CHAR(5),@MANVC CHAR(5)
	SELECT @MANVC=MaNV FROM deleted
	SELECT @MANVM=MaNV FROM inserted
	UPDATE HOADON SET MaNV=@MANVM WHERE MaNV=@MANVC

--TRIGGER TABLE CHUYENBAY
--UPDATE MACB TRONG VE
CREATE TRIGGER ALTER_CHUYENBAY
ON CHUYENBAY
FOR UPDATE
AS
	DECLARE @MACBM CHAR(8),@MACHC CHAR(8)
	SELECT @MACBM=MaCB FROM inserted
	SELECT @MACHC=MaCB FROM deleted
	UPDATE Ve SET MaCB=@MACBM WHERE MaCB=@MACHC

--TEST---
INSERT INTO ChuyenBay VALUES('11350001','ABA01','TN1','7/22/2021 6:00','7/23/2021 8:00',N'TP HCM',N'Hà Nội','9900',N'Còn')
UPDATE ChuyenBay
SET SL='100000'
WHERE MaCB='11110001';
---- table may bay for update
CREATE TRIGGER SoCho_MB_UPDATE
ON MayBay
FOR update
AS
	BEGIN
		Declare @SL int
		Declare @SoCho int
		select @SoCho=SoCho from inserted
		select @SL=SL from ChuyenBay, inserted where ChuyenBay.MaMB=inserted.MaMB
		IF(@SL>@SoCho)
		BEGIN
			ROLLBACK TRAN
			Print 'SL VE <= SO CUA MAY BAY'
		
	END
END
----Test----
UPDATE MayBay
SET SoCho='2'
WHERE MaMB='ABA01';


Create Proc SearchCB(@NGKH smalldatetime,@NGDN smalldatetime,@NoiKH nvarchar (50),@NoiDen nvarchar(50))
AS
BEGIN
	SELECT *
	FROM ChuyenBay A
	WHERE A.NoiKH=@NoiKH AND A.NoiDen=@NoiDen AND A.TGKhoiHanh=@NGKH AND A.TGDen= @NGDN

END
EXEC SearchCB @NGKH='7/22/2021 6:00' ,  @NGDN='7/23/2021 8:00' , @NoiKH=N'TP HCM' , @NoiDen=N'Hà Nội'

Create Proc SearchTHU(@TUNG smalldatetime,@DNNG smalldatetime)
AS
BEGIN
	SELECT *
	FROM HoaDon A
	WHERE NgHD>=@TUNG AND NgHD<=@DNNG

END

EXEC SearchTHU @TUNG='4/4/2020', @DNNG='7/7/2021'

SELECT * FROM NhanVien Where MaNV='10001'AND TenNV=N'Hà Kim Ngọc'
Create Proc CB_GET
AS
BEGIN
	SELECT *
	FROM  ChuyenBay
	

END
Create Proc HD_GET
AS
BEGIN
	SELECT *
	FROM  HoaDon
	

END
Create Proc KH_GET
AS
BEGIN
	SELECT *
	FROM  KhachHang
	

END
--KHACHHANG CO NHIEU HON DON NHAT
SELECT TOP 1 KhachHang.MaKH,COUNT(MAHD) SOHD
FROM KhachHang,HoaDon
WHERE KhachHang.MaKH=HoaDon.MaKH
GROUP BY KhachHang.MaKH
ORDER BY COUNT(MaHD) DESC
--KHACHHANG CO TONG TRI GIA CAC HD CAO NHAT
SELECT TOP 1 KhachHang.MaKH,SUM(TriGia) DOANHTHU
FROM KhachHang,HoaDon
WHERE KhachHang.MaKH=HoaDon.MaKH
GROUP BY KhachHang.MaKH
ORDER BY SUM(TriGia) DESC
--CAC KHACH HANG CO CHUYEN BAY DEN HCM
SELECT KhachHang.MaKH,TenKH
FROM KhachHang,HoaDon,Ve,ChuyenBay
WHERE KhachHang.MaKH=HoaDon.MaKH
AND HoaDon.MaHD=Ve.MaHD
AND Ve.MaCB=ChuyenBay.MaCB
AND ChuyenBay.NoiDen=N'TP HCM'

--IN RA CAC VE KHOI HANH O TP HCM
SELECT *
FROM Ve,ChuyenBay
WHERE Ve.MaCB=ChuyenBay.MaCB
AND NoiKH=N'TP HCM'

CREATE FUNCTION CHUYENBAYDEN(@NOIDEN NVARCHAR(50)) RETURNS TABLE
AS
RETURN (SELECT * FROM ChuyenBay WHERE NoiDen=@NOIDEN)

SELECT* FROM dbo.CHUYENBAYDEN(N'Hà Nội')

CREATE LOGIN NHANVIEN WITH PASSWORD = ''
CREATE USER [NHANVIEN1] FOR LOGIN NHANVIEN

CREATE ROLE NHANVIEN

EXEC sp_addrolemember NHANVIEN,NHANVIEN1
EXEC sp_addrolemember db_owner,NHANVIEN
EXEC sp_addrolemember db_accessadmin,NHANVIEN
GRANT ALL ON HoaDon TO NHANVIEN1
REVOKE ALL ON HoaDon FROM NHANVIEN1
DENY CREATE TABLE, CREATE PROCEDURE
	TO NHANVIEN1;



CREATE TRIGGER DELETE_CB
ON ChuyenBay
FOR DELETE
AS
	IF(@@ROWCOUNT=0)
	BEGIN
		PRINT'CHUYEN BAY KHONG VE'
		RETURN
	END
DELETE Ve
FROM Ve v, deleted D
WHERE v.MaCB=D.MaCB
PRINT 'DA XOA CAC VE LIEN QUAN'
GO

CREATE PROC INSERT_VE(@MaV CHAR(8),@MaCB CHAR(8),@MaHD CHAR(8),@ChoNgoi CHAR(4),@LoaiVe NVARCHAR(20),@Gia MONEY)
AS
BEGIN
	INSERT INTO Ve VALUES(@MaV,@MaCB,@MaHD,@ChoNgoi,@
END
SELECT * FROM Ve where MaHD='HD001004';
SELECT * FROM HoaDon
create proc ADD_HD(@MaHD nvarchar(8),@MaNV nvarchar(5),@MaKH nvarchar(8), @NGHD nvarchar(40),@GIA nvarchar(40))
as 
begin 

	INSERT INTO HoaDon VALUES(@MaHD,@MaNV,@MaKH,@NGHD,@GIA)

	select*
	from HoaDon
	where @MaHD=MaHD
enddrop proc ADD_HD

		EXEC ADD_HD @MaHD='HD002020' , @MaNV='10001' , @MaKH='10002001' , @NGHD='5/6/2020', @GIA='1' 
