using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace CineJoits1958
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idProyeccion")]
        public short id { get; set; }
        [Column("Horario")]
        [Required]
        public DateTime FechaHora { get; set; }
        [ForeignKey("idPelicula")]
        [Required]
        public Pelicula Pelicula { get; set; }
        [ForeignKey("idSala")]
        [Required]
        public Sala Sala { get; set; }
        [Column("Precio")]
        [Required]
        public float Precio { get; set; }
        public Proyeccion()
        {
            EntradasVendidas = new List<Entrada>();
        }

        public List<Entrada>EntradasVendidas { get; set; }
        public void VenderEntrada(Cajero cajero)
        {
            EntradasVendidas.Add(new Entrada(this,cajero));
        }
        [NotMapped]
        public int EntradasDisponibles =>Sala.Capacidad - CantidadVendidas ;
        [NotMapped]
        public int CantidadVendidas => EntradasVendidas.Count;

        public int EntradasVendidasentre(DateTime inicio, DateTime fin)
        {
            return EntradasVendidas.Count(ev => ev.Entre(inicio, fin));                                      
        }
    }
   

}
