using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [Key]
        [Column("idProyeccion")]
        public short id { get; set; }
        [Column("Horario")]
        [Required]
        public DateTime FechaHora { get; set; }
        [Column("Pelicula")]
        [Required]
        public Pelicula Pelicula { get; set; }
        [Column("Sala")]
        [Required]
        public Sala Sala { get; set; }
        [Column("Precio")]
        [Required]
        public float Precio { get; set; }
        public List<Entrada>EntradasVendidas { get; set; }
        public void VenderEntrada()
        {
            Entrada vendida = new Entrada(this);
           EntradasVendidas.Add(vendida);
        }

    }

}
