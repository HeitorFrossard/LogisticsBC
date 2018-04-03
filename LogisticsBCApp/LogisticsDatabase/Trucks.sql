CREATE TABLE [dbo].[Trucks]
(
	[TruckId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MaxLoad] DECIMAL(18, 2) NOT NULL, 
    [CurrentLoad] DECIMAL(18, 2) NOT NULL, 
    [AreaId] INT NOT NULL, 
    [DriverId] INT NOT NULL
)
