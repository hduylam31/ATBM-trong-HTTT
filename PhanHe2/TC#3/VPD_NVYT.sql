--Tao VPD sao cho Các nhân viên thu?c c? s? y t? có quy?n thêm ho?c xóa d?
--li?u phát sinh t? chính c? s? y t? mà nhân viên này tr?c thu?c
--Tao function vpd nhan vien so y te
CREATE OR REPLACE FUNCTION vpd_NhanVien_CSYT (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
v_user VARCHAR2(30);
BEGIN
v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
if v_user like 'C##SYT%' then
    RETURN 'MACSYT = '||SUBSTR(v_user, 7);
else 
    return '';
end if;
END;

--Xoa function
drop FUNCTION vpd_NhanVien_CSYT;

--Thi hanh policy
begin
DBMS_RLS.ADD_POLICY(object_schema => 'C##ADMIN_BENHVIEN',
object_name => 'HSBA', 
policy_name => 'STOCK_TRX_NHANVIENSYT_POLICY',
function_schema => 'C##Admin_BenhVien', 
policy_function => 'vpd_NhanVien_CSYT',
statement_types =>'SELECT, DELETE');
end;


--Xoa chinh sach
exec DBMS_RLS.DROP_POLICY('C##ADMIN_BENHVIEN', 'HSBA', 'STOCK_TRX_NHANVIENSYT_POLICY');

----liên quan 1 h? s? b?nh án
----Thi hanh policy
--begin
--DBMS_RLS.ADD_POLICY(object_schema => 'C##ADMIN_BENHVIEN',
--object_name => 'HSBA_DV', 
--policy_name => 'STOCK_TRX_NHANVIENSYT1_POLICY',
--function_schema => 'C##Admin_BenhVien', 
--policy_function => 'vpd_NhanVien_CSYT',
--statement_types =>'SELECT, DELETE');
--end;
--
--
----Xoa chinh sach
--exec DBMS_RLS.DROP_POLICY('C##ADMIN_BENHVIEN', 'HSBA_DV', 'STOCK_TRX_NHANVIENSYT1_POLICY');
--


--Test VPD trên user SYT1
SELECT * FROM C##Admin_BenhVien.HSBA;
--SELECT * FROM C##Admin_BenhVien.HSBA_DV;
