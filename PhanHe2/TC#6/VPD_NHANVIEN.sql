--Tao function vpd nhan vien
CREATE OR REPLACE FUNCTION vpd_NhanVien (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
v_user VARCHAR2(30);
BEGIN
v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
if v_user like 'C##NV%' then
    RETURN 'MANV = '||SUBSTR(v_user, 6);
else 
    return '';
end if;
END;

--Xoa function
drop FUNCTION vpd_NhanVien;

--Thi hanh policy
begin
DBMS_RLS.ADD_POLICY(object_schema => 'C##ADMIN_BENHVIEN',
object_name => 'NHANVIEN', 
policy_name => 'STOCK_TRX_NHANVIEN_POLICY',
function_schema => 'C##Admin_BenhVien', 
policy_function => 'vpd_NhanVien',
statement_types =>'SELECT, UPDATE');
end;

--Xoa chinh sach
exec DBMS_RLS.DROP_POLICY('C##ADMIN_BENHVIEN', 'NHANVIEN', 'STOCK_TRX_NHANVIEN_POLICY');

--Test VPD STOCK_TRX_NHANVIEN_POLICY
SELECT * FROM C##Admin_BenhVien.NHANVIEN;