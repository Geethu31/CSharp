create database CompanyDB

use CompanyDB
--Create Table
create Table Employee(
EmployeeID int NOT NULL PRIMARY KEY,
FirstName varchar(50),
LastName varchar(50),
Salary decimal(10,2),
);
Alter table Employee
ADD Department varchar(50)

--Insert data into table
insert into Employee (EmployeeID,FirstName,LastName,Salary,Department)
values
(1,'John','Doe',50000,'HR'),
(2,'Jane','Smith',60000,'IT'),
(3,'David','Lee',55000,'Marketing')

--Select and Query Data

select * from Employee

Select FirstName,LastName,Salary, Department
FROM Employee
where Department ='IT' AND Salary>50000

select MAX(Salary) As MaxSalary FROM Employee

--Update Data in the table
UPDATE Employee
SET Salary = 55000
where FirstName = 'John'

UPDATE Employee
SET Department ='Marketing'
where FirstName ='Jane'

--Delete Data from a Table
delete from Employee
where FirstName = 'David' AND LastName = 'Lee'

delete from Employee
where Department ='Marketing'

select * from Employee

--Product Management
--Create Table
create Table Product(
ProductID int NOT NULL PRIMARY KEY,
ProductName varchar(50),
Category varchar(50),
Price decimal(10,2),
Stock int,
);

----Insert data into table
insert into Product(ProductID,ProductName,Category,Price,Stock)
values
(1,'Laptop','Electronics',1000,'50'),
(2,'Mouse','Electronics',20,'200'),
(3,'Keyboard','Electronics',30,'150'),
(4,'Printer','Electronics',150,'75')

----Descending order
SELECT * FROM Product 
ORDER BY price desc;

----Updating the price
Update Product
SET Price ='25'
where ProductName = 'Mouse'

----Deleting with ProductID
delete from Product
where ProductID = 2

----Alphabetical order
select * from Product
order by ProductName asc;

select * from Product

--Library Management
create Table Books(
BookID int NOT NULL PRIMARY KEY,
TitleName varchar(255),
Author varchar(255),
PublishedYear int,
AvailableCopies int,
);

--Insert data into table
insert into Books(BookID,TitleName,Author,PublishedYear,AvailableCopies)
values
(1,'The Great Gatsby','F.Scott Fitzgerald',1925,3),
(2,'1984','George Orwell',1949,2),
(3,'To Kill a Mockingbird','Harper Lee',1960,5),
(4,'Brave New World','Aldous Huxley',1932,4)

--Updating the price
Update Books
SET AvailableCopies ='5'
where TitleName = '1984'

--Delete with BookID
delete from Books
where BookID = 1

--select books published after 1950
select * from Books where PublishedYear>1950

select * from Books

--Customer Management
--Create Table
create Table Customer(
CustomerID int,
CustomerName varchar(50),
Email varchar(50),
PhoneNumber varchar(50),
);

--inserting data
insert into Customer(CustomerID,CustomerName,Email,PhoneNumber)
values
('201','Alice Johnson','alice@example.com','555-1234'),
('202','Bob Smith','bob@example.com','555-5678'),
('203','Charlie Brown','charlie@example.com','555-8765')

--inserting new row
insert into Customer(CustomerID,CustomerName,Email,PhoneNumber)
values
('204','David Wilson','david@example.com','555-9999')


--Update the phone number
update customer
set PhoneNumber = '555-9999'
where CustomerName = 'Alice Johnson'

--delete 
delete from Customer
where CustomerID=202
select * from Customer

--clear the table
truncate table Customer


--Order Management
--Create Table
create Table Orders(
OrderID int,
CustomerID int,
OrderDate varchar(50),
TotalAmount decimal(10,2)
);
truncate table Orders
--insert data
insert into Orders(OrderID,CustomerID,OrderDate,TotalAmount)
values
(301,201,'01-09-2024',250),
(302,202,'02-09-2024',150),
(303,203,'03-09-2024',200)

