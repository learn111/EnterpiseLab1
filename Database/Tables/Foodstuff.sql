CREATE TABLE [dbo].[Foodstuff]
(
	[FoodstuffId] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Name] NVARCHAR(256) NOT NULL, 
    [Price] DECIMAL(18, 2) NOT NULL, 
    [MeasurementUnitId] INT NULL FOREIGN KEY REFERENCES MeasurementUnit(MeasurementUnitId)
)
