delimiter //

drop database if exists BARC;
create database BARC;
use BARC;

create table Socios(
CodSocio int primary key auto_increment,
DNI varchar (10) not null,
Nombre varchar (60),
Apellido varchar (60),
Direccion varchar (30),
Localidad varchar (30),
Tel varchar (15),
Estado varchar(15),
SocioDesde date
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

CREATE TABLE BajasSocios(
IDBaja int primary key auto_increment,
CodSocio int,
FechaBaja DATE
);

create table Editoriales(
CodEditorial int primary key auto_increment,
NombreEditorial VARChAR(20)
);

create table Autores(
CodAutor int primary key auto_increment,
Nombre varchar (60),
Apellido varchar (60)
);

create table Libros(
CodLibro int primary key auto_increment,
Titulo varchar (90),
ISBN varchar (15),
Editorial int,
F_Publicacion varchar(10),
PrecioVenta FLOAT,
PrecioAlquiler FLOAT, -- por semana
PuntoPedido INT,
PuntoPedidoAlquiler INT
);

create table LibroAutor(
CodLibro int,
CodAutor int,
primary key (CodLibro, CodAutor)
);

create table Ejemplares( -- modificar en abm??
idEjem int primary key auto_increment,
CodLibro int,
Deteriorado boolean,
Prestado boolean,
Vendido boolean,
Alquiler boolean
);

-- GUARDA LAS COMPRAS

create table Compras( -- modificar?? (abm)
CodCompra int primary key auto_increment,
CodSocio int not null,
FechaCompra date,
FTopePago date,
TipoDePago varchar(15), -- contado o financiado SI ES AL CONTADO SE HACE DESCUENTO
Cantpagos int, -- si es al contado es null
Estado varchar(13),
Corredor int
);

-- solo para compras, si es financiado cargas aca la compra
create table Cuotas(
CodCompra int,
NumCuota int,
FVencimiento date,
Monto float,
FPago date,
EstadoPago boolean,-- pagada o no
foreign key (CodCompra) references Compras(CodCompra),
Primary key (CodCompra, NumCuota)
);

-- RELACIONA LAS COMPRAS DEL SOCIO CON LOS EJEMPLARES
create table DetalleCompra(
CodCompra int,
idEjem int,
Monto_Individual FLOAT,
primary key (CodCompra, idEjem)
);

-- GUARDA LOS ALQUILERES
create table Alquileres( -- modificar?? (abm)
CodAlquiler int primary key auto_increment,
CodSocio int not null,
Fecha_Inicio date,
Fecha_Devolucion date,
Fecha_Tope date,
Fecha_VencimientoPago date,
EstadoPago VARCHAR(13),
Corredor int
);

-- TABLA QUE RELACIONA LOS PRESTAMOS CON LOS EJEMPLARES
create table DetalleAlq( 
CodAlquiler int,
idEjem int,
Monto_Individual_Semanal FLOAT,
primary key (CodAlquiler, idEjem)
);

create table Envios( -- opcion de realizar envio si quiere cargas el envio aca, luego en la pantalla de envios los visualizas
CodEnvio int primary key auto_increment,
Fecha_Aceptado DATE, -- fecha en la que se acepta
CodAlquiler int,
CodCompra int,
Estado_Envio varchar(20) -- en preparacion, enviado,
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
Nombre VARCHAR(40),
Descripcion varchar (500),
Fecha DATE,
Motivo VARCHAR(400)
);
/*
Creamos eventos, y cargamos por evento los socios que asistieron.
*/
create table AsisEvento(
NEvento int,
CodSocio int,
primary key (NEvento, CodSocio),
foreign key (NEvento) references Eventos(NEvento),
foreign key (CodSocio) references Socios(CodSocio)
);

create table Zonas(
CodZona int primary key auto_increment,
LimS varchar(60),
LimN varchar(60),
LimE varchar(60),
LimO varchar(60)
);

create table Corredores(
CodCorredor int primary key auto_increment,
DNI varchar (10),
Nombre varchar (60),
Apellido varchar (60),
Tel varchar (15),
Baja BOOLEAN
);

create table Corredores_Zonas(
CodCorredor int,
CodZona int,
foreign key (CodCorredor) references Corredores(CodCorredor),
foreign key (CodZona) references Zonas(CodZona)
);

create table Recorridos(
NRecorrido int primary key auto_increment,
Fecha date,
Corredor int,
foreign key (Corredor) REFERENCES Corredores(CodCorredor)
);
/*
SE HACE UN PROCEDURE CON CALENDARIO 1 vez por semana
los que no compraron en la semana se programa el recorrido aca.
*/
create table Recorridos_Soc(
NRecorrido int,
Socio int,
primary key (NRecorrido, Socio),
foreign key (NRecorrido) references Recorridos(NRecorrido),
foreign key (Socio) references Socios(CodSocio)
);

create table Usuarios(
CodUsuario int primary key,
Usuario varchar(20),
Password varchar(30)
);

create table Remitos( -- para envios a socios
NRemito int primary key auto_increment,
ImporteTotal FLOAT,
CodCompra int,
CodAlquiler int,
FechaRecepcion DATE -- fecha enq ue recibe el libro el socio
);

CREATE TABLE DetalleRem(
NRemito int,
idEjem INT,
primary key(NRemito, idEjem),
foreign key (idEjem) REFERENCES Ejemplares(idEjem),
foreign key (NRemito) REFERENCES Remitos(NRemito)
);

CREATE TABLE Facturas( -- solo compra, socio compra y generamos las compras y la factura, solo contado
CodFactura INT auto_increment,
Fecha DATE,
CodSocio INT,
Total FLOAT,
CodCompra int,
PRIMARY KEY (CodFactura),
FOREIGN KEY (CodSocio) references Socios(CodSocio),
FOREIGN KEY (CodCompra) references Compras(CodCompra)
);


CREATE TABLE Recibos( -- cuando me pagan genero el recibo y se relaciona mediante el codigo de operacion
NRecibo int primary key auto_increment,
fecha DATE,
CodSocio INT,
Total FLOAT, -- siempre es el total del valor
CodCompra int,
CodAlquiler int,
Corredor int,
Interes int, --  si esta financiado el interes de la tabla cuota, si no NULL porcentual ????
Motivo VARCHAR(40),
FOREIGN KEY (CodSocio) references Socios(CodSocio),
FOREIGN KEY (CodCompra) references Compras(CodCompra),
FOREIGN KEY (CodAlquiler) references Alquileres(CodAlquiler),
foreign key (Corredor) references Corredores(CodCorredor)
);

create table Solicitudes_Compras( -- te la deniego si esta mal?
NSoli int primary key auto_increment,
Proveedor int,
Estado Varchar(15),
Fecha date
);

create table Solicitudes_Compras_Det(
IDSolCompDet int auto_increment,
NSoli int,
Libro varchar (15),
Cantidad int,
primary key (IDSolCompDet),
foreign key (NSoli) references Solicitudes_Compras(NSoli)
);

create table Nota_Pedidos(
NNotaPedido int primary key auto_increment,
Fecha date,
NSoli int,
Estado varchar(15), -- estado = cancelada?
foreign key (NSoli) references Solicitudes_Compras(NSoli)
);

/*
create table Nota_Pedidos_Det(
IDNotaDet int auto_increment,
NNotaPedido int,
Libro varchar (15),
primary key (IDNotaDet),
foreign key (NNotaPedido) references Nota_Pedidos(NNotaPedido)
);
*/

create table Comprobantes_Entradas( -- llega el libro del proveedor, puede qudar pendiente
IDCompEntrada int Primary KEY auto_increment,
IDNotaPedido int,
NFacturaProveedor int,
Pagado boolean,
foreign key (IDNotaPedido) references Nota_Pedidos(NNotaPedido)
);

create table Comprobantes_Entradas_Det(
IDCompDet int auto_increment,
IDCompEntrada int,
Libro varchar (15),
Cantidad int,
PrecioUni float,
primary key (IDCompDet),
foreign key (IDCompEntrada) references Comprobantes_Entradas(IDCompEntrada)
);

create table Hojas_de_Ruta( -- cuando haces envios, haces la hora de ruta
NHojaRuta int primary key auto_increment,
Fecha date,
Estado varchar(15)
);
-- al finalizar el dia se toman todos los envios que se cargaron en el dia y se genera la hoja de ruta

create table Hojas_de_Ruta_Det(
NHojaRuta int,
NRemito int,
CantiLib int,
primary key (NHojaRuta, NRemito),
foreign key (NHojaRuta) references Hojas_de_Ruta(NHojaRuta),
foreign key (NRemito) references Remitos(NRemito)
);

/*create table Financiaciones(
NFinanciacion int primary key auto_increment,
CodCompra int,
CodAlquiler int,
Cuotas int,
Medio varchar(15),
Fecha date,
Monto_Total FLOAT
); 
create table Deudores( -- cuando ya va a legales, paso 2 meses con compras que adeuda
NDeudor int primary key auto_increment,
CodSocio int,
Monto float,
FechaFinDeuda date,
foreign key (CodSocio) references Socios(CodSocio)
);
*/

create table Balances_Diarios( -- al final del dia se calcula en base a los recibos y pago de proveedor
IDBalance int primary key auto_increment,
FechaBalance date ,
Balance float,
A_Favor boolean
);

create table Balances_Mensuales( -- al final del mes en base a los recibos y pago de proveedor
IDBalance int primary key auto_increment,
FechaCierre date,
Balance float,
A_Favor boolean
);

create table Detalle_Factura(
CodFactura int,
CodLibro int,
Cantidad int,
primary key(CodFactura, CodLibro),
foreign key (CodFactura) references Facturas(CodFactura),
foreign key (CodLibro) references Libros(CodLibro)
);

create table Cheques( -- pago al proveedor, sirve de comprobante que pagamos
NCheque int primary key auto_increment,
Monto float,
Proveedor int,
FechaEmision date,
FechaVence date,
NFacturaProveedor int
);

create table Intereses(
CodInteres int primary key auto_increment,
DiasAtrasados int,
Porcentaje int
);

create table Proveedores(
CodProveedor int primary key auto_increment,
Proveedor VARCHAR(40),
Direccion VARCHAR(50),
Telefono VARCHAR(12)
);

create Table Proveedores_Editoriales(
CodProveedor int,
Editorial int,
primary key (CodProveedor, Editorial)
);

CREATE TABLE Calendario(
IdCalendario int primary key auto_increment,
Intervalo VARCHAR(30),
Fecha DATETIME
);

CREATE TABLE Notificaciones(
IdNotificacion int primary key auto_increment,
Fecha date,
Tipo VARCHAR(50),
Detalle VARCHAR(100),
Usuario VARCHAR(40),
Vista boolean
);

CREATE TABLE Inactivos_Temp(
CodSocio INT PRIMARY KEY,
FechaMax DATE
);

alter table LibroAutor add constraint FK_LibroAutor_L foreign key (CodLibro) references Libros (CodLibro);

alter table LibroAutor add constraint FK_LibroAutor_A foreign key (CodAutor) references Autores (CodAutor);

alter table Ejemplares add constraint FK_Ejemplar foreign key (CodLibro) references Libros (CodLibro);

alter table Compras add constraint FK_Compra_Soc foreign key (CodSocio)
references Socios (CodSocio);

alter table DetalleCompra add constraint FK_DetalleCompra_C foreign key (CodCompra) references Compras(CodCompra);

alter table DetalleCompra add constraint FK_DetalleCompra_E foreign key (idEjem) references Ejemplares(idEjem);

alter table Alquileres add constraint FK_AlquilerSocio foreign key (CodSocio) references Socios(CodSocio);

alter table DetalleAlq add constraint FK_DetalleAlquiler foreign key (CodAlquiler) references Alquileres(CodAlquiler);

alter table DetalleAlq add constraint FK_DetalleEjemplar foreign key (idEjem) references Ejemplares(idEjem);

alter table Envios add constraint FK_OperacionAlquiler foreign key (CodAlquiler) references Alquileres(CodAlquiler);

alter table Envios add constraint FK_OperacionCompra foreign key (CodCompra) references Compras(CodCompra);

alter table Alquileres add constraint FK_Alquiler_C foreign key (Corredor) references Corredores(CodCorredor);

alter table Compras add constraint FK_Compra_C foreign key (Corredor) references Corredores(CodCorredor);

alter table Solicitudes_Compras add constraint FK_Proveedor foreign key (Proveedor) references Proveedores(CodProveedor);

alter table Cheques add constraint FK_Proveedor_Cheque foreign key (Proveedor) references Proveedores(CodProveedor);

alter table Libros add constraint FK_Editorial_Libro foreign key (Editorial) references Editoriales(CodEditorial);

alter table Proveedores_Editoriales add constraint FK_Proveedor_Editorial foreign key (Editorial) references Editoriales(CodEditorial);

alter table Remitos add constraint FK_Remito_CodCompra foreign key (CodCompra) references Compras(CodCompra);

alter table Remitos add constraint FK_Remito_CodAlquiler foreign key (CodAlquiler) references Alquileres(CodAlquiler);

alter table BajasSocios add constraint FK_BajaSocio foreign key (CodSocio) references Socios(CodSocio);

insert into Usuarios values
(1,"root","root"),
(2,"administrador","12345678"),
(3,"libros", "libros"),
(4, "administracion", "administracion"),
(5, "logistica", "logistica"),
(6, "atencion", "atencion");

insert into Socios values(1000,"11223344","Carlos Saul","Fernandez","Av Francisco Beiro 5300","C.A.B.A.","1125348180","Moroso", 20191029);
insert into Socios values('',"22334455","Susana","Perez","Virgilio 2650","C.A.B.A.", "1134879654","Al dia", 20191101);
insert into Socios values('',"43917632", "Lucas", "Castelao", "Emilio Castro 7200", "C.A.B.A", "1150405955", "Al dia", 20191109);

INSERT INTO Autores VALUES
(10000, "Jorge Luis", "Borges"),
('', "Miguel", "de Cervantes"),
('', "Isaac", "Asimov"),
(10004, "J.K", "Rowling");

INSERT INTO Editoriales VALUES
(1, 'DEBOLSILLO'),
(2, "S.L.U. ESPASA LIBROS"),
(3, "Salamandra");

INSERT INTO Libros VALUES
(20000, "El sol Desnudo", "9788497937856", 1, 1956,5000, 500, 2, 1),
(20001, "Los limites de la Fundacion", "9788484505969", 1, 1960, 6000, 600, 2, 1),
(20002, "Don Quijote de la Mancha", "9788467016901", 2, 1605, 3000, 300, 2, 1),
(20003, "El libro de arena", "9788499089522", 1, 1975, 4750, 475, 2, 1),
(20004, "Harry Potter y La Piedra Filosofal", "9788498386561", 3, 1997, 950, 200, 2, 1),
(20005, "Harry Potter y La Camara Secreta", "9788498389104", 3, 1998, 815, 250, 2, 1);

INSERT INTO LibroAutor VALUES 
(20000, 10002),
(20001, 10002),
(20002, 10001),
(20003, 10000),
(20004, 10004),
(20005, 10004);

-- id, codlibrom, deteriorado, prestado, vendido, alquiler
INSERT INTO Ejemplares VALUES
(40000, 20000, 0, 0, 1, 0),
(40001, 20000, 0, 0, 1, 0),
(40002, 20000, 0, 0, 0, 1),
(40003, 20000, 0, 0, 0, 1),
(40004, 20000, 0, 0, 0, 1),
(40005, 20001, 0, 0, 1, 0),
(40006, 20001, 0, 0, 1, 0),
(40007, 20001, 0, 0, 0, 1),
(40008, 20001, 0, 0, 0, 1),
(40009, 20002, 0, 0, 0, 0),
(40010, 20002, 0, 0, 0, 1),
(40011, 20003, 0, 0, 0, 0),
(40012, 20003, 0, 0, 0, 0),
(40013, 20003, 0, 0, 0, 1),
(40014, 20004, 0, 0, 0, 0),
(40015, 20004, 0, 1, 0, 1),
(40016, 20005, 0, 0, 0, 0),
(40017, 20005, 0, 1, 0, 1),
('', 20000, 0, 0, 1, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 1),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 1),
('', 20000, 0, 0, 0, 0),
('', 20000, 0, 0, 0, 1),
('', 20001, 0, 0, 0, 0),
('', 20001, 0, 0, 0, 0),
('', 20001, 0, 0, 0, 0),
('', 20002, 0, 0, 0, 0),
('', 20002, 0, 0, 0, 1),
('', 20004, 0, 0, 0, 0),
('', 20004, 0, 0, 0, 0),
('', 20004, 0, 0, 0, 0),
('', 20004, 0, 0, 0, 1),
('', 20004, 0, 0, 0, 1),
('', 20004, 0, 0, 0, 1),
('', 20005, 0, 0, 0, 0),
('', 20005, 0, 0, 0, 0),
('', 20005, 0, 0, 0, 0),
('', 20005, 0, 0, 0, 0),
('', 20005, 0, 0, 0, 1),
('', 20005, 0, 0, 0, 1),
('', 20005, 0, 0, 0, 1);

