using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace TatooBookingLibrary.Models
{
    public partial class TatooBookingContext : DbContext
    {
        public TatooBookingContext()
        {
        }

        public TatooBookingContext(DbContextOptions<TatooBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<BookingService> BookingServices { get; set; }
        public virtual DbSet<BookingTatoo> BookingTatoos { get; set; }
        public virtual DbSet<DateWorkForArtist> DateWorkForArtists { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }
        public virtual DbSet<StudioStaff> StudioStaffs { get; set; }
        public virtual DbSet<Tatoo> Tatoos { get; set; }
        public virtual DbSet<TatooCategory> TatooCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("Test"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Degree)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("degree");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.StudioId).HasColumnName("studio_id");

                entity.HasOne(d => d.Studio)
                    .WithMany(p => p.Artists)
                    .HasForeignKey(d => d.StudioId)
                    .HasConstraintName("FK__Artist__studio_i__60A75C0F");
            });

            modelBuilder.Entity<BookingService>(entity =>
            {
                entity.ToTable("BookingService");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtistId).HasColumnName("artist_id");

                entity.Property(e => e.InkDay1)
                    .HasColumnType("date")
                    .HasColumnName("ink_day_1");

                entity.Property(e => e.InkDay2)
                    .HasColumnType("date")
                    .HasColumnName("ink_day_2");

                entity.Property(e => e.InkDay3)
                    .HasColumnType("date")
                    .HasColumnName("ink_day_3");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TatooId).HasColumnName("tatoo_id");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_price");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.BookingServices)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__BookingSe__artis__72C60C4A");

                entity.HasOne(d => d.Tatoo)
                    .WithMany(p => p.BookingServices)
                    .HasForeignKey(d => d.TatooId)
                    .HasConstraintName("FK__BookingSe__tatoo__73BA3083");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.BookingServices)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK__BookingSe__users__71D1E811");
            });

            modelBuilder.Entity<BookingTatoo>(entity =>
            {
                entity.ToTable("BookingTatoo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtistId).HasColumnName("artist_id");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("date")
                    .HasColumnName("date_create");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UsersBookDate)
                    .HasColumnType("date")
                    .HasColumnName("users_book_date");

                entity.Property(e => e.UsersBookTime).HasColumnName("users_book_time");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.Property(e => e.UsersPhone)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("users_phone");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.BookingTatoos)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__BookingTa__artis__6EF57B66");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.BookingTatoos)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK__BookingTa__users__6E01572D");
            });

            modelBuilder.Entity<DateWorkForArtist>(entity =>
            {
                entity.ToTable("DateWorkForArtist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArtistId).HasColumnName("artist_id");

                entity.Property(e => e.EndWorkHour).HasColumnName("end_work_hour");

                entity.Property(e => e.StartWorkHour).HasColumnName("start_work_hour");

                entity.Property(e => e.WorkDate)
                    .HasColumnType("date")
                    .HasColumnName("work_date");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.DateWorkForArtists)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DateWorkF__artis__66603565");
            });

            modelBuilder.Entity<Studio>(entity =>
            {
                entity.ToTable("Studio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<StudioStaff>(entity =>
            {
                entity.ToTable("StudioStaff");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StudioId).HasColumnName("studio_id");

                entity.HasOne(d => d.Studio)
                    .WithMany(p => p.StudioStaffs)
                    .HasForeignKey(d => d.StudioId)
                    .HasConstraintName("FK__StudioSta__studi__6383C8BA");
            });

            modelBuilder.Entity<Tatoo>(entity =>
            {
                entity.ToTable("Tatoo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Img)
                    .HasColumnType("image")
                    .HasColumnName("img");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TatooDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tatoo_description");

                entity.Property(e => e.TatooName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tatoo_name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tatoos)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Tatoo__category___6B24EA82");
            });

            modelBuilder.Entity<TatooCategory>(entity =>
            {
                entity.ToTable("TatooCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
