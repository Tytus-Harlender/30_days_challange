Source: https://www.w3resource.com/sql-exercises/?fbclid=IwAR1KJMaU4mV7I40lfLhMWB6boT8F7qliBa9PtEwAe1YVCfEO5mr_jafJtdc



Retrive data from tables



Task1
SELECT * FROM salesman
Task2
SELECT 'This is SQL Exercise, Practice and Solution';
Task3
??
Task4 (ok)
SELECT 8+36;
Task5(ok)
SELECT  90*3-4;
Task6(ok)
SELECT name, commission FROM salesman
Task7(ok)
SELECT ord_date, salesman_id, ord_no, purch_amt FROM orders
Task8(ok)
SELECT DISTINCT salesman_id FROM orders
Task9
SELECT name, city  FROM salesman WHERE city='Paris'
Task10 (ok)
SELECT * FROM customer WHERE grade =200
Task11 (ok)
SELECT ord_no, ord_date, purch_amt FROM orders WHERE salesman_id =5001
Task12 (ok)
SELECT * FROM nobel_win WHERE year='1970'
Task13
SELECT WINNER FROM nobel_win WHERE year ='1971' and subject = 'Literature'
Task14(ok)
select year, subject FROM nobel_win WHERE winner = 'Dennis Gabor'
Task15(ok)
SELECT winner FROM nobel_win where subject = 'Physics' and year>='1950'
Task16
select year, subject, winner, country from nobel_win where subject = 'Chemistry' and year>=1965 and year<=1975
Task17(ok)
select * from nobel_win where category = 'Prime Minister' and year>=1972
Task18
select * from nobel_win where winner LIKE 'Louis%'
Task19 (good!)
select winner from nobel_win where subject ='Physics' and year = '1970' or subject ='Economics' and year = '1971'
Task20
select winner from nobel_win where year = 1970 AND subject NOT IN ('Physiology','Economics')
Task21
SELECT * FROM nobel_win WHERE (subject ='Physiology' AND year<1971) UNION (SELECT * FROM nobel_win WHERE (subject ='Peace' AND year>=1974));
Task22
SELECT * FROM nobel_win WHERE winner = 'Johannes Georg Bednorz'
Task23
SELECT * FROM nobel_win WHERE subject NOT LIKE 'P%' order by year DeSC, winner
Task24
SELECT *
FROM nobel_win
WHERE year=1970 
ORDER BY
 CASE
    WHEN subject IN ('Economics','Chemistry') THEN 1
    ELSE 0
 END ASC,
 subject,
 winner;

Task25 (ok)
select PRO_NAME from item_mast where PRO_PRICE>200 and PRO_PRICE<600
SELECT * FROM item_mast WHERE pro_price BETWEEN 200 AND 600;
Task26
SELECT AVG(pro_price) FROM item_mast WHERE pro_com=16;
Task27
select PRO_NAME, PRO_PRICE from item_mast
SELECT pro_name as "Item Name", pro_price AS "Price in Rs."  FROM item_mast;
Task28 (ok)
select PRO_NAME, PRO_PRICE from item_mast where PRO_PRICE>=250 order by PRO_PRICE DESC, PRO_NAME
Task29 (!)
select  avg(pro_price), PRO_COM from item_mast group by pro_com
Task30 (!)
select pro_name, pro_price from item_mast where pro_price = (SELECT MIN(pro_price) FROM item_mast);
Task31 (ok)
select distinct emp_lname from emp_details
Task32 (ok)
select * from emp_details where emp_lname = 'Snares'
Task33 (ok)
select * from emp_details where emp_dept = 57



Boolean and relational operators



