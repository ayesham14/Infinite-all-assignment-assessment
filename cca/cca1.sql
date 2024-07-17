create database assessment1

--1
create table birthday
(id int primary key,
name varchar(50),
birthdate date
)

insert into birthday values(100,'ayesha', '2000-10-14')
select * from birthday

select name,birthdate, datename(weekday, birthdate) as dayOfWeek from birthday



--2

declare @presentdate date =  getdate()

select name, birthdate,datediff(day, birthdate, @presentdate) as 'Present Age In Days'
from birthday


--3

create table employees (
    empid int primary key,
    fname varchar(50),
    lname varchar(50),
    mail varchar(100),
    age int,
    dob date,
    doj_month varchar(20),
    doj_year int
)

insert into employees (empid, fname, lname, mail, age, dob, doj_month, doj_year)
values
    (11, 'ayesha', 'muk', 'aayy@gmail.com', 16, '2000-05-13', 'may', 2024),
    (12, 'john', 'senar', 'jogt@gmail.com', 17, '1999-07-27 ','june', 2023),
    (14, 'alice', 'bob', 'kbob@gmail.com',20, '1994-02-05', 'july', 2019)
   
select fname, lname, doj_month, doj_year
from employees
where doj_month = 'july'
    and (doj_year < 2020)

  --4

  create table employeee
  (
  empno int primary key,
  empname varchar(50),
  sal decimal(10,2),
  doj date
  )

 begin transaction
insert into employeee values(1,'John', 50000, '2022-01-15'), (2,'Sena', 55000, '2019-03-10'),(3,'Smith', 60000, '2021-06-25')

update employeee set sal =sal*1.15
where empno =2

select * from employeee
delete from employeee where empno = 1

commit
insert into employee values(1,'John', 50000, '2022-01-15')

--5

create table department (
depptno int primary key,
dname varchar(50)
)


insert into department (depptno, dname)
values(10, 'Accounting'),(20, 'Research'),(30, 'Sales'),(40, 'Operations')

create table employeees (
emppno int primary key,
emppname varchar(50),
salry decimal(10, 2),
depptno int,
foreign key (depptno) references department(depptno)
)


insert into employeees (emppno, emppname, salry, depptno)
values(1, 'ayesha', 5000.00, 10),(2, 'muskan', 6000.00, 20),(3, 'alice', 7000.00, 30),(4, 'Johnson', 5500.00, 10),(5, 'Lee', 8000.00, 20),(6, 'Wilson', 6500.00, 30);

select *from department
select * from employeees



create function calculateBonus(depptno int, salry decimal(10, 2)) returns decimal(10, 2)
begin
    declare bonus decimal(10, 2);
    
    if depptno = 10 then
        set bonus = salry * 0.15; 
    elseif depptno = 20 then
        set bonus = salry * 0.20; 
        set bonus = salry * 0.05; 
    end if;
    
    return bonus;
end 

select emppname, salry, dname as department, calculateBonus(e.depptno, e.salry) as bonus
from employeees e
join departments d on e.depptno = d.depptno;


