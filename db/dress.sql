drop database RentDressManagement
create database RentDressManagement;
GO
use RentDressManagement;

DROP TABLE Employee;
DROP TABLE Customer;
DROP TABLE Dress;
DROP TABLE [Order];
DROP TABLE OrderLine;
DROP TABLE Stock;
DROP TABLE Payment;

select *from stock
select *from employee
select *from dress
select * from Customer
create table employee 
(
	EmployeeID INT IDENTITY(1,1) NOT NULL,
	EmployeeName varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Role varchar(20) NOT NULL,
	Status varchar(20) NOT NULL,
	Primary key (EmployeeID)
) 
insert into employee vlaues ('',)
insert into employee values ('Nguyen Van A','123456','admin','work ')
select *from employee;
create table customer 
(
	CustomerID INT IDENTITY(1,1) NOT NULL,
	CustomerName varchar(50) NOT NULL,
	PhoneNumber varchar(10) unique not null,
	Email varchar(100),
	[Address] varchar(100) NOT NULL,
	Primary key (CustomerID)
)
select *from customer;

insert into customer values ('Ha','9713271348','ha@gmail.com','91 le van tam, quan 5, tp HCM')
select *from dress

create table dress
(
	DressID INT IDENTITY(1,1) NOT NULL,
	DressName varchar(50) NOT NULL,
	DressDecription varchar(200),
	Price float  NOT NULL,
	Primary key (DressID)
)
select *from Dress
create table [Order]
(
	OrderID INT IDENTITY(1,1) NOT NULL,
	CustomerID INT NOT NULL,
	EmployeeID INT NOT NULL,
	OrderDate datetime NOT NULL,
	Total int
	Primary key (OrderID)
)
 
create table OrderLine
(
	OrderID INT NOT NULL,
	DressID INT NOT NULL,
	Quantity int  NOT NULL,
	[Sum] int  NOT NULL,
	Primary key (OrderID,DressID)
)


create table Stock 
(
	StockID INT IDENTITY(1,1) NOT NULL,
	DressID INT NOT NULL,
	DressQuant int NOT NULL,
	ImportDate datetime NOT NULL,
	Primary key (StockID)
)

create table Payment
(
	PaymentID INT IDENTITY(1,1) NOT NULL,
	OrderID INT NOT NULL,
	EmployeeID INT NOT NULL,
	Amount int NOT NULL,
	Change int NOT NULL,
	PaymentDate datetime NOT NULL,
	Primary key (PaymentID)
)

 ALTER TABLE [Order] ADD CONSTRAINT FK_ORDER_CUSTOMER FOREIGN KEY (customerID) REFERENCES Customer(CustomerID);
 ALTER TABLE [Order] ADD CONSTRAINT FK_ORDER_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);
 
 ALTER TABLE OrderLine ADD CONSTRAINT FK_ORDERLINE_ORDER FOREIGN KEY (OrderID) REFERENCES [Order](OrderID);
 ALTER TABLE OrderLine ADD CONSTRAINT FK_ORDERLINE_DRESS FOREIGN KEY (DressID) REFERENCES Dress(DressID);
 
 ALTER TABLE Stock ADD CONSTRAINT FK_STOCK_DRESS FOREIGN KEY (DressID) REFERENCES Dress(DressID);
 
	ALTER TABLE Payment ADD CONSTRAINT FK_PAYMENT_ORDER FOREIGN KEY (OrderID) REFERENCES [Order](OrderID);
 ALTER TABLE Payment ADD CONSTRAINT FK_PAYMENT_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID);
 



drop trigger OrdLineSum
go
create trigger OrdLineSum
on OrderLine
for insert,update
as
BEGIN
	declare @quant int,@sum int, @dressID int, @unitPrice int
	select @quant = Quantity, @dressID = DressID from inserted
	select @unitPrice = Price from dress where @dressID = DressID
	set @sum = @quant*@unitPrice
	update OrderLine set [Sum] = @sum
	where @dressID = DressID
END


