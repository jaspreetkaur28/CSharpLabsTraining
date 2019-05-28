use Northwind

/*1.1	Write a query that lists all Customers in either Paris or London. Include Customer ID, Company Name and all address fields.
*/

SELECT CustomerID, CompanyName, Address, City, Region, PostalCode, Country 
FROM Customers 
WHERE City IN ('London', 'Paris') /* picks cities in london or paris */
Order by City ASC


/*1.2	List all products stored in bottles.*/
SELECT ProductName AS 'Bottled Products'
FROM Products 
WHERE QuantityPerUnit LIKE '%Bottles%' /* Finds the word bottles in the description area */
 

/*1.3	Repeat question above, but add in the Supplier Name and Country. */
SELECT ProductName AS 'Bottled Products', CompanyName, Country
FROM Products P
INNER JOIN Suppliers S /* joins products and suppliers table*/
ON S.SupplierID = P.SupplierID
WHERE QuantityPerUnit LIKE '%Bottles%'/* Finds the word bottles in the description area */

/*1.4	Write an SQL Statement that shows how many products there are in each category. Include Category Name in result set and list the highest number first.
 */
SELECT  CategoryName AS 'Category', COUNT(*) AS 'Quantity'  /* counts all the rows and groups by category name */
FROM Products P
INNER JOIN Categories C ON C.CategoryID = P.CategoryID
GROUP BY CategoryName
ORDER BY [Quantity] DESC


/* 1.5	List all UK employees using concatenation to join their title of courtesy, first name and last name together. 
Also include their city of residence.*/
SELECT TitleOfCourtesy+ ' ' + FirstName + ' ' + LastName As 'Full Name of UK Employees', City 
FROM Employees 
WHERE Country = 'UK'

/*1.6	List Sales Totals for all Sales Regions (via the Territories table using 4 joins) with a Sales Total greater than 1,000,000. Use rounding or FORMAT to present the numbers.  */
SELECT  RegionDescription AS 'Region',
ROUND(SUM(UnitPrice*Quantity*(1-Discount)),-4) AS 'Total Sales Rounded'
FROM Territories T
/* inner join on 4 other tables to get the data needed*/
INNER JOIN Region R               ON R.Regionid = T.RegionID
INNER JOIN EmployeeTerritories ET ON ET.TerritoryID = T.TerritoryID
INNER JOIN Orders O               ON O.EmployeeID = ET.EmployeeID
INNER JOIN [Order Details] OD     ON OD.OrderID = O.OrderID

GROUP BY RegionDescription /* will show only the regions and their total sales*/
HAVING SUM(UnitPrice*Quantity*(1-Discount))  > 1000000 /* total sales needs the discount to be included so 1-discount */

/*1.7	Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country. */
SELECT 
ShipCountry AS Country, 
Count(*) AS 'Total Number of Freight over 100'  /*counts the rows for the total number */
FROM Orders 
WHERE ShipCountry IN ('USA','UK') AND Freight > 100.00
GROUP BY ShipCountry

/* 1.8	Write an SQL Statement to identify the Order Number of the Order with the highest amount of discount applied */
SELECT TOP 1(Orderid)   AS 'Highest Discounted Order'  
FROM [Order Details] WHERE UnitPrice*Discount*Quantity > 0 /* No need for 1-Discount as we want the discounted amount anf not the total sale*/
GROUP BY OrderID
ORDER BY SUM(UnitPrice*Discount*Quantity) DESC
  

/* Exercise 2
Spartans Table – include details about all the Spartans on this course. 
Separate Title, First Name and Last Name into separate columns, 
and include University attended, course taken and mark achieved. 
Add any other columns you feel would be appropriate. 
*/
DROP TABLE [dbo].[SPARTANS]; /*drops table to stop errors */


