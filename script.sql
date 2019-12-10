USE [QLSINHVIEN]
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewDanhSachTenLop'
GO
EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewDanhSachTenLop'
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[XoaSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[XoaNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[XoaMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[XoaLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaLopHoc]
GO
/****** Object:  StoredProcedure [dbo].[XoaKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaKhoaHoc]
GO
/****** Object:  StoredProcedure [dbo].[XoaKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaKhoa]
GO
/****** Object:  StoredProcedure [dbo].[XoaHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaHocKy]
GO
/****** Object:  StoredProcedure [dbo].[XoaHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaHeDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[XoaDiemCuaSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[XoaDiemCuaSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[UpDateTrangThai]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[UpDateTrangThai]
GO
/****** Object:  StoredProcedure [dbo].[UpDateMatKhau]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[UpDateMatKhau]
GO
/****** Object:  StoredProcedure [dbo].[UpDateDiemQTVaDiemThi]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[UpDateDiemQTVaDiemThi]
GO
/****** Object:  StoredProcedure [dbo].[TimMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemThongTinNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemThongTinNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemLopHoc]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemKhoaHoc]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemKhoa]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemHocKy]
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[TimKiemHeDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[ThemSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[ThemNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[ThemMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[ThemLopHocMoi]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemLopHocMoi]
GO
/****** Object:  StoredProcedure [dbo].[ThemKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemKhoaHoc]
GO
/****** Object:  StoredProcedure [dbo].[ThemKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemKhoa]
GO
/****** Object:  StoredProcedure [dbo].[ThemKetQua]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemKetQua]
GO
/****** Object:  StoredProcedure [dbo].[ThemHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemHocKy]
GO
/****** Object:  StoredProcedure [dbo].[ThemHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ThemHeDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaThongTinSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaThongTinLopHoc]
GO
/****** Object:  StoredProcedure [dbo].[SuaNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[SuaMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[SuaKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaKhoa]
GO
/****** Object:  StoredProcedure [dbo].[SuaHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaHocKy]
GO
/****** Object:  StoredProcedure [dbo].[SuaHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SuaHeDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[SoTinChiDat]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[SoTinChiDat]
GO
/****** Object:  StoredProcedure [dbo].[LayKetQuaHocTap]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[LayKetQuaHocTap]
GO
/****** Object:  StoredProcedure [dbo].[LayDiemTheoKySinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[LayDiemTheoKySinhVien]
GO
/****** Object:  StoredProcedure [dbo].[LayAnhSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[LayAnhSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[KiemTraDangNhap]
GO
/****** Object:  StoredProcedure [dbo].[KetQuaTongKetHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[KetQuaTongKetHocKy]
GO
/****** Object:  StoredProcedure [dbo].[KetQuaTongKetDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[KetQuaTongKetDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachThongTinNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachThongTinNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachThongTinHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachThongTinHocKy]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachTaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong_Khoa_Top]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienXetHocBong_Khoa_Top]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong_Khoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienXetHocBong_Khoa]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienXetHocBong]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruongKhongDuocNhanBang]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienRaTruongKhongDuocNhanBang]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruongDuocNhanBang]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienRaTruongDuocNhanBang]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruong]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienRaTruong]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienCuaLop]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVienCuaLop]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachQuyen]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachQuyen]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachNganhDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMonHocToanTruong]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachMonHocToanTruong]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachKhoaHoc]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachKhoa]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachHocKy]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSachHeDaoTao]
GO
/****** Object:  StoredProcedure [dbo].[DanhSach_ThongTin_Lop]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSach_ThongTin_Lop]
GO
/****** Object:  StoredProcedure [dbo].[DanhSach_ThongTin_KhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[DanhSach_ThongTin_KhoaHoc]
GO
/****** Object:  StoredProcedure [dbo].[ChinhSuaQuyen]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ChinhSuaQuyen]
GO
/****** Object:  StoredProcedure [dbo].[ChinhSuaKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP PROCEDURE [dbo].[ChinhSuaKhoaHoc]
GO
ALTER TABLE [dbo].[SinhVien] DROP CONSTRAINT [FK_SinhVien_Lop]
GO
ALTER TABLE [dbo].[NganhDaoTao] DROP CONSTRAINT [FK_NganhDaoTao_Khoa]
GO
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_NganhDaoTao]
GO
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_KhoaHoc]
GO
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_HeDaoTao]
GO
ALTER TABLE [dbo].[BangDiem] DROP CONSTRAINT [FK_BangDiem_SinhVien]
GO
ALTER TABLE [dbo].[BangDiem] DROP CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[BangDiem] DROP CONSTRAINT [FK_BangDiem_HocKy]
GO
/****** Object:  Table [dbo].[ThongTinDanhNhap]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[ThongTinDanhNhap]
GO
/****** Object:  Table [dbo].[SinhVien_Deleted]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[SinhVien_Deleted]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[SinhVien]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[MonHoc]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[Khoa]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[HocKy]
GO
/****** Object:  Table [dbo].[DoiDiem]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[DoiDiem]
GO
/****** Object:  Table [dbo].[BangDiem_Updated]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[BangDiem_Updated]
GO
/****** Object:  Table [dbo].[BangDiem_DeletedTime]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[BangDiem_DeletedTime]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[BangDiem]
GO
/****** Object:  View [dbo].[viewDanhSachTenHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP VIEW [dbo].[viewDanhSachTenHeDaoTao]
GO
/****** Object:  Table [dbo].[HeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[HeDaoTao]
GO
/****** Object:  View [dbo].[viewDanhSachTenNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP VIEW [dbo].[viewDanhSachTenNganhDaoTao]
GO
/****** Object:  Table [dbo].[NganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[NganhDaoTao]
GO
/****** Object:  View [dbo].[viewDanhSachTenKhoahoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP VIEW [dbo].[viewDanhSachTenKhoahoc]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[KhoaHoc]
GO
/****** Object:  View [dbo].[viewDanhSachTenLop]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP VIEW [dbo].[viewDanhSachTenLop]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP TABLE [dbo].[Lop]
GO
/****** Object:  UserDefinedFunction [dbo].[fnTinhDiemChuHonF]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP FUNCTION [dbo].[fnTinhDiemChuHonF]
GO
/****** Object:  UserDefinedFunction [dbo].[fnTinhDiemChu]    Script Date: 2019-12-10 7:00:06 AM ******/
DROP FUNCTION [dbo].[fnTinhDiemChu]
GO
/****** Object:  UserDefinedFunction [dbo].[fnTinhDiemChu]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fnTinhDiemChu](@DiemQuaTrinh float,@DiemThi float)
returns varchar(10) 
AS
begin
	return (CASE
		WHEN (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 4.95 THEN 'F'
		WHEN 4.95 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 5.45 THEN 'D'
		WHEN 5.45 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 6.95 THEN 'C'
		WHEN 6.95 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 8.45 THEN 'B'
		WHEN (@DiemQuaTrinh*0.5 + @DiemThi*0.5) >= 8.45 THEN 'A'
	END)
end
GO
/****** Object:  UserDefinedFunction [dbo].[fnTinhDiemChuHonF]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fnTinhDiemChuHonF](@DiemQuaTrinh float,@DiemThi float)
returns varchar(10) AS
begin
	return (CASE
		WHEN 4.95 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 5.45 THEN 'D'
		WHEN 5.45 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 6.95 THEN 'C'
		WHEN 6.95 <= (@DiemQuaTrinh*0.5 + @DiemThi*0.5) AND (@DiemQuaTrinh*0.5 + @DiemThi*0.5) < 8.45 THEN 'B'
		WHEN (@DiemQuaTrinh*0.5 + @DiemThi*0.5) >= 8.45 THEN 'A'
	END)
end
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MaKhoaHoc] [varchar](10) NOT NULL,
	[MaHeDaoTao] [varchar](10) NOT NULL,
	[MaNganh] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewDanhSachTenLop]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*---------------------------------------------------------------------------------------------*/
CREATE VIEW [dbo].[viewDanhSachTenLop]
AS
SELECT        MaLop, TenLop
FROM            dbo.Lop
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [varchar](10) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewDanhSachTenKhoahoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewDanhSachTenKhoahoc]
AS
	SELECT MaKhoaHoc FROM KhoaHoc
GO
/****** Object:  Table [dbo].[NganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganhDaoTao](
	[MaNganh] [varchar](10) NOT NULL,
	[TenNganh] [nvarchar](50) NOT NULL,
	[MaKhoa] [varchar](10) NULL,
 CONSTRAINT [PK_NganhDaoTao] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewDanhSachTenNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------------
CREATE VIEW [dbo].[viewDanhSachTenNganhDaoTao]
AS
	SELECT MaNganh, TenNganh FROM NganhDaoTao; 
GO
/****** Object:  Table [dbo].[HeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeDaoTao](
	[MaHe] [varchar](10) NOT NULL,
	[TenHe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HeDaoTao] PRIMARY KEY CLUSTERED 
(
	[MaHe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewDanhSachTenHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------------------------------------------
CREATE VIEW [dbo].[viewDanhSachTenHeDaoTao]
AS
	SELECT MaHe, TenHe FROM HeDaoTao; 
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[Stt] [int] IDENTITY(1,1) NOT NULL,
	[MaSinhVien] [varchar](10) NOT NULL,
	[MaMonHoc] [varchar](10) NOT NULL,
	[MaHocKy] [varchar](10) NOT NULL,
	[DiemQuaTrinh] [float] NOT NULL,
	[DiemThi] [float] NOT NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[Stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangDiem_DeletedTime]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem_DeletedTime](
	[Stt] [int] NULL,
	[Tgianxoa] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangDiem_Updated]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem_Updated](
	[Stt] [int] NULL,
	[Masv] [varchar](10) NULL,
	[Mamh] [varchar](10) NULL,
	[Mahk] [varchar](10) NULL,
	[DiemQTCu] [float] NULL,
	[DiemThiCu] [float] NULL,
	[Tgiansua] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiDiem]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiDiem](
	[Stt] [int] IDENTITY(1,1) NOT NULL,
	[DiemChu] [varchar](10) NULL,
	[DiemSo] [float] NULL,
	[KetLuan] [nvarchar](10) NULL,
 CONSTRAINT [PK_DoiDiem] PRIMARY KEY CLUSTERED 
(
	[Stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHocKy] [varchar](10) NOT NULL,
	[TenHocKy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[Tenkhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NOT NULL,
	[SoTinChi] [int] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](10) NOT NULL,
	[TenSinhVien] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[Anh] [image] NULL,
	[Lop] [varchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[ChinhSachUuTien] [bit] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_Deleted]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_Deleted](
	[Masv] [varchar](10) NULL,
	[Tensv] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Malop] [varchar](10) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Chinhsachuutien] [bit] NULL,
	[Tgianxoa] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinDanhNhap]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinDanhNhap](
	[TaiKhoan] [varchar](30) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[Quyen] [nvarchar](30) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_ThongTinDanhNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BangDiem] ON 

INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (1, N'15CNPM002', N'GELA220405', N'151', 9.5, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (2, N'15CNPM002', N'EHQT130137', N'151', 5, 5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (3, N'15CNPM002', N'MATH142001', N'151', 7, 6.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (4, N'15CNPM002', N'INPR140285', N'151', 8.5, 9.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (5, N'15CNPM002', N'INIT130185', N'151', 9, 9)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (6, N'15CNPM002', N'MATH141601', N'151', 7, 5.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (7, N'15CNPM002', N'LLCT120314', N'151', 9, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (8, N'15CNPM002', N'EHQT130237', N'152', 7.7, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (9, N'15CNPM002', N'PHED110513', N'152', 6, 5.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (10, N'15CNPM002', N'PRTE240385', N'152', 9, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (11, N'15CNPM002', N'LLCT150105', N'152', 9.5, 9.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (12, N'15CNPM002', N'MATH141701', N'152', 7.5, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (13, N'15CNPM002', N'DIGR240485', N'152', 8.5, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (14, N'15CNPM002', N'MATH122101', N'152', 6.5, 5.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (15, N'15CNPM002', N'GDQP008031', N'161', 8, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (16, N'15CNPM002', N'GDQP008032', N'161', 9, 9)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (17, N'15CNPM002', N'PHED130715', N'161', 9, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (18, N'15CNPM002', N'EHQT230337', N'161', 8, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (19, N'15CNPM002', N'DASA240179', N'161', 8, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (20, N'15CNPM002', N'DBSY240184', N'161', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (21, N'15CNPM002', N'LLCT230214', N'161', 9.5, 9.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (22, N'15CNPM002', N'PHED110613', N'161', 6, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (23, N'15CNPM002', N'OOPR240279', N'161', 8, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (24, N'15CNPM002', N'PHYS110702', N'161', 7, 7.5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (25, N'15CNPM002', N'EHQT230437', N'162', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (26, N'15CNPM002', N'PHED130715', N'162', 6, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (27, N'15CNPM002', N'OPSY340280', N'162', 6, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (28, N'15CNPM002', N'CAAL240180', N'162', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (29, N'15CNPM002', N'WIPR240579', N'162', 8, 9)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (30, N'15CNPM002', N'NEES340380', N'162', 9, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (31, N'15CNPM002', N'INSE340380', N'171', 7, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (32, N'15CNPM002', N'EHQT330537', N'171', 8, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (34, N'15CNPM002', N'PROJ212879', N'171', 10, 10)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (35, N'15CNPM002', N'DBMS340284', N'171', 8, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (37, N'15CNPM002', N'ESYS431080', N'171', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (38, N'15CNPM002', N'WEPR340479', N'171', 8, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (39, N'15CNPM002', N'SOTE431079', N'172', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (40, N'15CNPM002', N'SOPM431679', N'172', 8, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (41, N'15CNPM002', N'MOPR331279', N'172', 6, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (42, N'15CNPM002', N'SOEN340679', N'172', 8, 8)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (43, N'15CNPM002', N'ECOM430984', N'172', 7, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (45, N'15CNPM002', N'GRPR433279', N'181', 8, 6)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (46, N'15CNPM002', N'ESDN432079', N'181', 8, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (47, N'15CNPM002', N'POSE431479', N'181', 7, 7)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (48, N'15CNPM002', N'ARIN330585', N'181', 7, 5)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (49, N'15CNPM002', N'GRPR401979', N'182', 10, 10)
INSERT [dbo].[BangDiem] ([Stt], [MaSinhVien], [MaMonHoc], [MaHocKy], [DiemQuaTrinh], [DiemThi]) VALUES (50, N'15CNPM002', N'ADMP431879', N'182', 7, 7)
SET IDENTITY_INSERT [dbo].[BangDiem] OFF
INSERT [dbo].[BangDiem_DeletedTime] ([Stt], [Tgianxoa]) VALUES (56, CAST(N'2019-12-10T02:18:05.970' AS DateTime))
INSERT [dbo].[BangDiem_Updated] ([Stt], [Masv], [Mamh], [Mahk], [DiemQTCu], [DiemThiCu], [Tgiansua]) VALUES (49, N'15CNPM002', N'GRPR401979', N'GRPR401979', 9, 8, CAST(N'2019-12-10T02:34:43.500' AS DateTime))
SET IDENTITY_INSERT [dbo].[DoiDiem] ON 

INSERT [dbo].[DoiDiem] ([Stt], [DiemChu], [DiemSo], [KetLuan]) VALUES (1, N'F', 0, N'Học lại')
INSERT [dbo].[DoiDiem] ([Stt], [DiemChu], [DiemSo], [KetLuan]) VALUES (2, N'D', 1, N'Qua')
INSERT [dbo].[DoiDiem] ([Stt], [DiemChu], [DiemSo], [KetLuan]) VALUES (3, N'C', 2, N'Qua')
INSERT [dbo].[DoiDiem] ([Stt], [DiemChu], [DiemSo], [KetLuan]) VALUES (4, N'B', 3, N'Qua')
INSERT [dbo].[DoiDiem] ([Stt], [DiemChu], [DiemSo], [KetLuan]) VALUES (5, N'A', 4, N'Qua')
SET IDENTITY_INSERT [dbo].[DoiDiem] OFF
INSERT [dbo].[HeDaoTao] ([MaHe], [TenHe]) VALUES (N'CD', N'Cao đẳng')
INSERT [dbo].[HeDaoTao] ([MaHe], [TenHe]) VALUES (N'CQ', N'Chính quy')
INSERT [dbo].[HeDaoTao] ([MaHe], [TenHe]) VALUES (N'TC', N'Tại chức')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'151', N'Học kỳ 1 năm 2015')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'152', N'Học kỳ 2 năm 2015')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'161', N'Học kỳ 1 năm 2016')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'162', N'Học kỳ 2 năm 2016')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'171', N'Học kỳ 1 năm 2017')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'172', N'Học kỳ 2 năm 2017')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'181', N'Học kỳ 1 năm 2018')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy]) VALUES (N'182', N'Học kỳ 2 năm 2018')
INSERT [dbo].[Khoa] ([MaKhoa], [Tenkhoa]) VALUES (N'123', N'1234')
INSERT [dbo].[Khoa] ([MaKhoa], [Tenkhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NgayBatDau], [NgayKetThuc]) VALUES (N'15', CAST(N'2015-09-05' AS Date), CAST(N'2019-06-30' AS Date))
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NgayBatDau], [NgayKetThuc]) VALUES (N'16', CAST(N'2016-09-05' AS Date), CAST(N'2020-06-30' AS Date))
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [NgayBatDau], [NgayKetThuc]) VALUES (N'17', CAST(N'2017-09-05' AS Date), CAST(N'2021-06-30' AS Date))
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoaHoc], [MaHeDaoTao], [MaNganh]) VALUES (N'15CNPM1A', N'K15 CNPM 1A', N'15', N'CQ', N'CNPM')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoaHoc], [MaHeDaoTao], [MaNganh]) VALUES (N'15HTTT1A', N'K15 Hệ thống TT 1A', N'15', N'CQ', N'KTHT')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoaHoc], [MaHeDaoTao], [MaNganh]) VALUES (N'15MMT1A', N'K15 Mạng MT 1A', N'15', N'CQ', N'MMT')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ADMP431879', N'Lập trình di động nâng cao', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ADNT330580', N'Mạng máy tính nâng cao', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ARIN330585', N'Trí tuệ nhân tạo', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'CAAL240180', N'Kiến trúc máy tính và hợp ngữ', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'CLCO432779', N'Điện toán đám mây', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'CNDE430780', N'Thiết kế mạng', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DAMI330484', N'Khai phá dữ liệu', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DASA240179', N'Cấu trúc dữ liệu và giải thuật', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DAWH430784', N'Kho dữ liệu', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DBMS340284', N'Hệ quản trị cơ sở dữ liệu', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DBSE431284', N'Bảo mật CSDL', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DBSY240184', N'Cơ sở dữ liệu', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DCTE330480', N'Kỹ thuật truyền số liệu (CTT)', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DIDB330584', N'Cơ sở dữ liệu phân tán', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'DIGR240485', N'Toán rời rạc và lý thuyết đồ thị', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ECOM430984', N'Thương mại điện tử', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'EHQT130137', N'Anh văn 1', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'EHQT130237', N'Anh văn 2', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'EHQT230337', N'Anh văn 3', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'EHQT230437', N'Anh văn 4', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'EHQT330537', N'Anh văn 5', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ESDN432079', N'Thiết kế phần mềm giáo dục', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ESYS431080', N'Hệ thống nhúng', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'FOIT331380', N'Lý thuyết thông tin', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GDQP008031', N'Giáo dục quốc phòng 1(ĐH)', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GDQP008032', N'Giáo dục quốc phòng 2(ĐH)', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GDQP008033', N'Giáo dục quốc phòng 3(ĐH)', 2)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GELA220405', N'Pháp luật đại cương', 2)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GRPR401979', N'Khoá luận tốt nghiệp (CNTT)', 10)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'GRPR433279', N'Thực tập tốt nghiệp', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'HCIN431979', N'Tương tác người máy', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'IIOT431480', N'Internet kết nối vạn vật', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'INIT130185', N'Nhập môn ngành CNTT', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'INPR140285', N'Nhập môn lập trình', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'INRE431084', N'Truy tìm thông tin', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'INSE340379', N'Bảo mật thông tin', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'INSE340380', N'An toàn thông tin', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ISAC431384', N'Đánh giá và kiểm soát HTTT', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'ISAD330384', N'Phân tích và thiết kế hệ thống thông tin', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'LLCT120314', N'Tư tưởng Hồ Chí Minh', 2)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'LLCT150105', N'Những nguyên lý cơ bản CN Mác-Lênin', 5)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'LLCT230214', N'Đường lối CM của Đảng CSVN', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MATH122101', N'Xác suất và ứng dụng', 2)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MATH141601', N'Giải tích 1', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MATH141701', N'Giải tích 2', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MATH142001', N'Đại số tuyến tính và cấu trúc đại số', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MISY430684', N'Hệ thống thông tin quản lý', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MOPL331379', N'Ngôn ngữ lập trình tiên tiến', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MOPR331279', N'Lập trình di động', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'MTSE431179', N'Các công nghệ phần mềm mới', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'NEES340380', N'Mạng máy tính căn bản', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'OOPR240279', N'Lập trình hướng đối tượng', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'OPSY340280', N'Hệ điều hành', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PHED110513', N'Giáo dục thể chất 1', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PHED110613', N'Giáo dục thể chất 2', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PHED130715', N'Giáo dục thể chất 3 (Tự chọn)', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PHYS110702', N'Thí nghiệm vật lý 2', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PHYS130502', N'Vật lý 2', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'POCN431280', N'Tiểu luận chuyên ngành MMT', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'POIS431184', N'Tiểu luận chuyên ngành HTTT', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'POSE431479', N'Tiểu luận chuyên ngành CNPM', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PROJ212879', N'Đồ án 1', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PROJ312979', N'Đồ án 2', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PROJ313079', N'Đồ án 3', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'PRTE240385', N'Kỹ thuật lập trình', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'SEEN431579', N'Search Engine', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'SOEN340679', N'Công nghệ phần mềm', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'SOIS431484', N'Chuyên đề chọn lọc trong HTTT', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'SOPM431679', N'Quản lý dự án phần mềm', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'SOTE431079', N'Kiểm thử phần mềm', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'TOEN430979', N'Công cụ và môi trường phát triển PM', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'UNOS330680', N'Hệ điều hành mạng Unix', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'WEPR340479', N'Lập trình web', 4)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'WESE431479', N'Bảo mật web', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'WINE331480', N'Công nghệ mạng không dây', 3)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'WIPR240579', N'Lập trình trên Windows', 4)
INSERT [dbo].[NganhDaoTao] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'CNPM', N'Công nghệ phần mềm', N'CNTT')
INSERT [dbo].[NganhDaoTao] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'KTHT', N'Hệ thống thông tin', N'CNTT')
INSERT [dbo].[NganhDaoTao] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'MMT', N'Mạng máy tính', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSinhVien], [TenSinhVien], [NgaySinh], [GioiTinh], [Anh], [Lop], [DiaChi], [ChinhSachUuTien]) VALUES (N'15CNPM001', N'Nguyễn Văn B', CAST(N'1997-12-09' AS Date), 1, 0x89504E470D0A1A0A0000000D494844520000006400000064080600000070E29554000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC400000EC401952B0E1B000009BB49444154785EED5D0957DBB816BEDE92000959D8CB36C0B467E899F9FF7FE4CD7BE7F4BCB643295032A1842C40E26DEE27CB2D8B4981C692C2E46B2EB6E4500B7DBA8B16CBD67FFE7C17D3142311C74915E1F0ED5CFC7C04EE7CD1B220963802B66DD17967F0EDFF9D1262005272005B1EA7D08844F31299584252157F6998184244F50B12624106ECF077525E0E3913438830B3C2D8C2212664E098E086119E704CACC9FA4EC6CBC2E4110233C5020D49258A2296DB79FCF9F6DD49C24411828A0E59FC30A2C00F9043AEEB52A954642990E7B922AE8FA29082C04FBEC7448130FCAEF83F0CF737C6F743D28A0C8250547EBD51A56AB542E5D912E73E6CB650F197D703EAF7FAD4ED5C528F8FC8B56D47B822534D9EB184A4448461488582479B1B2B542E5744DE737171D1A52FA72DBABABA2287C915C418161098470813810209F31406B4B5F98A1A8D7A726D4CB8BCBCA24F074734F043721C5B10630A8C204450C01FD8FA808970D9ACCCB24FD8DDDD163E212F9C7C69B2C634C9738BC6E88976420419119B26266375758916176ADC6A1D79357F74D9B7BC7FFF179B30CF08BFA29D1084ABAE63D1FEFE6B99A31E7D3661FFFBFF47D614976B442F295AC35EF80998A9DFF6F7648E1ECCCDCED0DEE62AF91CC909DBA911DA0849C9585B5D64FBADBF3B54AF37A83E3F4B3673E270D91CE6458768AC098BFD4648CBCB8B32AD1FBBDB5B22B28392589A44AB86CCCDCECA941980534703815F4B6A08996A4523211155E6CA32650E5657989010432D9CD0201A09212ACD60F8C32CD8B64DB3F333E4F379C0B5A35AF8A30B31958A1C661A8846AD4636FB3787FB47B90837C6CC7C166D8440431C575D07F02998AFCC51CC7E24C3C48F47F86FCFCC67D1A8214C88C21EF95350F03CB22D9BD89350CCB5A452B49A2C87EDB5A928954A147205A9167D260B3FB800A6C2F5D8BFB15D4511558A1642D00749B40345301318D6128D4631F4698808F4CD856525FE0DA554295A08418F382104621E3A9D2EB5CF3BE470396F0E6BA8106D268B6F9F240CC3C9F129BDFF7048966D717F01C2D1A042D166B2C08789662BB630AD8B85105C40B419C5A2CD64C15A61F8DD3444116A461FF46908C34C42D060644203B41262A4C94A1B098AA641B4FA9030344F430259A6BB431AAA441B217C6F360F98C3360B83D0A79023ACAC610D15A2D56485288161C87594F711A28590646D229B07B160DA2C0CFDA138DE31EDCA44392120230C228E646C3659E61162B3218FB87C36071C36D7906A51BA500E6460BE7A75759996971A32D73C74BB7DFAF0F113B962BE0686441DD46A08A8E71668321940A53247C54241145735949BAC52C9CC59C2BB28CD60A1437C7B11022BCBADF48FF221A37E27E31A7FD4228E95DFF25940B4750F5C819978281F18F53B19D794D7CEF57512C5980EF1508F65653ADE5C45DE5F1DAC98FFD86B99301358C4E7FB7E321CAE5A6419142179C6BCD7BF946933D1EBF7A53919658BF2815242C4140308E9994DC845EF8A22DBBEE77055087FD44210D2EDC99499E876FA62C6500794130235C1EA7253FD08A604AE2FD9A1F379A68DCF5B9262A883C5B1BDC5E6E0FCBC2D73CC02CA8529DCCCCA5221B21C0AC1A1249B83B3AF17326D165AADB6F07589C3C351AD682084EFCB7F2C260BFF3A38E27E8919A6CB0F7D3A3A3EA5ABEB01974F4BB50868BB331ED8EFB273FFF3BFEF648E5E1C7F6ED2DFADAF72C589CCD4007D4D818187631CC715AD5237106460745770C1DAAB4BB41202801413C2E0ABC135C530A5CC884ED14E08ECF545A723537A808D0322DBA1C88A33E7B9558A0184105DF6F49AACCEC58508349250472FB41392C47A317DFDAAAF5F72D1EE93C784DC5D67AB438CD010F891D3664BE6A8C5D0F7E97A301015717315BA2E314043009B0683A1DCF54D2D4E4F5B64B9F01F160B69172308819660FBBE834FC732470D306ED53A6353699B4106C4100D01291605614827474D99933F3052E07207D5E578D38DB8511820C61002381C7A9E344F652A6FC474D66E27F31EDC324D11A30801B06BA81A24839CF2D418318C90588C25A902FC16EE99512FDAC4380DF13C7584DC249F23CE7B92E2B1F9A3AEDDC443D7706E1421887AB09FAE2A140A4571CF9B957213772B2CC543F9C08F7E67D435C0380D29790579963F4AD8D384231BECC29315F1A43BF43C367FD4B5347FD4359C1BA721C56251A6F247A10093C53E24CB98B3203FEBDA43F9A3AEA5F9A3AEE1DC3042888A254FA6F247B1C8DA98DA8AD46E6816630811B63C8EA85C56B70F63A55C963E84FF71EB34418CD210D7F5C40CA22A20CA72D88FE0B1A1ACB9091D62948654E6D5EF525A2ECF887B9B02230881C988C298EAD5AACC51877ABD42561865CE4DE8100308E152700B755C8BE6E7D56F1B5BADCC938BD15EE14B4469B48A6642B812629BFCA14F3B3B5B324F3D76F7B6C5BEEFC2B9735AA7682304761BBB580C8703DAD9DD161BE2EBC2ECCC0CED6D6F50380CB8A3A8D77C292704FE1364E09D5218B7FAE3F73754ABFEDCAB8CC6815AAD426FDFBE21AFE0B2B6E0E9C2445BEE76E2F216B58F454B228A45BC536A8D239C3979C52CE081A2C3C3631A0C87E472189EAC485183DC098146F04F0AC2803CD7A1CDCD0DB151F124A0D3E9D1E1E713A13120064D386F6E722144908082F309DEB2E63211EBEB6B4698A6E7A07DD1A5A3A313A1DDC9907D7EC48C9D9054234004B6127FB5B6428DBAFAFE451E386F770431D8562A59943D7E56C64648DADB45613135BAFE6A79ECAFBB330578B6E5F8F8443C09964E728D8B9CB1109284B01CC3B266ACAF2DD3C2E24272E185A37576CEC4248B32B0D86F1CA4FC14212911711CD2DADA2A2D2FFD3B88B80BACBA3CFD72C6B58957BBA62FAA7C1E394F2624354D3886ECE4969617D83CAD88BC7F3B8E4F9AD46472B09C094FF13E47639E44484A46100454ADCED3F6D60AB70875134A93008C891D1C7CA676BB2BDE5EFD54521E4D88D00876D805EEC9EEFCB2255E973DC5C3C003401F3F1C92FFED7DBB8F23E68784882104F6D7789D1C22A7A525735E73370968B6FEA6E3A326938257BB7285FF80989184C04261E7508F7BA9AFDFEC880EDE144F07D62CBF7BF7814D3DBA04A3DF4EFDE0E022C8805654CAB3B4FFF6D729193F013C4CFA76FFB5989D449D4A579C894C42127F11D042A3AA759EE2A56197EB72913BCB0929D9ACDC23045F44DF02D3A91B1BAF64EE14E3C2FAC62A356A65D1CB9703FCB7904948D1F5686B7B4A465ED8DCDAA442D14BB611042737E416216968BBF77A5BE64C91177EDDF94538FB907BF799CB80A03E50A385859A5CA63F459E703D9B16176BA2CE13F548F05D43380FBE637D6D3A0CA20A989AB098106CCB746F4E1DE60ACB386DEE554EA10618F32ACFCDDDDA1FD86626C08670308D464D7E750A55A8D593F5C5290F76C8DD460847C6549D9FCC29D64946AD56154B8FD07DB72C8BFE0165B28D68282EE8CD0000000049454E44AE426082, N'15CNPM1A', N'Sài Gòn', 0)
INSERT [dbo].[SinhVien] ([MaSinhVien], [TenSinhVien], [NgaySinh], [GioiTinh], [Anh], [Lop], [DiaChi], [ChinhSachUuTien]) VALUES (N'15CNPM002', N'Nguyễn Thị A', CAST(N'1997-01-09' AS Date), 0, 0x89504E470D0A1A0A0000000D4948445200000082000000870806000000DACE814E000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC400000EC401952B0E1B000030C549444154785EED7D598C5DD795DDBAE31B6B2EB2388A222952246DCDB623CBF220BBED743B705B6EB9D371A3DB098C4CE80E908F20C8771020BFF9CB4F107F05F908900682FE4862771B7023082CA465D956ACD86D256E4B96440D9C6A78EFDD396BED7BEFAB57C5E99155F5AA48D67E75EACE67D87B9D7DF63EF79C739D177FF8BD029BC9C950F0E770B728CACB9EE7D9311CC7B60EB7459E232F1878A6D0D6E585C285977BBC41376F2F292B651EECF07ABABE24D5A9B22CEB0F566779A8D2DCE0B12139A317373E6EA4DD6176863B93A69CF9C836E40B8EE425818C476E21A18F0697916629B1C02D392F81C36594625A050291AE65798154E9E73AE132328F61FCC46F4C8C7053C8F29480CB5836969479CC0A1D2BD111E22509361F091903FF10B82EF2D0438FCF0F88D1DCF7095A9F4276514429BC5E847692236079FCAC0EB985C84D90862C2B9F4BC8978CD7522F45EAA7283CE6C9659551220AA382D816BA312FB23C311E181F782E67BE2836049E8F9065F35DC94155797C72BEFAA3EF6CB85F8F07E4A2CA2546AA8439AB854F8DC054CB3B2A2D9153051423E018A63C3C71379454DB9A1C1380349282D24ED384677D7814E6909876460C6E2A0C1FE73F27E733043643C89AD27403E2A940DEF470CD89B1E631BE7688668FCC2618F498FEAB9807531F5942C62BAD46884192C1A73042A6E5FA21C818F4B39889936FAC085B2BFB664A19369488D9AB8E6BBE73EB0AC08E0B9F201025A9C0C27B098871B3E37CEDD5CD4000DA61C376923CB3A0DAE79381520B6A0E94B8B6050B6E1A635B4940D81867CEB45CD66A81518CC8088CA2F0EDDC9098DF1A08C3A7ED5CC11873B458E35B12A6EFA04FADD26715722860B737C0348171707A063329CBA8C7A46DF8AC627F19AB96239FA0F759411A5E8335904260DA99CB1A4A10B03AB016323FD286DBCA8E1A0865A4AA04AA0CA29AEFB59656D09D799611F4E40F73E57A816E198B9C977EF45D3D3F241DB40804259A30D21A08AE1264E14781E0580D1811C6B6D04620181BC400A2DB67ED3320B0A066976004F1BC71331054AB7DEAED90424A7D0A9F71F7D301726A947349888F2E1DC3E3ED459CEFCCE360D8464ABED5CC60322A262EB2E9B83858C14F97DFC78F572FE1CD6C151F0C623841034148554C8075050CF221B25CADE77DEB743D10541986C2570645920BAF09001965A67D8715D71DD598B721E76FFFE8CFEAB20F49355054360D3CD65689A96DE0DDA63CC528D612579A629BC832526C6E1A68A8B2D86240E0079637350D29053CCA766D33692C6E254491DAEE80BC6CB2765C6D65585BBB8AF37E07BF71F014BE367F0A7E8B794F591A873611CB61C6AE9EABFFB159F1547833841C6454BD5796098A620DDFBFF8FFF0CA07EF209D9E226B9A70788FE7297D3EC83FE5CCA2505C9BE986274BAAF32E722A20D4A7541E015B955254032267B95356D6944010A98970C835D661DE63A76E4BCED77FBC11088A3A8ED9663286820908E94A4D37953756FF853A1988636984F5A74729531CDC5A81AACB2E55F92889311D6902E6652D654D545BC89099514A2390ED634C26448C20C9799D41CD98C77BA4B5DC0155259977B593E2A9A28D7FF2D03378727A818F3265CBBA8C5EB6F104BA9E311A914646FB42695AFE189CAA9689E5AFAC5CC69FFEFAAFF0CADA15F4C210ADB8C02C9B192A1BC4CC6BD3F19937BB7D035911370888C2162F369C130C681B71AB5C49B4CC8569688B92F796302881204D99D3305073E91910085CDA4443AD711B725EDCD43408C739DBDF72BFE4C94DA31A2F0D929228D15A93E24DC464FE3CA1BC3ADF60ADDF40BC316C865819F44C4335FD06B2B501194C00041E621A6E8D38C761AF8BC7BAB338D369A3D568A11D84AC3D6412E37E35B98AEFBFFB3A5E5A388DDF3DF151ACF557D16975AB04EE9C082D6A8A12882BFCFFF2F27BF81F6FFF1AAF5DFE00D7C20CC134D397914F6D13D7E0AA482CF3A47037F08E3C271825C4A1E098F7948F9A3664685033F904FF8A43C3D5F8A9FBB4D5A6824BFDA89DAE3CBE31C9F9DA262028823C67D2E3C731062909016124529E4A59358472D510A93BAB29AAA923A49AD8A3467068AD87514EB4BB18B0562C07098D3BE0B96001BF71F4248E4FCDA24BE3A84D660E9311C3952C4FBDE9D128245BA798708F46DE145A76CBDD5046573693B6A1E691708CD8A2FDE9A55FE1DF5EF9292282A0998666EDB498F79A543C65EDC640A0E13A0204698826DD416D959684AF7DE29A54EB029162551A553EEE929C1737790D8A5816F99DA0E9F6A4243602C154A184CE4B9E40A040D4C7EACBD854D0347111D3C20F3B01A4ACAE243D3CDE98C18B07CFE085E9C374DB2807B6DB0955408BED75F518E36059644132E9BECFE73D3665EA1F615BEE39F48CEE96E47A328311F3CC14109AB1489032FE1F5EF900DF7EF3A7F8057DFC80EEA5AB76BB162E83F6C6054287CD90547ECCEB31A120EF27C8D5ECD92D1529D66D00C2577FF8DF15D30849A5483D6F486D8BA424AE0782F54D904CB1F116816135AB8C45DDCA7BB4F56317FD90DAA3EDA2736D0D5F387A06BFBF741E5D5E8E088C84CF7464C7F2F99C1A437D9D19B586A2C8C85CE99D806A5AF68C182D03D0A11B79B794D2539066928DD3977DC17DA5D151E754D6C0CFDD01BEFDC62B787DF9128AEE34ED96B2AD161794EACD81204049A08217F7095A3DA75648C093CDE6AADDAF231A929E59D73C77433780D1DD33687C2A4BA242EA277D57900165E7143580028D409A3DB41F3C0CDA12688AEEF22AFEEEC9C7F10F172EA0CBA642E06293CC9A1322A74D90D338F3527A1711DBD4C44398876C5B7D341947230BCCCFCF998E8CABAD504210C95E510F6497CD5597F99F2238DC4668BD908F064DFCF1F967F0DCE1E388FB3D73BB1382466513FE54FAEB4979E21DBC58303E1D890F3284758EBACC3AAC08059E2DEFDD18B6466C1A6EF0AE61DB49498C6A04353FAC995E68852C8FCBAD4F57EE2A0F82BC011AFA70C8D8CBAD180F5DE9E19F9FFD24CECF2ED1574EE005E377964C8A4AB75B0591B81C1A9219FECDEB2FE307F11A521AB9411C510BCAB6B879B354F2A124D68B92786EE4F4FAF96DA4AD352CDB426511D59B278558B40900D6ECA634C4748077F2659C7C3FC2B71EFF0CCECC2FF1461A6A6472624CDF5B641A4EF9A6343396678A1AED8F3FFA293CD6EA20A43B99D1B81C14B706B0845C87218D9CDB707E1B6957812086895493C4446122CA28E69886118DAD7E31C03CB9F087679FC6D3E11C7CDE672FC4E8276FE85EDE23647600CB6479B3FD1C0B3421FEE8D86398A611DC6BBA38144CD300DC7B209E303725F87525271CD420D0564C4C7AB491D531D20DB172F9437C63F1113CBF74144DEA0175FC38213D1A03C4DE63A6A806A80CDF825E840A79C2EFE29B679EC4C124C272BCC2F2AEB3DDB8B1CE925DA30902413A6D3D38347D25F81A04756DEAD06E68840DBCD7BB86F3878EE24BF327ED156B46D7509EA0C8A57DA1B057C9B49BB67480FAB40E2FD3A2FD52FB107EB3BD848B2D1A8F14BCCAAAC6D05E17DB097B64D76842401063D45B391A02328C1B52ED3FBB7427537ACBF4C6703871F1ADB9B35870D5614EFF99BFD0FA083CB864AEC25E2695C7091C5AFA29E6D5EDCC327CF9EC47F0955507032244DEC01A4130356093110EE438ED2A1826A811C62032C2F37C7CE045F86C73114FCC1ED0ABD0BDA039EF8ACCFCADD0EED11D5E40882F9DFB181A0481C6424CD39D5D6E3908072A21C32E627B4F01417C48E99BA7BD35FCCE917368D27D1C8891B5EAB8E748792FF7F4A24C4EE363D34B787AF620E2FE0A9AB4219683026DEB1F60D358DEBA2B343E102AD02A50A395BBF5FE48B8E3D2D873E543528F494A15DA398E87E6BA48931E1B1179E4F72689B9321AD5D32930E7498A208AF1DB0B27702C0FD0A3DD1310F845C0A6F24EF9B6CD341E106E94C94A7826A5A1A4AA73E3166A18456928AACBD60B1AF83B873E42F73147D4F1E0AB0B6F0F1B86B72495872CD6D8CEB8C850E80594EBE1C9E6029E9A3B8C4B6E8CE9D4C35AAECEB61136EE02DD0408CAD8C6A0C19A699021F7321A77196B6A0EBAC516429705B6819C2CAC4CFCB1284792AF2209180785EF2705FA88F052E0616AB1852C8ED14943DE46B4DCA338B0268D7F3E8DE1804D835EAE390119461E7DF5C823984B320CC8DB4EB1FB76D02D3482B2B61ED4D7AD96CC0AA3D2D9933286F85F81FF7864BF7148F76BEC419EA6B81AB109E836D0E1F9E71E3A8736E3D73B78A35BE4F05E21F320040AED33E8EDE752BB8B2F4F1D47444D11B7E8418DC9B79DA2DBB059D92EB3A8411EACF4E6035B99F82FA7269065AC51421AE96C6FC8F4D8ED48371973A8FAA940223745447BE089EE3CCE76161068D81755281BD8E138C4FB8658DE7E9ED96888AF1F3C8D69F2F76A12F3A804CA6ED1D8F54D530A845B6905430283FAFC652A1818B863EED2986253B153FE0B35069FEAD2EFF7F1651A514E9CD8485C874D84E58EF1D6C6E4FD40561482214F222CB65A7881654EFAF1AE9B413704829A650509A01682064DFA14BE54B6393BAAD1BA573F690669043B1E8F146BC1B65300CB684D1F6CB7F164EB20D5A687A21122617C09D5A6B2A851CCF70B49C305AE0F1BB8449BEAF3732731E7750C20752899A37DED6C238DC46D61845C8D95CB3322B2DA2ACC30A3536E8006B736A944C3C358FF7BB46E070C7146C3D1864E132839059549C5FB08E81269048D21E436A45BB23845E8D0508A52FCF6A10B686AD6884611F19AD923DCB3F73755FFFDFD40EA53CDF308ABD2AA6C111E9E6EE1F16907ABD99ABD4F09C9BEC8CB0998C246706D1B18188DBAB25336C31ADB913A092B5A4C53B51C08E4CACF0DE9C7AABF3F0CF5568F19E443A581A3DD721884D578664AA1D61465E07D5550FF7F6D14DD92CA24D0287CBC93ADE258A3838FB50FF0DCBA1BA57C29E877FF5139E846469580F1D8F402526ABF9407832CA13C68446B481DD5F258FC1C971855392647DC2FE55AEEF3BC6A7CD868587F7FA091BFBE8FD8C90956A252AF4B8524BD14D2F02EFD241C0BEB60B118EB3006D5E0F20A1757FC089F9C59C2023543BA7130DEFD492CA24BAD171AE3A821E2029F5C781807823696A5911BD2AEAC70E4F94E9074ABBAE8A471B5ADBBEB4CE7D6EAA7DE261494264CA885B6D7C36C02ECFEED9413B5474E10CE130CCFCE1C90256A76C97626B15749B6964C04A90369DA937E1B1F9B3986248A11B052A24F756D9D4FE44629922D93A291FFA78657C2D7CF404139885C0D9E88634D1C719024A5C5AEF1F41933288DA04114D2082542155D1D44779F4B6562E03B78948ED413338BC882DC46315758BC6F49FC94BB4DA58B584D41500AFBE3DD45749D0019C160F3310884BA62DE9674DB6D82C46D4D380F246BF15FB6971493927173D648CA9E677DDBEA58CD801981DC7779DED5EC616E65C26D0CA650EE9C98B06CCAC1600D2F4C3F64A399A322BDDBD8EE299208341F426F255533EB26E2A9CE0C0E3402AC26E59036F544966F2E25C95B90784954A50E8DC00D21A351B83148FB88EA584B50945CA746D0A8588DB32B158782CD69142098A17232A5B67A6073280B71A7245CA6D4306D1A44E7E60E59AE02EAC9725C4275D37D4A6657193F4B575CD54B6C9C6B85381EB6D91CE748682BF9563975710C927A6128EAC0385C0A5D201B0D36829ABC2EE150EE9BA6E77919E6C6FCD1601950D82152B354A4194ED35B383C33C57648EF28082C15BECEE50344329E555B1FEF2E21A43D96796A3AC80C6B1A6E2F08E996DADD36979BFB7AEDADB52042DB96FBB24D14A3BC116DCD0364F44A41D57A5748BAE7A9998398A741A4D5508463A3071008AAD06E96E2F1E925B46D9C634A0165D4CAD50DB720DD62BA5CED7F1504841A3EBA5E47235FCDF40541A7ADCED77C9F08102C33558ECAFDC2DE259C9F9ED74A38369347CAC0727FFB0A70FF11CB2F4D7CBCDB4127A42B1FA774A5794EFCDAC40FF1713488ACE9E77D43ADCE43D576D95D7AFDADA07DF5D4D620D0D6E6539A44260004CB2333457B103D3747939E514EB338E4FED9A9196B16E426F9BCC706713E88A462532B489D2F151E12D60E47BEF4267648F05AB3C921EFB47C80477E697CA76C2B4DE7AB3BE1742C00258C7334A48A4FB69F85BA1191D13F0120089D421DF3895516B091B2CC5E8E1916622668DA22555A842BB442ABA4DA3E78A41770EAD53D3FB580BCC1B63E61AD95A6A8AE0F89ED884680DBA45B5E1718CADEC211E2B1797CE4ABA60C0E8326D0320CCF6B8AE0A480302422BCC144132239A51638DE9AB5D3A5155D1A31DA7F2089C5A6DC6CD8FEE1CE2C2B05F9719D74ED3623EBDAE751DDCF20CB5F0AA40E76BDBC543E74B330423B0F04658C89CA52D56BEC8800CCE8369E692D5866247C65BC1ED2FEA0929977D4964DEA6F2FA660C5B3A134D7A97CD7530BBB0ABA979AA10E6608727B2734198D2061D31D0AA511E8236BC1A793CD5223D42078D0C9AC776A8403ED699B652D2058C5D82C4F8140422ED16041CFCAF03323D042191F9F1E9B262601870D9AA67F6A95144D599BF7AD2B651F0415C96C5373FD707706013D2A5BC8CC34E40812AA43EBF91506785D4B031592FC3A2E2CF0A29E189B765C0ACA93FACE0B0A5EC3D2B45AE8144131AD1148FB54913A805831BC0CD29341DB47264BD168A340D5E5AFEE7E858CC84965851734FAF28DE14ED77CDC712008D41AA61EC71191CAF68FB96BD15B08E54FEED34652ADD1A6DADE8E6A399BE2B851B803DA712088F48653EF165450A9405BF1CC2D9B867DDA1ADDA1BC6F4A130182B22B1BC1D653E6BE8DF1A71FBB4F9B68BBA47A173419205077D9D2B1D68F2E63914D845943FB24524B6041461FC938336EFBB04DB4F3405079E8193422173DEBF84831282282A22AF53E1969DD0F0D5849D4052FCD49BEE965D4A4B4C4849A06E2615820EDEC6B83EB889544EB43684175F5BCAA09BD430F704B343120ECD3ADC9D590406E35B83CCA337B7934C9EA72E740B0C66C24ECD3365051761DBB0EAE2511A2421F26D11BC2C931F82640B8710636E7CB0EEF28AF932BD83D45648B8090D228B8BABA0C2D1DC88661A2F6E24D80A061225252EB212B343F2F41EA72DFA6C8A744F0ED73AA3B6C3C020B39A0A1A81EB4E524C65B71AFBC619FCA26C0A7419DBBF879B46633C68A805050F7FB84D0305ED3C0BC68F0AA326C0B68F3584742EDEDA86CE788EE6A5F096ACE84A683EFD33AD95B67326795BCC93DF2D83C86C9B90DB7018232518952E0646EF5D3F8387D004CDB71F06A2F4778A7064F0A40318DA1B54C53C1F76948E4A738F26E7FD986A9697EC924DD861B0241DAE87A8D245555018102D5D2F8A58EB80DF1967279DD4A9BF08480B0AC55CDF7A92232897F030AFFDDB5ABB6E8B73A16CC581C83C5DB41D70161140036E8C1F6CA8C966F37F43651630CA511CA4BE390949CC6C809089AF0A9EF90ECD346D2CCB2E5A8874C734035D37C44163B4DAE3E5757D05D51B021320C81EFD987243D8D1A626E721B54E2DA47B27C6A05CDF1B7914602C1ED32CBEB364C9228CF6868465E8605771ADF7DFB2D5ECC700D917D98826633A28406E8244BBF57887CD477A8FE7AAD87D78A08B34983FCA270048809B1C326B858CDAF828E35064E9F8FB11B0886F2AB61BACFE465F7E9D5F29D0C8752E3A039949AC1A011B757642310492D10708C5D31D9175D2AADF3C0112BD75BD1326B8D5FCD729260CA4B93200281AD7E15EA7183EAE2ACBF1F58034179B2099C0A3C2A27C79691DC8EEC5996CBBC0D068DA98FB8732D8E10661EBC4473F77204DE5856C7FD476210C3EB6B1FA2E587D4C2D4CB1AA7AE5A372186181044A3DB3A886A4DA10E8F8DC1EA38EFB3DB6E4DBCC7B40D81A3A02685B6315EEB5D2B9990B2D9503C7AF3F2805242A1FF9FF40A1A649606F96A467AC99CC99025570B5D529570B56287B480B4819A094D97B7153DA80B3448525B7D6646BA611CD25D7A4E2F56E4414823AC16295E5DF950064445D4066A8E2657F6BD4364FF2089F0B6D367A528BF5F2DFE4E9268C3951FD4D4A2901E6BAD5631B1A641ED39836ABFB2A43170C3C91139DBB122A03A196F70893A47023E6353EB19BC42DF590AF0DAE00AFA1AB11B525BD0501C482756987C10C834ADC04FFA797F19FE9ABEDB14D0B54ED016D355412784075B43C9823A2F98A8BE1F6013261894516546F929A74969F64CE904DA17D3C6919A9EE5AF1C4C5906FD421A89977AAB788F35414BC968CADB767E5EF85E20E3AF02E922B5AE06EB88375ABAC806FC5A77E364C895CAB6C0DAA8565F5BD1D056B023927646C39DD00D9E11B8D6FA03360F17CB139E9CCC3B8DF8DE266B9215C8F20F063D24AC073A9417A5F59B2749D6A56D8109CB2554D869520A0631D7C3FFBCFAB66520E1BE6AC38346067DDA4D6F0F96110B08FC993B4D794C120A74E2A40718B867AD03358265CEB25187EDA6D2DB68B43AF8597215C94A4A75C8CC54571F3492D03F1CACD8E41F71DB8030AE6FBE4D542E9D9397A17AB3C4D36AAB3787ED241514F073077DEEBC9E5C412B65D255B3F4A0915ECA25B48FF4B5DA866C33560A7DC17692EC70B55ED2D0106466346FDE8C3AAB9FA3A1D413DB418A495AC8517F7AE2E08D6C855E850A3FD95AB057483A79C0AD71598B5930D0742E39BE7D6CBF2595A9D54134A184F509E02C74D18F23C4FD88EA412BD28A250F9E5690765C89FBE48787986850E79A5EEA911D13E38640B83BC4124A256AD876A7FABCEF04ECD43D4972DFA783266C9514BAD26283EC8409D549A38900C1E4AB7F95A4F55FC622E2041D3FC4E199797BF1A91EB5C9167F6F907A70CF4C1D84D78B6D26B463EBE1880F25BFEE9A8CE76510EB6F55D1761C084A5B2F9AB497EA553473E3A4393C0ABDC7E6E04811E2486BDA72A99E4CEB647980C8DEC150E6173A33D6A32B9BCD8B6441F1DA16EA84E2D5A29B5A8CD33CC12A94DEC8E630098D40B95AED678612B6037A0DAD8E9442AB8C16115E983E8CA38E6FDDCC65961E2C3261D3687E766A0E276617703989AD0BDFDECD904F77E539F0999420486DC5D514857D6F4B0B7089C37AC73D1A26040495B37C41E5A0BD9A222452E3B6832BE9321EED7BF8E4A9B3B624BDAC560D7C19BE007B508842D3CBBB0361137F6FE634223FC6A02B6391D7B6C00A4FAF001887F8EA697CA979827584DA6E8C7CE73502D3D38B2B41BF49F0C93BEDF55730B5DCC3EF9F7E02C7BC06855FBEDC72AD2FA37AEE4122C98495F3F9F6613C3BBF8868E54A796E8BBCB077480685323A596037A309340D2C0DD1E8F93E1222BF17E4984A527C63E10C3E73F008C228615B96DB9B47DDFAA051291A07499122081DFCFD43E771CEEF60906BF8E0F08675D2B9CDA126EE5B9DE3AECD3867E5D34B4419A31BCDF0CD0F4E0208248D5EF65C1F7D0A5B7D05F3CD2E9E5A3A6A6B2E6AC16F9EB26CA66CCB862B8332947D0ABCA8F7207A235A65DEC634F078CF53C56F7521D70379F4B37DEB38AACA2461853E06B4938EBA6D9CA017D523104C7265914BD2ADAA309B83C5CDC07D19847238247CE9029B8FC2F4653C1AB02CD2CD81FF5F7CF57BA3496D3F59ECCC04FF5BFBCF1DD90C1AE8F21916F8B3D3C7F0DCEC927DB823E22F48C2F2217D739F3EB580E1C5D426EA87F71C5EA719254B9805F53575780F93A6AEA5AA95CCAF8C65FB66268BE6E66C07CC555653580AE38D68052F5F7E07DFBBF236DE4E22241460974C917A1F9278E7560021D5F694550A069F952AA4E16D4BFC53EA29D32134D8EA08247A9CE9DFE49B5B3B0F04115310146A208824E015F411B200271B1D7C6AFA289E993E88C361176D7A14FACE9719B5090B44793B9AFDC367335AD55222AEA7A57726A2D0EE9A061446C430554D0642AACE12E63BD2073B0ABCC99D1FAE7C889F5D79173FE1762DA390FD26BA7E1B7E3F474C0D69B5BC961CCB9FD30B50D5AE3F7826A0D8D811D67A19841A655E5A05D411C2079FB7A1854220CFBBF448760F089BA8CC52813006D668330CE8E6A88F5D96F2B1761B87FC162EB417F1C4F4013CD498C6AA9F6391C5F31332C72F572D17FAF73A10F409248779CE09E6A8EDE3AD6C80FFDBBF8AD7A255BC7DF5327EB57C1957D904C4BE478F89DAAED1E4336C46E3826008A93935D07F1D08942701C0DA614028CF59E522086AAAF76A591B08785676B8D482BEC637BC38423B0784CD391A215D12405D42B6A7852128D366465598388872AA458242AA5473210AAA86C75633FCD38F7C1607C329ACD1BD52CDEAB0E6E4A661C4A8324EB58BBB499BED16D5D6952CC37FFEE54FF017BD8BB8C8B2AE0E62CCA36DAA5B6ADA04AA177E590A8706B5E68CC4D611A4AFE0F1BA31AB8C4F40D077B9ABC34A2B9446A17E6A02B4689926CA08206A7CD43828E8A5B296F0D704DB610423B445CE29971B43699430A8040CF5F106E2A15DEF7A689377533DAA3B32EC2ACD8354CBD437DB705B6D2A4E1757D72284335368F31CE86198FAF34BDB409A41CC2EBF4DA457DB9BD2D92952FE6D53ED5424A15AB03C91DB2C568746B23F3F8DF7920132D6F403C114E2B6878845883DC6C0BC076188A41BA0EFC61424ED243747C353CFCBF5E5910C2D7E053BA6BA671C6A0EEAEF739B06202F044BAB26E28D0C56457013DAA2465023AEE8D72126034568F6A9EE64B1A6ACBDAA280D574660494AD0906ED95646CB2C08B15A95535F996B05BCFFE2153C73EC0CFED9A90BB66AAB5195946ECDD88EAA06BD55F4709A484F9A5AFEBF59DEB093C462F7A9C554D75AB187D7A9E29B8D10A768EBA82443034F46A27AF30886EF7C7811FFEE7FBF8CD5C5293434A94CC51E16A63CAE816CE7C51315B2BA45A4CB9E9A864D64ABAF6A28811D91A71548EC01A33A121ED779DB44DB04849A34D6AEB4506D7614B7594A60108DFE081044966895F268DEF465DA943545C6A0B716E3486B06D32D7A0F15E074AFCCA15ED4A3EAF3B04686BDD7BF847FF9C8A77176E62095EE0428A20AD6D7D9A4C6999B7FF1EA9FE1976E1F073D6A331E7B1A8C4BAF4083725513036A8601B37F51F31A0918AF9CB460649A51F2D141CD885A22237C1149AE6A1AD6054CE23D059B98B2815C8F6203DD24BE51DA2210241C81613D057BA961EA5B6E0A81611A4116EDB04EDF94543E9F05A5A980940C1253F328A6A1C31355FB2F95A89285B64EA38B15DEDFA105FEEF8F3E8F035DC2608B8DDD38A422CAF8F234149F79FB473FF90EFE8A4977237DA24F17591974CD4A10A0C5730D3DC8AC0F087487F6CDDD90F863C6E250B2152933E4F956684B4F2B6365A03AAA824A6BD3DF9931F394B92DDBAFF2995B1219150B380C8501887A8006A3EB69A5D691C09A97E913845AC195B5AD953A680A285BE3C5D894A9F9338133C9418147DD29B4AEB141A377E0B1AD6A52ECDDA08D29AF491B410B6CBBB894C5F8D04D90B40989717871035215B0F67F53D06FAB7477AC53BA37495B9955AD3530C888B1ADCEDE86189FEECA247832AE450DE2B15969050DB30F6455AB23C6A351A9F3EA99D3E774A7FB296632BA954E4AE3528DEFCE939F10DA4C2A61FB9F341D1C3D75A2148615539D6529925486DF801A60055EA3C0CC5407DD224033D2C093BB179C045F7B02438FA04C784B741320B09A6D0A19559AD651D2CA0639999E93131A3FD1A405DF607BAEA07D2DB32BF7254A120C228A86353BD5A20FB7CBABAE933FA126E0EB8BA8368632B4318D36A6526DAE6557FAC5A5D0536A9C146BD33E422FA0E5CD7C98B3BCF39436D57CF569D796135166561D9BC2E7CB38ACEAA97D8093850E9C26CB40804774FB08705DDD8ADC344BCCA7613C0C9A71B673401009B57528F36EC1CA210C9686DB069DCF7DCB52756ABDB91893F8B034AE9E37F7881A458F2B984761C1FE6CE0AB8C321D4C13304DEB6ED6959D271BE4C1B48D0FCCD234BD82904796755E2B836ED41FEF33ABBEE485AE897777458A8F716DF829A1DBD6B2DBD36DAA9012280B51AA79B6FB235B153CA1E4B4389682F6ED957345A5617767648F8C3CA6E3E1B9916B2E0DD08CC2507B7D28ECD06D2CDF4B4C825C5AE9BED360F9C901E6E760B38D2E81283ED502DA403C34602B6CBE76A7A4C737876DA0B175A9DA7C2D97A105B1CAAD6A2385C1609D1723611D003B279890465894B38922F88E37A72C2989612264DD74F4881498EEA21F62BE2160A8BCACF56566EE29BA3110CAF26C288C842BAD20440F7BB2182408D904752835C2A687B79954F302DF47440352730467C39679B112CC44C88AC6B4980795B7437EA803CC54BFDD5055D49D63C1B6D3F54060E6D55BA7DE416BE7785C6DACF6CB4A55EFA10652E8A4BED424E3AE0ED217057DFC32A853A9FED2FCF691E49DD165F499C67437C093ED39EBC10C54532740B45B69A8CA705385C8D1083D9C75BB580B43787913611222E539B9B4F70A166EC839014005302054541F0BF5E6C2B026D6CDC0861F8FADCF9BC1AE5561BB29655A599AE0A8DBC04CAB8D425DDAFC4D84988C523293448107A7BA73CC94BC29359B65F73A19A4BBEF09BA6915B28296BBB62D5BBE753BC00CA39B0858A77740F6EB44FEE69A19134778D29F035D736A23255A5D9F14D5E99117E7660F6221A6C14CD7DAA35FAD3782B186A74F3A4F774963EBD2D2435628DBC1D25BDE2DA23660EA2DCFC7B33387CD25F3649F58CE76810884471A6D9C6E773170F4F681395417F3BDA3106E0E0495A11479591AB1D97E2C65DDA3555FDB71AA9322C32DF040C26FB79B78B83D8B96C6FFA57A6B395992561409805A12EFE1B979F4D5D5456FC649A8316D14D5BD413704828695DB9B027BB1A3375B9EF9CE1A48616B28D120545067C98E1379AD555AD553A7318C7AB9E2B801B26BCB786EEA10A6C2C006C50E5CAAE4095741358DE649C91E48D93C4C2FE24011129432A6D92CD08651B5B93EEC3DBA5E92ACF15AEFA89E2A2FC66BE6B24D9B1F099AB23609E34C5AA9D90CE1D018D470F8B53462AD4B71B4D1C2F37387ADBD627D84176881AFC90361680C87053ED15EC0D3ED455C2B22B4FDD05640B10C6E0893CDE3B874E32A6D8D5C15EACDE8B9EAFCA4C88D349EC1C36AD687DFA106E82DE3E38B4770729A963A2B98D626949EDA4DD26A273374977F6BE9147C2F478F46A3436D55CA7D17987687746320EC25626D4BE318FDA85C7DCD5DE9E17CD0C5178F9C4647B96733EC93C7052D742DC8B55BE4B11518A4313ED159C057164F628DFAABD9932D53DDB0C769F780A09A5285A10D28BAEE9C8C2EDA04646840AE1E4E5D7CF3E4E338D7ECD02ACF10E9B381BC51268414EFAE115D460DB9F7D214BF77F80C3EDF398E350D48D5B56161D41B5B92B655F1AA9DDD23656D7780A0828B43ACCD3975BB4B632F504E28D824C86D16AF7AEC029E0F29FC7E93358E86E0D24A8ADF39FD389E5D38C0EAA739537ABEF4646C8CE42E3254638B1B4E8084E558A07DF0D22C9BAEF9595CCA651CBAC85C0709BD099F6EA53C2ED9337A8D9DB1AC7D2FAD40BF9DA4086BBB643DE827C75FC1F6E9768BF7BB32AF417994FB9791010D7A00C2401C2788A85A6783A6CD6A1AF026312FA76D90F7D6700E6D7C839AE0E3F307E0D22A776D706C19DD9E20F1B9ACFEE853E01AB8BA1C03FFE1E25BF8936B3FB7296CA7BC2E02DA3BEA86BFECC736EEB14BA0B723A0EF97AEE6F615490054A6D6C9A0B10971D46336D27A778040D2A0CE24EDC16F51F0D2046CE3354CBD3D204A557BBC02BD2CB1CFDFFD6EF710BE72F6099C0DBBAC45742579BFBC19CDA7DC3324D7954CD608622D5AAA10D2BB4AD70AFCB7F7DFC07FEABF855FB33CDDD845C42AD86C3651A4391A2C6FDBF1B1ECEA8B36DBE987090402C37A8C37EB0D6ED0D0DE1520284165C7C963FAFF645EA07E0A66BB47B7ABD1606D49D9D626F89CBF883F58BA80E30B53645AC2A6427D1A5A0022A75DA8D51476A765BB111519152D55BD470DA6399A220156E325C2CCC7DA20C19F7CF8D7F82FC9AFB1D2EB234C694F141EB2204416FA68C6D222DB0783CD40A841A075134A09AC93A6E36D0D08633D598BFD7A929B2520380442A0F1DECB7D0CA60A7CCE5DC0EF1DBA80870ECCB2A2D115A3BBD86D77F8841A33BD70629CCC7C39ED6D6F90F532F2AF2C69F95F5A214A0768B2294883C038B1DCEBE1A7CB1FE03BEFBD819F44CB8835BA296659583E7B4A3789F8ACA2341D51465772B2BEBE9974CF866BB203048475F2A869037B13BC7EA31A2A4D48BE7B20F0297BB0CAE490786CD3B47951EE9E50AEDA227BB94C887B3CA7B62AA22510D12DECA4052ECC1CC2134BC7F1D5E621CC74E87FF3D1C2A6865303B0E668FABC3440AA81AB7C7E4F7EE4639493552FA79ABD9E9BA2C5431B822F497A21D6A83DFEF2CA3BF88B4BBFC62F9335BCDB63D3207EB19CD66FAB5ACA0296ABCDE46C128126ADE2BECF635E50BD5610A32D25FDD303DAE89032909D622BA7F07C4619304A1BD0B39134AC8070D80A10346E61F3C32E0D259A772C948748EA9219F1E5FF6BA6AF4B4132D1015D2C81E37CD0C2A3338BF81B7387F1D1CE0C3A6490750ADCC724CDA1AFE3F8B26FC8BF953CC2A5C12A5EB97A153FBDF63E5E5DBE842BE493D76C634A824D344148AFB7C96FDA16B6282A41E4B0C9B1C5B158CBB5FE413976515828ED0CCD81F499C054A3C9732E9BA69ECDB66ED238AFAB6449BA7B2BC6E208101495110F3431C5A6ACD150EAA806F4B5EA418E95030DB8EF5DC1719E7B7AF108CE2F1CC1E7A68E10307C4EDA8AB5C6DCAAF5C96DF725895F36278286A255607A0B3A47078AB51F7883CDE00F344DFEDA45FC657AD9BCAA8ED3E29500030A7B8602064110F1A994C0D0C4594F954C7D16048522D3FB0F01411A435DDDA23E3D320DED0B3718D8B5F4B61908429A9F530350D8FA76DB5A3130147799D967BC797C8CAAFFA9EE2C8EA9E6C76CBF1A32FE5843A83E4B154800D928A721B4EE4F22D354564DE25183A7413C976820CFB1ECFA668328A241FCD6D52BF8E1D5F7F0E797E8714888AD5944CEC0BE7F4504C04B685BF459F3D96E38FAF889F8A63F6A000D1B54F3D4A4E0A585623EAF0A6A634D87741740B047EA3BF52C23D7742F26372425386001627A034BF4979FEE2EE219D6FE53ED193CE24D11AA8CA0E9D232C888D03EA65216C66326583BAC0153FBD5604615FFFD4A6A1A68E7582592F1C6FA20B6E46C4A1D0A4FE735C84623C2356DAE49FE88C73F59BE82972FBF89FF459BE2326DA7359E77DD105D6A0BA76035A22D25209896E1569A5976983ED42A575DC78A5B1DB11BF9AB833181A01B347C5C7337158F2675C854D3B18D4DA0AA72D9E607CCDC8570069F9F3E8C13F37338D16ED90B2144544B7E667EBF2C575B0D9E82D78C20578865EE9506F37DDFE3C00A4A5EC6947EC29A4D1D60BDA79A2E97506BAB334DABCF79ABD4A98D107EA04E357541F141AAFF0FE966BE1E2FE3FB1FBC891FCB9E60B3D0A08615602413814823CE630149C9D1C650A27A7B4B4BC396DADBC8601DDC413F423E208ABB0D3EE3D0DDC9714D7D006984A924C769BF85E759F33F36BB8413D3B30899A811255B1A2642EA48EAE5A97DBA1BD25A1201114353EA9DB887D796DFC5CBD756F0EAE54B78DFE9B1F968602AD66A342EF2460303AA002DBCD1104088096B7A6EC0FBF1804081F64317F3AB399A0D1FBFC22ABC418C4FB797F0C9430FE3C9858358D49B3FC6A431035434D583EB74A31EAD7DBA73EA33C89CF6A941AC9B805E9666FAFD6AB086FFFACE2FF083AB17B14C2D1253661A4CD4A6C6955D206351CD4D50198F9B69BCA681913669F05D63EB7E8D6DD5A7E78FE1EB87CEE199E6025CB613FAACAF3E21AC59C9A6DFB560D43EED08ADA489CDEAB205CCD9C4A8FD8FF21E9B066A6B7A181FC431FEE3C59FE3BB1FFE929A809E9B0C73363D893C098A46DEDCD81A4127CA2F95574F7077D5D70BF701BEB9F828BEB174167ECBC11A21D9629BA399C1EABCE8876A025CD07C299FDBA76D27CD0257C594F1672E24B74DB6160D1A96A62D1AEAC7047E16ADE2DBBF7805AFD38EF09716D1EBC5B43D3C04048EE4AA384C4B9BB065F36DA21A0432E0EC8041AEDD543FC33F587A0C7FF0D0A3F028F09CF68132602F88A8AB22DA057E4C2B58A0D8A71D235531566EAA7BBDB9F430438B3DD0EB6F87007042F3C0B492DB05AF8B3F3AFD099C9B39802B972F639676DC54A45E5DC552BA9A0283D970FCDB0004C95DFF5A3DA2AECDC8D31E2E7B3D1A187DFCEB134FE1A5A5A37C98D227E4DC202CC7EF3343EAEE6D68314C02842DC43EED24593F807A1FD83470DF961822FF352AAE41DBC0BADE69374494C329B7897FF5D027F0E9B945BC9FAFF21CEF2712727A1E3E6D3A4D5C2EB4B60185BE0108653F41814B331E96889EB4CDD828F817E74EE291034B94BE104548A9774BD8D47EB957061D57E7F669A768C8ED92D70C7654FFABB71A00E315E8D08B78E9F8E338B142AF4F8BB5B4029B10A4613D6148F7946092D8370041A4385CBA2797FBABB401227C219FC1374E5E80ADE8C9EAAEEE4BDD547F4D7E9FF62669CDA682DA412BC93CE34FE35B679E81DB5BB5F73C5E2BA46433C4342CD37E4C71EA2516652979AE8BD4416B25C687AD14C7FA0EFEF1E967EC1374EA8CD0030AFB00B807881557DDCC1A4789B51E9E9D3B88DF3CF83092CB2B5AA88A159A4D0B2B7543AFC729CFEB34828010A90382A6C01F1E7E0C07A7A79039117CB92A1500A415B4448E3505FBB42749DDCBC2409AC788DBB4FBF20C5F3D7E01A7178EA158A33CF54698F6811C01919B36D59F4DB7436E899B2288232C87093EE5CFE24B871FA661A1E5ED1AB40DCAF7DAFB746F9044C5AA8A909E844F8F81963D0EB1DA7FF3E4611AF5059B051757794F238AEC66378D132414BECD22CA62B8ED0616FB393EF3F059D30252197236641EEED3BD437533AE19697A07A13FBDBEBED09EC399F62C0645C44A9F6310DA557A1F7227B8A32F95678187D56880E73B4B786AEA00F54A62EF16842C3639FB748F935E12CE15217EEBD069B4D9FC77B31CAB72F7D93AD041F0CD8D502F85A6993B6B31BE78F411CCF0622113916D89FAB46D04CC3EDDE3E422A7EDF7DCDC617C24E82068A8F6575734F256D3B8D553955DE9E1DCE2319C9CD19C426A83D0E37DD408B227F6DB86FB800A647E018D777AE1D029BC9FAC6126A54A601D2710E86BBA21DA9AA243EFF28B478E604ABD577A9B68934F7817776FE45FECD3BD45EA55B405C792029F993E8463618BD028C72DD8D86041428B5B1F6F76F0F4F4AC3DA4AE4C7533C83EA86ED9A77B9C3468255017805B204C33FCCDF987B146A3D1AEE96D9693A6F8D08DF099F987B0E834A94184917DBA1FC98B33FBE4A2D691FE42F710ED423A0BEA50B22FA6312CD224F8D4D2C97250E93EDDBF14F8367DBFC1EDD176071FEF2E5A0FA4AB49287D2478010770844D838D67DAA7FB92286FC46CE2DB85073F2D30A09DF8B7664F202D0AFC7F84CAB7075B0B1C830000000049454E44AE426082, N'15CNPM1A', N'An Giang', 0)
INSERT [dbo].[SinhVien] ([MaSinhVien], [TenSinhVien], [NgaySinh], [GioiTinh], [Anh], [Lop], [DiaChi], [ChinhSachUuTien]) VALUES (N'15MMT001', N'Lê Văn C', CAST(N'1997-01-10' AS Date), 1, 0x89504E470D0A1A0A0000000D494844520000006400000064080600000070E29554000000017352474200AECE1CE90000000467414D410000B18F0BFC6105000000097048597300000EC400000EC401952B0E1B000009BB49444154785EED5D0957DBB816BEDE92000959D8CB36C0B467E899F9FF7FE4CD7BE7F4BCB643295032A1842C40E26DEE27CB2D8B4981C692C2E46B2EB6E4500B7DBA8B16CBD67FFE7C17D3142311C74915E1F0ED5CFC7C04EE7CD1B220963802B66DD17967F0EDFF9D1262005272005B1EA7D08844F31299584252157F6998184244F50B12624106ECF077525E0E3913438830B3C2D8C2212664E098E086119E704CACC9FA4EC6CBC2E4110233C5020D49258A2296DB79FCF9F6DD49C24411828A0E59FC30A2C00F9043AEEB52A954642990E7B922AE8FA29082C04FBEC7448130FCAEF83F0CF737C6F743D28A0C8250547EBD51A56AB542E5D912E73E6CB650F197D703EAF7FAD4ED5C528F8FC8B56D47B822534D9EB184A4448461488582479B1B2B542E5744DE737171D1A52FA72DBABABA2287C915C418161098470813810209F31406B4B5F98A1A8D7A726D4CB8BCBCA24F074734F043721C5B10630A8C204450C01FD8FA808970D9ACCCB24FD8DDDD163E212F9C7C69B2C634C9738BC6E88976420419119B26266375758916176ADC6A1D79357F74D9B7BC7FFF179B30CF08BFA29D1084ABAE63D1FEFE6B99A31E7D3661FFFBFF47D614976B442F295AC35EF80998A9DFF6F7648E1ECCCDCED0DEE62AF91CC909DBA911DA0849C9585B5D64FBADBF3B54AF37A83E3F4B3673E270D91CE6458768AC098BFD4648CBCB8B32AD1FBBDB5B22B28392589A44AB86CCCDCECA941980534703815F4B6A08996A4523211155E6CA32650E5657989010432D9CD0201A09212ACD60F8C32CD8B64DB3F333E4F379C0B5A35AF8A30B31958A1C661A8846AD4636FB3787FB47B90837C6CC7C166D8440431C575D07F02998AFCC51CC7E24C3C48F47F86FCFCC67D1A8214C88C21EF95350F03CB22D9BD89350CCB5A452B49A2C87EDB5A928954A147205A9167D260B3FB800A6C2F5D8BFB15D4511558A1642D00749B40345301318D6128D4631F4698808F4CD856525FE0DA554295A08418F382104621E3A9D2EB5CF3BE470396F0E6BA8106D268B6F9F240CC3C9F129BDFF7048966D717F01C2D1A042D166B2C08789662BB630AD8B85105C40B419C5A2CD64C15A61F8DD3444116A461FF46908C34C42D060644203B41262A4C94A1B098AA641B4FA9030344F430259A6BB431AAA441B217C6F360F98C3360B83D0A79023ACAC610D15A2D56485288161C87594F711A28590646D229B07B160DA2C0CFDA138DE31EDCA44392120230C228E646C3659E61162B3218FB87C36071C36D7906A51BA500E6460BE7A75759996971A32D73C74BB7DFAF0F113B962BE0686441DD46A08A8E71668321940A53247C54241145735949BAC52C9CC59C2BB28CD60A1437C7B11022BCBADF48FF221A37E27E31A7FD4228E95DFF25940B4750F5C819978281F18F53B19D794D7CEF57512C5980EF1508F65653ADE5C45DE5F1DAC98FFD86B99301358C4E7FB7E321CAE5A6419142179C6BCD7BF946933D1EBF7A53919658BF2815242C4140308E9994DC845EF8A22DBBEE77055087FD44210D2EDC99499E876FA62C6500794130235C1EA7253FD08A604AE2FD9A1F379A68DCF5B9262A883C5B1BDC5E6E0FCBC2D73CC02CA8529DCCCCA5221B21C0AC1A1249B83B3AF17326D165AADB6F07589C3C351AD682084EFCB7F2C260BFF3A38E27E8919A6CB0F7D3A3A3EA5ABEB01974F4BB50868BB331ED8EFB273FFF3BFEF648E5E1C7F6ED2DFADAF72C589CCD4007D4D818187631CC715AD5237106460745770C1DAAB4BB41202801413C2E0ABC135C530A5CC884ED14E08ECF545A723537A808D0322DBA1C88A33E7B9558A0184105DF6F49AACCEC58508349250472FB41392C47A317DFDAAAF5F72D1EE93C784DC5D67AB438CD010F891D3664BE6A8C5D0F7E97A301015717315BA2E314043009B0683A1DCF54D2D4E4F5B64B9F01F160B69172308819660FBBE834FC732470D306ED53A6353699B4106C4100D01291605614827474D99933F3052E07207D5E578D38DB8511820C61002381C7A9E344F652A6FC474D66E27F31EDC324D11A30801B06BA81A24839CF2D418318C90588C25A902FC16EE99512FDAC4380DF13C7584DC249F23CE7B92E2B1F9A3AEDDC443D7706E1421887AB09FAE2A140A4571CF9B957213772B2CC543F9C08F7E67D435C0380D29790579963F4AD8D384231BECC29315F1A43BF43C367FD4B5347FD4359C1BA721C56251A6F247A10093C53E24CB98B3203FEBDA43F9A3AEA5F9A3AEE1DC3042888A254FA6F247B1C8DA98DA8AD46E6816630811B63C8EA85C56B70F63A55C963E84FF71EB34418CD210D7F5C40CA22A20CA72D88FE0B1A1ACB9091D62948654E6D5EF525A2ECF887B9B02230881C988C298EAD5AACC51877ABD42561865CE4DE8100308E152700B755C8BE6E7D56F1B5BADCC938BD15EE14B4469B48A6642B812629BFCA14F3B3B5B324F3D76F7B6C5BEEFC2B9735AA7682304761BBB580C8703DAD9DD161BE2EBC2ECCC0CED6D6F50380CB8A3A8D77C292704FE1364E09D5218B7FAE3F73754ABFEDCAB8CC6815AAD426FDFBE21AFE0B2B6E0E9C2445BEE76E2F216B58F454B228A45BC536A8D239C3979C52CE081A2C3C3631A0C87E472189EAC485183DC098146F04F0AC2803CD7A1CDCD0DB151F124A0D3E9D1E1E713A13120064D386F6E722144908082F309DEB2E63211EBEB6B4698A6E7A07DD1A5A3A313A1DDC9907D7EC48C9D9054234004B6127FB5B6428DBAFAFE451E386F770431D8562A59943D7E56C64648DADB45613135BAFE6A79ECAFBB330578B6E5F8F8443C09964E728D8B9CB1109284B01CC3B266ACAF2DD3C2E24272E185A37576CEC4248B32B0D86F1CA4FC14212911711CD2DADA2A2D2FFD3B88B80BACBA3CFD72C6B58957BBA62FAA7C1E394F2624354D3886ECE4969617D83CAD88BC7F3B8E4F9AD46472B09C094FF13E47639E44484A46100454ADCED3F6D60AB70875134A93008C891D1C7CA676BB2BDE5EFD54521E4D88D00876D805EEC9EEFCB2255E973DC5C3C003401F3F1C92FFED7DBB8F23E68784882104F6D7789D1C22A7A525735E73370968B6FEA6E3A326938257BB7285FF80989184C04261E7508F7BA9AFDFEC880EDE144F07D62CBF7BF7814D3DBA04A3DF4EFDE0E022C8805654CAB3B4FFF6D729193F013C4CFA76FFB5989D449D4A579C894C42127F11D042A3AA759EE2A56197EB72913BCB0929D9ACDC23045F44DF02D3A91B1BAF64EE14E3C2FAC62A356A65D1CB9703FCB7904948D1F5686B7B4A465ED8DCDAA442D14BB611042737E416216968BBF77A5BE64C91177EDDF94538FB907BF799CB80A03E50A385859A5CA63F459E703D9B16176BA2CE13F548F05D43380FBE637D6D3A0CA20A989AB098106CCB746F4E1DE60ACB386DEE554EA10618F32ACFCDDDDA1FD86626C08670308D464D7E750A55A8D593F5C5290F76C8DD460847C6549D9FCC29D64946AD56154B8FD07DB72C8BFE0165B28D68282EE8CD0000000049454E44AE426082, N'15MMT1A', N'Thanh Hóa', 1)
INSERT [dbo].[SinhVien_Deleted] ([Masv], [Tensv], [Ngaysinh], [Gioitinh], [Malop], [Diachi], [Chinhsachuutien], [Tgianxoa]) VALUES (N'TestTrigge', N'TestTrigger', CAST(N'2019-12-10' AS Date), 1, N'15HTTT1A', N'TestTrigger', 1, CAST(N'2019-12-10T03:43:02.833' AS DateTime))
INSERT [dbo].[ThongTinDanhNhap] ([TaiKhoan], [MatKhau], [Quyen], [TrangThai]) VALUES (N'bichngoc', N'991525', N'Quản Lý', 0)
INSERT [dbo].[ThongTinDanhNhap] ([TaiKhoan], [MatKhau], [Quyen], [TrangThai]) VALUES (N'hoangphan', N'991403', N'Admin', 1)
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocKy] FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKy] ([MaHocKy])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocKy]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_HeDaoTao] FOREIGN KEY([MaHeDaoTao])
REFERENCES [dbo].[HeDaoTao] ([MaHe])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_HeDaoTao]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoaHoc] FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoaHoc]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_NganhDaoTao] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NganhDaoTao] ([MaNganh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_NganhDaoTao]
GO
ALTER TABLE [dbo].[NganhDaoTao]  WITH CHECK ADD  CONSTRAINT [FK_NganhDaoTao_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[NganhDaoTao] CHECK CONSTRAINT [FK_NganhDaoTao_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([Lop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
/****** Object:  StoredProcedure [dbo].[ChinhSuaKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CHỈNH SỬA KHÓA HỌC
CREATE PROC [dbo].[ChinhSuaKhoaHoc]
@MaKhoaHoc varchar(10),
@NgayBatDau datetime,
@NgayKetThuc datetime
AS
	UPDATE KhoaHoc SET NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc WHERE MaKhoaHoc = @MaKhoaHoc; 
GO
/****** Object:  StoredProcedure [dbo].[ChinhSuaQuyen]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CHỈNH SỬA QUYỀN
CREATE PROC [dbo].[ChinhSuaQuyen]
@TaiKhoan varchar(30),
@Quyen nvarchar(30)
AS
	UPDATE ThongTinDanhNhap SET Quyen = @Quyen
	WHERE TaiKhoan = @TaiKhoan; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSach_ThongTin_KhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--LẤY RA DANH SÁCH CÁC KHÓA HỌC TRONG TRƯỜNG
CREATE PROC [dbo].[DanhSach_ThongTin_KhoaHoc]
AS
	SELECT MaKhoaHoc, NgayBatDau,NgayKetThuc 
	FROM KhoaHoc ORDER BY MaKhoaHoc DESC;
--THÊM KHÓA HỌC MỚI
GO
/****** Object:  StoredProcedure [dbo].[DanhSach_ThongTin_Lop]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSach_ThongTin_Lop]
AS
SELECT A.MaLop, A.TenLop, A.MaKhoaHoc, C.TenHe, B.TenNganh, D.Tenkhoa 
FROM Lop A, NganhDaoTao B, HeDaoTao C, Khoa D
WHERE A.MaNganh = B.MaNganh AND A.MaHeDaoTao = C.MaHe AND B.MaKhoa = D.MaKhoa 
ORDER BY Tenkhoa ASC, MaKhoaHoc DESC, MaLop ASC;
--LẤY RA DANH SÁCH 14 HỌC KỲ GẦN NHẤT
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachHeDaoTao]
AS
	SELECT * FROM HeDaoTao;
--LẤY BẢNG NGÀNH ĐÀO TẠO
GO
/****** Object:  StoredProcedure [dbo].[DanhSachHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachHocKy]
AS
	SELECT TOP 14 * FROM HocKy ORDER BY MaHocKy DESC;
--DANH SÁCH MÔN HỌC
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--/*###=========================GIAO DIỆN XÉT HỌC BỔNG======================###*/
--LẤY DANH SÁCH KHOA

CREATE PROC [dbo].[DanhSachKhoa]
AS
	SELECT MaKhoa, Tenkhoa FROM Khoa ORDER BY Tenkhoa ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachKhoaHoc]
AS
	SELECT MaKhoaHoc FROM KhoaHoc ORDER BY MaKhoaHoc DESC;
--THÊM LỚP HỌC MỚI.
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachMonHoc]
AS
	SELECT * FROM MonHoc ORDER BY TenMonHoc ASC;
