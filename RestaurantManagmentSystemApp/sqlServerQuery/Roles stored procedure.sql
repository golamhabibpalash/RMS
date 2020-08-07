create procedure st_insertRole
@name varchar(30)
as
insert into roles(r_name)
values(@name)


create proc st_updateRole
@name varchar(30),
@id tinyint
as
update roles
set
r_name=@name
where
r_id=@id



create proc st_deleteRole
@id tinyint
as
delete from roles
where
r_id=@id


create proc st_getRoles
as
select * from roles