Task1(ok)
select * from customer where grade >100
Task2 (ok)
select * from customer where grade >100 and city ='New York'
Task3 (ok)
select * from customer where grade>100 or city ='New York'
Task4 (ok)
select * from customer where grade<=100 or city ='New York'
select * from customer where city ='New York' or not grade>100
Task5
select * from customer where not (city = 'Nwe York' or  grade>100)
Task6 (!)
select * from orders where not(ord_date =  '2012-09-10' and salesman_id >5005 or purch_amt > 1000)
Task7 (ok)
select salesman_id, name, city, commission from salesman where commission <'0.12' and commission >'0.10'
Task8 (!)
SELECT * FROM  orders WHERE(purch_amt<200 or 
NOT(ord_date>='2012-02-10' AND customer_id<3009));
Task9
SELECT * FROM  orders WHERE 
NOT((ord_date>='2012-08-17' OR customer_id>3005) AND purch_amt<1000);
Task10 (!!)
SELECT ord_no,purch_amt, (100*purch_amt)/6000 AS "Achieved %", (100*(6000-purch_amt)/6000) AS "Unachieved %" FROM  orders 
WHERE (100*purch_amt)/6000>50;
Task11 (ok)
select * from emp_details where emp_lname = 'Dosni' or emp_lname = 'Mardy'
Task12 (ok)
select * from emp_details where emp_dept = '63' or emp_dept = '47'


Wildcard and Special operators


Task1 (ok)
select * from salesman where city ='Paris' or city ='Rome'
Task2	
select * from salesman where city IN ('Paris', 'Rome')
Task3
select salesman_id, name, city, commission from salesman where city not in('Paris', 'Rome')
Task4 (ok)
select * from customer where customer_id IN (3007, 3008 , 3009)
Task5	(!)
select * from salesman where commission BETWEEN 0.12 AND 0.14
Task6 (!)
SELECT * FROM orders WHERE (purch_amt BETWEEN 500 AND 4000) AND NOT purch_amt IN(948.50,1983.43);
Task7
SELECT * FROM salesman WHERE name BETWEEN 'A' and 'L';
Task8 (ok)
select * from salesman where name not between 'A'and'L'
Task9
select * from customer where cust_name like 'B%'
Task10 (ok)
select * from customer where cust_name like '%n'
Task11
select * from salesman where name like 'N__l%'
Task12 (?)
select col1 from testtable where col1 like '%/_%' escape '/'Task13
Task13
select col1 from testtable where col1 not like '%/_%' escape '/'
Task14 (ok)
select col1 from testtable where col1 like '%//%' escape '/'
Task15 (ok)
select col1 from testtable where col1 not like '%//%' escape '/'
Task16
select col1 from testtable where col1 like '%/_//%' escape '/'
Task17
select col1 from testtable where col1 not like '%/_//%' escape '/'

Task18
select col1 from testtable where col1 like '%/%%' escape '/'
Task19(ok)
select col1 from testtable where col1 not like '%/%%' escape '/'
Task20
select * from customer where grade is null
Task21
select * from customer where grade is not null
Task22 (ok)
select * from emp_details where emp_lname like 'D%'


Aggregate Functions



Task1
select sum(purch_amt) from orders
Task2(ok)
select avg(purch_amt) from orders
Task3
SELECT COUNT (DISTINCT salesman_id) FROM orders;
Task4(ok)
SELECT COUNT (DISTINCT cust_name) FROM customer;
SELECT COUNT(*) FROM customer;
Task5(ok)
SELECT count (*) FROM customer where grade is not null ;
SELECT COUNT (ALL grade) FROM customer;
Task6 (ok)
SELECT max (purch_amt) FROM orders;
Task7 (ok)
SELECT min (purch_amt) FROM orders;
Task8 (!)
SELECT city, max(grade) FROM customer GROUP BY city;
Task9 (ok)
SELECT customer_id, max(purch_amt) FROM orders GROUP BY customer_id;	
Task10 (!)
SELECT customer_id,ord_date,MAX(purch_amt) FROM orders GROUP BY customer_id,ord_date;
Task11
SELECT salesman_id, MAX(purch_amt) FROM orders where ord_date='2012-08-17'GROUP BY salesman_id;
Task12
SELECT customer_id,ord_date,MAX(purch_amt) FROM orders GROUP BY customer_id,ord_date HAVING MAX(purch_amt)>2000.00;
Task13 
select customer_id, ord_date, max(purch_amt) from orders group by customer_id, ord_date having max(purch_amt) between 2000 and 6000
Task14
select customer_id, ord_date, max(purch_amt) from orders group by customer_id, ord_date having max(purch_amt) in (2000,3000,5760,6000)
Task15 (ok)
select customer_id, max(purch_amt) from orders where customer_id between 3002 and 3007 group by customer_id
Task16 (ok)
select customer_id, max(purch_amt) from orders where customer_id between 3002 and 3007 group by customer_id having max(purch_amt)>'1000'
Task17 (ok)
select salesman_id, max(purch_amt)
from orders
where salesman_id between 5003 and 5008
group by salesman_id
Task18	(ok)
SELECT count (ord_no)
FROM orders
WHERE ord_date = '2012-08-17'
Task19 (ok)
SELECT count (salesman_id)
FROM salesman
WHERE city is not null
Task20 (?)
SELECT ord_date, salesman_id, count(*)
FROM orders
GROUP BY ord_date, salesman_id
Task21 (ok)
SELECT avg(pro_price) as "Average Price"
FROM item_mast
Task22 (ok)
SELECT count(pro_id)
FROM item_mast
where PRO_PRICE >=350
Task23 (ok)
SELECT pro_com as "identyfikator produktu",avg(pro_price) as "średnia cena"
FROM item_mast
group by pro_com
order by pro_com ascTask24
Task24 (ok)
SELECT sum(dpt_allotment)as "suma przydziału"
FROM emp_department
Task25 (ok)
SELECT emp_dept as "code of department", count(emp_idno) as "liczba pracowników"
FROM emp_details
GROUP BY emp_dept
order by emp_dept asc