--inserting new order
insert into Orders(OrderID,CustomerID,OrderDate,TotalAmount)
values
(304,204,'04-09-2024',300)

--update the totalamount
update OrderS
set TotalAmount=275
where OrderID =301

--delete with orderID
delete from Orders
where OrderID=302

--select order with totalamount greater than 200
select * from Orders where TotalAmount>200

--select only OrderID and TotalAmount for all orders
select OrderID,TotalAmount
from Orders

select * from Orders

--Primary Key
--Create table
create table Students (
    StudentID INT PRIMARY KEY,
    FirstName varchar(50),
    LastName varchar(50),
    Email varchar(100)
);

--insert data
insert into Students (StudentID, FirstName, LastName, Email)
values 
(1, 'John', 'Doe', 'john.doe@example.com'),
(2, 'Jane', 'Smith', 'jane.smith@example.com'),
(3, 'Mike', 'Johnson', 'mike.johnson@example.com');
select * from Students

--Courses Table
create table Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100)
);
insert into Courses (CourseID, CourseName)
values 
(1, 'Mathematics'),
(2, 'English'),
(3, 'Computer Science')


----Enrollment Table
create table Enrollments (
    EnrollmentID INT PRIMARY KEY,
    StudentID int,
    CourseID int,
    EnrollmentDate varchar(50),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
insert into Enrollments (EnrollmentID, StudentID, CourseID, EnrollmentDate)
VALUES 
(1, 1, 1, '01-10-2024'),
(2, 2, 2, '02-10-2024'), 
(3, 3, 3, '03-10-2024')
Select * from Enrollments

--Composite Key
create table OrderDetails (
    OrderID int,
    ProductID int,
    Quantity int,
    PRIMARY KEY (OrderID, ProductID)
);
select * from OrderDetails

--Candidate key
create table Users (
    UserID int PRIMARY KEY,              
    Email varchar(50) UNIQUE,           
    Username varchar(50)
	);
	select * from Users

--Surrogate key
Create table  Products (
    AutoID integer PRIMARY KEY autoincrement,  
    ProductName varchar(50) NOT NULL,      
    Price decimal(10, 2) NOT NULL           
);
select * from Products

--Natural Key
create table  Employees (
    SSN varchar(10) PRIMARY KEY,              
    FirstName varchar(50) NOT NULL,       
    LastName varchar(50) NOT NULL,        
    Position varchar(50) NOT NULL         
);
select * from Employees

--Unique key
create table Customers (
    CustomerID INT PRIMARY KEY,          
    FirstName varchar(50) NOT NULL,       
    LastName varchar(50),        
    PhoneNumber varchar(15) UNIQUE,       
    Email varchar(50)                    
);
select * from Customers

--Basic view creation
create view EmployeeView AS
SELECT FirstName,LastName,Department
FROM Employee

--Query the view
SELECT * FROM EmployeeView


--Updating data through a view
create view EditableEmployeeView AS
Select EmployeeID,FirstName,LastName,Salary
FROM Employee
UPDATE EditableEmployeeView
SET Salary = 60000
WHERE EmployeeID =1
--Verify
SELECT * FROM EditableEmployeeView
WHERE EmployeeID=1

--View with calculated columns
create view EmployeeSalaryBonusView as
select FirstName,LastName,Salary,Salary*0.10 as bonus
from Employee
select * from EmployeeSalaryBonusView

--Altering 
alter view EmployeeView as
select FirstName,LastName,Department,Salary
from Employee
select * from EmployeeView
----Verify 
select * from employeeView


--view with parameters
create view FilteredEmployeeView as
select EmployeeID,FirstName,LastName,Department
from employee
select*from FilteredEmployeeView
where Department='HR'

--dropping a view
DROP VIEW EmployeeView
--Query to view again
SELECT * FROM EmployeeView



----------PART 2-------------
create table Sales(
SalesID int NOT NULL,
ProductID int,
ProductName varchar(50),
QuantitySold int,
SaleAmount int,
SaleDate varchar(50)
);
insert into Sales(SalesID,ProductID,ProductName,QuantitySold,SaleAmount,SaleDate)
values
('1','101','Laptop','5','5000','01-09-2024'),
('2','102','Mouse','10','250','02-09-2024'),
('3','103','Laptop','3','3000','03-09-2024'),
('4','104','Keyboard','8','800','04-09-2024'),
('5','105','Mouse','6','150','05-09-2024')
select * from Sales
--calculate total sales amount
select SUM(SaleAmount) as Sum from Sales

--maximum quantity sold
select MAX(QuantitySold) as Max from Sales

--average sale amount per sale
select AVG(SaleAmount) as Average from Sales

--minimum sale amount
select MIN(SaleAmount) as Min from Sales

--total quantity sold
select SUM(QuantitySold) as TotalQuantity from Sales
where ProductName='Laptop'


--EmployeeSalaries
create table Employes(
EmployeeID int NOT NULL,
EmployeeName varchar(50),
Department varchar(50),
Salary int,
HireDate varchar(50)
);
insert into Employes(EmployeeID,EmployeeName,Department,Salary,HireDate)
values
('1','John Doe','IT','5000','01-10-2022'),
('2','Jane Smith','HR','6000','15-03-2021'),
('3','Bob Johnson','Finance','5500','20-06-2020'),
('4','Alice Brown','IT','6200','01-02-2023'),
('5','Charlie White','Marketing','4800','10-03-2023')
select * from Employes
-- total salary expenditure
select SUM(Salary) as Sum from Employes

--highest salary
select Max(Salary) as Max from Employes

--calculate the average salary
select AVG(Salary) as Avg from Employes

--find the minimum salary 
select MIN(Salary) as MinIT from Employes
where Department='IT'

--find the total number of employees
select Department,COUNT(EmployeeID) as TotalEmployees from Employes
GROUP BY Department
ORDER BY TotalEmployees

--Inventory Management
create table Inventory(
ProductID int,
ProductName varchar(50),
QuantityInStock int,
RecorderLevel int,
LastRestockDate varchar(50)
);
insert into Inventory(ProductID,ProductName,QuantityInStock,RecorderLevel,LastRestockDate)
values
('201','Monitor','50','10','25-08-2024'),
('202','Printer','30','5','01-09-2024'),
('203','Mouse','100','15','10-09-2024'),
('204','Keyboard','80','20','15-09-2024'),
('205','Laptop','25','5','20-09-2024')
select * from Inventory
--total quantity of products in stock
select SUM(QuantityInStock) as Sum from Inventory
--product with the highest quantity in stock
select ProductName, QuantityInStock from Inventory where QuantityInStock=(select MAX(QuantityInStock) from inventory)
--average reorder level
select Avg(RecorderLevel) as Avg from Inventory
--product with the lowest reorder level
select ProductName,RecorderLevel from Inventory where RecorderLevel=(select min(RecorderLevel) from inventory)
--total quantity in stock for products where the quantity is less than the reorder level
select sum(QuantityInStock) as TotalQuantityInStock from Inventory
where QuantityInStock < RecorderLevel


--CustomerOrders
create table CustomerOrders(
OrderID int NOT NULL,
CustomerID varchar(10),
OrderDate varchar(50),
OrderAmount int,
QuantityOrdered int
);
insert into CustomerOrders(OrderID,CustomerID,OrderDate,OrderAmount,QuantityOrdered)
values
('501','C001','10-09-2024','1500','3'),
('502','CO02','11-09-2024','2000','5'),
('503','CO01','12-09-2024','1000','2'),
('504','C003','13-09-2024','2500','4'),
('505','C002','14-09-2024','3000','6')
select * from CustomerOrders
--total order amount
select SUM(OrderAmount) as Sum from CustomerOrders
--average order amount
select AVG(OrderAmount) as Avg from CustomerOrders
--maximum order amount from a single order
select MAX(OrderAmount) as Max from CustomerOrders
--total quantity ordered
select SUM(QuantityOrdered) as TotalQuantityOrdered from CustomerOrders
--minimum order amount
select MIN(OrderAmount) as Min from CustomerOrders

--Product Ratings Database
create table ProductRatings(
RatingID int NOT NULL,
ProductID varchar(10),
CustomerID varchar(10),
Rating int,
ReviewDate varchar(50)
);
insert into ProductRatings(RatingID,ProductID,CustomerIS,Rating,ReviewDate)
values
('1','P001','C001','4','01-09-2024'),
('2','P002','C002','5','02-092-2024'),
('3','P001','C003','3','03-09-2024'),
('4','P003','C001','2','04-09-2024'),
('5','P002','C004','4','05-09-2024')
select * from ProductRatings
--average rating for each product
SELECT ProductID, AVG(Rating) AS AverageRating from ProductRatings
GROUP BY ProductID;
--highest rating given to any product
select MAX(Rating) as Max from ProductRatings
--lowest rating given to any product
select MIN(Rating) as Min from ProductRatings
--total number of ratings for each product
Select ProductID, COUNT(Rating) as TotalRating from ProductRatings
GROUP BY ProductID
--total number of products rated
SELECT COUNT(DISTINCT ProductID) AS TotalRatedProducts from ProductRatings
truncate table ProductRatings


---------------------------------------------------------------------------------------------------------------------------------
--Retrieve Employees Who Work in Specific Departments Using IN Operator
SELECT EmployeeName, Department FROM Employes
WHERE Department IN ('HR', 'Finance', 'IT')

--Retrieve the product names and prices of products that are priced between 100 and 500
SELECT ProductID,ProductName,Price FROM Product
WHERE Price BETWEEN 100 AND 500

--Retrieve the customer names that start with the letter 'A'
SELECT CustomerID,CustomerName from Customer
where CustomerName LIKE 'A%'

--Retrieve Orders Placed on Specific Dates
SELECT OrderID,OrderDate FROM Orders
WHERE OrderDate IN ('01-09-2024', '01-02-2024', '01-03-2024')

--Retrieve Products That Are Not Priced Between 100 and 500 Using NOT BETWEEN
SELECT ProductID,ProductName,Price FROM Product
WHERE Price  NOT BETWEEN 100 AND 500

--More than 5000 and less than 1000 using OR 
SELECT OrderID,OrderAmount FROM CustomerOrders
WHERE OrderAmount>5000 OR OrderAmount<1000

--Not work in HR or IT using NOT IN
SELECT EmployeeName, Department FROM Employes
WHERE Department NOT IN ('HR','IT')

--Retrieve Orders Placed in 2023 Using BETWEEN and AND Operators
SELECT* FROM Orders
WHERE OrderDate BETWEEN '01-01-2024' AND '31-12-2024'

--Find Customers Who Do Not Have 'John' in Their Name Using NOT LIKE Operator
SELECT CustomerID,CustomerName from Customer
where CustomerName NOT LIKE 'John%'

--Retrieve the product names and prices of products that are either in category 'A' or have a price less than 100
CREATE TABLE Categories (
    CategoryID int PRIMARY KEY,
    CategoryName varchar(50)
);
CREATE TABLE Products (
    ProductID int,
    ProductName varchar(100),
    Price decimal(10, 2),
    CategoryID int,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
INSERT INTO Categories (CategoryID, CategoryName)
VALUES 
(1, 'A'), 
(2, 'B'), 
(3, 'C');
INSERT INTO Products (ProductID, ProductName, Price, CategoryID)
VALUES 
('1', 'Product1', '50','1'),
('2', 'Product2', '150.00','2'),
('3', 'Product3', '200.00','3'),
('4', 'Product4', '80.00', '2'),
('5', 'Product5', '70.00','1');
SELECT ProductName, price
FROM products
WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE CategoryName = 'A')
  OR price < 100;
select * from Products
select * from Categories

-------------------------------------------------------------------------------
--Add a New Column
ALTER TABLE Employes
ADD DateOfBirth varchar(50);
select * from Employes

--Modify Column Data Type
ALTER TABLE Customers
ALTER COLUMN PhoneNumber varchar(15);
select * from Customers

--Add a primary key
ALTER TABLE Employes
ADD CONSTRAINT PK_Employes PRIMARY KEY(EmployeeID);
select * from Employes

--Drop a column
ALTER TABLE Employees
DROP COLUMN LastName;
select * from Employees

--Add a foreign key
Create table Course(
StudentID int,
CourseName varchar(50)
);
ALTER TABLE Course
ADD CONSTRAINT FK_Course_Students
FOREIGN KEY (StudentID) REFERENCES Students(StudentID);

--Drop a foreign key
ALTER TABLE Course
DROP CONSTRAINT FK_Course_Students;

--Rename a column
EXEC sp_rename'Employes.EmployeeName','FullName','COLUMN';
select * from Employes

--Add a default value
ALTER TABLE Employes
ADD CONSTRAINT DF_DateOfBirth
DEFAULT 'Active' FOR DateOfBirth;

--Drop a primary key
CREATE TABLE Coursess (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100)
);
ALTER TABLE Coursess
ADD CONSTRAINT PK_Coursess PRIMARY KEY(CourseID)

