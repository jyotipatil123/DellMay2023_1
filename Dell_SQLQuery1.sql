
create database Dell

use dell

types : 
1.  DDL    Data Definition Language 
      create database 
	  create table
	  alter table
	  truncate table
	  drop table 

create table mytable(id int, name varchar(50))

SQL : int, numeric(18,0) , decimal, money, geography, xml, varchar , nvarchar, 
      date, time, datetime, datetimeoffset, datetime2..........

2.  DML    Data Manipulation Language
1. insertion : 
    insert into mytable(id, name) values(10,'anita')
	insert into mytable(id, name) values(11,'avinash'),(12,'karuna'),(13,'akash')

	select * from mytable
2. deletion : 
    delete from mytable where id=10
	delete from mytable                      -- all the records are removed 
	delete from mytable where id=10 and name='anita'
3. updation 
    update mytable set name='Lalita' where id=11

3.  DCL    Data Control Language

Operators : 
 arithemetic operators        +  -  *  /  mod
 relational                  <   >  <=  >=  <>  !=
 logical                    and , or , not 
 assignment                 =

 where clause : 
 select * from mytable where id<15

 select distinct id, name from mytable where id<15

 ====================================================================
 declare @num1 int =10
 print @num1
 =====================================================================

 declare @a int =10
 declare @b int =20
 
 print 'Addition result is : '
 print (@a+@b)
 print 'Subtraction result is : '
 print (@a-@b)
 print 'Multiplication result is : '
 print (@a*@b)
 print 'Division result is : '
 print (@a/@b)
 ===================================================
 Logical operators : 

 select * from mytable where id=11 and name='avinash'
 select * from mytable where id=10 or name='avinash'
 select * from mytable where id!=10 

 print @a

 create student table --studid, name, city

 insert 2 records

 delete 1 record
 
 update 1 record

 order by :
    select * from mytable order by name
	select * from mytable order by name asc 

	select * from mytable order by name desc

	select * from mytable order by name asc, id asc

set operations :

1.  union and union all

select custcity from customer union select city from employee

select custcity from customer union all select city from employee

select * from customer union select * from employee

select * from customer union all select * from employee

select custid from customer
intersect
select empid from employee

select * from customer
minus
select * from employee
//===================================================================================

while loop :

declare @i int=10;

while(@i <=30)
begin
      print @i
	  set @i=@i+10
end

--Program : to print all even numbers from 50 to 100
--Program : to print all odd numbers from 1 to 50

while loop with break : 

declare @i int=10;

while(@i <=30)
begin
      print @i
	  set @i=@i+10

     if @i=30  break;
end
----------------------------------------------------------------

while loop with continue : 

declare @i int=10;

while(@i <= 30)
begin
    
	  set @i=@i+10
	  print @i

     if @i=10  continue;
end


------------------------------------------------

declare @x int=50;print 'even numbers:  'while(@x<=100)begin       print @x      set @x=@x+2end

-------------------------------------
Nested while loop example : 

declare @i int=10, @j int=1

while @i<=30
  begin
     print concat('i=',@i)

	 while(@j <=3)
	 begin
	    print concat('j=', @j)
		set @j= @j+1
	 end
	 set @i=@i+10
  end

  ===============================================

  if statement : 

  declare @mysalary int =10000, @stdsalary int =5000

  if (@mysalary > @stdsalary)
      print 'my salary is greater than standard salary'
  else
      print 'my salary is less'

=============================================================

  declare @mysalary int =10000, @stdsalary int =5000

  if ((select avg(salary) from employee )> @stdsalary)
      print 'my salary is greater than standard salary'
  else
      print 'my salary is less'
================================================================

Nested if : 

declare @studmarks int =95

if(@studmarks > 65)
  begin
     if @studmarks >75
	     print 'Grade A+'
     else
	     print 'Grade A'
  end 
else
   print 'Below the grade'

==================================================

declare @totalmarks int

set @totalmarks=49

if @totalmarks >=50
   goto pass
else
   goto fail

pass: 
       print 'congrats'
	   return
fail: 
       print 'failed'
	   return
go
=======================================================
declare @k int;
set @k=0

while @k<=10
begin
    if @k=11
	   goto label1

	   set @k= @k+1
	   print @k
end 

label1:
    print 'welcome'
==================================================================

Keys 
1. primary key   --- unique, not null 
                     PK must --1 column or combination of more than one column
2. foreign key     first table, second table
                   
customer 
custid  name  city
.............
...........

order
orderid   qty  custid
.............
.......
			
3. candidate key   combinations of pK
4. unique key      1 set of info
5. alternate key   left out combination keys 

Normalization 
1NF...........


constraints :
1. primary key constraint : 

create table person
(  
   id int, 
   name varchar(50),
   city varchar(50),
   primary key(id)
)

insert into person(id,name,city) values(11,'monica','mysore')

select * from person

2.  foreign key

create table order1
(
  orderid int primary key,
  quantity int, 
  id int, 
  foreign key(id) references person1(id)
)

3.  not null

create table person1
(  
   id int not null, 
   name varchar(50) not null,
   city varchar(50) not null,
   primary key(id)
)

insert into person1(id,name,city) values(11,'monica','')

4.  check constraint : 

create table person2
(
   id int, 
   name varchar(50),
   age int,
   check (age>=18)
)

insert into person2(id, name, age) values(10,'aaa',22)

select * from person2

5.  unique 
by default PK is unique  ---no duplicate records 

create table person4
(
  id int not null unique, 
  name varchar(50),
  city varchar(50),
  foreign key(id) references person1(id)
)

insert into person3(id,name,city) values (100, 'kavita', 'delhi')

create table person5
(
  id int unique, 
  name varchar(50),
  city varchar(50)
)
insert into person5(id,name,city) values(null,'aa','gujrat')

select * from person5


select * from person3

6.  default 
create table person6
(
   id int, 
   name varchar(50),
   city varchar(50) default 'Delhi'
)

insert into person6 values(100,'anita','Kanpur')
insert into person6 values(100,'anita')

select * from person6


alter table -----

select * from customer
alter table customer
     alter column custid primary key int 

ALTER TABLE customer   alter  not null custid;

delete from customer where custid=103

ALTER TABLE DEPT ADD CONSTRAINT PK_DEPT PRIMARY KEY (DEPTNO)

--------------primary key for the exsiting table -----------------
-- make the column as not null first
ALTER TABLE customer  ALTER COLUMN  custid int NOT NULL;

-- add the column as primary key
ALTER TABLE customer ADD PRIMARY KEY (custid);

=================================================================

clauses : asdfasdfasdfasdfasdasdasdasfdasfdasds































