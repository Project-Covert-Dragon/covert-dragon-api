using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design; 

namespace Covert.Dragon.Data;
public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
{
public StoreContext CreateDbContext(string[] args) 
     {
var optionsBuilder = new DbContextOptionsBuilder<StoreContext>( );

optionsBuilder.UseSqlite ("Data Source= Registrar.sqlite"); 

return new StoreContext (optionsBuilder.Options);
     }
}