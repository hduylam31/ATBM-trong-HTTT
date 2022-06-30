--Tao User Nhan vien so y te
DECLARE
  CURSOR c1 IS
    SELECT DISTINCT MACSYT FROM C##Admin_BenhVien.HSBA
    ORDER BY MACSYT;

  my_id   C##Admin_BenhVien.HSBA.MACSYT%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('CREATE USER C##SYT'|| my_id ||' IDENTIFIED BY NHANVIEN'|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;


--Xoa user nhan vien so y te
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user so y te
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##SYT') != 0;

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

--Tao ROLE
CREATE ROLE C##NHANVIENCSYT;

--Xoa ROLE
DROP ROLE C##NHANVIENCSYT;

--Cap role cho user
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user benh nhan
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##SYT') != 0;

    my_id   dba_users.username%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('GRANT C##NHANVIENCSYT TO '|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;
/

--Phan quyen 
GRANT CREATE SESSION to C##NHANVIENCSYT;

GRANT SELECT, DELETE ON C##Admin_BenhVien.HSBA TO C##NHANVIENCSYT;
GRANT SELECT, DELETE ON C##Admin_BenhVien.HSBA_DV TO C##NHANVIENCSYT;

REVOKE SELECT, DELETE ON C##Admin_BenhVien.HSBA FROM C##NHANVIENCSYT;
REVOKE SELECT, DELETE ON C##Admin_BenhVien.HSBA_DV FROM C##NHANVIENCSYT;


