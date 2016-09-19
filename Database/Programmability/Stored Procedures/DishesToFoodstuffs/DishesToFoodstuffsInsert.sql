CREATE PROCEDURE DishesToFoodstuffsInsert 
	@DishId INT,	@FoodstuffId INT,	@Consumption DECIMAL(18, 10)
AS
BEGIN
	DECLARE @ErrorMessage NVARCHAR(4000)
	DECLARE @ErrorSeverity INT
	DECLARE @ErrorState INT
	DECLARE @ErrorCode INT

	BEGIN TRY
		BEGIN TRANSACTION

		INSERT dbo.DishesToFoodstuffs ( 
			DishId,			FoodstuffId,			Consumption
		)
		SELECT 
			@DishId,			@FoodstuffId,			@Consumption

		DECLARE @DishesToFoodstuffsId INT = SCOPE_IDENTITY()
		EXEC DishesToFoodstuffsSelect
			@DishesToFoodstuffsId = @DishesToFoodstuffsId

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		SELECT 
			@ErrorCode = ERROR_NUMBER(),
			@ErrorMessage = ERROR_MESSAGE(),
			@ErrorSeverity = ERROR_SEVERITY(),
			@ErrorState = ERROR_STATE()

		-- try to translate error into human-style
		IF (@ErrorCode < 50000)
			SELECT @ErrorCode = dbo.SystemConstraintMessages_GetCode(@ErrorMessage, OBJECT_NAME(@@PROCID))

		IF (@ErrorCode IS NOT NULL) BEGIN
			SELECT @ErrorMessage = FORMATMESSAGE(@ErrorCode);
			THROW @ErrorCode, @ErrorMessage, @ErrorSeverity;	
		END
		ELSE 
		BEGIN
			-- add here any additional logic for unexpected exception
			;THROW;			
		END

	END CATCH

END
GO
