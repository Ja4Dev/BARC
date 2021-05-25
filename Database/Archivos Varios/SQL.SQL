


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

CALL AltaCompras(20003, 1000, 1, 950, 950)//




idcompra, fecha, monto total, estado
SELECT CodCompra, FechaCompra, Monto_Total, Estado FROM Compra WHERE CodSocio = CodSocio_

idalquiler, fecha inicio, fecha tope, fecha devolucion, estado
SELECT CodAlquiler, Fecha_Inicio, Fecha_Tope, Fecha_Devolucion, estado FROM Alquiler WHERE Codsocio = 


        ElseIf TipoDoc = "FacturaImpaga" Then

            Dim invoice As New FEncabezado()

            invoice.CopiaDocumento = "Original"
            invoice.TipoDocumento = "Factura"
            invoice.IdenDocumento = "C"

            invoice.CodFactura = ComprasSocio.lstOperacion.FocusedItem.Text
            invoice.SubtotalFactura = total

            invoice.FechaFacturacion = ComprasSocio.lstOperacion.FocusedItem.SubItems(1).Text
            invoice.HastaFecha = ComprasSocio.lstOperacion.FocusedItem.SubItems(1).Text
            invoice.VenceFecha = fechatope

            Consulta("select dni, apellido, nombre, direccion, localidad from socios where codsocio = " & codsoc & "")
            rd.Read()

            invoice.DNISocio = rd(0)
            invoice.ApeNombre = rd(1) & " " & rd(2)
            invoice.CondicionIVA = "Consumidor Final"
            invoice.DomicilioSocio = rd(3) & " " & rd(4)
            invoice.condVenta = ComprasSocio.lstOperacion.FocusedItem.SubItems(3).Text

            For Each item In ComprasSocio.lstDetalleCompra.Items
                Dim article As New FArticulo()

                Consulta("select codlibro from libros where Titulo = '" & ComprasSocio.lstDetalleCompra.Items(i).Text & "'")
                rd.Read()

                article.CodLibro = Convert.ToInt32(rd(0))
                article.TituloLibro = ComprasSocio.lstDetalleCompra.Items(i).Text
                article.CantidadLibro = Convert.ToInt32(ComprasSocio.lstDetalleCompra.Items(i).SubItems(3).Text)
                article.PrecioUnitario = Convert.ToDecimal(ComprasSocio.lstDetalleCompra.Items(i).SubItems(4).Text)
                article.SubtotalArticulo = Convert.ToDecimal(Val(ComprasSocio.lstDetalleCompra.Items(i).SubItems(3).Text) * Val(ComprasSocio.lstDetalleCompra.Items(i).SubItems(4).Text))

                invoice.Detail.Add(article)

                i = i + 1
            Next

            Dim frm As New facremPreview()

            frm.Invoice.Add(invoice)

            frm.Detail = invoice.Detail
            frm.ShowDialog()




DROP PROCEDURE IF EXISTS AltaCompraNuevo//
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
	(CodCompra_, CodigoSocio, CURDATE(), (SELECT DATE_ADD(CURDATE(), INTERVAL 14 DAY)), TipoPago, CantPago, "Adeuda", CoDCorredor);
	INSERT INTO Envios VALUES
	('', NULL, CodCompra_, 'Pendiente');
	IF TipoPago = "Financiado" THEN
		SET I = 1;
		WHILE I <= CantPago DO
			INSERT INTO Cuotas VALUES
			(CodCompra_, I, (SELECT DATE_ADD(CURDATE(), INTERVAL 14 DAY)), MontoCuota, NULL, 0);
		END WHILE;
		SET I = I + 1;
	END IF;
END//


SELECT DATE_ADD(CURDATE(), INTERVAL 14 DAY)

