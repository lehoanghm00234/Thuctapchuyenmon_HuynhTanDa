use Quanlykhachsan2
go

create proc themkh(
	@makh varchar(50),
	@tenkh varchar(50),
	@gioitinh varchar(50),
	@ngaysinh varchar(50),
	@cmnd varchar(50),
	@sdt varchar(50),
	@diachi varchar(50),
	@ghichu varchar(50)
	
)
as begin
	insert into khachhang values(@makh ,
	@tenkh ,
	@gioitinh ,
	@ngaysinh ,
	@cmnd ,
	@sdt ,
	@diachi ,
	@ghichu )

end

go
create proc update_kh(
	@makh varchar(50),
	@tenkh varchar(50),
	@gioitinh varchar(50),
	@ngaysinh varchar(50),
	@cmnd varchar(50),
	@sdt varchar(50),
	@diachi varchar(50),
	@ghichu varchar(50)
	
)
as begin
	update  khachhang set 
	 tenkh= @tenkh ,
	 gioitinh= @gioitinh ,
	ngaysinh= @ngaysinh ,
	cmnd= @cmnd ,
	 sdt =@sdt ,
	diachi= @diachi ,
	ghichu= @ghichu  where makh= @makh 

end


--Them loai phong.
 go
 create proc themloaiphong(
	@maloai varchar(50),
	@songuoi varchar(50),
	@gia varchar(50)
 )
 as begin
 insert into loaiphong values (
	@maloai,
	@songuoi,
	@gia
 )
 end

 go
 create proc suaLoaiPhong(
	@maloai varchar(50),
	@songuoi varchar(50),
	@gia varchar(50)
 )
 as begin 
  update loaiphong set
  
  songuoi = @songuoi,
  gia = @gia where maloai = @maloai
  end

go

--Xoa loai phong.
create proc deleteLoaiPhong(
	@maloai varchar(50)
)
as
begin
delete loaiphong where maloai = @maloai
end

--Xoa khach hang.
go
create proc deletekh(
	@makh nvarchar(50)
)
as

 begin
 delete khachhang where makh=@makh

 end
 --Them tinh trang
 go
 create proc themtinhtrang(
	@matinhtrang varchar(50),
	@tentinhtrang varchar(50)
 )
 as
 begin
 insert into tinhtrang values(
	@matinhtrang,
	@tentinhtrang
 )
 end
 --Sua tinh trang
 go
 create proc suatinhtrang(
	@matinhtrang varchar(50),
	@tentinhtrang nvarchar(50)
 )
 as
 begin
 update tinhtrang set
 tentinhtrang = @tentinhtrang
 where matinhtrang = @matinhtrang
 end
 --Xoa tinh trang
 go
 create proc xoatinhtrang(
	@matinhtrang varchar(50)
 )
 as begin
 delete tinhtrang where matinhtrang = @matinhtrang
 end
 --Them phong
 go
 alter proc themPhong (
	@maphong varchar(50),
	@matinhtrang varchar(50),
	@maloai varchar(50)
 )
 as begin
 insert into phong values(
	@maphong,
	@matinhtrang,
	@maloai
 )
 end
 --Sua phong
 go
 create proc suaPhong(
	@maphong varchar(50),
	@matinhtrang varchar(50),
	@maloai varchar(50)
 )
 as begin
 update phong set 
 matinhtrang = @matinhtrang,
 maloai=@maloai where maphong=@maphong
 end
 --Xoa phong
 go
 create proc xoaPhong(
	@maphong varchar(50)
 )
 as begin
 delete phong where maphong=@maphong
 end


 --Them phieu dat phong;
 go
 create proc themDatPhong(
	@matp varchar(50),
	@maphong varchar(50),
	@makh varchar(50),
	@ngaythue varchar(50),
	@soluong varchar(50)
 )
 as begin
 insert into phieuthuephong values(
	@matp,
	@maphong,
	@makh,
	@ngaythue,
	@soluong
 ) 
 end
 --Sua phieu thue phong
 go
 create proc suaDatPhong(
	@matp varchar(50),
	@maphong varchar(50),
	@makh varchar(50),
	@ngaythue varchar(50),
	@soluong varchar(50)
 )
 as begin
 update phieuthuephong set
 maphong = @maphong,
 makh = @makh,
 ngaythue = @ngaythue,
 soluong = @soluong where matp = @matp
 end
 --Xoa phieuthuephong
 go
 create proc xoaDatPhong(
	@matp varchar(50)
 )
 as begin
 delete phieuthuephong where matp = @matp
 end








 -- Them nhan vien
 go
 drop proc themNhanVien
 create proc themNhanVien(
	@manv varchar(50),
	@tennv varchar(50),
	@gioitinh varchar(50),
	@ngaysinh varchar(50),
	@sdt varchar(50),
	@diachi varchar(50),
	@luong varchar(50),
	@chucvu nvarchar(50),
	@tongluong nvarchar(50)
 )
 as begin
 insert into nhanvien values(
	@manv,
	@tennv,
	@gioitinh,
	@ngaysinh,
	@sdt,
	@diachi,
	
	@luong,
	@chucvu,
	@tongluong
 )
 end
 --Sua nhan vien
 go
 create proc suaNhanVien(
	@manv varchar(50),
	@tennv varchar(50),
	@gioitinh varchar(50),
	@ngaysinh varchar(50),
	@sdt varchar(50),
	@diachi varchar(50),
	@chucvu nvarchar(50),
	@luong nvarchar(50)
 )
 select * from nhanvien
 as begin
 update nhanvien set
 tennv = @tennv,
 gioitinh = @gioitinh,
 ngaysinh = @ngaysinh,
 sdt = @sdt,
 diachi = @diachi,
 chucvu = @chucvu,
 luong = @luong where manv = @manv
 end

-- Xoa nhan vien 
go 
create proc xoaNhanVien(
  @manv varchar(50)
)
as begin
delete nhanvien where manv = @manv
end
--Them chuc vu
go 
create proc themChucvu(
	@machucvu nvarchar(50),
	@tenchucvu nvarchar(50),
	@hesoluong nvarchar(50)
)
as begin
insert into chucvu values(
	@machucvu,
	@tenchucvu,
	@hesoluong
)
end
--Sua chuc vu
go
create proc suaChucvu(
	@machucvu nvarchar(50),
	@tenchucvu nvarchar(50),
	@hesoluong nvarchar(50)

)
as 
begin 
update chucvu set 
tenchucvu = @tenchucvu,
hesoluong = @hesoluong where machucvu = @machucvu
end
--Xoa chuc vu
go
create proc xoaChucvu(
	@machuvu nvarchar(50)
)
as begin
delete chucvu where machucvu = @machuvu
end