--TÌM KIẾM MÔN HỌC
GO
/****** Object:  StoredProcedure [dbo].[DanhSachMonHocToanTruong]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachMonHocToanTruong]
AS
	SELECT MaMonHoc, TenMonHoc, SoTinChi FROM MonHoc ORDER BY MaMonHoc ASC;
--XÓA MÔN HỌC THEO MÃ MÔN
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachNganhDaoTao]
AS
	SELECT MaNganh, TenNganh FROM NganhDaoTao;
--LẤY DANH SÁCH KHÓA HỌC
GO
/****** Object:  StoredProcedure [dbo].[DanhSachQuyen]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH QUYỀN
CREATE PROC [dbo].[DanhSachQuyen]
AS
	SELECT DISTINCT Quyen FROM ThongTinDanhNhap ORDER BY Quyen ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachSinhVien]
AS
	SELECT MaSinhVien, TenSinhVien, NgaySinh, GioiTinh, Lop, DiaChi, ChinhSachUuTien FROM SinhVien ORDER BY TenSinhVien ASC;
--TÌM KIẾM SINH VIÊN.
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienCuaLop]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH SINH VIÊN CỦA LỚP HOC.

CREATE PROC [dbo].[DanhSachSinhVienCuaLop]
@MaLop varchar(10)
AS
	SELECT MaSinhVien, TenSinhVien FROM SinhVien WHERE Lop = @MaLop ORDER BY TenSinhVien ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruong]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--/*###=========================GIAO DIỆN XÉT RA TRƯỜNG======================###*/
