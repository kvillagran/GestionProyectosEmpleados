using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProyectosEmpleados.Models
{
    public class Asignacion
    {
        public int AsignacionId { get; set; }

        [Required(ErrorMessage = "La fecha de asignación es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime FechaAsignacion { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio.")]
        [StringLength(100, ErrorMessage = "El rol no puede exceder los 100 caracteres.")]
        public string Rol { get; set; } = string.Empty;

        [ForeignKey("Empleado")]
        public int? EmpleadoId { get; set; }
        public Empleado? Empleado { get; set; }

        [ForeignKey("Proyecto")]
        public int? ProyectoId { get; set; }
        public Proyecto? Proyecto { get; set; }
    }
}
