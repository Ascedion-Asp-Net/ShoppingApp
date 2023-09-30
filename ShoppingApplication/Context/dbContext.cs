using Microsoft.EntityFrameworkCore;

namespace ShoppingApplication.Context
{

    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