--DANH SÁCH SINH VIÊN HẾT THỜI GIAN HỌC TẬP - HOẶC ĐỦ ĐIỀU KIÊN RA TRƯỜNG.
CREATE PROC [dbo].[DanhSachSinhVienRaTruong]
AS
	SELECT A.MaSinhVien, A.TenSinhVien, A.GioiTinh, B.TenLop, C.MaKhoaHoc, D.TenHe, E.TenNganh, F.Tenkhoa
	FROM SinhVien A, Lop B, KhoaHoc C, HeDaoTao D, NganhDaoTao E, Khoa F
	WHERE A.Lop = B.MaLop AND B.MaKhoaHoc = C.MaKhoaHoc AND B.MaHeDaoTao = D.MaHe
	AND B.MaNganh = E.MaNganh AND E.MaKhoa = F.MaKhoa
	AND ((DATEDIFF(DD, GETDATE(), C.NgayKetThuc) <=0 AND DATEDIFF(DD, GETDATE(), C.NgayKetThuc) > -365)
	OR A.MaSinhVien IN
	(SELECT A.MaSinhVien
	FROM (BangDiem A RIGHT JOIN 
		(SELECT B.MaMonHoc AS MA, MAX (B.DiemQuaTrinh*0.5 + B.DiemThi*0.5) AS DIEM , B.MaSinhVien FROM BangDiem B 
			WHERE MaSinhVien IN (SELECT MaSinhVien FROM SinhVien)
			GROUP BY B.MaMonHoc, B.MaSinhVien) 
			AS BANGTAM
			ON A.MaMonHoc = MA AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) = DIEM), MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi)
	AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) > 4.95 
	GROUP BY A.MaSinhVien
	HAVING SUM(B.SoTinChi) >= 125))
	ORDER BY A.TenSinhVien ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruongDuocNhanBang]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH SINH VIÊN RA TRƯỜNG ĐƯỢC NHẬN BẰNG.
