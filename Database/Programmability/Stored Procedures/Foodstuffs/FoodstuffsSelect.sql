CREATE PROCEDURE FoodstuffsSelect
	@FoodstuffId INT = NULL
AS
BEGIN
	SELECT 
		FoodstuffId,		Name,		Price,		MeasurementUnitId
	FROM Foodstuffs
	WHERE 
		FoodstuffId = ISNULL(@FoodstuffId, FoodstuffId)
	ORDER BY
		FoodstuffId
END
GO