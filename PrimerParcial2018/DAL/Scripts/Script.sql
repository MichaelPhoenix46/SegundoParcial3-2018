Create database PrimerParcialDb
use PrimerParcialDb
go
create table Vendedores
(
	Vendedorid int primary key identity(1,1),
	Nombres varchar(30),
	Sueldo decimal,
	PorRetencion decimal,
	Retencion decimal,
	Fecha datetime


)