CREATE PROC [dbo].[DanhSachSinhVienRaTruongDuocNhanBang]
AS
	SELECT A.MaSinhVien, A.TenSinhVien, A.GioiTinh, B.TenLop, C.MaKhoaHoc, D.TenHe, E.TenNganh, F.Tenkhoa
	FROM SinhVien A, Lop B, KhoaHoc C, HeDaoTao D, NganhDaoTao E, Khoa F
	WHERE A.Lop = B.MaLop AND B.MaKhoaHoc = C.MaKhoaHoc AND B.MaHeDaoTao = D.MaHe
	AND B.MaNganh = E.MaNganh AND E.MaKhoa = F.MaKhoa
	AND (DATEDIFF(DD, GETDATE(), C.NgayKetThuc) > -365)
	AND A.MaSinhVien IN
	(SELECT A.MaSinhVien
	FROM (BangDiem A RIGHT JOIN 
		(SELECT B.MaMonHoc AS MA, MAX (B.DiemQuaTrinh*0.5 + B.DiemThi*0.5) AS DIEM , B.MaSinhVien FROM BangDiem B 
			WHERE MaSinhVien IN (SELECT MaSinhVien FROM SinhVien)
			GROUP BY B.MaMonHoc, B.MaSinhVien) 
			AS BANGTAM
			ON A.MaMonHoc = MA AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) = DIEM), MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi)
	AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) > 4.95 
	GROUP BY A.MaSinhVien
	HAVING SUM(B.SoTinChi) >= 125)
	ORDER BY A.TenSinhVien ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienRaTruongKhongDuocNhanBang]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH SINH VIÊN RA TRƯỜNG KHÔNG ĐƯỢC NHẬN BẰNG.
