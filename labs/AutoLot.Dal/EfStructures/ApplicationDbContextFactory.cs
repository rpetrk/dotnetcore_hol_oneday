namespace AutoLot.Dal.EfStructures;
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    //class implementation goes here
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = @"server=(localdb)\ProjectModels;Database=AutoLot;Integrated Security=True;";
        //@"server=(localdb)\MsSqlLocalDb;Database=AutoLot;Integrated Security=true";
        optionsBuilder.UseSqlServer(connectionString);
        //optionsBuilder.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
        Console.WriteLine(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}