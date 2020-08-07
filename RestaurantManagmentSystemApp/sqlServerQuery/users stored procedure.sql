create procedure st_insertUsers
@name varchar(30),
@uname varchar(30),
@password varchar(30),
@phone varchar(15),
@address varchar(100),
@email varchar(50)
as
insert into users (u_name,u_uname,u_password,u_phone,u_address,u_email) 
values (@name,@uname,@password,@phone,@address,@email)



create procedure st_updateUsers
@name varchar(30),
@uname varchar(30),
@password varchar(30),
@phone varchar(15),
@address varchar(100),
@email varchar(50),
@id int
as
update users
set
u_name=@name,
u_uname=@uname,
u_password=@password,
u_phone=@phone,
u_address=@address,
u_email=@email 
where
u_id=@id



create procedure st_deleteUser
@id int
as
delete from users where u_id=@id



create procedure st_getUsersData
as
select
u.u_id as 'ID',
u.u_name as 'Name',
u.u_uname as 'Username',
u.u_password as 'Password',
u.u_phone as 'Phone',
u.u_address as 'Address',
u.u_email as 'Email'
from users u
order by u.u_name asc