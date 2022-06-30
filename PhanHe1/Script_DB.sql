-- XEM DANH SÁCH CÁC USERS
select * from dba_users;
-- XEM DANH SÁCH CÁC ROLES
select * from dba_roles;

/

-- XEM QUYỀN USER
select A.*
from (select grantee username,
             granted_role privilege,
             '--' owner,
             '--' table_name,
             '--' column_name,
             admin_option admin_option,
             'ROLE' access_type
      from dba_role_privs RP
      join dba_roles R on RP.granted_role = R.role
      where grantee in (select username from dba_users)
      union
      select grantee username,
             privilege privilege,
             '--' owner,
             '--' table_name,
             '--' column_name,
             admin_option admin_option,
             'SYSTEM' access_type
      from dba_sys_privs
      where grantee in (select username from dba_users)
      union
      select grantee username,
             privilege privilege,
             owner owner,
             table_name table_name,
             '--' column_name,
             grantable admin_option,
             'TABLE' access_type
      from dba_tab_privs
      where grantee in (select username from dba_users)
      union
      select DP.grantee username,
             privilege privilege,
             owner owner,
             table_name table_name,
             column_name column_name,
             '--' admin_option,
             'ROLE' access_type
      from role_tab_privs RP, dba_role_privs DP
      where RP.role = DP.granted_role and DP.grantee in (select username from dba_users)
      union
      select grantee username,
             privilege privilege,
             grantable admin_option,
             owner owner,
             table_name table_name,
             column_name column_name,
             'COLUMN' access_type
      from dba_col_privs
      where grantee in (select username from dba_users)) A
order by username, A.table_name, case
                                    when A.access_type = 'SYSTEM' then 1
                                    when A.access_type = 'TABLE' then 2
                                    when A.access_type = 'COLUMN' then 3
                                    when A.access_type = 'ROLE' then 4
                                 end,
                                 case
                                    when A.privilege in ('EXECUTE') then 1
                                    when A.privilege in ('SELECT', 'INSERT', 'DELETE') then 3
                                    else 2
                                 end,
                                 A.column_name, A.privilege;
/
-- XEM QUYỀN ROLE
select A.*
from (select grantee role,
            granted_role privilege,
            '--' owner,
            '--' table_name,
            '--' column_name,
            admin_option admin_option,
            'ROLE' access_type
        from dba_role_privs RP
        join dba_roles R on RP.granted_role = R.role
        where grantee in (select role from dba_roles)
        union
        select grantee role,
            privilege privilege,
            '--' owner,
            '--' table_name,
            '--' column_name,
            admin_option admin_option,
            'SYSTEM' access_type
        from dba_sys_privs
        where grantee in (select role from dba_roles)
        union
        select grantee role,
            privilege privilege,
            owner owner,
            table_name table_name,
            '--' column_name,
            grantable admin_option,
            'TABLE' access_type
        from dba_tab_privs
        where grantee in (select role from dba_roles)
        union
        select DP.grantee role,
            privilege privilege,
            owner owner,
            table_name table_name,
            column_name column_name,
            '--' admin_option,
            'ROLE' access_type
        from role_tab_privs RP, dba_role_privs DP
        where RP.role = DP.granted_role and DP.grantee in (select role from dba_roles)
        union
        select grantee role,
            privilege privilege,
            grantable admin_option,
            owner owner,
            table_name table_name,
            column_name column_name,
            'COLUMN' access_type
        from dba_col_privs
        where grantee in (select role from dba_roles)) A
order by role, A.table_name, case
                                    when A.access_type = 'SYSTEM' then 1
                                    when A.access_type = 'TABLE' then 2
                                    when A.access_type = 'COLUMN' then 3
                                    when A.access_type = 'ROLE' then 4
                                end,
                                case
                                    when A.privilege in ('EXECUTE') then 1
                                    when A.privilege in ('SELECT', 'INSERT', 'DELETE') then 3
                                    else 2
                                end,
                                A.column_name, A.privilege;

/

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

/

-------------Phân quyền cho role 
create or replace procedure Grant_Privs_toRole(Role_Name in varchar2, Privs_name in varchar2,Table_Name in varchar2)
authid current_user 
is
Tmp_Query varchar2(100);
begin 
    Tmp_Query := 'Grant '||Privs_name|| ' on ' ||Table_Name ||' to ' ||Role_Name;
    execute immediate (Tmp_Query); 
end;

/

--------------Thu hồi quyền của Role
create or replace procedure Revoke_Privs_toRole(Role_Name in varchar2, Privs_name in varchar2,Table_Name in varchar2)
authid current_user 
is
Tmp_Query varchar2(100);
begin 
    Tmp_Query := 'Revoke '||Privs_name|| ' on ' ||Table_Name ||' from ' ||Role_Name;
    execute immediate (Tmp_Query); 
end;

/

--Cap quyen cho user
create or replace procedure Grant_Privs_toUser(User_Name in varchar2, Privs_name in varchar2,Table_Name in varchar2,grant_option in Varchar2 )
authid current_user 
is
Tmp_count int;
Tmp_Query varchar2(100);
begin 
select count(*) into Tmp_count from all_users where username=User_name;
if(Tmp_count!=0) then
    if(grant_option='NO') then
    Tmp_Query:='Grant '||Privs_name|| ' on ' ||Table_Name ||' to ' ||User_Name;
    execute immediate (Tmp_query);
   
    elsif(grant_option='YES') then
    Tmp_Query:='Grant '||Privs_name|| ' on ' ||Table_Name ||' to ' ||User_Name||' With grant option' ;
    end if;
execute immediate (Tmp_query);
else 
RAISE_APPLICATION_ERROR(-20000,'User chua ton tai');
end if;
end;

/

--Thu hoi quyen cho user
create or replace procedure Revoke_Object_Privs_User(User_Name in varchar2, priv in varchar2, a_object in varchar2)
authid current_user is
Tmp_query varchar(100);
Tmp_count int;
exception_username exception;
Begin

select count(*) into Tmp_count from all_users where UserName=User_Name;
if(Tmp_count != 0) then
Tmp_query:='REVOKE '||priv||' ON ' ||a_object||' FROM ' ||User_name;
execute IMMEDIATE (Tmp_query);
elsif(Tmp_count=0) then
raise exception_username;
end if;

Exception 
when exception_username then 
RAISE_APPLICATION_ERROR(-20000,'User chua ton tai');
WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
End;