Formatting Query Output



Task1 (ok)
SELECT commission*100 as "prowizja %",'%', salesman_id as "liczba pracowników", name, city
FROM salesman
Task2
SELECT 'Dnia', ord_date, 'było',count(ord_no), 'zamówień'
FROM orders
GROUP BY ord_date;
Task3 (ok)
SELECT *
FROM orders
ORDER BY ord_no asc
Task4 (ok)
SELECT *
FROM orders
ORDER BY ord_date desc
Task5 (ok)
SELECT *
FROM orders
ORDER BY ord_date asc, purch_amt desc
Task6 (ok)
SELECT *
FROM customer
ORDER BY customer_id asc
Task7
SELECT salesman_id,ord_date,MAX(purch_amt) 
FROM orders 
GROUP BY salesman_id,ord_date 
ORDER BY salesman_id,ord_date;
Task8 (ok)
SELECT cust_name,city,grade 
FROM customer 
ORDER BY grade desc
Task9 (!)
SELECT customer_id, count(distinct ord_no), max(purch_amt)
FROM orders
GROUP BY customer_id
ORDER BY count(distinct ord_no) DESC;
Task10
SELECT ord_date, max(purch_amt),max(purch_amt)*0.15
FROM orders
GROUP BY ord_date
ORDER BY ord_date


Query on Multiple Tables



Task1
SELECT customer.cust_name, salesman.name, salesman.city FROM salesman, customer where salesman.city = customer.city
Task2 (ok)
SELECT customer.cust_name, salesman.name
FROM salesman, customer
where salesman.salesman_id = customer.salesman_id
Task3 (!!!)
SELECT ord_no, cust_name, orders.customer_id, orders.salesman_id
FROM salesman, customer, orders
WHERE customer.city <> salesman.city
AND orders.customer_id = customer.customer_id
AND orders.salesman_id = salesman.salesman_id;
Task4
SELECT ord_no, orders.customer_id, cust_name
FROM customer, orders
WHERE orders.customer_id = customer.customer_id
Task5
SELECT customer.cust_name AS "Customer",
customer.grade AS "Grade"
FROM orders, salesman, customer
WHERE orders.customer_id = customer.customer_id
AND orders.salesman_id = salesman.salesman_id
AND salesman.city IS NOT NULL
AND customer.grade IS NOT NULL;
Task6 (ok)
SELECT cust_name, customer.city, customer.salesman_id, salesman.commission
FROM customer, salesman
WHERE customer.salesman_id = salesman.salesman_id
AND salesman.commission between .12 and .14
Task7 (ok)
SELECT ord_no, cust_name, salesman.commission, purch_amt*salesman.commission
FROM customer, salesman,orders
WHERE orders.customer_id = customer.customer_id
AND orders.salesman_id = salesman.salesman_id 
AND customer.grade >=200
Task8 (ok)
SELECT ord_date, cust_name
FROM customer t, orders h
WHERE h.customer_id = t.customer_id
AND h.ord_date = '2012-10-05'



