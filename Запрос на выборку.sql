-- Если правильно понятно суть задания то необходим был запрос именно на выборку из таблицы
SELECT Products.Product AS Продукт, Categories.Category AS Категория FROM Products
LEFT JOIN Categories ON Products.idCategory = Categories.id