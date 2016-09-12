CREATE TABLE [dbo].[DishesToFoodstuffs]
(
	[DishesToFoodstuffsId] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [DishId] INT NOT NULL FOREIGN KEY REFERENCES Dish(DishId), 
    [FoodstuffId] INT NOT NULL FOREIGN KEY REFERENCES Foodstuff(FoodstuffId), 
    [Consumption] DECIMAL(18, 2) NOT NULL
)
