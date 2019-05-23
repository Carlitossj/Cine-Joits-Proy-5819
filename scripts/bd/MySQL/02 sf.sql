delimiter $$
create function entradasVendidasEntre (unidPelicula smallint,
                                       unacotaInferior datetime,
                                       unacotaSuperior datetime)
                                       returns int
 begin
 declare EntradaVendidas int;
 select sum (idEntrada) into EntradaVendidas
 from Entrada
 where fecha_y_hora between cotaInferior and cotaSuperior;
 return EntradaVendidas;
 end$$
                                        