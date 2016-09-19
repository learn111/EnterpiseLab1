﻿CREATE PROCEDURE MeasurementUnitsSelect
	@MeasurementUnitId INT = NULL
AS
BEGIN
	SELECT 
		MeasurementUnitId,
	FROM MeasurementUnits
	WHERE 
		MeasurementUnitId = ISNULL(@MeasurementUnitId, MeasurementUnitId)
	ORDER BY
		MeasurementUnitId
END
GO