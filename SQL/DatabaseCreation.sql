create database MIST353A3
go
--Jayden Donham start
use MIST353A3
go

create table Occupation
(OccupationID int not null primary key identity (1,1),
Position nvarchar(25) not null,
Wage nvarchar(25) not null);
go

create table Location
(StateID int not null primary key identity (1,1),
State nvarchar(25) not null,
City nvarchar(25) not null,
Zip nvarchar(25) not null);
go
--Jayden Donham end

-- Josh Keller
-- Creating the driver table
-- Used for the "job search" aspect of the portal or other integrations for employer use
-- Stores driver information for employer ease of access

CREATE TABLE DRIVER(
	DID INT PRIMARY KEY,
	DPosition NVARCHAR(50),
	D_First NVARCHAR(50),
	D_Last NVARCHAR(50),
	D_Hometown NVARCHAR(50),
	D_LNum NVARCHAR(50)
);
GO

-- Create POI Table
-- This table is for Points of Interest along a given route a driver may pick
-- A core element of one of the projects we were merging is finding POI along a route
-- To find POI, POI must be in this table

CREATE TABLE POI(
	POI_ID INT PRIMARY KEY,
	POI_Name NVARCHAR(50),
	POI_Add_Num INT,
	POI_Street NVARCHAR(50),
	POI_CITY NVARCHAR(50),
	POI_STATE VARCHAR(50),
	POI_ZIP int
);
GO

--Josh Keller end

--Ryan Sladic Start 
--Make AutoPart table

CREATE TABLE AutoPart
(
    PNum INT PRIMARY KEY,
    PManu VARCHAR(50),
    PCategory VARCHAR(50) CHECK (PCategory IN ('Mechanical', 'Cosmetic')),
    PCountry VARCHAR(50),
    PPrice INT,
    PDescription VARCHAR(50)
);

--Creating the VEHICLE table
-- Creating the VEHICLE table - RYAN SLADIC 
CREATE TABLE VEHICLE
(
    VIN INT PRIMARY KEY,
    VMake VARCHAR(50),
    VModel VARCHAR(50),
    VYear INT
);

-- End Ryan Sladic 
