using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Proyeccion")]
    class Proyeccion
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
        public void VenderEntrada()
        {

        }

    }

}
