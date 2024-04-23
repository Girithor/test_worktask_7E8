/*
	Если придерживаться описания задачи, то связь между продуктами и категориями, много ко многим, а значит должна существовать промежуточная таблица, которая и реализует данную связь. В моем скрипте я представил, что это таблица Product_Category.
	Пример SQL скрипта:
*/
SELECT 
	p.Name,
	c.Name
FROM Product AS p -- Если принять, что таблица Продуктов - Product
LEFT JOIN Product_Category p_c ON p_c.ProductId = p.Id
LEFT JOIN Category c ON c.Id = p_c.CategoryId -- Если принять, что таблица Категорий - Category