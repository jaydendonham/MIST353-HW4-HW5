--STORED PROCEDURE 1
-- Stored procedure to count how many different car manufacturers the system has parts for.
CREATE PROC GetManufacturerCount
    @manufacturerCount INT OUTPUT
AS
BEGIN
    SELECT @manufacturerCount = COUNT(DISTINCT Manufacturer)
    FROM dbo.VEHICLE;
END;
GO
                                            --OUTPUT FOR SP1 
                                            Number of Different Car Manufacturers: 16
                                            Completion time: 2024-02-26T21:28:54.0537207-05:00


    
--STORED PROCEDURE 2 -RYAN SLADIC
--SP Filter to get all information about parts in database for American automobiles. 
CREATE PROC GetPartsFromUSA
AS
BEGIN
    SELECT *
    FROM AutoPart
    WHERE PCountry = 'USA';
END;
                                                --OUTPUT FOR SP 2 RYAN SLADIC 
                                            1	ABC Manufacturing	Mechanical	USA	50	Engine
                                            6	Tech Solutions	Cosmetic	USA	60	Exhaust
                                            11	FutureTech	Mechanical	USA	55	Starter
                                            15	TechGurus	Mechanical	USA	85	Ignition Coil
