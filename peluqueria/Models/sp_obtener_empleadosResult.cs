﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace peluqueria.Models
{
    public partial class sp_obtener_empleadosResult
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public DateOnly? fecha_contratacion { get; set; }
    }
}