ALTER TABLE Coursess
DROP CONSTRAINT PK_Coursess;

--Add a unique constraint
ALTER TABLE Coursess
ADD Email varchar(50);
select * from Coursess
ALTER TABLE Coursess
ADD CONSTRAINT UQ_Email UNIQUE(Email);

--Add a check constraint
ALTER TABLE Employes
ADD CONSTRAINT CHK_Salary CHECK (Salary >= 1000);

--Drop a check constraint
ALTER TABLE Employes
DROP CONSTRAINT CHK_Salary;


---------------------------------------------------------------------------------------------------
--Retrieve Employees Who Earn More Than the Average Salary 
SELECT FullName, Salary FROM Employes
WHERE Salary > (SELECT AVG(Salary) FROM Employes);
select * from Employes
-- Retrieve the department names that have more than 5 employees
create table Employeee(
EmployeeID int,
EmployeeName varchar(50),
DepartmentID int,
DepartmentName varchar(50),
Salary decimal(10,2)
);
insert into Employeee(EmployeeID,EmployeeName,DepartmentID,DepartmentName,Salary)
values
('101','John','201','IT',25000),
('102','Jane','202','Marketing',30000),
('103','Smith','203','HR',10000),
('104','Mike','203','HR',15000),
('105','Johnson','201','IT',20000)
select*from Employeee

