CREATE TABLE [dbo].[Packages]
(
	[PackageId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerName] NCHAR(30) NOT NULL, 
    [Address] NCHAR(30) NOT NULL, 
    [AreaId] INT NOT NULL, 
    [Weight] DECIMAL(18, 2) NOT NULL, 
    [DeliveryDate] DATETIME NOT NULL, 
    [StatusDelivered] BIT NOT NULL
)