/* sur, oeste, norte, este */
INSERT INTO Zonas VALUES
(150000, "Nogoya", "Gral. Paz", "Salvador Maria el Carril", "Bermudez"),
('', "Rivadavia", "Gral. Paz", "Nogoya", "Irigoyen"),
('', "Emilio Castro", "Gral.Paz", "Rivadavia", "Escalada"),
('', "Directorio", "Gral.Paz", "Emilio Castro", "Escalada"),
('', "Juan B Justo", "Irigoyen", "Nogoya", "Segurola"),
('', "Juan B Justo", "Segurola", "Francisco Beiro", "Nazca"),
('', "Directorio", "Escalada", "Rivadavia", "San Pedrito"),
('', "Castañares", "Escalada", "Directorio", "Mariano Acosta");

INSERT INTO Corredores VALUES
(5000, "85124636", "Juan", "Perez", "1152689547", 0),
('', "85124637", "Angel David", "Neglia", "1145789654", 0),
('', "85124638", "Maximiliano", "Garcia", "1123526214", 0),
('', "85124639", "Erendira", "Lazo", "1122504525", 0);

INSERT INTO Corredores_Zonas VALUES
(5000, 150000),
(5000, 150001),
(5001, 150002),
(5001, 150003),
(5002, 150004),
(5002, 150005),
(5003, 150006),
(5003, 150007);

