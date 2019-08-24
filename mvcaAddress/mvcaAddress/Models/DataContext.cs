

namespace mvcaAddress.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext    
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcaAddress.Models.Book> Books { get; set; }
    }
}