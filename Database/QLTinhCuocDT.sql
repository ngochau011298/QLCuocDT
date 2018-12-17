
/* drop database QLTinhCuocDT */

create database QLTinhCuocDT

go
use QLTinhCuocDT

create table KhachHang
(
	MaKH varchar(20) primary key,
	TenKH nvarchar(50) not null,
	CMND varchar(10),
	Email varchar(50),
	NgheNghiep nvarchar(50),
	ChucVu nvarchar(50),
	DiaChi nvarchar(100),
	Flag bit
)

create table ThongTinSIM
(
	IDSIM varchar(10) primary key,
	MaKH varchar(20),
	NgayDangKy date,
	NgayHetHan date,
	Flag bit,
	
	foreign key (MaKH) references KhachHang(MaKH)
)

create table HoaDonDangKy
(
	MaHDDK varchar(20) primary key,
	IDSIM varchar(10),
	ChiPhiDangKy decimal(19,3),
	Flag bit,

	foreign key (IDSIM) references ThongTinSIM(IDSIM)
)

create table HoaDonTinhCuoc
(
	MaHDTC varchar(20) primary key,
	IDSIM varchar(10),
	PhiThueBao decimal(19,3),
	TongTien decimal(19,3),
	NgayLapHD date,
	ThanhToan bit,
	Flag bit,
	
	foreign key (IDSIM) references ThongTinSIM(IDSIM)
)

create table ChiTietSuDung
(
	MaChiTiet varchar(10) primary key,
	IDSIM varchar(10),
	
	TGBD datetime,
	TGKT datetime,
	SoPhutSD int,
	PhiCuocGoi decimal(19,3),
	Flag bit,

	foreign key (IDSIM) references ThongTinSIM(IDSIM)

)

create table GiaCuoc
(
	MaGiaCuoc varchar(20) primary key,
	
	TGBD time(0),
	TGKT time(0),
	Gia decimal(19, 3),
	Flag bit
)


/*Insert*/

insert into KhachHang values ('KH001', N'Trần Văn Bé', '754846193', 'nguyennhus293@gmail.com', N'Nhân viên văn phòng', N'Trưởng phòng', N'237 Bế Văn Đán, P11, Q5, TP.HCM', 1)
insert into KhachHang values ('KH002', N'Nguyền Thị Thơm', '156494247', 'thomthi19443@gmail.com', N'Đầu bếp', N'Bếp phó', N'137 Trần Văn Linh, P3, Q.Gò Vấp, TP.HCM', 1)
insert into KhachHang values ('KH003', N'Trần Cao Anh', '125792434', '', N'Tài xế', N'Nhân viên', N'29 Cao Bá Quát, P7, Q8, TP.HCM', 1)
insert into KhachHang values ('KH004', N'Lê Thị Oanh', '297345661', 'thioanh72364@gmail.com', N'Nhân viên công ty', N'Thư ký', N'154 Dương Bá Trạc, P9, Q10, TP.HCM', 1)
insert into KhachHang values ('KH005', N'Trần Công Duy', '538678684', '', N'Công nhân xây dựng', N'Phụ hồ', N'10 Hồng Bàng, P4, Q3, TP.HCM', 1)
insert into KhachHang values ('KH006', N'Dương Hoàng Lấn', '449231548', 'hoanglanduong146@gmail.com', N'Công nhân nhà máy', N'Quản lý', N'220 Trần Hưng Đạo, P11, Q1, TP.HCM', 1)
insert into KhachHang values ('KH007', N'Phan Thị Quỳnh', '759561921', 'quynhphan71661@gmail.com',N'Giáo viên', N'Trợ lý đào tạo', N'147 Trần Phú, P2, Q9, TP.HCM', 1)



insert into ThongTinSIM values ('0914563575', 'KH001', '2017/12/22', '2020/12/31', 1)
insert into ThongTinSIM values ('0973456446', 'KH001', '2017/10/05', '2020/12/31', 1)
insert into ThongTinSIM values ('0124846483', 'KH002', '2018/01/22', '2020/12/31', 1)
insert into ThongTinSIM values ('0128469464', 'KH003', '2017/12/04', '2020/12/31', 1)
insert into ThongTinSIM values ('0975116468', 'KH004', '2017/12/14', '2020/12/31', 1)
insert into ThongTinSIM values ('0952515484', 'KH004', '2018/01/12', '2020/12/31', 1)
insert into ThongTinSIM values ('0971613756', 'KH005', '2018/01/08', '2020/12/31', 1)
insert into ThongTinSIM values ('0124979531', 'KH006', '2018/02/01', '2020/12/31', 1)
insert into ThongTinSIM values ('0126486775', 'KH007', '2017/12/28', '2020/12/31', 1)


insert into HoaDonDangKy values ('DK001', '0914563575', 50000, 1)
insert into HoaDonDangKy values ('DK002', '0973456446', 50000, 1)
insert into HoaDonDangKy values ('DK003', '0124846483', 50000, 1)
insert into HoaDonDangKy values ('DK004', '0128469464', 50000, 1)
insert into HoaDonDangKy values ('DK005', '0975116468', 50000, 1)
insert into HoaDonDangKy values ('DK006', '0952515484', 50000, 1)
insert into HoaDonDangKy values ('DK007', '0971613756', 50000, 1)
insert into HoaDonDangKy values ('DK008', '0124979531', 50000, 1)
insert into HoaDonDangKy values ('DK009', '0126486775', 50000, 1)


insert into HoaDonTinhCuoc values ('HD001', '0914563575', 50000, 70200, '2018/02/01', 1, 1)
insert into HoaDonTinhCuoc values ('HD002', '0973456446', 50000, 65000, '2018/05/01', 1, 1)
insert into HoaDonTinhCuoc values ('HD003', '0124846483', 50000, 59000, '2018/09/01', 1, 1)
insert into HoaDonTinhCuoc values ('HD004', '0128469464', 50000, 80000, '2018/10/01', 1, 1)
insert into HoaDonTinhCuoc values ('HD005', '0971613756', 50000, 62000, '2018/11/01', 0, 1)



insert into GiaCuoc values ('GC01', '07:00:00', '23:00:00', 200, 1)
insert into GiaCuoc values ('GC02', '23:00:00', '07:00:00', 150, 1)




--delete from ChiTietSuDung

--select * from ChiTietSuDung where IDSIM = '0975116468' and TGBD >= '2018/10/22' and TGKT <= '2018/11/22' and Flag = 1

--select SUM(PhiCuocGoi) from ChiTietSuDung where IDSIM = '0975116468' and TGBD >= '2018/10/22' and TGKT <= '2018/11/22' and Flag = 1

--insert into HoaDonTinhCuoc values ('HD06', '0126486775', 50000, 86400, '2018/11/21', 0, 1)

--select Email from KhachHang, ThongTinSIM where KhachHang.MaKH = ThongTinSIM.MaKH and ThongTinSIM.IDSIM = '0914563575' and KhachHang.Flag = 1