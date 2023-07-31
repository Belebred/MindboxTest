SELECT Name AS 'Продукт', Cathegory AS 'Категория'
FROM Product
LEFT JOIN ProductCathegory
	ON (Product.ID = ProductCathegory.ProductID)
LEFT JOIN Cathegory
	ON (Cathegory.ID = ProductCathegory.CathegoryID)