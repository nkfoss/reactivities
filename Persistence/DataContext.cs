using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    // Datacontext derives from class DbContext
        public class DataContext : DbContext
    {
        // Our constructor uses the base(options), which means it will pass the options into the constructor of
        // class that it derives from (DbContext)
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        // Here we are essentially referring to the database table, title Activities.
        public DbSet<Activity> Activities { get; set; }
    }
}

// When we want to create a database based on the code we have, we use a 'migration'.
// DbSet creates a table in the DB called "Activities" (or whatever the property name is)
// The columns inside the table are based on the generic class <Activity> properties.
// ... naming property 'Id' (special name) will be used as the primary key in the table.