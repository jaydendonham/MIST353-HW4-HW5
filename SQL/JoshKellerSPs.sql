-- Josh Keller
-- STORED PROCEDURE 5
-- Add a driver to the database
-- Used by employers to add their drivers, or by prospective drivers to put their information out there for employers

USE MIST353A3
GO

CREATE PROC addDriver

	@DID int,
	@Position varchar(50),
	@Driver_First varchar(50),
	@Driver_Last varchar(50),
	@Hometown varchar(50),
	@DLNum varchar(50)

AS
BEGIN
INSERT INTO Driver([DID], [Position], [Driver_First], [Driver_Last], [Hometown], [DLNum])
VALUES(@DID,@Position,@Driver_First,@Driver_Last,@Hometown,@DLNum)
END
GO

-- Josh Keller
-- STORED PROCEDURE 6
-- Find POI within a given state
-- This will be useful for long-distance trips where a driver may want to visit different POI in a state
-- This may be a rest stop or monument
-- For example, West Virginia would provide a variety including the Tamarack, New River Gorge, etc

CREATE OR ALTER PROC findPOIByState

	@POI_State nvarchar(50)
AS
BEGIN

	Select * FROM POI WHERE POI_State = @POI_State
END
GO
