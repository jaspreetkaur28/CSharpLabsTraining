
use Northwind 
select sum(Quantity) As 'Total Stock' from [Order Details ]
select avg(UnitPrice) As 'Total average' from [Order Details ]
select Min(UnitPrice) As 'Min', Max(UnitPrice) As 'Max' from [Order Details ]
select count(*) As 'Total Orders' from orders
select count(CustomerID) As 'Number of customers', Country FROM Customers GROUP BY Country Having Count(CustomerID) >6 Order by [Number of customers] Desc; 
select  [Order Details].OrderID,  Products.ProductName,  [Order Details].UnitPrice,  [Order Details].Quantity from [Order Details] 
Inner join Products on Products.ProductID =  [Order Details].ProductID
/* create some queries using these  keywords on the Northwind database 
1. sum 
2. avg 
3. Min/max 
4. count 
5. group by ??? 
6. having ??? 
7. inner join
*/