CREATE PROC [dbo].[DanhSachSinhVienRaTruongKhongDuocNhanBang]
AS
	SELECT A.MaSinhVien, A.TenSinhVien, A.GioiTinh, B.TenLop, C.MaKhoaHoc, D.TenHe, E.TenNganh, F.Tenkhoa
	FROM SinhVien A, Lop B, KhoaHoc C, HeDaoTao D, NganhDaoTao E, Khoa F
	WHERE A.Lop = B.MaLop AND B.MaKhoaHoc = C.MaKhoaHoc AND B.MaHeDaoTao = D.MaHe
	AND B.MaNganh = E.MaNganh AND E.MaKhoa = F.MaKhoa
	AND DATEDIFF(DD, GETDATE(), C.NgayKetThuc) <=0 AND DATEDIFF(DD, GETDATE(), C.NgayKetThuc) > -365
	AND A.MaSinhVien NOT IN
	(SELECT A.MaSinhVien
	FROM (BangDiem A RIGHT JOIN 
		(SELECT B.MaMonHoc AS MA, MAX (B.DiemQuaTrinh*0.5 + B.DiemThi*0.5) AS DIEM , B.MaSinhVien FROM BangDiem B 
			WHERE MaSinhVien IN (SELECT MaSinhVien FROM SinhVien)
			GROUP BY B.MaMonHoc, B.MaSinhVien) 
			AS BANGTAM
			ON A.MaMonHoc = MA AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) = DIEM), MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi)
	AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) > 4.95 
	GROUP BY A.MaSinhVien
	HAVING SUM(B.SoTinChi) >= 125)
	ORDER BY A.TenSinhVien ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH SINH VIÊN TOÀN TRƯỜNG ĐẠT HỌC BỔNG TRONG HỌC KỲ GẦN NHẤT. 
