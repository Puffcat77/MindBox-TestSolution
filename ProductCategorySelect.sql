select P.Name, C.Name
from Product P left join ProductCategory PC on P.Id = PC.ProductId
	left join Category C on PC.CategoryId = C.Id
group by P.Name, C.Name