DROP PROCEDURE IF EXISTS AltaCompra//
CREATE PROCEDURE AltaCompra(CodigoSocio INT, TipoPago VARCHAR(15), CantPago INT , CodCorredor INT, MontoCuota FLOAT)
BEGIN 
	DECLARE CodCompra_ INT;
	DECLARE I INT;
	SET CodCompra_ = ( SELECT MAX(CodCompra)+1 FROM Compras );
	IF TipoPago = "Contado" THEN
		SET CantPago = NULL;
	END IF;
	INSERT INTO Compras VALUES
	(CodCompra_, CodigoSocio, CURDATE(), (SELECT DATE_ADD(CURDATE(), INTERVAL 14 DAY)), TipoPago, CantPago, "Adeuda", CoDCorredor);
	INSERT INTO Envios VALUES
	('', NULL, CodCompra_, 'Pendiente');
	IF TipoPago = "Financiado" THEN
		SET I = 1;
		WHILE I <= CantPago DO
			INSERT INTO Cuotas VALUES
			(CodCompra_, I, (SELECT DATE_ADD(CURDATE(), INTERVAL 14 DAY)), MontoCuota, NULL, 0);
		END WHILE;
		SET I = I + 1;
	END IF;
END//

DROP PROCEDURE IF EXISTS AltaAlquilerNuevo//
CREATE PROCEDURE AltaAlquilerNuevo(CodigoSocio INT, FechaTOP DATE, CodCorredor INT)
BEGIN
	DECLARE CodALQ_ INT;
	SET CodALQ_ = ( SELECT MAX(CodAlquiler)+1 FROM Alquileres );
	INSERT INTO Socios VALUES
	(CodigoSocio, (SELECT DNI FROM nuevos), (SELECT Nombre FROM Nuevos), (SELECT Apellido FROM Nuevos), (SELECT Direccion FROM Nuevos), (SELECT Localidad FROM nuevos), (SELECT Tel From Nuevos), "Al dia", CURDATE());
	DELETE FROM Nuevos;
	INSERT INTO Alquileres VALUES
	(CodALQ_, CodigoSocio, CURDATE(), NULL, FechaTOP, "Adeuda", CoDCorredor );
	INSERT INTO Envios VALUES 
	('', CodALQ_, NULL, 'Pendiente');
END//


DROP PROCEDURE IF EXISTS AltaAlquiler//
CREATE PROCEDURE AltaAlquiler(CodigoSocio INT, FechaTOP DATE, CodCorredor INT)
BEGIN
	DECLARE CodALQ_ INT;
	SET CodALQ_ = ( SELECT MAX(CodAlquiler)+1 FROM Alquileres );
	INSERT INTO Alquileres VALUES
	(CodALQ_, CodigoSocio, CURDATE(), NULL, FechaTOP, "Adeuda", CoDCorredor );
END//

DROP PROCEDURE IF EXISTS AltaAlquilerD//
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

AltaCompraNuevo(CodigoSocio INT, TipoPago VARCHAR(15), CantPago INT , CodCorredor INT, MontoCuota FLOAT)

CALL AltaCompraNuevo(1004, 'Contado', 0, 100000, 0); //
CALL AltaCompras(20001, 1003, 1, 20000); //

CALL AltaAlquilerNuevo(1005, 20191115, 100000); //
CALL AltaAlquilerD(20001, 1003, 1, 13000); //




INSERT INTO Recibos VALUES ('', CURDATE()," & codsoc & ", " & total & ", " & codcompra & ", " & codcompra & ", " & corredor & ", NULL)



CALL InteresesProce(62, @Dias)//

SELECT @Dias//

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
1820
489

UPDATE Calendario SET Fecha = CURDATE() WHERE IdCalendario = 1
UPDATE Calendario SET Fecha = CURDATE() WHERE IdCalendario = 2
UPDATE Calendario SET Fecha = CURDATE() WHERE IdCalendario = 3


SELECT DISTINCT CodSocio FROM Compras WHERE FTopePago < CURDATE() AND NOT Estado = "Pagado"

SELECT DISTINCT CodSocio FROM Alquileres WHERE Fecha_VencimientoPago < CURDATE() AND NOT EstadoPago = "Pagado"


