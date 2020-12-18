SQL JOINS


Task1(ok)
SELECT salesman.name, customer.name, salesman.city 
FROM salesman, customer
WHERE salesman.city = customer.city
Task2 (ok)
SELECT ord_no, purch_amt, cust_name, customer.city
FROM orders, customer
WHERE orders.purch_amt between 500 and 2000
AND orders.customer_id = customer.customer_id
Task3
SELECT a.cust_name AS "Customer Name", 
a.city, b.name AS "Salesman", b.commission 
FROM customer a 
INNER JOIN salesman b 
ON a.salesman_id=b.salesman_id;
Task4 (ok)
SELECT a.cust_name AS "Customer Name", 
a.city, b.name AS "Salesman", b.commission 
FROM customer a 
INNER JOIN salesman b 
ON a.salesman_id=b.salesman_id 
WHERE b.commission>.12;
Task5 (ok)
SELECT a.cust_name AS "Customer Name", 
a.city, b.name AS "Salesman", b.city,b.commission  
FROM customer a  
INNER JOIN salesman b  
ON a.salesman_id=b.salesman_id 
WHERE b.commission>.12 
AND a.city<>b.city;
Task6 (ok)
SELECT a.ord_no,a.ord_date,a.purch_amt,
b.cust_name AS "Customer Name", b.grade, 
c.name AS "Salesman", c.commission 
FROM orders a 
INNER JOIN customer b 
ON a.customer_id=b.customer_id 
INNER JOIN salesman c 
ON a.salesman_id=c.salesman_id;
Task7 (??)
SELECT * 
FROM orders 
NATURAL JOIN customer  
NATURAL JOIN salesman;

‘natural join’ 

Task8
SELECT a.cust_name,a.city,a.grade, 
b.name AS "Salesman",b.city 
FROM customer a 
LEFT JOIN salesman b 
ON a.salesman_id=b.salesman_id 
order by a.customer_id;
Task9
SELECT a.cust_name,a.city,a.grade, 
b.name AS "Salesman", b.city 
FROM customer a 
LEFT OUTER JOIN salesman b 
ON a.salesman_id=b.salesman_id 
WHERE a.grade<300 
ORDER BY a.customer_id;
Task10 (??)
SELECT a.cust_name,a.city, b.ord_no,
b.ord_date,b.purch_amt AS "Order Amount" 
FROM customer a 
LEFT OUTER JOIN orders b 
ON a.customer_id=b.customer_id 
order by b.ord_date;
Task11
SELECT a.cust_name,a.city, b.ord_no,
b.ord_date,b.purch_amt AS "Order Amount", 
c.name,c.commission 
FROM customer a 
LEFT OUTER JOIN orders b 
ON a.customer_id=b.customer_id 
LEFT OUTER JOIN salesman c 
ON c.salesman_id=b.salesman_id;
Task12
SELECT a.cust_name,a.city,a.grade, 
b.name AS "Salesman", b.city 
FROM customer a 
RIGHT OUTER JOIN salesman b 
ON b.salesman_id=a.salesman_id 
ORDER BY b.salesman_id;
Task13
SELECT a.cust_name,a.city,a.grade, 
b.name AS "Salesman", 
c.ord_no, c.ord_date, c.purch_amt 
FROM customer a 
RIGHT OUTER JOIN salesman b 
ON b.salesman_id=a.salesman_id 
RIGHT OUTER JOIN orders c 
ON c.customer_id=a.customer_id;
Task14
SELECT a.cust_name,a.city,a.grade, 
b.name AS "Salesman", 
c.ord_no, c.ord_date, c.purch_amt 
FROM customer a 
RIGHT OUTER JOIN salesman b 
ON b.salesman_id=a.salesman_id 
LEFT OUTER JOIN orders c 
ON c.customer_id=a.customer_id 
WHERE c.purch_amt>=2000 
AND a.grade IS NOT NULL;
Task15
SELECT a.cust_name,a.city, b.ord_no,
b.ord_date,b.purch_amt AS "Order Amount" 
FROM customer a 
FULL OUTER JOIN orders b 
ON a.customer_id=b.customer_id;
Task16
SELECT a.cust_name,a.city, b.ord_no,
b.ord_date,b.purch_amt AS "Order Amount" 
FROM customer a 
FULL OUTER JOIN orders b 
ON a.customer_id=b.customer_id 
WHERE a.grade IS NOT NULL;
Task17 (? Cartesian product, ‘cross join’)
SELECT * 
FROM salesman a 
CROSS JOIN customer b;
Task18 (ok)
SELECT * 
FROM salesman a 
CROSS JOIN customer b 
WHERE a.city IS NOT NULL;
Task19 (ok)
SELECT * 
FROM salesman a 
CROSS JOIN  customer b 
WHERE a.city IS NOT NULL 
AND b.grade IS NOT NULL;
Task20
SELECT * 
FROM salesman a 
CROSS JOIN customer b 
WHERE a.city IS NOT NULL 
AND b.grade IS NOT NULL 
AND  a.city<>b.city;
Task21
SELECT *
FROM item_mast 
INNER JOIN company_mast
ON item_mast.pro_com= company_mast.com_id;
Task22
SELECT item_mast.pro_name, pro_price, company_mast.com_name
FROM item_mast 
INNER JOIN company_mast
ON item_mast.pro_com = company_mast.com_id;
Task23
SELECT AVG(pro_price), company_mast.com_name
FROM item_mast INNER 
JOIN company_mast
ON item_mast.pro_com= company_mast.com_id
GROUP BY company_mast.com_name;
Task24
SELECT company_mast.com_name
FROM item_mast INNER 
JOIN company_mast
ON item_mast.pro_com= company_mast.com_id
GROUP BY company_mast.com_name
HAVING avg(item_mast.PRO_PRICE) >=350
Task25 (!!)
SELECT A.pro_name, A.pro_price, F.com_name
   FROM item_mast A INNER JOIN company_mast F
   ON A.pro_com = F.com_id
     AND A.pro_price =
     (
       SELECT MAX(A.pro_price)
         FROM item_mast A
         WHERE A.pro_com = F.com_id
     );
