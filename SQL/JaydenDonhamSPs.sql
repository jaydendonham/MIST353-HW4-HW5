use MIST353A3
go

create or alter proc spGetAllOccupations
as
begin
	select Position, Wage from Occupation
end
go

--exec spGetAllOccupations

create or alter proc spAddLocation
(@state nvarchar(25), @city nvarchar(25), @zip nvarchar(25))
as
begin
	insert into Location (State, City, Zip)
	values (@state, @city, @zip)
end
go

--exec spAddLocation 'New York', 'New York City', '10001'