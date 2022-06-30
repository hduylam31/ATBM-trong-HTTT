-- MA HOA
-- HAM MA HOA/GIAI MA
CREATE OR REPLACE FUNCTION F_ENCRYPT (val IN VARCHAR2)
RETURN VARCHAR2
IS
    key_bytes_raw RAW(32);
    encrypted_raw RAW(2000); -- stores encrypted binary text
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_AES256
                                 + SYS.DBMS_CRYPTO.CHAIN_CBC
                                 + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    key_bytes_raw := UTL_I18N.STRING_TO_RAW('UkXp2r5u8x/A?D(G+KbPeShVmYq3t6v9');
    encrypted_raw := DBMS_CRYPTO.ENCRYPT (src => UTL_I18N.STRING_TO_RAW (val, 'AL32UTF8'),
                                          typ => encryption_type,
                                          key => key_bytes_raw);
    RETURN RAWTOHEX(encrypted_raw);
END F_ENCRYPT;
/
CREATE OR REPLACE FUNCTION F_DECRYPT (val IN VARCHAR2)
RETURN VARCHAR2
IS
    key_bytes_raw RAW(2000);
    decrypted_raw RAW(2000); -- stores decrypted binary text
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_AES256
                                 + SYS.DBMS_CRYPTO.CHAIN_CBC
                                 + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    key_bytes_raw := UTL_I18N.STRING_TO_RAW('UkXp2r5u8x/A?D(G+KbPeShVmYq3t6v9');
    decrypted_raw := DBMS_CRYPTO.DECRYPT (src => HEXTORAW(val),
                                          typ => encryption_type,
                                          key => key_bytes_raw);
   RETURN UTL_I18N.RAW_TO_CHAR(decrypted_raw, 'AL32UTF8');
END F_DECRYPT;
/
--
select * from HSBA;
select * from HSBA_DV;
select * from BENHNHAN;
select * from CSYT;
select * from NHANVIEN;

drop table HSBA_DV;
drop table HSBA;
drop table BENHNHAN;
drop table NHANVIEN;
drop table CSYT;
drop table KHOA;

create table KHOA(
    MAKHOA number(5),
    TENKHOA varchar2(20),
    
    PRIMARY KEY (MAKHOA)
);

create table HSBA(      -- Bao mat CHANDOAN, KETLUAN
	MAHSBA number(5),     
    MABN number(5),
	NGAY date,
	CHANDOAN varchar2(100),
	MABS number(5),
	MAKHOA number(5),
	MACSYT number(5),
	KETLUAN varchar2(100),

	PRIMARY KEY(MAHSBA)
);

create table HSBA_DV(       -- Bao mat KETQUA
	MAHSBA number(5),           
	MADV number(5),
	NGAY date,
	MAKTV number(5),
	KETQUA varchar2(100),

	PRIMARY KEY(MAHSBA,MADV,NGAY)
);

create table BENHNHAN(      -- Bao mat CMND, NGAYSINH, DIACHI, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC
	MABN number(5),          
	MACSYT number(5),
	TENBN nvarchar2(20),
	CMND varchar2(100),
	NGAYSINH varchar2(100),
	SONHA varchar2(100),
	TENDUONG varchar2(100),
	QUANHUYEN varchar2(20),
	TINHTP varchar2(20),
	TIENSUBENH varchar2(100),
	TIENSUBENHGD varchar2(100),
	DIUNGTHUOC varchar2(100),

	PRIMARY KEY(MABN)
);

