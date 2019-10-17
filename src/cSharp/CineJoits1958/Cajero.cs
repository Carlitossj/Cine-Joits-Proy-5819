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
        public string Nombre { get; set; }
        [Column("Apellido")]
        [Required]
        public string Apellido { get; set; }
        [Column("Email")]
        [Required]
        public string Email { get; set; }
        [Column("Contraseña")]
        [Required]
        public string Contraseña { get; set; }
        public Cajero() { }

    }
}
