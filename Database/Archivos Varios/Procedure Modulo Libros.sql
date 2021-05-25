TAREAS PARA LA BASE DE DATOS:

1. Crear Procedure para agregar ejemplares de libros con parametros de entrada, (Nombre, ISBN, Editorial, DATEPublicacion, Nombre Autor, Apellido Autor, cantidad de ejemplares).
si no existe el autor crearlo, agregar el libro si no existe, una vez agregado el libro agregar los ejemplares.

CREATE PROCEDURE AgreLibro(Nombre varchar(90), ISBN varchar(15), Editorial varchar(20), FPubli date, NoAutor varchar(60), ApAutor varchar(60), Cantidad int)
begin
declare CodL int;
declare CodA int;
insert into Autor values ('', NoAutor, ApAutor);
insert into Libro values ('', Nombre, ISBN, Editorial, FPubli);
set CodL = (SELECT MAX(CodLibro) FROM Libro);
set CodA = (SELECT MAX(CodAutor) FROM Autor);
insert into Libroautor values (CodL, CodA);
end//

CREATE PROCEDURE AgreEje(LiISBN varchar(15), cantidad int)
begin
declare CodL int;
declare conta int;
set CodL = (SELECT CodLibro FROM Libro WHERE ISBN = LiISBN);
REPEAT
insert into Ejemplar values ('', CodL, false, false)
UNTIL conta = cantidad
END REPEAT;
end//

Se ingresa el ISBN y Visual verifica que exista el libro.

Consulta("SELECT COUNT(*) FROM Libro WHERE ISBN = " & ISBN)

Si da 0 se le hacen completar al usuario los datos (Nombre, ISBN, Editorial, DATEPublicacion, Nombre Autor, Apellido Autor, cantidad)
y se llama al procedure AgreLibro, posteriormente al AgreEje.

Consulta("CALL AgreLibro('" & Nombre & "', '" & ISBN & ", '" & Editorial & "', '" & FPubli & "', '" & NombreAutor & "', '" & ApellidoAutor & "')")
Consulta("CALL AgreEje('" & ISBN & "', " & Cantidad & ")")

Si da mas de 0 se le pide solo la cantidad.

Consulta("CALL AgreEje('" & ISBN & "', " & Cantidad & ")")