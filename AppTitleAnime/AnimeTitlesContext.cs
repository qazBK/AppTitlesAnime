using System;
using System.Collections.Generic;
using AppTitleAnime.Models_2;
using Microsoft.EntityFrameworkCore;
using Type = AppTitleAnime.Models_2.Type;

namespace AppTitleAnime;

public partial class AnimeTitlesContext : DbContext
{
    public AnimeTitlesContext()
    {
    }

    public AnimeTitlesContext(DbContextOptions<AnimeTitlesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnimeTitle> AnimeTitles { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Studio> Studios { get; set; }

    public virtual DbSet<TitlesGenre> TitlesGenres { get; set; }

    public virtual DbSet<TitlesStatus> TitlesStatuses { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
 */       => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=anime_titles;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimeTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("anime_titles_pkey");

            entity.ToTable("anime_titles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountSeries).HasColumnName("count_series");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.IdStudio).HasColumnName("id_studio");
            entity.Property(e => e.IdType).HasColumnName("id_type");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OriginalName).HasColumnName("original_name");
            entity.Property(e => e.Poster).HasColumnName("poster");

            entity.HasOne(d => d.Studio).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdStudio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ titles_to_studio");

            entity.HasOne(d => d.Studio).WithMany(p => p.AnimeTitles)
                .HasForeignKey(d => d.IdType)
                .HasConstraintName("fk_ titles_to_types");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GenreAnime).HasColumnName("genre_anime");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusAnime).HasColumnName("status_anime");
        });

        modelBuilder.Entity<Studio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("studio_pkey");

            entity.ToTable("studios");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Studio1).HasColumnName("studio");
        });

        modelBuilder.Entity<TitlesGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("titles_genres_pkey");

            entity.ToTable("titles_genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdAnime).HasColumnName("id_anime");
            entity.Property(e => e.IdGenre).HasColumnName("id_genre");

            entity.HasOne(d => d.IdAnimeNavigation).WithMany(p => p.TitlesGenres)
                .HasForeignKey(d => d.IdAnime)
                .HasConstraintName("fk_titles_geners_to_anime_titles");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.TitlesGenres)
                .HasForeignKey(d => d.IdGenre)
                .HasConstraintName("fk_titles_geners_to_geners");
        });

        modelBuilder.Entity<TitlesStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("titles_statuses_pkey");

            entity.ToTable("titles_statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateStatus).HasColumnName("date_status");
            entity.Property(e => e.IdAnime).HasColumnName("id_anime");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");

            entity.HasOne(d => d.IdAnimeNavigation).WithMany(p => p.TitlesStatuses)
                .HasForeignKey(d => d.IdAnime)
                .HasConstraintName("fk_titles_to_anime_titles");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.TitlesStatuses)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("fk_titles_to_statuses");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("types_pkey");

            entity.ToTable("types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeAnime).HasColumnName("type_anime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
