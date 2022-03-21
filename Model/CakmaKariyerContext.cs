public class CakmaKariyerContext : DbContext
{
    DbSet <Account>? Accounts { get; set; }
    DbSet <Role>? roles { get; set; }
    DbSet <AccountEmployerDetail>? AccountEmployerDetails { get; set; }
    DbSet <AccountStudentDetail>? AccountStudentDetails { get; set; }
    DbSet <Sector>? Sectors { get; set; }
    DbSet <Department>? Departments { get; set; }
    DbSet <Position>? Positions { get; set; }
    DbSet <JobAdvertisement>? JobAdvertisements { get; set; }
    DbSet <JobAdvertisementDetail>? jobAdvertisementDetails { get; set; }
    DbSet <Department_Sector>? Department_Sectors { get; set; }
    DbSet <Position_Department>? Position_Departments { get; set; }
    DbSet <Account_Role>? Account_Role { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=CakmaKariyer;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        JobPostingCategoryDatebaseBuilder.TableBuilder(modelBuilder);
        JobAdvertisementDatabaseBuilder.TableBuilder(modelBuilder);

    }

}