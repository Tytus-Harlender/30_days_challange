WITH recursive_CTE
AS
(       
	select EmployeeId, ReportsTo, FirstName, LastName, 0 as Organization_Level 
        from dbo.Employees
	where ReportsTo is null
 
	UNION ALL
 
	select e.EmployeeId, e.ReportsTo, e.FirstName, e.LastName, Organization_Level + 1
	from dbo.Employees e inner join recursive_CTE r on e.ReportsTo = r.EmployeeId
)
Select * from recursive_CTE
option (maxrecursion 1)