select count(*) FROM notificaciones WHERE Tipo = 'Administracion' AND Detalle = 'Hay Solicitudes de Compra Pendientes' AND Usuario = 'Administracion' AND Fecha = CURDATE();

"select l.CodLibro, titulo, nombre, apellido, isbn, NombreEditorial, f_publicacion, PrecioVenta, PrecioAlquiler from Libros l, autores a, libroautor la, ejemplares e, editoriales ed where la.codlibro = l.codlibro and la.codautor = a.codautor and e.codlibro = l.codlibro and l.Editorial = ed.CodEditorial group by (e.codlibro)"


SELECT Libro, Cantidad FROM Solicitudes_Compras sc, Solicitudes_Compras_Det scd, Nota_Pedidos np
WHERE NNotaPedido = " & Trim() & " AND np.NSoli = sc.NSoli AND sc.NSoli = scd.NSoli

ingrese cod factura proveedor

DROP PROCEDURE IF EXISTS CompEntradaDetLibros//
CREATE PROCEDURE CompEntradaDetLibros(ISBN VARCHAR(15), Cantidad INT, PrecioUni INT)
BEGIN
	DECLARE CompEntrada INT;

	SET CompEntrada = (SELECT Max(IDCompEntrada) FROM Comprobantes_Entradas);
	INSERT INTO Comprobantes_Entradas_Det VALUES
	('', CompEntrada, ISBN, Cantidad, PrecioUni);
END//

agregar editorial, autor y procedure

DROP PROCEDURE IF EXISTS AgreLibroNuevo//
CREATE PROCEDURE AgreLibroNuevo(Nombre varchar(90), ISBN varchar(15), Editorial INT, PV FLOAT, PA FLOAT, FPubli VARCHAR(10), CodA VARCHAR(60), PPA INT, PPV INT )
begin
	declare CodL int;
	insert into Libros values ('', Nombre, ISBN, Editorial, FPubli, PV, PA, PPV, PPA);
	set CodL = (SELECT MAX(CodLibro) FROM Libros);
	insert into Libroautor values (CodL, CodA);
end//

SELECT Libro, Cantidad, sc.Proveedor 
FROM Solicitudes_Compras sc, Solicitudes_Compras_Det scd, Nota_Pedidos np 
WHERE np.NSoli = sc.NSoli AND sc.NSoli = scd.NSoli 
AND NOT np.Estado = 'Recibido'


SELECT DISTINCT ced.Libro, ced.Cantidad FROM Solicitudes_Compras_Det scd, Solicitudes_Compras sc, 
Nota_Pedidos np,Comprobantes_Entradas ce, Comprobantes_Entradas_Det ced 
WHERE scd.NSoli = sc.NSoli AND sc.NSoli = np.NSoli AND np.NNotaPedido = ce.IdNotaPedido
AND ce.IDCompEntrada = ced.IDCompEntrada AND np.NNotaPEdido = 100001

SELECT DISTINCT scd.Libro, scd.Cantidad FROM Solicitudes_Compras_Det scd, Solicitudes_Compras sc, 
Nota_Pedidos np
WHERE scd.NSoli = sc.NSoli AND sc.NSoli = np.NSoli AND np.NNotaPEdido = 100001

DROP PROCEDURE IF EXISTS VerPuntosPedido//
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

DROP PROCEDURE IF EXISTS InteresesProce//



SELECT NRemito, CantiLib FROM Hojas_de_Ruta

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

