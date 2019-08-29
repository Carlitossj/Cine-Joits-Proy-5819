using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Entrada")]
    class Entrada
    {
        [Key]
        [Column("idEntrada")]
        public int Id { get; set; }
        [Column("Proyeccion")]
        [Required]
        public Proyeccion Proyeccion { get; set; }
        [Column("Valor")]
        [Required]
        public float Valor { get; set; }


    }
}
