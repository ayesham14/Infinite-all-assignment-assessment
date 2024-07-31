create database cc7
 use cc7
create table books(
id int primary key,
title varchar(40),
author varchar(40),
isbn varchar(15) unique,
reviewername varchar(30),
publish_date Datetime,
ratings int
)

insert into books(id,title,author,isbn,reviewername,publish_date,ratings)values(1,'My First SQL book','Mary Parker','981483029127','John Smith','2012-02-22 12:08:17',4),
    (2,'My SECOND SQL book','John Mayer','857300923713','John Smith','1972-07-03 09:22:45',5),
    (3,'My THIRD SQL book','Cary Flint','523120967812','Alice Walker','2017-10-22 23:47:10',1)

 select * from books

 --Write a query to fetch the details of the books written by author whose name ends with er.

 select * from books
 where author like '%er'

 --Display the Title ,Author and ReviewerName for all the books from the above table 
 
 

 ---Display the  reviewer name who reviewed more than one book.

 select reviewername from books
 group by reviewername
 having count(*)>1

 create table customer(
 id int primary key,
 name varchar(50),
 address varchar(100),
 age int,
 salary float
 )

 insert into customer(id, name, address,age, salary) values
 (1,'ramesh','Ahmedabad',32, 2000.00),
 (2, 'khilan', 'delhi', 25, 1500.00),
 (3, 'kaushik', 'kota', 23, 2000.00),
 (4,'chaitali','mumbai',25,6500.00),
 (5,'kardik','bhopal',27,8500.00),
 (6,'komal','mp',22,4500),
 (7,'muffy','indore',24,10000)

 select * from customer

 ----Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

 select name as 'Name of the customer having o in address'
 from customer
 where address like '%o%'

 create table orders(
 order_id int primary key,
 order_date datetime,
 customer_id int,
 amount float
 )

 insert into orders(order_id,order_date,customer_id,amount)
 values
 (102,'2009-10-08 00:00:00',3,3000),
 (100,'2009-10-08 00:00:00',3,1500),
 (101,'2008-05-20 00:00:00',2,1560),
 (103,'2008-05-20 00:00:00',4,2060)

 select * from orders

 --Write a query to display the   Date,Total no of customer  placed order on same Date

 select order_date,count(customer_id) as 'Total Number Of Customers'
 from orders
 group by order_date

 create table employee(
 id int primary key,
 name varchar(50),
 address varchar(100),
 age int,
 salary float
 )

 insert into employee values(1,'ramesh','Ahmedabad',32, 2000.00),
 (2, 'khilan', 'delhi', 25, 1500.00),
 (3, 'kaushik', 'kota', 23, 2000.00),
 (4,'chaitali','mumbai',25,6500.00),
 (5,'kardik','bhopal',27,8500.00),
 (6,'komal','mp',22,null)

 select * from employee

 --Display the Names of the Employee in lower case, whose salary is null 
select LOWER(name) AS LowercaseName
from employee
where salary is null

create table students(
reg int primary key,
name varchar(100),
age int,
qualification varchar(100),
mobile_no varchar(14),
mail_id varchar(100),
location varchar(150),
gender char(1)
)

insert into students values (2, 'SAI', 22, 'BE', '9952836777', 'SAI@GMAIL.COM', 'CHENNAI', 'M'),
    (3, 'KUMAR', 20, 'BSC', '7890125648', 'KUMAR@GMAIL.COM', 'MADURAI', 'M'),
    (4, 'SELVI',  22, 'B  TECH', '8904567342', 'SELVI@GMAIL.COM', 'SELAM', 'F'),
(5, 'NISHA',  25, 'ME', '7834672310', 'NISHA@GMAIL.COM', 'THENI', 'F'),
  (6, 'SAISARAN',  21, 'BA', '7890345678', 'SARAN@GMAIL.COM', 'MADURAI', 'F'),
   (7, 'TOM',  23, 'BCA', '8901234675', 'TOM@GMAIL.COM', 'PUNE', 'M')

select * from students

--Write a sql server query to display the Gender,Total no of male and female from the above relation   

select gender, count(*) as 'Total Employees'
from students
group by gender