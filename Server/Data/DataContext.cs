using BlazorBasicSqlServer.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorBasicSqlServer.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }        
        public DbSet<Alunos> TblTeste3 => Set<Alunos>();
    }
}