-- В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной
-- категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у 
-- продукта нет категорий, то его имя все равно должно выводиться.


CREATE TABLE Products
(
    Id   int primary key,
    Name varchar(20)
);

INSERT INTO Products
VALUES (1, 'RTX 4090'),
       (2, 'GTX 1060'),
       (3, 'RTX A6000'),
       (4, 'GMA 3100'),
       (5, 'Radeon 680M');

CREATE TABLE Categories
(
    Id   int primary key,
    Name varchar(20)
);

INSERT INTO Categories
VALUES (1, 'Ray tracing'),
       (2, 'Nvidia'),
       (3, 'AMD'),
       (4, 'Gaming');

CREATE TABLE ProductCategories
(
    ProductId  int foreign key references Products(id),
    CategoryId int foreign key references Categories(id),
    primary key (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES (1, 1),
       (1, 2),
       (1, 4),
       (2, 2),
       (2, 4),
       (3, 1),
       (3, 2),
       (5, 3);

SELECT P.Name, C.Name
FROM Products P
         LEFT JOIN ProductCategories PC
                   ON P.Id = PC.ProductId
         LEFT JOIN Categories C
                   ON PC.CategoryId = C.Id;