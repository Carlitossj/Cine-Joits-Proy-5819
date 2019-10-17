using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Entrada")]
    public class Entrada
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idEntrada")]
        public int Id { get; set; }
        [ForeignKey("idProyección"), Required]  
        public Proyeccion Proyeccion { get; set; }
        [Column("Valor")]
        [Required]
        public float Valor { get; set; }
        [Column("FechaHora")]
        [Required]
        public DateTime FechaHora { get; set; }
        [ForeignKey("Cajero"), Required]

        public Cajero Cajero { get; set; }
        public Entrada() { }

        public Entrada(Proyeccion proyeccion)
        {
            Proyeccion = proyeccion;
            Valor = proyeccion.Precio;
        }
         public bool Entre (DateTime Inicio,DateTime fin)
         {
            return Inicio <=FechaHora && FechaHora <= fin;
         }

        public bool Entre()
        {
            throw new NotImplementedException();
        }
    }
}
