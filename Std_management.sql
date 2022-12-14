USE [master]
GO
/****** Object:  Database [Std_management]    Script Date: 10/26/2022 10:33:54 AM ******/
CREATE DATABASE [Std_management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Std_management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Std_management.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Std_management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Std_management_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Std_management] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Std_management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Std_management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Std_management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Std_management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Std_management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Std_management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Std_management] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Std_management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Std_management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Std_management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Std_management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Std_management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Std_management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Std_management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Std_management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Std_management] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Std_management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Std_management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Std_management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Std_management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Std_management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Std_management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Std_management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Std_management] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Std_management] SET  MULTI_USER 
GO
ALTER DATABASE [Std_management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Std_management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Std_management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Std_management] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Std_management] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Std_management]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Account_ID] [char](6) NOT NULL,
	[Username] [varchar](10) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[User_ID] [char](8) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Account_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class](
	[Class_ID] [char](6) NOT NULL,
	[Class_Name] [varchar](6) NOT NULL,
	[Number_Of_Student] [int] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[Class_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class_Student]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class_Student](
	[Class_Student_ID] [int] IDENTITY(1,1) NOT NULL,
	[Class_ID] [char](6) NOT NULL,
	[Student_ID] [char](8) NOT NULL,
 CONSTRAINT [PK_Class_Student] PRIMARY KEY CLUSTERED 
(
	[Class_Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Class_Subject]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Class_Subject](
	[Class_Subject_ID] [int] IDENTITY(1,1) NOT NULL,
	[Class_ID] [char](6) NOT NULL,
	[Subject_Teacher_ID] [int] NULL,
 CONSTRAINT [PK_Class_Subject] PRIMARY KEY CLUSTERED 
(
	[Class_Subject_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Major]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Major](
	[Major_ID] [char](6) NOT NULL,
	[Major_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[Major_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Major_Subject]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Major_Subject](
	[Major_Subject_ID] [int] IDENTITY(1,1) NOT NULL,
	[Subject_ID] [char](6) NOT NULL,
	[Major_ID] [char](6) NOT NULL,
 CONSTRAINT [PK_Major_Subject] PRIMARY KEY CLUSTERED 
(
	[Major_Subject_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mark](
	[Mark_ID] [int] IDENTITY(1,1) NOT NULL,
	[Student_ID] [char](8) NOT NULL,
	[Subject_Teacher_ID] [int] NOT NULL,
	[Score] [float] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Mark] PRIMARY KEY CLUSTERED 
(
	[Mark_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[Role_ID] [char](2) NOT NULL,
	[Role_Name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Role_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
	[Subject_ID] [char](6) NOT NULL,
	[Subject_Name] [varchar](100) NOT NULL,
	[Number_Of_Credits] [int] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Subject_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject_Teacher]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject_Teacher](
	[Subject_Teacher_ID] [int] IDENTITY(1,1) NOT NULL,
	[Teacher_ID] [char](8) NOT NULL,
	[Subject_ID] [char](6) NOT NULL,
 CONSTRAINT [PK_Subject_Teacher] PRIMARY KEY CLUSTERED 
(
	[Subject_Teacher_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/26/2022 10:33:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[User_ID] [char](8) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
	[Phone] [char](10) NULL,
	[Email] [varchar](50) NOT NULL,
	[Address] [nvarchar](250) NOT NULL,
	[Picture] [text] NULL,
	[Status] [bit] NOT NULL CONSTRAINT [df_Status]  DEFAULT ((1)),
	[Role_ID] [char](2) NOT NULL,
	[Major_ID] [char](6) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'1     ', N'admin', N'123', N'TE0002  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'10    ', N'SS170457', N'123', N'SS170457')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'11    ', N'SS170468', N'123', N'SS170468')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'12    ', N'TE0001', N'123', N'TE0001  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'13    ', N'TE0003', N'123', N'TE0003  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'14    ', N'TE0004', N'123', N'TE0004  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'15    ', N'TE0005', N'123', N'TE0005  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'16    ', N'TE0006', N'123', N'TE0006  ')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'2     ', N'SE140876', N'123', N'SE140876')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'3     ', N'SE150818', N'123', N'SE150818')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'4     ', N'SE160144', N'123', N'SE160144')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'5     ', N'SE170186', N'123', N'SE170186')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'6     ', N'SE170456', N'123', N'SE170456')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'7     ', N'SE170478', N'123', N'SE170478')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'8     ', N'SS160463', N'123', N'SS160463')
INSERT [dbo].[Account] ([Account_ID], [Username], [Password], [User_ID]) VALUES (N'9     ', N'SS170074', N'123', N'SS170074')
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SE1601', N'SE', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SE1602', N'SE', 3)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SE1603', N'SE', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SE1604', N'SE', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SE1605', N'SE', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SS1601', N'IB', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SS1602', N'IB', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SS1603', N'IB', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SS1604', N'IB', 30)
INSERT [dbo].[Class] ([Class_ID], [Class_Name], [Number_Of_Student]) VALUES (N'SS1605', N'IB', 30)
SET IDENTITY_INSERT [dbo].[Class_Student] ON 

INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (13, N'SE1602', N'SE140876')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (19, N'SE1602', N'SE150818')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (20, N'SE1602', N'SE170186')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (21, N'SE1602', N'SE160144')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (22, N'SE1602', N'SE170456')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (25, N'SE1604', N'SE170186')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (26, N'SE1604', N'SE140876')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (27, N'SE1604', N'SE150818')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (28, N'SE1604', N'SE160144')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (29, N'SE1604', N'SE170478')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (30, N'SE1604', N'SE170456')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (31, N'SS1601', N'SS160463')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (32, N'SS1601', N'SS170074')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (33, N'SS1601', N'SS170457')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (34, N'SS1601', N'SS170468')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (35, N'SS1605', N'SS160463')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (36, N'SS1605', N'SS170074')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (37, N'SS1605', N'SS170457')
INSERT [dbo].[Class_Student] ([Class_Student_ID], [Class_ID], [Student_ID]) VALUES (38, N'SS1605', N'SS170468')
SET IDENTITY_INSERT [dbo].[Class_Student] OFF
SET IDENTITY_INSERT [dbo].[Class_Subject] ON 

INSERT [dbo].[Class_Subject] ([Class_Subject_ID], [Class_ID], [Subject_Teacher_ID]) VALUES (1, N'SE1602', 1)
INSERT [dbo].[Class_Subject] ([Class_Subject_ID], [Class_ID], [Subject_Teacher_ID]) VALUES (2, N'SE1604', 5)
INSERT [dbo].[Class_Subject] ([Class_Subject_ID], [Class_ID], [Subject_Teacher_ID]) VALUES (3, N'SS1601', 16)
SET IDENTITY_INSERT [dbo].[Class_Subject] OFF
INSERT [dbo].[Major] ([Major_ID], [Major_Name]) VALUES (N'IB    ', N'International Bussiness')
INSERT [dbo].[Major] ([Major_ID], [Major_Name]) VALUES (N'SE    ', N'Software Engineering')
SET IDENTITY_INSERT [dbo].[Major_Subject] ON 

INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (1, N'DBI202', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (2, N'FER201', N'IB    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (3, N'MAD101', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (4, N'MAE101', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (5, N'MAS202', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (6, N'MAS291', N'IB    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (7, N'PRF192', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (8, N'PRN211', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (9, N'PRO192', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (10, N'SWP391', N'SE    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (11, N'SWR302', N'IB    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (12, N'SWT301', N'IB    ')
INSERT [dbo].[Major_Subject] ([Major_Subject_ID], [Subject_ID], [Major_ID]) VALUES (13, N'ENM211', N'IB    ')
SET IDENTITY_INSERT [dbo].[Major_Subject] OFF
SET IDENTITY_INSERT [dbo].[Mark] ON 

INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (1, N'SE140876', 1, 10, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (2, N'SE150818', 1, 7, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (3, N'SE160144', 1, 6, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (4, N'SE170186', 1, 7, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (5, N'SE170456', 1, 8, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (6, N'SE170186', 5, 9, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (7, N'SE140876', 5, 8, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (8, N'SE150818', 5, 5, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (9, N'SE160144', 5, 10, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (10, N'SE170478', 5, 3, 0)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (11, N'SE170456', 5, 4, 0)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (12, N'SS160463', 16, 8, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (13, N'SS170074', 16, 8, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (14, N'SS170457', 16, 8.5, 1)
INSERT [dbo].[Mark] ([Mark_ID], [Student_ID], [Subject_Teacher_ID], [Score], [Status]) VALUES (15, N'SS170468', 16, 8.5, 1)
SET IDENTITY_INSERT [dbo].[Mark] OFF
INSERT [dbo].[Role] ([Role_ID], [Role_Name]) VALUES (N'AD', N'Admin')
INSERT [dbo].[Role] ([Role_ID], [Role_Name]) VALUES (N'ST', N'Student')
INSERT [dbo].[Role] ([Role_ID], [Role_Name]) VALUES (N'TC', N'Teacher')
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'DBI202', N'Introduction to Databases', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'ENM211', N'Pre-Intermediate Business English 1', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'FER201', N'dau xanh rau ma', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'MAD101', N'Discrete mathematics', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'MAE101', N'Mathematics for Engineering', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'MAS202', N'Applied Statistics for Business', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'MAS291', N'Statistics & Probability', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'PRF192', N'Programming Fundamentals', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'PRN211', N'Basic Cross-Platform Application Programming With .NET', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'PRO192', N'Object-Oriented Programming', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'SWP391', N'Application development project', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'SWR302', N'Software Requirement', 3)
INSERT [dbo].[Subject] ([Subject_ID], [Subject_Name], [Number_Of_Credits]) VALUES (N'SWT301', N'Software Testing', 3)
SET IDENTITY_INSERT [dbo].[Subject_Teacher] ON 

INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (1, N'TE0001  ', N'DBI202')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (2, N'TE0001  ', N'FER201')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (3, N'TE0002  ', N'MAD101')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (4, N'TE0002  ', N'MAE101')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (5, N'TE0003  ', N'MAS202')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (6, N'TE0003  ', N'MAS291')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (7, N'TE0004  ', N'PRF192')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (8, N'TE0004  ', N'PRN211')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (9, N'TE0005  ', N'PRO192')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (10, N'TE0005  ', N'SWP391')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (11, N'TE0004  ', N'SWR302')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (12, N'TE0001  ', N'SWT301')
INSERT [dbo].[Subject_Teacher] ([Subject_Teacher_ID], [Teacher_ID], [Subject_ID]) VALUES (16, N'TE0006  ', N'ENM211')
SET IDENTITY_INSERT [dbo].[Subject_Teacher] OFF
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE140876', N'Tran', N'Doanh', CAST(N'2001-01-02' AS Date), 0, N'0955544436', N'doanhtqse140876@fpt.edu.vn', N'6778 Ila Alley', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE150818', N'Tran', N'Huy', CAST(N'2001-01-02' AS Date), 0, N'0955544450', N'huycgse150818@fpt.edu.vn', N'11918 Wanda Fields', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE160144', N'Do', N'Hoang', CAST(N'2001-01-02' AS Date), 0, N'0755524041', N'hoangvmse160144@fpt.edu.vn', N'31724 Irving Knolls', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE170186', N'Le', N'Phuong', CAST(N'2001-01-02' AS Date), 1, N'0555550773', N'PhuongDTSE170186@fpt.edu.vn', N'425 Kuhn Throughway', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE170456', N'Hoang', N'Han', CAST(N'2001-01-02' AS Date), 1, N'0755590971', N'HanNHGSE170456@fpt.edu.vn', N'40343 Ursula Underpass', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SE170478', N'Le', N'Duy', CAST(N'2001-01-02' AS Date), 0, N'0555500008', N'DuyNDASE170478@fpt.edu.vn', N'6301 Ismael Plain', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SS160463', N'Ho', N'Nam', CAST(N'2001-01-02' AS Date), 0, N'0955583885', N'namnhss160463@fpt.edu.vn', N'920 Ismael Lake', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'IB    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SS170074', N'Pham', N'Trang', CAST(N'2001-01-02' AS Date), 1, N'0355530844', N'TrangNPHSS170074@fpt.edu.vn', N'236 Kaitlin Prairie', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'IB    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SS170457', N'Pham', N'Tien', CAST(N'2001-01-02' AS Date), 0, N'0755511618', N'TienVMSS170457@fpt.edu.vn', N'417 Weissnat Haven', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'IB    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'SS170468', N'Tran', N'Huy', CAST(N'2001-01-02' AS Date), 0, N'0555526585', N'HuyPQSS170468@fpt.edu.vn', N'5195 Reynold Square', N'https://i.pinimg.com/736x/b1/5e/ed/b15eedbdafbbdbca3249e3942f4faf3b.jpg', 1, N'ST', N'IB    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0001  ', N'Nguyễn', N'Thế Hoàng', CAST(N'1976-01-20' AS Date), 0, N'0791234567', N'HoangNT@fu.edu.vn', N'Phu Nhuan', N'https://zix.vn/data/avatars/h/44/44768.jpg?1590308705', 1, N'TC', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0002  ', N'Trương', N'Long', CAST(N'1992-08-18' AS Date), 0, N'0791285267', N'LongT@fu.edu.vn', N'Binh Thanh', N'https://cdn.lazi.vn/storage/uploads/users/avatar/89511_1530418635.jpg', 1, N'AD', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0003  ', N'Nguyễn', N'Thị Kiều Ân', CAST(N'1994-07-20' AS Date), 1, N'0986234567', N'AnNTK@fu.edu.vn', N'Thu Duc', N'https://cdn.lazi.vn/storage/uploads/users/avatar/273850_1571841685.jpg', 1, N'TC', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0004  ', N'Nguyễn', N'Minh Sang', CAST(N'1990-08-15' AS Date), 0, N'0365234567', N'SangNM@fu.edu.vn', N'Hoc Mon', N'https://i.pinimg.com/originals/69/a5/60/69a5602fb6377d1fef9bb45e8db9e415.jpg', 1, N'TC', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0005  ', N'Nguyễn', N'Nguyên Bình', CAST(N'1976-02-28' AS Date), 0, N'0791222667', N'BinhNN7@fe.edu.vn', N'Quan 9', N'https://www.facebook.com/photo/?fbid=10159870536641108&set=a.10151911504736108', 1, N'TC', N'SE    ')
INSERT [dbo].[User] ([User_ID], [First_Name], [Last_Name], [BirthDate], [Gender], [Phone], [Email], [Address], [Picture], [Status], [Role_ID], [Major_ID]) VALUES (N'TE0006  ', N'Nguyễn', N'Thị Ánh', CAST(N'1997-02-20' AS Date), 0, N'0791220001', N'AnhNT@fe.edu.vn', N'Quan 10', N'https://www.facebook.com/photo/?fbid=10159870536641108&set=a.10151911504736108', 1, N'TC', N'IB    ')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_User_Email]    Script Date: 10/26/2022 10:33:54 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UQ_User_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_User_Phone]    Script Date: 10/26/2022 10:33:54 AM ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [UQ_User_Phone] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_User_ID] FOREIGN KEY([User_ID])
REFERENCES [dbo].[User] ([User_ID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_User_ID]
GO
ALTER TABLE [dbo].[Class_Student]  WITH CHECK ADD  CONSTRAINT [FK_Class_Student_ClassID_Class_ClassID] FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Class] ([Class_ID])
GO
ALTER TABLE [dbo].[Class_Student] CHECK CONSTRAINT [FK_Class_Student_ClassID_Class_ClassID]
GO
ALTER TABLE [dbo].[Class_Student]  WITH CHECK ADD  CONSTRAINT [FK_Class_Student_StudentID_Student_StudentID] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[User] ([User_ID])
GO
ALTER TABLE [dbo].[Class_Student] CHECK CONSTRAINT [FK_Class_Student_StudentID_Student_StudentID]
GO
ALTER TABLE [dbo].[Class_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Class_Subject_ClassID_Class_ClassID] FOREIGN KEY([Class_ID])
REFERENCES [dbo].[Class] ([Class_ID])
GO
ALTER TABLE [dbo].[Class_Subject] CHECK CONSTRAINT [FK_Class_Subject_ClassID_Class_ClassID]
GO
ALTER TABLE [dbo].[Class_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Class_Subject_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID] FOREIGN KEY([Subject_Teacher_ID])
REFERENCES [dbo].[Subject_Teacher] ([Subject_Teacher_ID])
GO
ALTER TABLE [dbo].[Class_Subject] CHECK CONSTRAINT [FK_Class_Subject_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID]
GO
ALTER TABLE [dbo].[Major_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Major_Subject_MajorID_Major_MajorID] FOREIGN KEY([Major_ID])
REFERENCES [dbo].[Major] ([Major_ID])
GO
ALTER TABLE [dbo].[Major_Subject] CHECK CONSTRAINT [FK_Major_Subject_MajorID_Major_MajorID]
GO
ALTER TABLE [dbo].[Major_Subject]  WITH CHECK ADD  CONSTRAINT [FK_Major_Subject_SubjectID_Subject_SubjectID] FOREIGN KEY([Subject_ID])
REFERENCES [dbo].[Subject] ([Subject_ID])
GO
ALTER TABLE [dbo].[Major_Subject] CHECK CONSTRAINT [FK_Major_Subject_SubjectID_Subject_SubjectID]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_StudentID_Student_StudentID] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[User] ([User_ID])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_StudentID_Student_StudentID]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID] FOREIGN KEY([Subject_Teacher_ID])
REFERENCES [dbo].[Subject_Teacher] ([Subject_Teacher_ID])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID]
GO
ALTER TABLE [dbo].[Subject_Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Teacher_SubjectID_Subject_SubjectID] FOREIGN KEY([Subject_ID])
REFERENCES [dbo].[Subject] ([Subject_ID])
GO
ALTER TABLE [dbo].[Subject_Teacher] CHECK CONSTRAINT [FK_Subject_Teacher_SubjectID_Subject_SubjectID]
GO
ALTER TABLE [dbo].[Subject_Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Teacher_TeacherID_Teacher_TeacherID] FOREIGN KEY([Teacher_ID])
REFERENCES [dbo].[User] ([User_ID])
GO
ALTER TABLE [dbo].[Subject_Teacher] CHECK CONSTRAINT [FK_Subject_Teacher_TeacherID_Teacher_TeacherID]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Major_ID] FOREIGN KEY([Major_ID])
REFERENCES [dbo].[Major] ([Major_ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Major_ID]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_ID] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Role] ([Role_ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role_ID]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [CHK_Number_Of_Credits] CHECK  (([Number_Of_Credits]>(0)))
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [CHK_Number_Of_Credits]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [CHK_User_Email] CHECK  (([Email] like '%@%'))
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [CHK_User_Email]
GO
USE [master]
GO
ALTER DATABASE [Std_management] SET  READ_WRITE 
GO
