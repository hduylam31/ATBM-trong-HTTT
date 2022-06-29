select * from  C##Admin_BenhVien.HSBA;
select * from  C##Admin_BenhVien.HSBA_DV;
select * from  C##Admin_BenhVien.BENHNHAN;
select * from  C##Admin_BenhVien.CSYT;
select * from  C##Admin_BenhVien.NHANVIEN;

drop table HSBA;
drop table HSBA_DV;
drop table BENHNHAN;
drop table CSYT;
drop table NHANVIEN;

create table HSBA(
	MAHSBA number(5),
	MABN number(5),
	NGAY date,
	CHANDOAN varchar2(20),
	MABS number(5),
	MAKHOA number(5),
	MACSYT number(5),
	KETLUAN varchar2(20),

	PRIMARY KEY(MAHSBA)
);

create table HSBA_DV(
	MAHSBA number(5),
	MADV number(5),
	NGAY date,
	MAKTV number(5),
	KETQUA varchar2(20),

	PRIMARY KEY(MAHSBA,MADV,NGAY)
);


create table BENHNHAN(
	MABN number(5),
	MACSYT number(5),
	TENBN nvarchar2(20),
	CMND number(10),
	NGAYSINH date,
	SONHA number(3),
	TENDUONG varchar2(20),
	QUANHUYEN varchar2(20),
	TINHTP varchar2(20),
	TIENSUBENH varchar2(20),
	TIENSUBENHGD varchar2(20),
	DIUNGTHUOC varchar2(20),

	PRIMARY KEY(MABN)
);

create table CSYT(
	MACSYT number(5),
	TENCSYT varchar2(20),
	DCCSYT varchar2(50),
	SDTCSYT number(10),

	PRIMARY KEY(MACSYT)
);

create table NHANVIEN(
	MANV number(5),
	HOTEN nvarchar2(20),
	PHAI varchar2(10),
	NGAYSINH date,
	CMND number(10),
	QUEQUAN varchar2(20),
	SDT number(10),
	CSYT number(5),
	VAITRO varchar2(20),
	CHUYENKHOA varchar2(20),

	PRIMARY KEY(MANV)
);

ALTER TABLE BENHNHAN
ADD CONSTRAINT FK_BENHNHAN_MACSYT
FOREIGN KEY (MACSYT)
REFERENCES CSYT(MACSYT);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_CSYT
FOREIGN KEY (CSYT)
REFERENCES CSYT(MACSYT);

ALTER TABLE HSBA
ADD CONSTRAINT FK_HSBA_MABN
FOREIGN KEY (MABN)
REFERENCES BENHNHAN(MABN);

ALTER TABLE HSBA
ADD CONSTRAINT FK_HSBA_MABS
FOREIGN KEY (MABS)
REFERENCES NHANVIEN(MANV);

ALTER TABLE HSBA
ADD CONSTRAINT FK_HSBA_MACSYT
FOREIGN KEY (MACSYT)
REFERENCES CSYT(MACSYT);

