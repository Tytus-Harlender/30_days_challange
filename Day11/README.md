#Day11

GUID vs ID – difference 
VARCHAR vs CHAR - difference
Datatypes in SQL
‘auto_increment’
SQL procedure store
Query realization improvement

1.	GUID vs ID

This is a comparison of different primary keys types in DB. Traditional ID is an integer which takes 4 bytes, whereas GUID (Globally Unique ID) takes 16 bytes. What for shall we use more memory-consuming keys? They are ‘unique’ even outside our DB (‘globally’ as stated) which means across every table, every database, every server there is no another key of the same specification.

When to use?

It allows an easy merging of records from different databases. You can generate IDs anywhere, instead of having to roundtrip to the database. On the other hand, it takes more memory, which may have serious performance and storage implications.

Source:
https://blog.codinghorror.com/primary-keys-ids-versus-guids/

2.	VARCHAR vs CHAR

They are both ‘Character and String’ data types in SQL. They are both declared with a length that indicates the maximum number of characters you want to store. However they differ in some points. The length of a ‘CHAR’ column is fixed to the length that you declare when you create the table. The length can be any value from 0 to 255. On the other hand, values in ‘VARCHAR’ columns are variable-length strings. The length can be specified as a value from 0 to 65,535.

When to use which?

It depends. If the content is a fixed size, we will get better performance with ‘char’type. However, if a given value is stored into the CHAR(4) and VARCHAR(4) columns, the values retrieved from the columns are not always the same because trailing spaces are removed from CHAR columns upon retrieval. If we want to keep our variable flexible, as the data may for example change in the future, we may use VARCHAR. However, it may lead to memory consumption changes as the size is not fixed (see second source for elaboration)

Source:
https://dev.mysql.com/doc/refman/5.7/en/char.html
https://stackoverflow.com/questions/1885630/whats-the-difference-between-varchar-and-char

3.	Datatypes in SQL

We may distinguish the following datatypes in SQL:

-Numeric data types such as int, tinyint, bigint, float, real etc.
-Date and Time data types such as Date, Time, Datetime etc.
-Character and String data types such as char, varchar, text etc.
-Unicode character string data types, for example nchar, nvarchar, ntext    -Binary data types such as binary, varbinary etc.
-Miscellaneous data types – clob, blob, xml, cursor, table etc.

Source:
https://www.journaldev.com/16774/sql-data-types

4.	‘auto_increment’

  The idea behind auto_increment feature in relational databases comes down to improve the queries realisation speed on the DB as well as not to mess with IDs of DB elements when adding several objects especially simultaniously. By default the starting value for incrementation is 1 and it iterates with adding 1 each step. After using AUTO_INCREMENT statement in syntax (accurate to MySQL DB) there is no need to define ID value. In other words, to insert a new record into the table, we will NOT have to specify a value for the "id" column (a unique value will be added automatically). It helps a lot with adding new records. The MS SQL Server uses the IDENTITY keyword to perform an auto-increment feature. 
  
source: 
https://www.w3schools.com/sql/sql_autoincrement.asp
https://chartio.com/resources/tutorials/how-to-define-an-auto-increment-primary-key-in-sql-server/ 



5.	SQL procedure store

Stored procedure is a saved piece of code, that can be latter reused. It helps you not to rewrite and rewrite the same piece of code all over again. You may also declare the input parameters you need, so that the stored procedure can act based on the parameter value(s) that is passed. The syntax for stored procedure declaration is as follows:

CREATE PROCEDURE procedure_name
AS
sql_statement
GO; 

To execute the created procedure use the following syntax:
EXEC procedure_name; 

source:https://www.w3schools.com/sql/sql_stored_procedures.asp


6.	Query realization improvement


