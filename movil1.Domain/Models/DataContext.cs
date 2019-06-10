namespace movil1.Domain.Models
{
    using System.Data.Entity;
    
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<movil1.Common.Models.Aliment> Aliments { get; set; }
    }
}
