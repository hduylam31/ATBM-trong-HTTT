--Tao User BenhNhan
DECLARE
  CURSOR c1 IS
    SELECT MABN FROM C##Admin_BenhVien.BENHNHAN
    WHERE MABN < 11
    ORDER BY MABN;

  my_id   C##Admin_BenhVien.BENHNHAN.MABN%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('CREATE USER C##BN'|| my_id ||' IDENTIFIED BY CSYT'|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;

--Xoa user benh nhan
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user benh nhan
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##BN') != 0;

    my_id   dba_users.username%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('DROP USER '|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;
/

-- Xem danh sách user benh nhan
SELECT username
FROM dba_users
WHERE INSTR(username, 'C##BN') = 1


--Tao ROLE
CREATE ROLE C##BENHNHAN;

--Xoa ROLE
DROP ROLE C##BENHNHAN;

--Cap role cho user
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user benh nhan
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##BN') != 0;

    my_id   dba_users.username%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('GRANT C##BENHNHAN TO '|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;
/

--Phan quyen DBA
GRANT CREATE SESSION to C##BENHNHAN;

--Phan quyen Admin_BenhVien
--Quyen select
grant select on C##Admin_BenhVien.BENHNHAN to C##BENHNHAN;
revoke select on C##Admin_BenhVien.BENHNHAN from C##BENHNHAN;

--Quyen update tren cac truong tru truong MANV
grant update(TENBN, CMND, NGAYSINH, SONHA, 
TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC) 
on C##Admin_BenhVien.BENHNHAN to C##BENHNHAN;
REVOKE UPDATE ON C##Admin_BenhVien.BENHNHAN FROM C##BENHNHAN;

