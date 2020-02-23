create database MusteriApp

use MusteriApp
create table Admin(
Id uniqueidentifier primary key,
KullaniciAd nvarchar(100),
Sifre nvarchar(100)
)

create table Musteri(
Id uniqueidentifier primary key,
Isim nvarchar(100)
)
create table Adres(
Id uniqueidentifier primary key,
Tanim nvarchar(300),
MusteriId uniqueidentifier,
foreign key (MusteriId) references Musteri(Id) on delete cascade
)

drop table Adres


--insert into Admin values (newid(),'yvz','1')

--select * from Admin

--'E3E4DF1D-808A-414D-A753-471FE2200181'

select * from Musteri

insert into Musteri values(newid(),'Yavuz')

select * from Adres