GO
CREATE TABLE [dbo].[SPARTANS] ( /* all the data types */
    [SpartanId]    INT  IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50) NULL,
    [FirstName]    NVARCHAR (50) NULL,
    [LastName]     NVARCHAR (50) NULL,
    [University]   NVARCHAR (50) NULL,
    [Course]       NVARCHAR (50) NULL,
    [Mark]         Int  NULL, 
	[YearOfGrad]   Date 
);

SET IDENTITY_INSERT [dbo].[SPARTANS] ON /* inserting new data into table */
INSERT INTO [dbo].[SPARTANS] ([SpartanId], [Title], [FirstName], [LastName] , [University], [Course], [Mark], [YearOfGrad]) 
                      VALUES (1, 'Mr', 'Emmanuel', 'Badejo', 'Bedfordshire', 'BEng Electronic Engineering',100,'2016'),
					         (2, 'Mr', 'Lutizen', 'HeitKamp', 'University of Twente', 'MSC Mechnical Engineering',100,'2010'),
					         (3, 'Mr', 'Li', 'Dinh', 'Kingston', 'Bsc Nutrition',100,'2017'),
					         (4, 'Miss', 'Jaspreet', 'Rai', 'Greenwich', 'BEng Software Engineering',100,'2018'),
					         (2, 'Mr', 'Sebastian', 'Trifa', 'Bristol', 'Msc Physical with Astrophysics',100,'2014')
 SET IDENTITY_INSERT [dbo].[SPARTANS] OFF /* ends inserting data */

 
/*3.1 List all Employees from the Employees table and who they report to. No Excel required. (5 Marks) */
SELECT 
E.FirstName + ' ' + E.LastName AS 'Full Name', 
S.FirstName + ' ' + S.LastName AS 'Superior' 
FROM Employees E
LEFT JOIN Employees S  /* shows all employees including the Boss who doesnt have a superior */
ON E.ReportsTo = S.EmployeeID /* same table so needs a join to link these two  */
Order by [Superior] ASC

/*3.2 List all Suppliers with total sales over $10,000 in the Order Details table. Include the Company Name from the Suppliers Table and present as a line chart as below: (5 Marks)*/
 
SELECT  CompanyName, round(sum(OD.Unitprice*OD.Quantity*(1-OD.Discount)),0) AS 'Total Sales' 
FROM [Order Details] OD
JOIN Products P ON P.ProductID = OD.ProductID
JOIN Suppliers S ON S.SupplierID = P.SupplierID /* these two tables allow the total sales to be linked with the companyname */
GROUP BY CompanyName /* groups so rows are equal to the function results*/
HAVING SUM(OD.Unitprice*OD.Quantity*(1-OD.Discount))  > 10000  
ORDER BY [Total Sales] DESC
 
/*3.3 List the Top 10 Customers YTD for the latest year in the Orders file. Based on total amount of orders shipped. No Excel required. (10 Marks)*/

SELECT TOP 10 Companyname, count(*) AS 'Total Orders Shipped in the latest year'
FROM customers c
INNER JOIN  Orders O  ON O.CustomerID = c.CustomerID  
WHERE Year(OrderDate ) = (SELECT MAX(YEAR(OrderDate)) FROM Orders) /*not hard coded*/
GROUP BY CompanyName/* groups so rows are equal to the function results*/
ORDER BY 'Total Orders Shipped in the latest year' DESC

/*3.4 Plot the Average Ship Time by month for all data in the Orders Table. (10 Marks)*/
 
SELECT  CONCAT(FORMAT(orderdate, 'MMMM') , ' ', Year(OrderDate)) AS 'MonthYear', /*gets the month and year from orderdate*/
AVG(DATEDIFF(day, OrderDate, ShippedDate))  AS 'Average Shipping Time' /*calculates the shipping time difference*/
FROM Orders   
GROUP BY FORMAT(orderdate, 'MMMM'), YEAR(OrderDate), MONTH(OrderDate)    
ORDER BY YEAR(OrderDate) , MONTH(OrderDate)    
 