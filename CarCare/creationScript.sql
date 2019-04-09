--Mitchell Ferguson
USE master
GO
DROP DATABASE IF EXISTS fergusmw --Only for testing
GO
CREATE DATABASE fergusmw
GO

USE fergusmw
GO

CREATE TABLE Customers(
	[custID] INT PRIMARY KEY IDENTITY,
	[name] VARCHAR(50) NOT NULL,
	[address] VARCHAR(100) NOT NULL
)

CREATE TABLE Cars(
	[carID]	INT	PRIMARY KEY	IDENTITY,
	[custID] INT NOT NULL,
	[license] VARCHAR(20) NOT NULL,
	[make] VARCHAR(20) NOT NULL,
	[model] VARCHAR(20) NOT NULL,
	[year] INT NOT NULL,
	[repairID] INT
	FOREIGN KEY (custID) REFERENCES Customers(custID)
)

CREATE TABLE Repairs(
	[repairID] INT PRIMARY KEY IDENTITY,
	[carID] INT NOT NULL,
	[repairDetails] VARCHAR NOT NULL DEFAULT 'N/A',
	[repairCost] FLOAT NOT NULL DEFAULT '0.00'
	FOREIGN KEY (carID) REFERENCES Cars(carID)
)