create table Hojas_de_Ruta( -- cuando haces envios, haces la hora de ruta
NHojaRuta int primary key auto_increment,
Fecha date,
Estado varchar(15) -- pendiente, enviado, entregado
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

create table Envios( -- opcion de realizar envio si quiere cargas el envio aca, luego en la pantalla de envios los visualizas
CodEnvio int primary key auto_increment,
CodAlquiler int,
CodCompra int,
Estado_Envio varchar(20) -- pendiente, enviado, entregado
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

SELECT SUM(Monto_Individual) FROM DetalleCompra WHERE CodCompra = 300000

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
create table Detalle_Factura(
CodFactura int,
CodLibro int,
Cantidad int,
primary key(CodFactura, CodLibro),
foreign key (CodFactura) references Facturas(CodFactura),
foreign key (CodLibro) references Libros(CodLibro)
);


SELECT NNotaPedido, np.Fecha, np.Nsoli, np.Estado, p.Proveedor FROM Proveedores P, 
Nota_Pedidos np, Solicitudes_Compras sc 
WHERE p.CodProveedor = sc.Proveedor AND np.NSoli = sc.NSoli AND NNotaPedido > 100000


('', CURDATE(), " & codsoc & ", " & lstCuotas.FocusedItem.SubItems(2).Text & ", " & CodCompra & ", NULL, " & Corredor & ", " & Interes & ", 'Pago de Cuota Numero ' " & lstCuota.FocusedItem.Text & ")

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


DROP PROCEDURE IF EXISTS BajaInactivos//
CREATE PROCEDURE BajaInactivos()
BEGIN
	DECLARE EOF BOOLEAN DEFAULT FALSE;
	DECLARE CODSOC_ INT;
	DECLARE CODSOCAUX INT;
	DECLARE FECHA DATE;
	DECLARE FechaMax DATE;
	DECLARE I INT DEFAULT 0;

	DECLARE ComprasInactivos CURSOR FOR ();
	DECLARE CONTINUE HANDLER FOR NOT FOUND SET EOF = TRUE;

	OPEN ComprasInactivos;
	FETCH ComprasInactivos INTO CODSOC_, FECHA;

	WHILE EOF = FALSE DO
		SET CODSOCAUX = CODSOC_
		WHILE EOF = FALSE AND CODSOCAUX = CODSOC_ DO
			IF I = 0 OR FechaMax < FECHA THEN
				SET I = 1;
				SET FechaMax = FECHA;
				FETCH ComprasInactivos INTO CODSOC_, FECHA;
			END IF;
		END WHILE;
		IF (SELECT DATEDIFF(CURDATE(), FechaMax) > 60) THEN
			INSERT INTO Inactivos_Temp VALUES
			(CODSOCAUX, FechaMax);
		END IF;
	END WHILE;
	CLOSE ComprasInactivos;
END//

SELECT CodSocio, FechaCompra FROM Compras UNION SELECT CodSocio, Fecha_Inicio FROM Alquileres ORDER BY CodSocio


codcompra
SELECT CodEnvio FROM Envios e, Hojas_de_Ruta_Det hr, Remitos r
WHERE

CodAlquiler

SELECT CodEnvio FROM

DROP procedure IF EXISTS ActualizarEnvios//
CREATE procedure ActualizarEnvios(HojaRuta int)
BEGIN
	DECLARE EOF BOOLEAN DEFAULT FALSE;
	DECLARE CodAlq INT;
	DECLARE CodComp INT;

	DECLARE EnviosCursor CURSOR FOR (SELECT r.CodAlquiler, r.CodCompra FROM Remitos r, Hojas_de_Ruta_Det hr 
		WHERE hr.NRemito = r.NRemito AND NHojaRuta = HojaRuta);
	DECLARE CONTINUE HANDLER FOR NOR FOUND SET EOF = TRUE;


	OPEN EnviosCursor;
	FETCH EnviosCursor INTO CodAlq, CodComp;
	WHILE EOF = FALSE DO
		IF CodComp THEN
			UPDATE Envios SET Estado_Envio = 'Entregado' WHERE CodCompra = CodComp;
		ELSE
			UPDATE Envios SET Estado_Envio = 'Entregado' WHERE CodAlquiler = CodAlq;
		END IF;
	END WHILE;
	END IF;
END//


SELECT CodSocio, Max(FechaCompra) FROM Compras group by Codsocio
UNION SELECT CodSocio, Max(Fecha_Inicio) FROM Alquileres Group By Codsocio ORDER BY CodSocio

SELECT c.CodSocio, GREATEST(Max(FechaCompra), Max(Fecha_Inicio)) FROM Compras c, alquileres a GROUP BY Codsocio


create table Cheques( -- pago al proveedor, sirve de comprobante que pagamos
NCheque int primary key auto_increment,
Monto float,
Proveedor int,
FechaEmision date,
FechaVence date,
NFacturaProveedor int
);

SELECT p.Proveedor FROM Proveedores P, 
Nota_Pedidos np, Solicitudes_Compras sc 
WHERE p.CodProveedor = sc.Proveedor AND np.NSoli = sc.NSoli AND NNotaPedido =


SELECT DISTINCT CodLibro From Ejemplares e, DetalleCompra dc WHERE e.idejem = dc.idejem and dc.codcompra = 300000

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

create table Balances_Diarios( -- al final del dia se calcula en base a los recibos y pago de proveedor
FechaBalance date primary key,
Balance float,
A_Favor boolean
);

codlibro, titulo, cantidad, precio, subtotal from CodCompra


SELECT l.CodLibro, l.titulo, COUNT(*), l.PrecioVenta FROM libros l, ejemplares e, DetalleCompra dc
WHERE l.CodLibro = e.CodLibro AND e.idEjem = dc.idEjem AND dc.CodCompra = 300008 group by l.CodLibro

select l.Titulo, a.Nombre, a.Apellido, l.Editorial, count(*), dc.Monto_Individual from libros l, autores a, libroautor la, ejemplares e, detallecompra dc, compras c where l.codlibro = la.codlibro and la.codautor = a.codautor and l.codlibro = e.codlibro and e.idejem = dc.idejem and dc.codcompra = c.codcompra and c.codcompra =  group by l.titulo


=First(Fields!FechaTopeAlq.Value, "Encabezado")

select * from balances_diarios WHERE FechaBalance = (SELECT MAX(FechaBalance) FROM Balances_Diarios);


SELECT * FROM Zonas WHERE CodZona NOT IN (SELECT CodZona FROM Corredores_Zonas WHERE CodCorredor = 5000)


SELECT CodCompra, CodAlquiler
FROM Compras c, alquileres a
WHERE FechaCompra > (SELECT DATE_SUB(CURDATE(), INTERVAL 1 WEEK)) OR
Fecha_Inicio > (SELECT DATE_SUB(CURDATE(), INTERVAL 1 WEEK))


SELECT CodCompra
FROM Compras 
WHERE Estado = 'Impago'
GROUP BY Codsocio 
UNION
SELECT CodAlquiler
FROM Alquileres 
WHERE EstadoPago = 'Impago'
GROUP BY CodSocio

INSERT INTO Recorridos VALUES
('', 20191111, 5001);

INSERT INTO Recorridos_Soc VALUES
(2, 1000);

SELECT COUNT(*) FROM Recorridos r, Recorridos_Soc rs WHERE r.Corredor = 5000 AND rs.Socio = 1000 AND
r.NRecorrido = rs.NRecorrido
AND r.Fecha > (SELECT DATE_SUB(CURDATE(), INTERVAL 1 WEEK)) 

SELECT COUNT(*) FROM recorridos WHERE fecha = curdate() AND corredor = 5000

SELECT NRecorrido, r.Fecha, r.Corredor, c.Nombre, c.Apellido FROM Recorridos r, Corredores c
WHERE r.Corredor = c.CodCorredor ORDER BY r.Fecha DESC

SELECT r.Socio, Nombre, Apellido, Direccion FROM Recorridos_Soc r, Socios s
WHERE r.Socio = s.CodSocio AND NRecorrido = 2


Editoriales > ABM
Autores > ABM
Libros > BM
Compras > B (inmodulo)
Alquileres > B (inmodulo)
Eventos > BM (inmodulo)
Zonas > ABM
Corredores > ABM
Usuarios > M 
Intereses > M
Proveedores > ABM
Proveedores Editoriales > ABM