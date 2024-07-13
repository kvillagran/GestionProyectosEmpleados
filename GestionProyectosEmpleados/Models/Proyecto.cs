using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace GestionProyectosEmpleados.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; } = string.Empty; // Inicializar con un valor por defecto

        public string Descripcion { get; set; } = string.Empty; // Inicializar con un valor por defecto

        [Required]
        public DateTime FechaInicio { get; set; }

        public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>(); // Inicializar con una lista vacía
    }
}
