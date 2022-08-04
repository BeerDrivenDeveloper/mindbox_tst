/****** Object: Table [dbo].[Products] Script Date: 04.08.2022 18:34:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [ID]   INT            NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL
);

/****** Object: Table [dbo].[Categories] Script Date: 04.08.2022 18:34:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories] (
    [ID]   INT            NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL
);

/****** Object: Table [dbo].[ProductCategories] Script Date: 04.08.2022 18:34:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductCategories] (
    [ProductID]  INT NULL,
    [CategoryID] INT NULL
);

insert into Products (ID, Name)
Values 
	(1, 'Volkswagen Golf 3'),
	(2, 'Volvo XC90'),
	(3, 'Ведро оцинкованное, 5 л'),
	(4, 'Жигули Барное, 20 л, в ведре'),
	(5, 'Лавкрафтовский ужас');
	
insert into Categories (ID, Name)
Values 
	(1, 'Автомобиль'),
	(2, 'Ведро'),
	(3, 'Жидкость');
	
insert into ProductCategories (ProductID, CategoryID)
Values 
	(1, 1),
	(1, 2),
	(2, 1),
	(3, 2),
	(4, 2),
	(4, 3);
	
select prod.name as 'Продукт',
cat.Name as 'Категория'
from Products prod
left join ProductCategories prcat on (prod.id = prcat.ProductID)
left join Categories cat on (prcat.CategoryID = cat.id);


