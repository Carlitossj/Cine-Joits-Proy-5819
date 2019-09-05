using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CineJoits1958
{
    [Table("Genero")]
    public class Genero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idGenero")]
        public  short Id { get; set; }
        [Column("Genero")]
        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }
    }
}
