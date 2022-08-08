using Microsoft.EntityFrameworkCore;
using PracticID.Models;

namespace PracticID.Data
{
	public class DbPersonContext : DbContext
	{
		public DbPersonContext(DbContextOptions<DbPersonContext> options) : base(options) { }

		public DbSet<Person> Person { get; set; } = default!;
	}
}
