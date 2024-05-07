

using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{

    public DbSet<Product> Tbl_Product { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=eiger.liara.cloud,31508;Initial Catalog=myDB;User Id=sa;Password=z5Y0vidaGciDckNqm7xRmgCB;MultipleActiveResultSets=true;TrustServerCertificate=true");

    }
    
}