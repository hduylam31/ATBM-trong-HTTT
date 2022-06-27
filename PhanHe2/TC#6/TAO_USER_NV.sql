--Tao User Nhan vien
DECLARE
  CURSOR c1 IS
    SELECT MANV FROM C##Admin_BenhVien.NHANVIEN
    WHERE MANV < 21
    ORDER BY MANV;

  my_id   C##Admin_BenhVien.NHANVIEN.MANV%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('CREATE USER C##NV'|| my_id ||' IDENTIFIED BY NHANVIEN'|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;


--Xoa user nhan vien
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user benh nhan
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##NV') != 0;

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
CREATE ROLE C##NHANVIEN;

--Xoa ROLE
DROP ROLE C##NHANVIEN;

--Cap role cho user
DECLARE
  CURSOR c1 IS
    -- Xem danh sách user benh nhan
    SELECT username
    FROM dba_users
    WHERE INSTR(username, 'C##NV') != 0;

    my_id   dba_users.username%TYPE;
  
BEGIN
  OPEN c1;
  LOOP
    FETCH c1 INTO my_id;
    IF c1%FOUND THEN  -- fetch succeeded
      execute immediate('GRANT C##NHANVIEN TO '|| my_id);
    ELSE  -- fetch failed
      EXIT;
    END IF;
  END LOOP;
  
  COMMIT WRITE IMMEDIATE NOWAIT;
END;
/

--Phan quyen 
GRANT CREATE SESSION to C##NHANVIEN;

grant select on C##Admin_BenhVien.NHANVIEN to C##NHANVIEN;
revoke select on C##Admin_BenhVien.NHANVIEN from C##NHANVIEN;

--Quyen update tren cac truong tru truong MANV
grant update(HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SDT, CHUYENKHOA) on C##Admin_BenhVien.NHANVIEN to C##NHANVIEN;
REVOKE UPDATE ON SYS.NHANVIEN FROM C##NHANVIEN;
