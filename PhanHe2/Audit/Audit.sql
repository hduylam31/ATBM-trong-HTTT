--Cap quyen audit cho Admin_BenhVien
GRANT AUDIT_ADMIN to C##Admin_BenhVien;
GRANT AUDIT_VIEWER to C##Admin_BenhVien;

-- Dang nhap vao user Admin
--Truy van audit
SELECT DBUSERNAME ,ACTION_NAME, OBJECT_SCHEMA, OBJECT_NAME, EVENT_TIMESTAMP, SQL_TEXT
FROM unified_audit_trail;

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
  , audit_condition => 'EXTRACT(YEAR FROM NGAY) = '2019'
  , audit_column => NULL
  , handler_schema => NULL
  , handler_module => NULL
  , enable => TRUE
  , statement_types => 'SELECT'
  );
END;

