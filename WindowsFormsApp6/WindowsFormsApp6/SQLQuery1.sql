create database arac_kiralama
use arac_kiralama

create table m�steriler(
Tc_kimlik int,
Kullan�c�_ad� nvarchar(20),
Sifre nvarchar(20),
E_Mail varchar(50),
ehliyet_no int,
)
create table Y�netici(
Kullan�c�_ad� nvarchar(20),
Sifre nvarchar(20),
)

create table arac_bilgileri(
Plaka nvarchar(20),
Marka nvarchar(20),
Model nvarchar(20),
Y�l� int,

)
insert into arac_bilgileri(Plaka,Marka,Model,Y�l�) values ('34AG9012','Wolkswagen','Polo',2012)

insert into arac_bilgileri(Plaka,Marka,Model,Y�l�) values ('34UV351','Honda','Civic',2013)

create table Musteri_bilgileri(
tc_kimlik int,
kullan�c�ad� nvarchar(20),
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

insert into Y�netici(Kullan�c�_ad�,Sifre) values('Furkan',123456)
insert into Y�netici(Kullan�c�_ad�,Sifre) values('Soner',123)

insert into m�steriler(Tc_kimlik,Kullan�c�_ad�,Sifre,E_Mail,ehliyet_no) values (480905980,'Furkann','Furkan12','furkan@gmail.com',12345)
insert into m�steriler(Tc_kimlik,Kullan�c�_ad�,Sifre,E_Mail,ehliyet_no) values (452905435,'Soner','soner12','soner@gmail.com',55345)
insert into m�steriler(Tc_kimlik,Kullan�c�_ad�,Sifre,E_Mail,ehliyet_no) values (480903435,'Fatih','fatih12','fatih@gmail.com',64345)
insert into m�steriler(Tc_kimlik,Kullan�c�_ad�,Sifre,E_Mail,ehliyet_no) values (485296253,'Ahmet','ahmet12','ahmet@gmail.com',62345)
select * from m�steriler

insert into ar

select * from m�steriler