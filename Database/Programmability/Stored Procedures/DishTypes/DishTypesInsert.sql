CREATE PROCEDURE DishTypesInsert 
	@Name NVARCHAR(64)
AS
BEGIN
	DECLARE @ErrorMessage NVARCHAR(4000)
	DECLARE @ErrorSeverity INT
	DECLARE @ErrorState INT
	DECLARE @ErrorCode INT

	BEGIN TRY
		BEGIN TRANSACTION

		INSERT dbo.DishTypes ( 
			Name
		)
		SELECT 
			@Name

		DECLARE @DishTypeId INT = SCOPE_IDENTITY()
		EXEC DishTypesSelect
			@DishTypeId = @DishTypeId

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
