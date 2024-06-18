USE [NvvK22CNT2Lesson07Db]
GO
/****** Object:  Table [dbo].[nvvKhoa]    Script Date: 6/17/2024 3:44:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvvKhoa](
	[NvvMaKH] [nchar](10) NOT NULL,
	[NvvTenKH] [nchar](50) NULL,
	[NvvTrangThai] [bit] NULL,
 CONSTRAINT [PK_nvvKhoa] PRIMARY KEY CLUSTERED 
(
	[NvvMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nvvSinhVien]    Script Date: 6/17/2024 3:44:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvvSinhVien](
	[NvvMaSV] [nvarchar](50) NOT NULL,
	[NvvHoSV] [nvarchar](50) NULL,
	[NvvTenSV] [nvarchar](50) NULL,
	[NvvNgaySinh] [date] NULL,
	[NvvPhai] [bit] NULL,
	[NvvPhone] [nchar](10) NULL,
	[NvvEmail] [nvarchar](50) NULL,
	[NvvMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_nvvSinhVien] PRIMARY KEY CLUSTERED 
(
	[NvvMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nvvKhoa] ([NvvMaKH], [NvvTenKH], [NvvTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT2                                           ', 1)
GO
INSERT [dbo].[nvvSinhVien] ([NvvMaSV], [NvvHoSV], [NvvTenSV], [NvvNgaySinh], [NvvPhai], [NvvPhone], [NvvEmail], [NvvMaKH]) VALUES (N'2210900081', N'Nguyễn Văn ', N'Vũ', CAST(N'2004-06-04' AS Date), 1, N'0812056108', N'nguyenvanvu642004@gmail.com', N'K22CNT2   ')
GO
