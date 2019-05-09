USE [master]
GO
/****** Object:  Database [CarCare]    Script Date: 5/9/2019 1:15:33 PM ******/
CREATE DATABASE [CarCare]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarCare', FILENAME = N'C:\Users\nowhe\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\CarCare.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarCare_log', FILENAME = N'C:\Users\nowhe\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\CarCare.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarCare] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarCare].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarCare] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [CarCare] SET ANSI_NULLS ON 
GO
ALTER DATABASE [CarCare] SET ANSI_PADDING ON 
GO
ALTER DATABASE [CarCare] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [CarCare] SET ARITHABORT ON 
GO
ALTER DATABASE [CarCare] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarCare] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarCare] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarCare] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarCare] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [CarCare] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [CarCare] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarCare] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [CarCare] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarCare] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarCare] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarCare] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarCare] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarCare] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarCare] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarCare] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarCare] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarCare] SET RECOVERY FULL 
GO
ALTER DATABASE [CarCare] SET  MULTI_USER 
GO
ALTER DATABASE [CarCare] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarCare] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarCare] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarCare] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarCare] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarCare] SET QUERY_STORE = OFF
GO
USE [CarCare]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
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
