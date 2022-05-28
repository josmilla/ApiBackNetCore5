﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIClient.Infrastructure.Data.Entities
{
    public partial class CargaSiga
    {
        [Key]
        public int IdCarga { get; set; }
        public string NombreCal { get; set; }
        public string MatriculaCal { get; set; }
        public string NombreChapter { get; set; }
        public string MatriculaChapter { get; set; }
        public string TipoPreper { get; set; }
        public string Empresa { get; set; }
        public string MatriculaUsuario { get; set; }
        public string ApellidopaternoUsuario { get; set; }
        public string ApellidomaternoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string RolInsourcing { get; set; }
        public string Especialidad { get; set; }
        public string ChapterUo { get; set; }
        public double? Asignacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCarga { get; set; }
        public string FechaPeriodo { get; set; }

        //[JsonIgnore]
    }
}