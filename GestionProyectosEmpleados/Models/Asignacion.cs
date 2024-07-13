using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProyectosEmpleados.Models
{
    public class Asignacion
    {
        public int AsignacionId { get; set; }

        [Required]
        public DateTime FechaAsignacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Rol { get; set; } = string.Empty; // Inicializar con un valor por defecto

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; } = null!; // Usar 'null!' para inicializar como no nulo

        [ForeignKey("Proyecto")]
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; } = null!; // Usar 'null!' para inicializar como no nulo
    }
}
