-- ���� ��������� ������� ���� ������� �� ��������� ��� ������ ������ �� ������� �� �������
SELECT Products.Product AS �������, Categories.Category AS ��������� FROM Products
LEFT JOIN Categories ON Products.idCategory = Categories.id