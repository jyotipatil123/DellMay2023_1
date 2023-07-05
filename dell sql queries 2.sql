
--Auto increment : 

select * from student1

insert into student1(name,city) values('abc','gujrat')

delete  from student1

table : 
   250 columns -------1 column 
   more than 1 column combination xxx auto increment 


create table person7
(
   id int identity(1,1) primary key,
   name varchar(50)
)

insert into person7(name) values('cc')

select * from person7

===================================================================
select * from person

insert into person(id,name, city) values(12,'anita','delhi')

alter table person
    alter column id int identity(1,1)



==============================================try it-----------------

Built in functions : 

--1. Aggregate functions : 

select * from customer 

select sum(custid) from customer
select avg(custid) from customer
select count(custid) from customer
select min(custid) from customer
select max(custid) from customer

--2.  Mathematical functions :

select sin(0.4), cos(0.3), tan(0.5)
select asin(0.4), acos(0.3), atan(0.5), cot(0.2)

select pi()

select power(2,3), square(5), log(0.5),log10(0.9)

select exp(0.2)

3.  string functions : 

select lower('INDIA'), upper('india')
select left('india is a country', 5)
select right('india is a country', 5)
select ltrim('      india')
select rtrim('india          ')
select trim('   india   ')
select replace('india is a country', 'india', 'UK')
select ascii('a')
select replicate('india',10)
select substring('india is a country',1,5) 
select reverse('india'), len('india')

4.  date time functions 

select * from student2

select getdate()

select day(getdate()), month(getdate()), year(getdate())

select dateadd(month, 2, getdate())
select dateadd(year, 2, getdate())
select dateadd(day, 2, getdate())

select dateadd(month, 2, '2/3/2023')   mm/dd/yyyy
select dateadd(year, 2, '3/2/2023')
select dateadd(day, 2, '2023/4/5')

select dateadd(month, 2, doj)   from student2
select dateadd(year, 2,doj )from student2
select dateadd(day, 2, doj)from student2

select datediff(year, '2/3/2023', '7/6/2023') as 'Datediff-year'
select datediff(month, '2/3/2023', '7/6/2023') 'Datediff-month'
select datediff(day, '2/3/2023', '7/6/2023') 'Datediff-day'

select datepart(year,'2/3/2022')
select datepart(month,'2/3/2022')
select datepart(day,'2/3/2022')

select isdate('2/3/2023')           -- 0 if date format is wrong
                                    -- 1 if date format is correct 
============================================================================

clauses : 

1. where : logical operators

select * from customer where custid <13
select * from customer where custid >=13
select * from customer where custid <=13
select * from customer where custid >13

select * from customer where custid <13 and custname='sunita'
select * from customer where custid <13 or custname='sunita'
select * from customer where custid !=13 or custname!='sunita'

2. order by 

select * from customer order by custid asc /desc

3. group by
4. distinct
   select distinct(custid), custname from customer

5. between 
select * from customer where custid between 11 and 15
logical operators 

6. top
select top 5 custid from customer 
select top 5 * from customer 

7. like
_ single character 
% group / collection of characters  

select * from customer where custname like 'a%'
select * from customer where custname like '%a'
select * from customer where custname like '_____a'
select * from customer where custname like 'ka___a' 

logical operators --check , and, or, not 

select * from employee where empname  NOT like 'q%'select * from employee where empname  like 'q%' AND empname  like 'N%'select * from employee where empname  like 'q%' OR empname  like 'N%'

8. in
select * from customer where custid in(10,11,12)
select * from customer where custid in(select custid from customer where custname='anita')


9. any
select * from customer where custid < any
(select custid from customer where custname='anita')  

 (101,104)

10. all
select * from customer where custid <=
all(select custid from customer where custname='anita')

11. not 

12. null 
select * from customer c left join product p
on c.custid = p.custid where productid is  null

select * from customer c left join product p
on c.custid = p.custid where productid is not  null

select empcity from employee where empid < any
(select empid from employee where empname ='qcdef' 
OR empname='qwer' OR empname='qazwsk')
========================================

Sub query : 
 query within a query
  outer query (inner query) 

  JOins : 

select * from customer

select * from product

1. Left join / left outer join :

select * from customer c left join product p
on c.custid = p.custid 

select * from customer c left join product p
on c.custid = p.custid 
where p.productid is not null

2.  Right join / right outer join :

select * from customer c right join product p
on c.custid = p.custid 

select * from customer c right join product p
on c.custid = p.custid 
where c.custid is not null

3.  full join / full outer join :

