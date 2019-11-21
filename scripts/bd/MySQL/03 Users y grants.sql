#Punto 1
create user 'administradores'@'localhost'IDENTIFIED BY 'passadministrador';
GRANT insert,select ON Pelicula TO 'administradores'@'localhost';
GRANT insert,select ON Proyeccion TO 'administradores'@'localhost';
GRANT insert,select ON Genero TO 'administradores'@'localhost';
GRANT insert,select ON Sala TO 'administradores'@'localhost';
GRANT insert,select ON Cajero TO 'administradores'@'localhost';

#Punto2
create user 'cajeros'@'10.120.0.%' identified by 'passcajeros';
grant select on Cajero to 'cajeros'@'10.120.0.%';
grant select on Pelicula to 'cajeros'@'10.120.0.%';
grant select on Proyeccion to 'cajeros'@'10.120.0.%';
grant select on Genero to 'cajeros'@'10.120.0.%';
grant select on Sala to 'cajeros'@'10.120.0.%';
grant select on Entrada to 'cajeros'@'10.120.0.%';
grant insert on Entrada to 'cajeros'@'10.120.0.%';
#CajerosLocales
create user 'cajeros'@'localhost' identified by 'passcajeros';
grant select on Cajero to 'cajeros'@'localhost';
grant select on Pelicula to 'cajeros'@'localhost';
grant select on Proyeccion to 'cajeros'@'localhost';
grant select on Genero to 'cajeros'@'localhost';
grant select on Sala to 'cajeros'@'localhost';
grant select on Entrada to 'cajeros'@'localhost';
grant insert on Entrada to 'cajeros'@'10.120.0.%';



