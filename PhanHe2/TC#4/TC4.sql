/* Phân tích:
Thực hiện bảo mật ở mức dòng dữ liệu => Khó để sử dụng, quản lý bằng cách tạo View + RBAC gán cho từng ngư�?i dùng
=> Sử dụng thêm VPD

Hướng thực hiện:
1. Tạo user và role YBS (Y/Bác sĩ) và gán t?ng user vào role
2. �?p dụng RBAC tạo view V_HSBA_KQDV HSBA + HSBA_DV và gán quy�?n xem (select) vào role YBS
3. �?p dụng VPD vào view V_HSBA_KQDV
4. C?p quy�?n xem BENHNHAN cho role YBS
*/

-- 1.1 TẠO ROLE Y/B�?C Sĩ + CẤP QUYỀN ROLE
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
DROP ROLE RL_YBS;
CREATE ROLE RL_YBS;
ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

-- 1.2 XÓA C�?C USER Y/B�?C SĨ
alter session set "_oracle_script"=true;
DROP PROCEDURE SP_DEL_USERS;
CREATE OR REPLACE PROCEDURE SP_DEL_USERS
AS
    CURSOR c_del_sv IS (SELECT USERNAME
                        FROM DBA_USERS
                        WHERE INSTR(USERNAME, 'YBS') != 0);
    my_YBS DBA_USERS.USERNAME%TYPE;
BEGIN
    OPEN c_del_sv;
    LOOP
        FETCH c_del_sv INTO my_YBS;
        IF c_del_sv%FOUND THEN
            EXECUTE IMMEDIATE ('DROP USER '||my_YBS);
        ELSE EXIT;
        END IF;
    END LOOP;
END;
/
EXECUTE SP_DEL_USERS;
alter session set "_oracle_script"=FALSE;

-- 1.3 TẠO USER CHO TỪNG Y/B�?C SĨ VÀ G�?N VÀO ROLE
CREATE OR REPLACE PROCEDURE usp_CreateUserYBS
AS
	CURSOR CUR IS (SELECT MANV
				FROM C##Admin_BenhVien.NHANVIEN
                WHERE VAITRO = N'Y/Bac si');
	strSQL VARCHAR(2000);
	Usr varchar2(30);
BEGIN
	OPEN CUR;
	strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
	EXECUTE IMMEDIATE (strSQL);
	LOOP
		FETCH CUR INTO Usr;
		EXIT WHEN CUR%NOTFOUND;
		
        -- VD: Y/Bac si có MANV = 1 => T?o tk: YBS1 mk: 1
		strSQL := 'CREATE USER YBS'||Usr||' IDENTIFIED BY '||Usr;
		EXECUTE IMMEDIATE (strSQL);
		strSQL := 'GRANT CREATE SESSION TO YBS'||Usr;
		EXECUTE IMMEDIATE (strSQL);
        -- Gán vào role RL_YBS
        strSQL := 'GRANT RL_YBS TO '||'YBS'||Usr;
        EXECUTE IMMEDIATE (strSQL);
	END LOOP;
	strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
	EXECUTE IMMEDIATE (strSQL);
END;
/
EXECUTE usp_CreateUserYBS;
/
-- 2.1 TẠO VIEW HSBA + HSBA_DV
DROP VIEW V_HSBA_KQDV;

CREATE VIEW V_HSBA_KQDV
AS
    SELECT H.*, D.MADV, D.NGAY AS NgayDV, D.KETQUA
    FROM C##Admin_BenhVien.HSBA H, C##Admin_BenhVien.HSBA_DV D
    WHERE H.MAHSBA = D.MAHSBA
 /   
-- 2.2 CẤP QUYỀN SELECT TRÊN VIEW V_HSBA_KQDV CHO  RL_YBS
GRANT SELECT ON V_HSBA_KQDV TO RL_YBS;

--Select view v_hsba_kqdv voi user BacSi
SELECT * FROM C##Admin_BenhVien.v_hsba_kqdv;

-- 3.1 FUNCTION CHO VPD
CREATE OR REPLACE FUNCTION sec_function_ybs (p_schema VARCHAR2, p_obj VARCHAR2)
    RETURN VARCHAR2
AS
    USER VARCHAR2(10);
    MAYBS NUMBER(5);
BEGIN
    USER := SYS_CONTEXT('userenv', 'SESSION_USER');
    USER := SUBSTR(USER, 4);
    MAYBS := TO_NUMBER(USER);
    RETURN 'MABS = '||MAYBS;
END;
/
-- 3.2 �?ĂNG K�? FUNCTION CHO VIEW V_HSBA_KQDV    
 BEGIN
    DBMS_RLS.add_policy
        (
        object_schema => 'C##Admin_BenhVien',
        object_name => 'V_HSBA_KQDV',
        policy_name => 'YBS_VIEW_SEC',
        policy_function => 'sec_function_ybs',
        statement_types => 'SELECT'
        );
 END;
 /
 
 
SELECT username
FROM dba_users
WHERE INSTR(username, 'YBS') != 0;
    
-- 4. CẤP QUYỀN XEM BENNHAN CHO Y/B�?C SĨ
GRANT SELECT ON C##Admin_BenhVien.BENHNHAN TO RL_YBS;
 
--Test VPD
SELECT * FROM C##Admin_BenhVien.v_hsba_kqdv;

--Test RBAC
SELECT * FROM C##Admin_BenhVien.BENHNHAN;
 