INSERT INTO Intereses VALUES
(10, 1, 2),
('', 7, 4),
('', 14, 9),
('', 21, 15),
('', 30, 21),
('', 45, 25),
('', 60, 30);

INSERT INTO Compras VALUES
(300000, 1000, 20191029, 20191105, "Contado", 1, "Pagado", 5000),
('', 1000, 20191101, 20191108, "Contado", 1, "Impago", 5000),
('', 1000, 20191101, 20191108, "Financiado", 2, "Impago", 5000),
('', 1000, 20191106, 20191113, "Contado", 1, "Impago", 5000);

INSERT INTO DetalleCompra VALUES
(300000, 40000, 4500),
(300000, 40001, 4500),
(300001, 40005, 5400),
(300002, 40006, 6000),
(300003, 40018, 4500);

INSERT INTO Cuotas VALUES
(300002, 1, 20191108, 3000, NULL, 0),
(300002, 2, 20191208, 3000, NULL, 0);

INSERT INTO Alquileres VALUES
(400000, 1001, 20191101, 20191115, 20191115, 20191108, "Pagado", 5000),
(400001, 1002, 20191109, NULL, 20191130, 20191116, "Impago", 5001);
/*
('', 1002, 20191018, NULL, 20191108, 20191101, "Impago", 5000),
('', 1000, 20191018, NULL, 20191108, 20191101, "Impago", 5000);
*/
INSERT INTO DetalleAlq VALUES
(400000, 40002, 500),
(400000, 40015, 200),
(400001, 40015, 200),
(400001, 40017, 250);

