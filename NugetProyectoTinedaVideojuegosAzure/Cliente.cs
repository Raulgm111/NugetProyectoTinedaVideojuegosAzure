﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetProyectoTinedaVideojuegosAzure
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("IDCLIENTE")]
        public int IdCliente { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("APELLIDOS")]
        public string Apellidos { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("ROLE")]
        public string? Role { get; set; }
        [Column("SALT")]
        public string Salt { get; set; }
        [Column("IMAGEN")]
        public string? Imagen { get; set; }
        [Column("CONTRASEÑA")]
        public byte[] Contraseña { get; set; }
    }
}
