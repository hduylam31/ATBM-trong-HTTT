-------------Phân quyền cho role 
create or replace procedure Grant_Privs_toRole(Role_Name in varchar2, Privs_name in varchar2,Table_Name in varchar2)
authid current_user 
is
Tmp_Query varchar2(100);
begin 
    Tmp_Query := 'Grant '||Privs_name|| ' on ' ||Table_Name ||' to ' ||Role_Name;
    execute immediate (Tmp_Query); 
end;


--------------Thu hồi quyền của Role
create or replace procedure Revoke_Privs_toRole(Role_Name in varchar2, Privs_name in varchar2,Table_Name in varchar2)
authid current_user 
is
Tmp_Query varchar2(100);
begin 
    Tmp_Query := 'Revoke '||Privs_name|| ' on ' ||Table_Name ||' from ' ||Role_Name;
    execute immediate (Tmp_Query); 
end;