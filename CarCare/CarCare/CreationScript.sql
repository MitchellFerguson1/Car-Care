USE [master]
GO
/****** Object:  Database [CarCare]    Script Date: 5/9/2019 1:15:33 PM ******/
CREATE DATABASE [CarCare]
GO
USE [CarCare]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 5/9/2019 1:15:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[carId] [int] IDENTITY(1,1) NOT NULL,
	[custId] [int] NOT NULL,
	[license] [varchar](20) NOT NULL,
	[make] [varchar](20) NOT NULL,
	[model] [varchar](20) NOT NULL,
	[year] [int] NOT NULL,
	[repairId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[carId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[license] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[custId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[custId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repairs]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repairs](
	[repairId] [int] IDENTITY(1,1) NOT NULL,
	[carId] [int] NOT NULL,
	[repairDetails] [varchar](max) NOT NULL,
	[repairCost] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[repairId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT ('') FOR [address]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Car_ToCustomer] FOREIGN KEY([custId])
REFERENCES [dbo].[Customers] ([custId])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Car_ToCustomer]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Car_ToRepair] FOREIGN KEY([repairId])
REFERENCES [dbo].[Repairs] ([repairId])
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Car_ToRepair]
GO
/****** Object:  StoredProcedure [dbo].[AddNewCar]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewCar]
	@name VARCHAR(50),
	@address VARCHAR(100),
	@make VARCHAR(20),
	@model VARCHAR(20),
	@year INT,
	@license VARCHAR(20)
AS
	INSERT INTO Cars(make, model, year, license, custId)
		VALUES(@make, @model, @year, @license, (SELECT custId FROM Customers WHERE name = @name AND @address = address))
GO
/****** Object:  StoredProcedure [dbo].[AddNewCust]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewCust]
	@name VARCHAR(50),
	@address VARCHAR(100)
AS
	INSERT INTO Customers(name, address) VALUES (@name, @address)
GO
/****** Object:  StoredProcedure [dbo].[DeleteCar]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCar]
	@carID INT
AS
	DELETE FROM Repairs WHERE carId = @carID
	DELETE FROM Cars WHERE carId = @carID
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer]
	@custID INT
AS
	DELETE FROM Repairs WHERE carId IN (SELECT	carId
										FROM	Cars
										WHERE	custId = @custId)
	DELETE FROM Cars WHERE custId = @custID
	DELETE FROM Customers WHERE custId = @custID
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomers]
AS
	SELECT	custId,
			name,
			address
	FROM	Customers
GO
/****** Object:  StoredProcedure [dbo].[updateCustomer]    Script Date: 5/9/2019 1:15:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateCustomer]
	@custId INT,
	@newName VARCHAR(50),
	@newAddress VARCHAR(100)
AS
	UPDATE	Customers
	SET		name = @newName, address = @newAddress
	WHERE	custId = @custId
GO
USE [master]
GO
ALTER DATABASE [CarCare] SET  READ_WRITE 
GO
