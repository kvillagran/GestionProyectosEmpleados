using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionProyectosEmpleados.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede tener más de 100 caracteres.")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de contratación es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha no válido.")]
        public DateTime FechaContratacion { get; set; }

        [Required(ErrorMessage = "El puesto es obligatorio.")]
        [StringLength(100, ErrorMessage = "El puesto no puede tener más de 100 caracteres.")]
        public string Puesto { get; set; } = string.Empty;

        public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>();
    }
}
