using Microsoft.EntityFrameworkCore;

namespace GestionProyectosEmpleados.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asignacion>()
                .HasKey(a => a.AsignacionId);

            modelBuilder.Entity<Asignacion>()
                .HasOne(a => a.Empleado)
                .WithMany(e => e.Asignaciones)
                .HasForeignKey(a => a.EmpleadoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Asignacion>()
                .HasOne(a => a.Proyecto)
                .WithMany(p => p.Asignaciones)
                .HasForeignKey(a => a.ProyectoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
