using System.Diagnostics.Contracts;
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

        builder.Entity<Contrato>()
            .HasOne(c => c.Persona)
            .WithMany()
            .HasForeignKey(c => c.PersonaId)
            .OnDelete(DeleteBehavior.Cascade); 

        builder.Entity<ProcesoVinculado>()
            .HasOne(pv => pv.Persona)
            .WithMany()
            .HasForeignKey(pv => pv.PersonaId)
            .OnDelete(DeleteBehavior.Restrict); 

        builder.Entity<ProcesoVinculado>()
            .HasOne(pv => pv.Contrato)
            .WithMany()
            .HasForeignKey(pv => pv.ContratoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Aprobacion>()
            .HasOne(a => a.Persona)
            .WithMany()
            .HasForeignKey(a => a.PersonaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Aprobacion>()
            .HasOne(a => a.ProcesoVinculado)
            .WithMany()
            .HasForeignKey(a => a.ProcesoVinculadoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Documento>()
            .HasOne(d => d.Persona)
            .WithMany()
            .HasForeignKey(d => d.PersonaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Documento>()
            .HasOne(d => d.ProcesoVinculado)
            .WithMany()
            .HasForeignKey(d => d.ProcesoVinculadoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Notificacion>()
            .HasOne(n => n.Persona)
            .WithMany()
            .HasForeignKey(n => n.PersonaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Notificacion>()
            .HasOne(n => n.ProcesoVinculado)
            .WithMany()
            .HasForeignKey(n => n.ProcesoVinculadoId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Persona>()
            .Property(p => p.Telefono)
            .HasColumnType("decimal(18,2)");

        builder.Entity<ProcesoVinculado>()
            .Property(pv => pv.Valor)
            .HasColumnType("decimal(18,2)");
    }
}