INSERT INTO Envios VALUES
(100000, 20191030, NULL, 300000, 'Entregado'),
('', 20191102, 400000, NULL, 'Entregado'),
('', 20191102, NULL, 300001, 'Entregado'),
('', 20191102, NULL, 300002, "Entregado"),
(100004, 20191110, 400001, NULL, 'Entregado');

INSERT INTO Facturas VALUES
(400000, 20191029, 1000, 9000, 300000),
('', 20191029, 1000, 5400, 300001),
('', 20191029, 1000, 6000, 300002),
('', 20191106, 1000, 4500, 300003);

INSERT INTO Detalle_Factura VALUES
(400000, 20000, 2),
(400001, 20000, 1),
(400001, 20001, 1),
(400002, 20001, 1),
(400003, 20000, 1);

INSERT INTO Recibos VALUES 
(500000, 20191101, 1000, 9000, 300000, NULL, 5000, 0, 'Pago de Compra'),
('', 20191101, 1001, 1400, NULL, 400000, 5000, 0, 'Recibo de Alquiler'),
('', 20191101, 1001, 1400, NULL, 400000, 5000, 0, 'Pago de Alquiler'),
('', 20191109, 1002, 1350, NULL, 400001, 5001, 0, 'Recibo de Alquiler');

INSERT INTO Remitos VALUES
(100000, 9000, 300000, NULL, 20191031),
('', 2100, NULL, 400000, 20191103),
('', 5400, 300001, NULL, 20191103),
('', 6000, 300002, NULL, 20191103),
('', 1650, NULL, 400001, 20191111);