SELECT DepartmentName FROM Employeee
WHERE DepartmentID IN (SELECT DepartmentID FROM Employeee
GROUP BY DepartmentID
HAVING COUNT(EmployeeID) > 1
);

--Retrieve Products with a Price Higher Than the Maximum Price of Category 'A' 
CREATE TABLE Product (
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100) NOT NULL,
Price DECIMAL(10, 2) NOT NULL,
Category CHAR(1) NOT NULL
);
INSERT INTO Product (ProductID,ProductName, Price, Category)
VALUES
('101','Product1', 100.50, 'A'),
('102','Product2', 200.00, 'B'),
('103','Product3', 150.00, 'A'),
('104','Product4', 250.75, 'C'),
('105','Product5', 300.50, 'A');
select * from Product
SELECT ProductName, Price FROM Product
WHERE Price > (
SELECT MAX(Price)
FROM Product
WHERE Category = 'A'
);

--Retrieve Employees Who Work in Departments with Average Salary Higher Than 50,000
SELECT EmployeeName,Salary from Employeee
WHERE DepartmentID IN(
SELECT DepartmentID from Employeee 
GROUP BY DepartmentID
HAVING AVG(Salary)>25000
);

-- Retrieve the names of employees who earn more than the average salary of their department
SELECT EmployeeName FROM Employeee e
WHERE Salary > (
SELECT AVG(Salary)
FROM Employeee
WHERE DepartmentID = e.DepartmentID
);

