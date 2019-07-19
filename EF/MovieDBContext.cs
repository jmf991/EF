using System.Data.Entity;

public class MovieDBContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
}