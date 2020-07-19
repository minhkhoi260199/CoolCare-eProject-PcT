USE [HealthInsuranceMgmt]
GO
/****** Object:  Table [dbo].[AdminLogin]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[UserType] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_AdminLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InsuranceId] [int] NOT NULL,
	[Status] [int] NULL,
	[Description] [varchar](250) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyDetails]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](20) NULL,
	[CompanyUrl] [varchar](50) NULL,
 CONSTRAINT [PK_CompanyDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Designation] [varchar](50) NULL,
	[JoinDate] [datetime] NULL,
	[Salary] [money] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[Country] [varchar](50) NOT NULL,
	[City] [varchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hospitals]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospitals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Location] [varchar](50) NULL,
	[HospitalUrl] [varchar](50) NULL,
 CONSTRAINT [PK_Hospital] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicals]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicals](
	[Id] [int] NOT NULL,
	[MedicalName] [varchar](250) NULL,
	[MedicalDescription] [varchar](250) NULL,
	[CompanyId] [int] NULL,
	[HospitalId] [int] NULL,
 CONSTRAINT [PK_Medicals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policies]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyDesc] [varchar](250) NULL,
	[Amount] [money] NULL,
	[Emi] [money] NULL,
	[PolicyDuration] [int] NULL,
	[MedicalId] [int] NULL,
 CONSTRAINT [PK_Policies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PoliciesOnEmployees]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoliciesOnEmployees](
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusId] [int] NULL,
 CONSTRAINT [PK_PoliciesOnEmployees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyRequestDetails]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyRequestDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [datetime] NULL,
	[EmpId] [int] NOT NULL,
	[PolicyId] [int] NULL,
	[PolicyName] [varchar](50) NULL,
	[PolicyAmount] [money] NULL,
	[Emi] [money] NULL,
	[CompanyId] [int] NULL,
	[CompanyName] [varchar](50) NULL,
	[Status] [bit] NOT NULL,
	[ApprovedDate] [datetime] NULL,
	[Reason] [varchar](250) NULL,
	[RequestId] [int] NULL,
	[MedicalId] [int] NULL,
 CONSTRAINT [PK_PolicyRequestDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] NOT NULL,
	[Status] [varchar](250) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](250) NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 7/18/2020 11:14:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CompanyDetails] ON 

INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (1, N'Liberty Insurance Inc', N'44A Mac Dinh Chi st, Dist 1, HCM City', N'+84-1800599998', N'https://www.libertyinsurance.com.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (2, N'Bao Viet Insurance Inc', N'257 NTMK st, Dist 3, HCM City', N'+84-0966795333', N'https://ibaoviet.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (3, N'Bao Minh Insurance Inc', N'112 CMT8 st, Dist 10, HCM City', N'+84-0903686166', N'http://baominhsaigon.com.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (4, N'VietinBank Health Insurance Inc', N'357 Le Duan st, Dist 1, HCM City', N'+84-2819001566', N'https://vbi.vietinbank.vn/')
INSERT [dbo].[CompanyDetails] ([Id], [CompanyName], [Address], [Phone], [CompanyUrl]) VALUES (5, N'BIC Health Insurance Inc', N'191 Ba Trieu st, Dong Da Dist, HN City', N'+84-0422200282', N'https://bic.vn/')
SET IDENTITY_INSERT [dbo].[CompanyDetails] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (4, N'Worker', CAST(N'2020-07-15T00:00:00.000' AS DateTime), 6000000.0000, N'Lan', N'Ly', N'User001', N'123456', N'17A NTMK st', N'+84-394455693', N'Dist 3', N'Vietnam', N'HCM', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (5, N'Worker', CAST(N'2019-08-16T00:00:00.000' AS DateTime), 6000000.0000, N'Toan', N'Nguyen', N'User002', N'123456', N'15B Pauter st', N'+84-884582692', N'Dist 10', N'Vietnam', N'HCM', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (7, N'Telesales', CAST(N'2018-09-15T00:00:00.000' AS DateTime), 9000000.0000, N'Le', N'Ngo', N'User003', N'123456', N'114 Tran Phu', N'+84-256982458', N'Hoan Kiem', N'Vietnam', N'HN', 2)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (8, N'Manager', CAST(N'2019-08-07T00:00:00.000' AS DateTime), 2000000.0000, N'Van', N'Hanh', N'User004', N'123456', N'22 Alexander', N'+84-455365115', N'Cau Giay', N'Vietnam', N'HN', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (10, N'Manager', CAST(N'2020-06-02T00:00:00.000' AS DateTime), 25000000.0000, N'Tinh', N'Le', N'User005', N'123456', N'6A Cong Hoa', N'+84-624455693', N'Tan Binh', N'Vietnam', N'HCM', 2)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (11, N'Shipper', CAST(N'2019-05-04T00:00:00.000' AS DateTime), 5000000.0000, N'Dinh', N'Do', N'User006', N'123456', N'15 Hong Bang', N'+84-591268411', N'Dist 6', N'Vietnam', N'HCM', 2)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (12, N'Shipper', CAST(N'2018-05-04T00:00:00.000' AS DateTime), 5500000.0000, N'Luong', N'Ly', N'User007', N'123456', N'18 Da Khoa', N'+84-892211226', N'Dist 7', N'Vietnam', N'HCM', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (13, N'IT', CAST(N'2019-06-15T00:00:00.000' AS DateTime), 15000000.0000, N'Hong', N'Nguyen', N'User008', N'123456', N'14B Hoa Su', N'+84-922153588', N'Phu Nhuan', N'Vietnam', N'HCM', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (14, N'IT', CAST(N'2020-07-16T00:00:00.000' AS DateTime), 18000000.0000, N'Khang', N'Vo', N'User009', N'123456', N'19A Cao Thang', N'+84-722593225', N'Dist 1', N'Vietnam', N'HCM', 1)
INSERT [dbo].[Employees] ([Id], [Designation], [JoinDate], [Salary], [FirstName], [LastName], [Username], [Password], [Address], [Phone], [State], [Country], [City], [Status]) VALUES (16, N'Telesales', CAST(N'2019-05-16T00:00:00.000' AS DateTime), 10000000.0000, N'Mai', N'Trinh', N'User010', N'123456', N'20 Ton Dan', N'+84-394696938', N'Dist 4', N'Vietnam', N'HCM', 2)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Hospitals] ON 

INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (1, N'Vinmec Central Park International Hospital', N'+84-283622 1166', N'Binh Thanh, HCM', N'https://vinmec.com/centralpark/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (2, N'FV International Hospital', N'+84-2854113333', N'Dist 7, HCM', N'http://www.fvhospital.com/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (3, N'City International Hospital', N'+84-2862803333', N'Binh Tan, HCM', N'https://cih.com.vn/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (4, N'Victoria Healthcare International Hospital', N'+84-2839104545', N'Phu Nhuan, HCM', N'https://www.victoriavn.com/')
INSERT [dbo].[Hospitals] ([Id], [HospitalName], [Phone], [Location], [HospitalUrl]) VALUES (5, N'Columbia Asia Internation General Hospital', N'+84-2838238888', N'Dist 1, HCM', N'https://www.columbiaasia.com/')
SET IDENTITY_INSERT [dbo].[Hospitals] OFF
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (1, N'Liberty MediCare Health Insurance', N'Citizens are living in Vietnam
Ages 15 to 64
This insurance is not for people with pre-existing illness or special illness
', 1, 1)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (2, N'Liberty Healthcare Insurance', N'Citizens are living in Vietnam
Ages 15 to 64
This insurance is not for people with pre-existing illness or special illness
', 1, 2)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (3, N'Bao Viet K-Care Insurance', N'Citizens are living in Vietnam
Ages 15 to 60
This insurance is not for people with pre-existing illness or special illness
', 2, 3)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (4, N'Bao Viet InterCare Insurance', N'Citizens are living in Vietnam
Ages 15 to 75
This insurance is not for people with pre-existing illness or special illness
', 2, 4)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (5, N'Bao Minh HealthCare Insurance', N'Citizens are living in Vietnam
Ages 15 to 60
Except for the following:
People with mental illness, leprosy, cancer;
Those who are disabled or permanently disabled from 50% or more;
People who are in the process of treating illnesses, injuries
', 3, 5)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (6, N'Bao Minh PSN-Care Insurance', N'Citizens are living in Vietnam
Ages 1 to 70
Except for the following:
People with mental illness, leprosy, cancer;
Those who are disabled or permanently disabled from 50% or more;
People who are in the process of treating illnesses, injuries
', 3, 1)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (7, N'ViettinBank VBI Care Insurance', N'Citizens are living in Vietnam
Ages 1 to 60
Except for the following:
People with mental illness, leprosy, cancer;
Those who are disabled or permanently disabled from 50% or more;
People who are in the process of treating illnesses, injuries
', 4, 2)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (8, N'ViettinBank HC Insurance', N'Citizens are living in Vietnam
Ages 18 to 70
Except for the following:
People with mental illness, leprosy, cancer;
Those who are disabled or permanently disabled from 50% or more;
People who are in the process of treating illnesses, injuries
', 4, 3)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (9, N'BIC Care Insurance', N'Citizens are living in Vietnam
Ages 1 to 65
People with mental illness, leprosy
Those with permanent disability more than 50%
', 5, 4)
INSERT [dbo].[Medicals] ([Id], [MedicalName], [MedicalDescription], [CompanyId], [HospitalId]) VALUES (10, N'BIC 24/7 Insurance', N'Citizens are living in Vietnam
Ages 1 to 65
People with mental illness, leprosy
Those with permanent disability more than 50%
', 5, 5)
SET IDENTITY_INSERT [dbo].[Policies] ON 

INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (3, N'Liberty MediCare Standard', N'There is no waiting period for special illnesses.
There is no limit to the number of visits and the cost of each visit.
Transparent, fast and fair compensation procedure
24/7 customer service.
', 300000000.0000, 25000000.0000, 12, 1)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (4, N'Liberty MediCare Premium', N'There is no waiting period for special illnesses.
There is no limit to the number of visits and the cost of each visit.
Best suited for households, small and medium enterprises
', 600000000.0000, 50000000.0000, 12, 1)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (5, N'Liberty Healthcare Standard', N'Get global emergency medical assistance by International SOS
Free routine checkups and vaccinations
There is no limit on the cost of treatment or the number of days in a hospital
', 24000000.0000, 2000000.0000, 12, 2)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (7, N'Liberty Healthcare Premium', N'Get global emergency medical assistance by International SOS
Free routine checkups and vaccinations
There is no limit on the cost of treatment or the number of days in a hospital
', 48000000.0000, 4000000.0000, 12, 2)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (8, N'Bao Viet K-Care Standard', N'Cancer insurance benefits
Early stage cancer insurance benefits
Late stage cancer insurance benefits
Hospitalization benefit
Death benefit due to cancer
Accidental death benefit
', 120000000.0000, 10000000.0000, 12, 3)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (9, N'Bao Viet K-Care Premium', N'Cancer insurance benefits
Early stage cancer insurance benefits
Late stage cancer insurance benefits
Hospitalization benefit
Death benefit due to cancer
Accidental death benefit
', 240000000.0000, 20000000.0000, 12, 3)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (10, N'Bao Viet InterCare Standard', N'Emergency medical transportation and repatriation in Vietnam or abroad.
There is no waiting period for special illnesses.
There is no limit to the number of visits and the cost of each visit.
', 48000000.0000, 4000000.0000, 12, 4)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (11, N'Bao Viet InterCare Premium', N'Emergency medical transportation and repatriation in Vietnam or abroad.
There is no waiting period for special illnesses.
There is no limit to the number of visits and the cost of each visit.
', 120000000.0000, 10000000.0000, 12, 4)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (12, N'Bao Minh HealthCare Standard', N'Permanent disability
Loss of income
Medical costs
Health insurance has a variety of insurance packages such as life insurance and medical cost insurance, dental treatment insurance, eye treatment insurance for customers to choose on demand.
', 60000000.0000, 5000000.0000, 12, 5)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (13, N'Bao Minh HealthCare Premium', N'Permanent disability
Loss of income
Medical costs
Health insurance has a variety of insurance packages such as life insurance and medical cost insurance, dental treatment insurance, eye treatment insurance for customers to choose on demand.
', 120000000.0000, 10000000.0000, 12, 5)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (14, N'Bao Minh PSN-Care Standard', N'Accident insurance protects against the following risks:
Died
Total permanent disability
Permanent disability
Loss of income
Medical costs
', 96000000.0000, 8000000.0000, 12, 6)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (15, N'Bao Minh PSN-Care Premium', N'Accident insurance protects against the following risks:
Died
Total permanent disability
Permanent disability
Loss of income
Medical costs
', 240000000.0000, 20000000.0000, 12, 6)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (17, N'ViettinBank VBI Care Standard', N'Customers are insured globally for special insurance programs;
Accident insurance for up to VND 2 billion, inpatient benefits up to VND 400 million;
No health examination is required before registration; ', 120000000.0000, 10000000.0000, 12, 7)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (18, N'ViettinBank VBI Care Premium', N'Customers are insured globally for special insurance programs;
Accident insurance for up to VND 2 billion, inpatient benefits up to VND 400 million;
No health examination is required before registration; ', 480000000.0000, 40000000.0000, 12, 7)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (19, N'ViettinBank HC Standard', N'Guarantee of hospital fees at affiliated hospitals and clinics nationwide;
Discounts for customers and families who have no claim for compensation for 1 year or more;
Children over 12 months old can join independent insurance;
', 360000000.0000, 30000000.0000, 12, 8)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (20, N'ViettinBank HC premium', N'Guarantee of hospital fees at affiliated hospitals and clinics nationwide;
Discounts for customers and families who have no claim for compensation for 1 year or more;
Children over 12 months old can join independent insurance;
', 720000000.0000, 60000000.0000, 12, 8)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (21, N'BIC Care Standard', N'Death of permanent disability due to an accident
Medical expenses due to an accident
Income allowance for the treatment of accidental injuries
The cost of surgical treatment of inpatient treatment due to illness, illness and maternity
', 60000000.0000, 5000000.0000, 12, 9)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (22, N'BIC Care Premium', N'Death of permanent disability due to an accident
Medical expenses due to an accident
Income allowance for the treatment of accidental injuries
The cost of surgical treatment of inpatient treatment due to illness, illness and maternity
', 144000000.0000, 12000000.0000, 12, 9)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (24, N'BIC 24/7 Standard', N'Outpatient medical expenses due to illness or disease
Death and permanent health injury due to illness
Income allowance during the inpatient treatment due to illness or disease
', 96000000.0000, 8000000.0000, 12, 10)
INSERT [dbo].[Policies] ([Id], [PolicyName], [PolicyDesc], [Amount], [Emi], [PolicyDuration], [MedicalId]) VALUES (25, N'BIC 24/7 Premium', N'Outpatient medical expenses due to illness or disease
Death and permanent health injury due to illness
Income allowance during the inpatient treatment due to illness or disease
', 144000000.0000, 12000000.0000, 12, 10)
SET IDENTITY_INSERT [dbo].[Policies] OFF
SET IDENTITY_INSERT [dbo].[UserStatus] ON 

INSERT [dbo].[UserStatus] ([Id], [StatusName]) VALUES (1, N'Activated')
INSERT [dbo].[UserStatus] ([Id], [StatusName]) VALUES (2, N'Not Activated')
SET IDENTITY_INSERT [dbo].[UserStatus] OFF
ALTER TABLE [dbo].[AdminLogin]  WITH CHECK ADD  CONSTRAINT [FK_AdminLogin_UserType] FOREIGN KEY([UserType])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[AdminLogin] CHECK CONSTRAINT [FK_AdminLogin_UserType]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_PoliciesOnEmployees] FOREIGN KEY([InsuranceId])
REFERENCES [dbo].[PoliciesOnEmployees] ([Id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_PoliciesOnEmployees]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_UserStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[UserStatus] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_UserStatus]
GO
ALTER TABLE [dbo].[Medicals]  WITH CHECK ADD  CONSTRAINT [FK_Medicals_CompanyDetails] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyDetails] ([Id])
GO
ALTER TABLE [dbo].[Medicals] CHECK CONSTRAINT [FK_Medicals_CompanyDetails]
GO
ALTER TABLE [dbo].[Medicals]  WITH CHECK ADD  CONSTRAINT [FK_Medicals_Hospitals] FOREIGN KEY([HospitalId])
REFERENCES [dbo].[Hospitals] ([Id])
GO
ALTER TABLE [dbo].[Medicals] CHECK CONSTRAINT [FK_Medicals_Hospitals]
GO
ALTER TABLE [dbo].[Policies]  WITH CHECK ADD  CONSTRAINT [FK_Policies_Medicals] FOREIGN KEY([MedicalId])
REFERENCES [dbo].[Medicals] ([Id])
GO
ALTER TABLE [dbo].[Policies] CHECK CONSTRAINT [FK_Policies_Medicals]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Employees] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Employees]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Policies] FOREIGN KEY([PolicyId])
REFERENCES [dbo].[Policies] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Policies]
GO
ALTER TABLE [dbo].[PoliciesOnEmployees]  WITH CHECK ADD  CONSTRAINT [FK_PoliciesOnEmployees_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[PoliciesOnEmployees] CHECK CONSTRAINT [FK_PoliciesOnEmployees_Status]
GO
