namespace movil1.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<movil1.Common.Models.Aliment> Aliments { get; set; }
    }
}