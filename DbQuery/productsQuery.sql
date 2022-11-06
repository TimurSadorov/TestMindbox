SELECT product.Name as "productName", category.Name as "categoryName"
FROM product 
	LEFT JOIN productCategory ON product.Id = productCategory.ProductId
        LEFT JOIN category ON category.Id = productCategory.CategoryId
