USE [master]
GO
/****** Object:  Database [QUAN_LY_NHAN_SU]    Script Date: 4/28/2022 11:24:36 PM ******/
CREATE DATABASE [QUAN_LY_NHAN_SU]
GO
USE [QUAN_LY_NHAN_SU]
GO
/****** Object:  User [chuong]    Script Date: 4/28/2022 11:24:36 PM ******/
CREATE USER [chuong] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 4/28/2022 11:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANGNHAP](
	[username] [nvarchar](50) NOT NULL,
	[password] [nchar](20) NOT NULL,
	[id_Nv] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DANGNHAPM] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DUAN]    Script Date: 4/28/2022 11:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DUAN](
	[id_Da] [nvarchar](10) NOT NULL,
	[name_Da] [nvarchar](50) NOT NULL,
	[sonv_Da] [int] NOT NULL,
	[mota_Da] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DUAN] PRIMARY KEY CLUSTERED 
(
	[id_Da] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 4/28/2022 11:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LUONG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_NV] [nvarchar](10) NULL,
	[LuongCu] [float] NULL,
	[LuongMoi] [float] NULL,
	[NgayThayDoi] [date] NULL,
 CONSTRAINT [PK_LUONG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/28/2022 11:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id_Nv] [nvarchar](10) NOT NULL,
	[name_Nv] [nvarchar](100) NOT NULL,
	[ngaysinh_Nv] [date] NOT NULL,
	[diachi_Nv] [nvarchar](50) NOT NULL,
	[luong_Nv] [int] NOT NULL,
	[id_Pb] [nvarchar](10) NOT NULL,
	[id_Da] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[id_Nv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 4/28/2022 11:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[id_Pb] [nvarchar](10) NOT NULL,
	[name_Pb] [nvarchar](50) NOT NULL,
	[sonv_Pb] [int] NOT NULL,
	[mota_Pb] [nvarchar](100) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[id_Pb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DANGNHAP] ([username], [password], [id_Nv]) VALUES (N'admin                                             ', N'admin               ', N'nv5       ')
INSERT [dbo].[DANGNHAP] ([username], [password], [id_Nv]) VALUES (N'an                                                ', N'123                 ', N'nv2       ')
INSERT [dbo].[DANGNHAP] ([username], [password], [id_Nv]) VALUES (N'binh                                              ', N'123                 ', N'nv4       ')
INSERT [dbo].[DANGNHAP] ([username], [password], [id_Nv]) VALUES (N'chuong                                            ', N'123                 ', N'nv3       ')
INSERT [dbo].[DANGNHAP] ([username], [password], [id_Nv]) VALUES (N'minh                                              ', N'123                 ', N'nv1       ')
INSERT [dbo].[DUAN] ([id_Da], [name_Da], [sonv_Da], [mota_Da]) VALUES (N'da1       ', N'Xay dung phan mem HAUI', 4, N'Du an giao duc')
INSERT [dbo].[DUAN] ([id_Da], [name_Da], [sonv_Da], [mota_Da]) VALUES (N'da2       ', N'Xay dung website ban hang', 1, N'Du an kinh te')
INSERT [dbo].[DUAN] ([id_Da], [name_Da], [sonv_Da], [mota_Da]) VALUES (N'da3       ', N'Cổng thông tin Tp Hà Nội', 4, N'Dự án chính phủ cập nhật thông tin chính trị ,..')
INSERT [dbo].[DUAN] ([id_Da], [name_Da], [sonv_Da], [mota_Da]) VALUES (N'da4       ', N'Xây dựng phần mềm quản lý nhân sự cty 3f', 1, N'Dự án văn phòng')
SET IDENTITY_INSERT [dbo].[LUONG] ON 

INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (1, N'nv1', 19000000, 23000000, CAST(N'2019-01-26' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (2, N'nv2', 13000000, 15000000, CAST(N'2021-04-08' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (4, N'nv4', 10000000, 15000000, CAST(N'2021-09-01' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (6, N'nv3', 20000000, 32000000, CAST(N'2022-04-28' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (7, N'nv8', 10000000, 26000000, CAST(N'2022-01-14' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (8, N'nv7', 10000000, 7666667, CAST(N'2022-04-03' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (9, N'nv1', 23000000, 24500000, CAST(N'2022-04-17' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (10, N'nv9', 10000000, 32500000, CAST(N'2022-07-07' AS Date))
INSERT [dbo].[LUONG] ([ID], [ID_NV], [LuongCu], [LuongMoi], [NgayThayDoi]) VALUES (11, N'nv8', 10000000, 45000000, CAST(N'2022-04-28' AS Date))
SET IDENTITY_INSERT [dbo].[LUONG] OFF
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv1', N'Lê Văn Bình', CAST(N'1998-02-08' AS Date), N'Hà Nội', 24500000, N'pb1       ', N'da3       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv10', N'Thầy cho em 9 nhé', CAST(N'1997-10-11' AS Date), N'Bắc Giang', 15000000, N'pb3       ', N'da3       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv2', N'Nguyễn Hoàng Bá Ân', CAST(N'1998-05-09' AS Date), N'Lạng Sơn', 15000000, N'pb1       ', N'da1       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv3', N'Nguyễn Văn Chương', CAST(N'1998-08-07' AS Date), N'Bắc Giang', 20000000, N'pb2       ', N'da1       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv4', N'Nguyễn Mỹ Linh', CAST(N'1998-11-05' AS Date), N'Bắc Giang', 10000000, N'pb3       ', N'da3       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv5', N'Lê Văn Sơn', CAST(N'1996-10-12' AS Date), N'Cao Bằng', 14000000, N'pb2       ', N'da1       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv6', N'Bùi Văn Cảnh', CAST(N'1997-10-11' AS Date), N'Sơn La', 13000000, N'pb2       ', N'da3       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv7', N'Nguyễn Thanh Hương', CAST(N'1996-05-07' AS Date), N'Hưng Yên', 7666667, N'pb4       ', N'da4       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv8', N'Trần Thanh Hằng', CAST(N'1996-06-08' AS Date), N'Thái Bình', 45000000, N'pb2       ', N'da2       ')
INSERT [dbo].[NHANVIEN] ([id_Nv], [name_Nv], [ngaysinh_Nv], [diachi_Nv], [luong_Nv], [id_Pb], [id_Da]) VALUES (N'nv9', N'Phạm Thị Linh', CAST(N'1997-06-08' AS Date), N'Bắc Ninh', 32500000, N'pb1       ', N'da1       ')
INSERT [dbo].[PHONGBAN] ([id_Pb], [name_Pb], [sonv_Pb], [mota_Pb]) VALUES (N'pb1       ', N'Hành chính - Nhân sự', 3, N'Đây là phòng phát triển và quản lý nhân sự')
INSERT [dbo].[PHONGBAN] ([id_Pb], [name_Pb], [sonv_Pb], [mota_Pb]) VALUES (N'pb2       ', N'Kinh doanh', 4, N'Đây là phòng kinh điều khiển hoạt động sản xuất trong công ty')
INSERT [dbo].[PHONGBAN] ([id_Pb], [name_Pb], [sonv_Pb], [mota_Pb]) VALUES (N'pb3       ', N'Kế toán', 2, N'Đây là phòng quản lý , thanh toán lương nhân viên , tài sản công ty ')
INSERT [dbo].[PHONGBAN] ([id_Pb], [name_Pb], [sonv_Pb], [mota_Pb]) VALUES (N'pb4       ', N'Kỹ thuật ', 1, N'Đây là phòng thực hiện nghiên cứu , sản xuất và tranning của công ty')
ALTER TABLE [dbo].[LUONG] ADD  CONSTRAINT [DF_LUONG_NgayThayDoi]  DEFAULT (getdate()) FOR [NgayThayDoi]
GO
ALTER TABLE [dbo].[DANGNHAP]  WITH CHECK ADD  CONSTRAINT [FK_DANGNHAP_NHANVIEN] FOREIGN KEY([id_Nv])
REFERENCES [dbo].[NHANVIEN] ([id_Nv])
GO
ALTER TABLE [dbo].[DANGNHAP] CHECK CONSTRAINT [FK_DANGNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_DUAN] FOREIGN KEY([id_Da])
REFERENCES [dbo].[DUAN] ([id_Da])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_DUAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHONGBAN] FOREIGN KEY([id_Pb])
REFERENCES [dbo].[PHONGBAN] ([id_Pb])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHONGBAN]
GO
USE [master]
GO
ALTER DATABASE [QUAN_LY_NHAN_SU] SET  READ_WRITE 
GO
