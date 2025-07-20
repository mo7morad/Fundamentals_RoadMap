
Declare  @score int;
set @score = 75;

IF @score >= 90
	BEGIN
		PRINT 'Grade A'
	END
ELSE
	BEGIN
		IF @score >= 80
			BEGIN
				PRINT 'Grade B'
			END
		ELSE
			BEGIN
				PRINT 'Grade C or lower'
			END
	END
