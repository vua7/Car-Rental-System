use GROUP5291;

begin try
	drop table Customers;
end try
begin catch
end catch

create table Customers (
CustomerID int primary key,
first_name varchar(30),
last_name varchar(30),
driving_license int,
membership int,
street_name varchar(50),
street_number int,
apt_number int,
city varchar(20),
province varchar(20),
zip varchar(7),
phone_number int);

insert into Customers values(1, 'John', 'Hancock', 123456789, 12345, 'newStreet', 15, 0, 'Edmonton', 'Alberta', 'A1B 2C3', 1234567890);