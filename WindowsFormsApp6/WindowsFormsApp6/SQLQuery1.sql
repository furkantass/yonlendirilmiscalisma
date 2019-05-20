create database arac_kiralama
use arac_kiralama

create table müsteriler(
Tc_kimlik int,
Kullanýcý_adý nvarchar(20),
Sifre nvarchar(20),
E_Mail varchar(50),
ehliyet_no int,
)
create table Yönetici(
Kullanýcý_adý nvarchar(20),
Sifre nvarchar(20),
)

create table arac_bilgileri(
Plaka nvarchar(20),
Marka nvarchar(20),
Model nvarchar(20),
Yýlý int,

)
insert into arac_bilgileri(Plaka,Marka,Model,Yýlý) values ('34AG9012','Wolkswagen','Polo',2012)

insert into arac_bilgileri(Plaka,Marka,Model,Yýlý) values ('34UV351','Honda','Civic',2013)

create table Musteri_bilgileri(
tc_kimlik int,
kullanýcýadý nvarchar(20),
sifresi nvarchar(20),
maili nvarchar(20),
ehliyet_no int,
)

create table arac_kira(
tc_kimlik int,
plaka nvarchar(20),
alis_tarihi date,
veris_tarihi date,
fiyat money
)

select * from arac_kiralama

insert into Yönetici(Kullanýcý_adý,Sifre) values('Furkan',123456)
insert into Yönetici(Kullanýcý_adý,Sifre) values('Soner',123)

insert into müsteriler(Tc_kimlik,Kullanýcý_adý,Sifre,E_Mail,ehliyet_no) values (480905980,'Furkann','Furkan12','furkan@gmail.com',12345)
insert into müsteriler(Tc_kimlik,Kullanýcý_adý,Sifre,E_Mail,ehliyet_no) values (452905435,'Soner','soner12','soner@gmail.com',55345)
insert into müsteriler(Tc_kimlik,Kullanýcý_adý,Sifre,E_Mail,ehliyet_no) values (480903435,'Fatih','fatih12','fatih@gmail.com',64345)
insert into müsteriler(Tc_kimlik,Kullanýcý_adý,Sifre,E_Mail,ehliyet_no) values (485296253,'Ahmet','ahmet12','ahmet@gmail.com',62345)
select * from müsteriler

insert into ar

select * from müsteriler