--Retrieve the names of customers who have not placed any orders
CREATE TABLE Customerss (
CustomerID INT PRIMARY KEY,
CustomerName VARCHAR(100) NOT NULL
);
CREATE TABLE Orderss (
OrderID INT PRIMARY KEY,
CustomerID INT,
OrderDate VARCHAR(50),
FOREIGN KEY (CustomerID) REFERENCES Customerss(CustomerID)
);
INSERT INTO Customerss (CustomerID,CustomerName)
VALUES
('101','Alice'),
('102','Bob'),
('103','Charlie'),
('104','David');
INSERT INTO Orderss (OrderID,CustomerID, OrderDate)
VALUES
('1','101', '2024-01-15'),  
('2','101', '2024-02-20'),  
('3','102', '2024-01-10'); 
SELECT CustomerName FROM Customerss
WHERE CustomerID NOT IN (
 SELECT CustomerID FROM Orderss
);

--Retrieve the names of products that have never been ordered
CREATE TABLE ProductPlaced (
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100) NOT NULL
);
CREATE TABLE OrdersPlaced (
OrderID INT PRIMARY KEY,
ProductID INT,
OrderDate VARCHAR(50),
FOREIGN KEY (ProductID) REFERENCES ProductPlaced(ProductID)
);
INSERT INTO ProductPlaced(ProductID,ProductName)
VALUES
('1','Product A'),
('2','Product B'),
('3','Product C'),
('4','Product D');
INSERT INTO OrdersPlaced (OrderID,ProductID, OrderDate)
VALUES
('101','1', '2024-01-15'),  
('102','1', '2024-02-20'),  
('103','2', '2024-01-10');
SELECT ProductName FROM ProductPlaced 
WHERE ProductID NOT IN (
SELECT ProductID
FROM OrdersPlaced
);

