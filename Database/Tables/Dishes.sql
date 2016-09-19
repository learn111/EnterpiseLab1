CREATE TABLE [dbo].[Dishes]
(
	[DishId] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [Name] NVARCHAR(256) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DishTypeId] INT NOT NULL FOREIGN KEY REFERENCES DishTypes(DishTypeId)
)