INSERT INTO DetalleRem VALUES
(100000, 40000),
(100000, 40001),
(100001, 40002),
(100001, 40015),
(100002, 40005),
(100003, 40006);

INSERT INTO Hojas_de_Ruta VALUES
(900000, 20191031, "Entregado"),
('', 20191103, "Entregado"),
('', 20191111, "Entregado");

INSERT INTO Hojas_de_Ruta_Det VALUES
(900000, 100000, 2),
(900001, 100001, 2),
(900001, 100002, 1),
(900001, 100003, 1),
(900002, 100004, 2);

INSERT INTO Recorridos VALUES
(1, 20191031, 5000),
('', 20191103, 5000),
('', 20191111, 5001);

INSERT INTO Recorridos_Soc VALUES
(1, 1000),
(2, 1000),
(2, 1001),
(3, 1002);

INSERT INTO Proveedores VALUES
(10, "LEAS Distribuidora.", "Thompson 250, Bahia Blanca", "0291-455-3691"),
('', "Distribuidora Tramas.", "Echeverría 1446, Loc. 37, C.A.B.A", "0353 453-9100");

INSERT INTO Proveedores_Editoriales VALUES
(10, 1),
(10, 2),
(11, 3);

INSERT INTO Solicitudes_Compras VALUES
(100001, 11, 'Aceptado', 20191112),
(100002, 10, 'Aceptado', 20191112);
INSERT INTO Solicitudes_Compras_Det VALUES
(100001, 100001, 9788499089522, 5),
(100002, 100002, 9788484505969, 5),
(100003, 100002, 9788467016901, 5);
INSERT INTO Nota_Pedidos VALUES
(100001, 20191112, 100001, 'Recibido'),
(100002, 20191112, 100002, 'Recibido');
INSERT INTO Comprobantes_Entradas VALUES
(100001, 100001, 1453323, 1),
(100002, 100001, 1453328, 1),
(100003, 100002, 1234556, 0);
INSERT INTO Comprobantes_Entradas_Det VALUES
(100001, 100001, 9788499089522, 3, 450),
(100002, 100002, 9788499089522, 2, 450),
(100003, 100003, 9788484505969, 5, 500),
(100004, 100003, 9788467016901, 5, 400);