create table CSYT(
	MACSYT number(5),
	TENCSYT varchar2(20),
	DCCSYT varchar2(50),
	SDTCSYT varchar2(10),

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
	CHUYENKHOA number(5),

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

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_CK
FOREIGN KEY(CHUYENKHOA)
REFERENCES KHOA(MAKHOA);

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

ALTER TABLE HSBA
ADD CONSTRAINT FK_HSBA_MAKHOA
FOREIGN KEY (MAKHOA)
REFERENCES KHOA(MAKHOA);

ALTER TABLE HSBA_DV
ADD CONSTRAINT FK_HSBA_DV_MAKTV
FOREIGN KEY (MAKTV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE HSBA_DV
ADD CONSTRAINT FK_HSBA_DV_MAHSBA
FOREIGN KEY (MAHSBA)
REFERENCES HSBA(MAHSBA);

INSERT INTO  KHOA VALUES (1, N'Rang ham mat');
INSERT INTO  KHOA VALUES (2, N'Da lieu');
INSERT INTO  KHOA VALUES (3, N'Mat');
INSERT INTO  KHOA VALUES (4, N'Da khoa');
INSERT INTO  KHOA VALUES (5, N'Tai - mui - hong');
INSERT INTO  KHOA VALUES (6, N'Tim');
INSERT INTO  KHOA VALUES (7, N'Than');
INSERT INTO  KHOA VALUES (8, N'Than kinh');
INSERT INTO  KHOA VALUES (9, N'Phoi');

INSERT INTO  CSYT VALUES (1, N'Bac Ninh', N'Nguyen Tat Thanh ', '0432983952');
INSERT INTO  CSYT VALUES (2, N'Thua Thien-Hue', N'Duong so 18', '0563415553');
INSERT INTO  CSYT VALUES (3, N'Ninh Binh', N'Duong so 623', '0396157611');
INSERT INTO  CSYT VALUES (4, N'Kien Giang', N'Nguyen Bieu', '0693915449');
INSERT INTO  CSYT VALUES (5, N'Bac Lieu', N'Nguyen Hue', '0175427559');

INSERT INTO  BENHNHAN VALUES (1, 2, N'Ton Le', F_ENCRYPT('2853979520'), F_ENCRYPT('1992-09-08'), F_ENCRYPT('295'), F_ENCRYPT(N'Ba Hom'), N'6', N'Gia Lai', F_ENCRYPT(N'Viem nao'), F_ENCRYPT(N'Viem nao'), F_ENCRYPT(N'Co'));
INSERT INTO  BENHNHAN VALUES (2, 1, N'B?nh Qu?n', F_ENCRYPT('2855085007'), F_ENCRYPT('1999-08-27'), F_ENCRYPT('779'), F_ENCRYPT(N'Go Cam Dem'), N'5', N'Lam Dong', F_ENCRYPT(N'Nam Candida albicans'), F_ENCRYPT(N'cum A/H5N1'), F_ENCRYPT(N'Khong'));
INSERT INTO  BENHNHAN VALUES (3, 4, N'?inh L?c', F_ENCRYPT('2854898708'), F_ENCRYPT('1999-07-03'), F_ENCRYPT('592'), F_ENCRYPT(N'De Ap Tran Hung Dao'), N'5', N'Tuyen Quang', F_ENCRYPT(N'Lau'), F_ENCRYPT(N'Sot xuat huyet'), F_ENCRYPT(N'Co'));
INSERT INTO  BENHNHAN VALUES (4, 5, N'Qu?c Vi?t', F_ENCRYPT('2857835331'), F_ENCRYPT('1996-10-13'), F_ENCRYPT('926'), F_ENCRYPT(N'Ward 08'), N'9', N'Bac Ninh', F_ENCRYPT(N'Viem nao'), F_ENCRYPT(N'Ta'), F_ENCRYPT(N'Khong'));
INSERT INTO  BENHNHAN VALUES (5, 3, N'Tu?n Ki?t', F_ENCRYPT('2853236931'), F_ENCRYPT('1994-11-17'),F_ENCRYPT('381'), F_ENCRYPT(N'Duong so 9A'), N'3', N'Dong Nai', F_ENCRYPT(N'Viem ho hap'), F_ENCRYPT(N'San la gan'), F_ENCRYPT(N'Khong'));
INSERT INTO  BENHNHAN VALUES (6, 2, N'Vi?t Phong', F_ENCRYPT('2855221245'), F_ENCRYPT('1993-05-22'), F_ENCRYPT('315'), F_ENCRYPT(N'Quang Trung'), N'5', N'Tay Ninh', F_ENCRYPT(N'Vang da'), F_ENCRYPT(N'Viem ho hap'), F_ENCRYPT(N'Co'));
INSERT INTO  BENHNHAN VALUES (7, 1, N'Vi?t Th?i', F_ENCRYPT('2852407110'), F_ENCRYPT('1998-07-04'), F_ENCRYPT('486'), F_ENCRYPT(N'Duong so 49'), N'5', N'Nghe An', F_ENCRYPT(N'Tay chan mieng'), F_ENCRYPT(N'Sot ret'), F_ENCRYPT(N'Khong'));
INSERT INTO  BENHNHAN VALUES (8, 1, N'Thi?n Ph??c', F_ENCRYPT('2853191520'), F_ENCRYPT('1986-11-18'), F_ENCRYPT('081'), F_ENCRYPT(N'Dong Da'), N'8', N'Ha Nam', F_ENCRYPT(N'Phong'), F_ENCRYPT(N'Ho ga'), F_ENCRYPT(N'Co'));
INSERT INTO  BENHNHAN VALUES (9, 4, N'B?o B?o', F_ENCRYPT('2856238419'), F_ENCRYPT('1984-06-05'), F_ENCRYPT('038'), F_ENCRYPT(N'Ap Bac'), N'3', N'Ha Nam', F_ENCRYPT(N'Dai'), F_ENCRYPT(N'Cum'), F_ENCRYPT(N'Khong'));
INSERT INTO  BENHNHAN VALUES (10, 2, N'H?ng S?n', F_ENCRYPT('2858710615'), F_ENCRYPT('1997-04-06'), F_ENCRYPT('338'), F_ENCRYPT(N'Do Quang Dau'), N'2', N'Phu Tho', F_ENCRYPT(N'Soi than'), F_ENCRYPT(N'Quai bi'), F_ENCRYPT(N'Co'));

INSERT INTO  NHANVIEN  VALUES (1, N'Phu Thinh', N'Nu', TO_DATE('1994-08-16', 'yyyy-mm-dd'), N'2853613212', N'Vinh Long', N'0927137473', 4, N'Co so y te', 1);
INSERT INTO  NHANVIEN  VALUES (2, N'Hong Viet', N'Nu', TO_DATE('1992-03-22', 'yyyy-mm-dd'), N'2856018583', N'Vinh Long', N'0992818449', 5, N'Y/Bac si', 2);
INSERT INTO  NHANVIEN  VALUES (3, N'Minh Danh', N'Nam', TO_DATE('1988-03-15', 'yyyy-mm-dd'), N'2852080392', N'Yen Bai', N'0267998457', 3, N'Y/Bac si', 3);
INSERT INTO  NHANVIEN  VALUES (4, N'Huu Trac', N'Nu', TO_DATE('1992-08-14', 'yyyy-mm-dd'), N'2852147691', N'Dien Bien', N'0322813579', 2, N'Y/Bac si', 4);
INSERT INTO  NHANVIEN  VALUES (5, N'Viet Ch?nh', N'Nu', TO_DATE('1985-09-15', 'yyyy-mm-dd'), N'2851108687', N'Khanh Hoa', N'0921285954', 5, N'Y/Bac si', 4);
INSERT INTO  NHANVIEN  VALUES (6, N'Cao Nghiep', N'Nam', TO_DATE('1983-07-03', 'yyyy-mm-dd'), N'2850324481', N'Phu Yen', N'0153294618', 5, N'Y/Bac si', 2);
INSERT INTO  NHANVIEN  VALUES (7, N'Lam Truong', N'Nu', TO_DATE('1993-03-20', 'yyyy-mm-dd'), N'2853691986', N'Vinh Long', N'0874538925', 1, N'Y/Bac si', 1);
INSERT INTO  NHANVIEN  VALUES (8, N'Hai Son', N'Nu', TO_DATE('1982-09-28', 'yyyy-mm-dd'), N'2857641620', N'Binh Dinh', N'0254255786', 3, N'Y/Bac si', 2);
INSERT INTO  NHANVIEN  VALUES (9, N'Gia Thien', N'Nu', TO_DATE('1981-05-14', 'yyyy-mm-dd'), N'2859386541', N'Can Tho', N'0858864298', 2, N'Y/Bac si', 7);
INSERT INTO  NHANVIEN  VALUES (10, N'Minh Thong', N'Nam', TO_DATE('1988-05-18', 'yyyy-mm-dd'), N'2853075544', N'Tien Giang', N'0164749835', 3, N'Y/Bac si', 3);
INSERT INTO  NHANVIEN  VALUES (11, N'Ngoc Mai', N'Nu', TO_DATE('1990-07-28', 'yyyy-mm-dd'), N'2853301456', N'Ha Noi', N'0988123444', 3, N'Thanh tra', 3);
INSERT INTO  NHANVIEN  VALUES (12, N'Dinh Toan', N'Nam', TO_DATE('1985-01-11', 'yyyy-mm-dd'), N'2852780091', N'Thanh Hoa', N'0283472145', 3, N'Thanh tra', 2);
INSERT INTO  NHANVIEN  VALUES (13, N'Minh Tri', N'Nam', TO_DATE('1998-12-01', 'yyyy-mm-dd'), N'2851608878', N'Bac Lieu', N'0907956722', 3, N'Thanh tra', 5);
INSERT INTO  NHANVIEN  VALUES (14, N'Thanh Ngoc', N'Nu', TO_DATE('1983-06-07', 'yyyy-mm-dd'), N'2854601969', N'An Giang', N'0375123456', 3, N'Thanh tra', 4);
INSERT INTO  NHANVIEN  VALUES (15, N'Lan Anh', N'Nu', TO_DATE('1996-01-18', 'yyyy-mm-dd'), N'2851120937', N'Tien Giang', N'0734666555', 3, N'Thanh tra', 7);
INSERT INTO  NHANVIEN  VALUES (16, N'Truong Vy', N'Nam', TO_DATE('1980-03-25', 'yyyy-mm-dd'), N'2854542388', N'Hue', N'0192653871', 3, N'Nghien cuu', 3);
INSERT INTO  NHANVIEN  VALUES (17, N'Khanh My', N'Nu', TO_DATE('1989-10-10', 'yyyy-mm-dd'), N'2858879605', N'Ha Giang', N'0943867992', 3, N'Nghien cuu', 2);
INSERT INTO  NHANVIEN  VALUES (18, N'Hong Ngoc', N'Nu', TO_DATE('1988-02-28', 'yyyy-mm-dd'), N'2852256789', N'Bac Ninh', N'0876119342', 3, N'Nghien cuu', 6);
INSERT INTO  NHANVIEN  VALUES (19, N'Truc Lieu', N'Nu', TO_DATE('1988-05-13', 'yyyy-mm-dd'), N'2850831162', N'TP.HCM', N'0345112887', 3, N'Nghien cuu', 8);
INSERT INTO  NHANVIEN  VALUES (20, N'Ngoc Nguyen', N'Nam', TO_DATE('1992-09-12', 'yyyy-mm-dd'), N'2857904890', N'Tay Ninh', N'0903776123', 3, N'Nghien cuu', 5);
INSERT INTO  NHANVIEN  VALUES (21, N'Anh Kim', N'Nu', TO_DATE('1997-05-10', 'yyyy-mm-dd'), N'2851206643', N'Ca Mau', N'0769111872', 3, N'Nghien cuu', 6);
INSERT INTO  NHANVIEN  VALUES (22, N'Thanh My', N'Nu', TO_DATE('1999-10-26', 'yyyy-mm-dd'), N'2852900087', N'Can Tho', N'0981230198', 3, N'Nghien cuu', 9);
INSERT INTO  NHANVIEN  VALUES (23, N'Vy Han', N'Nu', TO_DATE('1984-02-18', 'yyyy-mm-dd'), N'2853718894', N'Da Lat', N'0123444781', 3, N'Nghien cuu', 3);
INSERT INTO  NHANVIEN  VALUES (24, N'Mai Linh', N'Nu', TO_DATE('1990-11-12', 'yyyy-mm-dd'), N'2856123123', N'An Giang', N'0900780116', 3, N'Nghien cuu', 2);
INSERT INTO  NHANVIEN  VALUES (25, N'Minh Toan', N'Nam', TO_DATE('1997-01-18', 'yyyy-mm-dd'), N'2855879900', N'TP.HCM', N'0189227660', 3, N'Nghien cuu', 7);

INSERT INTO  HSBA  VALUES (1, 5, TO_DATE('2019-01-09', 'yyyy-mm-dd'), F_ENCRYPT(N'Viem ho hap'), 2, 5, 2, F_ENCRYPT(N'Viem ho hap'));
INSERT INTO  HSBA  VALUES (2, 2, TO_DATE('2020-09-27', 'yyyy-mm-dd'), F_ENCRYPT(N'Tieu chay'), 8, 3, 3, F_ENCRYPT(N'San la phoi'));
INSERT INTO  HSBA  VALUES (3, 4, TO_DATE('2021-10-07', 'yyyy-mm-dd'), F_ENCRYPT(N'Uon van'), 3, 1, 1, F_ENCRYPT(N'Ta'));
INSERT INTO  HSBA  VALUES (4, 1, TO_DATE('2021-01-22', 'yyyy-mm-dd'), F_ENCRYPT(N'Nam Candida albicans'), 4, 4, 5, F_ENCRYPT(N'Viem mang nao'));
INSERT INTO  HSBA  VALUES (5, 10, TO_DATE('2021-09-09', 'yyyy-mm-dd'), F_ENCRYPT(N'Bach cau'), 1, 3, 2, F_ENCRYPT(N'Giang mai'));
INSERT INTO  HSBA  VALUES (6, 9, TO_DATE('2020-05-31', 'yyyy-mm-dd'), F_ENCRYPT(N'San la gan'), 3, 2, 2, F_ENCRYPT(N'Tim'));
INSERT INTO  HSBA  VALUES (7, 6, TO_DATE('2019-03-09', 'yyyy-mm-dd'), F_ENCRYPT(N'Quai bi'), 5, 5, 3, F_ENCRYPT(N'Sot xuat huyet'));
INSERT INTO  HSBA  VALUES (8, 2, TO_DATE('2020-11-18', 'yyyy-mm-dd'), F_ENCRYPT(N'Viem mang nao'), 8, 3, 3, F_ENCRYPT(N'Phong'));
INSERT INTO  HSBA  VALUES (9, 4, TO_DATE('2020-05-06', 'yyyy-mm-dd'), F_ENCRYPT(N'Ta'), 1, 2, 3, F_ENCRYPT(N'Bach hau'));
INSERT INTO  HSBA  VALUES (10, 1, TO_DATE('2019-01-31', 'yyyy-mm-dd'), F_ENCRYPT(N'Sot vang'), 3, 2, 2, F_ENCRYPT(N'Viem gan'));
INSERT INTO  HSBA  VALUES (11, 7, TO_DATE('2020-05-30', 'yyyy-mm-dd'), F_ENCRYPT(N'Quai bi'), 2, 3, 4, F_ENCRYPT(N'Cum'));
INSERT INTO  HSBA  VALUES (12, 5, TO_DATE('2020-03-06', 'yyyy-mm-dd'), F_ENCRYPT(N'Dai'), 9, 2, 4, F_ENCRYPT(N'Ho ga'));
INSERT INTO  HSBA  VALUES (13, 3, TO_DATE('2019-11-21', 'yyyy-mm-dd'), F_ENCRYPT(N'Sot xuat huyet'), 1, 3, 1, F_ENCRYPT(N'Ho ga'));
INSERT INTO  HSBA  VALUES (14, 6, TO_DATE('2020-07-04', 'yyyy-mm-dd'), F_ENCRYPT(N'Thuy dau'), 3, 5, 5, F_ENCRYPT(N'San la phoi'));
INSERT INTO  HSBA  VALUES (15, 7, TO_DATE('2019-01-17', 'yyyy-mm-dd'), F_ENCRYPT(N'Thuy dau'), 8, 2, 3, F_ENCRYPT(N'Lau'));

INSERT INTO  HSBA_DV  VALUES (1, 3, TO_DATE('2019-11-02', 'yyyy-mm-dd'), 3, F_ENCRYPT(N'Cum A/H5N1'));
INSERT INTO  HSBA_DV  VALUES (1, 33, TO_DATE('2021-12-30', 'yyyy-mm-dd'), 6, F_ENCRYPT(N'Viem mang nao'));
INSERT INTO  HSBA_DV  VALUES (3, 2, TO_DATE('2019-08-25', 'yyyy-mm-dd'), 10, F_ENCRYPT(N'Lau'));
INSERT INTO  HSBA_DV  VALUES (4, 7, TO_DATE('2021-01-15', 'yyyy-mm-dd'), 9, F_ENCRYPT(N'Quai bi'));
INSERT INTO  HSBA_DV  VALUES (5, 17, TO_DATE('2021-01-29', 'yyyy-mm-dd'), 2, F_ENCRYPT(N'Cum'));
INSERT INTO  HSBA_DV  VALUES (6, 6, TO_DATE('2020-06-16', 'yyyy-mm-dd'), 1, F_ENCRYPT(N'Lau'));
INSERT INTO  HSBA_DV  VALUES (7, 16, TO_DATE('2021-10-24', 'yyyy-mm-dd'), 7, F_ENCRYPT(N'Cum A/H5N1'));
INSERT INTO  HSBA_DV  VALUES (8, 23, TO_DATE('2021-02-23', 'yyyy-mm-dd'), 9, F_ENCRYPT(N'Soi than'));
INSERT INTO  HSBA_DV  VALUES (9, 15, TO_DATE('2021-04-07', 'yyyy-mm-dd'), 2, F_ENCRYPT(N'Sot xuat huyet'));
INSERT INTO  HSBA_DV  VALUES (10, 5, TO_DATE('2019-04-23', 'yyyy-mm-dd'), 8, F_ENCRYPT(N'Lao phoi'));

--
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- Xoa user
DECLARE
    CURSOR C IS (SELECT USERNAME
                 FROM DBA_USERS
                 WHERE INSTR(USERNAME, 'TT') != 0 OR INSTR(USERNAME, 'NC') != 0);
    MY_U VARCHAR2(5);
    strSQL VARCHAR2(2000);
BEGIN
    OPEN C;
    LOOP
        FETCH C INTO MY_U;
        EXIT WHEN C%NOTFOUND;
        
        strSQL := 'DROP USER '||MY_U;
        EXECUTE IMMEDIATE (strSQL);     
    END LOOP;
END;
/
-- THANH TRA
DROP ROLE RL_THANHTRA;
CREATE ROLE RL_THANHTRA;

DECLARE
    CURSOR C IS (SELECT TO_CHAR(MANV)
                 FROM NHANVIEN
                 WHERE VAITRO = 'Thanh tra');
    MY_TT VARCHAR2(5);
    strSQL VARCHAR2(2000);
BEGIN
    OPEN C;
    LOOP
        FETCH C INTO MY_TT;
        EXIT WHEN C%NOTFOUND;
        
        strSQL := 'CREATE USER TT'||MY_TT||' IDENTIFIED BY TT'||MY_TT;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO TT'||MY_TT;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT RL_THANHTRA TO TT'||MY_TT;  
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/
SELECT * FROM DBA_USERS WHERE INSTR(USERNAME, 'TT') != 0 ORDER BY USERNAME;
SELECT * FROM DBA_SYS_PRIVS WHERE PRIVILEGE = 'CREATE SESSION';
SELECT * FROM DBA_ROLE_PRIVS WHERE INSTR(GRANTEE, 'TT') != 0 ORDER BY GRANTEE;

GRANT EXECUTE ON F_DECRYPT TO RL_THANHTRA;

CREATE OR REPLACE VIEW V_THANHTRA_HSBA
AS
    SELECT MAHSBA, MABN, NGAY,
           F_DECRYPT(CHANDOAN) CHANDOAN,
           MABS, MAKHOA, MACSYT,
           F_DECRYPT(KETLUAN) KETLUAN
    FROM HSBA;
GRANT SELECT ON V_THANHTRA_HSBA TO RL_THANHTRA;

CREATE OR REPLACE VIEW V_THANHTRA_HSBA_DV
AS
    SELECT MAHSBA, MADV, NGAY, MAKTV, F_DECRYPT(KETQUA) KETQUA
    FROM HSBA_DV;
GRANT SELECT ON V_THANHTRA_HSBA_DV TO RL_THANHTRA;

CREATE OR REPLACE VIEW V_THANHTRA_BENHNHAN
AS
    SELECT MABN, MACSYT, TENBN,
           F_DECRYPT(CMND) CMND,
           TO_DATE(F_DECRYPT(NGAYSINH), 'yyyy-mm-dd') NGAYSINH,
           TO_NUMBER(F_DECRYPT(SONHA)) SONHA,
           F_DECRYPT(TENDUONG) TENDUONG,
           QUANHUYEN, TINHTP,
           F_DECRYPT(TIENSUBENH) TIENSUBENH,
           F_DECRYPT(TIENSUBENHGD) TIENSUBENHGD,
           F_DECRYPT(DIUNGTHUOC) DIUNGTHUOC
    FROM BENHNHAN;
GRANT SELECT ON V_THANHTRA_BENHNHAN TO RL_THANHTRA;

GRANT SELECT ON KHOA TO RL_THANHTRA;
GRANT SELECT ON CSYT TO RL_THANHTRA;
GRANT SELECT ON NHANVIEN TO RL_THANHTRA;

-- NGHIEN CUU
DROP ROLE RL_NGHIENCUU;
CREATE ROLE RL_NGHIENCUU;

--Tao user nghien cuu
DECLARE
    CURSOR C IS (SELECT TO_CHAR(MANV)
                 FROM NHANVIEN
                 WHERE VAITRO = 'Nghien cuu');
    MY_NC VARCHAR2(5);
    strSQL VARCHAR2(2000);
BEGIN
    OPEN C;
    LOOP
        FETCH C INTO MY_NC;
        EXIT WHEN C%NOTFOUND;
        
        strSQL := 'CREATE USER NC'||MY_NC||' IDENTIFIED BY NC'||MY_NC;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO NC'||MY_NC;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT RL_NGHIENCUU TO NC'||MY_NC;  
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/
SELECT * FROM DBA_USERS WHERE INSTR(USERNAME, 'NC') != 0 ORDER BY USERNAME;
SELECT * FROM DBA_SYS_PRIVS WHERE PRIVILEGE = 'CREATE SESSION';
SELECT * FROM DBA_ROLE_PRIVS WHERE INSTR(GRANTEE, 'NC') != 0 ORDER BY GRANTEE;

GRANT EXECUTE ON F_DECRYPT TO RL_NGHIENCUU;

CREATE OR REPLACE VIEW V_NGHIENCUU_HSBA
AS
    SELECT DISTINCT MAHSBA, MABN, NGAY,
                    F_DECRYPT(CHANDOAN) CHANDOAN,
                    MABS, HSBA.MAKHOA, HSBA.MACSYT,
                    F_DECRYPT(KETLUAN) KETLUAN
    FROM HSBA, KHOA, NHANVIEN NV, CSYT
    WHERE INSTR(SYS_CONTEXT('USERENV', 'SESSION_USER'), TO_CHAR(NV.MANV)) != 0 
          AND HSBA.MACSYT = NV.CSYT
          AND HSBA.MAKHOA = KHOA.MAKHOA
          AND NV.CHUYENKHOA = KHOA.MAKHOA;
GRANT SELECT ON V_NGHIENCUU_HSBA TO RL_NGHIENCUU;

CREATE OR REPLACE VIEW V_NGHIENCUU_HSBA_DV
AS
    SELECT DISTINCT HSBA_DV.MAHSBA, HSBA_DV.MADV, HSBA_DV.NGAY, HSBA_DV.MAKTV, F_DECRYPT(KETQUA) KETQUA
    FROM HSBA, HSBA_DV, KHOA, NHANVIEN NV, CSYT
    WHERE INSTR(SYS_CONTEXT('USERENV', 'SESSION_USER'), TO_CHAR(NV.MANV)) != 0 
          AND HSBA.MAHSBA = HSBA_DV.MAHSBA
          AND HSBA.MACSYT = NV.CSYT
          AND HSBA.MAKHOA = KHOA.MAKHOA
          AND NV.CHUYENKHOA = KHOA.MAKHOA;
GRANT SELECT ON V_NGHIENCUU_HSBA_DV TO RL_NGHIENCUU;

--Test user NghienCuu16
SELECT * FROM SYS.V_NGHIENCUU_HSBA;

SELECT * FROM SYS.V_NGHIENCUU_HSBA_DV;

--Test user ThanhTra11
SELECT * FROM SYS.KHOA;
SELECT * FROM SYS.CSYT;
SELECT * FROM SYS.NHANVIEN;

SELECT * FROM SYS.HSBA;
SELECT * FROM SYS.HSBA_DV;
SELECT * FROM SYS.BENHNHAN;

SELECT * FROM SYS.V_THANHTRA_BENHNHAN;
SELECT * FROM SYS.V_THANHTRA_HSBA;
SELECT * FROM SYS.V_THANHTRA_HSBA_DV;
