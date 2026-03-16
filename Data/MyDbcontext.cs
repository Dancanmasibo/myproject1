using Microsoft.EntityFrameworkCore;

namespace myproject1.Data
{
    public class MyDbcontex:DbContext
    {
        public MyDbcontex(DbContextOptions<MyDbcontex> options) : base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
