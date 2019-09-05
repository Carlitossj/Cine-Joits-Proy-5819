﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace CineJoits1958
{
    [Table("Proyeccion")]
    public class Proyeccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("idProyeccion")]
        public short id { get; set; }
        [Column("Horario")]
        [Required]
        public DateTime FechaHora { get; set; }
        [ForeignKey("idPelicula")]
        [Required]
        public Pelicula Pelicula { get; set; }
        [ForeignKey("idSala")]
        [Required]
        public Sala Sala { get; set; }
        [Column("Precio")]
        [Required]
        public float Precio { get; set; }

        public List<Entrada>EntradasVendidas { get; set; }
        public void VenderEntrada()
        {
            EntradasVendidas.Add(new Entrada(this));
        }
        [NotMapped]
        public int EntradasDisponibles =>Sala.Capacidad - EntradasVendidas.Count ;
        public int EntradasVenidasentre(DateTime inicio, DateTime fin)
        {
            return EntradasVendidas.Count(ev => ev.Entre(inicio, fin));                                      
        }
    }
   

}