INSERT INTO Cheques VALUES
(100000, 1350, 11, 20191112, NULL, 1453323),
(100001, 900, 11, 20191112, NULL, 1453328);

INSERT INTO Balances_Diarios VALUES
(1, 20191027, 100000, 1),
('', 20191028, 100000, 1),
('', 20191029, 100000, 1),
('', 20191030, 100000, 1),
('', 20191031, 100000, 1),
('', 20191101, 110400, 1),
('', 20191102, 110400, 1),
('', 20191103, 110400, 1),
('', 20191104, 110400, 1),
('', 20191105, 110400, 1),
('', 20191106, 110400, 1),
('', 20191107, 110400, 1),
('', 20191108, 110400, 1),
('', 20191109, 110400, 1),
('', 20191110, 110400, 1);

INSERT INTO Balances_Mensuales VALUES
(1, 20191031, 100000, 1);

INSERT INTO Eventos VALUES
(100, "Don Quijote", "Evento en el que se mostrará y leera secciones del libro original del Quijote, ademas de su puesta a la venta.", 20191111, "Promocion del Nuevo Libro");
INSERT INTO AsisEvento VALUES
(100, 1000),
(100, 1001);



INSERT INTO Calendario VALUES
(1, "Mensualmente", 20191101),
('', "Semanalmente", 20191104),
('', "Diariamente", 20191101),
('', "Cada 3 Dias", 20191101),
('', "Cada Hora", 20191101200000);

INSERT INTO Notificaciones VALUES
(100000, NULL, NULL, NULL, NULL, 1),
('', 20191104, "Sistema", "Revision Diaria Realizada", "root", 0),
('', 20191104, "Sistema", "Revision Diaria Realizada", "libros", 0),
('', 20191104, "Sistema", "Revision Diaria Realizada", "administracion", 0),
('', 20191104, "Sistema", "Revision Diaria Realizada", "envios", 0),
('', 20191104, "Sistema", "Revision Diaria Realizada", "atencion", 0);

//

CREATE PROCEDURE AltaCompra(CodigoSocio INT, TipoPago VARCHAR(15), CantPago INT , CodCorredor INT, MontoCuota FLOAT)
BEGIN 
	DECLARE CodCompra_ INT;
	DECLARE I INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra)+1 FROM Compras );
	IF TipoPago = "Contado" THEN
		SET CantPago = NULL;
	END IF;
	INSERT INTO Compras VALUES
	(CodCompra_, CodigoSocio, CURDATE(), (SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)), TipoPago, CantPago, "impago", CoDCorredor);
	IF TipoPago = "Financiado" THEN
		SET I = 1;
		WHILE I <= CantPago DO
			INSERT INTO Cuotas VALUES
			(CodCompra_, I, (SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)), MontoCuota, NULL, 0);
		SET I = I + 1;
		END WHILE;
	END IF;
