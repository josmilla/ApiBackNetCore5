﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIClient.Infrastructure.Data.Entities
{
    public partial class Periodo


    {
        //public Periodo()
        //{
        //    Carga = new HashSet<Carga>();
        //}

        [Key]
        public int IdPeriodo { get; set; }
        public string Periodo1 { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool? Estado { get; set; }

        //public ICollection<Carga> Carga { get; set; }



    }
}