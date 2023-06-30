
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

select * from product