END//
CREATE PROCEDURE AltaCompraNuevo(CodigoSocio INT, TipoPago VARCHAR(15), CantPago INT , CodCorredor INT, MontoCuota FLOAT)
BEGIN 
	DECLARE CodCompra_ INT;
	DECLARE I INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra)+1 FROM Compras );
	IF TipoPago = "Contado" THEN
		SET CantPago = NULL;
	END IF;
	INSERT INTO Socios VALUES
	(CodigoSocio, (SELECT DNI FROM nuevos), (SELECT Nombre FROM Nuevos), (SELECT Apellido FROM Nuevos), (SELECT Direccion FROM Nuevos), (SELECT Localidad FROM nuevos), (SELECT Tel From Nuevos), "Al dia", CURDATE());
	DELETE FROM Nuevos;
	INSERT INTO Compras VALUES
	(CodCompra_, CodigoSocio, CURDATE(), (SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)), TipoPago, CantPago, "Impago", CoDCorredor);
	IF TipoPago = "Financiado" THEN
		SET I = 1;
		WHILE I <= CantPago DO
			INSERT INTO Cuotas VALUES
			(CodCompra_, I, (SELECT DATE_ADD(CURDATE(), INTERVAL 1 WEEK)), MontoCuota, NULL, 0);
			SET I = I + 1;
		END WHILE;
	END IF;
END//
CREATE PROCEDURE AltaCompras(CodigoLibro INT, CodigoSocio INT, CantEjemplares INT, PrecioInd FLOAT)
BEGIN
	DECLARE It INT;
	DECLARE idEjem_ INT;
	DECLARE CodCompra_ INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra) FROM Compras );
	SET It = 1;
	WHILE It <= CantEjemplares DO
		SET idEjem_ = (SELECT idEjem FROM Ejemplares WHERE Vendido = 0 AND Alquiler = 0 AND Deteriorado = 0
		AND CodLibro = CodigoLibro LIMIT 1);
		INSERT INTO DetalleCompra VALUES
		(CodCompra_, idEjem_, PrecioInd);
		UPDATE Ejemplares SET vendido = true WHERE idEjem = idEjem_;
		SET It = It + 1;
	END WHILE;
END//



CREATE PROCEDURE AltaAlquiler(CodigoSocio INT, FechaTOP DATE, CodCorredor INT)
BEGIN
	DECLARE CodALQ_ INT;
	SET CodALQ_ = ( SELECT MAX(CodAlquiler)+1 FROM Alquileres );
	INSERT INTO Alquileres VALUES
	(CodALQ_, CodigoSocio, CURDATE(), NULL, FechaTOP, date_add(curdate(), interval 1 month), "Impago", CodCorredor );
END//
CREATE PROCEDURE AltaAlquilerNuevo(CodigoSocio INT, FechaTOP DATE, CodCorredor INT)
BEGIN
	DECLARE CodALQ_ INT;
	SET CodALQ_ = ( SELECT MAX(CodAlquiler)+1 FROM Alquileres );
	INSERT INTO Socios VALUES
	(CodigoSocio, (SELECT DNI FROM nuevos), (SELECT Nombre FROM Nuevos), (SELECT Apellido FROM Nuevos), (SELECT Direccion FROM Nuevos), (SELECT Localidad FROM nuevos), (SELECT Tel From Nuevos), "Al dia", CURDATE());
	DELETE FROM Nuevos;
	INSERT INTO Alquileres VALUES
	(CodALQ_, CodigoSocio, CURDATE(), NULL, FechaTOP, date_add(CURDATE(), interval 1 month), "Impago", CoDCorredor );
END//
CREATE PROCEDURE AltaAlquilerD(CodigoLibro INT, CodigoSocio INT, CantEjemplares INT, PrecioInd FLOAT)
BEGIN 
	DECLARE It INT;
	DECLARE idEjem_ INT;
	DECLARE CodALQ_ INT;
	SET CodALQ_ = ( SELECT MAX(CodAlquiler) FROM Alquileres );
	SET It = 1;
	WHILE It <= CantEjemplares DO
		SET idEjem_ = (SELECT idEjem FROM Ejemplares WHERE Prestado = 0 AND Alquiler = 1 AND Deteriorado = 0
		AND CodLibro = CodigoLibro LIMIT 1);
		INSERT INTO DetalleAlq VALUES
		(CodALQ_, idEjem_, PrecioInd);
		UPDATE Ejemplares SET Prestado = true WHERE idEjem = idEjem_;
		SET It = It + 1;
	END WHILE;
END//



CREATE PROCEDURE CompEntradaDetLibros(ISBN VARCHAR(15), Cantidad INT, PrecioUni INT)
BEGIN
	DECLARE CompEntrada INT;

	SET CompEntrada = (SELECT Max(IDCompEntrada) FROM Comprobantes_Entradas);
	INSERT INTO Comprobantes_Entradas_Det VALUES
	('', CompEntrada, ISBN, Cantidad, PrecioUni);
