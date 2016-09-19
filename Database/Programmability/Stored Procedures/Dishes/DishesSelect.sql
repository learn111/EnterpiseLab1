CREATE PROCEDURE DishesSelect
	@DishId INT = NULL
AS
BEGIN
	SELECT 
		DishId,		Name,		Description,		DishTypeId
	FROM Dishes
	WHERE 
		DishId = ISNULL(@DishId, DishId)
	ORDER BY
		DishId
END
GO