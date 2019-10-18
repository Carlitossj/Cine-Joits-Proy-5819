using NETCore.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;



namespace CineJoits1958
{
   [Table("Cajero")]
    public class Cajero
    {
        [DatabaseGenerated (DatabaseGeneratedOption.None)]
        [Key]
        [Column("Dni")]
        public int   dni { get; set; }
        [Column("Nombre")]
        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }
        [Column("Apellido")]
        [Required]
        [StringLength(45)]
        public string Apellido { get; set; }
        [Column("Email")]
        [Required]
        [StringLength(45)]
        public string Email { get; set; }
        [Column("Contraseña")]
        [Required]
        [StringLength(45)]
        public string Contraseña { get; set; }
        [NotMapped]
        public string NombreCompleto => $"{Apellido}, {Nombre}";
        public Cajero() { }

    }
}
