namespace Vehycles
{
	using Vehycles.Data;
	using Vehycle.Data.Models;
	using Vehycles.Services;
	using Vehycles.Services.Interfaces;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
				?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services.AddDbContext<VehyclePlatformDbContext>(options =>
				options.UseSqlServer(connectionString));

			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
			{
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.SignIn.RequireConfirmedAccount = false;
            })
			.AddEntityFrameworkStores<VehyclePlatformDbContext>()
			.AddDefaultTokenProviders()
			.AddRoles<ApplicationRole>();

			builder.Services.AddTransient<IVehycleService, VehycleService>();
			builder.Services.AddTransient<ICategoryService, CategoryService>();
			builder.Services.AddTransient<ISearchService, SearchService>();
			builder.Services.AddTransient<IUserService, UserService>();
			builder.Services.AddTransient<IAdService, AdService>();

			builder.Services.AddResponseCaching();
			builder.Services.ConfigureApplicationCookie(cfg =>
			{
				cfg.LoginPath = "/User/Login";
				cfg.AccessDeniedPath = "/Home/Error/401";
			});

			builder.Services.AddControllersWithViews();

			WebApplication app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(config =>
			{



			});

			app.MapDefaultControllerRoute();

			app.MapRazorPages();

			app.Run();
		}
	}
}
