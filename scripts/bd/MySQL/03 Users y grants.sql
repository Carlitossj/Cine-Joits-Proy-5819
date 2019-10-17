#Punto 1
create user 'administradores'@'localhost'IDENTIFIED BY 'passadministrador';
GRANT insert,select ON Pelicula TO 'Bibliotecario'@'localhost';
GRANT insert,select ON Proyeccion TO 'Bibliotecario'@'localhost';
GRANT insert,select ON Genero TO 'Bibliotecario'@'localhost';
GRANT insert,select ON Sala TO 'Bibliotecario'@'localhost';

#Punto2
create user 'cajeros'@'10.120.0.%' identified by 'passcajeros';
grant select on Pelicula to 'cajeros'@'10.120.0.%';
grant select on Proyeccion to 'cajeros'@'10.120.0.%';
grant select on Genero to 'cajeros'@'10.120.0.%';
grant select on Sala to 'cajeros'@'10.120.0.%';
grant select on Entrada to 'cajeros'@'10.120.0.%';
grant insert on Entrada to 'cajeros'@'10.120.0.%';

#Punto3


