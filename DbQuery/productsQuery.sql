SELECT product.name as "productName", category.name as "categoryName"
FROM product 
	LEFT JOIN productCategory ON product.Id = productCategory.ProductId
        LEFT JOIN category ON category.Id = productCategory.CategoryId