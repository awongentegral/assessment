USE [SqlDbSample]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 5/30/2023 5:14:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[id] [int] NOT NULL,
	[title] [varchar](100) NOT NULL,
	[year] [int] NOT NULL,
	[author] [varchar](100) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 5/30/2023 5:14:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[reviewer_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[rating] [int] NOT NULL,
	[rating_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviewers]    Script Date: 5/30/2023 5:14:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviewers](
	[id] [int] NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Reviewers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Books] ([id], [title], [year], [author]) VALUES (101, N'A Tale Of Two Cities', 1859, N'Charles Dickens')
INSERT [dbo].[Books] ([id], [title], [year], [author]) VALUES (102, N'The Lord of the Rings', 1955, N'J. R. R. Toklien')
INSERT [dbo].[Books] ([id], [title], [year], [author]) VALUES (103, N'The Hobbit', 1937, NULL)
INSERT [dbo].[Books] ([id], [title], [year], [author]) VALUES (104, N'The Little Prince', 1943, N'Antoine de Saint-Exupery')
GO
INSERT [dbo].[Ratings] ([reviewer_id], [book_id], [rating], [rating_date]) VALUES (15201, 101, 2, CAST(N'2015-02-11' AS Date))
INSERT [dbo].[Ratings] ([reviewer_id], [book_id], [rating], [rating_date]) VALUES (15201, 101, 4, CAST(N'2015-06-16' AS Date))
INSERT [dbo].[Ratings] ([reviewer_id], [book_id], [rating], [rating_date]) VALUES (53202, 103, 4, NULL)
INSERT [dbo].[Ratings] ([reviewer_id], [book_id], [rating], [rating_date]) VALUES (15203, 103, 4, CAST(N'2015-03-21' AS Date))
GO
INSERT [dbo].[Reviewers] ([id], [name]) VALUES (15201, N'Joe Martinez')
INSERT [dbo].[Reviewers] ([id], [name]) VALUES (15203, N'Joe Martinez')
INSERT [dbo].[Reviewers] ([id], [name]) VALUES (44203, N'John Smith')
INSERT [dbo].[Reviewers] ([id], [name]) VALUES (53202, N'Alice Lewis')
GO
