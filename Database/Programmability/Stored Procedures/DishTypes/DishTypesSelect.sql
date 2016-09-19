﻿CREATE PROCEDURE DishTypesSelect
	@DishTypeId INT = NULL
AS
BEGIN
	SELECT 
		DishTypeId,
	FROM DishTypes
	WHERE 
		DishTypeId = ISNULL(@DishTypeId, DishTypeId)
	ORDER BY
		DishTypeId
END
GO