CREATE PROC [dbo].[DanhSachSinhVienXetHocBong]
@MaHocKy varchar(10)
AS
	SELECT
	A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa,
	ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2)[DiemTrungBinhHocKyHe10]
	FROM BangDiem A , MonHoc B, DoiDiem C, SinhVien D, Lop E, KhoaHoc F, NganhDaoTao G, Khoa H
	WHERE A.MaMonHoc = B.MaMonHoc AND A.MaSinhVien = D.MaSinhVien AND D.Lop = E.MaLop
	AND E.MaKhoaHoc = F.MaKhoaHoc AND E.MaNganh = G.MaNganh AND G.MaKhoa = H.MaKhoa AND C.DiemChu = dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi)
	AND A.MaHocKy = @MaHocKy AND
	A.MaSinhVien
	NOT IN
	(SELECT
		M.MaSinhVien
	FROM BangDiem M, MonHoc B, DoiDiem C 
	WHERE M.MaMonHoc = B.MaMonHoc and C.DiemChu = 
	(CASE
		WHEN (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) < 4.95 THEN 'F'
	END) AND (M.DiemQuaTrinh*0.5 + M.DiemThi*0.5) < 5.45 AND M.MaHocKy = @MaHocKy)
	GROUP BY A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa
	HAVING ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2) >= 7
	ORDER BY [DiemTrungBinhHocKyHe10] DESC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong_Khoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DANH SÁCH SINH VIÊN ĐẠT HỌC BỔNG CỦA KHOA.
