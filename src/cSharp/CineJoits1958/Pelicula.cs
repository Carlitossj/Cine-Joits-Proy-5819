using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace CineJoits1958
{
    [Table("Pelicula")]
    public class Pelicula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("idGenero")]
        [Required]
        public Genero Genero { get; set; }
        public List<Proyeccion> Proyecciones { get; set; }
       
        public void AgregarProyeccion (Proyeccion proyeccion)
        {
            Proyecciones.Add(proyeccion);
        }
        public int EntradasVenidasentre(DateTime inicio, DateTime fin)
        {
            return Proyecciones.Sum(p => p.EntradasVenidasentre(inicio,fin));
        }
    }
}