----------------------------------------------------------------------------------------------------------------------
CREATE TABLE Departments (
DepartmentID INT PRIMARY KEY,
DepartmentName VARCHAR(50) NOT NULL
);
CREATE TABLE Employ (
EmployeeID INT PRIMARY KEY,
EmployeeName VARCHAR(50),
DepartmentID INT,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
INSERT INTO Departments (DepartmentID,DepartmentName)
VALUES
('1','HR'),
('2','Finance'),
('3','IT'),
('4','Marketing');
INSERT INTO Employ(EmployeeID,EmployeeName, DepartmentID)
VALUES
('101','Alice','1'),  
('102','Bob','2'),   
('103','Charlie','3'),
('104','David',Null),  
('105',Null,'4');    
select * from Employ

--Retrieve Employees and Their Department Names
SELECT e.EmployeeName, d.DepartmentName FROM Employ e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

--Retrieve All Employees and Their Department Names, Including Those Without Departments
SELECT e.EmployeeName, d.DepartmentName FROM Employ e
LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID;

--Retrieve All Departments and the Employees Working in Them  
SELECT d.DepartmentName,e.EmployeeName FROM Departments d
RIGHT JOIN Employ e ON d.DepartmentID = e.DepartmentID;

--Retrieve All Employees and Departments, Including Those Without Matches 
SELECT e.EmployeeName, d.DepartmentName FROM Employ e
FULL OUTER JOIN Departments d ON e.DepartmentID = d.DepartmentID;



CREATE TABLE Customr (
CustomerID INT PRIMARY KEY,
CustomerName VARCHAR(50) NOT NULL
);
CREATE TABLE Ordr (
OrderID INT PRIMARY KEY,
CustomerID INT,
FOREIGN KEY (CustomerID) REFERENCES Customr(CustomerID)
);
INSERT INTO Customr (CustomerID,CustomerName)
VALUES
('1','John'),
('2','Mike'),
('3','Jane');
INSERT INTO Ordr (OrderID, CustomerID)
VALUES
('101', '1'),  
('102','2'),  
('103','1');
select * from Ordr
select * from Customr
--Retrieve Orders and the Customers Who Placed Them 
SELECT o.OrderID, c.CustomerName FROM Ordr o
INNER JOIN Customr c ON o.CustomerID = c.CustomerID;

--Retrieve Orders and Customers, Including Customers Without Orders 
SELECT c.CustomerID, c.CustomerName, o.OrderID
FROM Customr c
LEFT JOIN Ordr o ON c.CustomerID = o.CustomerID;
select * from Ordr
select * from Customr

--Retrieve Products and Their Categories
SELECT p.ProductID, p.ProductName, c.CategoryName
FROM Products p
INNER JOIN Categories c ON p.CategoryID = c.CategoryID;
select * from Products
select * from Categories

--Retrieve All Categories and Products, Including Categories Without Products
SELECT p.ProductID, p.ProductName, c.CategoryID, c.CategoryName
FROM Products p
RIGHT JOIN Categories c ON p.CategoryID = c.CategoryID;

--etrieve Employees and Their Managers
create table Emplyee(
EmployeeID int NOT NULL,
EmployeeName varchar(50),
ManagerID int
);
insert into Emplyee(EmployeeID,EmployeeName,ManagerID)
values
('1','Ravi',NULL),
('2','Raj','4'),
('3','Sachin','2'),
('4','Sajin','1')

SELECT e.EmployeeID,e.EmployeeName,m.EmployeeName AS ManagerName FROM Emplyee e
LEFT JOIN Emplyee m ON e.ManagerID = m.EmployeeID;

--Retrieve Employees and Their Managers
SELECT p.ProductID, p.ProductName, o.OrderID, o.OrderDate
FROM Products p
CROSS JOIN Orders o;
select * from Products
select * from Orders
----------------------------------------------------------------------------------------------------------------------

--Retrieve the department name and the average salary of employees in each department,Only display departments where the average salary is greater than 50,000
SELECT DepartmentName, AVG(salary) AS average_salary
FROM Employeee
GROUP BY DepartmentName
HAVING AVG(salary) > 50000;
select * from Employeee

--Retrieve the department name and the total number of employees in each department,Only display departments that have more than 5 employees
SELECT DepartmentName, COUNT(EmployeeID) AS total_employees
FROM Employeee
GROUP BY DepartmentName
HAVING COUNT(EmployeeID) > 5;
select * from Employeee

-- Retrieve the department name, maximum salary, and minimum salary for each department,Only include departments where the minimum salary is greater than 30,000
SELECT DepartmentName, MAX(salary) AS max_salary, MIN(salary) AS min_salary
FROM Employeee
GROUP BY DepartmentName
HAVING MIN(salary) > 30000

--Retrieve the employee name and total sales made by each salesperson. Only display salespersons who have made total sales of more than 100,000
CREATE TABLE Sales (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    SalesAmount DECIMAL(10, 2)
);
INSERT INTO Sales (EmployeeID, EmployeeName, SalesAmount)
VALUES 
(1, 'John', 120000),
(2, 'Jane', 95000.00),
(3, 'Smith', 150000.00);
select * from Sales

SELECT EmployeeName, SUM(SalesAmount) AS totalsales
FROM Sales
GROUP BY EmployeeName
HAVING SUM(SalesAmount) > 100000;

-- Retrieve the customer name and the total number of orders placed by each customer,Only display customers who have placed more than 3 orders
CREATE TABLE Ordrs (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(100)
);
INSERT INTO Ordrs (OrderID,CustomerName)
VALUES 
(1, 'John Doe'),
(2, 'Jane Smith'),
(3, 'John Doe');
SELECT CustomerName, COUNT(OrderID) AS TotalOrders
FROM Ordrs
GROUP BY CustomerName
HAVING COUNT(OrderID) > 3;



