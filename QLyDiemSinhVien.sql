ALTER DATABASE QLDiemSinhVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE
USE master
DROP DATABASE QLDiemSinhVien
USE master

GO
IF EXISTS(SELECT name FROM sysdatabases WHERE name ='QLDiemSinhVien')
DROP DATABASE QLDiemSinhVien
go
CREATE DATABASE QLDiemSinhVien
GO
USE QLDiemSinhVien

GO

CREATE FUNCTION auto_maGV( ) RETURNS CHAR(5)
AS
    BEGIN
        DECLARE @maGV CHAR(5)
        IF ( SELECT COUNT(maGV)
                FROM   dbo.GiaoVien
            ) = 0
            SET @maGV = '0'
        ELSE
            SELECT  @maGV = MAX(RIGHT(maGV, 3))
            FROM    dbo.GiaoVien
        SELECT  @maGV = CASE WHEN @maGV >= 0
                                AND @maGV < 9
                            THEN 'GV00' + CONVERT(CHAR, CONVERT(INT, @maGV)
                                + 1)
                            WHEN @maGV >= 9
                            THEN 'GV0' + CONVERT(CHAR, CONVERT(INT, @maGV)
                                + 1)
                        END
        RETURN @maGV
    END
GO
CREATE TABLE GiaoVien
    (
      maGV CHAR(5) DEFAULT dbo.auto_maGV() PRIMARY KEY
                   CHECK ( maGV LIKE 'GV[0-9][0-9][0-9]' ) ,
      hoTen NVARCHAR(50) NOT NULL ,
      gioiTinh CHAR(1) DEFAULT 'M'
                       CHECK ( gioiTinh IN ( 'M', 'F' ) ) ,--male: nam; female: nữ,
      sdt VARCHAR(10)
        UNIQUE
        CHECK ( sdt LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
                OR sdt LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' )
        NULL ,
      email VARCHAR(100) UNIQUE
                         CHECK ( email LIKE '[A-Za-z]%@gmail.com'
                                 OR email LIKE '[A-Za-z]%@yahoo.com' ) ,
      anh IMAGE NULL
    )

GO
CREATE TABLE NamHoc
    (
      maNamHoc CHAR(3) PRIMARY KEY ,
      tenNamHoc VARCHAR(30) NULL
    )
GO
CREATE TABLE HocKy
    (
      maHK INT PRIMARY KEY ,
      tenHK NVARCHAR(10)
    )


GO
CREATE TABLE Khoa
    (
      maKhoa VARCHAR(5) PRIMARY KEY ,
      tenKhoa NVARCHAR(50) NOT NULL, 
    )
GO
CREATE TABLE LOP
    (
      maLop VARCHAR(10) PRIMARY KEY ,
      maKhoa VARCHAR(5)
        NOT NULL FOREIGN KEY ( maKhoa ) REFERENCES dbo.Khoa ( maKhoa ) ,
      siSo INT NULL,
    )
GO
CREATE TABLE SinhVien
    (
      maSV VARCHAR(13) PRIMARY KEY ,
      hoTen NVARCHAR(50) NOT NULL ,
      gioiTinh CHAR(1) DEFAULT 'M'
                       CHECK ( gioiTinh IN ( 'M', 'F' ) ) ,--male: nam; female: nữ,
      namSinh DATE NULL ,
      maLop VARCHAR(10)
        NOT NULL FOREIGN KEY ( maLop ) REFERENCES LOP ( maLop ) ,
      diaChi NVARCHAR(100) NULL
    )
GO
CREATE TABLE HocPhan
    (
      maHP CHAR(7) PRIMARY KEY ,
      tenHP NVARCHAR(50) NOT NULL
                         UNIQUE ,
      soTC TINYINT CHECK ( soTC >= 1
                           AND soTC <= 5 )
    )
GO
CREATE TABLE LopHP
    (
      maLHP VARCHAR(10) PRIMARY KEY ,
      maHP CHAR(7) FOREIGN KEY REFERENCES HocPhan ( maHP ) ON DELETE CASCADE,
      maHK INT FOREIGN KEY REFERENCES HocKy ( maHK ) ON DELETE CASCADE,
      tenLHP NVARCHAR(50) NOT NULL ,
      maGV CHAR(5) FOREIGN KEY REFERENCES GiaoVien ( maGV ) ON DELETE CASCADE,
      sSMax INT NOT NULL
                DEFAULT 40 ,
      sSDK INT NOT NULL
               DEFAULT 1 ,
      CHECK ( sSMax >= sSDK )
    )
GO
CREATE TABLE LHP_SV
    (
      MaLHP VARCHAR(10) FOREIGN KEY REFERENCES LopHP ( maLHP ) ON DELETE CASCADE,
      maSV VARCHAR(13) FOREIGN KEY ( maSV ) REFERENCES SinhVien ( maSV ) ON DELETE CASCADE,
      dTKHP DECIMAL(4, 1) CHECK ( dTKHP BETWEEN 0 AND 10 ) ,
      PRIMARY KEY ( MaLHP, maSV )
    )

GO

CREATE TABLE TKHK
    (
      maHK INT FOREIGN KEY ( maHK ) REFERENCES HocKy ( maHK ) ON DELETE CASCADE,
      maSV VARCHAR(13) FOREIGN KEY ( maSV ) REFERENCES SinhVien ( maSV ) ON DELETE CASCADE,
      sTCDK TINYINT CHECK ( sTCDK >= 0 ) ,
      sTCTL TINYINT CHECK ( sTCTL >= 0 ) ,
      dTBC DECIMAL(5, 2) CHECK ( dTBC BETWEEN 0 AND 10 ) ,
      PRIMARY KEY ( maHK, maSV )
    )
GO
CREATE TABLE userLogin(
	userName VARCHAR(50) PRIMARY KEY,
	passAccount VARCHAR(50) NOT NULL,
)

	--------
	--Them du lieu
GO
INSERT  INTO HocKy VALUES  
	( '118', N'Học kỳ 118' ),
	( '218', N'Học kỳ 218' ),
	( '119', N'Học kỳ 119' ),
	( '219', N'Học kỳ 219' ),
	( '120', N'Học kỳ 120' ),
	( '220', N'Học kỳ 220' )
GO
INSERT INTO HocKy VALUES
	('111',N'Hoc ki')
GO
INSERT INTO HocKy VALUES
	('All',N'Học kỳ')
GO
Select * from SinhVien
GO
INSERT INTO dbo.GiaoVien ( maGV, hoTen, gioiTinh, sdt, email)
VALUES  ( DEFAULT, N'Hoàng Thị Mỹ Lệ','F', '0344976831', 'htmle@gmail.com'),
		( DEFAULT, N'Đỗ Lê Quân','M', '0324454232', 'lequanit@gmail.com'),
		( DEFAULT, N'Nguyễn Văn Phát','M', '0324453232', 'vanphat@gmail.com'),
		( DEFAULT, N'Nguyễn Văn A','M', '0364396835', 'vana@gmail.com')
		
GO
INSERT  INTO dbo.Khoa
        ( maKhoa, tenKhoa )
VALUES  ( 'DDT', N'Điện - Điện tử'),
        ( 'HTP', N'Hoá - Thực phẩm' ),
        ( 'SPK', N'Sư phạm công nghiệp' ),
        ( 'CK', N'Cơ Khí' ),
        ( 'TDH', N'Tự động hoá' )
GO
INSERT  INTO dbo.Khoa
        ( maKhoa, tenKhoa )
VALUES  ( 'A', 'All')
-------------------
Go
INSERT INTO dbo.LOP
        ( maLop, maKhoa, siSo )    
		VALUES 
        ( '18T1', 'DDT',55 ),
        ( '18HTP', 'HTP', 65 ),
        ( '19T1', 'DDT',77 ),
        ( '19T2', 'DDT',52 ),
        ( '18C1', 'CK', 45 ),
        ( '18C2', 'CK', 33 ),
        ( '19C1', 'CK', 54 )

GO
INSERT INTO LOP (maLop,maKhoa,siSo)
VALUES('18S1','SPK',50),
('18S2','SPK',50),
('18H1','HTP',40),
('18H2','HTP',45),
('18TDH1','TDH',60),
('18TDH2','TDH',56)

------------------
GO

DELETE dbo.SinhVien
INSERT  INTO dbo.SinhVien
        ( maSV, hoTen, gioiTinh, maLop )
VALUES  ( '1811505310107', N'Nguyễn Thành Đạt', 'M', '18T1'),
        ( '1811505310120', N'Trần Hoàng Chung', 'M', '18C2' ),
        ( '1811505310121', N'Nguyễn Văn Long', 'M', '18C2' ),
        ( '1811505310122', N'Ngô Tất Tố', 'M', '18C1' ),
        ( '1811505310123', N'Huỳnh Văn Long', 'M', '18C1' ),
		( '1811505310124', N'Huỳnh Thị Tuyết', 'F', '18H1'),
        ( '1811505310125', N'Lên Hữu Tài', 'M', '18H1' ),
        ( '1811505310126', N'Nguyễn Đình Tuấn', 'M', '18H2' ),
        ( '1811505310127', N'Lê Đào Tiên', 'F', '18H2' ),
        ( '1811505310128', N'Hồ Tấn Tài', 'M', '18H1' ),
		( '1811505310129', N'Dương Minh Tuấn', 'M', '18S1' ),
        ( '1811505310130', N'Lê Thị Lan Anh', 'F', '18S1' ),
		( '1811505310131', N'Nguyễn Thị Hoài', 'F', '18S2'),
        ( '1811505310132', N'Trần Quang Hải', 'M', '18S2' ),
        ( '1811505310133', N'Nguyễn Hải Tú', 'F', '18S2' ),
        ( '1811505310134', N'Bùi Duy Vật', 'M', '18TDH1' ),
        ( '1811505310135', N'Cái Duy Minh', 'M', '18TDH2' )

------------------
GO
INSERT  INTO dbo.HocPhan
        ( maHP, tenHP, soTC )
VALUES  ( '5505136', N'Cơ sở dữ liệu phi quan hệ', 3),
        ( '5505175', N'Lập trình web nâng cao', 2 ),
        ( '5505168', N'Lập trình HDT Java', 2 ),
        ( '5505120', N'Bảo trì máy tính', 2 ),
        ( '5505203', N'TH Lập trình Java NC', 1 )

GO
INSERT  INTO dbo.LopHP
        ( maLHP , maHP, maHK, tenLHP, maGV, sSMax, sSDK)
VALUES  ('291LTWNC01','5505136','219',N'Lập trình Web nâng cao','GV001',50,43),
		('291LTWNC02','5505136','219',N'Lập trình Web nâng cao','GV001',50,40),
		('291LTWNC03','5505136','219',N'Lập trình Web nâng cao','GV003',50,23),
		('291LTWNC04','5505136','219',N'Lập trình Web nâng cao','GV003',50,20),
		('120BTMT01','5505120','120',N'Bảo trì máy tính','GV004', 70, 65),
		('120BTMT02','5505120','120',N'Bảo trì máy tính','GV004', 70, 65),
		('120CSDLP01','5505136','120',N'Cơ sở dữ liệu phi quan hệ','GV004', 70, 65),
		('120CSDLP02','5505136','120',N'Cơ sở dữ liệu phi quan hệ','GV004', 70, 65),
		('120TLTJ01','5505203','120',N'TH Lập trình Java NC','GV001', 70, 65),
		('120TLTJ02','5505120','120',N'TH Lập trình Java NC','GV001', 70, 65),
		('120LHDTJ01','5505168','120',N'Lập trình HDT Java','GV004', 70, 65),
		('120LHDTJ02','5505168','120',N'Lập trình HDT Java','GV004', 70, 65)
-----------------------	  
GO
INSERT INTO dbo.userLogin
        ( userName, passAccount)
VALUES ('admin','admin'),
		('datnguyen','datnguyen'),
		('nguyenhuy','nguyenhuy')
 GO

 INSERT INTO dbo.LHP_SV
         ( MaLHP, maSV, dTKHP )
 VALUES  ( '291LTWNC01', '1811505310107', 7.7 ),
		 ( '120BTMT01', '1811505310107', 8 ),
		 ( '120CSDLP01', '1811505310107', 9 ),
		 ( '120TLTJ01', '1811505310107', 7 ),
		 ( '120LHDTJ02', '1811505310107', 8.7 ),

		 ( '291LTWNC01', '1811505310120', 7.7 ),
		 ( '120BTMT01', '1811505310120', 8 ),
		 ( '120CSDLP01', '1811505310120', 9 ),
		 ( '120TLTJ01', '1811505310120', 7 ),
		 ( '120LHDTJ02', '1811505310120', 8.7 ),

		 ( '291LTWNC01', '1811505310121', 7.7 ),
		 ( '120BTMT01', '1811505310121', 8 ),
		 ( '120CSDLP01', '1811505310121', 9 ),
		 ( '120TLTJ01', '1811505310121', 7 ),
		 ( '120LHDTJ02', '1811505310121', 8.7 ),

		 ( '291LTWNC01', '1811505310122', 7.7 ),
		 ( '120BTMT01', '1811505310122', 8 ),
		 ( '120CSDLP01', '1811505310122', 9 ),
		 ( '120TLTJ01', '1811505310122', 7 ),
		 ( '120LHDTJ02', '1811505310122', 8.7 ),

		 ( '291LTWNC01', '1811505310123', 7.7 ),
		 ( '120BTMT01', '1811505310123', 8 ),
		 ( '120CSDLP01', '1811505310123', 9 ),
		 ( '120TLTJ01', '1811505310123', 7 ),
		 ( '120LHDTJ02', '1811505310123', 8.7 ),

		 ( '291LTWNC01', '1811505310124', 7.7 ),
		 ( '120BTMT01', '1811505310124', 8 ),
		 ( '120CSDLP01', '1811505310124', 9 ),
		 ( '120TLTJ01', '1811505310124', 7 ),
		 ( '120LHDTJ02', '1811505310124', 8.7 ),

		 ( '291LTWNC01', '1811505310125', 7.7 ),
		 ( '120BTMT01', '1811505310125', 8 ),
		 ( '120CSDLP01', '1811505310125', 9 ),
		 ( '120TLTJ01', '1811505310125', 7 ),
		 ( '120LHDTJ02', '1811505310125', 8.7 ),

		 ( '291LTWNC01', '1811505310126', 7.7 ),
		 ( '120BTMT01', '1811505310126', 8 ),
		 ( '120CSDLP01', '1811505310126', 9 ),
		 ( '120TLTJ01', '1811505310126', 7 ),
		 ( '120LHDTJ02', '1811505310126', 8.7 ),

		 ( '291LTWNC01', '1811505310127', 7.7 ),
		 ( '120BTMT01', '1811505310127', 8 ),
		 ( '120CSDLP01', '1811505310127', 9 ),
		 ( '120TLTJ01', '1811505310127', 7 ),
		 ( '120LHDTJ02', '1811505310127', 8.7 ),

		 ( '291LTWNC01', '1811505310128', 7.7 ),
		 ( '120BTMT01', '1811505310128', 8 ),
		 ( '120CSDLP01', '1811505310128', 9 ),
		 ( '120TLTJ01', '1811505310128', 7 ),
		 ( '120LHDTJ02', '1811505310128', 8.7 )

 GO
INSERT  INTO dbo.TKHK
VALUES  ( '118', '1811505310107', 18, 40, 3.2 ),
        ( '119', '1811505310107', 18, 40, 3.4 ),
        ( '120', '1811505310107', 18, 40, 3.2 ),
        ( '218', '1811505310107', 18, 40, 3.3 ),
        ( '219', '1811505310107', 18, 40, 3.3 ),
        ( '220', '1811505310107', 23, 40, 3.1 ),

		( '118', '1811505310126', 18, 40, 3.2 ),
        ( '119', '1811505310126', 18, 40, 3.4 ),
        ( '120', '1811505310126', 18, 40, 3.2 ),
        ( '218', '1811505310126', 18, 40, 3.3 ),
        ( '219', '1811505310126', 18, 40, 3.3 ),
        ( '220', '1811505310126', 23, 40, 3.1 ),

		( '118', '1811505310127', 18, 40, 3.2 ),
        ( '119', '1811505310127', 18, 40, 3.4 ),
        ( '120', '1811505310127', 18, 40, 3.2 ),
        ( '218', '1811505310127', 18, 40, 3.3 ),
        ( '219', '1811505310127', 18, 40, 3.3 ),
        ( '220', '1811505310127', 23, 40, 3.1 ),

		( '118', '1811505310128', 18, 40, 3.2 ),
        ( '119', '1811505310128', 18, 40, 3.4 ),
        ( '120', '1811505310128', 18, 40, 3.2 ),
        ( '218', '1811505310128', 18, 40, 3.3 ),
        ( '219', '1811505310128', 18, 40, 3.3 ),
        ( '220', '1811505310128', 23, 40, 3.1 ),

		( '118', '1811505310129', 18, 40, 3.2 ),
        ( '119', '1811505310129', 18, 40, 3.4 ),
        ( '120', '1811505310129', 18, 40, 3.2 ),
        ( '218', '1811505310129', 18, 40, 3.3 ),
        ( '219', '1811505310129', 18, 40, 3.3 ),
        ( '220', '1811505310129', 23, 40, 3.1 ),

		( '118', '1811505310130', 18, 40, 3.2 ),
        ( '119', '1811505310130', 18, 40, 3.4 ),
        ( '120', '1811505310130', 18, 40, 3.2 ),
        ( '218', '1811505310130', 18, 40, 3.3 ),
        ( '219', '1811505310130', 18, 40, 3.3 ),
        ( '220', '1811505310130', 23, 40, 3.1 ),

		( '118', '1811505310131', 18, 40, 3.2 ),
        ( '119', '1811505310131', 18, 40, 3.4 ),
        ( '120', '1811505310131', 18, 40, 3.2 ),
        ( '218', '1811505310131', 18, 40, 3.3 ),
        ( '219', '1811505310131', 18, 40, 3.3 ),
        ( '220', '1811505310131', 23, 40, 3.1 ),

		( '118', '1811505310132', 18, 40, 3.2 ),
        ( '119', '1811505310132', 18, 40, 3.4 ),
        ( '120', '1811505310132', 18, 40, 3.2 ),
        ( '218', '1811505310132', 18, 40, 3.3 ),
        ( '219', '1811505310132', 18, 40, 3.3 ),
        ( '220', '1811505310132', 23, 40, 3.1 ),

		( '118', '1811505310133', 18, 40, 3.2 ),
        ( '119', '1811505310133', 18, 40, 3.4 ),
        ( '120', '1811505310133', 18, 40, 3.2 ),
        ( '218', '1811505310133', 18, 40, 3.3 ),
        ( '219', '1811505310133', 18, 40, 3.3 ),
        ( '220', '1811505310133', 23, 40, 3.1 ),

		( '118', '1811505310134', 18, 40, 3.2 ),
        ( '119', '1811505310134', 18, 40, 3.4 ),
        ( '120', '1811505310134', 18, 40, 3.2 ),
        ( '218', '1811505310134', 18, 40, 3.3 ),
        ( '219', '1811505310134', 18, 40, 3.3 ),
        ( '220', '1811505310134', 23, 40, 3.1 ),

		( '118', '1811505310135', 18, 40, 3.2 ),
        ( '119', '1811505310135', 18, 40, 3.4 ),
        ( '120', '1811505310135', 18, 40, 3.2 ),
        ( '218', '1811505310135', 18, 40, 3.3 ),
        ( '219', '1811505310135', 18, 40, 3.3 ),
        ( '220', '1811505310135', 23, 40, 3.1 ),

		( '118', '1811505310120', 18, 40, 3.2 ),
        ( '119', '1811505310120', 18, 40, 3.4 ),
        ( '120', '1811505310120', 18, 40, 3.2 ),
        ( '218', '1811505310120', 18, 40, 3.3 ),
        ( '219', '1811505310120', 18, 40, 3.3 ),
        ( '220', '1811505310120', 23, 40, 3.1 )


GO
CREATE VIEW SINHVIEN_VIEW AS
	SELECT SV.maSV, SV.hoTen, SV.maLop, TKHK.sTCDK, TKHK.dTBC, TKHK.maHK
	FROM SinhVien SV
	JOIN TKHK ON SV.maSV = TKHK.maSV
	JOIN LOP AS L ON SV.maLop = L.maLop
	JOIN HocKy AS HK ON HK.maHK = TKHK.maHK
