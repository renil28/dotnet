--SQL Challenges-1: Exercise-2 with Solution
--From the following table, write a SQL query to find the third highest sale. Return sale amount.
CREATE TABLE salemast(sale_id int, employee_id int, sale_date date, sale_amt int);
TRUNCATE TABLE salemast;
INSERT INTO salemast (sale_id, employee_id, sale_date, sale_amt) VALUES ('1', '1000', '2012-03-08', 4500);
INSERT INTO salemast (sale_id, employee_id, sale_date, sale_amt) VALUES ('2', '1001', '2012-03-09', 5500);
INSERT INTO salemast (sale_id, employee_id, sale_date, sale_amt) VALUES ('3', '1003', '2012-04-10', 3500); 
INSERT INTO salemast (sale_id, employee_id, sale_date, sale_amt) VALUES ('3', '1003', '2012-04-10', 2500); 

SELECT  * FROM salemast;
SELECT top 1 * from (select top 3  sale_id, sale_amt FROM salemast order by sale_amt desc) salemast order by sale_amt asc;

--From the following table, write a SQL query to find the Nth highest sale. Return sale amount.
SELECT top 1 * from (select top 2 sale_id, sale_amt FROM salemast order by sale_amt desc) salemast order by sale_amt asc;