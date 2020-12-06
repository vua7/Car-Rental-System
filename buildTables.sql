use GROUP5291;

begin try
	drop table Customers;
	drop table Rental_trans;
	drop table Cars;
	drop table Car_types;
	drop table Employees;
	drop table Branches;
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
	phone_number varchar(30));

create table Car_types (
	CarType varchar(30) primary key,
	price_D int,
	price_W int,
	price_M int);

create table Branches (
	Branch_ID int primary key,
	street_name varchar(30),
	street_number int,
	city varchar(30),
	province varchar(30),
	zip varchar(7),
	phone_number varchar(30));

create table Cars (
	VIN varchar(17) primary key,
	Color varchar(20),
	Model varchar(30),
	CarType varchar(30) foreign key references Car_types(CarType),
	Branch_ID int foreign key references Branches(Branch_ID)
);

create table Employees (
	Employee_ID int primary key,
	first_name varchar(30),
	middle_initial varchar(2),
	last_name varchar(30),
	street_name varchar(30),
	street_number int,
	city varchar(30),
	province varchar(30),
	zip varchar(7),
	phone_number varchar(30),
	Branch_ID int foreign key references Branches(Branch_ID)
);

create table Rental_trans (
	Rental_ID int primary key,
	pickup_date varchar(30),
	return_date varchar(30),
	price int,
	Customer_ID int,
	Employee_ID int,
	pickup_Branch_ID int foreign key references Branches(Branch_ID),
	return_Branch_ID int foreign key references Branches(Branch_ID),
	VIN varchar(17) foreign key references Cars(VIN)
);

insert into Customers values(1, 'John', 'Hancock', 123456789, 12345, 'newStreet', 15, 0, 'Edmonton', 'Alberta', 'A1B 2C3', '1234567890');
insert into Car_types values('Sedan', 100, 100, 100);
insert into Branches values(1, 'St. Albert Trail', 140, 'Edmonton', 'AB', 'T6A 3M9', '7805555555');
insert into Cars values('S9G7H1KJY7H508JN7', 'red', 'Pontiac Sunfire', 'Sedan', 1);
insert into Employees values(1, 'Joe', 'O','Bloe', 'Cherry St.', '69', 'Saskatoon', 'Saskatchewan', 'K9R 4Y7', '5645558790', 1);
insert into Rental_trans values(1234, '2020-11-29', '2020-12-01', 300, 1, 1, 1, 1, 'S9G7H1KJY7H508JN7');