delimiter //

drop database if exists BARC;
create database BARC;
use BARC;

create table Socio(
CodSocio int primary key auto_increment,
DNI varchar (10) not null,
Nombre varchar (60),
Apellido varchar (60),
Direccion varchar (30),
Localidad varchar (30),
Tel varchar (15),
Estado varchar(15)
);

create table nuevos(
CodSocio int primary key auto_increment,
DNI varchar (10) not null,
Nombre varchar (60),
Apellido varchar (60),
Direccion varchar (30),
Localidad varchar (30),
Tel varchar (15)
);

create table Autor(
CodAutor int primary key auto_increment,
Nombre varchar (60),
Apellido varchar (60)
);

create table Libro(
CodLibro int primary key auto_increment,
Titulo varchar (90),
ISBN varchar (15),
Editorial varchar (20),
F_Publicacion varchar(10),
PrecioVenta FLOAT
);

create table LibroAutor(
CodLibro int,
CodAutor int,
primary key (CodLibro, CodAutor)
);

create table Ejemplar(
idEjem int primary key auto_increment,
CodLibro int,
Deteriorado boolean,
Prestado boolean,
Vendido boolean,
Alquiler boolean
);

-- GUARDA LAS COMPRAS

create table Compra(
CodCompra int primary key auto_increment,
CodSocio int not null,
FechaCompra date,
Monto_Total decimal(9,2),
Estado varchar(13)
);

-- RELACIONA LAS COMPRAS DEL SOCIO CON LOS EJEMPLARES
create table DetalleCompra(
CodCompra int,
idEjem int,
Monto_Individual FLOAT,
primary key (CodCompra, idEjem)
);

-- GUARDA LOS ALQUILERES
create table Alquiler(
CodAlquiler int primary key auto_increment,
CodSocio int not null,
Fecha_Inicio date,
Fecha_Devolucion date,
Fecha_Tope date,
Estado VARCHAR(13),
Monto_Total FLOAT,
Monto_Semanal FLOAT
);

-- TABLA QUE RELACIONA LOS PRESTAMOS CON LOS EJEMPLARES
create table DetalleAlq( 
CodAlquiler int,
idEjem int,
primary key (CodAlquiler, idEjem)
);

create table Envio(
CodEnvio int primary key auto_increment,
CodOperacion int,
Estado_Envio varchar(20)
);

/* no la borro porque capaz nos sirve despues
create table EstadoPre(
NPrestamo int primary key,
Entregado boolean,
FechaDePago date,
Plan int,
Pagado boolean,
foreign key (NPrestamo) references Prestamo(NPrestamo),
foreign key (Plan) references PlanDePago(idPlan)
);
*/


create table Eventos(
NEvento int primary key auto_increment,
Descripcion varchar (100)
);

/* no entra en el sistema
create table AsisEvento(
NEvento int,
CodSocio int,
primary key (NEvento, CodSocio),
foreign key (NEvento) references Eventos(NEvento)
);
*/
/* tampoco entra en el sistema 
create table Corredores(
CodCorredor int primary key,
DNI varchar (10),
Nombre varchar (60),
Apellido varchar (60),
Direccion varchar (30),
Tel varchar (15),
Localidad varchar (30),
Sueldo decimal(7,2)
);
*/


create table Usuarios(
CodUsuario int primary key,
Usuario varchar(20),
Password varchar(30),
Permisos varchar(15)
);




alter table LibroAutor add constraint FK_LibroAutor_L foreign key (CodLibro) references Libro (CodLibro);

alter table LibroAutor add constraint FK_LibroAutor_A foreign key (CodAutor) references Autor (CodAutor);

alter table Ejemplar add constraint FK_Ejemplar foreign key (CodLibro) references Libro (CodLibro);

alter table Compra add constraint FK_Compra_Soc foreign key (CodSocio)
references Socio (CodSocio);

alter table DetalleCompra add constraint FK_DetalleCompra_C foreign key (CodCompra) references Compra(CodCompra);

alter table DetalleCompra add constraint FK_DetalleCompra_E foreign key (idEjem) references Ejemplar(idEjem);

alter table Alquiler add constraint FK_AlquilerSocio foreign key (CodSocio) references Socio(CodSocio);

alter table DetalleAlq add constraint FK_DetalleAlquiler foreign key (CodAlquiler) references Alquiler(CodAlquiler);

alter table DetalleAlq add constraint FK_DetalleEjemplar foreign key (idEjem) references Ejemplar(idEjem);

alter table Envio add constraint FK_OperacionAlquiler foreign key (CodOperacion) references Alquiler(CodAlquiler);

