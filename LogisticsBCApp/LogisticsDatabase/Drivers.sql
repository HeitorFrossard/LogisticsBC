CREATE TABLE [dbo].[Drivers]
(
	[DriverId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DriverName] NCHAR(30) NOT NULL, 
    [TotalEarnings] DECIMAL(18, 2) NOT NULL 
)
