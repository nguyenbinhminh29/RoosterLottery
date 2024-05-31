USE [master]
GO
/****** Object:  Database [ZRL_DEV]    Script Date: 31/05/2024 16:59:22 PM ******/
CREATE DATABASE [ZRL_DEV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZRL_DEV', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZRL_DEV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZRL_DEV_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ZRL_DEV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ZRL_DEV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZRL_DEV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZRL_DEV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZRL_DEV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZRL_DEV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZRL_DEV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZRL_DEV] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZRL_DEV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZRL_DEV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZRL_DEV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZRL_DEV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZRL_DEV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZRL_DEV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZRL_DEV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZRL_DEV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZRL_DEV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZRL_DEV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ZRL_DEV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZRL_DEV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZRL_DEV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZRL_DEV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZRL_DEV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZRL_DEV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZRL_DEV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZRL_DEV] SET RECOVERY FULL 
GO
ALTER DATABASE [ZRL_DEV] SET  MULTI_USER 
GO
ALTER DATABASE [ZRL_DEV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZRL_DEV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZRL_DEV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZRL_DEV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZRL_DEV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZRL_DEV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ZRL_DEV] SET QUERY_STORE = OFF
GO
USE [ZRL_DEV]
GO
/****** Object:  Table [dbo].[LotteryTransactions]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LotteryTransactions](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[OpeningTime] [datetime] NULL,
	[OpenedNumber] [int] NULL,
	[OpeningPeriod] [nvarchar](50) NULL,
 CONSTRAINT [PK_LotteryTransactions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Birthday] [date] NULL,
	[PhoneNo] [nvarchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[LastLoginDate] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTicket]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTicket](
	[ID] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[TicketNumber] [int] NULL,
	[PurchaseDate] [datetime] NULL,
	[LotteryPeriod] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserLottery] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'8949e039-5bdf-40ca-bd69-00eeb7d87dd5', N'ROOSTER_01', CAST(N'2024-05-30T13:00:00.417' AS DateTime), 5, N'2024053013')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'54ed09fa-897f-4a9a-b4b0-01f6afebe973', N'ROOSTER_01', CAST(N'2024-05-31T05:00:00.470' AS DateTime), 1, N'202405315')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'7fb3fe12-8941-4b4b-b92a-0b0c1002d82c', N'ROOSTER_01', CAST(N'2024-05-29T19:00:00.220' AS DateTime), 1, N'2024052919')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'14fa098f-d651-4818-9f4d-112a3beef569', N'ROOSTER_01', CAST(N'2024-05-30T15:00:00.400' AS DateTime), 4, N'2024053015')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'71823599-8220-4961-a008-160c78dd36b8', N'ROOSTER_01', CAST(N'2024-05-29T18:28:08.880' AS DateTime), 6, N'2024052918')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'a3b17676-0bd2-4093-bfce-174046392001', N'ROOSTER_01', CAST(N'2024-05-30T17:00:00.510' AS DateTime), 3, N'2024053017')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'ce1cedf0-682d-44db-947d-192b7dee2e6a', N'ROOSTER_01', CAST(N'2024-05-31T01:00:00.547' AS DateTime), 2, N'202405311')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'1f349579-0f45-40b5-88b0-1ebffcdf79b7', N'ROOSTER_01', CAST(N'2024-05-30T18:00:00.710' AS DateTime), 3, N'2024053018')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'f9b81fe9-2803-4578-b56e-23fc26e4e4f4', N'ROOSTER_01', CAST(N'2024-05-31T04:00:00.063' AS DateTime), 4, N'202405314')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'b64fb20c-57b7-4622-9eda-28c741ee0a81', N'ROOSTER_01', CAST(N'2024-05-31T02:00:00.603' AS DateTime), 7, N'202405312')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'd817d6d1-cc7b-453e-af7f-299bf72513db', N'ROOSTER_01', CAST(N'2024-05-31T10:00:00.200' AS DateTime), 9, N'2024053110')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'e7ad3d17-f8b2-4ab6-845e-3bcd544f76ae', N'ROOSTER_01', CAST(N'2024-05-31T12:00:00.110' AS DateTime), 2, N'2024053112')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'5f751a58-3a39-4244-8edc-4a2742ff91d9', N'ROOSTER_01', CAST(N'2024-05-31T09:00:00.263' AS DateTime), 7, N'202405319')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'b82b08fb-a244-4d73-9dd6-4d49b9109f6a', N'ROOSTER_01', CAST(N'2024-05-31T08:00:00.860' AS DateTime), 3, N'202405318')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'e276d2ef-2c37-4c4a-be14-507c795c0c0f', N'ROOSTER_01', CAST(N'2024-05-31T03:00:00.163' AS DateTime), 7, N'202405313')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'c41c5bd5-6282-40dc-bcb3-58976203296c', N'ROOSTER_01', CAST(N'2024-05-31T14:00:01.023' AS DateTime), 7, N'2024053114')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'c3ac8bf0-d1ba-4e26-9d37-58c296924048', N'ROOSTER_01', CAST(N'2024-05-30T22:00:00.603' AS DateTime), 9, N'2024053022')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'b3407a7c-5821-4082-a7b7-6c72a2dad557', N'ROOSTER_01', CAST(N'2024-05-31T11:00:00.430' AS DateTime), 2, N'2024053111')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'329c3bc4-fe3f-402d-b8b5-6ebe72111d73', N'ROOSTER_01', CAST(N'2024-05-30T23:00:00.933' AS DateTime), 2, N'2024053023')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'00cc7316-dfdf-4e42-9974-6fd4677a1b6e', N'ROOSTER_01', CAST(N'2024-05-31T07:00:00.113' AS DateTime), 9, N'202405317')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'1f0cd1f6-6bdb-41fe-88bd-70da668b8673', N'ROOSTER_01', CAST(N'2024-05-29T18:40:00.377' AS DateTime), 3, N'2024052918')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'8c90c230-89fe-4427-a22d-87f93229be94', N'ROOSTER_01', CAST(N'2024-05-31T00:00:00.903' AS DateTime), 7, N'202405310')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'e6a5f9e5-6b83-402c-88b4-8a5a77f15677', N'ROOSTER_01', CAST(N'2024-05-31T13:00:01.020' AS DateTime), 3, N'2024053113')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'0b37e99c-52f7-4b08-939e-8b3cbc0543e1', N'ROOSTER_01', CAST(N'2024-05-30T19:00:00.790' AS DateTime), 8, N'2024053019')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'ab87dc0c-03b0-44b0-8376-8c8f81c8e3bc', N'ROOSTER_01', CAST(N'2024-05-30T20:00:00.547' AS DateTime), 2, N'2024053020')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'1485f66c-e784-43c4-a64b-8de8eb742229', N'ROOSTER_01', CAST(N'2024-05-30T21:00:00.823' AS DateTime), 4, N'2024053021')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'd0f55906-eddf-470d-9ddf-ae1ddbf540e6', N'ROOSTER_01', CAST(N'2024-05-31T15:00:00.980' AS DateTime), 3, N'2024053115')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'9b95039e-5f8d-4180-a96b-ae52ba512bb0', N'ROOSTER_01', CAST(N'2024-05-29T18:50:00.693' AS DateTime), 1, N'2024052918')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'6202baf3-af9f-4a53-8f47-b3a36000f246', N'ROOSTER_01', CAST(N'2024-05-30T16:00:00.193' AS DateTime), 3, N'2024053016')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'453e1243-5cd4-45b2-9dcb-bc4a621d5a4a', N'ROOSTER_01', CAST(N'2024-05-31T06:00:00.433' AS DateTime), 7, N'202405316')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'4e7b5dd4-09cc-497d-8046-c3fc452981a8', N'ROOSTER_01', CAST(N'2024-05-31T17:00:00.157' AS DateTime), 6, N'2024053117')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'a96207d6-be81-4d4c-b825-ead0be2136ce', N'ROOSTER_01', CAST(N'2024-05-30T14:00:00.433' AS DateTime), 5, N'2024053014')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'c46cc1a7-aeb6-4dda-a93b-f5b74ac24610', N'ROOSTER_01', CAST(N'2024-05-29T18:32:19.690' AS DateTime), 5, N'2024052918')
GO
INSERT [dbo].[LotteryTransactions] ([ID], [Name], [OpeningTime], [OpenedNumber], [OpeningPeriod]) VALUES (N'0d37a5ec-fa0a-4daf-896b-ffd5652fb9cd', N'ROOSTER_01', CAST(N'2024-05-31T16:00:00.130' AS DateTime), 6, N'2024053116')
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'50430a5c-7ce8-419d-8163-25b4286cf449', N'sfdsf', CAST(N'2014-05-31' AS Date), N'0977752526', CAST(N'2024-05-31T17:50:49.083' AS DateTime), NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'8e87a3c5-6cf7-4c10-b58c-357b530053e8', N'Minh 1', CAST(N'1991-05-29' AS Date), N'0123456788', CAST(N'2024-05-29T16:34:47.737' AS DateTime), NULL)
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'7cf5c834-6a19-4a83-9be0-918e5815139c', N'24324sdffs', CAST(N'1991-05-29' AS Date), N'0123456787', CAST(N'2024-05-29T18:58:33.473' AS DateTime), CAST(N'2024-05-31T17:58:49.177' AS DateTime))
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'ec0fa9ce-5a1e-4e5d-b5e8-9a2450f43b56', N'Minh', CAST(N'1991-05-28' AS Date), N'0987634343', CAST(N'2024-05-28T19:16:36.567' AS DateTime), CAST(N'2024-05-31T17:58:28.670' AS DateTime))
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'a415cf03-04bd-49d9-a8dc-a28c21704fee', N'Minh', CAST(N'2024-05-15' AS Date), N'0123456789', CAST(N'2024-05-29T16:20:38.010' AS DateTime), CAST(N'2024-05-31T17:09:26.293' AS DateTime))
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'f3a9a08c-80c8-4916-872b-d813c82fa7cd', N'sfdsfds', CAST(N'2323-05-29' AS Date), N'2432543543', CAST(N'2024-05-29T16:37:57.590' AS DateTime), CAST(N'2024-05-31T17:59:04.750' AS DateTime))
GO
INSERT [dbo].[Users] ([Id], [Name], [Birthday], [PhoneNo], [CreatedDate], [LastLoginDate]) VALUES (N'b173b821-d63a-4283-8e59-f5e4feb61ee1', N'Tester1', CAST(N'2010-05-31' AS Date), N'0123456432', CAST(N'2024-05-31T17:44:52.477' AS DateTime), NULL)
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'e8691511-79ee-4205-bbeb-2625a754bc8c', N'50430a5c-7ce8-419d-8163-25b4286cf449', 1, CAST(N'2024-05-31T17:51:02.243' AS DateTime), N'2024053118')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'6d543ff2-515e-48f4-9e1e-41ed77bba3e0', N'a415cf03-04bd-49d9-a8dc-a28c21704fee', 2, CAST(N'2024-05-31T11:26:38.973' AS DateTime), N'2024053112')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'00d563f6-61a4-4494-8e38-8571ea06664e', N'f3a9a08c-80c8-4916-872b-d813c82fa7cd', 7, CAST(N'2024-05-31T17:59:09.137' AS DateTime), N'2024053118')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'56c4d9da-21e0-4e34-88f4-8f03e318908e', N'ec0fa9ce-5a1e-4e5d-b5e8-9a2450f43b56', 5, CAST(N'2024-05-31T17:51:28.097' AS DateTime), N'2024053118')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'512e2d9b-3008-465e-b6db-b2ae18bf30c4', N'a415cf03-04bd-49d9-a8dc-a28c21704fee', 3, CAST(N'2024-05-29T19:21:42.537' AS DateTime), N'2024052920')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'3acd2828-0733-4b5b-b071-b39f64eac234', N'a415cf03-04bd-49d9-a8dc-a28c21704fee', 9, CAST(N'2024-05-30T17:25:30.430' AS DateTime), N'2024053018')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'e7ef843c-5aa3-42e5-a660-c5c8dbf44cf2', N'a415cf03-04bd-49d9-a8dc-a28c21704fee', 2, CAST(N'2024-05-29T19:14:59.057' AS DateTime), N'2024052920')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'2aa19e6a-695d-4016-a1b3-c61b19029b3b', N'7cf5c834-6a19-4a83-9be0-918e5815139c', 5, CAST(N'2024-05-31T17:58:54.070' AS DateTime), N'2024053118')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'a7012695-90e9-44c3-ac3b-c933a91d52a3', N'a415cf03-04bd-49d9-a8dc-a28c21704fee', 8, CAST(N'2024-05-30T18:02:12.373' AS DateTime), N'2024053019')
GO
INSERT [dbo].[UserTicket] ([ID], [UserId], [TicketNumber], [PurchaseDate], [LotteryPeriod]) VALUES (N'dd92648c-fafe-4cd5-987c-f61516a807c8', N'7cf5c834-6a19-4a83-9be0-918e5815139c', 2, CAST(N'2024-05-30T18:32:48.357' AS DateTime), N'2024053019')
GO
ALTER TABLE [dbo].[LotteryTransactions] ADD  CONSTRAINT [DF_LotteryTransactions_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[UserTicket] ADD  CONSTRAINT [DF_UserLottery_ID]  DEFAULT (newid()) FOR [ID]
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_LotteryTrans]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_LotteryTrans] 
	-- Add the parameters for the stored procedure here
	@OpenDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Name]
		,[OpeningTime]
		,[OpenedNumber]
		,[OpeningPeriod]
	FROM [dbo].[LotteryTransactions]
	WHERE CONVERT(nvarchar, OpeningTime, 112) = CONVERT(nvarchar, ISNULL(@OpenDate, GETDATE()), 112)
	ORDER BY OpeningTime DESC

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_MonitoringLotteryNumber]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_MonitoringLotteryNumber] 
	-- Add the parameters for the stored procedure here
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	--SELECT [Name], OpenedNumber
	--FROM LotteryTransactions
	--WHERE CONVERT(nvarchar, OpeningTime, 112) = '20240531' 

	SELECT [Name]
		, OpenedNumber AS Argument
		, COUNT(OpenedNumber) AS 'Value'
		, '' AS Color
		, '' AS Remark
	FROM LotteryTransactions
	WHERE CONVERT(nvarchar, OpeningTime, 112) >= CONVERT(nvarchar, @FromDate, 112)
	AND CONVERT(nvarchar, OpeningTime, 112) <= CONVERT(nvarchar, @ToDate, 112)
	GROUP BY [Name], OpenedNumber

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_MonitoringLotteryUserTicket]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_MonitoringLotteryUserTicket] 
	-- Add the parameters for the stored procedure here
	@FromDate date,
	@ToDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT 'Read' AS Name, 'Loop' AS Argument, 3 AS Value
	
	-- count new user
	SELECT 'New User' AS Name 
		,CONVERT(nvarchar, CreatedDate, 107) AS Argument
		, COUNT(CreatedDate) AS Value
	FROM Users
	WHERE CONVERT(nvarchar, CreatedDate, 112) >= CONVERT(nvarchar, @FromDate, 112)
	AND CONVERT(nvarchar, CreatedDate, 112) <= CONVERT(nvarchar, @ToDate, 112)
	GROUP BY CONVERT(nvarchar, CreatedDate, 107)

	-- count purchase number
	SELECT 'Purchase Number' AS Name
		, CONVERT(nvarchar, PurchaseDate, 107) AS Argument
		, COUNT(PurchaseDate) AS Value
	FROM UserTicket
	WHERE CONVERT(nvarchar, PurchaseDate, 112) >= CONVERT(nvarchar, @FromDate, 112)
	AND CONVERT(nvarchar, PurchaseDate, 112) <= CONVERT(nvarchar, @ToDate, 112)
	GROUP BY CONVERT(nvarchar, PurchaseDate, 107)

	-- count number win
	SELECT	'User Win' AS Name
		, CONVERT(nvarchar, T.OpeningTime, 107) AS Argument 
		, COUNT(OpeningTime) AS Value
	FROM LotteryTransactions T
	LEFT JOIN UserTicket U ON T.OpeningPeriod = U.LotteryPeriod
	WHERE T.OpenedNumber = U.TicketNumber
	AND CONVERT(nvarchar, OpeningTime, 112) >= CONVERT(nvarchar, @FromDate, 112)
	AND CONVERT(nvarchar, OpeningTime, 112) <= CONVERT(nvarchar, @ToDate, 112)
	GROUP BY CONVERT(nvarchar, OpeningTime, 107)

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_NextLotteryPeriod]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_NextLotteryPeriod]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	CREATE TABLE #NextLotteryTemp
	(
		OpeningPeriod nvarchar(50),
		OpeningTime datetime
	)

	--INSERT INTO #NextLotteryTemp
	--SELECT CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) - 1 AS nvarchar) AS OpeningPeriod
	--	, DATEADD(HOUR, -1, GETDATE()) AS OpeningTime

	--INSERT INTO #NextLotteryTemp
	--SELECT CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) + 0 AS nvarchar) AS OpeningPeriod
	--	, DATEADD(HOUR, 0, GETDATE()) AS OpeningTime

	INSERT INTO #NextLotteryTemp
	SELECT CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) + 1 AS nvarchar) AS OpeningPeriod
		, DATEADD(HOUR, 1, GETDATE()) AS OpeningTime

	--INSERT INTO #NextLotteryTemp
	--SELECT CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) + 2 AS nvarchar) AS OpeningPeriod
	--	, DATEADD(HOUR, 2, GETDATE()) AS OpeningTime

	--INSERT INTO #NextLotteryTemp
	--SELECT CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) + 3 AS nvarchar) AS OpeningPeriod
	--	, DATEADD(HOUR, 3, GETDATE()) AS OpeningTime


	SELECT * FROM #NextLotteryTemp

	IF (OBJECT_ID('tempdb..#NextLotteryTemp') IS NOT NULL)
	BEGIN
		DROP TABLE #NextLotteryTemp
	END

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_UserByPhone]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_UserByPhone]
	-- Add the parameters for the stored procedure here
	@PhoneNo nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Id]
		  ,[Name]
		  ,[Birthday]
		  ,[PhoneNo]
		  ,[CreatedDate]
		  ,[LastLoginDate]
	FROM [dbo].[Users] WITH(NOLOCK)
	WHERE PhoneNo = @PhoneNo;

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_UserTicket]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_UserTicket]
	-- Add the parameters for the stored procedure here
	@PhoneNo nvarchar(20),
	@PurchaseDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT T.[TicketNumber]
		,T.[PurchaseDate]
		,T.[LotteryPeriod]
		,U.PhoneNo
		,CASE WHEN T.[TicketNumber] = L.OpenedNumber THEN 'X' ELSE '' END AS 'Winned'
	FROM [dbo].[UserTicket] T
	INNER JOIN [Users] U ON T.UserId = U.Id
	LEFT JOIN [LotteryTransactions] L ON T.LotteryPeriod = L.OpeningPeriod
	WHERE U.PhoneNo = @PhoneNo
	AND CONVERT(nvarchar, T.PurchaseDate, 112) = CONVERT(nvarchar, ISNULL(@PurchaseDate, GETDATE()), 112)

END
GO
/****** Object:  StoredProcedure [dbo].[USP_INSERT_NewUser]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_INSERT_NewUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(100),
	@Birthday date,
	@PhoneNo nvarchar(20)
AS
BEGIN TRANSACTION
	BEGIN
		SET NOCOUNT ON;
		DECLARE @ErrCode int = 0 -- Error code
		DECLARE @ErrMsg nvarchar(1000) = 'Register user successfully.' -- Error message
		DECLARE @RCount int = 1

		IF LEN(@PhoneNo) > 10 OR LEN(@PhoneNo) < 10 OR LEFT(@PhoneNo, 1) <> '0'
		BEGIN
			Set @ErrCode = -2; Set @ErrMsg = 'Phone number is incorrect.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END

		SET @RCount = (SELECT COUNT(*) FROM [dbo].[Users] WHERE PhoneNo = @PhoneNo)

		IF @RCount > 0
		BEGIN
			Set @ErrCode = -1; Set @ErrMsg = 'User already exists.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END

		INSERT INTO [dbo].[Users]
           ([Name]
           ,[Birthday]
           ,[PhoneNo]
           ,[CreatedDate])
		VALUES
           (@Name
           ,@Birthday
           ,@PhoneNo
           ,GETDATE())

		If @@ERROR <> 0 
			Begin
				Set @ErrCode = @@ERROR; Set @ErrMsg = ERROR_MESSAGE();
				Goto HANDLE_ERROR --> Roll back when execute failed ...
			End
		-- ==========================================================================================================================
	END 
-- Commit transaction ===============================================================================================================
COMMIT TRANSACTION
	SELECT @ErrCode AS ErrCode, @ErrMsg AS ErrMsg, @RCount AS RCount;
	RETURN @@ROWCOUNT
-- Error transaction ================================================================================================================
HANDLE_ERROR:
	ROLLBACK TRANSACTION
	SELECT @ErrCode AS ErrCode, @ErrMsg AS ErrMsg, @@ROWCOUNT AS RCount;
	RETURN @@ERROR
--===================================================================================================================================
GO
/****** Object:  StoredProcedure [dbo].[USP_INSERT_UserTicket]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_INSERT_UserTicket]
	-- Add the parameters for the stored procedure here
	@PhoneNo nvarchar(20),
	@TicketNum int,
	@LotteryPeriod nvarchar(50)
AS
BEGIN TRANSACTION
	BEGIN
		SET NOCOUNT ON;
		DECLARE @ErrCode int = 0 -- Error code
		DECLARE @ErrMsg nvarchar(1000) = 'Create user ticket successfully.' -- Error message
		DECLARE @RCount int = 1
		DECLARE @CountUser int
		DECLARE @CountSlot int
		DECLARE @Period nvarchar(50)

		

		--Check range--------------
		IF @TicketNum < 0 OR @TicketNum > 9
		BEGIN
			Set @ErrCode = -1; Set @ErrMsg = 'The ticket number must be within the range 0 to 9.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END

		--Check user--------------------------
		SET @CountUser = (SELECT COUNT(Id) FROM [dbo].[Users] WHERE PhoneNo = @PhoneNo)

		IF @CountUser <= 0
		BEGIN
			Set @ErrCode = -2; Set @ErrMsg = 'User does not exist.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END

		--Check period-----------------------------
		SET @Period = (CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) + 1 AS nvarchar))

		IF ISNULL(@LotteryPeriod, '') != '' AND  @Period != @LotteryPeriod
		BEGIN
			Set @ErrCode = -3; Set @ErrMsg = 'Cannot set numbers for this period.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END

		--Check slot-------------------------------
		SET @CountSlot = (SELECT COUNT(T.UserId)
						FROM [dbo].[UserTicket] T
						INNER JOIN [dbo].[Users] U ON T.UserId = U.Id
						WHERE U.PhoneNo = @PhoneNo AND T.LotteryPeriod = @LotteryPeriod)

		IF @CountSlot >= 1
		BEGIN
			Set @ErrCode = -4; Set @ErrMsg = 'The phone number has exceeded the number placed for the lottery slot.';
			Goto HANDLE_ERROR --> Roll back when execute failed ...
		END


		INSERT INTO [dbo].[UserTicket]
           ([UserId]
           ,[TicketNumber]
           ,[PurchaseDate]
		   ,[LotteryPeriod])
		SELECT TOP 1 Id
			, @TicketNum
			, GETDATE()
			, @LotteryPeriod
		FROM [dbo].[Users] WHERE PhoneNo = @PhoneNo

		If @@ERROR <> 0 
			Begin
				Set @ErrCode = @@ERROR; Set @ErrMsg = ERROR_MESSAGE();
				Goto HANDLE_ERROR --> Roll back when execute failed ...
			End
		-- ==========================================================================================================================
	END 
-- Commit transaction ===============================================================================================================
COMMIT TRANSACTION
	SELECT @ErrCode AS ErrCode, @ErrMsg AS ErrMsg, @RCount AS RCount;
	RETURN @@ROWCOUNT
-- Error transaction ================================================================================================================
HANDLE_ERROR:
	ROLLBACK TRANSACTION
	SELECT @ErrCode AS ErrCode, @ErrMsg AS ErrMsg, @@ROWCOUNT AS RCount;
	RETURN @@ERROR
--===================================================================================================================================
GO
/****** Object:  StoredProcedure [dbo].[USP_LotteryStart]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_LotteryStart] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[LotteryTransactions]
           ([Name]
           ,[OpeningTime]
           ,[OpenedNumber]
           ,[OpeningPeriod])

     SELECT 'ROOSTER_01'
           ,GETDATE()
           ,FLOOR(RAND() * (10))
           ,CONVERT(nvarchar, GETDATE(), 112) + CAST(DATEPART(Hour, GetDate()) AS nvarchar)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UPDATE_UserLogin]    Script Date: 31/05/2024 16:59:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_UPDATE_UserLogin]
	-- Add the parameters for the stored procedure here
	@PhoneNo nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Users SET LastLoginDate = GETDATE() WHERE PhoneNo = @PhoneNo;

END
GO
USE [master]
GO
ALTER DATABASE [ZRL_DEV] SET  READ_WRITE 
GO
