CREATE TABLE [dbo].[DishesToFoodstuffs]
(
	[DishesToFoodstuffsId] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [DishId] INT NOT NULL FOREIGN KEY REFERENCES Dishes(DishId) ON DELETE CASCADE, 
    [FoodstuffId] INT NOT NULL FOREIGN KEY REFERENCES Foodstuffs(FoodstuffId), 
    [Consumption] DECIMAL(18, 2) NOT NULL
)
