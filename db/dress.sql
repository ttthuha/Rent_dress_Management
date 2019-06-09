drop database RentDressManagement
create database RentDressManagement;
GO
use RentDressManagement;

select *from employee
DROP TABLE Employee;
DROP TABLE Customer;
DROP TABLE Dress;
DROP TABLE [Order];
DROP TABLE OrderLine;
DROP TABLE Stock;
DROP TABLE Payment;

select *from stock
select *from employee
select *from dress;
select * from Customer
select * from [Order]
select *from OrderLine

create table employee 
(
	EmployeeID INT IDENTITY(1,1) NOT NULL,
	EmployeeName varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Status varchar(20) NOT NULL,
	IsAdmain varchar(20) NOT NULL,
	Primary key (EmployeeID)
) 

create table customer 
(
	CustomerID INT IDENTITY(1,1) NOT NULL,
	CustomerName varchar(50) NOT NULL,
	PhoneNumber varchar(10) unique not null,
	Email varchar(100),
	[Address] varchar(100) NOT NULL,
	Primary key (CustomerID)
)

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
	[Sum] float  NOT NULL,
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
	Amount float NOT NULL,
	Change float NOT NULL,
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


SELECT        [Order].CustomerID, SUM(OrderLine.Sum) AS Total
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID
WHERE        ([Order].CustomerID = 1)
GROUP BY [Order].CustomerID;


SELECT        [Order].CustomerID AS [CUSTOMER ID],[Order].OrderID AS [ORDER ID], dress.DressName AS [Dress Name], dress.DressDecription AS [Dress Decription], dress.Price, OrderLine.Quantity, OrderLine.Quantity * dress.Price AS Total
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID
WHERE        ( [Order].CustomerID = 1)

SELECT        [Order].CustomerID AS [CUSTOMER ID],[Order].OrderID, dress.DressName AS [Dress Name], dress.DressDecription AS [Dress Decription], dress.Price, OrderLine.Quantity, OrderLine.Quantity * dress.Price AS Total,
				[Order].OrderDate as [OrderDate]
FROM            [Order] INNER JOIN
                         OrderLine ON [Order].OrderID = OrderLine.OrderID INNER JOIN
                         dress ON OrderLine.DressID = dress.DressID

order BY  [Order].CustomerID 