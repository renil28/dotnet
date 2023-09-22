--From the following tables, write a SQL query to find the information on each salesperson of ABC Company.
--Return name, city, country and state of each salesperson.

Create database MyDB2;
use MyDB2;

CREATE TABLE salespersons(salesperson_id int, first_name varchar(255), last_name varchar(255));
CREATE TABLE  address(address_id int, salesperson_id  int, city varchar(255), state varchar(255), country varchar(255));
TRUNCATE TABLE address;
INSERT INTO salespersons (salesperson_id, first_name, last_name) VALUES ('1', 'Green', 'Wright');
INSERT INTO salespersons (salesperson_id, first_name, last_name) VALUES ('2', 'Jones', 'Collins');
INSERT INTO salespersons (salesperson_id, first_name, last_name) VALUES ('3', 'Bryant', 'Davis');

TRUNCATE TABLE address;
INSERT INTO address (address_id, salesperson_id, city, state, country) VALUES ('1', '2', 'Los Angeles','California', 'USA');
INSERT INTO address (address_id, salesperson_id, city, state, country) VALUES ('2', '3', 'Denver', 'Colorado','USA');
INSERT INTO address (address_id, salesperson_id, city, state, country) VALUES ('3', '4', 'Atlanta', 'Georgia','USA');

select * from address;
select * from salespersons;

select(emp.first_name +' ' + emp.last_name) as Name, ad.city, ad.state, ad.country from salespersons emp inner join address ad on emp.salesperson_id = ad.salesperson_id;