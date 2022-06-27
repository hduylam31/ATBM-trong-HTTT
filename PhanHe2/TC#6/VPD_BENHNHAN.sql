--Tao function 
CREATE OR REPLACE FUNCTION vpd_BenhNhan (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
v_user VARCHAR2(30);
BEGIN
v_user := SYS_CONTEXT('USERENV', 'SESSION_USER');
if v_user like 'C##BN%' then
    RETURN 'MABN = '||SUBSTR(SYS_CONTEXT('USERENV', 'SESSION_USER'), 6);
else 
    return '';
end if;
END;

--Xoa function
drop FUNCTION vpd_BenhNhan;

--Thi hanh plolicy
begin
DBMS_RLS.ADD_POLICY(object_schema => 'C##ADMIN_BENHVIEN',
object_name => 'BENHNHAN', 
policy_name => 'STOCK_TRX_BENHNHAN_POLICY',
function_schema => 'C##Admin_BenhVien', 
policy_function => 'vpd_BenhNhan',
statement_types =>'SELECT, UPDATE');
end;

--Xoa chinh sach
exec DBMS_RLS.DROP_POLICY('C##ADMIN_BENHVIEN', 'BENHNHAN', 'STOCK_TRX_BENHNHAN_POLICY');

