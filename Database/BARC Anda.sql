drop database if exists BARC;
create database BARC;
use BARC;

create table Socio(
CodSocio int auto_increment,
DNI varchar (10) not null,
Nombre varchar (60),
Apellido varchar (60),
Direccion varchar (30),
Localidad varchar (30),
Tel varchar (15),
Estado varchar(15),
constraint pk_persona primary key (CodSocio)
)engine=innodb;

create table Autor(
CodAutor int auto_increment,
Nombre varchar (60),
Apellido varchar (60),
constraint pk_autor primary key (CodAutor)
)engine=innodb;

create table Libro(
CodLibro int auto_increment,
Titulo varchar (90),
ISBN varchar (15),
Editorial varchar (20),
F_Publicacion varchar(10),
constraint pk_libro primary key (CodLibro)
)engine=innodb;

create table LibroAutor(
CodLibro int,
CodAutor int,
constraint pk_LibroAutor primary key (CodLibro, CodAutor),
constraint fk_LibroAutor_L foreign key (CodLibro) references Libro (CodLibro),
constraint fk_LibroAutor_A foreign key (CodAutor) references Autor (CodAutor)
)engine=innodb;

create table Ejemplar(
idEjem int auto_increment,
CodLibro int,
NEjemplar int,
Deteriorado boolean,
Prestado boolean,
constraint pk_Ejemplar primary key (idEjem),
constraint fk_Ejemplar foreign key (CodLibro) references Libro (CodLibro)
)engine=innodb;

-- GUARDA LOS PRESTAMOS POR SOCIO
create table Prestamo(
NPrestamo int auto_increment,
CodSocio int,
FPrestamo date,
FDevolucion date,
FTope date,
constraint pk_prestamo primary key (NPrestamo),
constraint fk_prestamo_S foreign key (CodSocio) references Socio(CodSocio)
)engine=innodb;

-- TABLA QUE RELACIONA LOS PRESTAMOS CON LOS EJEMPLARES
create table DetallePre( 
NPrestamo int, 
idEjem int,
constraint pk_prestamo primary key (NPrestamo, idEjem),
constraint fk_DetPre_prestamo foreign key (NPrestamo) references Prestamo(NPrestamo),
constraint fk_DetPre_ejem foreign key (idEjem) references Ejemplar(idEjem)
)engine=innodb;

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

insert into Usuarios values
(1,"root","root","root"),
(2,"Administrador","12345678","Admin");

insert into socio values(1000,"1","Carlos Saul","Menem","Calle Falsa 123","Bokita","0","Al dia");
insert into socio values('',"2","Mirtha","LeGrand","Cosmos","Via Lactea","0","Al dia");
insert into socio values('',"3","Mirtha","LeGarcha","Cosmos","Via Lactea","1","Baja");

INSERT INTO Autor VALUES
(10000, "Jorge Luis", "Borges"),
('', "Miguel", "de Cervantes"),
('', "Isaac", "Asimov");

INSERT INTO Libro VALUES
(20000, "El sol Desnudo", "ASDAASDASDDAS", "Doubleday", 1956),
('', "Los limites de la Fundacion", "DDAETQRQEDFADS", "Bruguera", 1960),
('', "Don Quijote de la Mancha", "DDAETQRQEDFADD", "Francisco de Robles", 1605),
('', "El libro de arena", "DDAETQRQEDSDADD", "Emece", 1975);

INSERT INTO LibroAutor VALUES 
(20000, 10002),
(20001, 10002),
(20002, 10001),
(20003, 10000);

INSERT INTO Ejemplar VALUES
(40000, 20000, 1, 0, 0),
('', 20000, 2, 0, 0),
('', 20000, 3, 0, 0),
('', 20000, 4, 0, 0),
('', 20000, 5, 0, 0),
('', 20001, 1, 0, 0),
('', 20001, 2, 0, 0),
('', 20001, 3, 0, 0),
('', 20001, 4, 0, 0),
('', 20002, 1, 0, 0),
('', 20002, 2, 0, 0),
('', 20003, 1, 0, 0),
('', 20003, 2, 0, 0),
('', 20003, 3, 0, 0);

/*
consulta para el catalogo:
SELECT l.CodLibro, titulo, nombre, apellido, isbn, editorial, f_publicacion, count(*) FROM 
Libro l, autor a, libroautor la, ejemplar e WHERE la.codlibro = l.codlibro AND la.codautor = a.codautor AND e.codlibro = l.codlibro Group BY (e.codlibro)

TAREAS PARA LA BASE DE DATOS:

1. Crear Procedure para agregar ejemplares de libros con parametros de entrada, (Nombre, ISBN, Editorial, DATEPublicacion, Nombre Autor, Apellido Autor, cantidad de ejemplares).
si no existe el autor crearlo, agregar el libro si no existe, una vez agregado el libro agregar los ejemplares.
*/
