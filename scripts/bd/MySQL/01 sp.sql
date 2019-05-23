delimiter $$
create procedure altaProyeccion (unidProteccion smallint,
                                 unafecha_y_hora datetime,
                                 unidPelicula smallint,
                                 unidSala smallint)
	
begin 
     insert into Proyeccion (idProyeccion,idfecha_y_hora,idPelicula,idSala)
             value(unidProyeccion,unafecha_y_fecha,unidPelicula,unidSala);
             end $$

create procedure altaPelicula (unidPelicula smallint,
                               unnombre varchar(50),
                               unafecha_lanzamiento date,
                               unidGenero smallint)
 begin 
       insert into Pelicula (idPelicula,nombre,fecha_lanzamiento,idGenero)
               value(unaidPelicula,unnombre,unafecha_lanzamiento,unidGenero);
               end$$
               
create procedure altaGenero (unidGenero smallint,
                              ungenero varchar(30))
					
begin
     insert into Genero (idGenero,genero)
             value(unidGenero,ungenero);
             end$$
             
create procedure altaSala (unidSala tinyint,
						unpiso tinyint,
                        unacapacidad smallint)
   
 begin 
     insert into Sala (idSala,piso,capacidad)
            value(unidSala,unpiso,unacapacidad);
            end$$
 
             
             