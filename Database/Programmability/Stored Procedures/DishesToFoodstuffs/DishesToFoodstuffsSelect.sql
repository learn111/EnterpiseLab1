CREATE PROCEDURE DishesToFoodstuffsSelect
	@DishesToFoodstuffsId INT = NULL
AS
BEGIN
	SELECT 
		DishesToFoodstuffsId,		DishId,		FoodstuffId,		Consumption
	FROM DishesToFoodstuffs
	WHERE 
		DishesToFoodstuffsId = ISNULL(@DishesToFoodstuffsId, DishesToFoodstuffsId)
	ORDER BY
		DishesToFoodstuffsId
END
GO
