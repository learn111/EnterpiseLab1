CREATE PROCEDURE DishTypesSelect
	@DishTypeId INT = NULL
AS
BEGIN
	SELECT 
		DishTypeId,		Name
	FROM DishTypes
	WHERE 
		DishTypeId = ISNULL(@DishTypeId, DishTypeId)
	ORDER BY
		DishTypeId
END
GO
