
using Microsoft.EntityFrameworkCore;
using DotNetEnv;

public class WasteCollectionDbContext : DbContext
{
    public DbSet<Municipality> Municipalities => Set<Municipality>();

    public DbSet<WasteCollectionSite> WasteCollectionSites => Set<WasteCollectionSite>();

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<SiteTranslation> SiteTranslations => Set<SiteTranslation>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Env.Load();

        string connectionString =
            Environment.GetEnvironmentVariable("NABLUS_DB_CONNECTION");

        optionsBuilder.UseNpgsql(connectionString);
    }


protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Municipality>().HasData(
        new Municipality
        {
            Id = 1,
            Name = "Nablus Municipality"
        }
    );

    modelBuilder.Entity<WasteCollectionSite>().HasData(
        new WasteCollectionSite { Id = 1, MunicipalityId = 1 },
        new WasteCollectionSite { Id = 2, MunicipalityId = 1 },
        new WasteCollectionSite { Id = 3, MunicipalityId = 1 }
    );

    modelBuilder.Entity<Employee>().HasData(
        new Employee { Id = 1, FullName = "Ahmad Saleh", SiteId = 1 },
        new Employee { Id = 2, FullName = "Omar Nasser", SiteId = 2 },
        new Employee { Id = 3, FullName = "Khaled Hamdan", SiteId = 3 }
    );

    modelBuilder.Entity<Language>().HasData(
        new Language { Id = 1, Code = "en", Name = "English" },
        new Language { Id = 2, Code = "ar", Name = "Arabic" }
    );

    modelBuilder.Entity<SiteTranslation>().HasData(
        new SiteTranslation
        {
            SiteId = 1,
            LanguageId = 1,
            Name = "Rafidia Site"
        },
        new SiteTranslation
        {
            SiteId = 1,
            LanguageId = 2,
            Name = "موقع رفيديا"
        },
        new SiteTranslation
        {
            SiteId = 2,
            LanguageId = 1,
            Name = "Al-Makhfia Site"
        },
        new SiteTranslation
        {
            SiteId = 2,
            LanguageId = 2,
            Name = "موقع المخفية"
        },
        new SiteTranslation
        {
            SiteId = 3,
            LanguageId = 1,
            Name = "Al-Jnaid Site"
        },
        new SiteTranslation
        {
            SiteId = 3,
            LanguageId = 2,
            Name = "موقع الجنيد"
        }
    );
}
}

