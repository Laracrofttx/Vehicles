using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vehycles.Data
{
	public class VehycleDbContext : IdentityDbContext
	{
		public VehycleDbContext(DbContextOptions<VehycleDbContext> options)
			: base(options)
		{
		}
	}
}
