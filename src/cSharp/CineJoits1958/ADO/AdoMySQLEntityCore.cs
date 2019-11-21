using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CineJoits1958.ADO
{
    public class AdoMySQLEntityCore : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Proyeccion> Proyecciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Cajero> Cajeros { get; set; }
       
        public AdoMySQLEntityCore() : base() { }

        internal AdoMySQLEntityCore(DbContextOptions dbo) : base(dbo) { }
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
        public void agregarCajero(Cajero cajero)
        {
            Cajeros.Add(cajero);
            SaveChanges();
        }
        public void actualizarPelicula(Pelicula pelicula)
        {
            this.Update<Pelicula>(pelicula);
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
                  .Include(p => p.Sala)
                  .Include(p=>p.Pelicula)
                  .ToList();
        }
        public List<Entrada>obtenerEntradas(Proyeccion proyeccion)
        {
            return Entradas
                .Where(entrada => entrada.Proyeccion == proyeccion)
                .Include(entrada => entrada.Cajero)
                .ToList();
        }
        public void actualizarEntrada(Entrada entrada)
        {
            this.Update<Entrada>(entrada);
            SaveChanges();

        }
        public List<Cajero> obtenerCajeros() =>Cajeros.ToList();
        public Cajero cajeroPorDniPass(int dni, string passEncriptada)
           => Cajeros.FirstOrDefault(c => c.dni == dni && c.Contraseña == passEncriptada);

    }
        

}

