using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CineJoits1958
{
    [Table("Sala")]
    class Sala
    {
        [Key]
        [Column("idSala")]
        public byte id { get; set; }
        [Column("Capacidad")]
        [Required]
        public short Capacidad { get; set; }
        [Column("Piso")]
        [Required]
        public byte Piso { get; set; }

    }
}