CREATE PROC [dbo].[DanhSachSinhVienXetHocBong_Khoa]
@MaHocKy varchar(10),
@TimKiem varchar(10)
AS
	SELECT
	A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa,
	ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2)[DiemTrungBinhHocKyHe10]
	FROM BangDiem A , MonHoc B, DoiDiem C, SinhVien D, Lop E, KhoaHoc F, NganhDaoTao G, Khoa H
	WHERE A.MaMonHoc = B.MaMonHoc AND A.MaSinhVien = D.MaSinhVien AND D.Lop = E.MaLop
	AND E.MaKhoaHoc = F.MaKhoaHoc AND E.MaNganh = G.MaNganh AND G.MaKhoa = H.MaKhoa AND C.DiemChu = dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi)
	AND A.MaHocKy = @MaHocKy AND H.MaKhoa = @TimKiem AND
	A.MaSinhVien
	NOT IN
	(SELECT
		M.MaSinhVien
	FROM BangDiem M, MonHoc B, DoiDiem C 
	WHERE M.MaMonHoc = B.MaMonHoc and C.DiemChu = 
	(CASE
		WHEN (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) < 4.95 THEN 'F'
	END) AND (M.DiemQuaTrinh*0.5 + M.DiemThi*0.5) < 5.45 AND M.MaHocKy = @MaHocKy)
	GROUP BY A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa
	HAVING ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2) >= 7
	ORDER BY [DiemTrungBinhHocKyHe10] DESC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachSinhVienXetHocBong_Khoa_Top]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DANH SÁCH SINH VIÊN ĐẠT HỌC BỔNG CỦA KHOA - TOP.
CREATE PROC [dbo].[DanhSachSinhVienXetHocBong_Khoa_Top]
@MaHocKy varchar(10),
@TimKiem varchar(10),
@Top int
AS
	SELECT TOP (@Top) WITH TIES
	A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa,
	ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2)[DiemTrungBinhHocKyHe10]
	FROM BangDiem A , MonHoc B, DoiDiem C, SinhVien D, Lop E, KhoaHoc F, NganhDaoTao G, Khoa H
	WHERE A.MaMonHoc = B.MaMonHoc AND A.MaSinhVien = D.MaSinhVien AND D.Lop = E.MaLop
	AND E.MaKhoaHoc = F.MaKhoaHoc AND E.MaNganh = G.MaNganh AND G.MaKhoa = H.MaKhoa AND C.DiemChu = dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi)
	AND A.MaHocKy = @MaHocKy AND H.MaKhoa = @TimKiem AND
	A.MaSinhVien
	NOT IN
	(SELECT
		M.MaSinhVien
	FROM BangDiem M, MonHoc B, DoiDiem C 
	WHERE M.MaMonHoc = B.MaMonHoc and C.DiemChu = 
	(CASE
		WHEN (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) < 4.95 THEN 'F'
	END) AND (M.DiemQuaTrinh*0.5 + M.DiemThi*0.5) < 5.45 AND M.MaHocKy = @MaHocKy)
	GROUP BY A.MaSinhVien, D.TenSinhVien, E.TenLop, F.MaKhoaHoc, G.TenNganh, H.Tenkhoa
	HAVING ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2) >= 7
	ORDER BY [DiemTrungBinhHocKyHe10] DESC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DANH SÁCH TÀI KHOẢN
CREATE PROC [dbo].[DanhSachTaiKhoan]
AS
	SELECT TaiKhoan, Quyen, TrangThai FROM ThongTinDanhNhap ORDER BY TaiKhoan ASC; 
GO
/****** Object:  StoredProcedure [dbo].[DanhSachThongTinHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachThongTinHocKy]
AS
	SELECT MaHocKy, TenHocKy FROM HocKy ORDER BY MaHocKy DESC;
--XÓA HỌC KỲ
GO
/****** Object:  StoredProcedure [dbo].[DanhSachThongTinNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--/*###=========================GIAO DIỆN NGÀNH ĐÀO TẠO======================###*/
--DANH SÁCH NGÀNH ĐÀO TẠO
CREATE PROC [dbo].[DanhSachThongTinNganhDaoTao]
AS
	SELECT A.MaNganh, A.TenNganh, B.Tenkhoa FROM NganhDaoTao A, Khoa B
	WHERE A.MaKhoa = B.MaKhoa
	ORDER BY TenNganh ASC; 
GO
/****** Object:  StoredProcedure [dbo].[KetQuaTongKetDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TOÀN BỘ KẾT QUẢ HỌC TẬP - KHÔNG TÍNH MÔN TRƯỢT VÀ TRÙNG
CREATE PROC [dbo].[KetQuaTongKetDaoTao]
@MaSinhVien varchar(10)
AS
	SELECT SUM(B.SoTinChi)[SO TIN CHI TICH LUY],
	   ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2)[DIEM TICH LUY HE 10],
	   ROUND((SUM(B.SoTinChi*C.DiemSo)/SUM(B.SoTinChi)),2)[DIEM TICH LUY HE 4]
	FROM (BangDiem A RIGHT JOIN 
		(SELECT B.MaMonHoc AS MA, MAX (B.DiemQuaTrinh*0.5 + B.DiemThi*0.5) AS DIEM FROM BangDiem B 
			WHERE MaSinhVien = @MaSinhVien 
			GROUP BY B.MaMonHoc) 
			AS BANGTAM
			ON A.MaMonHoc = MA AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) = DIEM), MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi) 
	AND (A.DiemQuaTrinh*0.5 + A.DiemThi*0.5) > 4.95 ; 
GO
/****** Object:  StoredProcedure [dbo].[KetQuaTongKetHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----KẾT QUẢ HỌC TẬP - TÍNH MÔN TRƯỢT.
CREATE PROC [dbo].[KetQuaTongKetHocKy]
@MaSinhVien varchar(10),
@MaHocKy varchar(10)
AS
	SELECT
	   ROUND((SUM(B.SoTinChi*(A.DiemQuaTrinh*0.5 + A.DiemThi*0.5))/SUM(B.SoTinChi)),2)[DIEM TRUNG BINH HE 10],
	   ROUND((SUM(B.SoTinChi*C.DiemSo)/SUM(B.SoTinChi)),2)[DIEM TRUNG BINH HE 4]
	FROM BangDiem A , MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi)
	AND MaSinhVien = @MaSinhVien AND MaHocKy = @MaHocKy; 
GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--/*###=========================GIAO DIỆN ĐĂNG NHẬP======================###*/
--KIỂM TRA ĐĂNG NHẬP.
CREATE PROC [dbo].[KiemTraDangNhap]
@TaiKhoan varchar(30),
@MatKhau varchar(30)
AS
	SELECT Quyen FROM ThongTinDanhNhap WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau; 
GO
/****** Object:  StoredProcedure [dbo].[LayAnhSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--LẤY RA ẢNH CỦA MỘT SINH VIÊN.
CREATE PROC [dbo].[LayAnhSinhVien]
@TimKiem nvarchar(50)
AS
	SELECT Anh FROM SinhVien WHERE MaSinhVien = @TimKiem; 
GO
/****** Object:  StoredProcedure [dbo].[LayDiemTheoKySinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--LẤY RA ĐIỂM TRONG 1 HỌC KỲ CỦA SINH VIÊN.
CREATE PROC [dbo].[LayDiemTheoKySinhVien]
@MaSinhVien varchar(10),
@MaHocKy varchar(10) 
AS
	SELECT A.STT, A.MaHocKy, A.MaMonHoc, B.TenMonHoc, B.SoTinChi, A.DiemQuaTrinh, A.DiemThi, ROUND((A.DiemQuaTrinh*0.5 + A.DiemThi*0.5),1)[Diem Tong Ket],
	dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi) [Diem Chu], c.KetLuan
	FROM BangDiem A, MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc AND C.DiemChu = dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi) 
	AND A.MaSinhVien = @MaSinhVien AND A.MaHocKy = @MaHocKy 
	ORDER BY MaMonHoc ASC, MaHocKy ASC; 
GO
/****** Object:  StoredProcedure [dbo].[LayKetQuaHocTap]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*###=========================GIAO DIÊN XEM KẾT QUẢ HỌC TẬP CỦA SINH VIÊN======================###*/
--LẤY RA TOÀN BỘ KẾT QUẢ HỌC TẬP CỦA SINH VIÊN.
CREATE PROC [dbo].[LayKetQuaHocTap]
@MaSinhVien varchar(10)
AS
	SELECT A.STT, A.MaHocKy, A.MaMonHoc, B.TenMonHoc, B.SoTinChi, A.DiemQuaTrinh, A.DiemThi, ROUND((A.DiemQuaTrinh*0.5 + A.DiemThi*0.5),1)[Diem Tong Ket],
	dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi) [Diem Chu], c.KetLuan
	FROM BangDiem A, MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc AND C.DiemChu = dbo.fnTinhDiemChu(A.DiemQuaTrinh,A.DiemThi)
	AND A.MaSinhVien = @MaSinhVien ORDER BY MaHocKy ASC, MaMonHoc ASC; 