END//
CREATE PROCEDURE AgreLibroNuevo(Nombre varchar(90), ISBN varchar(15), Editorial varchar(20), PV FLOAT, PA FLOAT, FPubli VARCHAR(10), CodA VARCHAR(60), PPA INT, PPV INT )
begin
	declare CodL int;
	insert into Libros values ('', Nombre, ISBN, Editorial, FPubli, PV, PA, PPV, PPA);
	set CodL = (SELECT MAX(CodLibro) FROM Libros);
	insert into Libroautor values (CodL, CodA);
end//
CREATE PROCEDURE AgreEje(LiISBN varchar(15), cantidadV int, cantidadA int)
begin
	declare CodL int;
	declare conta int;
	set conta = 0;
	set CodL = (SELECT CodLibro FROM Libros WHERE ISBN = LiISBN);
	IF cantidadV > 0 THEN
		REPEAT
		insert into Ejemplares values ('', CodL, false, false, false, false);
		set conta = conta + 1;
		UNTIL conta = cantidadV
		END REPEAT;
	END IF;
	set conta = 0;
	IF CantidadA > 0 THEN
		REPEAT
		insert into Ejemplares values ('', CodL, false, false, false, true);
		set conta = conta + 1;
		UNTIL conta = cantidadA
		END REPEAT;
	END IF;
end//
CREATE PROCEDURE InteresesProce(Dias INT, OUT DiasSalida INT)
BEGIN
	DECLARE EOF BOOLEAN DEFAULT FALSE;
	DECLARE DIAS_ INT;
	DECLARE Porcentaje_ INT;
	DECLARE I INT;

	DECLARE cursorinteres CURSOR FOR (SELECT DiasAtrasados, Porcentaje FROM intereses);
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET EOF = TRUE;

	OPEN cursorinteres;
	FETCH cursorinteres INTO DIAS_, Porcentaje_;
	SET I = 0;
	WHILE EOF = FALSE AND DIAS_ <= Dias DO
		IF I = Dias THEN
			SET DiasSalida = DIAS_;
			FETCH cursorinteres INTO DIAS_, Porcentaje_;
		ELSE
			SET I = I + 1;
		END IF;
	END WHILE;
	CLOSE cursorinteres;
END//
CREATE PROCEDURE HojaDeRuta(in remito int, in Cantl int)
BEGIN
	DECLARE H INT;
	DECLARE c INT;
	set H = (SELECT COUNT(*) FROM Hojas_de_ruta where Fecha = curdate());
	if H = 0 then
		insert into Hojas_de_ruta values ('', curdate(), 'Pendiente');
	end if;
	set c = (SELECT NHojaRuta FROM Hojas_de_ruta where Fecha = curdate());
	insert into Hojas_de_ruta_det values (c, remito, Cantl);
END//
CREATE PROCEDURE VerPuntosPedido( OUT Salida INT )
BEGIN
	DECLARE EOF BOOLEAN DEFAULT FALSE;
	DECLARE FLAG BOOLEAN DEFAULT FALSE;
	DECLARE CodLibro_ INT;
	DECLARE PP_ INT;
	DECLARE PPA_ Int;
	DECLARE EV INT;
	DECLARE EA INT;

	DECLARE cursorPuntoPedido CURSOR FOR(SELECT CodLibro, PuntoPedido, PuntoPedidoAlquiler From Libros);
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET EOF = TRUE;

	OPEN cursorPuntoPedido;
	FETCH cursorPuntoPedido INTO CodLibro_, PP_, PPA_;

	WHILE EOF = FALSE DO
		SET EV = (SELECT COUNT(*) FROM Ejemplares 
			WHERE alquiler = 0 and prestado = 0 and vendido = 0 and deteriorado = 0 
			AND CodLibro = CodLibro_);
		SET EA = (SELECT COUNT(*) FROM Ejemplares 
			WHERE alquiler = 1 and prestado = 0 and vendido = 0 and deteriorado = 0 
			AND CodLibro = CodLibro_);
		IF EV < PP_ THEN
			SET Flag = TRUE;
		END IF;
		IF EA < PPA_ THEN
			SET Flag = TRUE;
		END IF;
		FETCH cursorPuntoPedido INTO CodLibro_, PP_, PPA_;
	END WHILE;
	IF FLAG = TRUE THEN
		SET Salida = 1;
	ELSE
		SET Salida = 0;
	END IF;
END//

delimiter ;

USE BARC;

/*
IMPRIMIR REMITO
 Envios acepta el envio se da al flete, y vuelvne los remitos firmados que fueron
 entregados, los cargamos como entregados, cuando todos los remitos de la hoja de ruta
 estan entregados se pone la hoja como entregadas
*/
