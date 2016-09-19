﻿CREATE PROCEDURE DishesToFoodstuffsSelect
	@DishesToFoodstuffsId INT = NULL
AS
BEGIN
	SELECT 
		DishesToFoodstuffsId,
	FROM DishesToFoodstuffs
	WHERE 
		DishesToFoodstuffsId = ISNULL(@DishesToFoodstuffsId, DishesToFoodstuffsId)
	ORDER BY
		DishesToFoodstuffsId
END
GO