#Day10


1.	Common table expressions in SQL (CTE)
2.	Database normal forms (NF)
3.	Database index
4.	Execution in Database

1.	Common table expressions (CTE)

CTE are a concept used in SQL. It’s main idea is to create expressions with SQL syntax defining custom tables which may later be used in code.
An example of CTE is shown within CTEexample.sql file. A CTF expression prepares a table that consists of the data from several different tables. By doing so we simplify the data access which is later fulfilled in the query. We begin the CTE definition with ‘WITH’ keyword. It is a good pattern to end each SQL commend with ‘;’ sign, so that the parser will not interpret ‘WITH’ keyword as a hint keyword for the previous command. 

We may use recursive CTE for recurrence. If we have a collection with defined hierarchy, recursive CTE lets use create trees and graphs. Recursive CTE consists of 3 parts:
•	an anchor member (initial query that returns the base result set of the CTE)
•	recursive member (recursive query that creates results based on the previous query higher in hierarchy - anchor member or another recursive member)
•	A termination condition specified in the recursive member that terminates the execution of the recursive member

In file RecursiveCTEexample we may see example of such CTE. ‘UNION ALL’ is used to summon all anchor and recursive member results into one. ‘MAXRECURSION’ keyword defines after which iteration should the loop of recursion be broken (if it will not be defined 32767 is the number of maximum iteration)

When to use them?

If we have a lot of different tables and we want to use a query on all of them, we may use CTE to make it more concise. Another situation may be complex queries with ‘SELECT’ usage (for example CASE WHEN) when we may want to proceed with the output by adding it to the query internally. 

Secondly, for recurrence which we may be provided with by CTE.


Source:
https://www.sqlpedia.pl/cte-common-table-expressions/

2.	Database normal forms (NF)

Relational database is a database based on tables and relations of the data among them. Such ‘relations’ may be described as common subsets (columns) of some sets of data (tables). In such database the language used is SQL.

Both ‘normalization’ and ‘normal forms’ refers to the structure of a database. Normalization of a relational database is a process of restructing it in accordance to rules called ‘normal forms’ which are design patterns. This reduces redundancy as well as dependency of data and improves it’s integrity (for example: If some piece of data is duplicated several places in the database, there is the risk that it is updated in one place but not the other, leading to data corruption).

Normalization split a large table into smaller tables and define relationships between them to increases the clarity in organizing data.

We distinguish 5 following normal forms (NF) each describes how to get rid of some specific problem:
•	1NF - each column is unique (split the rows)
•	2NF (most common) – repetition of a value in next rows with more than one parameter is avoided (split the table into two and creating a key relation between them)
•	3NF (usually condition for considering a table as normalized) The entity should be considered already in 2NF, and no column entry should be dependent on any other entry (value) other than the key for the table. If such an entity exists, move it outside into a new table. It is called ‘Transitive Dependency’
•	4NF (rare)
•	5NF(rare)

Source:
https://www.w3schools.in/dbms/database-normalization/
https://stackoverflow.com/questions/246701/what-is-normalisation-or-normalization
https://www.studytonight.com/dbms/third-normal-form.php