GO
/****** Object:  StoredProcedure [dbo].[SoTinChiDat]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--KẾT QUẢ TỔNG KẾT THEO KỲ - TÍNH MÔN TRƯỢT.
----SỐ TÍN CHỈ ĐẠT - KHÔNG TÍNH MÔN TRƯỢT.
CREATE PROC [dbo].[SoTinChiDat]
@MaSinhVien varchar(10),
@MaHocKy varchar(10)
AS
	SELECT SUM(B.SoTinChi)[SO TIN CHI DAT]
	FROM BangDiem A , MonHoc B, DoiDiem C 
	WHERE A.MaMonHoc = B.MaMonHoc and C.DiemChu = dbo.fnTinhDiemChuHonF(A.DiemQuaTrinh,A.DiemThi)
	AND MaSinhVien = @MaSinhVien AND MaHocKy = @MaHocKy; 
GO
/****** Object:  StoredProcedure [dbo].[SuaHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SỬA HỆ ĐÀO TẠO
CREATE PROC [dbo].[SuaHeDaoTao]
@MaHe varchar(10),
@TenHe nvarchar(50)
AS
	UPDATE HeDaoTao SET TenHe = @TenHe WHERE MaHe = @MaHe; 
GO
/****** Object:  StoredProcedure [dbo].[SuaHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SỬA HỌC KỲ
CREATE PROC [dbo].[SuaHocKy]
@MaHocKy varchar(10),
@TenHocKy nvarchar(50)
AS
	UPDATE HocKy SET TenHocKy = @TenHocKy WHERE MaHocKy = @MaHocKy; 
GO
/****** Object:  StoredProcedure [dbo].[SuaKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SỬA KHOA
CREATE PROC [dbo].[SuaKhoa]
@MaKhoa varchar(10),
@TenKhoa nvarchar(50)
AS
	UPDATE Khoa SET Tenkhoa = @TenKhoa WHERE MaKhoa = @MaKhoa; 
GO
/****** Object:  StoredProcedure [dbo].[SuaMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--UPDATE MÔN HOC
CREATE PROC [dbo].[SuaMonHoc]
@MaMonHoc varchar(10),
@TenMonHoc nvarchar(50),
@SoTinChi int
AS
	UPDATE MonHoc SET TenMonHoc = @TenMonHoc, SoTinChi = @SoTinChi WHERE MaMonHoc = @MaMonHoc;
GO
/****** Object:  StoredProcedure [dbo].[SuaNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SỬA NGÀNH ĐÀO TẠO.
CREATE PROC [dbo].[SuaNganhDaoTao]
@MaNganh varchar(10),
@TenNganh nvarchar(50),
@MaKhoa varchar(10)
AS
	UPDATE NganhDaoTao SET TenNganh = @TenNganh, MaKhoa = @MaKhoa
	WHERE MaNganh = @MaNganh; 
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SỬA THÔNG TIN LỚP HỌC
CREATE PROC [dbo].[SuaThongTinLopHoc]
@MaLop varchar(10),
@TenLop nvarchar(50),
@MaKhoaHoc varchar(10),
@MaHeDaoTao varchar(10),
@MaNganh varchar(10)
AS
	UPDATE Lop SET TenLop = @TenLop, MaKhoaHoc = @MaKhoaHoc, MaHeDaoTao = @MaHeDaoTao, MaNganh = @MaNganh
	WHERE MaLop = @MaLop; 
GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaThongTinSinhVien]
@MaSinhVien varchar(10),
@TenSinhVien nvarchar(50),
@NgaySinh datetime,
@GioiTinh bit,
@Lop varchar(10),
@DiaChi nvarchar(50),
@ChinhSachUuTien bit
AS
begin
	begin try
		begin tran
			UPDATE SinhVien SET TenSinhVien = @TenSinhVien, NgaySinh = @NgaySinh, 
			GioiTinh = @GioiTinh, Lop = @Lop, DiaChi = @DiaChi, ChinhSachUuTien = @ChinhSachUuTien 
			WHERE MaSinhVien = @MaSinhVien;  
		commit tran
	end try
	begin catch
		rollback tran;
		throw 5000,'Khong The Sua Thông Tin Sinh Vien',1;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[ThemHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM HỆ ĐÀO TẠO
CREATE PROC [dbo].[ThemHeDaoTao]
@MaHe varchar(10),
@TenHe nvarchar(50)
AS
	INSERT INTO HeDaoTao(MaHe, TenHe) VALUES (@MaHe, @TenHe); 
GO
/****** Object:  StoredProcedure [dbo].[ThemHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM HỌC KỲ
CREATE PROC [dbo].[ThemHocKy]
@MaHocKy varchar(10),
@TenHocKy nvarchar(50)
AS
	INSERT INTO HocKy(MaHocKy, TenHocKy) VALUES (@MaHocKy, @TenHocKy); 
GO
/****** Object:  StoredProcedure [dbo].[ThemKetQua]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--THÊM ĐIỂM QUÁ TRÌNH VÀ ĐIỂM THI VÀO BẢNG ĐIỂM
CREATE PROC [dbo].[ThemKetQua]
@MaSinhVien varchar(10),
@MaMonHoc varchar(10),
@MaHocKy varchar(10),
@DiemQuaTrinh float,
@DiemThi float
AS
	INSERT INTO BangDiem VALUES (@MaSinhVien, @MaMonHoc, @MaHocKy, @DiemQuaTrinh, @DiemThi); 
GO
/****** Object:  StoredProcedure [dbo].[ThemKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM KHOA
CREATE PROC [dbo].[ThemKhoa]
@MaKhoa varchar(10),
@TenKhoa nvarchar(50)
AS
	INSERT INTO Khoa(MaKhoa, Tenkhoa) VALUES (@MaKhoa, @TenKhoa); 
GO
/****** Object:  StoredProcedure [dbo].[ThemKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM KHÓA HỌC MỚI
CREATE PROC [dbo].[ThemKhoaHoc]
@MaKhoaHoc varchar(10),
@NgayBatDau datetime,
@NgayKetThuc datetime
AS
	INSERT INTO KhoaHoc VALUES (@MaKhoaHoc, @NgayBatDau, @NgayKetThuc); 
GO
/****** Object:  StoredProcedure [dbo].[ThemLopHocMoi]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM LỚP HỌC MỚI.
CREATE PROC [dbo].[ThemLopHocMoi]
@MaLop varchar(10),
@TenLop nvarchar(50),
@MaKhoaHoc varchar(10),
@MaHeDaoTao varchar(10),
@MaNganh varchar(10)
AS
	INSERT INTO Lop(MaLop, TenLop, MaKhoaHoc, MaHeDaoTao, MaNganh) 
	VALUES (@MaLop, @TenLop, @MaKhoaHoc, @MaHeDaoTao, @MaNganh); 
GO
/****** Object:  StoredProcedure [dbo].[ThemMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM MÔN HỌC MỚI
CREATE PROC [dbo].[ThemMonHoc]
@MaMonHoc varchar(10),
@TenMonHoc nvarchar(50),
@SoTinChi int
AS
	INSERT INTO MonHoc(MaMonHoc, TenMonHoc, SoTinChi) VALUES (@MaMonHoc, @TenMonHoc, @SoTinChi); 
GO
/****** Object:  StoredProcedure [dbo].[ThemNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM NGÀNH ĐÀO TẠO
CREATE PROC [dbo].[ThemNganhDaoTao]
@MaNganh varchar(10),
@TenNganh nvarchar(50),
@MaKhoa varchar(10)
AS
	INSERT INTO NganhDaoTao(MaNganh, TenNganh, MaKhoa) VALUES (@MaNganh, @TenNganh, @MaKhoa); 
GO
/****** Object:  StoredProcedure [dbo].[ThemSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM SINH VIÊN MỚI.
CREATE PROC [dbo].[ThemSinhVien]
@MaSinhVien varchar(10),
@TenSinhVien nvarchar(50),
@NgaySinh datetime,
@GioiTinh bit,
@Anh image,
@Lop varchar(10),
@DiaChi nvarchar(50),
@ChinhSachUuTien bit
AS
	INSERT INTO SinhVien VALUES (@MaSinhVien, @TenSinhVien, @NgaySinh, @GioiTinh, @Anh, @Lop, 
	@DiaChi, @ChinhSachUuTien); 
GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--THÊM TÀI KHOẢN

CREATE PROC [dbo].[ThemTaiKhoan]
@TaiKhoan varchar(30),
@Quyen nvarchar(30)
AS
	INSERT INTO ThongTinDanhNhap(TaiKhoan, MatKhau, Quyen, TrangThai) 
	VALUES (@TaiKhoan, 'DHXD', @Quyen, '0'); 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM HỆ ĐÀO TẠO
CREATE PROC [dbo].[TimKiemHeDaoTao]
@TimKiem nvarchar(50)
AS
	SELECT MaHe, TenHe FROM HeDaoTao WHERE MaHe LIKE '%'+@TimKiem+'%' OR TenHe LIKE '%'+@TimKiem+'%'; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM HỌC KỲ.
CREATE PROC [dbo].[TimKiemHocKy]
@TimKiem nvarchar(50)
AS
	SELECT MaHocKy, TenHocKy FROM HocKy
	WHERE MaHocKy LIKE '%'+@TimKiem+'%' OR TenHocKy LIKE '%'+@TimKiem+'%'
	ORDER BY MaHocKy DESC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM KHOA
CREATE PROC [dbo].[TimKiemKhoa]
@TimKiem nvarchar(50)
AS
	SELECT MaKhoa, Tenkhoa FROM Khoa WHERE MaKhoa LIKE '%'+@TimKiem+'%' OR Tenkhoa LIKE '%'+@TimKiem+'%'; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM KHÓA HỌC
CREATE PROC [dbo].[TimKiemKhoaHoc]
@MaKhoaHoc varchar(10)
AS
	SELECT * FROM KhoaHoc WHERE MaKhoaHoc LIKE '%'+@MaKhoaHoc+'%' ORDER BY MaKhoaHoc DESC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM LỚP HỌC
CREATE PROC [dbo].[TimKiemLopHoc]
@TimKiem varchar(10)
AS
SELECT A.MaLop, A.TenLop, A.MaKhoaHoc, C.TenHe, B.TenNganh, D.Tenkhoa 
FROM Lop A, NganhDaoTao B, HeDaoTao C, Khoa D
WHERE A.MaNganh = B.MaNganh AND A.MaHeDaoTao = C.MaHe AND B.MaKhoa = D.MaKhoa
AND (A.MaLop LIKE '%'+@TimKiem+'%' OR A.TenLop LIKE '%'+@TimKiem+'%' OR D.Tenkhoa LIKE '%'+@TimKiem+'%'
OR C.TenHe LIKE '%'+@TimKiem+'%' OR B.TenNganh LIKE '%'+@TimKiem+'%' OR A.MaKhoaHoc LIKE '%'+@TimKiem+'%')
ORDER BY Tenkhoa ASC, MaKhoaHoc DESC, MaLop ASC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--TÌM KIẾM MÔN HỌC
CREATE PROC [dbo].[TimKiemMonHoc]
@TenMonHoc nvarchar(50)
AS
	SELECT * FROM MonHoc WHERE TenMonHoc LIKE ''+@TenMonHoc+'%'  ORDER BY TenMonHoc ASC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM NGÀNH ĐÀO TẠO.
CREATE PROC [dbo].[TimKiemNganhDaoTao]
@TenNganh nvarchar(50)
AS
	SELECT * FROM NganhDaoTao WHERE TenNganh LIKE ''+@TenNganh+'%'  ORDER BY TenNganh ASC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM SINH VIÊN.
CREATE PROC [dbo].[TimKiemSinhVien]
@TimKiem nvarchar(50)
AS
	SELECT MaSinhVien, TenSinhVien, NgaySinh, GioiTinh, Lop, DiaChi, ChinhSachUuTien 
	FROM SinhVien WHERE MaSinhVien LIKE '%'+@TimKiem+'%' OR TenSinhVien LIKE '%'+@TimKiem+'%' 
	OR Lop LIKE '%'+@TimKiem+'%'; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM TÀI KHOẢN
CREATE PROC [dbo].[TimKiemTaiKhoan]
@TimKiem nvarchar(30)
AS
	SELECT TaiKhoan, Quyen, TrangThai FROM ThongTinDanhNhap
	WHERE TaiKhoan LIKE '%'+@TimKiem+'%' OR Quyen LIKE '%'+@TimKiem+'%' OR TrangThai LIKE '%'+@TimKiem+'%'
	ORDER BY TaiKhoan ASC; 
GO
/****** Object:  StoredProcedure [dbo].[TimKiemThongTinNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM NGÀNH ĐÀO TẠO.
CREATE PROC [dbo].[TimKiemThongTinNganhDaoTao]
@TimKiem nvarchar(50)
AS
	SELECT A.MaNganh, A.TenNganh, B.Tenkhoa FROM NganhDaoTao A, Khoa B
	WHERE A.MaKhoa = B.MaKhoa AND (A.TenNganh LIKE '%'+@TimKiem+'%' OR A.MaNganh LIKE '%'+@TimKiem+'%' 
	OR A.MaKhoa LIKE '%'+@TimKiem+'%')
	ORDER BY TenNganh ASC; 
GO
/****** Object:  StoredProcedure [dbo].[TimMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TÌM KIẾM MÔN HỌC
CREATE PROC [dbo].[TimMonHoc]
@TimKiem nvarchar(50)
AS
	SELECT MaMonHoc, TenMonHoc, SoTinChi 
	FROM MonHoc WHERE MaMonHoc LIKE '%'+@TimKiem+'%' OR TenMonHoc LIKE '%'+@TimKiem+'%'
	OR SoTinChi LIKE '%'+@TimKiem+'%' ORDER BY MaMonHoc ASC; 
GO
/****** Object:  StoredProcedure [dbo].[UpDateDiemQTVaDiemThi]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--UPFATE ĐIỂM QUÁ TRÌNH VÀ ĐIỂM THI
CREATE PROC [dbo].[UpDateDiemQTVaDiemThi]
@MaSinhVien varchar(10),
@MaMonHoc varchar(10),
@MaHocKy varchar(10),
@DiemQuaTrinh float,
@DiemThi float
AS
	UPDATE BangDiem SET DiemQuaTrinh = @DiemQuaTrinh, DiemThi = @DiemThi
	WHERE MaSinhVien = @MaSinhVien AND MaMonHoc = @MaMonHoc AND MaHocKy = @MaHocKy; 
GO
/****** Object:  StoredProcedure [dbo].[UpDateMatKhau]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--UPDATE MẬT KHẨU
CREATE PROC [dbo].[UpDateMatKhau]
@TaiKhoan varchar(30),
@MatKhau varchar(30)
AS
	UPDATE ThongTinDanhNhap SET MatKhau = @MatKhau
	WHERE TaiKhoan = @TaiKhoan; 
GO
/****** Object:  StoredProcedure [dbo].[UpDateTrangThai]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--UPDATE TRẠNG THÁI.
CREATE PROC [dbo].[UpDateTrangThai]
@TaiKhoan varchar(30),
@TrangThai bit
AS
	UPDATE ThongTinDanhNhap SET TrangThai = @TrangThai
	WHERE TaiKhoan = @TaiKhoan; 
GO
/****** Object:  StoredProcedure [dbo].[XoaDiemCuaSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDiemCuaSinhVien]
@STT int
AS
begin
	begin try
		begin tran
			DELETE FROM BangDiem WHERE Stt = @STT; 
		commit tran
	end try
	begin catch
		rollback tran;
		throw 5000,'Khong The Xoa Diem',1;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[XoaHeDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHeDaoTao]
@MaHe varchar(10)
--AS
--	DELETE FROM HeDaoTao WHERE MaHe = @MaHe; 
--Go

AS
begin
	begin try
		begin tran
			DELETE FROM HeDaoTao WHERE MaHe = @MaHe;
		commit tran
	end try
	begin catch
		rollback tran;
		throw 5000,'Khong The Xoa He Dao Tao',1;
	end catch
end
GO
/****** Object:  StoredProcedure [dbo].[XoaHocKy]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA HỌC KỲ
CREATE PROC [dbo].[XoaHocKy]
@MaHocKy varchar(10)
AS
	DELETE FROM HocKy WHERE MaHocKy = @MaHocKy; 
GO
/****** Object:  StoredProcedure [dbo].[XoaKhoa]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--/*###=========================GIAO DIỆN KHOA======================###*/
--XÓA KHOA
CREATE PROC [dbo].[XoaKhoa]
@MaKhoa varchar(10)
AS
	DELETE FROM Khoa WHERE MaKhoa = @MaKhoa;
GO
/****** Object:  StoredProcedure [dbo].[XoaKhoaHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA KHÓA HỌC
CREATE PROC [dbo].[XoaKhoaHoc]
@MaKhoaHoc varchar(10)
AS
	DELETE FROM KhoaHoc WHERE MaKhoaHoc = @MaKhoaHoc; 
GO
/****** Object:  StoredProcedure [dbo].[XoaLopHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA LỚP HỌC
CREATE PROC [dbo].[XoaLopHoc]
@MaLop varchar(10)
AS
	DELETE FROM Lop WHERE MaLop = @MaLop; 
GO
/****** Object:  StoredProcedure [dbo].[XoaMonHoc]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA MÔN HỌC THEO MÃ MÔN
CREATE PROC [dbo].[XoaMonHoc]
@MaMonHoc varchar(10)
AS
	DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc; 
GO
/****** Object:  StoredProcedure [dbo].[XoaNganhDaoTao]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA NGÀNH ĐÀO TẠO
CREATE PROC [dbo].[XoaNganhDaoTao]
@MaNganh varchar(10)
AS
	DELETE FROM NganhDaoTao WHERE MaNganh = @MaNganh; 
GO
/****** Object:  StoredProcedure [dbo].[XoaSinhVien]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--XÓA SINH VIÊN.
CREATE PROC [dbo].[XoaSinhVien]
@Xoa varchar(10)
AS
	DELETE FROM SinhVien WHERE MaSinhVien = @Xoa; 
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoan]    Script Date: 2019-12-10 7:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--XÓA TÀI KHOẢN
CREATE PROC [dbo].[XoaTaiKhoan]
@TaiKhoan varchar(30)
AS
	DELETE FROM ThongTinDanhNhap WHERE TaiKhoan = @TaiKhoan; 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Lop"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 165
               Right = 234
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewDanhSachTenLop'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viewDanhSachTenLop'
GO
