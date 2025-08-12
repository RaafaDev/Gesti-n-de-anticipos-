using System.Security.Cryptography;
using GestionAnticiposApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestionAnticiposApp.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Persona> Personas { get; set; }
    public DbSet<Aprobacion> Aprobaciones { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Contrato> Contratos { get; set; }
    public DbSet<ProcesoVinculado> ProcesosVinculados { get; set; }
    public DbSet<Documento> Documentos { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasOne(u => u.Persona)
            .WithMany()
            .HasForeignKey(u => u.PersonaId)
            .OnDelete(DeleteBehavior.Restrict);


        builder.Entity<Persona>().ToTable("Personas");
        builder.Entity<Aprobacion>().ToTable("Aprobaciones");
        builder.Entity<Notificacion>().ToTable("Notificaciones");
        builder.Entity<Contrato>().ToTable("Contratos");
        builder.Entity<ProcesoVinculado>().ToTable("ProcesosVinculados");
        builder.Entity<Documento>().ToTable("Documento");

    }
}
