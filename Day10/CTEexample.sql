WITH CTE_1
AS
(
    SELECT SalesPersonID, COUNT(*) as NumberOfOrders ,
	MAX(OrderDate) as MaxDate
    FROM Sales.SalesOrderHeader
    GROUP BY SalesPersonID
),  
CTE_2
AS
(
    SELECT SalesPersonID, NumberOfOrders, MaxDate
    FROM CTE_1 
    WHERE NumberOfOrders  < 200 
)



SELECT top 10 CTE_1.*, CTE_2.* 
FROM CTE_1 LEFT JOIN CTE_2
	ON CTE_1.SalesPersonID= CTE_2.SalesPersonID
