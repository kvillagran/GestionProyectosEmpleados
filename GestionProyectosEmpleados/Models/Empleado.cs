using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionProyectosEmpleados.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty; // Inicializar con un valor por defecto

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty; // Inicializar con un valor por defecto

        [Required]
        public DateTime FechaContratacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Puesto { get; set; } = string.Empty; // Inicializar con un valor por defecto

        public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>(); // Inicializar con una lista vacía
    }
}
