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


3.	Database index

Index in database is a way to search through the data more efficiently by reducing the time needed for retrieving information. The idea is based on dividing the dataset into smaller groups following some common features (these ‘groups’ are called ‘fields’). We use ‘keys’ to group the data (recall Dictionary<Key,T> collection ). Then each group is again divided and so we proceed in creating smaller and smaller parts of data. By doing so we create a hierarchy which is easier searched as we may move directly to the needed node in the structure. Creating these hierarchy is called ‘indexing’.

The most common structure to use is B+ Tree. It has equal and even distribution of data. Moreover, the number of lookups is directly related to the height of the tree, so it is crucial to ensure all the branches are of equal height.  This spreads out the data across the entire tree, making it more efficient to look up data within any range.

Why and when to use it?

Although creating index for DB costs us additional memory usage (ca. 30% more then the indexed DB), it rapidly increases the speed of DB search. As we use binary search on created structure rather than a dataset itself we may quickly move directly to the field we are interested in omitting the other fields. Since indices are only used to speed up the searching for a matching field within the records, it stands to reason that indexing fields used only for output would be simply a waste of disk space and processing time when doing an insert or delete operation, and thus should be avoided. Also given the nature of a binary search, the cardinality or uniqueness of the data is important. Indexing on a field with a cardinality of 2 would split the data in half, whereas a cardinality of 1,000 would return approximately 1,000 records. With such a low cardinality the effectiveness is reduced to a linear sort, and the query optimizer will avoid using the index if the cardinality is less than 30% of the record number, effectively making the index a waste of space.

Cardinality in DB – (one of two meanings: A lot of distinct values in a table is high cardinality; a lot of repeated values is low cardinality)

Source:
https://www.essentialsql.com/what-is-a-database-index/
https://stackoverflow.com/questions/1108/how-does-database-indexing-work
https://orangematter.solarwinds.com/2020/01/05/what-is-cardinality-in-a-database/

4.	Execution plan in Database


Execution plans are a very important indicator for optimizing query performance. Before the database can execute an SQL statement, the optimizer has to create an execution plan for it. The database then executes this plan in a step-by-step manner. In this respect, the optimizer is very similar to a compiler because it translates the source code (SQL statement) into an executable program (execution plan).

The execution plan is the first place to look when searching for the cause of slow statements. There are different ways to get into execution plan of a DB. In SQL to get the execution plan we put ‘EXPLAIN’ keyword in front of the statement: 
EXPLAIN SELECT 1
There are two ways a execution plan may be shown – Text and Graphical ones. As an output we would get the plan in tab form. Execution plan shows us for example where are the missing indices which need to be created to improve efficiency. Then we may perform different operations on the plan and improve it. 
Most common steps for improvement are:

    -Productive indexes
    -Optimal table joining order
    -Hints for SQL query optimizer
    -Statistics

Query optimizer uses statistics to create execution plans. Statistics for SQL query optimization are objects with statistical information regarding the distribution of values inside an indexed view or columns of the table. If statistics is formed for an index or a table, then query optimizer can find the optimal execution plan faster. You can form your own statistics or edit existing ones to help optimizer.


Source:
https://use-the-index-luke.com/sql/explain-plan
https://www.apriorit.com/dev-blog/381-sql-query-optimization

