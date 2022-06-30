--Cap quyen audit cho Admin_BenhVien
GRANT AUDIT_ADMIN to C##Admin_BenhVien;
GRANT AUDIT_VIEWER to C##Admin_BenhVien;

-- Dang nhap vao user Admin
--Truy van audit
SELECT DBUSERNAME ,ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, EVENT_TIMESTAMP, SQL_TEXT
FROM unified_audit_trail;

--UPDATE C##Admin_BenhVien.NHANVIEN SET HOTEN = 'ten' , SDT = TO_NUMBER('111'), QUEQUAN = 'que'
--select * from C##Admin_BenhVien.NHANVIEN;

--Xoa cac audit
BEGIN
DBMS_AUDIT_MGMT.CLEAN_AUDIT_TRAIL(
audit_trail_type => DBMS_AUDIT_MGMT.AUDIT_TRAIL_UNIFIED,
use_last_arch_timestamp => FALSE);
END;

--Tao audit
--Luu vet khi Benh nhan update tren cac cot TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC
BEGIN
  DBMS_FGA.ADD_POLICY(
  object_schema => 'C##Admin_BenhVien'
  , object_name => 'BENHNHAN'
  , policy_name => 'FGA_BENHNHAN_TSBENH'
  , audit_condition => NULL
  , audit_column => 'TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC'
  , handler_schema => NULL
  , handler_module => NULL
  , enable => TRUE
  , statement_types => 'UPDATE'
  );
END;

exec DBMS_FGA.DISABLE_POLICY('C##Admin_BenhVien', 'BENHNHAN', 'FGA_BENHNHAN_TSBENH');
exec DBMS_FGA.DROP_POLICY('C##Admin_BenhVien', 'BENHNHAN', 'FGA_BENHNHAN_TSBENH');

--Luu vet nhung nguoi tra cuu HSBA vao nam 2019
BEGIN
  DBMS_FGA.ADD_POLICY(
  object_schema => 'C##Admin_BenhVien'
  , object_name => 'HSBA'
  , policy_name => 'FGA_HSBA_NAM'
  , audit_condition => 'EXTRACT(YEAR FROM NGAY) = ''2019'''
  , audit_column => NULL
  , handler_schema => NULL
  , handler_module => NULL
  , enable => TRUE
  , statement_types => 'SELECT'
  );
END;

exec DBMS_FGA.DISABLE_POLICY('C##Admin_BenhVien', 'HSBA', 'FGA_HSBA_NAM');
exec DBMS_FGA.DROP_POLICY('C##Admin_BenhVien', 'HSBA', 'FGA_HSBA_NAM');

--Standard Auditing
CREATE AUDIT POLICY Audit_CSYT  ACTIONS INSERT ON C##Admin_BenhVien.CSYT;
CREATE AUDIT POLICY Audit_NHANVIEN  ACTIONS INSERT ON C##Admin_BenhVien.NHANVIEN;

DROP AUDIT POLICY Audit_CSYT;
DROP AUDIT POLICY Audit_NHANVIEN;

--Test audit FGA_BENHNHAN_TSBENH
UPDATE C##Admin_BenhVien.BENHNHAN
SET TIENSUBENH = N'Lao ph?i';

--Test audit FGA_HSBA_NAM
SELECT * FROM C##Admin_BenhVien.HSBA;

--Test audit Audit_CSYT
DELETE FROM CSYT WHERE MACSYT = 6;
INSERT INTO  CSYT VALUES (9, N'Soc Trang5', N'aHoang Huu Nam', N'01754274594');