alter table Envio add constraint FK_OperacionCompra foreign key (CodOperacion) references Compra(CodCompra);




insert into Usuarios values
(1,"root","root","root"),
(2,"Administrador","12345678","Admin");

insert into socio values(1000,"1","Carlos Saul","Menem","Calle Falsa 123","Bokita","0","Al dia");
insert into socio values('',"2","Mirtha","LeGrand","Cosmos","Via Lactea","0","Al dia");
insert into socio values('',"3","Cacho","Castaña","Cosmos","Via Lactea","1","Baja");
insert into socio values('',"43917632", "Luquitas", "ElmasCapo", "Av Falsa 1230", "CABA", "1150405955", "Al dia");

INSERT INTO Autor VALUES
(10000, "Jorge Luis", "Borges"),
('', "Miguel", "de Cervantes"),
('', "Isaac", "Asimov");

INSERT INTO Libro VALUES
(20000, "El sol Desnudo", "ASDAASDASDDAS", "Doubleday", 1956,1000),
('', "Los limites de la Fundacion", "DDAETQRQEDFADS", "Bruguera", 1960,1200),
('', "Don Quijote de la Mancha", "DDAETQRQEDFADD", "Francisco de Robles", 1605,600),
('', "El libro de arena", "DDAETQRQEDSDADD", "Emece", 1975,950);

INSERT INTO LibroAutor VALUES 
(20000, 10002),
(20001, 10002),
(20002, 10001),
(20003, 10000);

-- id, codlibrom, deteriorado, prestado, vendido, alquiler
INSERT INTO Ejemplar VALUES
(40000, 20000, 0, 0, 1, 0),
('', 20000, 0, 0, 1, 0),
('', 20000, 0, 0, 0, 1),
('', 20000, 0, 0, 0, 1),
('', 20000, 0, 0, 0, 1),
('', 20001, 0, 0, 1, 0),
('', 20001, 0, 0, 0, 0),
('', 20001, 0, 0, 0, 1),
('', 20001, 0, 0, 0, 1),
('', 20002, 0, 0, 0, 0),
('', 20002, 0, 0, 0, 1),
('', 20003, 0, 0, 0, 0),
('', 20003, 0, 0, 0, 0),
('', 20003, 0, 0, 0, 1);


INSERT INTO Compra VALUES
(300000, 1000, curdate(), 10000, "Adeuda"),
('', 1001, curdate(), 12000, "Pagada");

INSERT INTO DetalleCompra VALUES
(300000, 40000, 5000),
(300000, 40001, 5000),
(300001, 40005, 12000);




DROP PROCEDURE IF EXISTS AltaCompra//
CREATE PROCEDURE AltaCompra(CodigoSocio INT, Total FLOAT)
BEGIN 
	DECLARE CodCompra_ INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra)+1 FROM Compra );
	INSERT INTO Compra VALUES
	(CodCompra_, CodigoSocio, CURDATE(), Total, "Adeuda");
END//

DROP PROCEDURE IF EXISTS AltaCompras//
CREATE PROCEDURE AltaCompras(CodigoLibro INT, CodigoSocio INT, CantEjemplares INT, PrecioInd FLOAT, Total FLOAT)
BEGIN
	DECLARE It INT;
	DECLARE idEjem_ INT;
	DECLARE CodCompra_ INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra) FROM Compra );
	SET It = 1;
	WHILE It <= CantEjemplares DO
		SET idEjem_ = (SELECT idEjem FROM Ejemplar WHERE Vendido = 0 AND Alquiler = 0 AND Deteriorado = 0
		AND CodLibro = CodigoLibro LIMIT 1);
		INSERT INTO DetalleCompra VALUES
		(CodCompra_, idEjem_, PrecioInd);
		UPDATE Ejemplar SET vendido = true WHERE idEjem = idEjem_;
		SET It = It + 1;
	END WHILE;
END//
/*
consulta para el catalogo:
SELECT l.CodLibro, titulo, nombre, apellido, isbn, editorial, f_publicacion, count(*) FROM 
Libro l, autor a, libroautor la, ejemplar e WHERE la.codlibro = l.codlibro AND la.codautor = a.codautor AND e.codlibro = l.codlibro Group BY (e.codlibro)

TAREAS PARA LA BASE DE DATOS:

1. Crear Procedure para agregar ejemplares de libros con parametros de entrada, (Nombre, ISBN, Editorial, DATEPublicacion, Nombre Autor, Apellido Autor, cantidad de ejemplares).
si no existe el autor crearlo, agregar el libro si no existe, una vez agregado el libro agregar los ejemplares.
*/

delimiter ;