ALTER TABLE HSBA_DV
ADD CONSTRAINT FK_HSBA_DV_MAKTV
FOREIGN KEY (MAKTV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE HSBA_DV
ADD CONSTRAINT FK_HSBA_DV_MAHSBA
FOREIGN KEY (MAHSBA)
REFERENCES HSBA(MAHSBA);

INSERT INTO  CSYT VALUES (1, N'Bac Ninh ', N'Nguyen Tat Thanh ', N'0432983952');
INSERT INTO  CSYT VALUES (2, N'Thua Thien-Hue ', N'Duong so 18', N'0563415553');
INSERT INTO  CSYT VALUES (3, N'Ninh Binh ', N'Duong so 623', N'0396157611');
INSERT INTO  CSYT VALUES (4, N'Kien Giang ', N'Nguyen Bieu', N'0693915449');
INSERT INTO  CSYT VALUES (5, N'Bac Lieu ', N'Nguyen Hue', N'0175427559');

INSERT INTO  BENHNHAN VALUES (1, 2, N'T�n L?', N'2853979520', TO_DATE('1992-09-08', 'yyyy-mm-dd'), N'295', N'Ba Hom', N'6', N'Gia Lai ', N'viem nao', N'viem nao', N'co');
INSERT INTO  BENHNHAN VALUES (2, 1, N'B�nh Qu�n', N'2855085007', TO_DATE('1999-08-27', 'yyyy-mm-dd'), N'779', N'Go Cam Dem', N'5', N'Lam Dong ', N'nam Candida albicans', N'cum A/H5N1', N'khong');
INSERT INTO  BENHNHAN VALUES (3, 4, N'�inh L?c', N'2854898708', TO_DATE('1999-07-03', 'yyyy-mm-dd'), N'592', N'De Ap Tran Hung Dao', N'5', N'Tuyen Quang ', N'lau', N'sot xuat huyet', N'co');
INSERT INTO  BENHNHAN VALUES (4, 5, N'Qu?c Vi?t', N'2857835331', TO_DATE('1996-10-13', 'yyyy-mm-dd'), N'926', N'Ward 08', N'9', N'Bac Ninh ', N'viem nao', N'ta', N'khong');
INSERT INTO  BENHNHAN VALUES (5, 3, N'Tu?n Ki?t', N'2853236931', TO_DATE('1994-11-17', 'yyyy-mm-dd'), N'381', N'Duong so 9A', N'3', N'Dong Nai ', N'viem ho hap', N'san la gan', N'khong');
INSERT INTO  BENHNHAN VALUES (6, 2, N'Vi?t Phong', N'2855221245', TO_DATE('1993-05-22', 'yyyy-mm-dd'), N'315', N'Quang Trung', N'5', N'Tay Ninh ', N'vang da', N'viem ho hap', N'co');
INSERT INTO  BENHNHAN VALUES (7, 1, N'Vi?t Th�i', N'2852407110', TO_DATE('1998-07-04', 'yyyy-mm-dd'), N'486', N'Duong so 49', N'5', N'Nghe An ', N'tay chan mieng', N'sot ret', N'khong');
INSERT INTO  BENHNHAN VALUES (8, 1, N'Thi?n Ph??c', N'2853191520', TO_DATE('1986-11-18', 'yyyy-mm-dd'), N'081', N'Dong Da', N'8', N'Ha Nam ', N'phong', N'ho ga', N'co');
INSERT INTO  BENHNHAN VALUES (9, 4, N'B?o B?o', N'2856238419', TO_DATE('1984-06-05', 'yyyy-mm-dd'), N'038', N'Ap Bac', N'3', N'Ha Nam ', N'dai', N'cum', N'khong');
INSERT INTO  BENHNHAN VALUES (10, 2, N'H?ng S?n', N'2858710615', TO_DATE('1997-04-06', 'yyyy-mm-dd'), N'338', N'Do Quang Dau', N'2', N'Phu Tho ', N'soi than', N'quai bi', N'co');

INSERT INTO  NHANVIEN  VALUES (1, N'Ph� Th?nh', N'Nu', TO_DATE('1994-08-16', 'yyyy-mm-dd'), N'2853613212', N'Vinh Long ', N'0927137473', 4, N'Co so y te', N' Rang ham mat');
INSERT INTO  NHANVIEN  VALUES (2, N'H?ng Vi?t', N'Nu', TO_DATE('1992-03-22', 'yyyy-mm-dd'), N'2856018583', N'Vinh Long ', N'0992818449', 5, N'Y/Bac si', N' Da lieu');
INSERT INTO  NHANVIEN  VALUES (3, N'Minh Danh', N'Nam', TO_DATE('1988-03-15', 'yyyy-mm-dd'), N'2852080392', N'Yen Bai ', N'0267998457', 3, N'Y/Bac si', N' Mat');
INSERT INTO  NHANVIEN  VALUES (4, N'H?u Tr�c', N'Nu', TO_DATE('1992-08-14', 'yyyy-mm-dd'), N'2852147691', N'Dien Bien ', N'0322813579', 2, N'Y/Bac si', N' Da khoa');
INSERT INTO  NHANVIEN  VALUES (5, N'Vi?t Ch�nh', N'Nu', TO_DATE('1985-09-15', 'yyyy-mm-dd'), N'2851108687', N'Khanh Hoa ', N'0921285954', 5, N'Y/Bac si', N' Da khoa');
INSERT INTO  NHANVIEN  VALUES (6, N'Cao Nghi?p', N'Nam', TO_DATE('1983-07-03', 'yyyy-mm-dd'), N'2850324481', N'Phu Yen ', N'0153294618', 5, N'Y/Bac si', N' Da lieu');
INSERT INTO  NHANVIEN  VALUES (7, N'L�m Tr??ng', N'Nu', TO_DATE('1993-03-20', 'yyyy-mm-dd'), N'2853691986', N'Vinh Long ', N'0874538925', 1, N'Y/Bac si', N' Rang ham mat');
INSERT INTO  NHANVIEN  VALUES (8, N'H?i S?n', N'Nu', TO_DATE('1982-09-28', 'yyyy-mm-dd'), N'2857641620', N'Binh Dinh ', N'0254255786', 3, N'Y/Bac si', N' Da lieu');
INSERT INTO  NHANVIEN  VALUES (9, N'Gia Thi?n', N'Nu', TO_DATE('1981-05-14', 'yyyy-mm-dd'), N'2859386541', N'Can Tho ', N'0858864298', 2, N'Y/Bac si', N' Than');
INSERT INTO  NHANVIEN  VALUES (10, N'Minh Th�ng', N'Nam', TO_DATE('1988-05-18', 'yyyy-mm-dd'), N'2853075544', N'Tien Giang ', N'0164749835', 3, N'Y/Bac si', N' Mat');

INSERT INTO  HSBA  VALUES (1, 5, TO_DATE('2019-01-09', 'yyyy-mm-dd'), N'viem ho hap', 2, 5, 2, N'viem ho hap');
INSERT INTO  HSBA  VALUES (2, 2, TO_DATE('2020-09-27', 'yyyy-mm-dd'), N'tieu chay', 8, 3, 3, N'san la phoi');
INSERT INTO  HSBA  VALUES (3, 4, TO_DATE('2021-10-07', 'yyyy-mm-dd'), N'uon van', 3, 1, 1, N'ta');
INSERT INTO  HSBA  VALUES (4, 1, TO_DATE('2021-01-22', 'yyyy-mm-dd'), N'nam Candida albicans', 4, 4, 5, N'viem mang nao');
INSERT INTO  HSBA  VALUES (5, 10, TO_DATE('2021-09-09', 'yyyy-mm-dd'), N'bach hau', 1, 3, 2, N'giang mai');
INSERT INTO  HSBA  VALUES (6, 9, TO_DATE('2020-05-31', 'yyyy-mm-dd'), N'san la gan', 3, 2, 2, N'tim');
INSERT INTO  HSBA  VALUES (7, 6, TO_DATE('2019-03-09', 'yyyy-mm-dd'), N'quai bi', 5, 5, 3, N'sot xuat huyet');
INSERT INTO  HSBA  VALUES (8, 2, TO_DATE('2020-11-18', 'yyyy-mm-dd'), N'viem mang nao', 8, 3, 3, N'phong');
INSERT INTO  HSBA  VALUES (9, 4, TO_DATE('2020-05-06', 'yyyy-mm-dd'), N'ta', 1, 2, 3, N'bach hau');
INSERT INTO  HSBA  VALUES (10, 1, TO_DATE('2019-01-31', 'yyyy-mm-dd'), N'sot vang', 3, 2, 2, N'viem gan');
INSERT INTO  HSBA  VALUES (11, 7, TO_DATE('2020-05-30', 'yyyy-mm-dd'), N'quai bi', 2, 3, 4, N'cum');
INSERT INTO  HSBA  VALUES (12, 5, TO_DATE('2020-03-06', 'yyyy-mm-dd'), N'dai', 9, 2, 4, N'ho ga');
INSERT INTO  HSBA  VALUES (13, 3, TO_DATE('2019-11-21', 'yyyy-mm-dd'), N'sot xuat huyet', 1, 3, 1, N'ho ga');
INSERT INTO  HSBA  VALUES (14, 6, TO_DATE('2020-07-04', 'yyyy-mm-dd'), N'ho ga', 3, 5, 5, N'san la phoi');
INSERT INTO  HSBA  VALUES (15, 7, TO_DATE('2019-01-17', 'yyyy-mm-dd'), N'thuy dau', 8, 2, 3, N'lau');

INSERT INTO  HSBA_DV  VALUES (1, 3, TO_DATE('2019-11-02', 'yyyy-mm-dd'), 3, N'cum A/H5N1');
INSERT INTO  HSBA_DV  VALUES (1, 33, TO_DATE('2021-12-30', 'yyyy-mm-dd'), 6, N'viem mang nao');
INSERT INTO  HSBA_DV  VALUES (2, 8, TO_DATE('2019-07-19', 'yyyy-mm-dd'), 1, N'ta');
INSERT INTO  HSBA_DV  VALUES (3, 2, TO_DATE('2019-08-25', 'yyyy-mm-dd'), 10, N'lau');
INSERT INTO  HSBA_DV  VALUES (4, 7, TO_DATE('2021-01-15', 'yyyy-mm-dd'), 9, N'quai bi');
INSERT INTO  HSBA_DV  VALUES (5, 17, TO_DATE('2021-01-29', 'yyyy-mm-dd'), 2, N'cum');
INSERT INTO  HSBA_DV  VALUES (6, 6, TO_DATE('2020-06-16', 'yyyy-mm-dd'), 1, N'lau');
INSERT INTO  HSBA_DV  VALUES (7, 16, TO_DATE('2021-10-24', 'yyyy-mm-dd'), 7, N'cum A/H5N1');
INSERT INTO  HSBA_DV  VALUES (8, 23, TO_DATE('2021-02-23', 'yyyy-mm-dd'), 9, N'soi than');
INSERT INTO  HSBA_DV  VALUES (9, 15, TO_DATE('2021-04-07', 'yyyy-mm-dd'), 2, N'sot xuat huyet');
INSERT INTO  HSBA_DV  VALUES (10, 5, TO_DATE('2019-04-23', 'yyyy-mm-dd'), 8, N'lao phoi ');
