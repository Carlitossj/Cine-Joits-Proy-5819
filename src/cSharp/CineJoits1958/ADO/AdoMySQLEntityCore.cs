using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CineJoits1958.ADO
{
    class AdoMySQLEntityCore : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Proyeccion> Proyecciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL("server=localhost;database=supermercado;user=supermercado;password=supermercado");
        }
        public void agregarPelicula(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
            SaveChanges();
        }
        public void agregarGenero(Genero genero)
        {
            Generos.Add(genero);
            SaveChanges();
        }
        public void agregarProyeccion(Proyeccion proyeccion)
        {
            Proyecciones.Add(proyeccion);
            SaveChanges();
        }
        public void agregarSala(Sala sala)
        {
           Salas.Add(sala);
            SaveChanges();
        }
        public void agregarEntrada(Entrada entrada)
        {
          Entradas.Add(entrada);
            SaveChanges();
        }
        public List<Genero> obtenerGeneros() => Generos.ToList();
        public List<Pelicula> obtenerPeliculas()
        {
            return Peliculas
                   .Include(pelicula => pelicula.Genero)
                   .ToList();
        }
        public List<Sala> obtenerSalas() => Salas.ToList();
        public List<Proyeccion>obtenerProyecciones()
        {
            return Proyecciones
                  .Include(proyecciones => proyecciones.Sala)
                  .ToList();
        }
        public List<Entrada>entradasde(Proyeccion proyeccion)
        {
            return Entradas
                .Where(entrada => entrada.Proyeccion == proyeccion)
                .ToList();
        }
    }
        

}