Task26
SELECT A.*, B.*
   FROM emp_details A INNER JOIN emp_department B
   ON A.EMP_DEPT = B.DPT_CODE
     
Task27 (ok)
SELECT A.dpt_name, A.dpt_allotment, B.emp_fname, B.emp_lname
   FROM emp_details B LEFT JOIN emp_department A
   ON A.dpt_code = B.emp_dept
     
Task28 (ok)
SELECT B.emp_fname, B.emp_lname
   FROM emp_details B INNER JOIN emp_department A
   ON A.dpt_code = B.emp_dept
AND A.dpt_allotment > 50000

Task29
SELECT A.dpt_name, count(b.emp_fname)
FROM emp_department A INNER JOIN emp_details B
   ON A.dpt_code = B.emp_dept
GROUP BY A.dpt_code
HAVING COUNT(B.emp_fname)> 2

SUBQUERIES

Task1
SELECT *
FROM Orders a
INNER JOIN Salesman b
ON a.salesman_id=b.salesman_id
AND b.name = 'Paul Adam'
Task2
SELECT *
FROM Orders a
INNER JOIN Salesman b
ON a.salesman_id=b.salesman_id
AND b.city = 'London'
[alternative way given in the example:]
SELECT *
FROM orders
WHERE salesman_id =
    (SELECT salesman_id 
     FROM salesman 
     WHERE city='London');
Task3
SELECT *
FROM orders
WHERE salesman_id =
    (SELECT DISTINCT salesman_id 
     FROM orders 
     WHERE customer_id =3007);
Task4
SELECT *
FROM orders
WHERE purch_amt >
    (SELECT avg(purch_amt) 
     FROM orders 
     WHERE ord_date ='10/10/2012');
Task5(ok)
SELECT *
FROM orders
WHERE salesman_id =
    (SELECT salesman_id 
     FROM Salesman
     WHERE city ='New York');
Task6(ok)
SELECT commission,
FROM Salesman
WHERE salesman_id =
    (SELECT salesman_id 
     FROM Customer
     WHERE city ='Paris');
Task7(ok)
SELECT *
FROM customer
WHERE customer_id =
    (SELECT salesman_id 
     FROM Salesman
     WHERE name ='Mc Lyon')-2001;
Task8 (ok)
SELECT *
FROM Customer
WHERE grade >
    (SELECT avg(grade) 
     FROM Customer
     WHERE city ='New York');
Task9
SELECT *
FROM Orders
WHERE salesman_id =
    (SELECT salesman_id 
     FROM salesman
     WHERE commission =
           (SELECT max(commission)
            FROM salesman));
Task10 (ok)

SELECT b.*, a.cust_name
FROM orders b, customer a
WHERE a.customer_id=b.customer_id
AND b.ord_date='2012-08-17';
[somehow doesn’t work:]
SELECT cust_name
FROM Customer
WHERE customer_id =
(SELECT customer_id
FROM Orders 
WHERE ord_date='2012-08-17')
Task11 
SELECT salesman_id,name 
FROM salesman a 
WHERE 1 < 
    (SELECT COUNT(*) 
     FROM customer 
     WHERE salesman_id=a.salesman_id);

Task12
SELECT * 
FROM orders a
WHERE purch_amt >
    (SELECT AVG(purch_amt) FROM orders b 
     WHERE b.customer_id = a.customer_id);

Task13
SELECT * 
FROM orders a
WHERE purch_amt >=
    (SELECT AVG(purch_amt) FROM orders b 
     WHERE b.customer_id = a.customer_id);

Task14 (ok!!)
SELECT sum(purch_amt) 
FROM orders a
GROUP BY ord_date
HAVING sum(purch_amt)>=1000+
    (SELECT max(purch_amt) FROM orders b 
     WHERE b.ord_date = a.ord_date);

Task15 (!)
SELECT customer_id,cust_name, city
FROM customer
WHERE EXISTS
   (SELECT *
    FROM customer 
    WHERE city='London');
Task16 (!!!!!)
SELECT * 
FROM salesman 
WHERE salesman_id IN (
   SELECT DISTINCT salesman_id 
   FROM customer a 
   WHERE EXISTS (
      SELECT * 
      FROM customer b 
      WHERE b.salesman_id=a.salesman_id 
      AND b.cust_name<>a.cust_name));
Task17 (!!!)
SELECT * 
FROM salesman 
WHERE salesman_id IN (
   SELECT DISTINCT salesman_id 
   FROM customer a 
   WHERE NOT EXISTS (
      SELECT * FROM customer b 
      WHERE a.salesman_id=b.salesman_id 
      AND a.cust_name<>b.cust_name));
Task18 (!!!)
SELECT * 
FROM salesman a 
WHERE EXISTS     
   (SELECT * FROM customer b     
    WHERE a.salesman_id=b.salesman_id     
	 AND 1<             
	     (SELECT COUNT (*)              
		  FROM orders             
		  WHERE orders.customer_id =            
		  b.customer_id));
Task19 (!!!)
SELECT *
FROM salesman 
WHERE city=ANY
    (SELECT city
     FROM customer);
Task20 (!!)
SELECT *
FROM salesman 
WHERE city IN
    (SELECT city
     FROM customer);
