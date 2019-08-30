using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Pelicula")]
    public class Pelicula
    {
        [Key]
        [Column("idPelicula")]
        public short Id{ get; set; }
        [Column("Nombre")]
        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }
        [Column("Fecha de Lanzamiento")]
        [Required]
        public DateTime Lanzamiento { get; set; }
        [Column("Genero")]
        [Required]
        public Genero Genero { get; set; }

    }
}
