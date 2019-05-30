delimiter $$
create function entradasVendidasEntre (unidPelicula smallint,
                                       unacotaInferior datetime,
                                       unacotaSuperior datetime)
                                       returns int
 begin
 declare EntradaVendidas int;
 select COUNT(idEntrada) into EntradaVendidas
 from Entrada
 where fecha_y_hora between cotaInferior and cotaSuperior;
 return EntradaVendidas;
 end$$
 
 create function  EntradasDisponibles (unidProyeccion smallint)
                                       returns int
begin
 declare entradasDisp int;
 select  capacidad - idEntradas into  entradasDisp   
 from Proyeccion
 where idProyeccion = unidProyeccion;
 return entradasDisp;
 
end$$