select * from customer c full join product p
on c.custid = p.custid 

select * from customer c full join product p
on c.custid = p.custid 
where p.productid is not null

4. inner join 
select * from customer c inner join product p
on c.custid = p.custid 

5. self join :

select c1.custid, c2.custid, c1.custname, c2.custname 
from customer c1, customer c2
where c1.custid >c2.custid

==========================================

select * from customer c, product r, person p
where c.custid=r.productid or c.custid=p.id

select * from customer c, product r, person p
where c.custid=p.id

select * from customer c, product r inner join person p 
on c.custid=r.productid and c.custid=p.id

==========================================================

Stored procedures : 

alter proc procedure1
as
begin
    select * from customer
	select * from customer where custid >101
end

exec procedure1

// create stored procedure for inserting a record in a table
// create stored procedure for delete a record in a table
// create stored procedure for update a record in a table

create procedure customerinsertasbegin insert into customer (CustId,Name,City) values(5,'Shiv','Delhi');end
-------------------------------
create proc dell_procasbegin 	insert into Subjects values( 6, 'Java',4)	delete from Subjects where subjectid=3	update subjects set name='Dotnet' where subjectid=1end

create procedure customerUpdateasbegin update customer set Name='Siva' where CustId=5;end

=========================================================
stored procedures with parameters ; 


create proc  delproc
(@id int)
as
begin
   delete from customer where custid =@id
end

exec delproc 11

select * from customer

insertion and updation with parameters 
=============================================================
create proc customerinsertion(@id int,@name varchar(100),@city varchar(100))asbegin insert into customer (CustId,Name,City) values(@id,@name,@city);end===============================create procedure customerUpdation(@id int,@name varchar(100),@city varchar(100))asbegin update customer set Name=@name, City=@city where CustId=@id;end=====================================================create proc wheredemo(@id int)asbegin   select * from customer where custid=@idend========================================================create stored procedure for sorting records of customer tablein ascending ordercreate stored procedure for sorting records of customer tablein descending order===============================================================Create a stored procedure to store a table vehicle and add the columns vehicleid, vehiclename, vehicle_coloralter proc studentprocas begincreate table customer (customer_id int,customer_name varchar(50),customer_address varchar(50))endDDL  -- once ==============================================================SELECT name, database_id, create_date  
FROM sys.databases; =================================================================sp_helptext delprocdrop proc delproc=====================================================================create proc generalprocasbegin   select getdate()   select month(getdate())endexec generalproc==========================================================create a view : CREATE VIEW CUSTOMERS_VIEW 
AS 
        SELECT custid, custname FROM  CUSTOMER

------------------------------------------------------
execute the view : 


select * from CUSTOMERS_VIEW

drop view CUSTOMERS_VIEW

===============================================================
create views : 
   insert, delete , update ????

Views with DDL   ?
===============================================================

CREATE VIEW CUSTOMERS_VIEW1 
AS
    SELECT custname, custcity FROM  CUSTOMER WHERE custid IS NOT NULL
    WITH CHECK OPTION;


select * from CUSTOMERS_VIEW1

update CUSTOMERS_VIEW1 set custcity='Pune' where custname='anita'
==============================================================
create view vw_testASselect * from Subjects where Classid is not nullwith check option=======================================================insert into vw_test(subjectid, name, classid)values(9,'ORACLE',5)delete from vw_test where subjectid=9

DROP VIEW CUSTOMERS_VIEW;

========================================

drop database
drop table
drop view
drop stored procedure
===============================================

scalar valued functions : 

select * from customer

CREATE FUNCTION GetCustomer(@cid INT)  
 RETURNS VARCHAR(50)  
 AS  
BEGIN  
    RETURN (SELECT custname FROM customer WHERE custid=@cid)  
END 

print dbo.GetCustomer(101)

select * from customer 
=======================================================================
Create function : where custid =102 and custname is "harshit".
=================================================================

select * from customer


alter FUNCTION GetCustomerName(@ccity varchar(50))  
 RETURNS VARCHAR(50)  
 AS  
BEGIN  
    RETURN (SELECT custname FROM customer WHERE custcity=@ccity)  
END 

print dbo.GetCustomerName('Pune')
=====================================================

table valued functions : 

alter FUNCTION GetAllCustomers(@pattern varchar(5))  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM customer WHERE custcity like @pattern


SELECT * FROM GetAllCustomers('P%') 
=======================================================================
create FUNCTION GetAllCustomers1()
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM customer


select * from dbo.GetAllCustomers1()