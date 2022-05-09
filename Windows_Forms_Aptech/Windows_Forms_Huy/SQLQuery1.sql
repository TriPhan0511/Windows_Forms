USE master
GO

DROP DATABASE IF EXISTS student_demo
GO

create database student_demo
go

USE student_demo
GO

create table _batches
(
id_batch int identity primary key not null,
batch_name varchar(20),
_description varchar(50) 
)
go
create table students
(
id_student int identity primary key not null,
student_name varchar(20),
birthday date,
phone int,
gender char(9),
email varchar(50) unique,
id_batch  int foreign key references _batches( id_batch) 
)
create table users
(
id_user int identity primary key not null,
us_name varchar(20) not null,
pass_word varchar(20) not null,
user_role varchar(20) not null,
)
create table teachers
(
id_teacher int identity primary key not null,
teacher_name varchar(20),
birthday date,
phone bigInt,
gender char(9),
email varchar(50),
id_user int foreign key references users(id_user),
id_batch int foreign key references _batches(id_batch)
)
create table attendances
(
id_attendance int identity not null,
id_batch int foreign key references _batches(id_batch),
id_student int foreign key references students(id_student),
id_user int foreign key references users(id_user),
attendance_status varchar(20),
attendance_date date
)
insert into _batches(batch_name,_description)
		values('batch164','dfdsfsdf'),
				('batch165','fdsfsfsdf')
				
insert into students(student_name,birthday,phone,gender,email,id_batch)
		values('Nguyen K','10-10-1999','0905632121','m','kjjjjkj@gmail.com','1'),
				('Nguyen A','09-10-1999','0905698321','m','dfgd@gmail.com','2'),
				('Nguyen B','10-01-1999','0905659821','m','kjkjhjkh@gmail.com','1'),
				('Nguyen C','08-10-1999','0914264321','m','fhjhkf@gmail.com','2')
insert into users (us_name,pass_word,user_role)
		values('Nguyen anh hieu','defauld','admin'),
			   ('Nguyen anh Huy','defauld','teacher')
insert into teachers(teacher_name ,birthday ,phone ,gender ,email ,id_user ,id_batch)
values('Nhat Kha','01-01-1994','0936521477','m','kha@gmail.com','1','1'),
      ('Thuy tien','01-09-1993','0312621477','f','tttt@gmail.com','2','1')
--create proc Sp_show_students(@batch_name)
--as
--begin
--select students.student_name
--from students join _batches on students.id_batch=_batches.id_batch
--where batch_name=@batch_name
--end

select * from students
update students set student_name='sgfdg',birthday='08-10-1999',phone='0905698321',gender='m',email='sdfdsf@gmail.com',id_batch='2' where id_student='1'
delete students where id_student='1'
insert into teachers(teacher_name ,birthday ,phone ,gender ,email ,id_user ,id_batch)
values('Quoc Dung','01-01-1979','0933652477','m','Dung@gmail.com','1','2')
select users.*,_batches.batch_name from users join teachers on
users.id_user=teachers.id_user join _batches on
teachers.id_batch=_batches.id_batch
drop database student_demo
select * from teachers
select * from _batches
select * from users
select * from attendances