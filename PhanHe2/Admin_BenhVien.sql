--Tao user Admin_BenhVien
create user C##Admin_BenhVien identified by Duy123;

-- Cap quyen tren Admin_BenhVien
GRANT CREATE SESSION to C##Admin_BenhVien;
GRANT CREATE ANY CONTEXT TO C##Admin_BenhVien;
GRANT CREATE PUBLIC SYNONYM TO C##Admin_BenhVien;
GRANT CREATE ANY TABLE TO C##Admin_BenhVien;
GRANT CREATE PROCEDURE TO C##Admin_BenhVien;
GRANT CREATE TRIGGER TO C##Admin_BenhVien;
GRANT CREATE VIEW TO C##Admin_BenhVien;
GRANT ADMINISTER DATABASE TRIGGER TO C##Admin_BenhVien;

--Cap quota cho Admin_BenhVien
ALTER USER C##Admin_BenhVien QUOTA UNLIMITED ON USERS;

--Dang nhap bang user Admin_BenhVien
--Tao user va role bang user SYS DBA

--TC#1
GRANT INSERT, UPDATE ON C##Admin_BenhVien.CSYT to SYS;
GRANT INSERT ON C##Admin_BenhVien.NHANVIEN to SYS;

