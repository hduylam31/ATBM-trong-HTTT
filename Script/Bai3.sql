----- Tao moi user
create or replace procedure Grant_NewUser(User_name in nvarchar2,Pass_Word in nvarchar2)
authid current_user 
as
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        RAISE_APPLICATION_ERROR(-20000,'User da ton tai'); 
    ELSE 
        execute immediate('Create user '|| User_name||' identified by '||Pass_Word);
        execute immediate('grant create session to '||User_name);
    END IF;
End;
/
----- Xoa user
create or replace procedure Drop_User(User_name in varchar2)
authid current_user 
as
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        execute immediate('DROP USER '|| User_name);
    ELSE 
         RAISE_APPLICATION_ERROR(-20000,'User khong ton tai'); 
    END IF;
End;
/
------Tao role moi
create or replace procedure Grant_NewRole(Role_name in varchar2,Pass_Word in varchar2)
authid current_user 
as
    Tmp_query varchar(100);
Begin
    IF(Pass_Word = ' ') THEN
    Tmp_query := 'Create role '|| Role_name;
    END IF;
    Tmp_query := 'Create role '|| Role_name||' identified by '||Pass_Word;
    execute IMMEDIATE (Tmp_query);
    exception
    when others then
        RAISE_APPLICATION_ERROR(-20000,'Role da ton tai'); 

End;
/
------Xoa role
create or replace procedure Drop_Role(Role_name in varchar2)
authid current_user 
as
    Tmp_query varchar(100);
Begin
    Tmp_query := 'Drop role '|| Role_name;
    execute IMMEDIATE (Tmp_query);
    exception
    when others then
        RAISE_APPLICATION_ERROR(-20000,'Role khong ton tai'); 

End;
/
-------Chinh sua password user
create or replace procedure Alter_User(User_name in varchar2,Pass_Word in varchar2)
authid current_user
is
Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username = User_name;
    If(Tmp_count != 0) then
        execute immediate('alter user '|| User_name||' identified by '||Pass_Word);
    ELSE 
            RAISE_APPLICATION_ERROR(-20000,'User khong ton tai'); 
    END IF;
END;
/
-------Chinh sua role
create or replace procedure Alter_Role(Role_name in varchar2,Pass_Word in varchar2)
authid current_user
is
    Tmp_count int;
    Tmp_query varchar2(100);
begin
    if(Pass_Word=' ') then
    Tmp_query :='ALTER ROLE '|| Role_Name|| ' Not IDENTIFIED';
    execute immediate(Tmp_query);
    elsif(pass_word!=' ') then
    Tmp_query :='ALTER ROLE '|| Role_Name|| ' IDENTIFIED BY'|| Pass_Word;
    end if;
end;

--- Chay thu
BEGIN 
    Grant_NewUser('BN1', 'BN1');
END;
/
BEGIN 
    Drop_User('BN1');
END;
/
BEGIN 
   Alter_User('BN1', 'LAM');
END;
/
BEGIN 
   Grant_NewRole('BACSI', '');
END;
/
BEGIN 
   Drop_Role('BACSI');
END;
/
BEGIN 
   Alter_Role('BACSI', 'LAM');
END;

--Cau 1
create or replace view XEM_USER
as
    select *
    from dba_users;
/ 
grant select on XEM_USER to Admin;

create or replace view XEM_ROLE
as
    select *
    from dba_roles;
/
grant select on XEM_ROLE to Admin;



BEGIN
    Drop_User(:name);
END;
