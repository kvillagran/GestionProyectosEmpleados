using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionProyectosEmpleados.Models
{
    public class Proyecto
    {
        public int ProyectoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "La descripción no puede tener más de 500 caracteres.")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "Formato de fecha no válido.")]
        public DateTime FechaInicio { get; set; }

        public ICollection<Asignacion> Asignaciones { get; set; } = new List<Asignacion>();
    }
}
