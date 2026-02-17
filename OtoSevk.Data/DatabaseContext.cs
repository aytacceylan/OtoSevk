using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OtoSevk.Entities;
using System.Security.Cryptography;

namespace OtoSevk.Data
{
	public class DatabaseContext : DbContext

	{
		public DbSet<Arac> Araclar { get; set; }
		public DbSet<Surucu> Suruculer { get; set; }
		public DbSet<Marka> Markalar { get; set; }
		public DbSet<AracKomutani> AracKomutanilar { get; set; }
		public DbSet<Rol> Roller { get; set; }		
		public DbSet<Sevk> Sevkler { get; set; }
		public DbSet<Servis> Servisler { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=(LocalDB)\MSSQLLocalDB;database=OtoSevkNetCore; integrated security=true; TrustServerSertificate=true;");

			optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));

			base.OnConfiguring(optionsBuilder);

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		//Fluent API
		modelBuilder.Entity<Marka>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
		modelBuilder.Entity<Rol>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
		modelBuilder.Entity<Rol>().HasData(new Rol
		{
			Id = 1,
			Adi = "Admin"
		});
		modelBuilder.Entity<Surucu>().HasData(new Surucu
		{
			Id = 1,
			Adi = "Admin",
			AktifMi = true,
			EklenmeTarihi = DateTime.Now,
			Email = "admin@OtoSevk.tc",
			SurucuAdi = "admin",
			Sifre = "123456",
			RolId =1,
			Soyadi = "admin",
			Telefon = "850",

		});

		base.OnModelCreating(modelBuilder);

		}
	
	}
}
