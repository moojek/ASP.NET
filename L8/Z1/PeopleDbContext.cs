using Microsoft.EntityFrameworkCore;
using Z1.Model;

namespace Z1;

public class PeopleDbContext(DbContextOptions<PeopleDbContext> options) : DbContext(options)
{
    public DbSet<Person> People => Set<Person>();
}