create database EmploymentManagement

create table emp_details
(
empno int primary key,
empname varchar(50) not null,
empsal numeric(10,2) check(empsal>=25000),
emptype char(1) check (emptype in ('F', 'P'))
)

create procedure insertemp
@empname varchar(50),
@empsal numeric(10,2),
@emptype char(1)
as
begin
declare @empno int
select @empno = isnull(max(empno),0) +1 
from emp_details

insert into emp_details(empno,empname,empsal,emptype)
values(@empno, @empname, @empsal, @emptype)

select @empno as Empno
end