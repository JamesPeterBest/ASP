using Microsoft.EntityFrameworkCore;

namespace datingapp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}         
        
    }
}