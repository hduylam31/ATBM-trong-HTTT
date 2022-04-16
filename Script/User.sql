--Xem quyen cua user
select * from dba_tab_privs where grantee ='C##LEKHOA1';
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




