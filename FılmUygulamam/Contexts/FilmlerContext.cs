using System;
using System.Collections.Generic;
using FılmUygulamam.Entities;
using Microsoft.EntityFrameworkCore;

namespace FılmUygulamam.Contexts;

public partial class FilmlerContext : DbContext
{
    public FilmlerContext()
    {
    }

    public FilmlerContext(DbContextOptions<FilmlerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Film> Filmler { get; set; }

    public virtual DbSet<Tur> Turler { get; set; }

    public virtual DbSet<Yonetmen> Yonetmenler { get; set; }

    public DbSet<FilmDetay> FilmDetay { get; set; }
    public DbSet<FılmTur> FılmTur { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-80VGNQA\\SQLEXPRESS;Database=Filmler;user id=sa;password=sa;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FılmTur>().HasKey(FılmTur => new { FılmTur.FilmId, FılmTur.TurId });
        modelBuilder.Entity<Film>().ToTable(nameof(Film));
        modelBuilder.Entity<Tur>().ToTable(nameof(Tur));
        modelBuilder.Entity<Yonetmen>().ToTable(nameof(Yonetmen)); 
        modelBuilder.Entity<FılmTur>().ToTable(nameof(FılmTur));
        modelBuilder.Entity<FilmDetay>().ToTable(nameof(FilmDetay));
    }
}